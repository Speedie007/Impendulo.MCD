namespace Impendulo.Courses.Add.CourseDatabase
{
    partial class frmAddTrainingDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTrainingDepartment));
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddTrainingDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddDepartment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(356, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddTrainingDepartment
            // 
            this.btnAddTrainingDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTrainingDepartment.Image")));
            this.btnAddTrainingDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTrainingDepartment.Location = new System.Drawing.Point(444, 40);
            this.btnAddTrainingDepartment.Name = "btnAddTrainingDepartment";
            this.btnAddTrainingDepartment.Size = new System.Drawing.Size(67, 30);
            this.btnAddTrainingDepartment.TabIndex = 6;
            this.btnAddTrainingDepartment.Text = "Add";
            this.btnAddTrainingDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTrainingDepartment.UseVisualStyleBackColor = true;
            this.btnAddTrainingDepartment.Click += new System.EventHandler(this.btnAddTrainingDepartment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Training Department";
            // 
            // txtAddDepartment
            // 
            this.txtAddDepartment.Location = new System.Drawing.Point(155, 12);
            this.txtAddDepartment.Name = "txtAddDepartment";
            this.txtAddDepartment.Size = new System.Drawing.Size(355, 22);
            this.txtAddDepartment.TabIndex = 4;
            // 
            // frmAddTrainingDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(516, 76);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddTrainingDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddTrainingDepartment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Training Department";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddTrainingDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddTrainingDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddDepartment;
    }
}