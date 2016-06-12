using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VendingMachine_SD.Model;

namespace VendingMachine_SD.Controller
{
    public class DrinksSelector_Controller
    {
        public int DrinksBrand { get; set; }
        public bool IsBrandAvailable()
        {
            DrinksModel drinksModel = new DrinksModel();
            drinksModel.getdrinkCount(DrinksBrand);
            //Mockup return value START
            if (DrinksBrand == 1)
            {
                //logic to retrieve from DB
                string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [DrinkCount] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE [DrinkBrand] = 'Brand1'", cnn))
                    {
                        // cnn.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int i = 0;
                                i = Convert.ToInt32(reader["DrinkCount"]);
                                if (i >0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else if (DrinksBrand == 2)
            {
                //logic to retrieve from DB
                string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [DrinkCount] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE [DrinkBrand] = 'Brand2'", cnn))
                    {
                        // cnn.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int i = 0;
                                i = Convert.ToInt32(reader["DrinkCount"]);
                                if (i > 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else if (DrinksBrand == 3)
            {
                //logic to retrieve from DB
                string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [DrinkCount] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE [DrinkBrand] = 'Brand3'", cnn))
                    {
                        // cnn.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int i = 0;
                                i = Convert.ToInt32(reader["DrinkCount"]);
                                if (i > 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            else if (DrinksBrand == 4)
            {
                //logic to retrieve from DB
                string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [DrinkCount] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE [DrinkBrand] = 'Brand4'", cnn))
                    {
                        // cnn.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int i = 0;
                                i = Convert.ToInt32(reader["DrinkCount"]);
                                if (i > 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            else if (DrinksBrand == 5)
            {
                //logic to retrieve from DB
                string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [DrinkCount] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE [DrinkBrand] = 'Brand5'", cnn))
                    {
                        // cnn.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int i = 0;
                                i = Convert.ToInt32(reader["DrinkCount"]);
                                if (i > 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }

        }
    }
}
