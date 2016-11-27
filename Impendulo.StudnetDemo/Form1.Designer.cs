namespace Impendulo.StudnetDemo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentIDNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStudentEnthnicity = new System.Windows.Forms.ComboBox();
            this.lookupEthnicityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboStudentMaritialStatus = new System.Windows.Forms.ComboBox();
            this.lookupMartialStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboStudentTitle = new System.Windows.Forms.ComboBox();
            this.lookupTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboStudentQualificationLevel = new System.Windows.Forms.ComboBox();
            this.lookupQualificationLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboStudentGender = new System.Windows.Forms.ComboBox();
            this.lookupGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEthnicityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMartialStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupQualificationLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupGenderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student First Name";
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(260, 27);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(353, 22);
            this.txtStudentFirstName.TabIndex = 1;
            // 
            // txtStudentIDNumber
            // 
            this.txtStudentIDNumber.Location = new System.Drawing.Point(260, 83);
            this.txtStudentIDNumber.Name = "txtStudentIDNumber";
            this.txtStudentIDNumber.Size = new System.Drawing.Size(353, 22);
            this.txtStudentIDNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID Number";
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(260, 55);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(353, 22);
            this.txtStudentLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Last Name";
            // 
            // cboStudentEnthnicity
            // 
            this.cboStudentEnthnicity.DataSource = this.lookupEthnicityBindingSource;
            this.cboStudentEnthnicity.DisplayMember = "Ethnicity";
            this.cboStudentEnthnicity.FormattingEnabled = true;
            this.cboStudentEnthnicity.Location = new System.Drawing.Point(260, 112);
            this.cboStudentEnthnicity.Name = "cboStudentEnthnicity";
            this.cboStudentEnthnicity.Size = new System.Drawing.Size(255, 24);
            this.cboStudentEnthnicity.TabIndex = 6;
            this.cboStudentEnthnicity.ValueMember = "EthnicityID";
            // 
            // lookupEthnicityBindingSource
            // 
            this.lookupEthnicityBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupEthnicity);
            // 
            // cboStudentMaritialStatus
            // 
            this.cboStudentMaritialStatus.DataSource = this.lookupMartialStatusBindingSource;
            this.cboStudentMaritialStatus.DisplayMember = "MaritialStatus";
            this.cboStudentMaritialStatus.FormattingEnabled = true;
            this.cboStudentMaritialStatus.Location = new System.Drawing.Point(260, 142);
            this.cboStudentMaritialStatus.Name = "cboStudentMaritialStatus";
            this.cboStudentMaritialStatus.Size = new System.Drawing.Size(255, 24);
            this.cboStudentMaritialStatus.TabIndex = 7;
            this.cboStudentMaritialStatus.ValueMember = "MartialStatusID";
            // 
            // lookupMartialStatusBindingSource
            // 
            this.lookupMartialStatusBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupMartialStatus);
            // 
            // cboStudentTitle
            // 
            this.cboStudentTitle.DataSource = this.lookupTitleBindingSource;
            this.cboStudentTitle.DisplayMember = "Title";
            this.cboStudentTitle.FormattingEnabled = true;
            this.cboStudentTitle.Location = new System.Drawing.Point(260, 173);
            this.cboStudentTitle.Name = "cboStudentTitle";
            this.cboStudentTitle.Size = new System.Drawing.Size(255, 24);
            this.cboStudentTitle.TabIndex = 8;
            this.cboStudentTitle.ValueMember = "TitleID";
            // 
            // lookupTitleBindingSource
            // 
            this.lookupTitleBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupTitle);
            // 
            // cboStudentQualificationLevel
            // 
            this.cboStudentQualificationLevel.DataSource = this.lookupQualificationLevelBindingSource;
            this.cboStudentQualificationLevel.DisplayMember = "QualificationLevel";
            this.cboStudentQualificationLevel.FormattingEnabled = true;
            this.cboStudentQualificationLevel.Location = new System.Drawing.Point(260, 204);
            this.cboStudentQualificationLevel.Name = "cboStudentQualificationLevel";
            this.cboStudentQualificationLevel.Size = new System.Drawing.Size(255, 24);
            this.cboStudentQualificationLevel.TabIndex = 9;
            this.cboStudentQualificationLevel.ValueMember = "QualificationLevelID";
            // 
            // lookupQualificationLevelBindingSource
            // 
            this.lookupQualificationLevelBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupQualificationLevel);
            // 
            // cboStudentGender
            // 
            this.cboStudentGender.DataSource = this.lookupGenderBindingSource;
            this.cboStudentGender.DisplayMember = "Gender";
            this.cboStudentGender.FormattingEnabled = true;
            this.cboStudentGender.Location = new System.Drawing.Point(260, 235);
            this.cboStudentGender.Name = "cboStudentGender";
            this.cboStudentGender.Size = new System.Drawing.Size(255, 24);
            this.cboStudentGender.TabIndex = 10;
            this.cboStudentGender.ValueMember = "GenderID";
            // 
            // lookupGenderBindingSource
            // 
            this.lookupGenderBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupGender);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Highest Student Qualification Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Student Martial Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Student Ethnicity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 49);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboStudentGender);
            this.Controls.Add(this.cboStudentQualificationLevel);
            this.Controls.Add(this.cboStudentTitle);
            this.Controls.Add(this.cboStudentMaritialStatus);
            this.Controls.Add(this.cboStudentEnthnicity);
            this.Controls.Add(this.txtStudentLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentIDNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentFirstName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookupEthnicityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMartialStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupQualificationLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupGenderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.TextBox txtStudentIDNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStudentEnthnicity;
        private System.Windows.Forms.ComboBox cboStudentMaritialStatus;
        private System.Windows.Forms.ComboBox cboStudentTitle;
        private System.Windows.Forms.ComboBox cboStudentQualificationLevel;
        private System.Windows.Forms.ComboBox cboStudentGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource lookupEthnicityBindingSource;
        private System.Windows.Forms.BindingSource lookupMartialStatusBindingSource;
        private System.Windows.Forms.BindingSource lookupTitleBindingSource;
        private System.Windows.Forms.BindingSource lookupQualificationLevelBindingSource;
        private System.Windows.Forms.BindingSource lookupGenderBindingSource;
        private System.Windows.Forms.Button button2;
    }
}

