namespace Impendulo.Courses
{
    partial class LinkModuleToCourse
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInsertModule = new System.Windows.Forms.Button();
            this.txtModuleNameINSERTIntoModules = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstModuleINSERT = new System.Windows.Forms.ListBox();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowInsertModuleSection = new System.Windows.Forms.Button();
            this.btnLinkCourseModule = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInsertModule);
            this.groupBox3.Controls.Add(this.txtModuleNameINSERTIntoModules);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 224);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Module If Does Not Listed";
            // 
            // btnInsertModule
            // 
            this.btnInsertModule.Location = new System.Drawing.Point(330, 171);
            this.btnInsertModule.Name = "btnInsertModule";
            this.btnInsertModule.Size = new System.Drawing.Size(128, 41);
            this.btnInsertModule.TabIndex = 4;
            this.btnInsertModule.Text = "Add Module";
            this.btnInsertModule.UseVisualStyleBackColor = true;
            this.btnInsertModule.Click += new System.EventHandler(this.btnInsertModule_Click);
            // 
            // txtModuleNameINSERTIntoModules
            // 
            this.txtModuleNameINSERTIntoModules.Location = new System.Drawing.Point(148, 33);
            this.txtModuleNameINSERTIntoModules.Name = "txtModuleNameINSERTIntoModules";
            this.txtModuleNameINSERTIntoModules.Size = new System.Drawing.Size(310, 22);
            this.txtModuleNameINSERTIntoModules.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Module Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstModuleINSERT);
            this.groupBox1.Controls.Add(this.btnShowInsertModuleSection);
            this.groupBox1.Controls.Add(this.btnLinkCourseModule);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 302);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Available Modules";
            // 
            // lstModuleINSERT
            // 
            this.lstModuleINSERT.DataSource = this.moduleBindingSource;
            this.lstModuleINSERT.DisplayMember = "ModuleName";
            this.lstModuleINSERT.FormattingEnabled = true;
            this.lstModuleINSERT.ItemHeight = 16;
            this.lstModuleINSERT.Location = new System.Drawing.Point(6, 21);
            this.lstModuleINSERT.Name = "lstModuleINSERT";
            this.lstModuleINSERT.Size = new System.Drawing.Size(471, 212);
            this.lstModuleINSERT.TabIndex = 6;
            this.lstModuleINSERT.ValueMember = "ModuleID";
            // 
            // btnShowInsertModuleSection
            // 
            this.btnShowInsertModuleSection.Location = new System.Drawing.Point(6, 248);
            this.btnShowInsertModuleSection.Name = "btnShowInsertModuleSection";
            this.btnShowInsertModuleSection.Size = new System.Drawing.Size(186, 48);
            this.btnShowInsertModuleSection.TabIndex = 5;
            this.btnShowInsertModuleSection.Text = "Add Module";
            this.btnShowInsertModuleSection.UseVisualStyleBackColor = true;
            this.btnShowInsertModuleSection.Click += new System.EventHandler(this.btnShowInsertModuleSection_Click);
            // 
            // btnLinkCourseModule
            // 
            this.btnLinkCourseModule.Location = new System.Drawing.Point(198, 248);
            this.btnLinkCourseModule.Name = "btnLinkCourseModule";
            this.btnLinkCourseModule.Size = new System.Drawing.Size(279, 48);
            this.btnLinkCourseModule.TabIndex = 1;
            this.btnLinkCourseModule.Text = "Link Selected Module";
            this.btnLinkCourseModule.UseVisualStyleBackColor = true;
            this.btnLinkCourseModule.Click += new System.EventHandler(this.btnLinkCourseModule_Click);
            // 
            // LinkModuleToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "LinkModuleToCourse";
            this.Text = "Link Module To Course";
            this.Load += new System.EventHandler(this.LinkModuleToCourse_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInsertModule;
        private System.Windows.Forms.TextBox txtModuleNameINSERTIntoModules;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstModuleINSERT;
        private System.Windows.Forms.Button btnShowInsertModuleSection;
        private System.Windows.Forms.Button btnLinkCourseModule;
        private System.Windows.Forms.BindingSource moduleBindingSource;
    }
}