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
            if (string.IsNullOrEmpty(pkgAgencyCommissionTextBox.Text))
            {
                newPkg.PkgAgencyCommission = null;
                return true;
            }

            // must be number
            if (!decimal.TryParse(pkgAgencyCommissionTextBox.Text, out decimal result))
            {
                MessageBox.Show("Agency commission needs to be a number.", "Commission Error");
                return false;
            }

            decimal commission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);
            // price must be positive
            if (commission < 0)
            {
                MessageBox.Show("Agency commission must be positive.", "Commission Error");
                return false;
            }
            // commission must be less than price
            if (commission > newPkg.PkgBasePrice)
            {
                MessageBox.Show("Agency commission must be less than package price.", "Commission Error");
                return false;
            }
            newPkg.PkgAgencyCommission = commission;
            return true;
        }

        /// <summary>
        /// Process new package price
        /// must be non null and be convertible to decimal
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public static bool ProcessPkgPrice(Package newPkg, TextBox pkgBasePriceTextBox)
        {
            decimal result;
            // price is required
            if (string.IsNullOrEmpty(pkgBasePriceTextBox.Text))
            {
                MessageBox.Show("Package price is required.", "Price Error");
                return false;
            }
            // must be number
            if (!Decimal.TryParse(pkgBasePriceTextBox.Text, out result))
            {
                MessageBox.Show("Price needs to be a number.", "Price Error");
                return false;
            }
            // price must be positive
            if (result < 0)
            {
                MessageBox.Show("Price must be positive.", "Price Error");
                return false;
            }
            newPkg.PkgBasePrice = result;
            return true;
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
            else
            {
                MessageBox.Show("Package Description is too long.", "Input Error");
            }

            // processing failed
            return false;
        }

        /// <summary>
        /// Process new package name
        /// can't be null or greater than 50 characters
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public static bool ProcessName(Package newPkg, TextBox pkgNameTextBox)
        {
            if (!string.IsNullOrWhiteSpace(pkgNameTextBox.Text))
            {
                if (pkgNameTextBox.Text.Length <= 50)
                {
                    newPkg.PkgName = pkgNameTextBox.Text;
                    return true;
                }
                else
                    MessageBox.Show("Package name is too long.", "Input Error");
            }
            else
                MessageBox.Show("Package name is required.", "Input Error");
            // processing failed
            return false;
        }

        /// <summary>
        /// Process new start date 
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public static bool ProcessStartDate(Package newPkg, DateTimePicker pkgStartDateTextBox)
        {
            string date = pkgStartDateTextBox.Value.ToString();

            // non-empty -> validate input
            if (Validator.IsValidDate(pkgStartDateTextBox.Text))
            {
                newPkg.PkgStartDate = Convert.ToDateTime(pkgStartDateTextBox.Text);
                return true;
            }

            // processing failed
            MessageBox.Show("Start date must be in valid date form.", "Input Error");
            return false;
        }

        /// <summary>
        /// Process new end date 
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public static bool ProcessEndDate(Package newPkg, DateTimePicker pkgEndDateTextBox)
        {
            string date = pkgEndDateTextBox.Value.ToString();

            // non empty -> validate input
            if (Validator.IsValidDate(pkgEndDateTextBox.Text))
            {
                if (Validator.IsLater(newPkg.PkgStartDate, pkgEndDateTextBox.Value))
                {
                    newPkg.PkgEndDate = Convert.ToDateTime(pkgEndDateTextBox.Text);
                    return true;
                }
                else
                    MessageBox.Show("End date must be after start date.", "Input Error");
            }
            else
                MessageBox.Show("Invalid End Date.", "Input Error");
            // processing failed 
            return false;
        }
    }
}
