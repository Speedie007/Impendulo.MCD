namespace Impendulo.Courses.Add.CourseDatabase
{
    partial class frmAddTrainingDepartmentCoursesEnrollmentTypeMetaData
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
            this.cboEnrollmentTypes = new System.Windows.Forms.ComboBox();
            this.lookupEnrollmentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData = new System.Windows.Forms.Button();
            this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesciption = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEnrollmentTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEnrollmentTypes
            // 
            this.cboEnrollmentTypes.DataSource = this.lookupEnrollmentTypeBindingSource;
            this.cboEnrollmentTypes.DisplayMember = "EnrollmentType";
            this.cboEnrollmentTypes.FormattingEnabled = true;
            this.cboEnrollmentTypes.Location = new System.Drawing.Point(162, 12);
            this.cboEnrollmentTypes.Name = "cboEnrollmentTypes";
            this.cboEnrollmentTypes.Size = new System.Drawing.Size(167, 24);
            this.cboEnrollmentTypes.TabIndex = 0;
            this.cboEnrollmentTypes.ValueMember = "EnrollmentTypeID";
            // 
            // lookupEnrollmentTypeBindingSource
            // 
            this.lookupEnrollmentTypeBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupEnrollmentType);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enrollment Type:";
            // 
            // txtMaximum
            // 
            this.txtMaximum.Location = new System.Drawing.Point(162, 73);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.Size = new System.Drawing.Size(64, 22);
            this.txtMaximum.TabIndex = 2;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(162, 42);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(167, 22);
            this.txtCost.TabIndex = 4;
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(162, 101);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(64, 22);
            this.txtMinimum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minimum Allowed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maximum Allowed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost:";
            // 
            // btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData
            // 
            this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData.Location = new System.Drawing.Point(415, 157);
            this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData.Name = "btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData";
            this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData.TabIndex = 10;
            this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData.Text = "Add";
            this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData.UseVisualStyleBackColor = true;
            this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData.Click += new System.EventHandler(this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData_Click);
            // 
            // btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData
            // 
            this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData.Location = new System.Drawing.Point(323, 157);
            this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData.Name = "btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData";
            this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData.Size = new System.Drawing.Size(86, 23);
            this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData.TabIndex = 11;
            this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData.Text = "&Cancel";
            this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData.UseVisualStyleBackColor = true;
            this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData.Click += new System.EventHandler(this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Description:";
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(162, 129);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(331, 22);
            this.txtDesciption.TabIndex = 12;
            this.txtDesciption.Text = "Default";
            // 
            // frmAddTrainingDepartmentCoursesEnrollmentTypeMetaData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(502, 188);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData);
            this.Controls.Add(this.btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtMaximum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEnrollmentTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddTrainingDepartmentCoursesEnrollmentTypeMetaData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add TrainingDepartment Courses Enrollment Type";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddTrainingDepartmentCoursesEnrollmentTypeMetaData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookupEnrollmentTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEnrollmentTypes;
        private System.Windows.Forms.BindingSource lookupEnrollmentTypeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaximum;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddTrainingDepartmentCoursesEnrollmentTypeMetaData;
        private System.Windows.Forms.Button btnCancelTrainingDepartmentCoursesEnrollmentTypeMetaData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesciption;
    }
}