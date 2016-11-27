namespace Impendulo.Courses
{
    partial class frmEngineeringConfigureCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEngineeringConfigureCourses));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnApprenticeshipAddNew = new System.Windows.Forms.Button();
            this.lblApprenticeshipCoure = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.apprenticeshipCourseModulesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apprenticeshipCourseModulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apprenticeshipCourseModulesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.apprenticeshipCourseModulesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLinkCourseToCategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipCourseModulesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipCourseModulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipCourseModulesBindingNavigator)).BeginInit();
            this.apprenticeshipCourseModulesBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnApprenticeshipAddNew);
            this.panelTop.Controls.Add(this.lblApprenticeshipCoure);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1192, 57);
            this.panelTop.TabIndex = 1;
            // 
            // btnApprenticeshipAddNew
            // 
            this.btnApprenticeshipAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnApprenticeshipAddNew.Image")));
            this.btnApprenticeshipAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprenticeshipAddNew.Location = new System.Drawing.Point(692, 11);
            this.btnApprenticeshipAddNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApprenticeshipAddNew.Name = "btnApprenticeshipAddNew";
            this.btnApprenticeshipAddNew.Size = new System.Drawing.Size(226, 28);
            this.btnApprenticeshipAddNew.TabIndex = 2;
            this.btnApprenticeshipAddNew.Text = "Add Appernticeship";
            this.btnApprenticeshipAddNew.UseVisualStyleBackColor = true;
            this.btnApprenticeshipAddNew.Click += new System.EventHandler(this.btnApprenticeshipAddNew_Click);
            // 
            // lblApprenticeshipCoure
            // 
            this.lblApprenticeshipCoure.AutoSize = true;
            this.lblApprenticeshipCoure.Location = new System.Drawing.Point(14, 14);
            this.lblApprenticeshipCoure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApprenticeshipCoure.Name = "lblApprenticeshipCoure";
            this.lblApprenticeshipCoure.Size = new System.Drawing.Size(162, 17);
            this.lblApprenticeshipCoure.TabIndex = 1;
            this.lblApprenticeshipCoure.Text = "Add New Apprenticeship";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 22);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 620);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1188, 616);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLinkCourseToCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 616);
            this.panel2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(10, 34);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 372);
            this.listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.toolStripContainer2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 616);
            this.panel3.TabIndex = 0;
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.apprenticeshipCourseModulesDataGridView);
            this.toolStripContainer2.ContentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(850, 665);
            this.toolStripContainer2.Location = new System.Drawing.Point(2, 3);
            this.toolStripContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(850, 692);
            this.toolStripContainer2.TabIndex = 3;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.apprenticeshipCourseModulesBindingNavigator);
            // 
            // apprenticeshipCourseModulesDataGridView
            // 
            this.apprenticeshipCourseModulesDataGridView.AutoGenerateColumns = false;
            this.apprenticeshipCourseModulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apprenticeshipCourseModulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.apprenticeshipCourseModulesDataGridView.DataSource = this.apprenticeshipCourseModulesBindingSource;
            this.apprenticeshipCourseModulesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apprenticeshipCourseModulesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.apprenticeshipCourseModulesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.apprenticeshipCourseModulesDataGridView.Name = "apprenticeshipCourseModulesDataGridView";
            this.apprenticeshipCourseModulesDataGridView.RowTemplate.Height = 24;
            this.apprenticeshipCourseModulesDataGridView.Size = new System.Drawing.Size(850, 665);
            this.apprenticeshipCourseModulesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ApprenticeshipCourseModuleID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ApprenticeshipCourseModuleID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Module";
            this.dataGridViewTextBoxColumn7.HeaderText = "Module";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ApprenticeshipCourseModuleUnitPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "ApprenticeshipCourseModuleUnitPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ApprenticeshipCourseDuration";
            this.dataGridViewTextBoxColumn5.HeaderText = "ApprenticeshipCourseDuration";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // apprenticeshipCourseModulesBindingSource
            // 
            //this.apprenticeshipCourseModulesBindingSource.DataSource = typeof(ObservableListSource<Impendulo.Data.Models.ApprenticeshipCourseModule>);
            // 
            // apprenticeshipCourseModulesBindingNavigator
            // 
            this.apprenticeshipCourseModulesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.apprenticeshipCourseModulesBindingNavigator.BindingSource = this.apprenticeshipCourseModulesBindingSource;
            this.apprenticeshipCourseModulesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.apprenticeshipCourseModulesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.apprenticeshipCourseModulesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.apprenticeshipCourseModulesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.apprenticeshipCourseModulesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.apprenticeshipCourseModulesBindingNavigatorSaveItem});
            this.apprenticeshipCourseModulesBindingNavigator.Location = new System.Drawing.Point(3, 0);
            this.apprenticeshipCourseModulesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.apprenticeshipCourseModulesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.apprenticeshipCourseModulesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.apprenticeshipCourseModulesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.apprenticeshipCourseModulesBindingNavigator.Name = "apprenticeshipCourseModulesBindingNavigator";
            this.apprenticeshipCourseModulesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.apprenticeshipCourseModulesBindingNavigator.Size = new System.Drawing.Size(295, 27);
            this.apprenticeshipCourseModulesBindingNavigator.TabIndex = 3;
            this.apprenticeshipCourseModulesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // apprenticeshipCourseModulesBindingNavigatorSaveItem
            // 
            this.apprenticeshipCourseModulesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.apprenticeshipCourseModulesBindingNavigatorSaveItem.Enabled = false;
            this.apprenticeshipCourseModulesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("apprenticeshipCourseModulesBindingNavigatorSaveItem.Image")));
            this.apprenticeshipCourseModulesBindingNavigatorSaveItem.Name = "apprenticeshipCourseModulesBindingNavigatorSaveItem";
            this.apprenticeshipCourseModulesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.apprenticeshipCourseModulesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Remove Course";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLinkCourseToCategory
            // 
            this.btnLinkCourseToCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLinkCourseToCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLinkCourseToCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkCourseToCategory.Image")));
            this.btnLinkCourseToCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinkCourseToCategory.Location = new System.Drawing.Point(174, 3);
            this.btnLinkCourseToCategory.Name = "btnLinkCourseToCategory";
            this.btnLinkCourseToCategory.Size = new System.Drawing.Size(142, 36);
            this.btnLinkCourseToCategory.TabIndex = 13;
            this.btnLinkCourseToCategory.Text = "Add Course";
            this.btnLinkCourseToCategory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 559);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmEngineeringConfigureCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "frmEngineeringConfigureCourses";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngineeringConfigureCourses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEngineeringConfigureCourses_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipCourseModulesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipCourseModulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprenticeshipCourseModulesBindingNavigator)).EndInit();
            this.apprenticeshipCourseModulesBindingNavigator.ResumeLayout(false);
            this.apprenticeshipCourseModulesBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnApprenticeshipAddNew;
        private System.Windows.Forms.Label lblApprenticeshipCoure;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.DataGridView apprenticeshipCourseModulesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource apprenticeshipCourseModulesBindingSource;
        private System.Windows.Forms.BindingNavigator apprenticeshipCourseModulesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton apprenticeshipCourseModulesBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLinkCourseToCategory;
    }
}