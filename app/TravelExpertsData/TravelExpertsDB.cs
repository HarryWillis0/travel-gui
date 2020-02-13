using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// Connect to TravelExperts DB
    /// </summary>
    /// @author Harry
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection() 
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";

            return new SqlConnection(connectionString);
        }
    }
}
