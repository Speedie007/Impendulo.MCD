namespace Impendulo.Courses.InputForms.Deployment
{
    partial class frmAddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDepartment));
            this.txtAddDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddDepartment
            // 
            this.txtAddDepartment.Location = new System.Drawing.Point(100, 12);
            this.txtAddDepartment.Name = "txtAddDepartment";
            this.txtAddDepartment.Size = new System.Drawing.Size(355, 20);
            this.txtAddDepartment.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department";
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDepartment.Image")));
            this.btnAddDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDepartment.Location = new System.Drawing.Point(339, 40);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(117, 30);
            this.btnAddDepartment.TabIndex = 2;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(262, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAddDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(460, 73);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddDepartment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Department";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button button2;
    }
}