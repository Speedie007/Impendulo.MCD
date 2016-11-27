namespace Impendulo.Courses
{
    partial class CourseViewLinkedCoursesAndModulesV3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseViewLinkedCoursesAndModulesV3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCourseCategories = new System.Windows.Forms.ComboBox();
            this.courseCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddNewCourseCategory = new System.Windows.Forms.Button();
            this.cboTrainingDepartment = new System.Windows.Forms.ComboBox();
            this.trainingDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnLinkCourseToCategory = new System.Windows.Forms.Button();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLinkCourseModule = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.courseModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.courseModuleDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnRemoveModuleLinkedToCourse = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveModule = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.courseCategoryBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseModuleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Course Categories";
            // 
            // cboCourseCategories
            // 
            this.cboCourseCategories.DataSource = this.courseCategoryBindingSource;
            this.cboCourseCategories.DisplayMember = "CourseCategoryName";
            this.cboCourseCategories.FormattingEnabled = true;
            this.cboCourseCategories.Location = new System.Drawing.Point(178, 58);
            this.cboCourseCategories.Name = "cboCourseCategories";
            this.cboCourseCategories.Size = new System.Drawing.Size(300, 24);
            this.cboCourseCategories.TabIndex = 13;
            this.cboCourseCategories.ValueMember = "CourseCategoryID";
            this.cboCourseCategories.SelectedIndexChanged += new System.EventHandler(this.cboCourseCategories_SelectedIndexChanged);
            // 
            // courseCategoryBindingSource
            // 
           // this.courseCategoryBindingSource.DataSource = typeof(Impendulo.Data.Models.CourseCategory);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Training Departments";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddNewCourseCategory);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboCourseCategories);
            this.groupBox3.Controls.Add(this.cboTrainingDepartment);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1099, 99);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Training Departments";
            // 
            // btnAddNewCourseCategory
            // 
            this.btnAddNewCourseCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCourseCategory.Image")));
            this.btnAddNewCourseCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCourseCategory.Location = new System.Drawing.Point(484, 55);
            this.btnAddNewCourseCategory.Name = "btnAddNewCourseCategory";
            this.btnAddNewCourseCategory.Size = new System.Drawing.Size(165, 29);
            this.btnAddNewCourseCategory.TabIndex = 15;
            this.btnAddNewCourseCategory.Text = "Add New Category";
            this.btnAddNewCourseCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewCourseCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCourseCategory.Click += new System.EventHandler(this.btnAddNewCourseCategory_Click);
            // 
            // cboTrainingDepartment
            // 
            this.cboTrainingDepartment.DataSource = this.trainingDepartmentBindingSource;
            this.cboTrainingDepartment.DisplayMember = "TrainingDepartmentName";
            this.cboTrainingDepartment.FormattingEnabled = true;
            this.cboTrainingDepartment.Location = new System.Drawing.Point(178, 28);
            this.cboTrainingDepartment.Name = "cboTrainingDepartment";
            this.cboTrainingDepartment.Size = new System.Drawing.Size(300, 24);
            this.cboTrainingDepartment.TabIndex = 12;
            this.cboTrainingDepartment.ValueMember = "TrainingDepartmentID";
            this.cboTrainingDepartment.SelectedIndexChanged += new System.EventHandler(this.cboTrainingDepartment_SelectedIndexChanged);
            // 
            // trainingDepartmentBindingSource
            // 
            this.trainingDepartmentBindingSource.DataSource = typeof(Impendulo.Data.Models.TrainingDepartment);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(119, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Remove Course";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLinkCourseToCategory
            // 
            this.btnLinkCourseToCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLinkCourseToCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLinkCourseToCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkCourseToCategory.Image")));
            this.btnLinkCourseToCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinkCourseToCategory.Location = new System.Drawing.Point(287, 383);
            this.btnLinkCourseToCategory.Name = "btnLinkCourseToCategory";
            this.btnLinkCourseToCategory.Size = new System.Drawing.Size(131, 36);
            this.btnLinkCourseToCategory.TabIndex = 11;
            this.btnLinkCourseToCategory.Text = "Add Course";
            this.btnLinkCourseToCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLinkCourseToCategory.UseVisualStyleBackColor = true;
            this.btnLinkCourseToCategory.Click += new System.EventHandler(this.btnLinkCourseToCategory_Click);
            // 
            // lstCourses
            // 
            this.lstCourses.DataSource = this.courseBindingSource;
            this.lstCourses.DisplayMember = "CourseName";
            this.lstCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 20;
            this.lstCourses.Location = new System.Drawing.Point(6, 33);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(410, 344);
            this.lstCourses.TabIndex = 1;
            this.lstCourses.ValueMember = "CourseID";
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // courseBindingSource
            // 
            //this.courseBindingSource.DataSource = typeof(Impendulo.Data.Models.Course);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnLinkCourseToCategory);
            this.groupBox4.Controls.Add(this.lstCourses);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 433);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Training Department Courses";
            // 
            // btnLinkCourseModule
            // 
            this.btnLinkCourseModule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLinkCourseModule.Enabled = false;
            this.btnLinkCourseModule.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkCourseModule.Image")));
            this.btnLinkCourseModule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLinkCourseModule.Name = "btnLinkCourseModule";
            this.btnLinkCourseModule.Size = new System.Drawing.Size(24, 24);
            this.btnLinkCourseModule.Text = "toolStripButton1";
            this.btnLinkCourseModule.Click += new System.EventHandler(this.btnLinkCourseModule_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // courseModuleBindingSource
            // 
           // this.courseModuleBindingSource.DataSource = typeof(Impendulo.Data.Models.CourseModule);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.courseModuleDataGridView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(641, 436);
            this.toolStripContainer1.Location = new System.Drawing.Point(6, 21);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(641, 463);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            // 
            // courseModuleDataGridView
            // 
            this.courseModuleDataGridView.AllowUserToAddRows = false;
            this.courseModuleDataGridView.AllowUserToDeleteRows = false;
            this.courseModuleDataGridView.AllowUserToOrderColumns = true;
            this.courseModuleDataGridView.AutoGenerateColumns = false;
            this.courseModuleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseModuleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RemoveModule,
            this.dataGridViewTextBoxColumn1,
            this.ModuleName,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.ModuleDescription});
            this.courseModuleDataGridView.DataSource = this.courseModuleBindingSource;
            this.courseModuleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseModuleDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.courseModuleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.courseModuleDataGridView.Name = "courseModuleDataGridView";
            this.courseModuleDataGridView.RowTemplate.Height = 24;
            this.courseModuleDataGridView.Size = new System.Drawing.Size(641, 436);
            this.courseModuleDataGridView.TabIndex = 0;
            this.courseModuleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseModuleDataGridView_CellClick);
            this.courseModuleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseModuleDataGridView_CellContentClick);
            this.courseModuleDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.courseModuleDataGridView_DataBindingComplete);
            this.courseModuleDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.courseModuleDataGridView_RowsRemoved);
            this.courseModuleDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.courseModuleDataGridView_RowStateChanged);
            this.courseModuleDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.courseModuleDataGridView_UserAddedRow);
            this.courseModuleDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.courseModuleDataGridView_UserDeletedRow);
            this.courseModuleDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.courseModuleDataGridView_UserDeletingRow);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.courseModuleBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnLinkCourseModule,
            this.btnRemoveModuleLinkedToCourse});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(271, 27);
            this.bindingNavigator1.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // btnRemoveModuleLinkedToCourse
            // 
            this.btnRemoveModuleLinkedToCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveModuleLinkedToCourse.Enabled = false;
            this.btnRemoveModuleLinkedToCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveModuleLinkedToCourse.Image")));
            this.btnRemoveModuleLinkedToCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveModuleLinkedToCourse.Name = "btnRemoveModuleLinkedToCourse";
            this.btnRemoveModuleLinkedToCourse.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveModuleLinkedToCourse.Text = "toolStripButton1";
            this.btnRemoveModuleLinkedToCourse.Click += new System.EventHandler(this.btnRemoveModuleLinkedToCourse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.toolStripContainer1);
            this.groupBox2.Location = new System.Drawing.Point(440, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 490);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modules";
            // 
            // RemoveModule
            // 
            this.RemoveModule.HeaderText = "";
            this.RemoveModule.Name = "RemoveModule";
            this.RemoveModule.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CourseModuleID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ref Num";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ModuleName
            // 
            this.ModuleName.HeaderText = "Module";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Width = 225;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CourseModuleUnitCost";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit Cost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CourseModuleDuration";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // ModuleDescription
            // 
            this.ModuleDescription.HeaderText = "Description";
            this.ModuleDescription.Name = "ModuleDescription";
            this.ModuleDescription.Width = 450;
            // 
            // CourseViewLinkedCoursesAndModulesV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "CourseViewLinkedCoursesAndModulesV3";
            this.Text = "CourseViewLinkedCoursesAndModulesV3";
            this.Load += new System.EventHandler(this.CourseViewLinkedCoursesAndModulesV3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseCategoryBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseModuleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCourseCategories;
        private System.Windows.Forms.BindingSource courseCategoryBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboTrainingDepartment;
        private System.Windows.Forms.BindingSource trainingDepartmentBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLinkCourseToCategory;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripButton btnLinkCourseModule;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.BindingSource courseModuleBindingSource;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView courseModuleDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNewCourseCategory;
        private System.Windows.Forms.ToolStripButton btnRemoveModuleLinkedToCourse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RemoveModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleDescription;
    }
}