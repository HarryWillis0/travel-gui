using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// Some validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Test if string is empty or not
        /// </summary>
        /// <param name="text">String to test</param>
        /// <returns>true if non-empty, false otherwise</returns>
        /// @author Harry
        public static bool IsPresent(string text)
        {
            return text != "";
        }

        /// <summary>
        /// Test if string is valid date or not
        /// </summary>
        /// <param name="text">String to test</param>
        /// <returns>True if valid date, false otherwise</returns>
        /// @author Harry
        public static bool IsValidDate(string text)
        {
            DateTime result;
            return DateTime.TryParse(text, out result);
        }

        /// <summary>
        /// Test if a date is after another date
        /// </summary>
        /// <param name="start"></param>
        /// <param name="date"></param>
        /// <returns>
        /// true if start and / or date are null
        /// true if date is after start
        /// false otherwise
        /// </returns>
        /// @author Harry
        public static bool IsLater(DateTime? start, DateTime? date)
        {
            if (start == null && date == null) // both null
            {
                return true;
            } 
            else if (start == null || date == null) // only one null
            {
                return true;
            }

            // both non-null here
            return DateTime.Compare((DateTime)start, (DateTime)date) < 0; 
        }

        public static bool IsValidSupplierId(string supplierId, out string error)
        {
            // supplier id required
            if (string.IsNullOrEmpty(supplierId))
            {
                error = "Supplier ID is required.";
                return false;
            }
            // supplier id must be number
            if (!Int32.TryParse(supplierId, out int result))
            {
                error = "Supplier ID must be a number.";
                return false;
            }
            error = "";
            return true;
        }
    }
}
