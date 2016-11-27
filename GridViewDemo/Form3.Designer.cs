namespace GridViewDemo
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label individualFirstNameLabel;
            System.Windows.Forms.Label individualSecondNameLabel;
            System.Windows.Forms.Label individualLastnameLabel;
            this.enquiryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enquiryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.enquiryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.enquiryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.individualFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.individualSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.individualLastnameTextBox = new System.Windows.Forms.TextBox();
            this.contactDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculumEnquiriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curriculumEnquiriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            individualFirstNameLabel = new System.Windows.Forms.Label();
            individualSecondNameLabel = new System.Windows.Forms.Label();
            individualLastnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingNavigator)).BeginInit();
            this.enquiryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumEnquiriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumEnquiriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // enquiryBindingSource
            // 
            this.enquiryBindingSource.DataSource = typeof(Impendulo.Data.Models.Enquiry);
            // 
            // enquiryBindingNavigator
            // 
            this.enquiryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.enquiryBindingNavigator.BindingSource = this.enquiryBindingSource;
            this.enquiryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.enquiryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.enquiryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.enquiryBindingNavigatorSaveItem});
            this.enquiryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.enquiryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.enquiryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.enquiryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.enquiryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.enquiryBindingNavigator.Name = "enquiryBindingNavigator";
            this.enquiryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.enquiryBindingNavigator.Size = new System.Drawing.Size(1042, 25);
            this.enquiryBindingNavigator.TabIndex = 0;
            this.enquiryBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // enquiryBindingNavigatorSaveItem
            // 
            this.enquiryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enquiryBindingNavigatorSaveItem.Enabled = false;
            this.enquiryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("enquiryBindingNavigatorSaveItem.Image")));
            this.enquiryBindingNavigatorSaveItem.Name = "enquiryBindingNavigatorSaveItem";
            this.enquiryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.enquiryBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // enquiryDataGridView
            // 
            this.enquiryDataGridView.AutoGenerateColumns = false;
            this.enquiryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enquiryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.enquiryDataGridView.DataSource = this.enquiryBindingSource;
            this.enquiryDataGridView.Location = new System.Drawing.Point(90, 57);
            this.enquiryDataGridView.Name = "enquiryDataGridView";
            this.enquiryDataGridView.Size = new System.Drawing.Size(300, 220);
            this.enquiryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EnquiryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EnquiryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EnquiryDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "EnquiryDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // individualsBindingSource
            // 
            this.individualsBindingSource.DataMember = "Individuals";
            this.individualsBindingSource.DataSource = this.enquiryBindingSource;
            // 
            // individualFirstNameLabel
            // 
            individualFirstNameLabel.AutoSize = true;
            individualFirstNameLabel.Location = new System.Drawing.Point(414, 57);
            individualFirstNameLabel.Name = "individualFirstNameLabel";
            individualFirstNameLabel.Size = new System.Drawing.Size(108, 13);
            individualFirstNameLabel.TabIndex = 2;
            individualFirstNameLabel.Text = "Individual First Name:";
            // 
            // individualFirstNameTextBox
            // 
            this.individualFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.individualsBindingSource, "IndividualFirstName", true));
            this.individualFirstNameTextBox.Location = new System.Drawing.Point(528, 54);
            this.individualFirstNameTextBox.Name = "individualFirstNameTextBox";
            this.individualFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.individualFirstNameTextBox.TabIndex = 3;
            // 
            // individualSecondNameLabel
            // 
            individualSecondNameLabel.AutoSize = true;
            individualSecondNameLabel.Location = new System.Drawing.Point(396, 83);
            individualSecondNameLabel.Name = "individualSecondNameLabel";
            individualSecondNameLabel.Size = new System.Drawing.Size(126, 13);
            individualSecondNameLabel.TabIndex = 4;
            individualSecondNameLabel.Text = "Individual Second Name:";
            // 
            // individualSecondNameTextBox
            // 
            this.individualSecondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.individualsBindingSource, "IndividualSecondName", true));
            this.individualSecondNameTextBox.Location = new System.Drawing.Point(528, 80);
            this.individualSecondNameTextBox.Name = "individualSecondNameTextBox";
            this.individualSecondNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.individualSecondNameTextBox.TabIndex = 5;
            // 
            // individualLastnameLabel
            // 
            individualLastnameLabel.AutoSize = true;
            individualLastnameLabel.Location = new System.Drawing.Point(418, 109);
            individualLastnameLabel.Name = "individualLastnameLabel";
            individualLastnameLabel.Size = new System.Drawing.Size(104, 13);
            individualLastnameLabel.TabIndex = 6;
            individualLastnameLabel.Text = "Individual Lastname:";
            // 
            // individualLastnameTextBox
            // 
            this.individualLastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.individualsBindingSource, "IndividualLastname", true));
            this.individualLastnameTextBox.Location = new System.Drawing.Point(528, 106);
            this.individualLastnameTextBox.Name = "individualLastnameTextBox";
            this.individualLastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.individualLastnameTextBox.TabIndex = 7;
            // 
            // contactDetailsBindingSource
            // 
            this.contactDetailsBindingSource.DataMember = "ContactDetails";
            this.contactDetailsBindingSource.DataSource = this.individualsBindingSource;
            // 
            // contactDetailsDataGridView
            // 
            this.contactDetailsDataGridView.AutoGenerateColumns = false;
            this.contactDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.contactDetailsDataGridView.DataSource = this.contactDetailsBindingSource;
            this.contactDetailsDataGridView.Location = new System.Drawing.Point(417, 149);
            this.contactDetailsDataGridView.Name = "contactDetailsDataGridView";
            this.contactDetailsDataGridView.Size = new System.Drawing.Size(300, 128);
            this.contactDetailsDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ContactDetailID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ContactDetailID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ContactDetailValue";
            this.dataGridViewTextBoxColumn4.HeaderText = "ContactDetailValue";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ContactTypeID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ContactTypeID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LookupContactType";
            this.dataGridViewTextBoxColumn6.HeaderText = "LookupContactType";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // curriculumEnquiriesBindingSource
            // 
            this.curriculumEnquiriesBindingSource.DataMember = "CurriculumEnquiries";
            this.curriculumEnquiriesBindingSource.DataSource = this.enquiryBindingSource;
            // 
            // curriculumEnquiriesDataGridView
            // 
            this.curriculumEnquiriesDataGridView.AutoGenerateColumns = false;
            this.curriculumEnquiriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.curriculumEnquiriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn14});
            this.curriculumEnquiriesDataGridView.DataSource = this.curriculumEnquiriesBindingSource;
            this.curriculumEnquiriesDataGridView.Location = new System.Drawing.Point(42, 313);
            this.curriculumEnquiriesDataGridView.Name = "curriculumEnquiriesDataGridView";
            this.curriculumEnquiriesDataGridView.Size = new System.Drawing.Size(1000, 220);
            this.curriculumEnquiriesDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CurriculumEnquiryID";
            this.dataGridViewTextBoxColumn7.HeaderText = "CurriculumEnquiryID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EnquiryID";
            this.dataGridViewTextBoxColumn8.HeaderText = "EnquiryID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CurriculumID";
            this.dataGridViewTextBoxColumn9.HeaderText = "CurriculumID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "EnrollmentQuanity";
            this.dataGridViewTextBoxColumn10.HeaderText = "EnrollmentQuanity";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "EnquiryStatusID";
            this.dataGridViewTextBoxColumn11.HeaderText = "EnquiryStatusID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Enquiry";
            this.dataGridViewTextBoxColumn14.HeaderText = "Enquiry";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 707);
            this.Controls.Add(this.curriculumEnquiriesDataGridView);
            this.Controls.Add(this.contactDetailsDataGridView);
            this.Controls.Add(individualLastnameLabel);
            this.Controls.Add(this.individualLastnameTextBox);
            this.Controls.Add(individualSecondNameLabel);
            this.Controls.Add(this.individualSecondNameTextBox);
            this.Controls.Add(individualFirstNameLabel);
            this.Controls.Add(this.individualFirstNameTextBox);
            this.Controls.Add(this.enquiryDataGridView);
            this.Controls.Add(this.enquiryBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingNavigator)).EndInit();
            this.enquiryBindingNavigator.ResumeLayout(false);
            this.enquiryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumEnquiriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curriculumEnquiriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource enquiryBindingSource;
        private System.Windows.Forms.BindingNavigator enquiryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton enquiryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView enquiryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource individualsBindingSource;
        private System.Windows.Forms.TextBox individualFirstNameTextBox;
        private System.Windows.Forms.TextBox individualSecondNameTextBox;
        private System.Windows.Forms.TextBox individualLastnameTextBox;
        private System.Windows.Forms.BindingSource contactDetailsBindingSource;
        private System.Windows.Forms.DataGridView contactDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource curriculumEnquiriesBindingSource;
        private System.Windows.Forms.DataGridView curriculumEnquiriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}