using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        int supplierCount = 0;

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

        // list of suppliers
        List<Supplier> suppliersDetails;

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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Packages Tab
                    loadMainFormData();
                    break;
                case 1: // Products Tab
                    break;
                case 2: // Suppliers Tab
                    loadSupplierTab();
                    break;
                case 3: // PRoduct Suppliers Tab
                    loadProductSupplierData();
                    break;
            }
        }

        /// <summary>
        /// Load supplier tab data
        /// </summary> Raymond

        private void loadSupplierTab()
        {
            suppliersDetails = SuppliersDB.GetSuppliers();
            supplierId.Text = suppliersDetails[supplierCount].SupplierId.ToString();
            supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
        }

        private string ProcessNullSupplierName(string supName)
        {
            // check for null
            if (suppliersDetails[supplierCount].SupName == null)
                return "";
            else
                return suppliersDetails[supplierCount].SupName.ToString();
        }

        // Load data for main form (first tab - Packages).
        private void loadMainFormData()
        {
            try
            {
                // access packages from db in thread (ASYNCHRONOUS) - Probably uneccessary
                /*Thread pkgWork = new Thread(() => 
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
                prodWork.Join();*/
                packages = PackageDB.GetPackages();
                products = ProductsDB.GetAllProducts();

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

        /// <summary>
        /// Load data for Product Suppliers tab
        /// </summary>
        /// <param name="productIndex">Current index of Product Supplier list. Optional parameter.</param>
        /// <returns>Rows affected by query, 1 for success and 0 for failure</returns>
        // @author Chi 
        private void loadProductSupplierData(int productIndex = 0)
        {
            // Clear list box and data grid view
            lstboxSuppliers.Items.Clear();
            dataGridViewProdSuppliers.Columns.Clear();
            
            // Set current product's view to index of 'products' list (global variable).
            Products curProduct = products[productIndex];
            curProductSuppliers = ProductSupplierDB.GetProductSuppliersByProductID(curProduct.ProductID);

            // Display current product's ID and Name.
            txtPSProdID.Text = curProduct.ProductID.ToString();
            txtPSProdName.Text = curProduct.ProductName;

            // Set customized properties for Data Grid View.
            dataGridViewProdSuppliers.AutoGenerateColumns = false;
            dataGridViewProdSuppliers.DataSource = curProductSuppliers;

            // Created and bind custom column to data source's data property SupplierId.
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Supplier's ID";
            idColumn.DataPropertyName = "SupplierId";
            idColumn.Width = 100;
            idColumn.ReadOnly = true;

            // Created and bind custom column to data source's data property SupName.
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Supplier's Name";
            nameColumn.DataPropertyName = "SupName";
            nameColumn.Width = 239;
            nameColumn.ReadOnly = true;

            // Add data bound columns to Data Grid View.
            dataGridViewProdSuppliers.Columns.Add(idColumn);
            dataGridViewProdSuppliers.Columns.Add(nameColumn);

            // List of all suppliers
            List<Supplier> allSuppliers = SuppliersDB.GetAllSuppliers();

            // Get a list of suppliers that are currently not added to current product's suppliers list
            filteredSuppliers =  new List<Supplier>(allSuppliers.Where(
                Sup => curProductSuppliers.All(
                    sup2 => sup2.SupplierId != Sup.SupplierId
                    )));

            // Add/Update filtered list to list box to prevent customer from adding  
            // same suppliers to product's supplier list.
            foreach (Supplier sup in filteredSuppliers)
            {
                // check if supplier name is null
                if (sup.SupName == null)
                    lstboxSuppliers.Items.Add("");
                else
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
            /*packageBindingSource.Clear();
            packageBindingSource.Add(packages[pkgPos]);*/// hmmmmmmmmmmm

            packageIdTextBox.Text = packages[pkgPos].PackageId.ToString();
            pkgAgencyCommissionTextBox.Text = packages[pkgPos].PkgAgencyCommission.ToString();
            pkgBasePriceTextBox.Text = packages[pkgPos].PkgBasePrice.ToString();
            pkgDescTextBox.Text = packages[pkgPos].PkgDesc;
            pkgStartDateTextBox.Text = packages[pkgPos].PkgStartDate.ToString();
            pkgEndDateTextBox.Text = packages[pkgPos].PkgEndDate.ToString();
            pkgNameTextBox.Text = packages[pkgPos].PkgName;

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

        private void btnModifyProducts_Click(object sender, EventArgs e)
        {
            try
            {
                int ProdID = Convert.ToInt32(ComProductId.SelectedItem);
                string ProdName = txtProductName.Text;
                if (ProdName == "")
                {
                    MessageBox.Show("Null values not allowed", "Incorrect Value");
                }
                else
                {
                    ProductsDB.ModifyProducts(ProdName, ProdID);
                    MessageBox.Show("Product name updated successfully", "Update");
                    clear();
                    ShowProductsInProductsTab();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Null values are not allowed", "Null Value Exception");
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            try
            {
                ComProductId.Enabled = false;
                string ProdName = txtProductName.Text;
                if (ProdName == null)
                {
                    MessageBox.Show("Null values are not allowed.", "Null Value Error");
                }
                else
                {
                    ProductsDB.AddProducts(ProdName);
                    ShowProductsInProductsTab();
                    LoadComboBox();
                    MessageBox.Show("New product succesfully added.", "Add Product");
                    clear();
                }
                ComProductId.Enabled = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("Null values are not allowed, Type correct information.", "Null Value / Incorrect Format");
            }
        }

        private void ShowProductsInProductsTab()
        {
            List<Products> dispProducts = ProductsDB.GetAllProducts();
            ViewProducts.DataSource = dispProducts;
        }

        private void clear()
        {
            ComProductId.Text = "";
            txtProductName.Text = string.Empty;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            ComProductId.Items.Clear();
            List<Products> dispProducts = ProductsDB.GetAllProducts();
            ViewProducts.DataSource = dispProducts;

            // loop through products and add ids to drop down
            foreach (Products prod in dispProducts)
            {
                ComProductId.Items.Add(prod.ProductID.ToString());
            }
        }

        private void ComProductId_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int ProductID = Convert.ToInt32(ComProductId.SelectedItem);
                Products myProduct = ProductsDB.GetProducts(ProductID);
                txtProductName.Text = myProduct.ProductName;
            }
            catch (FormatException)
            {
                MessageBox.Show("Select or type valid Product ID", "Incorrect Input");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Product Id does not exist.", "Incorrect Input");
            }
        }
        /// <summary>
        /// Set view to first item in product's list.
        /// </summary>
        /// @author Chi
        private void btnFirstItem_Click(object sender, EventArgs e)
        {
            loadProductSupplierData();
        }

        /// <summary>
        /// Set view to last item in product's list.
        /// </summary>
        /// @author Chi
        private void btnLastItem_Click(object sender, EventArgs e)
        {
            loadProductSupplierData(products.Count - 1);
        }

        /// <summary>
        /// Display next item in product's list.
        /// </summary>
        /// @author Chi
        private void btnNextItem_Click(object sender, EventArgs e)
        {
            int currentIndex = Convert.ToInt32(txtPSProdID.Text);

            if (currentIndex == products.Count)
                loadProductSupplierData();
            else
                loadProductSupplierData(currentIndex);
        }

        /// <summary>
        /// Display previous item in product's list.
        /// </summary>
        /// @author Chi
        private void btnPreviousItem_Click(object sender, EventArgs e)
        {
            int currentIndex = Convert.ToInt32(txtPSProdID.Text);
            currentIndex--;

            if (currentIndex == 0)
                loadProductSupplierData(products.Count - 1);
            else
                loadProductSupplierData(currentIndex - 1);
        }

        /// <summary>
        /// Operations for click event on Add Supplier button.
        /// </summary>
        /// @author Chi
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Supplier curSupplier; // Currently select supplier
            int currentSupID;  // Currently select supplier's ID
            int currentProductID = Convert.ToInt32(txtPSProdID.Text); // Current product's ProductID
            int currentSupplierIndex = lstboxSuppliers.SelectedIndex; // Current index of supplier selected in list box

            if (currentSupplierIndex >= 0) // If user have selected an item from list box
            {
                // Set current supplier's ID to supplier selected in list box.
                curSupplier = filteredSuppliers[currentSupplierIndex];
                currentSupID = curSupplier.SupplierId;

                // Verify if supplier is already added to product's suppliers list.
                int result = ProductSupplierDB.GetId(currentProductID, currentSupID);

                if(result < 0) // If supplier is not in product's supplier list.
                {
                    try
                    {
                        // Add supplier to current product, reset/reload view for current product
                        // and notify user that supplier was added successfully.
                        ProductSupplierDB.AddProductSupplier(currentProductID, currentSupID);
                        loadProductSupplierData(currentProductID - 1);
                        MessageBox.Show("Supplier Added", "Success");
                    }
                    catch (Exception ex)
                    {
                        // Notify user of optimistic concurrency error or DB error.
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

        /// <summary>
        /// Operations for click event on Remove Supplier button.
        /// </summary>
        /// @author Chi
        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            int currentSupID; // Currently select supplier's ID.
            int currentProductID = Convert.ToInt32(txtPSProdID.Text); // Currently viewing product's ID.

            int row = dataGridViewProdSuppliers.CurrentRow.Index; // Index of currently selected row in DGV.
            Supplier selectedSupplier = curProductSuppliers[row]; // Supplier that was selected/highlighted on DGV.
            currentSupID = selectedSupplier.SupplierId; // Set current supplier's ID to selected supplier.

            try {
                // Remove supplier for current product, reset/reload view for current product
                // and notify user that supplier was added successfully.
                ProductSupplierDB.RemoveProductSupplier(currentProductID, currentSupID);
                loadProductSupplierData(currentProductID - 1);
                MessageBox.Show("Supplier Removed.", "Success");
            }
            catch (SqlException ex)
            {
                if (ex.Errors[0].Number == 547 || // Foreign Key violation
                        ex.Errors[0].Number == 2601 // Primary key violation
                        )
                {
                    // Notify user of DB violation
                    MessageBox.Show("Unable to remove Supplier.\n" +
                        "The Product Supplier is currently part of a booking or package.\n\n", 
                        "Supplier In Use");
                }
            }
            catch (Exception ex)
            {
                // Notify user of optimistic concurrency error.
                MessageBox.Show("Unable to remove Supplier.\nThe Product Supplier was either removed or updated.\n\n" +
                                        ex.Message, "Unexpected Database Error");
            }
        }

        /*Code that takes user to the previous supplier detail - Raymond */
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (supplierCount >= 0)
            {
                if (supplierCount == 0)
                {
                    supplierId.Text = suppliersDetails[supplierCount].SupplierId.ToString();
                    supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
                }
                else
                {
                    supplierId.Text = suppliersDetails[--supplierCount].SupplierId.ToString();
                    supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
                }

            }
        }

        //Code that takes user to next supplier details - Raymond
        private void bbtnNexxt_Click(object sender, EventArgs e)
        {
            if (supplierCount <= suppliersDetails.Count - 1)
            {
                if (supplierCount == suppliersDetails.Count - 1)
                {
                    supplierId.Text = suppliersDetails[supplierCount].SupplierId.ToString();
                    supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
                }
                else
                {
                    supplierId.Text = suppliersDetails[++supplierCount].SupplierId.ToString();
                    supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
                }
            }
        }

        //Code written by Raymond Edeamrere 
        //Code that takes user to the last supplier ID on the table
        private void btnGoToEnd_Click(object sender, EventArgs e)
        {
            supplierCount = suppliersDetails.Count - 1;
            supplierId.Text = suppliersDetails[supplierCount].SupplierId.ToString();
            supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
        }

        //Code that takes user back to the first supplier ID - Raymond
        private void btnGoToStart_Click(object sender, EventArgs e)
        {
            supplierCount = 0;
            supplierId.Text = suppliersDetails[supplierCount].SupplierId.ToString();
            supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
        }

        //TypeCode written by Raymond Edeamrere 
        //Code that takes user to the last supplier ID on the table
        private void btnGoToEndSupplier_Click(object sender, EventArgs e)
        {
            supplierCount = suppliersDetails.Count - 1;
            supplierId.Text = suppliersDetails[supplierCount].SupplierId.ToString();
            supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
        }

        //Code that takes user back to the first supplier ID - Raymond
        private void btnGoToStartSupplier_Click(object sender, EventArgs e)
        {
            supplierCount = 0;
            supplierId.Text = suppliersDetails[supplierCount].SupplierId.ToString();
            supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
        }

        //Adding a new supplier - Raymond
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddSupplier addSupplier = new frmAddSupplier();

            DialogResult result = addSupplier.ShowDialog();

            suppliersDetails = SuppliersDB.GetSuppliers();
            supplierCount = suppliersDetails.Count - 1;
            supplierId.Text = suppliersDetails[supplierCount].SupplierId.ToString();
            supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
        }

        // Edit existing supplier - Raymond
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            frmEditSuppliers editSuppliers = new frmEditSuppliers(suppliersDetails[supplierCount]);
            DialogResult result = editSuppliers.ShowDialog();

            suppliersDetails = SuppliersDB.GetSuppliers();
            supplierId.Text = suppliersDetails[supplierCount].SupplierId.ToString();
            supplierName.Text = ProcessNullSupplierName(suppliersDetails[supplierCount].SupName);
        }
    }
}
    