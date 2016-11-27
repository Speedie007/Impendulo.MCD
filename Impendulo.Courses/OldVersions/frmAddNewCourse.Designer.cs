namespace Impendulo.Courses
{
    partial class frmAddNewCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewCourse));
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCourseCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(75, 12);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(392, 22);
            this.txtCourse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(212, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCourseCategory
            // 
            this.btnAddCourseCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourseCategory.Image")));
            this.btnAddCourseCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCourseCategory.Location = new System.Drawing.Point(347, 40);
            this.btnAddCourseCategory.Name = "btnAddCourseCategory";
            this.btnAddCourseCategory.Size = new System.Drawing.Size(122, 33);
            this.btnAddCourseCategory.TabIndex = 3;
            this.btnAddCourseCategory.Text = "&Add Course";
            this.btnAddCourseCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourseCategory.UseVisualStyleBackColor = true;
            this.btnAddCourseCategory.Click += new System.EventHandler(this.btnAddCourseCategory_Click);
            // 
            // frmAddNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 115);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddCourseCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewCourse";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Course Category";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddNewCourseCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCourseCategory;
    }
}