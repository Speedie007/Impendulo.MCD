namespace Impendulo.Enrollments.Deployment
{
    partial class frmEnrollmentSelectCourseCurriculum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnrollmentSelectCourseCurriculum));
            this.curriculumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelEnrollmentTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbCurriculum = new System.Windows.Forms.GroupBox();
            this.toolStripContainerCurriculum = new System.Windows.Forms.ToolStripContainer();
            this.dgvCurriculum = new System.Windows.Forms.DataGridView();
            this.curriculumNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCurriculumFilterCriteria = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilterTrainingDepartmentCourses = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefreshCourseSearch = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCurriculum = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbCurriculum.SuspendLayout();
            this.toolStripContainerCurriculum.ContentPanel.SuspendLayout();
            this.toolStripContainerCurriculum.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerCurriculum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculum)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCurriculum)).BeginInit();
            this.bindingNavigatorCurriculum.SuspendLayout();
            this.SuspendLayout();
            // 
            // curriculumBindingSource
            // 
            this.curriculumBindingSource.DataSource = typeof(Impendulo.Data.Models.Curriculum);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerMain.Size = new System.Drawing.Size(354, 402);
            this.splitContainerMain.SplitterDistance = 55;
            this.splitContainerMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.flowLayoutPanelEnrollmentTypes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrollment Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Type";
            // 
            // flowLayoutPanelEnrollmentTypes
            // 
            this.flowLayoutPanelEnrollmentTypes.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelEnrollmentTypes.Location = new System.Drawing.Point(91, 16);
            this.flowLayoutPanelEnrollmentTypes.Name = "flowLayoutPanelEnrollmentTypes";
            this.flowLayoutPanelEnrollmentTypes.Size = new System.Drawing.Size(260, 36);
            this.flowLayoutPanelEnrollmentTypes.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbCurriculum);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAddSelection);
            this.splitContainer1.Size = new System.Drawing.Size(354, 343);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbCurriculum
            // 
            this.gbCurriculum.Controls.Add(this.toolStripContainerCurriculum);
            this.gbCurriculum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCurriculum.Location = new System.Drawing.Point(0, 0);
            this.gbCurriculum.Name = "gbCurriculum";
            this.gbCurriculum.Size = new System.Drawing.Size(354, 297);
            this.gbCurriculum.TabIndex = 1;
            this.gbCurriculum.TabStop = false;
            this.gbCurriculum.Text = "Curriculum";
            // 
            // toolStripContainerCurriculum
            // 
            // 
            // toolStripContainerCurriculum.ContentPanel
            // 
            this.toolStripContainerCurriculum.ContentPanel.Controls.Add(this.dgvCurriculum);
            this.toolStripContainerCurriculum.ContentPanel.Size = new System.Drawing.Size(348, 226);
            this.toolStripContainerCurriculum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerCurriculum.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainerCurriculum.Name = "toolStripContainerCurriculum";
            this.toolStripContainerCurriculum.Size = new System.Drawing.Size(348, 278);
            this.toolStripContainerCurriculum.TabIndex = 0;
            this.toolStripContainerCurriculum.Text = "toolStripContainer1";
            // 
            // toolStripContainerCurriculum.TopToolStripPanel
            // 
            this.toolStripContainerCurriculum.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainerCurriculum.TopToolStripPanel.Controls.Add(this.bindingNavigatorCurriculum);
            // 
            // dgvCurriculum
            // 
            this.dgvCurriculum.AllowUserToAddRows = false;
            this.dgvCurriculum.AllowUserToDeleteRows = false;
            this.dgvCurriculum.AutoGenerateColumns = false;
            this.dgvCurriculum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurriculum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.curriculumNameDataGridViewTextBoxColumn});
            this.dgvCurriculum.DataSource = this.curriculumBindingSource;
            this.dgvCurriculum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurriculum.Location = new System.Drawing.Point(0, 0);
            this.dgvCurriculum.Name = "dgvCurriculum";
            this.dgvCurriculum.ReadOnly = true;
            this.dgvCurriculum.RowHeadersWidth = 15;
            this.dgvCurriculum.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCurriculum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurriculum.Size = new System.Drawing.Size(348, 226);
            this.dgvCurriculum.TabIndex = 0;
            this.dgvCurriculum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurriculum_CellClick);
            this.dgvCurriculum.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCurriculum_DataBindingComplete);
            // 
            // curriculumNameDataGridViewTextBoxColumn
            // 
            this.curriculumNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.curriculumNameDataGridViewTextBoxColumn.DataPropertyName = "CurriculumName";
            this.curriculumNameDataGridViewTextBoxColumn.HeaderText = "Curriculum";
            this.curriculumNameDataGridViewTextBoxColumn.Name = "curriculumNameDataGridViewTextBoxColumn";
            this.curriculumNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.txtCurriculumFilterCriteria,
            this.toolStripSeparator2,
            this.btnFilterTrainingDepartmentCourses,
            this.tsbtnRefreshCourseSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(348, 27);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 24);
            this.toolStripLabel1.Text = "Filter";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // txtCurriculumFilterCriteria
            // 
            this.txtCurriculumFilterCriteria.Name = "txtCurriculumFilterCriteria";
            this.txtCurriculumFilterCriteria.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.txtCurriculumFilterCriteria.Size = new System.Drawing.Size(220, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnFilterTrainingDepartmentCourses
            // 
            this.btnFilterTrainingDepartmentCourses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilterTrainingDepartmentCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterTrainingDepartmentCourses.Image")));
            this.btnFilterTrainingDepartmentCourses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterTrainingDepartmentCourses.Name = "btnFilterTrainingDepartmentCourses";
            this.btnFilterTrainingDepartmentCourses.Size = new System.Drawing.Size(24, 24);
            this.btnFilterTrainingDepartmentCourses.Text = "toolStripButton1";
            // 
            // tsbtnRefreshCourseSearch
            // 
            this.tsbtnRefreshCourseSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefreshCourseSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefreshCourseSearch.Image")));
            this.tsbtnRefreshCourseSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefreshCourseSearch.Name = "tsbtnRefreshCourseSearch";
            this.tsbtnRefreshCourseSearch.Size = new System.Drawing.Size(24, 24);
            this.tsbtnRefreshCourseSearch.Text = "toolStripButton2";
            // 
            // bindingNavigatorCurriculum
            // 
            this.bindingNavigatorCurriculum.AddNewItem = null;
            this.bindingNavigatorCurriculum.BindingSource = this.curriculumBindingSource;
            this.bindingNavigatorCurriculum.CanOverflow = false;
            this.bindingNavigatorCurriculum.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCurriculum.DeleteItem = null;
            this.bindingNavigatorCurriculum.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorCurriculum.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigatorCurriculum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorCurriculum.Location = new System.Drawing.Point(0, 27);
            this.bindingNavigatorCurriculum.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCurriculum.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCurriculum.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCurriculum.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCurriculum.Name = "bindingNavigatorCurriculum";
            this.bindingNavigatorCurriculum.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCurriculum.Size = new System.Drawing.Size(348, 25);
            this.bindingNavigatorCurriculum.Stretch = true;
            this.bindingNavigatorCurriculum.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddSelection
            // 
            this.btnAddSelection.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddSelection.Location = new System.Drawing.Point(214, 0);
            this.btnAddSelection.Name = "btnAddSelection";
            this.btnAddSelection.Size = new System.Drawing.Size(140, 42);
            this.btnAddSelection.TabIndex = 0;
            this.btnAddSelection.Text = "Add Selection";
            this.btnAddSelection.UseVisualStyleBackColor = true;
            this.btnAddSelection.Click += new System.EventHandler(this.btnAddSelection_Click);
            // 
            // frmEnrollmentSelectCourseCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 402);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "frmEnrollmentSelectCourseCurriculum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Curriculum";
            this.Load += new System.EventHandler(this.frmEnrollmentSelectCourseCurriculum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.curriculumBindingSource)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbCurriculum.ResumeLayout(false);
            this.toolStripContainerCurriculum.ContentPanel.ResumeLayout(false);
            this.toolStripContainerCurriculum.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerCurriculum.TopToolStripPanel.PerformLayout();
            this.toolStripContainerCurriculum.ResumeLayout(false);
            this.toolStripContainerCurriculum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculum)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCurriculum)).EndInit();
            this.bindingNavigatorCurriculum.ResumeLayout(false);
            this.bindingNavigatorCurriculum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource curriculumBindingSource;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox gbCurriculum;
        private System.Windows.Forms.ToolStripContainer toolStripContainerCurriculum;
        private System.Windows.Forms.DataGridView dgvCurriculum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtCurriculumFilterCriteria;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnFilterTrainingDepartmentCourses;
        private System.Windows.Forms.ToolStripButton tsbtnRefreshCourseSearch;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCurriculum;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEnrollmentTypes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculumNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddSelection;
    }
}