using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace travel_gui
{
    /// <summary>
    /// Processing of field inputs 
    /// </summary>
    public static class Processor
    {
        /// <summary>
        /// Process new package agency commission
        /// must be convertible to decimal or null
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public static bool ProcessPkgAgencyCommission(Package newPkg, TextBox pkgAgencyCommissionTextBox)
        {
            // for conversion from string to decimal
            decimal result;

            if (string.IsNullOrEmpty(pkgAgencyCommissionTextBox.Text))
            {
                newPkg.PkgAgencyCommission = null;
                return true;
            }

            // non empty -> must be convertible to decimal and less than the price of the package
            if (Decimal.TryParse(pkgAgencyCommissionTextBox.Text, out result) &&
                result < newPkg.PkgBasePrice)
            {
                newPkg.PkgAgencyCommission = result;
                return true;
            }
            else // invalid
                MessageBox.Show("Invalid Agency Commission.\nPlease make sure:\n\tCommission is a valid price.\n\tCommission is less than package price.", "Input Error");

            return false;
        }

        /// <summary>
        /// Process new package price
        /// must be non null and be convertible to decimal
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public static bool ProcessPkgPrice(Package newPkg, TextBox pkgBasePriceTextBox)
        {
            decimal result;
            if (!string.IsNullOrWhiteSpace(pkgBasePriceTextBox.Text) &&
                Decimal.TryParse(pkgBasePriceTextBox.Text, out result))
            {
                newPkg.PkgBasePrice = result;
                return true;
            }

            // processing failed
            MessageBox.Show("Invalid Price.", "Input Error");
            return false;
        }

        /// <summary>
        /// Process new package description
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public static bool ProcessDesc(Package newPkg, TextBox pkgDescTextBox)
        {
            // empty -> set new package description to null
            if (pkgDescTextBox.Text == "")
            {
                newPkg.PkgDesc = null;
                return true;
            }

            // non-empty -> validate length
            if (pkgDescTextBox.Text.Length <= 50)
            {
                newPkg.PkgDesc = pkgDescTextBox.Text;
                return true;
            }

            // processing failed
            MessageBox.Show("Invalid Description.", "Input Error");
            return false;
        }

        /// <summary>
        /// Process new package name
        /// can't be null or greater than 50 characters
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public static bool ProcessName(Package newPkg, TextBox pkgNameTextBox)
        {
            if (!string.IsNullOrWhiteSpace(pkgNameTextBox.Text) && pkgNameTextBox.Text.Length <= 50)
            {
                newPkg.PkgName = pkgNameTextBox.Text;
                return true;
            }

            // processing failed
            MessageBox.Show("Invalid Name.", "Input Error");
            return false;
        }

        /// <summary>
        /// Process new start date 
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public static bool ProcessStartDate(Package newPkg, TextBox pkgStartDateTextBox)
        {
            // empty -> set new package start date to null
            if (pkgStartDateTextBox.Text == "")
            {
                newPkg.PkgStartDate = null;
                return true;
            }

            // non-empty -> validate input
            if (Validator.IsValidDate(pkgStartDateTextBox.Text))
            {
                newPkg.PkgStartDate = Convert.ToDateTime(pkgStartDateTextBox.Text);
                return true;
            }

            // processing failed
            MessageBox.Show("Invalid Start Date.", "Input Error");
            return false;
        }

        /// <summary>
        /// Process new end date 
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public static bool ProcessEndDate(Package newPkg, TextBox pkgEndDateTextBox)
        {
            // empty -> set new package end date to null
            if (pkgEndDateTextBox.Text == "")
            {
                newPkg.PkgEndDate = null;
                return true;
            }

            // non empty -> validate input
            if (Validator.IsValidDate(pkgEndDateTextBox.Text) &&
                Validator.IsLater(newPkg.PkgStartDate, Convert.ToDateTime(pkgEndDateTextBox.Text)))
            {
                newPkg.PkgEndDate = Convert.ToDateTime(pkgEndDateTextBox.Text);
                return true;
            }

            // processing failed
            MessageBox.Show("Invalid End Date.", "Input Error");
            return false;
        }
    }
}
