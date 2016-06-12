using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace VendingMachine_SD.Model
{
    public class DrinksModel
    {
        public double NumberOfDrinksCansBrand1 { get; set; }
        public double NumberOfDrinksCansBrand2 { get; set; }
        public double NumberOfDrinksCansBrand3 { get; set; }
        public double NumberOfDrinksCansBrand4 { get; set; }
        public double NumberOfDrinksCansBrand5 { get; set; }
        public int getdrinkCount(int drinksBrand)
        {
            //logic to connect to database and retrieve the data.
            return 1;
        }

        //to update the brands from maintainers perspective.
        public double getDrinkPrice(int drinksBrand)
        {

            //logic to retrieve from DB
            string connetionString = null;
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
               if (drinksBrand == 1)
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [Price] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE id= 1", cnn))
                    {
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                double price = 0;
                                price = Convert.ToDouble(reader["Price"]);
                                return price;
                            }
                            return 0;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else if (drinksBrand == 2)
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [Price] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE id= 2", cnn))
                    {
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                double price = 0;
                                price = Convert.ToDouble(reader["Price"]);
                                return price;
                            }
                            return 0;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else if (drinksBrand == 3)
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [Price] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE id= 3", cnn))
                    {
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                double price = 0;
                                price = Convert.ToDouble(reader["Price"]);
                                return price;
                            }
                            return 0;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else if (drinksBrand == 4)
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [Price] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE id= 4", cnn))
                    {
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                double price = 0;
                                price = Convert.ToDouble(reader["Price"]);
                                return price;
                            }
                            return 0;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else if (drinksBrand == 5)
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT [Price] FROM [VendingMachine_SD].[dbo].[DrinksStorage] WHERE id= 5", cnn))
                    {
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                double price = 0;
                                price = Convert.ToDouble(reader["Price"]);
                                return price;
                            }
                            return 0;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public void GetNumberOfEachBrandDrinksCansFromdb()
        {
            //logic to retrieve from DB
            string connetionString = null;
            string sqlStatement = "SELECT [DrinkBrand], [DrinkCount] FROM [VendingMachine_SD].[dbo].[DrinksStorage]; SELECT [Denomination] ,[Count] FROM [VendingMachine_SD].[dbo].[CoinsStorage]";
            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sqlStatement, cnn))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["DrinkBrand"].ToString() == "Brand1")
                        {
                            NumberOfDrinksCansBrand1 = Convert.ToDouble(reader["DrinkCount"]);
                        }
                        else if (reader["DrinkBrand"].ToString() == "Brand2")
                        {
                            NumberOfDrinksCansBrand2 = Convert.ToDouble(reader["DrinkCount"]);
                        }
                        else if (reader["DrinkBrand"].ToString() == "Brand3")
                        {
                            NumberOfDrinksCansBrand3 = Convert.ToDouble(reader["DrinkCount"]);
                        }
                        else if (reader["DrinkBrand"].ToString() == "Brand4")
                        {
                            NumberOfDrinksCansBrand4 = Convert.ToDouble(reader["DrinkCount"]);
                        }
                        else if (reader["DrinkBrand"].ToString() == "Brand5")
                        {
                            NumberOfDrinksCansBrand5 = Convert.ToDouble(reader["DrinkCount"]);
                        }
                    }
                   
                }
            }
        }
        public void UpdateNumberOfEachBrandDrinksCans()
        {

            string sqlstatement = "Update [VendingMachine_SD].[dbo].[DrinksStorage] SET [DrinkCount] = CASE id WHEN 1 THEN " +
                                    " " + NumberOfDrinksCansBrand1 +
                                    " " + "WHEN 2 THEN" + " " + NumberOfDrinksCansBrand2 + " " + "WHEN 3 THEN" + " " + NumberOfDrinksCansBrand3 +
                                    " " + "WHEN 4 THEN" + " " + NumberOfDrinksCansBrand4 + " " + "WHEN 5 THEN" + " " + NumberOfDrinksCansBrand5 +
                                    " " + "END WHERE id IN (1, 2, 3, 4, 5);";
            string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["CS_VendingMachine_SD"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sqlstatement, cnn))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }


        }
        
    }
}
