namespace Impendulo.ContactDetails.Development
{
    partial class frmAddUpdateContactDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbAddStudentContactInfo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblAddControlType = new System.Windows.Forms.Label();
            this.txtStudentContactTypeAddEmailAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelAddStudnetContactInfo = new System.Windows.Forms.Button();
            this.btnAddContactInfo = new System.Windows.Forms.Button();
            this.btnUpdateContactInfo = new System.Windows.Forms.Button();
            this.gbContactYpeSelection = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelContactTypeOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbAddStudentContactInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbContactYpeSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Details";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.gbContactYpeSelection);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(693, 120);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbAddStudentContactInfo);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 54);
            this.panel2.TabIndex = 8;
            // 
            // gbAddStudentContactInfo
            // 
            this.gbAddStudentContactInfo.Controls.Add(this.flowLayoutPanel1);
            this.gbAddStudentContactInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddStudentContactInfo.Location = new System.Drawing.Point(0, 0);
            this.gbAddStudentContactInfo.Name = "gbAddStudentContactInfo";
            this.gbAddStudentContactInfo.Size = new System.Drawing.Size(685, 54);
            this.gbAddStudentContactInfo.TabIndex = 5;
            this.gbAddStudentContactInfo.TabStop = false;
            this.gbAddStudentContactInfo.Text = "Add/Update Contact Detail";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.txtStudentContactTypeAddEmailAddress);
            this.flowLayoutPanel1.Controls.Add(this.txtContactNumber);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelAddStudnetContactInfo);
            this.flowLayoutPanel1.Controls.Add(this.btnAddContactInfo);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateContactInfo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(679, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblAddControlType);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(75, 25);
            this.panel6.TabIndex = 3;
            // 
            // lblAddControlType
            // 
            this.lblAddControlType.AutoSize = true;
            this.lblAddControlType.Location = new System.Drawing.Point(3, 4);
            this.lblAddControlType.Name = "lblAddControlType";
            this.lblAddControlType.Size = new System.Drawing.Size(35, 13);
            this.lblAddControlType.TabIndex = 0;
            this.lblAddControlType.Text = "label3";
            // 
            // txtStudentContactTypeAddEmailAddress
            // 
            this.txtStudentContactTypeAddEmailAddress.Location = new System.Drawing.Point(84, 4);
            this.txtStudentContactTypeAddEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txtStudentContactTypeAddEmailAddress.Name = "txtStudentContactTypeAddEmailAddress";
            this.txtStudentContactTypeAddEmailAddress.Size = new System.Drawing.Size(289, 20);
            this.txtStudentContactTypeAddEmailAddress.TabIndex = 2;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(379, 4);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txtContactNumber.Mask = "(999) 000-0000";
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(100, 20);
            this.txtContactNumber.TabIndex = 1;
            // 
            // btnCancelAddStudnetContactInfo
            // 
            this.btnCancelAddStudnetContactInfo.Location = new System.Drawing.Point(485, 3);
            this.btnCancelAddStudnetContactInfo.Name = "btnCancelAddStudnetContactInfo";
            this.btnCancelAddStudnetContactInfo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddStudnetContactInfo.TabIndex = 7;
            this.btnCancelAddStudnetContactInfo.Text = "Cancel";
            this.btnCancelAddStudnetContactInfo.UseVisualStyleBackColor = true;
            this.btnCancelAddStudnetContactInfo.Click += new System.EventHandler(this.btnCancelAddStudnetContactInfo_Click);
            // 
            // btnAddContactInfo
            // 
            this.btnAddContactInfo.Location = new System.Drawing.Point(566, 3);
            this.btnAddContactInfo.Name = "btnAddContactInfo";
            this.btnAddContactInfo.Size = new System.Drawing.Size(75, 23);
            this.btnAddContactInfo.TabIndex = 6;
            this.btnAddContactInfo.Text = "Add ";
            this.btnAddContactInfo.UseVisualStyleBackColor = true;
            this.btnAddContactInfo.Click += new System.EventHandler(this.btnAddContactInfo_Click);
            // 
            // btnUpdateContactInfo
            // 
            this.btnUpdateContactInfo.Location = new System.Drawing.Point(3, 34);
            this.btnUpdateContactInfo.Name = "btnUpdateContactInfo";
            this.btnUpdateContactInfo.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateContactInfo.TabIndex = 9;
            this.btnUpdateContactInfo.Text = "Update";
            this.btnUpdateContactInfo.UseVisualStyleBackColor = true;
            this.btnUpdateContactInfo.Click += new System.EventHandler(this.btnUpdateContactInfo_Click);
            // 
            // gbContactYpeSelection
            // 
            this.gbContactYpeSelection.Controls.Add(this.flowLayoutPanelContactTypeOptions);
            this.gbContactYpeSelection.Location = new System.Drawing.Point(3, 63);
            this.gbContactYpeSelection.Name = "gbContactYpeSelection";
            this.gbContactYpeSelection.Size = new System.Drawing.Size(685, 53);
            this.gbContactYpeSelection.TabIndex = 0;
            this.gbContactYpeSelection.TabStop = false;
            this.gbContactYpeSelection.Text = "Select Type";
            // 
            // flowLayoutPanelContactTypeOptions
            // 
            this.flowLayoutPanelContactTypeOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContactTypeOptions.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelContactTypeOptions.Name = "flowLayoutPanelContactTypeOptions";
            this.flowLayoutPanelContactTypeOptions.Size = new System.Drawing.Size(679, 34);
            this.flowLayoutPanelContactTypeOptions.TabIndex = 7;
            // 
            // frmAddUpdateContactDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 139);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateContactDetails";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Contact Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbAddStudentContactInfo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.gbContactYpeSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAddStudentContactInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblAddControlType;
        private System.Windows.Forms.TextBox txtStudentContactTypeAddEmailAddress;
        private System.Windows.Forms.MaskedTextBox txtContactNumber;
        private System.Windows.Forms.Button btnCancelAddStudnetContactInfo;
        private System.Windows.Forms.Button btnAddContactInfo;
        private System.Windows.Forms.Button btnUpdateContactInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbContactYpeSelection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContactTypeOptions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

