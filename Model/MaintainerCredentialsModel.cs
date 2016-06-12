using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace VendingMachine_SD.Model
{
    class MaintainerCredentialsModel
    {
        public int password { get; set; }
        //get the maintainer password from database.
        public bool getMaintainerPass(string password)
        {
            //logic to retrieve from DB
            string connetionString = null;
            int userCount;
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT count(*) FROM Maintainer WHERE Pass = @password", cnn))
                {
                    sqlCommand.Parameters.AddWithValue("@password", password);
                    userCount = (int)sqlCommand.ExecuteScalar();
                    if (userCount == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public int getDenominationCount(string denomination)
        {
            //logic to retrieve from DB
            string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT [Count] FROM [VendingMachine_SD].[dbo].[CoinsStorage] where Denomination = @Denomination", cnn))
                {
                    sqlCommand.Parameters.AddWithValue("@Denomination", denomination);
                    // cnn.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                        return 0;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}