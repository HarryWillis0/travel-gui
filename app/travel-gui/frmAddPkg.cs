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
    public partial class frmAddPkg : Form
    {
        public frmAddPkg()
        {
            InitializeComponent();
        }

        private void frmEditPkg_Load(object sender, EventArgs e)
        {
            pkgNameTextBox.Focus();
        }

        /// <summary>
        /// Cancel adding new package
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Adding new package accepted
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Package newPkg = Validation();
            if (newPkg == null) // validation failed
                return;

            try
            {
                bool success = PackageDB.AddPackage(newPkg);
                if (success)
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding package.\n" + ex.Message,
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
                    if(Processor.ProcessStartDate(newPkg, pkgStartDateDateTimePicker) &&
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
