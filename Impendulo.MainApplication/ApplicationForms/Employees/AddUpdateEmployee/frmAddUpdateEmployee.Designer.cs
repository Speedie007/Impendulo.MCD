namespace Impendulo.Employees.AddUpdateEmployee.Deployment
{
    partial class frmAddUpdateEmployee
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
            System.Windows.Forms.Label employeeNumberLabel;
            System.Windows.Forms.Label individualSecondNameLabel;
            System.Windows.Forms.Label individualLastnameLabel;
            System.Windows.Forms.Label individualFirstNameLabel;
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbUsernameAndPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btmCancel = new System.Windows.Forms.Button();
            this.cboEmployeeTitle = new System.Windows.Forms.ComboBox();
            this.lookupTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeSecondName = new System.Windows.Forms.TextBox();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            employeeNumberLabel = new System.Windows.Forms.Label();
            individualSecondNameLabel = new System.Windows.Forms.Label();
            individualLastnameLabel = new System.Windows.Forms.Label();
            individualFirstNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbUsernameAndPassword.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTitleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeNumberLabel
            // 
            employeeNumberLabel.AutoSize = true;
            employeeNumberLabel.Location = new System.Drawing.Point(12, 26);
            employeeNumberLabel.Name = "employeeNumberLabel";
            employeeNumberLabel.Size = new System.Drawing.Size(96, 13);
            employeeNumberLabel.TabIndex = 33;
            employeeNumberLabel.Text = "Employee Number:";
            // 
            // individualSecondNameLabel
            // 
            individualSecondNameLabel.AutoSize = true;
            individualSecondNameLabel.Location = new System.Drawing.Point(12, 105);
            individualSecondNameLabel.Name = "individualSecondNameLabel";
            individualSecondNameLabel.Size = new System.Drawing.Size(78, 13);
            individualSecondNameLabel.TabIndex = 39;
            individualSecondNameLabel.Text = "Second Name:";
            // 
            // individualLastnameLabel
            // 
            individualLastnameLabel.AutoSize = true;
            individualLastnameLabel.Location = new System.Drawing.Point(12, 131);
            individualLastnameLabel.Name = "individualLastnameLabel";
            individualLastnameLabel.Size = new System.Drawing.Size(56, 13);
            individualLastnameLabel.TabIndex = 37;
            individualLastnameLabel.Text = "Lastname:";
            // 
            // individualFirstNameLabel
            // 
            individualFirstNameLabel.AutoSize = true;
            individualFirstNameLabel.Location = new System.Drawing.Point(12, 79);
            individualFirstNameLabel.Name = "individualFirstNameLabel";
            individualFirstNameLabel.Size = new System.Drawing.Size(60, 13);
            individualFirstNameLabel.TabIndex = 35;
            individualFirstNameLabel.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 41;
            label1.Text = "Title:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbUsernameAndPassword);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.cboEmployeeTitle);
            this.groupBox1.Controls.Add(employeeNumberLabel);
            this.groupBox1.Controls.Add(this.txtEmployeeNumber);
            this.groupBox1.Controls.Add(this.txtEmployeeSecondName);
            this.groupBox1.Controls.Add(individualSecondNameLabel);
            this.groupBox1.Controls.Add(this.txtEmployeeLastName);
            this.groupBox1.Controls.Add(individualLastnameLabel);
            this.groupBox1.Controls.Add(individualFirstNameLabel);
            this.groupBox1.Controls.Add(this.txtEmployeeFirstName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // gbUsernameAndPassword
            // 
            this.gbUsernameAndPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbUsernameAndPassword.Controls.Add(this.txtPassword);
            this.gbUsernameAndPassword.Controls.Add(this.label3);
            this.gbUsernameAndPassword.Controls.Add(this.txtPasswordConfirmation);
            this.gbUsernameAndPassword.Controls.Add(this.label2);
            this.gbUsernameAndPassword.Controls.Add(this.txtUsername);
            this.gbUsernameAndPassword.Controls.Add(this.label4);
            this.gbUsernameAndPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbUsernameAndPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbUsernameAndPassword.Location = new System.Drawing.Point(3, 154);
            this.gbUsernameAndPassword.Name = "gbUsernameAndPassword";
            this.gbUsernameAndPassword.Size = new System.Drawing.Size(386, 106);
            this.gbUsernameAndPassword.TabIndex = 43;
            this.gbUsernameAndPassword.TabStop = false;
            this.gbUsernameAndPassword.Text = "Username And Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(245, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(132, 74);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(245, 20);
            this.txtPasswordConfirmation.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password Confirmation:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(132, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(245, 20);
            this.txtUsername.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Name:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddEmployee);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateEmployee);
            this.flowLayoutPanel1.Controls.Add(this.btmCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 260);
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
            this.cboEmployeeTitle.Location = new System.Drawing.Point(114, 49);
            this.cboEmployeeTitle.Name = "cboEmployeeTitle";
            this.cboEmployeeTitle.Size = new System.Drawing.Size(122, 21);
            this.cboEmployeeTitle.TabIndex = 40;
            this.cboEmployeeTitle.ValueMember = "TitleID";
            // 
            // lookupTitleBindingSource
            // 
            this.lookupTitleBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupTitle);
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(114, 23);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(122, 20);
            this.txtEmployeeNumber.TabIndex = 34;
            // 
            // txtEmployeeSecondName
            // 
            this.txtEmployeeSecondName.Location = new System.Drawing.Point(114, 102);
            this.txtEmployeeSecondName.Name = "txtEmployeeSecondName";
            this.txtEmployeeSecondName.Size = new System.Drawing.Size(266, 20);
            this.txtEmployeeSecondName.TabIndex = 40;
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(114, 128);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(266, 20);
            this.txtEmployeeLastName.TabIndex = 38;
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(114, 76);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(266, 20);
            this.txtEmployeeFirstName.TabIndex = 36;
            // 
            // frmAddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 294);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Employee Details";
            this.Load += new System.EventHandler(this.frmAddUpdateEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUsernameAndPassword.ResumeLayout(false);
            this.gbUsernameAndPassword.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookupTitleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEmployeeTitle;
        private System.Windows.Forms.BindingSource lookupTitleBindingSource;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.TextBox txtEmployeeSecondName;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.GroupBox gbUsernameAndPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
    }
}