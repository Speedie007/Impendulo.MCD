namespace MCDHowToAccessData
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentIDNumber;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.TextBox StudentLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStudentTitle;
        private System.Windows.Forms.BindingSource lookupTitleBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboStudentQualificationLevel;
        private System.Windows.Forms.BindingSource lookupQualificationLevelBindingSource;
        private System.Windows.Forms.ComboBox cboStudentEnthnicity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStudentGender;
        private System.Windows.Forms.BindingSource lookupGenderBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboStudentMaritialStatus;
        private System.Windows.Forms.BindingSource lookupMartialStatusBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

