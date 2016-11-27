namespace Impendulo.MessageTemplates.Deployment.AddMessageTemplates
{
    partial class frmAddMessageTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMessageTemplate));
            this.lookupProcessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveMessageTmeplate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnSetItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSetBold = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.dgvMessageAttachments = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorMessageAttachments = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddAtachment = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveAttachemnt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialogForAttachments = new System.Windows.Forms.OpenFileDialog();
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileExtensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lookupProcessBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMessageAttachments)).BeginInit();
            this.bindingNavigatorMessageAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lookupProcessBindingSource
            // 
            this.lookupProcessBindingSource.DataSource = typeof(Impendulo.Data.Models.LookupProcess);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSaveMessageTmeplate);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 364);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(758, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSaveMessageTmeplate
            // 
            this.btnSaveMessageTmeplate.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveMessageTmeplate.Image")));
            this.btnSaveMessageTmeplate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveMessageTmeplate.Location = new System.Drawing.Point(680, 3);
            this.btnSaveMessageTmeplate.Name = "btnSaveMessageTmeplate";
            this.btnSaveMessageTmeplate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMessageTmeplate.TabIndex = 0;
            this.btnSaveMessageTmeplate.Text = "Save";
            this.btnSaveMessageTmeplate.UseVisualStyleBackColor = true;
            this.btnSaveMessageTmeplate.Click += new System.EventHandler(this.btnSaveMessageTmeplate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(599, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Editor";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStripContainer2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(752, 345);
            this.splitContainer2.SplitterDistance = 359;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.txtMessage);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(359, 320);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(359, 345);
            this.toolStripContainer2.TabIndex = 0;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.bindingNavigator2);
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(359, 320);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetItalic,
            this.toolStripSeparator6,
            this.btnSetBold});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(359, 25);
            this.bindingNavigator2.Stretch = true;
            this.bindingNavigator2.TabIndex = 1;
            // 
            // btnSetItalic
            // 
            this.btnSetItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnSetItalic.Image")));
            this.btnSetItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetItalic.Name = "btnSetItalic";
            this.btnSetItalic.Size = new System.Drawing.Size(52, 22);
            this.btnSetItalic.Text = "Italic";
            this.btnSetItalic.Click += new System.EventHandler(this.btnSetItalic_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSetBold
            // 
            this.btnSetBold.Image = ((System.Drawing.Image)(resources.GetObject("btnSetBold.Image")));
            this.btnSetBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetBold.Name = "btnSetBold";
            this.btnSetBold.Size = new System.Drawing.Size(51, 22);
            this.btnSetBold.Text = "Bold";
            this.btnSetBold.Click += new System.EventHandler(this.btnSetBold_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolStripContainer3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 345);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attachments";
            // 
            // toolStripContainer3
            // 
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.Controls.Add(this.dgvMessageAttachments);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(383, 301);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.Size = new System.Drawing.Size(383, 326);
            this.toolStripContainer3.TabIndex = 0;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // toolStripContainer3.TopToolStripPanel
            // 
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.bindingNavigatorMessageAttachments);
            // 
            // dgvMessageAttachments
            // 
            this.dgvMessageAttachments.AllowUserToAddRows = false;
            this.dgvMessageAttachments.AllowUserToDeleteRows = false;
            this.dgvMessageAttachments.AutoGenerateColumns = false;
            this.dgvMessageAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessageAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.fileExtensionDataGridViewTextBoxColumn});
            this.dgvMessageAttachments.DataSource = this.filesBindingSource;
            this.dgvMessageAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessageAttachments.Location = new System.Drawing.Point(0, 0);
            this.dgvMessageAttachments.Name = "dgvMessageAttachments";
            this.dgvMessageAttachments.Size = new System.Drawing.Size(383, 301);
            this.dgvMessageAttachments.TabIndex = 0;
            // 
            // bindingNavigatorMessageAttachments
            // 
            this.bindingNavigatorMessageAttachments.AddNewItem = null;
            this.bindingNavigatorMessageAttachments.BindingSource = this.filesBindingSource;
            this.bindingNavigatorMessageAttachments.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorMessageAttachments.DeleteItem = null;
            this.bindingNavigatorMessageAttachments.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorMessageAttachments.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigatorMessageAttachments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.btnAddAtachment,
            this.btnRemoveAttachemnt,
            this.toolStripSeparator1});
            this.bindingNavigatorMessageAttachments.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorMessageAttachments.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorMessageAttachments.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorMessageAttachments.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorMessageAttachments.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorMessageAttachments.Name = "bindingNavigatorMessageAttachments";
            this.bindingNavigatorMessageAttachments.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorMessageAttachments.Size = new System.Drawing.Size(383, 25);
            this.bindingNavigatorMessageAttachments.Stretch = true;
            this.bindingNavigatorMessageAttachments.TabIndex = 0;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddAtachment
            // 
            this.btnAddAtachment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddAtachment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAtachment.Image")));
            this.btnAddAtachment.Name = "btnAddAtachment";
            this.btnAddAtachment.RightToLeftAutoMirrorImage = true;
            this.btnAddAtachment.Size = new System.Drawing.Size(23, 22);
            this.btnAddAtachment.Text = "Add new";
            this.btnAddAtachment.Click += new System.EventHandler(this.btnAddAtachment_Click);
            // 
            // btnRemoveAttachemnt
            // 
            this.btnRemoveAttachemnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveAttachemnt.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAttachemnt.Image")));
            this.btnRemoveAttachemnt.Name = "btnRemoveAttachemnt";
            this.btnRemoveAttachemnt.RightToLeftAutoMirrorImage = true;
            this.btnRemoveAttachemnt.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveAttachemnt.Text = "Delete";
            this.btnRemoveAttachemnt.Click += new System.EventHandler(this.btnRemoveAttachemnt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // openFileDialogForAttachments
            // 
            this.openFileDialogForAttachments.Filter = "(*.pdf)|*.pdf|(*.txt)|*.txt|(*.docx)|*.docx|All files (*.*)|*.*";
            this.openFileDialogForAttachments.InitialDirectory = "c:\\";
            this.openFileDialogForAttachments.Multiselect = true;
            this.openFileDialogForAttachments.RestoreDirectory = true;
            this.openFileDialogForAttachments.ShowReadOnly = true;
            this.openFileDialogForAttachments.SupportMultiDottedExtensions = true;
            // 
            // filesBindingSource
            // 
            
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "File Name";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.Width = 79;
            // 
            // fileExtensionDataGridViewTextBoxColumn
            // 
            this.fileExtensionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileExtensionDataGridViewTextBoxColumn.DataPropertyName = "FileExtension";
            this.fileExtensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            this.fileExtensionDataGridViewTextBoxColumn.Name = "fileExtensionDataGridViewTextBoxColumn";
            // 
            // frmAddMessageTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddMessageTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Message Template";
            this.Load += new System.EventHandler(this.frmAddMessageTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookupProcessBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.PerformLayout();
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMessageAttachments)).EndInit();
            this.bindingNavigatorMessageAttachments.ResumeLayout(false);
            this.bindingNavigatorMessageAttachments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource lookupProcessBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSaveMessageTmeplate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton btnSetItalic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnSetBold;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.DataGridView dgvMessageAttachments;
        private System.Windows.Forms.BindingNavigator bindingNavigatorMessageAttachments;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton btnAddAtachment;
        private System.Windows.Forms.ToolStripButton btnRemoveAttachemnt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialogForAttachments;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileExtensionDataGridViewTextBoxColumn;
    }
}