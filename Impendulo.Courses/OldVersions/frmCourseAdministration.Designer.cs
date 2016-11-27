namespace Impendulo.Courses
{
    partial class frmCourseAdministration
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelCourseSelectionMain = new System.Windows.Forms.Panel();
            this.panelCourseSelectionItems = new System.Windows.Forms.Panel();
            this.panelCourseSelectionHeading = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelCourseSelectionMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelCourseSelectionMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1140, 704);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelCourseSelectionMain
            // 
            this.panelCourseSelectionMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCourseSelectionMain.Controls.Add(this.panelCourseSelectionItems);
            this.panelCourseSelectionMain.Controls.Add(this.panelCourseSelectionHeading);
            this.panelCourseSelectionMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCourseSelectionMain.Location = new System.Drawing.Point(0, 0);
            this.panelCourseSelectionMain.Name = "panelCourseSelectionMain";
            this.panelCourseSelectionMain.Size = new System.Drawing.Size(248, 704);
            this.panelCourseSelectionMain.TabIndex = 0;
            // 
            // panelCourseSelectionItems
            // 
            this.panelCourseSelectionItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCourseSelectionItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCourseSelectionItems.Location = new System.Drawing.Point(0, 98);
            this.panelCourseSelectionItems.Name = "panelCourseSelectionItems";
            this.panelCourseSelectionItems.Size = new System.Drawing.Size(244, 602);
            this.panelCourseSelectionItems.TabIndex = 1;
            // 
            // panelCourseSelectionHeading
            // 
            this.panelCourseSelectionHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCourseSelectionHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCourseSelectionHeading.Location = new System.Drawing.Point(0, 0);
            this.panelCourseSelectionHeading.Name = "panelCourseSelectionHeading";
            this.panelCourseSelectionHeading.Size = new System.Drawing.Size(244, 98);
            this.panelCourseSelectionHeading.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 704);
            this.panel1.TabIndex = 1;
            // 
            // frmCourseAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 704);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCourseAdministration";
            this.Text = "frmCourseAdministration";
            this.Load += new System.EventHandler(this.frmCourseAdministration_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelCourseSelectionMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelCourseSelectionMain;
        private System.Windows.Forms.Panel panelCourseSelectionItems;
        private System.Windows.Forms.Panel panelCourseSelectionHeading;
        private System.Windows.Forms.Panel panel1;
    }
}