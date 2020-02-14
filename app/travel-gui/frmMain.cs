using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace travel_gui
{
    public partial class frmMain : Form
    {
        // packages info
        List<Package> packages; // list of packages
        int pkgPos = 0; // current position in packages

        // product info
        List<Products> products;

        // supplier of current product in combo box
        List<Supplier> suppliersOfProd;

        // list of products associated with current package in detail view in packages tab
        List<string> pkgProducts;

        // list of supplier names of the products associated with package in detail view in packages tab
        List<string> pkgProdSupps;

        // List of suppliers of selected product
        List<Supplier> curProductSuppliers;

        // List of suppliers that are not suppliers of selected product
        List<Supplier> filteredSuppliers;

        public frmMain()
        {
            InitializeComponent();
        }

        // Event when page loads.
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadMainFormData();
        }


        // Events based on tab selected.
        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mainTabControl.SelectedIndex)
            {
                case 0:
                    loadMainFormData();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    loadProductSupplierData();
                    
                    break;
            }
        }

        // Load data for main form (first tab - Packages).
        private void loadMainFormData()
        {
            try
            {
                // access packages from db in thread (ASYNCHRONOUS) - Probably uneccessary
                Thread pkgWork = new Thread(() =>
                {
                    packages = PackageDB.GetPackages();
                });

                // access all products from db in thread 
                Thread prodWork = new Thread(() =>
                {
                    products = ProductsDB.GetAllProducts();
                });

                pkgWork.Start();
                prodWork.Start();

                pkgWork.Join();
                prodWork.Join();

                // access products and suppliers associated with current package
                PackageDB.GetPackageProducts(packages[pkgPos].PackageId, out pkgProducts, out pkgProdSupps);

                ShowPackages();
                ShowAllProducts();
                ShowPkgProducts(pkgProducts, pkgProdSupps);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading data.\n\n" + ex.Message,
                    ex.GetType().ToString());
            }
        }
        private void loadProductSupplierData(int productIndex = 0)
        {
            lstboxSuppliers.Items.Clear();
            dataGridViewProdSuppliers.Columns.Clear();
            
            Products curProduct = products[productIndex];
            curProductSuppliers = ProductSupplierDB.GetProductSuppliersByProductID(curProduct.ProductID);

            txtPSProdID.Text = curProduct.ProductID.ToString();
            txtPSProdName.Text = curProduct.ProductName;

            dataGridViewProdSuppliers.AutoGenerateColumns = false;
            dataGridViewProdSuppliers.DataSource = curProductSuppliers;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Supplier's ID";
            idColumn.DataPropertyName = "SupplierId";
            idColumn.Width = 100;
            idColumn.ReadOnly = true;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Supplier's Name";
            nameColumn.DataPropertyName = "SupName";
            nameColumn.Width = 239;
            nameColumn.ReadOnly = true;

            dataGridViewProdSuppliers.Columns.Add(idColumn);
            dataGridViewProdSuppliers.Columns.Add(nameColumn);

            List<Supplier> allSuppliers = SuppliersDB.GetAllSuppliers();

            filteredSuppliers =  new List<Supplier>(allSuppliers.Where(Sup => curProductSuppliers.All(sup2 => sup2.SupplierId != Sup.SupplierId)));
            foreach (Supplier sup in filteredSuppliers)
            {
                lstboxSuppliers.Items.Add(sup.SupName);
            }

        }


        /// <summary>
        /// Populate data grid view on packages tab with
        ///     products and suppliers associated with package
        ///         in detail view.
        /// </summary>
        /// @author Harry
        private void ShowPkgProducts(List<string> pkgProducts, List<string> pkgProdSupps)
        {
            dataGrdViewPkgProds.Rows.Clear();

            int index = 0;
            // create rows for product and its supplier 
            foreach (string str in pkgProducts)
            {
                string[] newRow = new string[] { str, pkgProdSupps[index++]};

                // add to data grid view
                dataGrdViewPkgProds.Rows.Add(newRow);
            }
        }

        /// <summary>
        /// Fill combo box with products
        /// </summary>
        private void ShowAllProducts()
        {
            foreach (Products prod in products)
            {
                cmboBoxProducts.Items.Add(prod.ProductName);
            }
        }

        /// <summary>
        /// Fill packages data view with packages
        /// </summary>
        /// @author Harry
        private void ShowPackages()
        {
            packageBindingSource.Clear();
            packageBindingSource.Add(packages[pkgPos]);

            // some formatting
            pkgBasePriceTextBox.Text = FormatPrices(pkgBasePriceTextBox.Text);

            // check for null before formatting
            if (pkgAgencyCommissionTextBox.Text == "")
                return;

            pkgAgencyCommissionTextBox.Text = FormatPrices(pkgAgencyCommissionTextBox.Text);
        }

        private string FormatPrices(string price)
        {
            decimal temp = Convert.ToDecimal(price);
            
            return temp.ToString("c2") ;
        }

        /// <summary>
        /// Fill packages detail view with the first package (by package id).
        /// </summary>
        /// @author Harry
        private void btnSkipToFirst_Click(object sender, EventArgs e)
        {
            // list of products associated with current package in detail view in packages tab
            List<string> pkgProducts;

            // list of supplier names of the products associated with package in detail view in packages tab
            List<string> pkgProdSupps;

            pkgPos = 0;
            ShowPackages();

            // access products and suppliers associated with current package
            PackageDB.GetPackageProducts(packages[pkgPos].PackageId, out pkgProducts, out pkgProdSupps);
            ShowPkgProducts(pkgProducts, pkgProdSupps);
        }

        /// <summary>
        /// Fill package detail view with the previous package
        ///     or wrap to last if current package is the first.
        /// </summary>
        /// @author Harry
        private void btnPrev_Click(object sender, EventArgs e)
        {
            // list of products associated with current package in detail view in packages tab
            List<string> pkgProducts;

            // list of supplier names of the products associated with package in detail view in packages tab
            List<string> pkgProdSupps;

            // wrap around if current package is the last.
            if (pkgPos == 0)
                pkgPos = packages.Count - 1;
            else
                pkgPos--;

            ShowPackages();

            // access products and suppliers associated with current package
            PackageDB.GetPackageProducts(packages[pkgPos].PackageId, out pkgProducts, out pkgProdSupps);
            ShowPkgProducts(pkgProducts, pkgProdSupps);
        }

        /// <summary>
        /// Fill packages detail view with next package (by package id)
        ///     wrap to first package if current package is the last.
        /// </summary>
        /// @author Harry
        private void btnNext_Click(object sender, EventArgs e)
        {
            // list of products associated with current package in detail view in packages tab
            List<string> pkgProducts;

            // list of supplier names of the products associated with package in detail view in packages tab
            List<string> pkgProdSupps;

            // wrap around if current package is the first.
            if (pkgPos == packages.Count - 1)
                pkgPos = 0;
            else
                pkgPos++;

            ShowPackages();

            // access products and suppliers associated with current package
            PackageDB.GetPackageProducts(packages[pkgPos].PackageId, out pkgProducts, out pkgProdSupps);
            ShowPkgProducts(pkgProducts, pkgProdSupps);
        }

        /// <summary>
        /// Fill packages detail view with the last package (by package id).
        /// </summary>
        /// @author Harry
        private void btnSkpToEnd_Click(object sender, EventArgs e)
        {
            // list of products associated with current package in detail view in packages tab
            List<string> pkgProducts;

            // list of supplier names of the products associated with package in detail view in packages tab
            List<string> pkgProdSupps;

            pkgPos = packages.Count - 1;
            ShowPackages();

            // access products and suppliers associated with current package
            PackageDB.GetPackageProducts(packages[pkgPos].PackageId, out pkgProducts, out pkgProdSupps);
            ShowPkgProducts(pkgProducts, pkgProdSupps);
        }

        /// <summary>
        /// Exit app
        /// </summary>
        /// @author Harry
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Show edit form
        /// </summary>
        /// @author Harry
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // get a copy of the current order
            Package oldPkg = packages[pkgPos].Clone();

            frmEditPkg updatePkg = new frmEditPkg();

            // set new and old packages on update form
            updatePkg.oldPkg = oldPkg;
            updatePkg.newPkg = packages[pkgPos];

            // show package edit form
            DialogResult editPkgResult = updatePkg.ShowDialog();

            if (editPkgResult == DialogResult.OK) // edit accepted
            {
                // re-gather packages from DB
                packages = PackageDB.GetPackages();
                ShowPackages();
            }
            else if (editPkgResult == DialogResult.Abort) // concurrency issue
            {
                packages[pkgPos] = oldPkg;
                MessageBox.Show("Edit aborted. Another user has modified or deleted that package.", "Edit Abort");
            }
            else // edit cancelled
            {
                // set back to un-edited package
                packages[pkgPos] = oldPkg;
            }
        }

        /// <summary>
        /// Show add form
        /// </summary>
        /// @author Harry
        private void btnAddPkg_Click(object sender, EventArgs e)
        {
            frmAddPkg addPkg = new frmAddPkg();

            // show add new package form
            DialogResult addPkgResult = addPkg.ShowDialog();

            if (addPkgResult == DialogResult.OK)
            {
                // set view to new package
                packages = PackageDB.GetPackages();
                pkgPos = packages.Count - 1;
                ShowPackages();
            }
        }

        /// <summary>
        /// Show suppliers of selected product
        /// </summary>
        /// @author Harry
        private void cmboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ensure there was a selection
            if (cmboBoxProducts.SelectedIndex > -1)
            {
                cmboBoxSupsOfProd.Text = "";
                try
                {
                    // get selected index 
                    int cmboBoxIndex = cmboBoxProducts.SelectedIndex;

                    // get product id
                    int prodId = products[cmboBoxIndex].ProductID;
                    
                    // get suppliers of product
                    suppliersOfProd = SuppliersDB.FindSuppliersOfProduct(prodId);

                    cmboBoxSupsOfProd.Items.Clear();

                    // add to combo box
                    foreach (Supplier sup in suppliersOfProd)
                    {
                        cmboBoxSupsOfProd.Items.Add(sup.SupName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while loading suppliers\n" + ex.Message,
                        ex.GetType().ToString());
                }
            }
        }

        /// <summary>
        /// Add selected product to package in detail view
        /// </summary>
        /// @author Harry
        private void btnAddProdToPkg_Click(object sender, EventArgs e)
        {
            if (cmboBoxSupsOfProd.SelectedIndex > -1) // selection required
            {
                // get product and supplier ids (to get ProductSupplierId)
                int prodId = products[cmboBoxProducts.SelectedIndex].ProductID;
                int supplierId = suppliersOfProd[cmboBoxSupsOfProd.SelectedIndex].SupplierId;

                try
                {
                    // get product supplier id
                    int prodSuppId = ProductSupplierDB.GetId(prodId, supplierId);

                    // create new package product supplier object to enter into package products suppliers table
                    PackageProductSupplier newPkgProdSup = new PackageProductSupplier();
                    newPkgProdSup.PackageId = Convert.ToInt32(packageIdTextBox.Text);
                    newPkgProdSup.ProductSupplierId = prodSuppId;

                    // update packages product supplier table
                    bool success = PackageProductSupplierDB.AddNewPkgProdSupp(newPkgProdSup);

                    if (success)
                    {
                        // clear combo boxes
                        cmboBoxProducts.Items.Clear();
                        cmboBoxSupsOfProd.Items.Clear();

                        // show updated version of products associated with package
                        List<string> pkgProducts;
                        List<string> pkgProdSupps;

                        // access products and suppliers associated with current package
                        PackageDB.GetPackageProducts(packages[pkgPos].PackageId, out pkgProducts, out pkgProdSupps);
                        ShowPkgProducts(pkgProducts, pkgProdSupps);
                        ShowAllProducts();
                        cmboBoxSupsOfProd.Text = "";
                        cmboBoxProducts.Text = "";
                        cmboBoxSupsOfProd.Items.Clear();
                        MessageBox.Show("Added product successfully.", "Success");
                    }
                    else
                    {
                        // clear combo boxes
                        cmboBoxProducts.Items.Clear();
                        cmboBoxSupsOfProd.Items.Clear();
                        MessageBox.Show("Error occured while adding product.", "Failure");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding product to package\n" + ex.Message,
                        ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a product and its supplier.", "Select Error");
            }
        }

        /// <summary>
        /// Re-gather data 
        /// </summary>
        /// @author Harry
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.frmMain_Load(sender, e);
        }

        private void btnFirstItem_Click(object sender, EventArgs e)
        {
            loadProductSupplierData();
        }

        private void btnLastItem_Click(object sender, EventArgs e)
        {
            loadProductSupplierData(products.Count - 1);
        }

        private void btnNextItem_Click(object sender, EventArgs e)
        {
            int currentIndex = Convert.ToInt32(txtPSProdID.Text);

            if (currentIndex == products.Count)
                loadProductSupplierData();
            else
                loadProductSupplierData(currentIndex);
        }

        private void btnPreviousItem_Click(object sender, EventArgs e)
        {
            int currentIndex = Convert.ToInt32(txtPSProdID.Text);
            currentIndex--;

            if (currentIndex == 0)
                loadProductSupplierData(products.Count - 1);
            else
                loadProductSupplierData(currentIndex - 1);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Supplier curSupplier;
            int currentSupID; 
            int currentProductID = Convert.ToInt32(txtPSProdID.Text);
            int currentSupplierIndex = lstboxSuppliers.SelectedIndex;

            if (currentSupplierIndex >= 0)
            {
                curSupplier = filteredSuppliers[currentSupplierIndex];
                currentSupID = curSupplier.SupplierId;

                int result = ProductSupplierDB.GetId(currentProductID, currentSupID);

                if(result < 0)
                {
                    try
                    {
                        ProductSupplierDB.AddProductSupplier(currentProductID, currentSupID);
                        loadProductSupplierData(currentProductID - 1);
                        MessageBox.Show("Supplier Added", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to Add Supplier.\nThe Product Supplier was either removed or updated.\n\n" + 
                                        ex.Message, "Unexpected Database Error");
                    }
                    
                }
                else
                    MessageBox.Show("That supplier is already added to the product", "Failed");

            }
            else
                MessageBox.Show("Please choose a supplier.", "No supplier selected");
        }

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            int currentSupID;
            int currentProductID = Convert.ToInt32(txtPSProdID.Text);
            
            int row = dataGridViewProdSuppliers.CurrentRow.Index;
            Supplier selectedSupplier = curProductSuppliers[row];
            currentSupID = selectedSupplier.SupplierId;

            try {
                ProductSupplierDB.RemoveProductSupplier(currentProductID, currentSupID);
                loadProductSupplierData(currentProductID - 1);
                MessageBox.Show("Supplier Removed.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Add Supplier.\nThe Product Supplier was either removed or updated.\n\n" +
                                        ex.Message, "Unexpected Database Error");
            }
        }
    }
}
    