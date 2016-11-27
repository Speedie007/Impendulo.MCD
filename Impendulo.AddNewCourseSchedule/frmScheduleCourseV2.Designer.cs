namespace Impendulo.AddNewCourseSchedule
{
    partial class frmScheduleCourseV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleCourseV2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ScheduledCoursesToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.dgvScheduledDepartmentCourses = new System.Windows.Forms.DataGridView();
            this.ScheduledCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduledCourseStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScheduleDepartmentCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrainingDepartments = new System.Windows.Forms.ComboBox();
            this.trainingDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstCoursePerDepartment = new System.Windows.Forms.ListBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ScheduledDepartmentCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ScheduledCoursesToolStripContainer.ContentPanel.SuspendLayout();
            this.ScheduledCoursesToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.ScheduledCoursesToolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledDepartmentCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduledDepartmentCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Course";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ScheduledCoursesToolStripContainer);
            this.groupBox3.Location = new System.Drawing.Point(469, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 394);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // ScheduledCoursesToolStripContainer
            // 
            // 
            // ScheduledCoursesToolStripContainer.ContentPanel
            // 
            this.ScheduledCoursesToolStripContainer.ContentPanel.Controls.Add(this.dgvScheduledDepartmentCourses);
            this.ScheduledCoursesToolStripContainer.ContentPanel.Size = new System.Drawing.Size(708, 346);
            this.ScheduledCoursesToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduledCoursesToolStripContainer.Location = new System.Drawing.Point(3, 18);
            this.ScheduledCoursesToolStripContainer.Name = "ScheduledCoursesToolStripContainer";
            this.ScheduledCoursesToolStripContainer.Size = new System.Drawing.Size(708, 373);
            this.ScheduledCoursesToolStripContainer.TabIndex = 2;
            this.ScheduledCoursesToolStripContainer.Text = "toolStripContainer1";
            // 
            // ScheduledCoursesToolStripContainer.TopToolStripPanel
            // 
            this.ScheduledCoursesToolStripContainer.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            this.ScheduledCoursesToolStripContainer.TopToolStripPanel.MaximumSize = new System.Drawing.Size(0, 200);
            this.ScheduledCoursesToolStripContainer.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // dgvScheduledDepartmentCourses
            // 
            this.dgvScheduledDepartmentCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduledDepartmentCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduledCourseID,
            this.CourseName,
            this.ScheduledCourseStartDate});
            this.dgvScheduledDepartmentCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScheduledDepartmentCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvScheduledDepartmentCourses.Name = "dgvScheduledDepartmentCourses";
            this.dgvScheduledDepartmentCourses.RowTemplate.Height = 24;
            this.dgvScheduledDepartmentCourses.Size = new System.Drawing.Size(708, 346);
            this.dgvScheduledDepartmentCourses.TabIndex = 0;
            // 
            // ScheduledCourseID
            // 
            this.ScheduledCourseID.DataPropertyName = "ScheduledTrainingDepartmentCourseID";
            this.ScheduledCourseID.HeaderText = "Schedule Ref";
            this.ScheduledCourseID.Name = "ScheduledCourseID";
            this.ScheduledCourseID.ReadOnly = true;
            this.ScheduledCourseID.Width = 125;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "Course";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 275;
            // 
            // ScheduledCourseStartDate
            // 
            this.ScheduledCourseStartDate.DataPropertyName = "ScheduledTrainingDepartmentCourseStartDate";
            this.ScheduledCourseStartDate.HeaderText = "Start Date";
            this.ScheduledCourseStartDate.Name = "ScheduledCourseStartDate";
            this.ScheduledCourseStartDate.ReadOnly = true;
            this.ScheduledCourseStartDate.Width = 150;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(310, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Click += new System.EventHandler(this.bindingNavigator1_Click);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnScheduleDepartmentCourse);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboTrainingDepartments);
            this.groupBox2.Controls.Add(this.lstCoursePerDepartment);
            this.groupBox2.Location = new System.Drawing.Point(15, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 394);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Course";
            // 
            // btnScheduleDepartmentCourse
            // 
            this.btnScheduleDepartmentCourse.Location = new System.Drawing.Point(231, 342);
            this.btnScheduleDepartmentCourse.Name = "btnScheduleDepartmentCourse";
            this.btnScheduleDepartmentCourse.Size = new System.Drawing.Size(196, 46);
            this.btnScheduleDepartmentCourse.TabIndex = 5;
            this.btnScheduleDepartmentCourse.Text = "Schedule Course";
            this.btnScheduleDepartmentCourse.UseVisualStyleBackColor = true;
            this.btnScheduleDepartmentCourse.Click += new System.EventHandler(this.btnScheduleDepartmentCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Training Department";
            // 
            // cboTrainingDepartments
            // 
            this.cboTrainingDepartments.DataSource = this.trainingDepartmentBindingSource;
            this.cboTrainingDepartments.DisplayMember = "Department";
            this.cboTrainingDepartments.FormattingEnabled = true;
            this.cboTrainingDepartments.Location = new System.Drawing.Point(166, 30);
            this.cboTrainingDepartments.Name = "cboTrainingDepartments";
            this.cboTrainingDepartments.Size = new System.Drawing.Size(261, 24);
            this.cboTrainingDepartments.TabIndex = 0;
            this.cboTrainingDepartments.ValueMember = "TrainingDepartmentID";
            this.cboTrainingDepartments.SelectedIndexChanged += new System.EventHandler(this.cboTrainingDepartments_SelectedIndexChanged);
            // 
            // trainingDepartmentBindingSource
            // 
            //this.trainingDepartmentBindingSource.DataSource = typeof(Impendulo.Data.Models.TrainingDepartment);
            // 
            // lstCoursePerDepartment
            // 
            this.lstCoursePerDepartment.DataSource = this.courseBindingSource;
            this.lstCoursePerDepartment.DisplayMember = "CourseName";
            this.lstCoursePerDepartment.FormattingEnabled = true;
            this.lstCoursePerDepartment.ItemHeight = 16;
            this.lstCoursePerDepartment.Location = new System.Drawing.Point(166, 60);
            this.lstCoursePerDepartment.Name = "lstCoursePerDepartment";
            this.lstCoursePerDepartment.Size = new System.Drawing.Size(261, 276);
            this.lstCoursePerDepartment.TabIndex = 2;
            this.lstCoursePerDepartment.ValueMember = "CourseID";
            // 
            // courseBindingSource
            // 
            //this.courseBindingSource.DataSource = typeof(Impendulo.Data.Models.Course);
            // 
            // frmScheduleCourseV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 456);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmScheduleCourseV2";
            this.Text = "frmScheduleCourseV2";
            this.Load += new System.EventHandler(this.frmScheduleCourseV2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ScheduledCoursesToolStripContainer.ContentPanel.ResumeLayout(false);
            this.ScheduledCoursesToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.ScheduledCoursesToolStripContainer.TopToolStripPanel.PerformLayout();
            this.ScheduledCoursesToolStripContainer.ResumeLayout(false);
            this.ScheduledCoursesToolStripContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledDepartmentCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduledDepartmentCourseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvScheduledDepartmentCourses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnScheduleDepartmentCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrainingDepartments;
        private System.Windows.Forms.BindingSource trainingDepartmentBindingSource;
        private System.Windows.Forms.ListBox lstCoursePerDepartment;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduledCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduledCourseStartDate;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.ToolStripContainer ScheduledCoursesToolStripContainer;
        private System.Windows.Forms.BindingSource ScheduledDepartmentCourseBindingSource;
    }
}