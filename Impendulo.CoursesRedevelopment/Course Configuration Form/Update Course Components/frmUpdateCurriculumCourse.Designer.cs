namespace Impendulo.Courses.InputForms.Development
{
    partial class frmUpdateCurriculumCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateCurriculumCourse));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCourseDuration = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateCurriculumCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCourseCourseCode = new System.Windows.Forms.TextBox();
            this.nudCourseMaximumAllowed = new System.Windows.Forms.NumericUpDown();
            this.nudCourseMinimumAllowed = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseMaximumAllowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseMinimumAllowed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCourseCourseCode);
            this.groupBox1.Controls.Add(this.nudCourseMaximumAllowed);
            this.groupBox1.Controls.Add(this.nudCourseMinimumAllowed);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudCourseDuration);
            this.groupBox1.Controls.Add(this.btnUpdateCurriculumCourse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCourseCost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Updarte Curruculum Course";
            // 
            // nudCourseDuration
            // 
            this.nudCourseDuration.Location = new System.Drawing.Point(119, 53);
            this.nudCourseDuration.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudCourseDuration.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudCourseDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCourseDuration.Name = "nudCourseDuration";
            this.nudCourseDuration.Size = new System.Drawing.Size(51, 20);
            this.nudCourseDuration.TabIndex = 59;
            this.nudCourseDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnUpdateCurriculumCourse
            // 
            this.btnUpdateCurriculumCourse.Location = new System.Drawing.Point(210, 164);
            this.btnUpdateCurriculumCourse.Name = "btnUpdateCurriculumCourse";
            this.btnUpdateCurriculumCourse.Size = new System.Drawing.Size(62, 23);
            this.btnUpdateCurriculumCourse.TabIndex = 6;
            this.btnUpdateCurriculumCourse.Text = "Update";
            this.btnUpdateCurriculumCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCurriculumCourse.Click += new System.EventHandler(this.btnUpdateCurriculumCourse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duration";
            // 
            // txtCourseCost
            // 
            this.txtCourseCost.Location = new System.Drawing.Point(119, 26);
            this.txtCourseCost.Name = "txtCourseCost";
            this.txtCourseCost.Size = new System.Drawing.Size(121, 20);
            this.txtCourseCost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Course Code";
            // 
            // txtCourseCourseCode
            // 
            this.txtCourseCourseCode.Location = new System.Drawing.Point(118, 137);
            this.txtCourseCourseCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCourseCourseCode.Name = "txtCourseCourseCode";
            this.txtCourseCourseCode.Size = new System.Drawing.Size(154, 20);
            this.txtCourseCourseCode.TabIndex = 70;
            // 
            // nudCourseMaximumAllowed
            // 
            this.nudCourseMaximumAllowed.Location = new System.Drawing.Point(118, 81);
            this.nudCourseMaximumAllowed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudCourseMaximumAllowed.Name = "nudCourseMaximumAllowed";
            this.nudCourseMaximumAllowed.Size = new System.Drawing.Size(51, 20);
            this.nudCourseMaximumAllowed.TabIndex = 68;
            // 
            // nudCourseMinimumAllowed
            // 
            this.nudCourseMinimumAllowed.Location = new System.Drawing.Point(118, 109);
            this.nudCourseMinimumAllowed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudCourseMinimumAllowed.Name = "nudCourseMinimumAllowed";
            this.nudCourseMinimumAllowed.Size = new System.Drawing.Size(51, 20);
            this.nudCourseMinimumAllowed.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Min Attendees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Max Attendees";
            // 
            // frmUpdateCurriculumCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 210);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateCurriculumCourse";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updte Properties";
            this.Load += new System.EventHandler(this.frmUpdateCurriculumCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseMaximumAllowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseMinimumAllowed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateCurriculumCourse;
        public System.Windows.Forms.TextBox txtCourseCost;
        public System.Windows.Forms.NumericUpDown nudCourseDuration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCourseCourseCode;
        public System.Windows.Forms.NumericUpDown nudCourseMaximumAllowed;
        public System.Windows.Forms.NumericUpDown nudCourseMinimumAllowed;
    }
}