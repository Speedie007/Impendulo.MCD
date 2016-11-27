namespace DynamicCreateEnumFromDatabase
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.curriculumCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curriculumCourseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumCourseParentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curricullumCourseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.curriculumCourseIDDataGridViewTextBoxColumn,
            this.curriculumIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.enrollmentTypeIDDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.curriculumCourseParentIDDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn,
            this.curriculumDataGridViewTextBoxColumn,
            this.curricullumCourseCodeDataGridViewTextBoxColumn,
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.curriculumCourseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(816, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // curriculumCourseBindingSource
            // 
            this.curriculumCourseBindingSource.DataSource = typeof(Impendulo.Data.Models.CurriculumCourse);
            // 
            // curriculumCourseIDDataGridViewTextBoxColumn
            // 
            this.curriculumCourseIDDataGridViewTextBoxColumn.DataPropertyName = "CurriculumCourseID";
            this.curriculumCourseIDDataGridViewTextBoxColumn.HeaderText = "CurriculumCourseID";
            this.curriculumCourseIDDataGridViewTextBoxColumn.Name = "curriculumCourseIDDataGridViewTextBoxColumn";
            // 
            // curriculumIDDataGridViewTextBoxColumn
            // 
            this.curriculumIDDataGridViewTextBoxColumn.DataPropertyName = "CurriculumID";
            this.curriculumIDDataGridViewTextBoxColumn.HeaderText = "CurriculumID";
            this.curriculumIDDataGridViewTextBoxColumn.Name = "curriculumIDDataGridViewTextBoxColumn";
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // enrollmentTypeIDDataGridViewTextBoxColumn
            // 
            this.enrollmentTypeIDDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentTypeID";
            this.enrollmentTypeIDDataGridViewTextBoxColumn.HeaderText = "EnrollmentTypeID";
            this.enrollmentTypeIDDataGridViewTextBoxColumn.Name = "enrollmentTypeIDDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // curriculumCourseParentIDDataGridViewTextBoxColumn
            // 
            this.curriculumCourseParentIDDataGridViewTextBoxColumn.DataPropertyName = "CurriculumCourseParentID";
            this.curriculumCourseParentIDDataGridViewTextBoxColumn.HeaderText = "CurriculumCourseParentID";
            this.curriculumCourseParentIDDataGridViewTextBoxColumn.Name = "curriculumCourseParentIDDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course.CourseName";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // lookupEnrollmentTypeDataGridViewTextBoxColumn
            // 
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn.DataPropertyName = "LookupEnrollmentType";
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn.HeaderText = "LookupEnrollmentType";
            this.lookupEnrollmentTypeDataGridViewTextBoxColumn.Name = "lookupEnrollmentTypeDataGridViewTextBoxColumn";
            // 
            // curriculumDataGridViewTextBoxColumn
            // 
            this.curriculumDataGridViewTextBoxColumn.DataPropertyName = "Curriculum";
            this.curriculumDataGridViewTextBoxColumn.HeaderText = "Curriculum";
            this.curriculumDataGridViewTextBoxColumn.Name = "curriculumDataGridViewTextBoxColumn";
            // 
            // curricullumCourseCodeDataGridViewTextBoxColumn
            // 
            this.curricullumCourseCodeDataGridViewTextBoxColumn.DataPropertyName = "CurricullumCourseCode";
            this.curricullumCourseCodeDataGridViewTextBoxColumn.HeaderText = "CurricullumCourseCode";
            this.curricullumCourseCodeDataGridViewTextBoxColumn.Name = "curricullumCourseCodeDataGridViewTextBoxColumn";
            // 
            // curriculumCourseMinimumMaximumDataGridViewTextBoxColumn
            // 
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn.DataPropertyName = "CurriculumCourseMinimumMaximum";
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn.HeaderText = "CurriculumCourseMinimumMaximum";
            this.curriculumCourseMinimumMaximumDataGridViewTextBoxColumn.Name = "curriculumCourseMinimumMaximumDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 628);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumCourseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumCourseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumCourseParentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lookupEnrollmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curricullumCourseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumCourseMinimumMaximumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource curriculumCourseBindingSource;
    }
}

