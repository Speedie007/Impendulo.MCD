namespace Impendulo.StudentForms.Development
{
    partial class frmStudentSearchForStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentSearchForStudent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbSearchForStudent = new System.Windows.Forms.GroupBox();
            this.picbtnAddStudent = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentIdNumber = new System.Windows.Forms.TextBox();
            this.panelStudentSearchResults = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvStudentSearchResults = new System.Windows.Forms.DataGridView();
            this.colSelectStudent = new System.Windows.Forms.DataGridViewLinkColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.MaskedTextBox();
            this.gbSearchForStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnAddStudent)).BeginInit();
            this.panelStudentSearchResults.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchForStudent
            // 
            this.gbSearchForStudent.Controls.Add(this.txtStudentNumber);
            this.gbSearchForStudent.Controls.Add(this.label1);
            this.gbSearchForStudent.Controls.Add(this.picbtnAddStudent);
            this.gbSearchForStudent.Controls.Add(this.btnRefresh);
            this.gbSearchForStudent.Controls.Add(this.btnSearch);
            this.gbSearchForStudent.Controls.Add(this.label3);
            this.gbSearchForStudent.Controls.Add(this.txtLastName);
            this.gbSearchForStudent.Controls.Add(this.label4);
            this.gbSearchForStudent.Controls.Add(this.txtFirstName);
            this.gbSearchForStudent.Controls.Add(this.label2);
            this.gbSearchForStudent.Controls.Add(this.txtStudentIdNumber);
            this.gbSearchForStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchForStudent.Location = new System.Drawing.Point(0, 0);
            this.gbSearchForStudent.Name = "gbSearchForStudent";
            this.gbSearchForStudent.Size = new System.Drawing.Size(802, 137);
            this.gbSearchForStudent.TabIndex = 1;
            this.gbSearchForStudent.TabStop = false;
            this.gbSearchForStudent.Text = "Search Fields";
            // 
            // picbtnAddStudent
            // 
            this.picbtnAddStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbtnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbtnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("picbtnAddStudent.Image")));
            this.picbtnAddStudent.Location = new System.Drawing.Point(558, 27);
            this.picbtnAddStudent.Name = "picbtnAddStudent";
            this.picbtnAddStudent.Size = new System.Drawing.Size(78, 75);
            this.picbtnAddStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbtnAddStudent.TabIndex = 15;
            this.picbtnAddStudent.TabStop = false;
            this.picbtnAddStudent.Visible = false;
            this.picbtnAddStudent.Click += new System.EventHandler(this.picbtnAddStudent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(477, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 78);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(396, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 78);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(151, 105);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(239, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(151, 79);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(239, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student ID Number";
            // 
            // txtStudentIdNumber
            // 
            this.txtStudentIdNumber.Location = new System.Drawing.Point(151, 27);
            this.txtStudentIdNumber.Name = "txtStudentIdNumber";
            this.txtStudentIdNumber.Size = new System.Drawing.Size(239, 20);
            this.txtStudentIdNumber.TabIndex = 3;
            // 
            // panelStudentSearchResults
            // 
            this.panelStudentSearchResults.Controls.Add(this.toolStripContainer1);
            this.panelStudentSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudentSearchResults.Location = new System.Drawing.Point(0, 137);
            this.panelStudentSearchResults.Name = "panelStudentSearchResults";
            this.panelStudentSearchResults.Size = new System.Drawing.Size(802, 408);
            this.panelStudentSearchResults.TabIndex = 12;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvStudentSearchResults);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(802, 381);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(802, 408);
            this.toolStripContainer1.TabIndex = 11;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            // 
            // dgvStudentSearchResults
            // 
            this.dgvStudentSearchResults.AllowUserToAddRows = false;
            this.dgvStudentSearchResults.AllowUserToDeleteRows = false;
            this.dgvStudentSearchResults.AutoGenerateColumns = false;
            this.dgvStudentSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelectStudent,
            this.studentIDDataGridViewTextBoxColumn,
            this.StudentIDNumber,
            this.colStudentFirstName,
            this.colStudentLastName});
            this.dgvStudentSearchResults.DataSource = this.studentBindingSource;
            this.dgvStudentSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentSearchResults.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentSearchResults.Name = "dgvStudentSearchResults";
            this.dgvStudentSearchResults.ReadOnly = true;
            this.dgvStudentSearchResults.RowTemplate.Height = 24;
            this.dgvStudentSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentSearchResults.Size = new System.Drawing.Size(802, 381);
            this.dgvStudentSearchResults.TabIndex = 0;
            this.dgvStudentSearchResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentSearchResults_CellContentClick);
            this.dgvStudentSearchResults.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStudentSearchResults_DataBindingComplete);
            // 
            // colSelectStudent
            // 
            this.colSelectStudent.ActiveLinkColor = System.Drawing.Color.Black;
            this.colSelectStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.colSelectStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSelectStudent.HeaderText = "Select";
            this.colSelectStudent.LinkColor = System.Drawing.Color.Black;
            this.colSelectStudent.Name = "colSelectStudent";
            this.colSelectStudent.ReadOnly = true;
            this.colSelectStudent.Text = "Select";
            this.colSelectStudent.TrackVisitedState = false;
            this.colSelectStudent.UseColumnTextForLinkValue = true;
            this.colSelectStudent.VisitedLinkColor = System.Drawing.Color.Black;
            this.colSelectStudent.Width = 43;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student Number";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 115;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 115;
            // 
            // StudentIDNumber
            // 
            this.StudentIDNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StudentIDNumber.DataPropertyName = "StudentIDNumber";
            this.StudentIDNumber.HeaderText = "ID Number";
            this.StudentIDNumber.MinimumWidth = 95;
            this.StudentIDNumber.Name = "StudentIDNumber";
            this.StudentIDNumber.ReadOnly = true;
            this.StudentIDNumber.Width = 95;
            // 
            // colStudentFirstName
            // 
            this.colStudentFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStudentFirstName.HeaderText = "First Name";
            this.colStudentFirstName.Name = "colStudentFirstName";
            this.colStudentFirstName.ReadOnly = true;
            this.colStudentFirstName.Width = 82;
            // 
            // colStudentLastName
            // 
            this.colStudentLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStudentLastName.HeaderText = "Last Name";
            this.colStudentLastName.Name = "colStudentLastName";
            this.colStudentLastName.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Impendulo.Data.Models.Student);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.studentBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(802, 27);
            this.bindingNavigator1.Stretch = true;
            this.bindingNavigator1.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Student Number";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(151, 53);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(239, 20);
            this.txtStudentNumber.TabIndex = 18;
            // 
            // frmStudentSearchForStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(802, 545);
            this.Controls.Add(this.panelStudentSearchResults);
            this.Controls.Add(this.gbSearchForStudent);
            this.DoubleBuffered = true;
            this.Name = "frmStudentSearchForStudent";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search For Selected Student";
            this.Load += new System.EventHandler(this.frmStudentSearchForStudent_Load);
            this.gbSearchForStudent.ResumeLayout(false);
            this.gbSearchForStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnAddStudent)).EndInit();
            this.panelStudentSearchResults.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchForStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentIdNumber;
        private System.Windows.Forms.Panel panelStudentSearchResults;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dgvStudentSearchResults;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewLinkColumn colSelectStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentLastName;
        private System.Windows.Forms.PictureBox picbtnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtStudentNumber;
    }
}