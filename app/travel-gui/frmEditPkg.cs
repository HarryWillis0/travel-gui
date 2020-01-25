﻿using System;
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
        private void ShowPackage()
        {
            packageIdTextBox.Text = oldPkg.PackageId.ToString();
            pkgNameTextBox.Text = oldPkg.PkgName;
            pkgDescTextBox.Text = oldPkg.PkgDesc;
            pkgStartDateTextBox.Text = oldPkg.PkgStartDate.ToString();
            pkgEndDateTextBox.Text = oldPkg.PkgEndDate.ToString();
            pkgBasePriceTextBox.Text = oldPkg.PkgBasePrice.ToString();
            pkgAgencyCommissionTextBox.Text = oldPkg.PkgAgencyCommission.ToString();

            // TODO: GET RID OF TIMES ON DATES

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
            if (Processor.ProcessName(newPkg, pkgNameTextBox) &&
                Processor.ProcessStartDate(newPkg, pkgStartDateTextBox) &&
                Processor.ProcessEndDate(newPkg, pkgEndDateTextBox) &&
                Processor.ProcessDesc(newPkg, pkgDescTextBox) &&
                Processor.ProcessPkgPrice(newPkg, pkgBasePriceTextBox) &&
                Processor.ProcessPkgAgencyCommission(newPkg, pkgAgencyCommissionTextBox))
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
    }
}