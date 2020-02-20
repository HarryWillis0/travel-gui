using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace travel_gui
{
    public partial class frmAddSupplier : Form
    {
        public frmAddSupplier()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // valid supplier id
            if (!Validator.IsValidSupplierId(supplierId.Text, out string result))
            {
                MessageBox.Show(result, "Supplier Error");
                return;
            }
            // supplier name required as per Jolanta
            if (string.IsNullOrEmpty(supplierName.Text))
            {
                MessageBox.Show("Supplier Name is required.", "Supplier Error");
                return;
            }
            
            Supplier supplier = new Supplier()
            {
                SupplierId = Int32.Parse(supplierId.Text),
                SupName = supplierName.Text
            };
            try
            {
                SuppliersDB.AddSupplier(supplier);
                this.DialogResult = DialogResult.OK;
            }
            catch (SqlException ex) 
            {
                if (ex.Number == 2627) // supplier id already exists 
                {
                    MessageBox.Show("Supplier ID already exists.", "ID Error");
                }
            } 
            catch (Exception ex)
            {

                MessageBox.Show("Error while adding supplier.\n\n" + ex.Message,
                    ex.GetType().ToString());
            }
            
        }
    }
}
