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
            ShowPackage(sender, e);
        }

        /// <summary>
        /// Fill packages data view with packages
        /// </summary>
        private void ShowPackage(object sender, EventArgs e)
        {
            packageIdTextBox.Text = oldPkg.PackageId.ToString();
            pkgNameTextBox.Text = oldPkg.PkgName;
            pkgDescTextBox.Text = oldPkg.PkgDesc;

            // format to get rid of time stamp - first got to check if null
            if (oldPkg.PkgStartDate == null)
            {
                chkBoxStartDate.Checked = true;
                chkBoxStartDate_CheckedChanged(sender, e);
            }
            else
            {
                DateTime temp = Convert.ToDateTime(oldPkg.PkgStartDate);
                pkgStartDateDateTimePicker.Value = temp;
            }

            if (oldPkg.PkgEndDate == null)
            {
                chkBoxEndDate.Checked = true;
                chkBoxEndDate_CheckedChanged(sender, e);
            }
            else
            {
                DateTime temp = Convert.ToDateTime(oldPkg.PkgEndDate);
                pkgEndDateDateTimePicker.Value = temp;
            }

            decimal tempMon = Convert.ToDecimal(oldPkg.PkgBasePrice);
            pkgBasePriceTextBox.Text = tempMon.ToString("F");

            if (oldPkg.PkgAgencyCommission == null)
                pkgAgencyCommissionTextBox.Text = "";
            else
            {
                tempMon = Convert.ToDecimal(oldPkg.PkgAgencyCommission);
                pkgAgencyCommissionTextBox.Text = tempMon.ToString("F");
            }
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
            newPkg = Validation();
            if (newPkg == null)
                return;
            try
            {
                int success = PackageDB.UpdatePackage(oldPkg, newPkg);

                if (success == 1)
                    this.DialogResult = DialogResult.OK;
                else if (success == 0) // there was a concurrency issue
                {
                    this.DialogResult = DialogResult.Abort;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while editing package.\n" + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private Package Validation()
        {
            Package newPkg = new Package();
            // VALIDATE
            if (Processor.ProcessName(newPkg, pkgNameTextBox) &&
                Processor.ProcessDesc(newPkg, pkgDescTextBox) &&
                Processor.ProcessPkgPrice(newPkg, pkgBasePriceTextBox) &&
                Processor.ProcessPkgAgencyCommission(newPkg, pkgAgencyCommissionTextBox))
            {
                // check to see if dates have empty checked
                if (chkBoxStartDate.Checked && chkBoxEndDate.Checked) // both checked
                {
                    newPkg.PkgStartDate = null;
                    newPkg.PkgEndDate = null;
                    return newPkg;
                }
                else if (chkBoxStartDate.Checked) // only start checked - invalid
                {
                    MessageBox.Show("End date must be checked empty if start date is.", "Date Error");
                    return null;
                }
                else if (chkBoxEndDate.Checked && Processor.ProcessStartDate(newPkg, pkgStartDateDateTimePicker)) // only end date checked - valid
                {
                    newPkg.PkgEndDate = null;
                    return newPkg;
                }
                else
                {
                    if (Processor.ProcessStartDate(newPkg, pkgStartDateDateTimePicker) &&
                        Processor.ProcessEndDate(newPkg, pkgEndDateDateTimePicker))
                    {
                        return newPkg;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Empty date time picker if checked, show todays date if unchecked
        /// </summary>
        private void chkBoxStartDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxStartDate.Checked) // checked
            {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgStartDateDateTimePicker.CustomFormat = " ";
            }
            else // unchecked
            {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Long;
            }
        }

        /// <summary>
        /// Empty date time picker if checked, show todays date if unchecked
        /// </summary>
        private void chkBoxEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxEndDate.Checked) // checked
            {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgEndDateDateTimePicker.CustomFormat = " ";
            }
            else // unchecked
            {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Long;
            }
        }
    }
}
