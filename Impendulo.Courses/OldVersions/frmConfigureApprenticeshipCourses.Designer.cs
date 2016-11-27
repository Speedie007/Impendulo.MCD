namespace Impendulo.Courses
{
    partial class frmConfigureApprenticeshipCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigureApprenticeshipCourses));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.courseModuleDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoveModule = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLinkCourseModule = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveModuleLinkedToCourse = new System.Windows.Forms.ToolStripButton();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLinkCourseToCategory = new System.Windows.Forms.Button();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseModuleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.toolStripContainer1);
            this.groupBox2.Location = new System.Drawing.Point(440, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 430);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modules";
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(970, 376);
            this.toolStripContainer1.Location = new System.Drawing.Point(6, 21);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(970, 403);
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
            this.ModuleName,
            this.ModuleDescription});
            this.courseModuleDataGridView.DataSource = this.courseModuleBindingSource;
            this.courseModuleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseModuleDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.courseModuleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.courseModuleDataGridView.Name = "courseModuleDataGridView";
            this.courseModuleDataGridView.RowTemplate.Height = 24;
            this.courseModuleDataGridView.Size = new System.Drawing.Size(970, 376);
            this.courseModuleDataGridView.TabIndex = 0;
            // 
            // RemoveModule
            // 
            this.RemoveModule.HeaderText = "";
            this.RemoveModule.Name = "RemoveModule";
            this.RemoveModule.Width = 40;
            // 
            // ModuleName
            // 
            this.ModuleName.HeaderText = "Module";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Width = 225;
            // 
            // ModuleDescription
            // 
            this.ModuleDescription.HeaderText = "Description";
            this.ModuleDescription.Name = "ModuleDescription";
            this.ModuleDescription.Width = 450;
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
            // btnLinkCourseModule
            // 
            this.btnLinkCourseModule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLinkCourseModule.Enabled = false;
            this.btnLinkCourseModule.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkCourseModule.Image")));
            this.btnLinkCourseModule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLinkCourseModule.Name = "btnLinkCourseModule";
            this.btnLinkCourseModule.Size = new System.Drawing.Size(24, 24);
            this.btnLinkCourseModule.Text = "toolStripButton1";
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
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnLinkCourseToCategory);
            this.groupBox4.Controls.Add(this.lstCourses);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 429);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Apprenticeship Courses";
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
            // 
            // courseBindingSource
            // 
            //this.courseBindingSource.DataSource = typeof(Impendulo.Data.Models.Course);
            // 
            // trainingDepartmentBindingSource
            // 
            this.trainingDepartmentBindingSource.DataSource = typeof(Impendulo.Data.Models.TrainingDepartment);
            // 
            // frmConfigureApprenticeshipCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmConfigureApprenticeshipCourses";
            this.Text = "frmConfigureApprenticeshipCourses";
            this.groupBox2.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseModuleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView courseModuleDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RemoveModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleDescription;
        private System.Windows.Forms.BindingSource courseModuleBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnLinkCourseModule;
        private System.Windows.Forms.ToolStripButton btnRemoveModuleLinkedToCourse;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLinkCourseToCategory;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource trainingDepartmentBindingSource;
        private System.Windows.Forms.BindingSource courseCategoryBindingSource;
    }
}