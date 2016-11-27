namespace Impendulo.Courses.Add.MCDCourses
{
    partial class frmAddTrainingDepartmentCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTrainingDepartmentCourses));
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddTrainingDepartmentCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddTrainingDepartmentCourse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(278, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "&Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddTrainingDepartmentCourse
            // 
            this.btnAddTrainingDepartmentCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTrainingDepartmentCourse.Image")));
            this.btnAddTrainingDepartmentCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTrainingDepartmentCourse.Location = new System.Drawing.Point(366, 35);
            this.btnAddTrainingDepartmentCourse.Name = "btnAddTrainingDepartmentCourse";
            this.btnAddTrainingDepartmentCourse.Size = new System.Drawing.Size(67, 30);
            this.btnAddTrainingDepartmentCourse.TabIndex = 16;
            this.btnAddTrainingDepartmentCourse.Text = "Add";
            this.btnAddTrainingDepartmentCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTrainingDepartmentCourse.UseVisualStyleBackColor = true;
            this.btnAddTrainingDepartmentCourse.Click += new System.EventHandler(this.btnAddTrainingDepartmentCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Course";
            // 
            // txtAddTrainingDepartmentCourse
            // 
            this.txtAddTrainingDepartmentCourse.Location = new System.Drawing.Point(71, 6);
            this.txtAddTrainingDepartmentCourse.Name = "txtAddTrainingDepartmentCourse";
            this.txtAddTrainingDepartmentCourse.Size = new System.Drawing.Size(362, 22);
            this.txtAddTrainingDepartmentCourse.TabIndex = 14;
            // 
            // frmAddTrainingDepartmentCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 77);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddTrainingDepartmentCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddTrainingDepartmentCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddTrainingDepartmentCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Training Department Course";
            this.Load += new System.EventHandler(this.frmAddTrainingDepartmentCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddTrainingDepartmentCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddTrainingDepartmentCourse;
    }
}