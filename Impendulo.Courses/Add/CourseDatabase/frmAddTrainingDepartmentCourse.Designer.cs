namespace Impendulo.Courses.Add.CourseDatabase
{
    partial class frmAddTrainingDepartmentCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTrainingDepartmentCourse));
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddTrainingDepartmentCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddTrainingDepartmentCourse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddTrainingDepartmentCourseDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(351, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "&Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddTrainingDepartmentCourse
            // 
            this.btnAddTrainingDepartmentCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTrainingDepartmentCourse.Image")));
            this.btnAddTrainingDepartmentCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTrainingDepartmentCourse.Location = new System.Drawing.Point(439, 68);
            this.btnAddTrainingDepartmentCourse.Name = "btnAddTrainingDepartmentCourse";
            this.btnAddTrainingDepartmentCourse.Size = new System.Drawing.Size(67, 30);
            this.btnAddTrainingDepartmentCourse.TabIndex = 10;
            this.btnAddTrainingDepartmentCourse.Text = "Add";
            this.btnAddTrainingDepartmentCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTrainingDepartmentCourse.UseVisualStyleBackColor = true;
            this.btnAddTrainingDepartmentCourse.Click += new System.EventHandler(this.btnAddTrainingDepartmentCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course";
            // 
            // txtAddTrainingDepartmentCourse
            // 
            this.txtAddTrainingDepartmentCourse.Location = new System.Drawing.Point(144, 12);
            this.txtAddTrainingDepartmentCourse.Name = "txtAddTrainingDepartmentCourse";
            this.txtAddTrainingDepartmentCourse.Size = new System.Drawing.Size(362, 22);
            this.txtAddTrainingDepartmentCourse.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Course Description";
            // 
            // txtAddTrainingDepartmentCourseDescription
            // 
            this.txtAddTrainingDepartmentCourseDescription.Location = new System.Drawing.Point(144, 40);
            this.txtAddTrainingDepartmentCourseDescription.Name = "txtAddTrainingDepartmentCourseDescription";
            this.txtAddTrainingDepartmentCourseDescription.Size = new System.Drawing.Size(362, 22);
            this.txtAddTrainingDepartmentCourseDescription.TabIndex = 12;
            // 
            // frmAddTrainingDepartmentCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(511, 104);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddTrainingDepartmentCourseDescription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddTrainingDepartmentCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddTrainingDepartmentCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddTrainingDepartmentCourse";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Training Department Course";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddTrainingDepartmentCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddTrainingDepartmentCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddTrainingDepartmentCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddTrainingDepartmentCourseDescription;
    }
}