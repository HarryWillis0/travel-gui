using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace travel_gui
{
    /// <summary>
    /// A form to update a package
    /// </summary>
    /// @author Harry
    public partial class frmEditPkg : Form
    {
        // store old and new package
        public Package oldPkg;
        public Package newPkg;

        public frmEditPkg()
        {
            InitializeComponent();
        }

        private void frmEditPkg_Load(object sender, EventArgs e)
        {
            pkgNameTextBox.Focus();
            ShowPackage();
        }

        /// <summary>
        /// Fill packages data view with packages
        /// </summary>
        /// @author Harry
        private void ShowPackage()
        {
            packageBindingSource.Clear();
            packageBindingSource.Add(oldPkg);

            // some formatting
            pkgBasePriceTextBox.Text = FormatPrices(pkgBasePriceTextBox.Text);
            pkgAgencyCommissionTextBox.Text = FormatPrices(pkgAgencyCommissionTextBox.Text);
        }

        private string FormatPrices(string price)
        {
            decimal temp = Convert.ToDecimal(price);

            return temp.ToString("c2");
        }

        /// <summary>
        /// Cancel edit of package
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Update accepted 
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // VALIDATE
            if (ProcessName() &&
                ProcessStartDate() &&
                ProcessEndDate() &&
                ProcessDesc() &&
                ProcessPkgPrice() &&
                ProcessPkgAgencyCommission())
            { // input good
               try
                {
                    bool success = PackageDB.UpdatePackage(oldPkg, newPkg);
                    if (success)
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while editing package.\n" + ex.Message,
                        ex.GetType().ToString());
                }
            }

        }

        /// <summary>
        /// Process new package agency commission
        /// must be convertible to decimal or null
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        private bool ProcessPkgAgencyCommission()
        {
            // for conversion from string to decimal
            decimal result;

            if (string.IsNullOrEmpty(pkgAgencyCommissionTextBox.Text))
            {
                newPkg.PkgAgencyCommission = null;
                return true;
            }

            // non empty -> must be convertible to decimal
            if (Decimal.TryParse(pkgAgencyCommissionTextBox.Text, out result))
            {
                newPkg.PkgAgencyCommission = result;
                return true;
            }

            // processing failed
            MessageBox.Show("Invalid Agency Commission.", "Input Error");
            return false;
        }

        /// <summary>
        /// Process new package price
        /// must be non null and be convertible to decimal
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        private bool ProcessPkgPrice()
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
        private bool ProcessDesc()
        {
            // empty -> set new package description to null
            if (pkgDescTextBox.Text == "")
            {
                newPkg.PkgDesc = null;
                return true;
            }

            // non-empty -> validate length
            if ( pkgDescTextBox.Text.Length <= 50)
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
        private bool ProcessName()
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
        private bool ProcessStartDate()
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
        private bool ProcessEndDate()
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
