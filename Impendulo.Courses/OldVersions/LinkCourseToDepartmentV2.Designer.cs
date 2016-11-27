namespace Impendulo.Courses
{
    partial class LinkCourseToDepartmentV2
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
            this.gbAvailableCourses = new System.Windows.Forms.GroupBox();
            this.lstCoursesINSERT = new System.Windows.Forms.ListBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowInsertCourseSection = new System.Windows.Forms.Button();
            this.btnLinkTrainingDepartmentCourse = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInsertCourse = new System.Windows.Forms.Button();
            this.txtCourseDescriptionINSERTIntoCourses = new System.Windows.Forms.TextBox();
            this.txtCourseNameINSERTIntoCourses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAvailableCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAvailableCourses
            // 
            this.gbAvailableCourses.Controls.Add(this.lstCoursesINSERT);
            this.gbAvailableCourses.Controls.Add(this.btnShowInsertCourseSection);
            this.gbAvailableCourses.Controls.Add(this.btnLinkTrainingDepartmentCourse);
            this.gbAvailableCourses.Location = new System.Drawing.Point(3, 3);
            this.gbAvailableCourses.Name = "gbAvailableCourses";
            this.gbAvailableCourses.Size = new System.Drawing.Size(483, 302);
            this.gbAvailableCourses.TabIndex = 6;
            this.gbAvailableCourses.TabStop = false;
            this.gbAvailableCourses.Text = "All Available Courses";
            // 
            // lstCoursesINSERT
            // 
            this.lstCoursesINSERT.DataSource = this.courseBindingSource;
            this.lstCoursesINSERT.DisplayMember = "CourseName";
            this.lstCoursesINSERT.FormattingEnabled = true;
            this.lstCoursesINSERT.ItemHeight = 16;
            this.lstCoursesINSERT.Location = new System.Drawing.Point(6, 21);
            this.lstCoursesINSERT.Name = "lstCoursesINSERT";
            this.lstCoursesINSERT.Size = new System.Drawing.Size(471, 212);
            this.lstCoursesINSERT.TabIndex = 6;
            this.lstCoursesINSERT.ValueMember = "CourseID";
            // 
            // courseBindingSource
            // 
            //this.courseBindingSource.DataSource = typeof(Impendulo.Data.Models.Course);
            // 
            // btnShowInsertCourseSection
            // 
            this.btnShowInsertCourseSection.Location = new System.Drawing.Point(6, 248);
            this.btnShowInsertCourseSection.Name = "btnShowInsertCourseSection";
            this.btnShowInsertCourseSection.Size = new System.Drawing.Size(186, 48);
            this.btnShowInsertCourseSection.TabIndex = 5;
            this.btnShowInsertCourseSection.Text = "Add Course";
            this.btnShowInsertCourseSection.UseVisualStyleBackColor = true;
            this.btnShowInsertCourseSection.Click += new System.EventHandler(this.btnShowInsertCourseSection_Click);
            // 
            // btnLinkTrainingDepartmentCourse
            // 
            this.btnLinkTrainingDepartmentCourse.Location = new System.Drawing.Point(198, 248);
            this.btnLinkTrainingDepartmentCourse.Name = "btnLinkTrainingDepartmentCourse";
            this.btnLinkTrainingDepartmentCourse.Size = new System.Drawing.Size(279, 48);
            this.btnLinkTrainingDepartmentCourse.TabIndex = 1;
            this.btnLinkTrainingDepartmentCourse.Text = "Link Selected Courses";
            this.btnLinkTrainingDepartmentCourse.UseVisualStyleBackColor = true;
            this.btnLinkTrainingDepartmentCourse.Click += new System.EventHandler(this.btnLinkTrainingDepartmentCourse_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gbAvailableCourses);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(499, 542);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnInsertCourse);
            this.groupBox3.Controls.Add(this.txtCourseDescriptionINSERTIntoCourses);
            this.groupBox3.Controls.Add(this.txtCourseNameINSERTIntoCourses);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(3, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 224);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Course If Does Not Listed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnInsertCourse
            // 
            this.btnInsertCourse.Location = new System.Drawing.Point(330, 171);
            this.btnInsertCourse.Name = "btnInsertCourse";
            this.btnInsertCourse.Size = new System.Drawing.Size(128, 41);
            this.btnInsertCourse.TabIndex = 4;
            this.btnInsertCourse.Text = "Add Course";
            this.btnInsertCourse.UseVisualStyleBackColor = true;
            this.btnInsertCourse.Click += new System.EventHandler(this.btnInsertCourse_Click_1);
            // 
            // txtCourseDescriptionINSERTIntoCourses
            // 
            this.txtCourseDescriptionINSERTIntoCourses.Location = new System.Drawing.Point(148, 61);
            this.txtCourseDescriptionINSERTIntoCourses.Multiline = true;
            this.txtCourseDescriptionINSERTIntoCourses.Name = "txtCourseDescriptionINSERTIntoCourses";
            this.txtCourseDescriptionINSERTIntoCourses.Size = new System.Drawing.Size(310, 104);
            this.txtCourseDescriptionINSERTIntoCourses.TabIndex = 3;
            // 
            // txtCourseNameINSERTIntoCourses
            // 
            this.txtCourseNameINSERTIntoCourses.Location = new System.Drawing.Point(148, 33);
            this.txtCourseNameINSERTIntoCourses.Name = "txtCourseNameINSERTIntoCourses";
            this.txtCourseNameINSERTIntoCourses.Size = new System.Drawing.Size(310, 22);
            this.txtCourseNameINSERTIntoCourses.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Course Name";
            // 
            // LinkCourseToDepartmentV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 560);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LinkCourseToDepartmentV2";
            this.Text = "LinkCourseToDepartmentV2";
            this.Load += new System.EventHandler(this.LinkCourseToDepartmentV2_Load);
            this.gbAvailableCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAvailableCourses;
        private System.Windows.Forms.ListBox lstCoursesINSERT;
        private System.Windows.Forms.Button btnShowInsertCourseSection;
        private System.Windows.Forms.Button btnLinkTrainingDepartmentCourse;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInsertCourse;
        private System.Windows.Forms.TextBox txtCourseDescriptionINSERTIntoCourses;
        private System.Windows.Forms.TextBox txtCourseNameINSERTIntoCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}