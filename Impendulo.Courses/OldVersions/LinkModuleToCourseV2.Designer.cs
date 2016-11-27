namespace Impendulo.Courses
{
    partial class LinkModuleToCourseV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkModuleToCourseV2));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbAvailableModules = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLinkCourseModule = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModuleDuration = new System.Windows.Forms.Label();
            this.lblModuleCost = new System.Windows.Forms.Label();
            this.txtModuleDuration = new System.Windows.Forms.TextBox();
            this.txtModuleCost = new System.Windows.Forms.TextBox();
            this.lstModuleINSERT = new System.Windows.Forms.ListBox();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowInsertModuleSection = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtModuleDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelAddingModule = new System.Windows.Forms.Button();
            this.btnInsertModule = new System.Windows.Forms.Button();
            this.txtModuleNameINSERTIntoModules = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbAvailableModules.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.gbAvailableModules);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 11);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(902, 555);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gbAvailableModules
            // 
            this.gbAvailableModules.Controls.Add(this.button1);
            this.gbAvailableModules.Controls.Add(this.btnLinkCourseModule);
            this.gbAvailableModules.Controls.Add(this.groupBox1);
            this.gbAvailableModules.Controls.Add(this.lstModuleINSERT);
            this.gbAvailableModules.Controls.Add(this.btnShowInsertModuleSection);
            this.gbAvailableModules.Location = new System.Drawing.Point(2, 5);
            this.gbAvailableModules.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbAvailableModules.Name = "gbAvailableModules";
            this.gbAvailableModules.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbAvailableModules.Size = new System.Drawing.Size(877, 367);
            this.gbAvailableModules.TabIndex = 8;
            this.gbAvailableModules.TabStop = false;
            this.gbAvailableModules.Text = "All Available Modules";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(613, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLinkCourseModule
            // 
            this.btnLinkCourseModule.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkCourseModule.Image")));
            this.btnLinkCourseModule.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLinkCourseModule.Location = new System.Drawing.Point(705, 120);
            this.btnLinkCourseModule.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnLinkCourseModule.Name = "btnLinkCourseModule";
            this.btnLinkCourseModule.Size = new System.Drawing.Size(155, 37);
            this.btnLinkCourseModule.TabIndex = 13;
            this.btnLinkCourseModule.Text = "Link Selected Module";
            this.btnLinkCourseModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinkCourseModule.UseVisualStyleBackColor = true;
            this.btnLinkCourseModule.Click += new System.EventHandler(this.btnLinkCourseModule_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblModuleDuration);
            this.groupBox1.Controls.Add(this.lblModuleCost);
            this.groupBox1.Controls.Add(this.txtModuleDuration);
            this.groupBox1.Controls.Add(this.txtModuleCost);
            this.groupBox1.Location = new System.Drawing.Point(608, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Size = new System.Drawing.Size(250, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "R";
            // 
            // lblModuleDuration
            // 
            this.lblModuleDuration.AutoSize = true;
            this.lblModuleDuration.Location = new System.Drawing.Point(15, 57);
            this.lblModuleDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleDuration.Name = "lblModuleDuration";
            this.lblModuleDuration.Size = new System.Drawing.Size(101, 16);
            this.lblModuleDuration.TabIndex = 15;
            this.lblModuleDuration.Text = "Module Duration";
            // 
            // lblModuleCost
            // 
            this.lblModuleCost.AutoSize = true;
            this.lblModuleCost.Location = new System.Drawing.Point(15, 31);
            this.lblModuleCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleCost.Name = "lblModuleCost";
            this.lblModuleCost.Size = new System.Drawing.Size(78, 16);
            this.lblModuleCost.TabIndex = 14;
            this.lblModuleCost.Text = "Module Cost";
            // 
            // txtModuleDuration
            // 
            this.txtModuleDuration.Location = new System.Drawing.Point(121, 53);
            this.txtModuleDuration.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtModuleDuration.Multiline = true;
            this.txtModuleDuration.Name = "txtModuleDuration";
            this.txtModuleDuration.Size = new System.Drawing.Size(125, 21);
            this.txtModuleDuration.TabIndex = 13;
            this.txtModuleDuration.Text = "0";
            // 
            // txtModuleCost
            // 
            this.txtModuleCost.Location = new System.Drawing.Point(138, 26);
            this.txtModuleCost.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtModuleCost.Name = "txtModuleCost";
            this.txtModuleCost.Size = new System.Drawing.Size(108, 23);
            this.txtModuleCost.TabIndex = 11;
            this.txtModuleCost.Text = "0";
            // 
            // lstModuleINSERT
            // 
            this.lstModuleINSERT.DataSource = this.moduleBindingSource;
            this.lstModuleINSERT.DisplayMember = "ModuleName";
            this.lstModuleINSERT.FormattingEnabled = true;
            this.lstModuleINSERT.ItemHeight = 16;
            this.lstModuleINSERT.Location = new System.Drawing.Point(6, 21);
            this.lstModuleINSERT.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.lstModuleINSERT.Name = "lstModuleINSERT";
            this.lstModuleINSERT.Size = new System.Drawing.Size(598, 292);
            this.lstModuleINSERT.TabIndex = 6;
            this.lstModuleINSERT.ValueMember = "ModuleID";
            // 
            // btnShowInsertModuleSection
            // 
            this.btnShowInsertModuleSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInsertModuleSection.Image = ((System.Drawing.Image)(resources.GetObject("btnShowInsertModuleSection.Image")));
            this.btnShowInsertModuleSection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowInsertModuleSection.Location = new System.Drawing.Point(446, 318);
            this.btnShowInsertModuleSection.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnShowInsertModuleSection.Name = "btnShowInsertModuleSection";
            this.btnShowInsertModuleSection.Size = new System.Drawing.Size(158, 39);
            this.btnShowInsertModuleSection.TabIndex = 5;
            this.btnShowInsertModuleSection.Text = "Add Module       ";
            this.btnShowInsertModuleSection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowInsertModuleSection.UseVisualStyleBackColor = true;
            this.btnShowInsertModuleSection.Click += new System.EventHandler(this.btnShowInsertModuleSection_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtModuleDescription);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnCancelAddingModule);
            this.groupBox3.Controls.Add(this.btnInsertModule);
            this.groupBox3.Controls.Add(this.txtModuleNameINSERTIntoModules);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(2, 382);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox3.Size = new System.Drawing.Size(422, 160);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Module If Does Not Listed";
            // 
            // txtModuleDescription
            // 
            this.txtModuleDescription.Location = new System.Drawing.Point(129, 59);
            this.txtModuleDescription.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtModuleDescription.Multiline = true;
            this.txtModuleDescription.Name = "txtModuleDescription";
            this.txtModuleDescription.Size = new System.Drawing.Size(289, 45);
            this.txtModuleDescription.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Module Description";
            // 
            // btnCancelAddingModule
            // 
            this.btnCancelAddingModule.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelAddingModule.Image")));
            this.btnCancelAddingModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAddingModule.Location = new System.Drawing.Point(199, 113);
            this.btnCancelAddingModule.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnCancelAddingModule.Name = "btnCancelAddingModule";
            this.btnCancelAddingModule.Size = new System.Drawing.Size(92, 41);
            this.btnCancelAddingModule.TabIndex = 5;
            this.btnCancelAddingModule.Text = "Cancel";
            this.btnCancelAddingModule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelAddingModule.UseVisualStyleBackColor = true;
            this.btnCancelAddingModule.Click += new System.EventHandler(this.btnCancelAddingModule_Click);
            // 
            // btnInsertModule
            // 
            this.btnInsertModule.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertModule.Image")));
            this.btnInsertModule.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertModule.Location = new System.Drawing.Point(296, 113);
            this.btnInsertModule.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnInsertModule.Name = "btnInsertModule";
            this.btnInsertModule.Size = new System.Drawing.Size(120, 41);
            this.btnInsertModule.TabIndex = 4;
            this.btnInsertModule.Text = "Add Module";
            this.btnInsertModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertModule.UseVisualStyleBackColor = true;
            this.btnInsertModule.Click += new System.EventHandler(this.btnInsertModule_Click);
            // 
            // txtModuleNameINSERTIntoModules
            // 
            this.txtModuleNameINSERTIntoModules.Location = new System.Drawing.Point(129, 33);
            this.txtModuleNameINSERTIntoModules.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtModuleNameINSERTIntoModules.Name = "txtModuleNameINSERTIntoModules";
            this.txtModuleNameINSERTIntoModules.Size = new System.Drawing.Size(289, 23);
            this.txtModuleNameINSERTIntoModules.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Module Name";
            // 
            // LinkModuleToCourseV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 390);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "LinkModuleToCourseV2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Link Module To Course";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LinkModuleToCourseV2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbAvailableModules.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gbAvailableModules;
        private System.Windows.Forms.ListBox lstModuleINSERT;
        private System.Windows.Forms.Button btnShowInsertModuleSection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtModuleNameINSERTIntoModules;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLinkCourseModule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModuleDuration;
        private System.Windows.Forms.Label lblModuleCost;
        private System.Windows.Forms.TextBox txtModuleDuration;
        private System.Windows.Forms.TextBox txtModuleCost;
        private System.Windows.Forms.TextBox txtModuleDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelAddingModule;
        private System.Windows.Forms.Button btnInsertModule;
    }
}