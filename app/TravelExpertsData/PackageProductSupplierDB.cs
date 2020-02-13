using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// Operations on Packages Products Suppliers table of TravelExperts DB
    /// </summary>
    /// @author Harry 
    public static class PackageProductSupplierDB
    {
        /// <summary>
        /// Add a new package product supplier to DB
        /// </summary>
        /// <param name="newPkgProdSupp">new item to add</param>
        /// <returns>true if successful, false otherwise</returns>
        public static bool AddNewPkgProdSupp(PackageProductSupplier newPkgProdSupp)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlTransaction addNewPkgProdSupp;
                int rowsAffected;

                string insert = "INSERT INTO Packages_Products_Suppliers (PackageId, ProductSupplierId) " +
                                "VALUES (@PackageId, @ProductSupplierId)";

                // start transaction
                addNewPkgProdSupp = connection.BeginTransaction();

                // set up cmd properties
                cmd.Connection = connection;
                cmd.Transaction = addNewPkgProdSupp;
                cmd.CommandText = insert;

                // add parameters
                cmd.Parameters.AddWithValue("@PackageId", newPkgProdSupp.PackageId);
                cmd.Parameters.AddWithValue("@ProductSupplierId", newPkgProdSupp.ProductSupplierId);

                try
                {
                    // run query
                    rowsAffected = cmd.ExecuteNonQuery();

                    // insert failed
                    if (rowsAffected != 1)
                    {
                        addNewPkgProdSupp.Rollback();
                        return false;
                    }

                    // commit transaction
                    addNewPkgProdSupp.Commit();
                    return true;
                } 
                catch (Exception ex)
                {
                    throw ex;
                }
            } // close and recycle connection
        }
    }
}
