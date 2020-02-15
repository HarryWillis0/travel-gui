using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class ProductsDB
    {
        /// <summary>
        /// Get all products from DB
        /// </summary>
        /// <returns>List of products</returns>
        /// @author Harry
        public static List<Products> GetAllProducts()
        {
            List<Products> products = new List<Products>(); // to return 
            Products curr; // to process row in table

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // query to select all from products table
                string query = "SELECT ProductId, ProdName " +
                               "FROM Products " +
                               "ORDER BY ProductId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // run query
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) // while there are results from query
                        {
                            // process each product and add to list
                            curr = new Products();
                            curr.ProductID = (int)reader["ProductId"];
                            curr.ProductName = (string)reader["ProdName"];

                            products.Add(curr);
                        }
                    }
                    catch (Exception ex) // unanticipated errors
                    {
                        throw ex;
                    }
                } // close and recycle cmd
            } // close and recycle connection

            return products;
        }

        /// Get products
        /// Rohit
        public static Products GetProducts(int ProductID)
        {
            Products product = null;
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                //SQL query with parameter selection to extract one product data
                string query = "SELECT * FROM products WHERE productid = @productID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@productID", ProductID);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Products();
                            product.ProductID = (int)reader["productID"];
                            product.ProductName = reader["prodName"].ToString();
                        }
                    }
                }
            }
            return product;
        }

        // updating the product name in travel experts product table
        public static void ModifyProducts(string ProdName, int ProductID)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "UPDATE products SET prodName = @prodName WHERE productID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@productID", ProductID);
                    cmd.Parameters.AddWithValue("@prodName", ProdName);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Add new products method
        // Rohit
        public static void AddProducts(string ProdName)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "INSERT INTO products (ProdName) VALUES (@ProdName)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProdName", ProdName);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
