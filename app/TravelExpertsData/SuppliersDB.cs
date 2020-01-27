using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class SuppliersDB
    {
        /// <summary>
        /// find suppliers of certain product
        /// </summary>
        /// <param name="prodId">certain product</param>
        /// <returns>list of suppliers of certain product</returns>
        /// @author Harry
        public static List<Supplier> FindSuppliersOfProduct(int prodId)
        {
            List<Supplier> suppliers = new List<Supplier>(); // empty list
            Supplier curr;

            using (SqlConnection conn = TravelExpertsDB.GetConnection())
            {
                // query to find suppliers of product selected from combo box
                string query =
                    "SELECT Suppliers.SupplierId, SupName " +
                    "FROM Suppliers " +
                        "join Products_Suppliers " +
                            "on Products_Suppliers.SupplierId = Suppliers.SupplierId " +
                        "join Products " +
                            "on Products.ProductId = Products_Suppliers.ProductId " +
                    "WHERE Products.ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", prodId); // add parameter to query

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) // while there's still results
                        {
                            curr = new Supplier();
                            curr.SupplierId = (int)reader["SupplierId"];
                            curr.SupName = (string)reader["SupName"];
                            suppliers.Add(curr);
                        }
                    } // recycle reader
                } // recycle cmd
            } // close and recycle conn
            return suppliers;
        }
    }
}
