namespace Impendulo.Scheduling
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabApprenticeship = new System.Windows.Forms.TabPage();
            this.tabAssesments = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabMain.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabApprenticeship.SuspendLayout();
            this.tabAssesments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabHome);
            this.tabMain.Controls.Add(this.tabApprenticeship);
            this.tabMain.Controls.Add(this.tabAssesments);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1024, 660);
            this.tabMain.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.groupBox3);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1016, 631);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabApprenticeship
            // 
            this.tabApprenticeship.Controls.Add(this.groupBox1);
            this.tabApprenticeship.Location = new System.Drawing.Point(4, 25);
            this.tabApprenticeship.Name = "tabApprenticeship";
            this.tabApprenticeship.Padding = new System.Windows.Forms.Padding(3);
            this.tabApprenticeship.Size = new System.Drawing.Size(1016, 631);
            this.tabApprenticeship.TabIndex = 1;
            this.tabApprenticeship.Text = "Apprenticeship";
            this.tabApprenticeship.UseVisualStyleBackColor = true;
            // 
            // tabAssesments
            // 
            this.tabAssesments.Controls.Add(this.groupBox2);
            this.tabAssesments.Location = new System.Drawing.Point(4, 25);
            this.tabAssesments.Name = "tabAssesments";
            this.tabAssesments.Size = new System.Drawing.Size(1016, 631);
            this.tabAssesments.TabIndex = 2;
            this.tabAssesments.Text = "Assesments";
            this.tabAssesments.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 625);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 631);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1010, 625);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMain.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabApprenticeship.ResumeLayout(false);
            this.tabAssesments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabApprenticeship;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabAssesments;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

