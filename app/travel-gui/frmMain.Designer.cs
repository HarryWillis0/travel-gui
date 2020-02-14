namespace travel_gui
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgEndDateLabel1;
            System.Windows.Forms.Label pkgStartDateLabel1;
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tbPkgs = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrdViewPkgProds = new System.Windows.Forms.DataGridView();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxAddProdToPkg = new System.Windows.Forms.GroupBox();
            this.btnAddProdToPkg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboBoxSupsOfProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBoxProducts = new System.Windows.Forms.ComboBox();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.btnEditPkg = new System.Windows.Forms.Button();
            this.pkgStartDateTextBox = new System.Windows.Forms.TextBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pkgEndDateTextBox = new System.Windows.Forms.TextBox();
            this.btnSkipToFirst = new System.Windows.Forms.Button();
            this.btnSkpToEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.tbProds = new System.Windows.Forms.TabPage();
            this.tbSuppliers = new System.Windows.Forms.TabPage();
            this.tbProdSupp = new System.Windows.Forms.TabPage();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.gbAddSupplier = new System.Windows.Forms.GroupBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.lstboxSuppliers = new System.Windows.Forms.ListBox();
            this.txtPSProdName = new System.Windows.Forms.TextBox();
            this.txtPSProdID = new System.Windows.Forms.TextBox();
            this.lblPSProductName = new System.Windows.Forms.Label();
            this.lblPSProductID = new System.Windows.Forms.Label();
            this.lblPSSuppliers = new System.Windows.Forms.Label();
            this.dataGridViewProdSuppliers = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirstItem = new System.Windows.Forms.Button();
            this.btnLastItem = new System.Windows.Forms.Button();
            this.btnNextItem = new System.Windows.Forms.Button();
            this.btnPreviousItem = new System.Windows.Forms.Button();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel1 = new System.Windows.Forms.Label();
            pkgStartDateLabel1 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.tbPkgs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViewPkgProds)).BeginInit();
            this.grpBoxAddProdToPkg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.tbProdSupp.SuspendLayout();
            this.gbAddSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(18, 33);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(19, 13);
            packageIdLabel.TabIndex = 0;
            packageIdLabel.Text = "Id:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(18, 189);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(104, 13);
            pkgAgencyCommissionLabel.TabIndex = 2;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(18, 163);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(34, 13);
            pkgBasePriceLabel.TabIndex = 4;
            pkgBasePriceLabel.Text = "Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(18, 137);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(63, 13);
            pkgDescLabel.TabIndex = 6;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(18, 59);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(38, 13);
            pkgNameLabel.TabIndex = 10;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgEndDateLabel1
            // 
            pkgEndDateLabel1.AutoSize = true;
            pkgEndDateLabel1.Location = new System.Drawing.Point(18, 108);
            pkgEndDateLabel1.Name = "pkgEndDateLabel1";
            pkgEndDateLabel1.Size = new System.Drawing.Size(55, 13);
            pkgEndDateLabel1.TabIndex = 17;
            pkgEndDateLabel1.Text = "End Date:";
            // 
            // pkgStartDateLabel1
            // 
            pkgStartDateLabel1.AutoSize = true;
            pkgStartDateLabel1.Location = new System.Drawing.Point(18, 82);
            pkgStartDateLabel1.Name = "pkgStartDateLabel1";
            pkgStartDateLabel1.Size = new System.Drawing.Size(58, 13);
            pkgStartDateLabel1.TabIndex = 18;
            pkgStartDateLabel1.Text = "Start Date:";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tbPkgs);
            this.mainTabControl.Controls.Add(this.tbProds);
            this.mainTabControl.Controls.Add(this.tbSuppliers);
            this.mainTabControl.Controls.Add(this.tbProdSupp);
            this.mainTabControl.Location = new System.Drawing.Point(12, 67);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(893, 362);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // tbPkgs
            // 
            this.tbPkgs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPkgs.Controls.Add(this.btnRefresh);
            this.tbPkgs.Controls.Add(this.label3);
            this.tbPkgs.Controls.Add(this.dataGrdViewPkgProds);
            this.tbPkgs.Controls.Add(this.grpBoxAddProdToPkg);
            this.tbPkgs.Controls.Add(this.btnAddPkg);
            this.tbPkgs.Controls.Add(this.btnEditPkg);
            this.tbPkgs.Controls.Add(pkgStartDateLabel1);
            this.tbPkgs.Controls.Add(this.pkgStartDateTextBox);
            this.tbPkgs.Controls.Add(pkgEndDateLabel1);
            this.tbPkgs.Controls.Add(this.pkgEndDateTextBox);
            this.tbPkgs.Controls.Add(this.btnSkipToFirst);
            this.tbPkgs.Controls.Add(this.btnSkpToEnd);
            this.tbPkgs.Controls.Add(this.btnNext);
            this.tbPkgs.Controls.Add(this.btnPrev);
            this.tbPkgs.Controls.Add(packageIdLabel);
            this.tbPkgs.Controls.Add(this.packageIdTextBox);
            this.tbPkgs.Controls.Add(pkgAgencyCommissionLabel);
            this.tbPkgs.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.tbPkgs.Controls.Add(pkgBasePriceLabel);
            this.tbPkgs.Controls.Add(this.pkgBasePriceTextBox);
            this.tbPkgs.Controls.Add(pkgDescLabel);
            this.tbPkgs.Controls.Add(this.pkgDescTextBox);
            this.tbPkgs.Controls.Add(pkgNameLabel);
            this.tbPkgs.Controls.Add(this.pkgNameTextBox);
            this.tbPkgs.Location = new System.Drawing.Point(4, 22);
            this.tbPkgs.Name = "tbPkgs";
            this.tbPkgs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPkgs.Size = new System.Drawing.Size(885, 336);
            this.tbPkgs.TabIndex = 0;
            this.tbPkgs.Text = "Packages";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(7, 306);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Current Products";
            // 
            // dataGrdViewPkgProds
            // 
            this.dataGrdViewPkgProds.AllowUserToAddRows = false;
            this.dataGrdViewPkgProds.AllowUserToDeleteRows = false;
            this.dataGrdViewPkgProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdViewPkgProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdName,
            this.colProdSupplier});
            this.dataGrdViewPkgProds.Location = new System.Drawing.Point(436, 40);
            this.dataGrdViewPkgProds.Name = "dataGrdViewPkgProds";
            this.dataGrdViewPkgProds.ReadOnly = true;
            this.dataGrdViewPkgProds.Size = new System.Drawing.Size(443, 150);
            this.dataGrdViewPkgProds.TabIndex = 23;
            // 
            // colProdName
            // 
            this.colProdName.HeaderText = "Product Name";
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            // 
            // colProdSupplier
            // 
            this.colProdSupplier.HeaderText = "Supplier";
            this.colProdSupplier.Name = "colProdSupplier";
            this.colProdSupplier.ReadOnly = true;
            this.colProdSupplier.Width = 300;
            // 
            // grpBoxAddProdToPkg
            // 
            this.grpBoxAddProdToPkg.Controls.Add(this.btnAddProdToPkg);
            this.grpBoxAddProdToPkg.Controls.Add(this.label2);
            this.grpBoxAddProdToPkg.Controls.Add(this.cmboBoxSupsOfProd);
            this.grpBoxAddProdToPkg.Controls.Add(this.label1);
            this.grpBoxAddProdToPkg.Controls.Add(this.cmboBoxProducts);
            this.grpBoxAddProdToPkg.Location = new System.Drawing.Point(436, 196);
            this.grpBoxAddProdToPkg.Name = "grpBoxAddProdToPkg";
            this.grpBoxAddProdToPkg.Size = new System.Drawing.Size(276, 134);
            this.grpBoxAddProdToPkg.TabIndex = 22;
            this.grpBoxAddProdToPkg.TabStop = false;
            this.grpBoxAddProdToPkg.Text = "Add Product to Package";
            // 
            // btnAddProdToPkg
            // 
            this.btnAddProdToPkg.Location = new System.Drawing.Point(96, 94);
            this.btnAddProdToPkg.Name = "btnAddProdToPkg";
            this.btnAddProdToPkg.Size = new System.Drawing.Size(75, 23);
            this.btnAddProdToPkg.TabIndex = 4;
            this.btnAddProdToPkg.Text = "Add";
            this.btnAddProdToPkg.UseVisualStyleBackColor = true;
            this.btnAddProdToPkg.Click += new System.EventHandler(this.btnAddProdToPkg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a Supplier:";
            // 
            // cmboBoxSupsOfProd
            // 
            this.cmboBoxSupsOfProd.FormattingEnabled = true;
            this.cmboBoxSupsOfProd.Location = new System.Drawing.Point(135, 53);
            this.cmboBoxSupsOfProd.Name = "cmboBoxSupsOfProd";
            this.cmboBoxSupsOfProd.Size = new System.Drawing.Size(121, 21);
            this.cmboBoxSupsOfProd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Product:";
            // 
            // cmboBoxProducts
            // 
            this.cmboBoxProducts.FormattingEnabled = true;
            this.cmboBoxProducts.Location = new System.Drawing.Point(135, 23);
            this.cmboBoxProducts.Name = "cmboBoxProducts";
            this.cmboBoxProducts.Size = new System.Drawing.Size(121, 21);
            this.cmboBoxProducts.TabIndex = 0;
            this.cmboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.cmboBoxProducts_SelectedIndexChanged);
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Location = new System.Drawing.Point(250, 241);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(75, 23);
            this.btnAddPkg.TabIndex = 21;
            this.btnAddPkg.Text = "New";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // btnEditPkg
            // 
            this.btnEditPkg.Location = new System.Drawing.Point(169, 241);
            this.btnEditPkg.Name = "btnEditPkg";
            this.btnEditPkg.Size = new System.Drawing.Size(75, 23);
            this.btnEditPkg.TabIndex = 20;
            this.btnEditPkg.Text = "Edit";
            this.btnEditPkg.UseVisualStyleBackColor = true;
            this.btnEditPkg.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pkgStartDateTextBox
            // 
            this.pkgStartDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateTextBox.Location = new System.Drawing.Point(150, 82);
            this.pkgStartDateTextBox.Name = "pkgStartDateTextBox";
            this.pkgStartDateTextBox.ReadOnly = true;
            this.pkgStartDateTextBox.Size = new System.Drawing.Size(256, 20);
            this.pkgStartDateTextBox.TabIndex = 19;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TravelExpertsData.Package);
            // 
            // pkgEndDateTextBox
            // 
            this.pkgEndDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateTextBox.Location = new System.Drawing.Point(150, 108);
            this.pkgEndDateTextBox.Name = "pkgEndDateTextBox";
            this.pkgEndDateTextBox.ReadOnly = true;
            this.pkgEndDateTextBox.Size = new System.Drawing.Size(256, 20);
            this.pkgEndDateTextBox.TabIndex = 18;
            // 
            // btnSkipToFirst
            // 
            this.btnSkipToFirst.Location = new System.Drawing.Point(150, 212);
            this.btnSkipToFirst.Name = "btnSkipToFirst";
            this.btnSkipToFirst.Size = new System.Drawing.Size(31, 23);
            this.btnSkipToFirst.TabIndex = 17;
            this.btnSkipToFirst.Text = "|<";
            this.btnSkipToFirst.UseVisualStyleBackColor = true;
            this.btnSkipToFirst.Click += new System.EventHandler(this.btnSkipToFirst_Click);
            // 
            // btnSkpToEnd
            // 
            this.btnSkpToEnd.Location = new System.Drawing.Point(313, 212);
            this.btnSkpToEnd.Name = "btnSkpToEnd";
            this.btnSkpToEnd.Size = new System.Drawing.Size(31, 23);
            this.btnSkpToEnd.TabIndex = 16;
            this.btnSkpToEnd.Text = ">|";
            this.btnSkpToEnd.UseVisualStyleBackColor = true;
            this.btnSkpToEnd.Click += new System.EventHandler(this.btnSkpToEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(250, 212);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(187, 212);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(57, 23);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.packageIdTextBox.Location = new System.Drawing.Point(150, 30);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.ReadOnly = true;
            this.packageIdTextBox.Size = new System.Drawing.Size(31, 20);
            this.packageIdTextBox.TabIndex = 1;
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(150, 186);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.ReadOnly = true;
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(82, 20);
            this.pkgAgencyCommissionTextBox.TabIndex = 3;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(150, 160);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.ReadOnly = true;
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(82, 20);
            this.pkgBasePriceTextBox.TabIndex = 5;
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(150, 134);
            this.pkgDescTextBox.Multiline = true;
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.ReadOnly = true;
            this.pkgDescTextBox.Size = new System.Drawing.Size(256, 20);
            this.pkgDescTextBox.TabIndex = 7;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(150, 56);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.ReadOnly = true;
            this.pkgNameTextBox.Size = new System.Drawing.Size(256, 20);
            this.pkgNameTextBox.TabIndex = 11;
            // 
            // tbProds
            // 
            this.tbProds.Location = new System.Drawing.Point(4, 22);
            this.tbProds.Name = "tbProds";
            this.tbProds.Padding = new System.Windows.Forms.Padding(3);
            this.tbProds.Size = new System.Drawing.Size(885, 336);
            this.tbProds.TabIndex = 1;
            this.tbProds.Text = "Products";
            this.tbProds.UseVisualStyleBackColor = true;
            // 
            // tbSuppliers
            // 
            this.tbSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tbSuppliers.Name = "tbSuppliers";
            this.tbSuppliers.Size = new System.Drawing.Size(885, 336);
            this.tbSuppliers.TabIndex = 3;
            this.tbSuppliers.Text = "Suppliers";
            this.tbSuppliers.UseVisualStyleBackColor = true;
            // 
            // tbProdSupp
            // 
            this.tbProdSupp.Controls.Add(this.btnFirstItem);
            this.tbProdSupp.Controls.Add(this.btnRemoveSupplier);
            this.tbProdSupp.Controls.Add(this.btnLastItem);
            this.tbProdSupp.Controls.Add(this.gbAddSupplier);
            this.tbProdSupp.Controls.Add(this.txtPSProdName);
            this.tbProdSupp.Controls.Add(this.btnNextItem);
            this.tbProdSupp.Controls.Add(this.txtPSProdID);
            this.tbProdSupp.Controls.Add(this.lblPSProductName);
            this.tbProdSupp.Controls.Add(this.btnPreviousItem);
            this.tbProdSupp.Controls.Add(this.lblPSProductID);
            this.tbProdSupp.Controls.Add(this.lblPSSuppliers);
            this.tbProdSupp.Controls.Add(this.dataGridViewProdSuppliers);
            this.tbProdSupp.Location = new System.Drawing.Point(4, 22);
            this.tbProdSupp.Name = "tbProdSupp";
            this.tbProdSupp.Padding = new System.Windows.Forms.Padding(3);
            this.tbProdSupp.Size = new System.Drawing.Size(885, 336);
            this.tbProdSupp.TabIndex = 2;
            this.tbProdSupp.Text = "Product Suppliers";
            this.tbProdSupp.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.Location = new System.Drawing.Point(322, 305);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(96, 23);
            this.btnRemoveSupplier.TabIndex = 2;
            this.btnRemoveSupplier.Text = "Remove Supplier";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.btnRemoveSupplier_Click);
            // 
            // gbAddSupplier
            // 
            this.gbAddSupplier.Controls.Add(this.btnAddSupplier);
            this.gbAddSupplier.Controls.Add(this.lstboxSuppliers);
            this.gbAddSupplier.Location = new System.Drawing.Point(486, 13);
            this.gbAddSupplier.Name = "gbAddSupplier";
            this.gbAddSupplier.Size = new System.Drawing.Size(364, 302);
            this.gbAddSupplier.TabIndex = 8;
            this.gbAddSupplier.TabStop = false;
            this.gbAddSupplier.Text = "Add Product Supplier";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(261, 20);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(91, 23);
            this.btnAddSupplier.TabIndex = 1;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lstboxSuppliers
            // 
            this.lstboxSuppliers.FormattingEnabled = true;
            this.lstboxSuppliers.Location = new System.Drawing.Point(17, 20);
            this.lstboxSuppliers.Name = "lstboxSuppliers";
            this.lstboxSuppliers.Size = new System.Drawing.Size(232, 264);
            this.lstboxSuppliers.TabIndex = 0;
            // 
            // txtPSProdName
            // 
            this.txtPSProdName.Location = new System.Drawing.Point(276, 13);
            this.txtPSProdName.Name = "txtPSProdName";
            this.txtPSProdName.ReadOnly = true;
            this.txtPSProdName.Size = new System.Drawing.Size(142, 20);
            this.txtPSProdName.TabIndex = 7;
            // 
            // txtPSProdID
            // 
            this.txtPSProdID.Location = new System.Drawing.Point(95, 13);
            this.txtPSProdID.Name = "txtPSProdID";
            this.txtPSProdID.ReadOnly = true;
            this.txtPSProdID.Size = new System.Drawing.Size(61, 20);
            this.txtPSProdID.TabIndex = 6;
            // 
            // lblPSProductName
            // 
            this.lblPSProductName.AutoSize = true;
            this.lblPSProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSProductName.Location = new System.Drawing.Point(183, 17);
            this.lblPSProductName.Name = "lblPSProductName";
            this.lblPSProductName.Size = new System.Drawing.Size(97, 16);
            this.lblPSProductName.TabIndex = 4;
            this.lblPSProductName.Text = "Product Name:";
            // 
            // lblPSProductID
            // 
            this.lblPSProductID.AutoSize = true;
            this.lblPSProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSProductID.Location = new System.Drawing.Point(16, 17);
            this.lblPSProductID.Name = "lblPSProductID";
            this.lblPSProductID.Size = new System.Drawing.Size(73, 16);
            this.lblPSProductID.TabIndex = 3;
            this.lblPSProductID.Text = "Product ID:";
            // 
            // lblPSSuppliers
            // 
            this.lblPSSuppliers.AutoSize = true;
            this.lblPSSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSSuppliers.Location = new System.Drawing.Point(16, 55);
            this.lblPSSuppliers.Name = "lblPSSuppliers";
            this.lblPSSuppliers.Size = new System.Drawing.Size(65, 16);
            this.lblPSSuppliers.TabIndex = 1;
            this.lblPSSuppliers.Text = "Suppliers";
            // 
            // dataGridViewProdSuppliers
            // 
            this.dataGridViewProdSuppliers.AllowUserToAddRows = false;
            this.dataGridViewProdSuppliers.AllowUserToDeleteRows = false;
            this.dataGridViewProdSuppliers.AllowUserToResizeColumns = false;
            this.dataGridViewProdSuppliers.AllowUserToResizeRows = false;
            this.dataGridViewProdSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdSuppliers.Location = new System.Drawing.Point(19, 80);
            this.dataGridViewProdSuppliers.Name = "dataGridViewProdSuppliers";
            this.dataGridViewProdSuppliers.ReadOnly = true;
            this.dataGridViewProdSuppliers.Size = new System.Drawing.Size(399, 217);
            this.dataGridViewProdSuppliers.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Travel Experts";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(860, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFirstItem
            // 
            this.btnFirstItem.Location = new System.Drawing.Point(21, 305);
            this.btnFirstItem.Name = "btnFirstItem";
            this.btnFirstItem.Size = new System.Drawing.Size(31, 23);
            this.btnFirstItem.TabIndex = 21;
            this.btnFirstItem.Text = "|<";
            this.btnFirstItem.UseVisualStyleBackColor = true;
            this.btnFirstItem.Click += new System.EventHandler(this.btnFirstItem_Click);
            // 
            // btnLastItem
            // 
            this.btnLastItem.Location = new System.Drawing.Point(184, 305);
            this.btnLastItem.Name = "btnLastItem";
            this.btnLastItem.Size = new System.Drawing.Size(31, 23);
            this.btnLastItem.TabIndex = 20;
            this.btnLastItem.Text = ">|";
            this.btnLastItem.UseVisualStyleBackColor = true;
            this.btnLastItem.Click += new System.EventHandler(this.btnLastItem_Click);
            // 
            // btnNextItem
            // 
            this.btnNextItem.Location = new System.Drawing.Point(121, 305);
            this.btnNextItem.Name = "btnNextItem";
            this.btnNextItem.Size = new System.Drawing.Size(57, 23);
            this.btnNextItem.TabIndex = 19;
            this.btnNextItem.Text = "Next";
            this.btnNextItem.UseVisualStyleBackColor = true;
            this.btnNextItem.Click += new System.EventHandler(this.btnNextItem_Click);
            // 
            // btnPreviousItem
            // 
            this.btnPreviousItem.Location = new System.Drawing.Point(58, 305);
            this.btnPreviousItem.Name = "btnPreviousItem";
            this.btnPreviousItem.Size = new System.Drawing.Size(57, 23);
            this.btnPreviousItem.TabIndex = 18;
            this.btnPreviousItem.Text = "Previous";
            this.btnPreviousItem.UseVisualStyleBackColor = true;
            this.btnPreviousItem.Click += new System.EventHandler(this.btnPreviousItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(922, 473);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mainTabControl);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tbPkgs.ResumeLayout(false);
            this.tbPkgs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViewPkgProds)).EndInit();
            this.grpBoxAddProdToPkg.ResumeLayout(false);
            this.grpBoxAddProdToPkg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.tbProdSupp.ResumeLayout(false);
            this.tbProdSupp.PerformLayout();
            this.gbAddSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tbPkgs;
        private System.Windows.Forms.TabPage tbProds;
        private System.Windows.Forms.TabPage tbSuppliers;
        private System.Windows.Forms.TabPage tbProdSupp;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.Button btnSkipToFirst;
        private System.Windows.Forms.Button btnSkpToEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TextBox pkgEndDateTextBox;
        private System.Windows.Forms.TextBox pkgStartDateTextBox;
        private System.Windows.Forms.Button btnEditPkg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.GroupBox grpBoxAddProdToPkg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBoxProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboBoxSupsOfProd;
        private System.Windows.Forms.Button btnAddProdToPkg;
        private System.Windows.Forms.DataGridView dataGrdViewPkgProds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtPSProdName;
        private System.Windows.Forms.TextBox txtPSProdID;
        private System.Windows.Forms.Label lblPSProductName;
        private System.Windows.Forms.Label lblPSProductID;
        private System.Windows.Forms.Label lblPSSuppliers;
        private System.Windows.Forms.DataGridView dataGridViewProdSuppliers;
        private System.Windows.Forms.GroupBox gbAddSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.ListBox lstboxSuppliers;
        private System.Windows.Forms.Button btnFirstItem;
        private System.Windows.Forms.Button btnLastItem;
        private System.Windows.Forms.Button btnNextItem;
        private System.Windows.Forms.Button btnPreviousItem;
        private System.Windows.Forms.Button btnRemoveSupplier;
    }
}

