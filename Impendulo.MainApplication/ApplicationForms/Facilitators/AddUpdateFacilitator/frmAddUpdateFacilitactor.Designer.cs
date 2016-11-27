namespace Impendulo.Facilitators.Deployment
{
    partial class frmAddUpdateFacilitator
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
            System.Windows.Forms.Label individualSecondNameLabel;
            System.Windows.Forms.Label individualLastnameLabel;
            System.Windows.Forms.Label individualFirstNameLabel;
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btmCancel = new System.Windows.Forms.Button();
            this.cboEmployeeTitle = new System.Windows.Forms.ComboBox();
            this.lookupTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmployeeSecondName = new System.Windows.Forms.TextBox();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            individualSecondNameLabel = new System.Windows.Forms.Label();
            individualLastnameLabel = new System.Windows.Forms.Label();
            individualFirstNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTitleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // individualSecondNameLabel
            // 
            individualSecondNameLabel.AutoSize = true;
            individualSecondNameLabel.Location = new System.Drawing.Point(11, 75);
            individualSecondNameLabel.Name = "individualSecondNameLabel";
            individualSecondNameLabel.Size = new System.Drawing.Size(78, 13);
            individualSecondNameLabel.TabIndex = 39;
            individualSecondNameLabel.Text = "Second Name:";
            // 
            // individualLastnameLabel
            // 
            individualLastnameLabel.AutoSize = true;
            individualLastnameLabel.Location = new System.Drawing.Point(11, 101);
            individualLastnameLabel.Name = "individualLastnameLabel";
            individualLastnameLabel.Size = new System.Drawing.Size(56, 13);
            individualLastnameLabel.TabIndex = 37;
            individualLastnameLabel.Text = "Lastname:";
            // 
            // individualFirstNameLabel
            // 
            individualFirstNameLabel.AutoSize = true;
            individualFirstNameLabel.Location = new System.Drawing.Point(11, 49);
            individualFirstNameLabel.Name = "individualFirstNameLabel";
            individualFirstNameLabel.Size = new System.Drawing.Size(60, 13);
            individualFirstNameLabel.TabIndex = 35;
            individualFirstNameLabel.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 41;
            label1.Text = "Title:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.cboEmployeeTitle);
            this.groupBox1.Controls.Add(this.txtEmployeeSecondName);
            this.groupBox1.Controls.Add(individualSecondNameLabel);
            this.groupBox1.Controls.Add(this.txtEmployeeLastName);
            this.groupBox1.Controls.Add(individualLastnameLabel);
            this.groupBox1.Controls.Add(individualFirstNameLabel);
            this.groupBox1.Controls.Add(this.txtEmployeeFirstName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facilitator Details";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddEmployee);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateEmployee);
            this.flowLayoutPanel1.Controls.Add(this.btmCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 31);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(308, 3);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(227, 3);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEmployee.TabIndex = 1;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btmCancel
            // 
            this.btmCancel.Location = new System.Drawing.Point(146, 3);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(75, 23);
            this.btmCancel.TabIndex = 2;
            this.btmCancel.Text = "Cancel";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // cboEmployeeTitle
            // 
            this.cboEmployeeTitle.DataSource = this.lookupTitleBindingSource;
            this.cboEmployeeTitle.DisplayMember = "Title";
            this.cboEmployeeTitle.FormattingEnabled = true;
            this.cboEmployeeTitle.Location = new System.Drawing.Point(113, 19);
            this.cboEmployeeTitle.Name = "cboEmployeeTitle";
            this.cboEmployeeTitle.Size = new System.Drawing.Size(122, 21);
            this.cboEmployeeTitle.TabIndex = 40;
            this.cboEmployeeTitle.ValueMember = "TitleID";
            // 
            // lookupTitleBindingSource
            // 
            this.lookupTitleBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupTitle);
            // 
            // txtEmployeeSecondName
            // 
            this.txtEmployeeSecondName.Location = new System.Drawing.Point(113, 72);
            this.txtEmployeeSecondName.Name = "txtEmployeeSecondName";
            this.txtEmployeeSecondName.Size = new System.Drawing.Size(266, 20);
            this.txtEmployeeSecondName.TabIndex = 40;
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(113, 98);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(266, 20);
            this.txtEmployeeLastName.TabIndex = 38;
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(113, 46);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(266, 20);
            this.txtEmployeeFirstName.TabIndex = 36;
            // 
            // frmAddUpdateFacilitator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 163);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateFacilitator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Facilitator Details";
            this.Load += new System.EventHandler(this.frmAddUpdateEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookupTitleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEmployeeTitle;
        private System.Windows.Forms.BindingSource lookupTitleBindingSource;
        private System.Windows.Forms.TextBox txtEmployeeSecondName;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btmCancel;
    }
}