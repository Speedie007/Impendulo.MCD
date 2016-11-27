namespace WizardTemplate
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
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.panelNavigationPanel = new System.Windows.Forms.Panel();
            this.panelNaigationalLinks = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.IsSplitterFixed = true;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.panelNaigationalLinks);
            this.MainSplitContainer.Panel1.Controls.Add(this.panelNavigationPanel);
            this.MainSplitContainer.Size = new System.Drawing.Size(1177, 619);
            this.MainSplitContainer.SplitterDistance = 185;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // panelNavigationPanel
            // 
            this.panelNavigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.panelNavigationPanel.Name = "panelNavigationPanel";
            this.panelNavigationPanel.Size = new System.Drawing.Size(185, 89);
            this.panelNavigationPanel.TabIndex = 0;
            // 
            // panelNaigationalLinks
            // 
            this.panelNaigationalLinks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNaigationalLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNaigationalLinks.Location = new System.Drawing.Point(0, 89);
            this.panelNaigationalLinks.Margin = new System.Windows.Forms.Padding(0);
            this.panelNaigationalLinks.Name = "panelNaigationalLinks";
            this.panelNaigationalLinks.Size = new System.Drawing.Size(185, 530);
            this.panelNaigationalLinks.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 619);
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Panel panelNaigationalLinks;
        private System.Windows.Forms.Panel panelNavigationPanel;
    }
}

