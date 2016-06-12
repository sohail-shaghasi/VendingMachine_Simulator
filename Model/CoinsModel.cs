using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace VendingMachine_SD.Model
{
    public class CoinsModel
    {
        public string NumberOf10cCoins { get; set; }
        public string NumberOf20cCoins { get; set; }
        public string NumberOf50cCoins { get; set; }
        public int getCoinsCount(double coinsDenomination)
        {
            //logic to connect to database and retrieve the data.
            if (coinsDenomination == 0.1)
            {
                return 150;
            }
            else if (coinsDenomination == 0.2)
            {
                return 130;
            }
            else
            {
                return 110;
            }
        }

        //to update the brands from maintainers perspective.
        public void updateCoinsCount()
        {
           
          string  sqlStatement = "Update [VendingMachine_SD].[dbo].[CoinsStorage] SET [Count] = CASE id WHEN 1 THEN" +
                            " " + NumberOf10cCoins + " " + "WHEN 2 THEN" + " " + NumberOf20cCoins + " " + "WHEN 3 THEN" +
                            " " + NumberOf50cCoins + " " + "END WHERE id IN (1, 2, 3)";

            string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sqlStatement, cnn))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// This function will update the prices fro every brand. 
        /// </summary>
        public void CollectTotalCashHeldByMachine()
        {
            string connetionString = null;
            string sqlStatement = "  UPDATE [VendingMachine_SD].[dbo].CoinsStorage SET [VendingMachine_SD].[dbo].CoinsStorage.[Count] = CASE Id WHEN 1 THEN 0 WHEN 2 THEN 0 WHEN 3 THEN 0 END WHERE Id IN (1,2,3)";
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sqlStatement, cnn))
                {
                    sqlCommand.ExecuteNonQuery();
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

        /// <summary>
        /// This function returns the total cash held by the machine.
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalCashHeldByMachine()
        {
            //decimal TotalAmount;
            string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connetionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ReturnSumOfAmount";
                var returnParameter = cmd.Parameters.Add("@RESULT", SqlDbType.Decimal);
                returnParameter.Precision = 8;
                returnParameter.Scale = 2;
                returnParameter.Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                var result = returnParameter.Value;
                return (decimal)result;
            }
            //return TotalAmount;
        }

        //update the price of the product 
        public void UpdateProductPrice(int product, string price)
        {
            double finalPrice = Convert.ToDouble(price);

            string connetionString = null;
            string sqlStatement = "  Update [VendingMachine_SD].[dbo].[DrinksStorage] SET Price = "+ finalPrice +" WHERE Id =" + product;
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sqlStatement, cnn))
                {
                    sqlCommand.ExecuteNonQuery();
                }
                cnn.Close();
            }


        }

        public void GetDenominationCount()
        {
            //logic to retrieve from DB
            string connetionString = null;
            string sqlStatement = "SELECT [Denomination] ,[Count] FROM [VendingMachine_SD].[dbo].[CoinsStorage]";
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sqlStatement, cnn))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["Denomination"].ToString() == "10Cent")
                        {
                            NumberOf10cCoins = reader["Count"].ToString();
                        }
                        else if (reader["Denomination"].ToString() == "20Cent")
                        {
                            NumberOf20cCoins = reader["Count"].ToString();
                        }
                        else if (reader["Denomination"].ToString() == "50Cent")
                        {
                            NumberOf50cCoins = reader["Count"].ToString();
                        }

                    }
                }
            }
                              
        }

    }
}
