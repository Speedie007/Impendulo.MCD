namespace Impendulo.Courses.Add.CourseDatabase
{
    partial class frmAddTrainingDepartmentCourseEnrollmentTypeModules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTrainingDepartmentCourseEnrollmentTypeModules));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.lstAvailableModules = new System.Windows.Forms.ListBox();
            this.bindingSourceAvailableModules = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceLinkedModules = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorAvailableModules = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtModuleBindingNavigator = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
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
            this.groupBox1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAvailableModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLinkedModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAvailableModules)).BeginInit();
            this.bindingNavigatorAvailableModules.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLinkedModules)).BeginInit();
            this.bindingNavigatorLinkedModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStripContainer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Modules";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lstAvailableModules);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(429, 400);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 18);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(429, 427);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindingNavigatorAvailableModules);
            // 
            // lstAvailableModules
            // 
            this.lstAvailableModules.DataSource = this.bindingSourceAvailableModules;
            this.lstAvailableModules.DisplayMember = "ModuleName";
            this.lstAvailableModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAvailableModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAvailableModules.FormattingEnabled = true;
            this.lstAvailableModules.ItemHeight = 20;
            this.lstAvailableModules.Location = new System.Drawing.Point(0, 0);
            this.lstAvailableModules.Name = "lstAvailableModules";
            this.lstAvailableModules.Size = new System.Drawing.Size(429, 400);
            this.lstAvailableModules.TabIndex = 0;
            this.lstAvailableModules.ValueMember = "ModuleID";
            // 
            // bindingSourceAvailableModules
            // 
            this.bindingSourceAvailableModules.DataSource = this.bindingSourceLinkedModules;
            // 
            // bindingSourceLinkedModules
            // 
            this.bindingSourceLinkedModules.DataSource = typeof(Impendulo.Data.Models.Module);
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorAvailableModules.Location = new System.Drawing.Point(3, 0);
            this.bindingNavigatorAvailableModules.MoveFirstItem = null;
            this.bindingNavigatorAvailableModules.MoveLastItem = null;
            this.bindingNavigatorAvailableModules.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorAvailableModules.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorAvailableModules.Name = "bindingNavigatorAvailableModules";
            this.bindingNavigatorAvailableModules.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorAvailableModules.Size = new System.Drawing.Size(400, 27);
            this.bindingNavigatorAvailableModules.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStripContainer2);
            this.groupBox2.Location = new System.Drawing.Point(534, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 448);
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
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(429, 400);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(3, 18);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(429, 427);
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
            this.lstLinkedModules.ItemHeight = 20;
            this.lstLinkedModules.Location = new System.Drawing.Point(0, 0);
            this.lstLinkedModules.Name = "lstLinkedModules";
            this.lstLinkedModules.Size = new System.Drawing.Size(429, 400);
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
            this.bindingNavigatorLinkedModules.Location = new System.Drawing.Point(3, 0);
            this.bindingNavigatorLinkedModules.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorLinkedModules.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorLinkedModules.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorLinkedModules.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorLinkedModules.Name = "bindingNavigatorLinkedModules";
            this.bindingNavigatorLinkedModules.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorLinkedModules.Size = new System.Drawing.Size(223, 27);
            this.bindingNavigatorLinkedModules.TabIndex = 0;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(45, 24);
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
            this.btnLinkModule.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkModule.Image")));
            this.btnLinkModule.Location = new System.Drawing.Point(453, 117);
            this.btnLinkModule.Name = "btnLinkModule";
            this.btnLinkModule.Size = new System.Drawing.Size(75, 83);
            this.btnLinkModule.TabIndex = 2;
            this.btnLinkModule.UseVisualStyleBackColor = true;
            this.btnLinkModule.Click += new System.EventHandler(this.btnLinkModule_Click);
            // 
            // btnRemoveModule
            // 
            this.btnRemoveModule.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveModule.Image")));
            this.btnRemoveModule.Location = new System.Drawing.Point(453, 217);
            this.btnRemoveModule.Name = "btnRemoveModule";
            this.btnRemoveModule.Size = new System.Drawing.Size(75, 83);
            this.btnRemoveModule.TabIndex = 3;
            this.btnRemoveModule.UseVisualStyleBackColor = true;
            this.btnRemoveModule.Click += new System.EventHandler(this.btnRemoveModule_Click);
            // 
            // frmAddTrainingDepartmentCourseEnrollmentTypeModules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 465);
            this.Controls.Add(this.btnRemoveModule);
            this.Controls.Add(this.btnLinkModule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddTrainingDepartmentCourseEnrollmentTypeModules";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Modules";
            this.Load += new System.EventHandler(this.frmAddTrainingDepartmentCourseEnrollmentTypeModules_Load);
            this.groupBox1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAvailableModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLinkedModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAvailableModules)).EndInit();
            this.bindingNavigatorAvailableModules.ResumeLayout(false);
            this.bindingNavigatorAvailableModules.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLinkedModules)).EndInit();
            this.bindingNavigatorLinkedModules.ResumeLayout(false);
            this.bindingNavigatorLinkedModules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstLinkedModules;
        private System.Windows.Forms.Button btnLinkModule;
        private System.Windows.Forms.Button btnRemoveModule;
        private System.Windows.Forms.BindingSource bindingSourceAvailableModules;
        private System.Windows.Forms.BindingSource bindingSourceLinkedModules;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ListBox lstAvailableModules;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAvailableModules;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtModuleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
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
    }
}