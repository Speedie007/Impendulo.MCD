namespace Impendulo.AddNewCourseSchedule
{
    partial class frmScheduleCourse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvScheduledDepartmentCourses = new System.Windows.Forms.DataGridView();
            this.ScheduledCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduledCourseStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScheduleDepartmentCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrainingDepartments = new System.Windows.Forms.ComboBox();
            this.trainingDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstCoursePerDepartment = new System.Windows.Forms.ListBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledDepartmentCourses)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1180, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Course";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvScheduledDepartmentCourses);
            this.groupBox3.Location = new System.Drawing.Point(460, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 388);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dgvScheduledDepartmentCourses
            // 
            this.dgvScheduledDepartmentCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduledDepartmentCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduledCourseID,
            this.CourseName,
            this.ScheduledCourseStartDate});
            this.dgvScheduledDepartmentCourses.Location = new System.Drawing.Point(6, 30);
            this.dgvScheduledDepartmentCourses.Name = "dgvScheduledDepartmentCourses";
            this.dgvScheduledDepartmentCourses.RowTemplate.Height = 24;
            this.dgvScheduledDepartmentCourses.Size = new System.Drawing.Size(702, 131);
            this.dgvScheduledDepartmentCourses.TabIndex = 0;
            // 
            // ScheduledCourseID
            // 
            this.ScheduledCourseID.DataPropertyName = "ScheduledCourseID";
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
            this.ScheduledCourseStartDate.DataPropertyName = "ScheduledCourseStartDate";
            this.ScheduledCourseStartDate.HeaderText = "Start Date";
            this.ScheduledCourseStartDate.Name = "ScheduledCourseStartDate";
            this.ScheduledCourseStartDate.ReadOnly = true;
            this.ScheduledCourseStartDate.Width = 150;
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
           // this.courseBindingSource.DataSource = typeof(Impendulo.Data.Models.Course);
            // 
            // frmScheduleCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 579);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmScheduleCourse";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmScheduleCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledDepartmentCourses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.ComboBox cboTrainingDepartments;
        private System.Windows.Forms.BindingSource trainingDepartmentBindingSource;
        private System.Windows.Forms.ListBox lstCoursePerDepartment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnScheduleDepartmentCourse;
        private System.Windows.Forms.DataGridView dgvScheduledDepartmentCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduledCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduledCourseStartDate;
    }
}

