namespace Impendulo.Courses.InputForms.Deployment
{
    partial class frmAddModules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddModules));
            this.bindingSourceAvailableModules = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceLinkedModules = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.lstLinkedModules = new System.Windows.Forms.ListBox();
            this.bindingNavigatorLinkedModules = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLinkModule = new System.Windows.Forms.Button();
            this.btnRemoveModule = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxModules = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartments = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.lstAvailableModules = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtModuleFilterCriteria = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilterModule = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresModuleSearch = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAvailableModules = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtModuleBindingNavigator = new System.Windows.Forms.ToolStripTextBox();
            this.btnAddNewModule = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAvailableModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLinkedModules)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLinkedModules)).BeginInit();
            this.bindingNavigatorLinkedModules.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxModules.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAvailableModules)).BeginInit();
            this.bindingNavigatorAvailableModules.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceAvailableModules
            // 
            this.bindingSourceAvailableModules.DataSource = this.bindingSourceLinkedModules;
            // 
            // bindingSourceLinkedModules
            // 
            this.bindingSourceLinkedModules.DataSource = typeof(Impendulo.Data.Models.Module);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStripContainer2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(543, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 459);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linked Modules";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.lstLinkedModules);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(432, 413);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(432, 440);
            this.toolStripContainer2.TabIndex = 1;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.bindingNavigatorLinkedModules);
            // 
            // lstLinkedModules
            // 
            this.lstLinkedModules.DataSource = this.bindingSourceLinkedModules;
            this.lstLinkedModules.DisplayMember = "ModuleName";
            this.lstLinkedModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLinkedModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLinkedModules.FormattingEnabled = true;
            this.lstLinkedModules.ItemHeight = 16;
            this.lstLinkedModules.Location = new System.Drawing.Point(0, 0);
            this.lstLinkedModules.Name = "lstLinkedModules";
            this.lstLinkedModules.Size = new System.Drawing.Size(432, 413);
            this.lstLinkedModules.TabIndex = 0;
            this.lstLinkedModules.ValueMember = "ModuleID";
            // 
            // bindingNavigatorLinkedModules
            // 
            this.bindingNavigatorLinkedModules.AddNewItem = null;
            this.bindingNavigatorLinkedModules.BindingSource = this.bindingSourceLinkedModules;
            this.bindingNavigatorLinkedModules.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorLinkedModules.DeleteItem = null;
            this.bindingNavigatorLinkedModules.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorLinkedModules.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorLinkedModules.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator5});
            this.bindingNavigatorLinkedModules.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorLinkedModules.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorLinkedModules.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorLinkedModules.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorLinkedModules.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorLinkedModules.Name = "bindingNavigatorLinkedModules";
            this.bindingNavigatorLinkedModules.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorLinkedModules.Size = new System.Drawing.Size(432, 27);
            this.bindingNavigatorLinkedModules.Stretch = true;
            this.bindingNavigatorLinkedModules.TabIndex = 0;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btnLinkModule
            // 
            this.btnLinkModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLinkModule.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkModule.Image")));
            this.btnLinkModule.Location = new System.Drawing.Point(3, 3);
            this.btnLinkModule.Name = "btnLinkModule";
            this.btnLinkModule.Size = new System.Drawing.Size(80, 60);
            this.btnLinkModule.TabIndex = 2;
            this.btnLinkModule.UseVisualStyleBackColor = true;
            this.btnLinkModule.Click += new System.EventHandler(this.btnLinkModule_Click);
            // 
            // btnRemoveModule
            // 
            this.btnRemoveModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveModule.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveModule.Image")));
            this.btnRemoveModule.Location = new System.Drawing.Point(3, 83);
            this.btnRemoveModule.Name = "btnRemoveModule";
            this.btnRemoveModule.Size = new System.Drawing.Size(80, 61);
            this.btnRemoveModule.TabIndex = 3;
            this.btnRemoveModule.UseVisualStyleBackColor = true;
            this.btnRemoveModule.Click += new System.EventHandler(this.btnRemoveModule_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxModules, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 465);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBoxModules
            // 
            this.groupBoxModules.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxModules.Location = new System.Drawing.Point(3, 3);
            this.groupBoxModules.Name = "groupBoxModules";
            this.groupBoxModules.Size = new System.Drawing.Size(436, 459);
            this.groupBoxModules.TabIndex = 6;
            this.groupBoxModules.TabStop = false;
            this.groupBoxModules.Text = "Available Modules";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.toolStripContainer1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(430, 440);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 54);
            this.panel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboDepartments);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 54);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Depaerment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Departments";
            // 
            // cboDepartments
            // 
            this.cboDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDepartments.DataSource = this.departmentBindingSource;
            this.cboDepartments.DisplayMember = "DepartmentName";
            this.cboDepartments.FormattingEnabled = true;
            this.cboDepartments.Location = new System.Drawing.Point(74, 21);
            this.cboDepartments.Name = "cboDepartments";
            this.cboDepartments.Size = new System.Drawing.Size(286, 21);
            this.cboDepartments.TabIndex = 3;
            this.cboDepartments.ValueMember = "DepartmentID";
            this.cboDepartments.SelectedIndexChanged += new System.EventHandler(this.cboDepartments_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupDepartment);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lstAvailableModules);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(424, 320);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 63);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(424, 374);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindingNavigatorAvailableModules);
            // 
            // lstAvailableModules
            // 
            this.lstAvailableModules.DataSource = this.bindingSourceAvailableModules;
            this.lstAvailableModules.DisplayMember = "ModuleName";
            this.lstAvailableModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAvailableModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAvailableModules.FormattingEnabled = true;
            this.lstAvailableModules.ItemHeight = 16;
            this.lstAvailableModules.Location = new System.Drawing.Point(0, 0);
            this.lstAvailableModules.Name = "lstAvailableModules";
            this.lstAvailableModules.Size = new System.Drawing.Size(424, 320);
            this.lstAvailableModules.TabIndex = 0;
            this.lstAvailableModules.ValueMember = "ModuleID";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.txtModuleFilterCriteria,
            this.toolStripSeparator2,
            this.btnFilterModule,
            this.tsbtnRefresModuleSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(424, 27);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 24);
            this.toolStripLabel1.Text = "Filter";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // txtModuleFilterCriteria
            // 
            this.txtModuleFilterCriteria.Name = "txtModuleFilterCriteria";
            this.txtModuleFilterCriteria.Size = new System.Drawing.Size(150, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnFilterModule
            // 
            this.btnFilterModule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilterModule.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterModule.Image")));
            this.btnFilterModule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterModule.Name = "btnFilterModule";
            this.btnFilterModule.Size = new System.Drawing.Size(24, 24);
            this.btnFilterModule.Text = "toolStripButton1";
            this.btnFilterModule.Click += new System.EventHandler(this.btnFilterModule_Click);
            // 
            // tsbtnRefresModuleSearch
            // 
            this.tsbtnRefresModuleSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefresModuleSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresModuleSearch.Image")));
            this.tsbtnRefresModuleSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresModuleSearch.Name = "tsbtnRefresModuleSearch";
            this.tsbtnRefresModuleSearch.Size = new System.Drawing.Size(24, 24);
            this.tsbtnRefresModuleSearch.Text = "toolStripButton2";
            this.tsbtnRefresModuleSearch.Click += new System.EventHandler(this.tsbtnRefresModuleSearch_Click);
            // 
            // bindingNavigatorAvailableModules
            // 
            this.bindingNavigatorAvailableModules.AddNewItem = null;
            this.bindingNavigatorAvailableModules.BindingSource = this.bindingSourceAvailableModules;
            this.bindingNavigatorAvailableModules.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorAvailableModules.DeleteItem = null;
            this.bindingNavigatorAvailableModules.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorAvailableModules.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorAvailableModules.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.txtModuleBindingNavigator,
            this.btnAddNewModule});
            this.bindingNavigatorAvailableModules.Location = new System.Drawing.Point(0, 27);
            this.bindingNavigatorAvailableModules.MoveFirstItem = null;
            this.bindingNavigatorAvailableModules.MoveLastItem = null;
            this.bindingNavigatorAvailableModules.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorAvailableModules.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorAvailableModules.Name = "bindingNavigatorAvailableModules";
            this.bindingNavigatorAvailableModules.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorAvailableModules.Size = new System.Drawing.Size(424, 27);
            this.bindingNavigatorAvailableModules.Stretch = true;
            this.bindingNavigatorAvailableModules.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // txtModuleBindingNavigator
            // 
            this.txtModuleBindingNavigator.Name = "txtModuleBindingNavigator";
            this.txtModuleBindingNavigator.Size = new System.Drawing.Size(175, 27);
            // 
            // btnAddNewModule
            // 
            this.btnAddNewModule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNewModule.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewModule.Image")));
            this.btnAddNewModule.Name = "btnAddNewModule";
            this.btnAddNewModule.RightToLeftAutoMirrorImage = true;
            this.btnAddNewModule.Size = new System.Drawing.Size(24, 24);
            this.btnAddNewModule.Text = "Add new";
            this.btnAddNewModule.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(445, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(92, 459);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 147);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveModule, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnLinkModule, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(86, 147);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // frmAddModules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddModules";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Modules";
            this.Load += new System.EventHandler(this.frmAddTrainingDepartmentCourseEnrollmentTypeModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAvailableModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLinkedModules)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLinkedModules)).EndInit();
            this.bindingNavigatorLinkedModules.ResumeLayout(false);
            this.bindingNavigatorLinkedModules.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxModules.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAvailableModules)).EndInit();
            this.bindingNavigatorAvailableModules.ResumeLayout(false);
            this.bindingNavigatorAvailableModules.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstLinkedModules;
        private System.Windows.Forms.Button btnLinkModule;
        private System.Windows.Forms.Button btnRemoveModule;
        private System.Windows.Forms.BindingSource bindingSourceAvailableModules;
        private System.Windows.Forms.BindingSource bindingSourceLinkedModules;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.BindingNavigator bindingNavigatorLinkedModules;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxModules;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDepartments;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ListBox lstAvailableModules;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtModuleFilterCriteria;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnFilterModule;
        private System.Windows.Forms.ToolStripButton tsbtnRefresModuleSearch;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAvailableModules;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtModuleBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAddNewModule;
        private System.Windows.Forms.BindingSource departmentBindingSource;
    }
}