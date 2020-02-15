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
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgEndDateLabel1;
            System.Windows.Forms.Label pkgStartDateLabel1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            //this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.ComProductId = new System.Windows.Forms.ComboBox();
            this.ViewProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnModifyProducts = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.tbSuppliers = new System.Windows.Forms.TabPage();
            this.tbProdSupp = new System.Windows.Forms.TabPage();
            this.btnFirstItem = new System.Windows.Forms.Button();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.btnLastItem = new System.Windows.Forms.Button();
            this.gbAddSupplier = new System.Windows.Forms.GroupBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.lstboxSuppliers = new System.Windows.Forms.ListBox();
            this.txtPSProdName = new System.Windows.Forms.TextBox();
            this.btnNextItem = new System.Windows.Forms.Button();
            this.txtPSProdID = new System.Windows.Forms.TextBox();
            this.lblPSProductName = new System.Windows.Forms.Label();
            this.btnPreviousItem = new System.Windows.Forms.Button();
            this.lblPSProductID = new System.Windows.Forms.Label();
            this.lblPSSuppliers = new System.Windows.Forms.Label();
            this.dataGridViewProdSuppliers = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel1 = new System.Windows.Forms.Label();
            pkgStartDateLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbPkgs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViewPkgProds)).BeginInit();
            this.grpBoxAddProdToPkg.SuspendLayout();

            this.tbProds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProducts)).BeginInit();

            //((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.tbProdSupp.SuspendLayout();
            this.gbAddSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSuppliers)).BeginInit();

            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(24, 41);
            packageIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(23, 17);
            packageIdLabel.TabIndex = 0;
            packageIdLabel.Text = "Id:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(24, 233);
            pkgAgencyCommissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(138, 17);
            pkgAgencyCommissionLabel.TabIndex = 2;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(24, 201);
            pkgBasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(44, 17);
            pkgBasePriceLabel.TabIndex = 4;
            pkgBasePriceLabel.Text = "Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(24, 169);
            pkgDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(83, 17);
            pkgDescLabel.TabIndex = 6;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(24, 73);
            pkgNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(49, 17);
            pkgNameLabel.TabIndex = 10;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgEndDateLabel1
            // 
            pkgEndDateLabel1.AutoSize = true;
            pkgEndDateLabel1.Location = new System.Drawing.Point(24, 133);
            pkgEndDateLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgEndDateLabel1.Name = "pkgEndDateLabel1";
            pkgEndDateLabel1.Size = new System.Drawing.Size(71, 17);
            pkgEndDateLabel1.TabIndex = 17;
            pkgEndDateLabel1.Text = "End Date:";
            // 
            // pkgStartDateLabel1
            // 
            pkgStartDateLabel1.AutoSize = true;
            pkgStartDateLabel1.Location = new System.Drawing.Point(24, 101);
            pkgStartDateLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgStartDateLabel1.Name = "pkgStartDateLabel1";
            pkgStartDateLabel1.Size = new System.Drawing.Size(76, 17);
            pkgStartDateLabel1.TabIndex = 18;
            pkgStartDateLabel1.Text = "Start Date:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPkgs);
            this.tabControl1.Controls.Add(this.tbProds);
            this.tabControl1.Controls.Add(this.tbSuppliers);
            this.tabControl1.Controls.Add(this.tbProdSupp);
            this.tabControl1.Location = new System.Drawing.Point(16, 82);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1191, 446);
            this.tabControl1.TabIndex = 0;

            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);

            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);

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
            this.tbPkgs.Location = new System.Drawing.Point(4, 25);

            this.tbPkgs.Margin = new System.Windows.Forms.Padding(4);
            this.tbPkgs.Name = "tbPkgs";
            this.tbPkgs.Padding = new System.Windows.Forms.Padding(4);

            this.tbPkgs.Size = new System.Drawing.Size(1183, 417);
            this.tbPkgs.TabIndex = 0;
            this.tbPkgs.Text = "Packages";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 377);

            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);

            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
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
            this.dataGrdViewPkgProds.Location = new System.Drawing.Point(581, 49);

            this.dataGrdViewPkgProds.Margin = new System.Windows.Forms.Padding(4);

            this.dataGrdViewPkgProds.Name = "dataGrdViewPkgProds";
            this.dataGrdViewPkgProds.ReadOnly = true;
            this.dataGrdViewPkgProds.RowHeadersWidth = 51;
            this.dataGrdViewPkgProds.Size = new System.Drawing.Size(591, 185);
            this.dataGrdViewPkgProds.TabIndex = 23;
            // 
            // colProdName
            // 
            this.colProdName.HeaderText = "Product Name";
            this.colProdName.MinimumWidth = 6;
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            this.colProdName.Width = 125;
            // 
            // colProdSupplier
            // 
            this.colProdSupplier.HeaderText = "Supplier";
            this.colProdSupplier.MinimumWidth = 6;
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
            this.grpBoxAddProdToPkg.Location = new System.Drawing.Point(581, 241);

            this.grpBoxAddProdToPkg.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxAddProdToPkg.Name = "grpBoxAddProdToPkg";
            this.grpBoxAddProdToPkg.Padding = new System.Windows.Forms.Padding(4);

            this.grpBoxAddProdToPkg.Size = new System.Drawing.Size(368, 165);
            this.grpBoxAddProdToPkg.TabIndex = 22;
            this.grpBoxAddProdToPkg.TabStop = false;
            this.grpBoxAddProdToPkg.Text = "Add Product to Package";
            // 
            // btnAddProdToPkg
            // 

            this.btnAddProdToPkg.Margin = new System.Windows.Forms.Padding(4);

            this.btnAddProdToPkg.Name = "btnAddProdToPkg";
            this.btnAddProdToPkg.Size = new System.Drawing.Size(100, 28);
            this.btnAddProdToPkg.TabIndex = 4;
            this.btnAddProdToPkg.Text = "Add";
            this.btnAddProdToPkg.UseVisualStyleBackColor = true;
            this.btnAddProdToPkg.Click += new System.EventHandler(this.btnAddProdToPkg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a Supplier:";
            // 
            // cmboBoxSupsOfProd
            // 
            this.cmboBoxSupsOfProd.FormattingEnabled = true;
            this.cmboBoxSupsOfProd.Location = new System.Drawing.Point(180, 65);

            this.cmboBoxSupsOfProd.Margin = new System.Windows.Forms.Padding(4);

            this.cmboBoxSupsOfProd.Name = "cmboBoxSupsOfProd";
            this.cmboBoxSupsOfProd.Size = new System.Drawing.Size(160, 24);
            this.cmboBoxSupsOfProd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Product:";
            // 
            // cmboBoxProducts
            // 
            this.cmboBoxProducts.FormattingEnabled = true;
            this.cmboBoxProducts.Location = new System.Drawing.Point(180, 28);

            this.cmboBoxProducts.Margin = new System.Windows.Forms.Padding(4);

            this.cmboBoxProducts.Name = "cmboBoxProducts";
            this.cmboBoxProducts.Size = new System.Drawing.Size(160, 24);
            this.cmboBoxProducts.TabIndex = 0;
            this.cmboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.cmboBoxProducts_SelectedIndexChanged);
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Location = new System.Drawing.Point(333, 297);

            this.btnAddPkg.Margin = new System.Windows.Forms.Padding(4);

            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(100, 28);
            this.btnAddPkg.TabIndex = 21;
            this.btnAddPkg.Text = "New";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // btnEditPkg
            // 
            this.btnEditPkg.Location = new System.Drawing.Point(225, 297);

            this.btnEditPkg.Margin = new System.Windows.Forms.Padding(4);

            this.btnEditPkg.Name = "btnEditPkg";
            this.btnEditPkg.Size = new System.Drawing.Size(100, 28);
            this.btnEditPkg.TabIndex = 20;
            this.btnEditPkg.Text = "Edit";
            this.btnEditPkg.UseVisualStyleBackColor = true;
            this.btnEditPkg.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pkgStartDateTextBox
            // 

            this.pkgStartDateTextBox.Location = new System.Drawing.Point(200, 101);
            this.pkgStartDateTextBox.Margin = new System.Windows.Forms.Padding(4);

            //this.pkgStartDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgStartDate", true));

            this.pkgStartDateTextBox.Name = "pkgStartDateTextBox";
            this.pkgStartDateTextBox.ReadOnly = true;
            this.pkgStartDateTextBox.Size = new System.Drawing.Size(340, 22);
            this.pkgStartDateTextBox.TabIndex = 19;
            // 
            // packageBindingSource
            // 
            //this.packageBindingSource.DataSource = typeof(TravelExpertsData.Package);
            // 
            // pkgEndDateTextBox
            // 

            this.pkgEndDateTextBox.Location = new System.Drawing.Point(200, 133);
            this.pkgEndDateTextBox.Margin = new System.Windows.Forms.Padding(4);

            //this.pkgEndDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgEndDate", true));

            this.pkgEndDateTextBox.Name = "pkgEndDateTextBox";
            this.pkgEndDateTextBox.ReadOnly = true;
            this.pkgEndDateTextBox.Size = new System.Drawing.Size(340, 22);
            this.pkgEndDateTextBox.TabIndex = 18;
            // 
            // btnSkipToFirst
            // 
            this.btnSkipToFirst.Location = new System.Drawing.Point(200, 261);

            this.btnSkipToFirst.Margin = new System.Windows.Forms.Padding(4);

            this.btnSkipToFirst.Name = "btnSkipToFirst";
            this.btnSkipToFirst.Size = new System.Drawing.Size(41, 28);
            this.btnSkipToFirst.TabIndex = 17;
            this.btnSkipToFirst.Text = "|<";
            this.btnSkipToFirst.UseVisualStyleBackColor = true;
            this.btnSkipToFirst.Click += new System.EventHandler(this.btnSkipToFirst_Click);
            // 
            // btnSkpToEnd
            // 
            this.btnSkpToEnd.Location = new System.Drawing.Point(417, 261);

            this.btnSkpToEnd.Margin = new System.Windows.Forms.Padding(4);

            this.btnSkpToEnd.Name = "btnSkpToEnd";
            this.btnSkpToEnd.Size = new System.Drawing.Size(41, 28);
            this.btnSkpToEnd.TabIndex = 16;
            this.btnSkpToEnd.Text = ">|";
            this.btnSkpToEnd.UseVisualStyleBackColor = true;
            this.btnSkpToEnd.Click += new System.EventHandler(this.btnSkpToEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(333, 261);

            this.btnNext.Margin = new System.Windows.Forms.Padding(4);

            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 28);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(249, 261);

            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);

            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(76, 28);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // packageIdTextBox
            // 

            this.packageIdTextBox.Location = new System.Drawing.Point(200, 37);
            this.packageIdTextBox.Margin = new System.Windows.Forms.Padding(4);

            //this.packageIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));

            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.ReadOnly = true;
            this.packageIdTextBox.Size = new System.Drawing.Size(40, 22);
            this.packageIdTextBox.TabIndex = 1;
            // 
            // pkgAgencyCommissionTextBox
            // 

            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(200, 229);
            this.pkgAgencyCommissionTextBox.Margin = new System.Windows.Forms.Padding(4);

            //this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));

            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.ReadOnly = true;
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(108, 22);
            this.pkgAgencyCommissionTextBox.TabIndex = 3;
            // 
            // pkgBasePriceTextBox
            // 

            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(200, 197);
            this.pkgBasePriceTextBox.Margin = new System.Windows.Forms.Padding(4);

            //this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));

            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.ReadOnly = true;
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(108, 22);
            this.pkgBasePriceTextBox.TabIndex = 5;
            // 
            // pkgDescTextBox
            // 

            this.pkgDescTextBox.Location = new System.Drawing.Point(200, 165);
            this.pkgDescTextBox.Margin = new System.Windows.Forms.Padding(4);

            //this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));

            this.pkgDescTextBox.Multiline = true;
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.ReadOnly = true;
            this.pkgDescTextBox.Size = new System.Drawing.Size(340, 24);
            this.pkgDescTextBox.TabIndex = 7;
            // 
            // pkgNameTextBox
            // 

            this.pkgNameTextBox.Location = new System.Drawing.Point(200, 69);
            this.pkgNameTextBox.Margin = new System.Windows.Forms.Padding(4);

            //this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));

            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.ReadOnly = true;
            this.pkgNameTextBox.Size = new System.Drawing.Size(340, 22);
            this.pkgNameTextBox.TabIndex = 11;
            // 
            // tbProds
            // 

            this.tbProds.Controls.Add(this.ComProductId);
            this.tbProds.Controls.Add(this.ViewProducts);
            this.tbProds.Controls.Add(this.btnAddProducts);
            this.tbProds.Controls.Add(this.btnModifyProducts);
            this.tbProds.Controls.Add(this.txtProductName);
            this.tbProds.Controls.Add(this.lblProductName);
            this.tbProds.Controls.Add(this.lblProductID);
            this.tbProds.Location = new System.Drawing.Point(4, 25);
            this.tbProds.Margin = new System.Windows.Forms.Padding(4);
            this.tbProds.Name = "tbProds";
            this.tbProds.Padding = new System.Windows.Forms.Padding(4);

            this.tbProds.Size = new System.Drawing.Size(1183, 417);
            this.tbProds.TabIndex = 1;
            this.tbProds.Text = "Products";
            this.tbProds.UseVisualStyleBackColor = true;
            // 
            // ComProductId
            // 
            this.ComProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComProductId.FormattingEnabled = true;
            this.ComProductId.Location = new System.Drawing.Point(294, 72);
            this.ComProductId.Name = "ComProductId";
            this.ComProductId.Size = new System.Drawing.Size(232, 28);
            this.ComProductId.TabIndex = 8;
            this.ComProductId.SelectedValueChanged += new System.EventHandler(this.ComProductId_SelectedValueChanged);
            // 
            // ViewProducts
            // 
            this.ViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewProducts.Location = new System.Drawing.Point(95, 218);
            this.ViewProducts.Name = "ViewProducts";
            this.ViewProducts.RowHeadersWidth = 51;
            this.ViewProducts.RowTemplate.Height = 24;
            this.ViewProducts.Size = new System.Drawing.Size(510, 182);
            this.ViewProducts.TabIndex = 7;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(432, 164);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(173, 34);
            this.btnAddProducts.TabIndex = 6;
            this.btnAddProducts.Text = "Add";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnModifyProducts
            // 
            this.btnModifyProducts.Location = new System.Drawing.Point(199, 164);
            this.btnModifyProducts.Name = "btnModifyProducts";
            this.btnModifyProducts.Size = new System.Drawing.Size(166, 34);
            this.btnModifyProducts.TabIndex = 5;
            this.btnModifyProducts.Text = "Modify";
            this.btnModifyProducts.UseVisualStyleBackColor = true;
            this.btnModifyProducts.Click += new System.EventHandler(this.btnModifyProducts_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(294, 118);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(232, 28);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(87, 118);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(194, 40);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductID
            // 
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(91, 75);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(157, 23);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSuppliers
            // 
            this.tbSuppliers.Location = new System.Drawing.Point(4, 25);

            this.tbSuppliers.Margin = new System.Windows.Forms.Padding(4);

            this.tbSuppliers.Name = "tbSuppliers";
            this.tbSuppliers.Size = new System.Drawing.Size(1183, 417);
            this.tbSuppliers.TabIndex = 3;
            this.tbSuppliers.Text = "Suppliers";
            this.tbSuppliers.UseVisualStyleBackColor = true;
            // 
            // tbProdSupp
            // 

            this.tbProdSupp.Location = new System.Drawing.Point(4, 25);
            this.tbProdSupp.Margin = new System.Windows.Forms.Padding(4);
            this.tbProdSupp.Name = "tbProdSupp";
            this.tbProdSupp.Padding = new System.Windows.Forms.Padding(4);

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
            /*this.tbProdSupp.Location = new System.Drawing.Point(4, 25);
            this.tbProdSupp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProdSupp.Name = "tbProdSupp";
            this.tbProdSupp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);*/

            this.tbProdSupp.Size = new System.Drawing.Size(1183, 417);
            this.tbProdSupp.TabIndex = 2;
            this.tbProdSupp.Text = "Product Suppliers";
            this.tbProdSupp.UseVisualStyleBackColor = true;
            // 
            // btnFirstItem
            // 
            this.btnFirstItem.Location = new System.Drawing.Point(28, 375);
            this.btnFirstItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirstItem.Name = "btnFirstItem";
            this.btnFirstItem.Size = new System.Drawing.Size(41, 28);
            this.btnFirstItem.TabIndex = 21;
            this.btnFirstItem.Text = "|<";
            this.btnFirstItem.UseVisualStyleBackColor = true;
            this.btnFirstItem.Click += new System.EventHandler(this.btnFirstItem_Click);
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.Location = new System.Drawing.Point(429, 375);
            this.btnRemoveSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(128, 28);
            this.btnRemoveSupplier.TabIndex = 2;
            this.btnRemoveSupplier.Text = "Remove Supplier";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.btnRemoveSupplier_Click);
            // 
            // btnLastItem
            // 
            this.btnLastItem.Location = new System.Drawing.Point(245, 375);
            this.btnLastItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLastItem.Name = "btnLastItem";
            this.btnLastItem.Size = new System.Drawing.Size(41, 28);
            this.btnLastItem.TabIndex = 20;
            this.btnLastItem.Text = ">|";
            this.btnLastItem.UseVisualStyleBackColor = true;
            this.btnLastItem.Click += new System.EventHandler(this.btnLastItem_Click);
            // 
            // gbAddSupplier
            // 
            this.gbAddSupplier.Controls.Add(this.btnAddSupplier);
            this.gbAddSupplier.Controls.Add(this.lstboxSuppliers);
            this.gbAddSupplier.Location = new System.Drawing.Point(648, 16);
            this.gbAddSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddSupplier.Name = "gbAddSupplier";
            this.gbAddSupplier.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddSupplier.Size = new System.Drawing.Size(485, 372);
            this.gbAddSupplier.TabIndex = 8;
            this.gbAddSupplier.TabStop = false;
            this.gbAddSupplier.Text = "Add Product Supplier";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(348, 25);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(121, 28);
            this.btnAddSupplier.TabIndex = 1;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lstboxSuppliers
            // 
            this.lstboxSuppliers.FormattingEnabled = true;
            this.lstboxSuppliers.ItemHeight = 16;
            this.lstboxSuppliers.Location = new System.Drawing.Point(23, 25);
            this.lstboxSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstboxSuppliers.Name = "lstboxSuppliers";
            this.lstboxSuppliers.Size = new System.Drawing.Size(308, 324);
            this.lstboxSuppliers.TabIndex = 0;
            // 
            // txtPSProdName
            // 
            this.txtPSProdName.Location = new System.Drawing.Point(368, 16);
            this.txtPSProdName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPSProdName.Name = "txtPSProdName";
            this.txtPSProdName.ReadOnly = true;
            this.txtPSProdName.Size = new System.Drawing.Size(188, 22);
            this.txtPSProdName.TabIndex = 7;
            // 
            // btnNextItem
            // 
            this.btnNextItem.Location = new System.Drawing.Point(161, 375);
            this.btnNextItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextItem.Name = "btnNextItem";
            this.btnNextItem.Size = new System.Drawing.Size(76, 28);
            this.btnNextItem.TabIndex = 19;
            this.btnNextItem.Text = "Next";
            this.btnNextItem.UseVisualStyleBackColor = true;
            this.btnNextItem.Click += new System.EventHandler(this.btnNextItem_Click);
            // 
            // txtPSProdID
            // 
            this.txtPSProdID.Location = new System.Drawing.Point(127, 16);
            this.txtPSProdID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPSProdID.Name = "txtPSProdID";
            this.txtPSProdID.ReadOnly = true;
            this.txtPSProdID.Size = new System.Drawing.Size(80, 22);
            this.txtPSProdID.TabIndex = 6;
            // 
            // lblPSProductName
            // 
            this.lblPSProductName.AutoSize = true;
            this.lblPSProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSProductName.Location = new System.Drawing.Point(244, 21);
            this.lblPSProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPSProductName.Name = "lblPSProductName";
            this.lblPSProductName.Size = new System.Drawing.Size(121, 20);
            this.lblPSProductName.TabIndex = 4;
            this.lblPSProductName.Text = "Product Name:";
            // 
            // btnPreviousItem
            // 
            this.btnPreviousItem.Location = new System.Drawing.Point(77, 375);
            this.btnPreviousItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreviousItem.Name = "btnPreviousItem";
            this.btnPreviousItem.Size = new System.Drawing.Size(76, 28);
            this.btnPreviousItem.TabIndex = 18;
            this.btnPreviousItem.Text = "Previous";
            this.btnPreviousItem.UseVisualStyleBackColor = true;
            this.btnPreviousItem.Click += new System.EventHandler(this.btnPreviousItem_Click);
            // 
            // lblPSProductID
            // 
            this.lblPSProductID.AutoSize = true;
            this.lblPSProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSProductID.Location = new System.Drawing.Point(21, 21);
            this.lblPSProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPSProductID.Name = "lblPSProductID";
            this.lblPSProductID.Size = new System.Drawing.Size(94, 20);
            this.lblPSProductID.TabIndex = 3;
            this.lblPSProductID.Text = "Product ID:";
            // 
            // lblPSSuppliers
            // 
            this.lblPSSuppliers.AutoSize = true;
            this.lblPSSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSSuppliers.Location = new System.Drawing.Point(21, 68);
            this.lblPSSuppliers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPSSuppliers.Name = "lblPSSuppliers";
            this.lblPSSuppliers.Size = new System.Drawing.Size(79, 20);
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
            this.dataGridViewProdSuppliers.Location = new System.Drawing.Point(25, 98);
            this.dataGridViewProdSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewProdSuppliers.Name = "dataGridViewProdSuppliers";
            this.dataGridViewProdSuppliers.ReadOnly = true;
            this.dataGridViewProdSuppliers.RowHeadersWidth = 51;
            this.dataGridViewProdSuppliers.Size = new System.Drawing.Size(532, 267);
            this.dataGridViewProdSuppliers.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 38);

            /*this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 52);*/

            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Travel Experts";
            // 
            // btnExit
            // 

            this.btnExit.Location = new System.Drawing.Point(1147, 539);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);

            /*this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1147, 539);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);*/

            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;

            this.ClientSize = new System.Drawing.Size(1229, 580);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);

            /*this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1229, 582);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);*/

            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbPkgs.ResumeLayout(false);
            this.tbPkgs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViewPkgProds)).EndInit();
            this.grpBoxAddProdToPkg.ResumeLayout(false);
            this.grpBoxAddProdToPkg.PerformLayout();

            this.tbProds.ResumeLayout(false);
            this.tbProds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProducts)).EndInit();

            /*((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.tbProdSupp.ResumeLayout(false);
            this.tbProdSupp.PerformLayout();*/
            this.gbAddSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdSuppliers)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPkgs;
        private System.Windows.Forms.TabPage tbProds;
        private System.Windows.Forms.TabPage tbSuppliers;
        private System.Windows.Forms.TabPage tbProdSupp;
        private System.Windows.Forms.Label lblTitle;
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

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView ViewProducts;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnModifyProducts;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.ComboBox ComProductId;

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

