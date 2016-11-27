namespace Impendulo.StudentForms.Development
{
    partial class frmAddUpdateStudent
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
            System.Windows.Forms.Label addressAreaCodeLabel;
            System.Windows.Forms.Label addressSuburbLabel;
            System.Windows.Forms.Label addressTownLabel;
            System.Windows.Forms.Label addressLineTwoLabel;
            System.Windows.Forms.Label addressLineOneLabel;
            System.Windows.Forms.Label lookupAddressTypeLabel;
            System.Windows.Forms.Label lookupCountryLabel;
            System.Windows.Forms.Label lookupProvinceLabel;
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label label36;
            System.Windows.Forms.Label qualificationLevelIDLabel;
            System.Windows.Forms.Label martialStatusIDLabel;
            System.Windows.Forms.Label genderIDLabel;
            System.Windows.Forms.Label ethnicityIDLabel;
            System.Windows.Forms.Label individualSecondNameLabel;
            System.Windows.Forms.Label individualLastnameLabel;
            System.Windows.Forms.Label individualIDNumberLabel;
            System.Windows.Forms.Label individualFirstNameLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label companySARSLevyRegistrationNumberLabel;
            System.Windows.Forms.Label companySETANumberLabel;
            System.Windows.Forms.Label companySicCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateStudent));
            this.label43 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MainflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gbStudentCompany = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companySicCodeTextBox = new System.Windows.Forms.TextBox();
            this.companySARSLevyRegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.companySETANumberTextBox = new System.Windows.Forms.TextBox();
            this.btnReviewCompanyDetails = new System.Windows.Forms.Button();
            this.btnSearchForCompany = new System.Windows.Forms.Button();
            this.gbStudentNextOfKin = new System.Windows.Forms.GroupBox();
            this.gbStudnetNextOfKin = new System.Windows.Forms.GroupBox();
            this.toolStripContainerStudentNextOfKin = new System.Windows.Forms.ToolStripContainer();
            this.dgvStudentNextOfKin = new System.Windows.Forms.DataGridView();
            this.BindingNavigatorStudnetNextOfKin = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.gbStudentAddressDetails = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbSutdentAddressAddEdit = new System.Windows.Forms.GroupBox();
            this.btnStudentAddressAddUpdate = new System.Windows.Forms.Button();
            this.imageListStudentRegisteration = new System.Windows.Forms.ImageList(this.components);
            this.btnStudentAddressCancelAddUpdate = new System.Windows.Forms.Button();
            this.cboStudentAddressProvince = new System.Windows.Forms.ComboBox();
            this.BindingSourceStudentAddressProvinces = new System.Windows.Forms.BindingSource(this.components);
            this.cboStudentAddressCountry = new System.Windows.Forms.ComboBox();
            this.BindingSourceStudentAddressCountry = new System.Windows.Forms.BindingSource(this.components);
            this.cboStudentAddressAddressType = new System.Windows.Forms.ComboBox();
            this.BindingSourceStudentAddressAddressType = new System.Windows.Forms.BindingSource(this.components);
            this.txtStudentAddressLineOne = new System.Windows.Forms.TextBox();
            this.txtStudentAddressLineTwo = new System.Windows.Forms.TextBox();
            this.txtStudentAddressTown = new System.Windows.Forms.TextBox();
            this.txtStudentAddressSuburb = new System.Windows.Forms.TextBox();
            this.txtStudentAddressAreaCode = new System.Windows.Forms.TextBox();
            this.chkStudnetAddressIsDefault = new System.Windows.Forms.CheckBox();
            this.ToolStripContainerStudentAddresses = new System.Windows.Forms.ToolStripContainer();
            this.dgvStudentAddresses = new System.Windows.Forms.DataGridView();
            this.AddressType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIsDefaultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addressLineOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLineTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressTownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressSuburbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressAreaCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressModifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSourceStudentAddresses = new System.Windows.Forms.BindingSource(this.components);
            this.BindingNavigatorStudentAddresses = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStudentAddress = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveStudentAddress = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gbAddStudentContactDetailRadioButtons = new System.Windows.Forms.GroupBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbAddStudentContactInfo = new System.Windows.Forms.GroupBox();
            this.btnCancelAddStudnetContactInfo = new System.Windows.Forms.Button();
            this.btnAddStudnetContactInfo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblAddControlType = new System.Windows.Forms.Label();
            this.txtStudentContactTypeAddEmailAddress = new System.Windows.Forms.TextBox();
            this.txtStudentContactTypeAddContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanelContactTypeOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.gbUpdateStudentContactInfo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtStudentContactTypeUpdateEmailAddress = new System.Windows.Forms.TextBox();
            this.txtStudentContactTypeUpdateNumberField = new System.Windows.Forms.MaskedTextBox();
            this.btnStudentContactInfoUpdateDetail = new System.Windows.Forms.Button();
            this.toolStripContainerStudentContacts = new System.Windows.Forms.ToolStripContainer();
            this.dgvStudentContactInfo = new System.Windows.Forms.DataGridView();
            this.ContactType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDetailValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSourceStudentContactDetails = new System.Windows.Forms.BindingSource(this.components);
            this.BindingNavigatorStudentContactInfo = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStudentContactInfo = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveStudentClientInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gbStudentDisability = new System.Windows.Forms.GroupBox();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelAddingStudentDisablity = new System.Windows.Forms.Button();
            this.btnAddUpdateStudentDisablity = new System.Windows.Forms.Button();
            this.txtStudentDisablityNotes = new System.Windows.Forms.TextBox();
            this.gbDisablitiyOptions = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelDisablitiyCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripContainerStudentDisablity = new System.Windows.Forms.ToolStripContainer();
            this.dgvStudentDisablity = new System.Windows.Forms.DataGridView();
            this.AssignnedDisablity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDisabilityNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSourceStudentDisablity = new System.Windows.Forms.BindingSource(this.components);
            this.BindingNavigatorStudentDisablity = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStudentDisablity = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveStudentDisablity = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gbStudentDetails = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddUpdateStudent = new System.Windows.Forms.Button();
            this.cbolookupTitle = new System.Windows.Forms.ComboBox();
            this.cboLookupQualificationLevel = new System.Windows.Forms.ComboBox();
            this.cboLookupMartialStatus = new System.Windows.Forms.ComboBox();
            this.cboLookupGender = new System.Windows.Forms.ComboBox();
            this.cboLookupEthnicity = new System.Windows.Forms.ComboBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentSecondName = new System.Windows.Forms.TextBox();
            this.txtStudentIDNumber = new System.Windows.Forms.TextBox();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNextSection = new System.Windows.Forms.Button();
            this.btnPreviousSection = new System.Windows.Forms.Button();
            this.BindingSourceStudentContactInfoContactType = new System.Windows.Forms.BindingSource(this.components);
            addressAreaCodeLabel = new System.Windows.Forms.Label();
            addressSuburbLabel = new System.Windows.Forms.Label();
            addressTownLabel = new System.Windows.Forms.Label();
            addressLineTwoLabel = new System.Windows.Forms.Label();
            addressLineOneLabel = new System.Windows.Forms.Label();
            lookupAddressTypeLabel = new System.Windows.Forms.Label();
            lookupCountryLabel = new System.Windows.Forms.Label();
            lookupProvinceLabel = new System.Windows.Forms.Label();
            studentIDLabel = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            qualificationLevelIDLabel = new System.Windows.Forms.Label();
            martialStatusIDLabel = new System.Windows.Forms.Label();
            genderIDLabel = new System.Windows.Forms.Label();
            ethnicityIDLabel = new System.Windows.Forms.Label();
            individualSecondNameLabel = new System.Windows.Forms.Label();
            individualLastnameLabel = new System.Windows.Forms.Label();
            individualIDNumberLabel = new System.Windows.Forms.Label();
            individualFirstNameLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            companySARSLevyRegistrationNumberLabel = new System.Windows.Forms.Label();
            companySETANumberLabel = new System.Windows.Forms.Label();
            companySicCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MainflowLayoutPanel.SuspendLayout();
            this.gbStudentCompany.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.gbStudentNextOfKin.SuspendLayout();
            this.toolStripContainerStudentNextOfKin.ContentPanel.SuspendLayout();
            this.toolStripContainerStudentNextOfKin.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerStudentNextOfKin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentNextOfKin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorStudnetNextOfKin)).BeginInit();
            this.BindingNavigatorStudnetNextOfKin.SuspendLayout();
            this.gbStudentAddressDetails.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbSutdentAddressAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentAddressProvinces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentAddressCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentAddressAddressType)).BeginInit();
            this.ToolStripContainerStudentAddresses.ContentPanel.SuspendLayout();
            this.ToolStripContainerStudentAddresses.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainerStudentAddresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorStudentAddresses)).BeginInit();
            this.BindingNavigatorStudentAddresses.SuspendLayout();
            this.gbAddStudentContactDetailRadioButtons.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbAddStudentContactInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbUpdateStudentContactInfo.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.toolStripContainerStudentContacts.ContentPanel.SuspendLayout();
            this.toolStripContainerStudentContacts.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerStudentContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentContactInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentContactDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorStudentContactInfo)).BeginInit();
            this.BindingNavigatorStudentContactInfo.SuspendLayout();
            this.gbStudentDisability.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDisablitiyOptions.SuspendLayout();
            this.toolStripContainerStudentDisablity.ContentPanel.SuspendLayout();
            this.toolStripContainerStudentDisablity.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerStudentDisablity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDisablity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentDisablity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorStudentDisablity)).BeginInit();
            this.BindingNavigatorStudentDisablity.SuspendLayout();
            this.gbStudentDetails.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentContactInfoContactType)).BeginInit();
            this.SuspendLayout();
            // 
            // addressAreaCodeLabel
            // 
            addressAreaCodeLabel.AutoSize = true;
            addressAreaCodeLabel.Location = new System.Drawing.Point(20, 223);
            addressAreaCodeLabel.Name = "addressAreaCodeLabel";
            addressAreaCodeLabel.Size = new System.Drawing.Size(68, 14);
            addressAreaCodeLabel.TabIndex = 36;
            addressAreaCodeLabel.Text = "Area Code:";
            // 
            // addressSuburbLabel
            // 
            addressSuburbLabel.AutoSize = true;
            addressSuburbLabel.Location = new System.Drawing.Point(20, 198);
            addressSuburbLabel.Name = "addressSuburbLabel";
            addressSuburbLabel.Size = new System.Drawing.Size(50, 14);
            addressSuburbLabel.TabIndex = 34;
            addressSuburbLabel.Text = "Suburb:";
            // 
            // addressTownLabel
            // 
            addressTownLabel.AutoSize = true;
            addressTownLabel.Location = new System.Drawing.Point(20, 173);
            addressTownLabel.Name = "addressTownLabel";
            addressTownLabel.Size = new System.Drawing.Size(43, 14);
            addressTownLabel.TabIndex = 32;
            addressTownLabel.Text = "Town:";
            // 
            // addressLineTwoLabel
            // 
            addressLineTwoLabel.AutoSize = true;
            addressLineTwoLabel.Location = new System.Drawing.Point(20, 113);
            addressLineTwoLabel.Name = "addressLineTwoLabel";
            addressLineTwoLabel.Size = new System.Drawing.Size(109, 14);
            addressLineTwoLabel.TabIndex = 30;
            addressLineTwoLabel.Text = "Address Line Two:";
            // 
            // addressLineOneLabel
            // 
            addressLineOneLabel.AutoSize = true;
            addressLineOneLabel.Location = new System.Drawing.Point(20, 84);
            addressLineOneLabel.Name = "addressLineOneLabel";
            addressLineOneLabel.Size = new System.Drawing.Size(107, 14);
            addressLineOneLabel.TabIndex = 28;
            addressLineOneLabel.Text = "Address Line One:";
            // 
            // lookupAddressTypeLabel
            // 
            lookupAddressTypeLabel.AutoSize = true;
            lookupAddressTypeLabel.Location = new System.Drawing.Point(21, 30);
            lookupAddressTypeLabel.Name = "lookupAddressTypeLabel";
            lookupAddressTypeLabel.Size = new System.Drawing.Size(86, 14);
            lookupAddressTypeLabel.TabIndex = 41;
            lookupAddressTypeLabel.Text = "Address Type:";
            // 
            // lookupCountryLabel
            // 
            lookupCountryLabel.AutoSize = true;
            lookupCountryLabel.Location = new System.Drawing.Point(20, 256);
            lookupCountryLabel.Name = "lookupCountryLabel";
            lookupCountryLabel.Size = new System.Drawing.Size(54, 14);
            lookupCountryLabel.TabIndex = 42;
            lookupCountryLabel.Text = "Country:";
            // 
            // lookupProvinceLabel
            // 
            lookupProvinceLabel.AutoSize = true;
            lookupProvinceLabel.Location = new System.Drawing.Point(20, 142);
            lookupProvinceLabel.Name = "lookupProvinceLabel";
            lookupProvinceLabel.Size = new System.Drawing.Size(57, 14);
            lookupProvinceLabel.TabIndex = 43;
            lookupProvinceLabel.Text = "Province:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(6, 23);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(99, 14);
            studentIDLabel.TabIndex = 56;
            studentIDLabel.Text = "Student Number";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new System.Drawing.Point(6, 52);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(31, 14);
            label36.TabIndex = 71;
            label36.Text = "Title";
            // 
            // qualificationLevelIDLabel
            // 
            qualificationLevelIDLabel.AutoSize = true;
            qualificationLevelIDLabel.Location = new System.Drawing.Point(4, 276);
            qualificationLevelIDLabel.Name = "qualificationLevelIDLabel";
            qualificationLevelIDLabel.Size = new System.Drawing.Size(124, 14);
            qualificationLevelIDLabel.TabIndex = 55;
            qualificationLevelIDLabel.Text = "Highest Qualuification";
            // 
            // martialStatusIDLabel
            // 
            martialStatusIDLabel.AutoSize = true;
            martialStatusIDLabel.Location = new System.Drawing.Point(4, 248);
            martialStatusIDLabel.Name = "martialStatusIDLabel";
            martialStatusIDLabel.Size = new System.Drawing.Size(82, 14);
            martialStatusIDLabel.TabIndex = 54;
            martialStatusIDLabel.Text = "Maritial Status";
            // 
            // genderIDLabel
            // 
            genderIDLabel.AutoSize = true;
            genderIDLabel.Location = new System.Drawing.Point(6, 220);
            genderIDLabel.Name = "genderIDLabel";
            genderIDLabel.Size = new System.Drawing.Size(47, 14);
            genderIDLabel.TabIndex = 53;
            genderIDLabel.Text = "Gender";
            // 
            // ethnicityIDLabel
            // 
            ethnicityIDLabel.AutoSize = true;
            ethnicityIDLabel.Location = new System.Drawing.Point(4, 192);
            ethnicityIDLabel.Name = "ethnicityIDLabel";
            ethnicityIDLabel.Size = new System.Drawing.Size(54, 14);
            ethnicityIDLabel.TabIndex = 52;
            ethnicityIDLabel.Text = "Ethnicity";
            // 
            // individualSecondNameLabel
            // 
            individualSecondNameLabel.AutoSize = true;
            individualSecondNameLabel.Location = new System.Drawing.Point(4, 108);
            individualSecondNameLabel.Name = "individualSecondNameLabel";
            individualSecondNameLabel.Size = new System.Drawing.Size(83, 14);
            individualSecondNameLabel.TabIndex = 64;
            individualSecondNameLabel.Text = "Second Name";
            // 
            // individualLastnameLabel
            // 
            individualLastnameLabel.AutoSize = true;
            individualLastnameLabel.Location = new System.Drawing.Point(4, 133);
            individualLastnameLabel.Name = "individualLastnameLabel";
            individualLastnameLabel.Size = new System.Drawing.Size(64, 14);
            individualLastnameLabel.TabIndex = 62;
            individualLastnameLabel.Text = "Last Name";
            // 
            // individualIDNumberLabel
            // 
            individualIDNumberLabel.AutoSize = true;
            individualIDNumberLabel.Location = new System.Drawing.Point(6, 164);
            individualIDNumberLabel.Name = "individualIDNumberLabel";
            individualIDNumberLabel.Size = new System.Drawing.Size(66, 14);
            individualIDNumberLabel.TabIndex = 60;
            individualIDNumberLabel.Text = "ID Number";
            // 
            // individualFirstNameLabel
            // 
            individualFirstNameLabel.AutoSize = true;
            individualFirstNameLabel.Location = new System.Drawing.Point(6, 80);
            individualFirstNameLabel.Name = "individualFirstNameLabel";
            individualFirstNameLabel.Size = new System.Drawing.Size(64, 14);
            individualFirstNameLabel.TabIndex = 58;
            individualFirstNameLabel.Text = "First Name";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(6, 23);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(96, 14);
            companyNameLabel.TabIndex = 6;
            companyNameLabel.Text = "Company Name:";
            // 
            // companySARSLevyRegistrationNumberLabel
            // 
            companySARSLevyRegistrationNumberLabel.AutoSize = true;
            companySARSLevyRegistrationNumberLabel.Location = new System.Drawing.Point(6, 51);
            companySARSLevyRegistrationNumberLabel.Name = "companySARSLevyRegistrationNumberLabel";
            companySARSLevyRegistrationNumberLabel.Size = new System.Drawing.Size(234, 14);
            companySARSLevyRegistrationNumberLabel.TabIndex = 8;
            companySARSLevyRegistrationNumberLabel.Text = "Company SARSLevy Registration Number:";
            // 
            // companySETANumberLabel
            // 
            companySETANumberLabel.AutoSize = true;
            companySETANumberLabel.Location = new System.Drawing.Point(6, 79);
            companySETANumberLabel.Name = "companySETANumberLabel";
            companySETANumberLabel.Size = new System.Drawing.Size(138, 14);
            companySETANumberLabel.TabIndex = 10;
            companySETANumberLabel.Text = "Company SETANumber:";
            // 
            // companySicCodeLabel
            // 
            companySicCodeLabel.AutoSize = true;
            companySicCodeLabel.Location = new System.Drawing.Point(6, 107);
            companySicCodeLabel.Name = "companySicCodeLabel";
            companySicCodeLabel.Size = new System.Drawing.Size(112, 14);
            companySicCodeLabel.TabIndex = 12;
            companySicCodeLabel.Text = "Company Sic Code:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(10, 7);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(164, 23);
            this.label43.TabIndex = 6;
            this.label43.Text = "Process Student";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1195, 722);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.NavigationPanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 722);
            this.panel2.TabIndex = 0;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NavigationPanel.Controls.Add(this.panel5);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigationPanel.Location = new System.Drawing.Point(0, 42);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(196, 676);
            this.NavigationPanel.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.label42);
            this.panel5.Controls.Add(this.label40);
            this.panel5.Controls.Add(this.label39);
            this.panel5.Controls.Add(this.label38);
            this.panel5.Controls.Add(this.label41);
            this.panel5.Controls.Add(this.label37);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 672);
            this.panel5.TabIndex = 0;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label42.Location = new System.Drawing.Point(23, 201);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(81, 17);
            this.label42.TabIndex = 20;
            this.label42.Tag = "5";
            this.label42.Text = " Next Of Kin";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label40.Location = new System.Drawing.Point(23, 163);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(68, 17);
            this.label40.TabIndex = 19;
            this.label40.Tag = "4";
            this.label40.Text = "Company";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label39.Location = new System.Drawing.Point(23, 124);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(67, 17);
            this.label39.TabIndex = 18;
            this.label39.Tag = "3";
            this.label39.Text = "Disabilities";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label38.Location = new System.Drawing.Point(23, 90);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(85, 17);
            this.label38.TabIndex = 17;
            this.label38.Tag = "2";
            this.label38.Text = "Contact Info";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label41.Location = new System.Drawing.Point(23, 52);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 17);
            this.label41.TabIndex = 16;
            this.label41.Tag = "1";
            this.label41.Text = "Addresses";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Tahoma", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(23, 18);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(73, 19);
            this.label37.TabIndex = 15;
            this.label37.Tag = "0";
            this.label37.Text = "Student";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label43);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 42);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.MainflowLayoutPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 649);
            this.panel3.TabIndex = 1;
            // 
            // MainflowLayoutPanel
            // 
            this.MainflowLayoutPanel.AutoScroll = true;
            this.MainflowLayoutPanel.Controls.Add(this.gbStudentCompany);
            this.MainflowLayoutPanel.Controls.Add(this.gbStudentNextOfKin);
            this.MainflowLayoutPanel.Controls.Add(this.gbStudentAddressDetails);
            this.MainflowLayoutPanel.Controls.Add(this.gbAddStudentContactDetailRadioButtons);
            this.MainflowLayoutPanel.Controls.Add(this.gbStudentDisability);
            this.MainflowLayoutPanel.Controls.Add(this.gbStudentDetails);
            this.MainflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainflowLayoutPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MainflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainflowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainflowLayoutPanel.Name = "MainflowLayoutPanel";
            this.MainflowLayoutPanel.Size = new System.Drawing.Size(987, 645);
            this.MainflowLayoutPanel.TabIndex = 2;
            // 
            // gbStudentCompany
            // 
            this.gbStudentCompany.Controls.Add(this.groupBox1);
            this.gbStudentCompany.Controls.Add(this.btnReviewCompanyDetails);
            this.gbStudentCompany.Controls.Add(this.btnSearchForCompany);
            this.gbStudentCompany.Location = new System.Drawing.Point(0, 0);
            this.gbStudentCompany.Margin = new System.Windows.Forms.Padding(0);
            this.gbStudentCompany.Name = "gbStudentCompany";
            this.gbStudentCompany.Padding = new System.Windows.Forms.Padding(0);
            this.gbStudentCompany.Size = new System.Drawing.Size(330, 185);
            this.gbStudentCompany.TabIndex = 4;
            this.gbStudentCompany.TabStop = false;
            this.gbStudentCompany.Tag = "4";
            this.gbStudentCompany.Text = "Student Company";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(companyNameLabel);
            this.groupBox1.Controls.Add(this.companyNameTextBox);
            this.groupBox1.Controls.Add(this.companySicCodeTextBox);
            this.groupBox1.Controls.Add(companySARSLevyRegistrationNumberLabel);
            this.groupBox1.Controls.Add(companySicCodeLabel);
            this.groupBox1.Controls.Add(this.companySARSLevyRegistrationNumberTextBox);
            this.groupBox1.Controls.Add(this.companySETANumberTextBox);
            this.groupBox1.Controls.Add(companySETANumberLabel);
            this.groupBox1.Location = new System.Drawing.Point(161, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 206);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Details";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(246, 20);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(413, 22);
            this.companyNameTextBox.TabIndex = 7;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Impendulo.Data.Models.Company);
            // 
            // companySicCodeTextBox
            // 
            this.companySicCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanySicCode", true));
            this.companySicCodeTextBox.Location = new System.Drawing.Point(246, 104);
            this.companySicCodeTextBox.Name = "companySicCodeTextBox";
            this.companySicCodeTextBox.Size = new System.Drawing.Size(187, 22);
            this.companySicCodeTextBox.TabIndex = 13;
            // 
            // companySARSLevyRegistrationNumberTextBox
            // 
            this.companySARSLevyRegistrationNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanySARSLevyRegistrationNumber", true));
            this.companySARSLevyRegistrationNumberTextBox.Location = new System.Drawing.Point(246, 48);
            this.companySARSLevyRegistrationNumberTextBox.Name = "companySARSLevyRegistrationNumberTextBox";
            this.companySARSLevyRegistrationNumberTextBox.Size = new System.Drawing.Size(187, 22);
            this.companySARSLevyRegistrationNumberTextBox.TabIndex = 9;
            // 
            // companySETANumberTextBox
            // 
            this.companySETANumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanySETANumber", true));
            this.companySETANumberTextBox.Location = new System.Drawing.Point(246, 76);
            this.companySETANumberTextBox.Name = "companySETANumberTextBox";
            this.companySETANumberTextBox.Size = new System.Drawing.Size(187, 22);
            this.companySETANumberTextBox.TabIndex = 11;
            // 
            // btnReviewCompanyDetails
            // 
            this.btnReviewCompanyDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnReviewCompanyDetails.Image")));
            this.btnReviewCompanyDetails.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReviewCompanyDetails.Location = new System.Drawing.Point(19, 119);
            this.btnReviewCompanyDetails.Name = "btnReviewCompanyDetails";
            this.btnReviewCompanyDetails.Size = new System.Drawing.Size(135, 105);
            this.btnReviewCompanyDetails.TabIndex = 3;
            this.btnReviewCompanyDetails.Text = "Review Company Deatils";
            this.btnReviewCompanyDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReviewCompanyDetails.UseVisualStyleBackColor = true;
            this.btnReviewCompanyDetails.Click += new System.EventHandler(this.btnReviewCompanyDetails_Click);
            // 
            // btnSearchForCompany
            // 
            this.btnSearchForCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchForCompany.Image")));
            this.btnSearchForCompany.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchForCompany.Location = new System.Drawing.Point(19, 19);
            this.btnSearchForCompany.Name = "btnSearchForCompany";
            this.btnSearchForCompany.Size = new System.Drawing.Size(135, 94);
            this.btnSearchForCompany.TabIndex = 0;
            this.btnSearchForCompany.Text = "Company Search";
            this.btnSearchForCompany.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchForCompany.UseVisualStyleBackColor = true;
            this.btnSearchForCompany.Click += new System.EventHandler(this.btnSearchForCompany_Click);
            // 
            // gbStudentNextOfKin
            // 
            this.gbStudentNextOfKin.Controls.Add(this.gbStudnetNextOfKin);
            this.gbStudentNextOfKin.Controls.Add(this.toolStripContainerStudentNextOfKin);
            this.gbStudentNextOfKin.Location = new System.Drawing.Point(330, 0);
            this.gbStudentNextOfKin.Margin = new System.Windows.Forms.Padding(0);
            this.gbStudentNextOfKin.Name = "gbStudentNextOfKin";
            this.gbStudentNextOfKin.Padding = new System.Windows.Forms.Padding(0);
            this.gbStudentNextOfKin.Size = new System.Drawing.Size(154, 83);
            this.gbStudentNextOfKin.TabIndex = 5;
            this.gbStudentNextOfKin.TabStop = false;
            this.gbStudentNextOfKin.Tag = "5";
            this.gbStudentNextOfKin.Text = "Student Next Of Kin";
            // 
            // gbStudnetNextOfKin
            // 
            this.gbStudnetNextOfKin.Location = new System.Drawing.Point(4, 207);
            this.gbStudnetNextOfKin.Name = "gbStudnetNextOfKin";
            this.gbStudnetNextOfKin.Size = new System.Drawing.Size(486, 266);
            this.gbStudnetNextOfKin.TabIndex = 1;
            this.gbStudnetNextOfKin.TabStop = false;
            this.gbStudnetNextOfKin.Text = "Next Of Kin Details";
            // 
            // toolStripContainerStudentNextOfKin
            // 
            // 
            // toolStripContainerStudentNextOfKin.ContentPanel
            // 
            this.toolStripContainerStudentNextOfKin.ContentPanel.Controls.Add(this.dgvStudentNextOfKin);
            this.toolStripContainerStudentNextOfKin.ContentPanel.Size = new System.Drawing.Size(154, 148);
            this.toolStripContainerStudentNextOfKin.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainerStudentNextOfKin.Location = new System.Drawing.Point(0, 15);
            this.toolStripContainerStudentNextOfKin.Name = "toolStripContainerStudentNextOfKin";
            this.toolStripContainerStudentNextOfKin.Size = new System.Drawing.Size(154, 175);
            this.toolStripContainerStudentNextOfKin.TabIndex = 0;
            this.toolStripContainerStudentNextOfKin.Text = "toolStripContainer1";
            // 
            // toolStripContainerStudentNextOfKin.TopToolStripPanel
            // 
            this.toolStripContainerStudentNextOfKin.TopToolStripPanel.Controls.Add(this.BindingNavigatorStudnetNextOfKin);
            // 
            // dgvStudentNextOfKin
            // 
            this.dgvStudentNextOfKin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentNextOfKin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentNextOfKin.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentNextOfKin.Name = "dgvStudentNextOfKin";
            this.dgvStudentNextOfKin.RowTemplate.Height = 24;
            this.dgvStudentNextOfKin.Size = new System.Drawing.Size(154, 148);
            this.dgvStudentNextOfKin.TabIndex = 0;
            // 
            // BindingNavigatorStudnetNextOfKin
            // 
            this.BindingNavigatorStudnetNextOfKin.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.BindingNavigatorStudnetNextOfKin.CountItem = this.bindingNavigatorCountItem4;
            this.BindingNavigatorStudnetNextOfKin.DeleteItem = this.bindingNavigatorDeleteItem4;
            this.BindingNavigatorStudnetNextOfKin.Dock = System.Windows.Forms.DockStyle.None;
            this.BindingNavigatorStudnetNextOfKin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigatorStudnetNextOfKin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem4});
            this.BindingNavigatorStudnetNextOfKin.Location = new System.Drawing.Point(3, 0);
            this.BindingNavigatorStudnetNextOfKin.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.BindingNavigatorStudnetNextOfKin.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.BindingNavigatorStudnetNextOfKin.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.BindingNavigatorStudnetNextOfKin.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.BindingNavigatorStudnetNextOfKin.Name = "BindingNavigatorStudnetNextOfKin";
            this.BindingNavigatorStudnetNextOfKin.PositionItem = this.bindingNavigatorPositionItem4;
            this.BindingNavigatorStudnetNextOfKin.Size = new System.Drawing.Size(151, 27);
            this.BindingNavigatorStudnetNextOfKin.TabIndex = 0;
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem3.Text = "Add new";
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem4.Text = "of {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem4
            // 
            this.bindingNavigatorDeleteItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem4.Image")));
            this.bindingNavigatorDeleteItem4.Name = "bindingNavigatorDeleteItem4";
            this.bindingNavigatorDeleteItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem4.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem4.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem4.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem4.Text = "Move previous";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "Position";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem4.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem4.Text = "Move last";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 27);
            // 
            // gbStudentAddressDetails
            // 
            this.gbStudentAddressDetails.Controls.Add(this.tabControl1);
            this.gbStudentAddressDetails.Controls.Add(this.ToolStripContainerStudentAddresses);
            this.gbStudentAddressDetails.Location = new System.Drawing.Point(484, 0);
            this.gbStudentAddressDetails.Margin = new System.Windows.Forms.Padding(0);
            this.gbStudentAddressDetails.Name = "gbStudentAddressDetails";
            this.gbStudentAddressDetails.Padding = new System.Windows.Forms.Padding(0);
            this.gbStudentAddressDetails.Size = new System.Drawing.Size(213, 102);
            this.gbStudentAddressDetails.TabIndex = 1;
            this.gbStudentAddressDetails.TabStop = false;
            this.gbStudentAddressDetails.Tag = "1";
            this.gbStudentAddressDetails.Text = "Student Address Details";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 171);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(213, 0);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbSutdentAddressAddEdit);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(205, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add/Edit Adress";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbSutdentAddressAddEdit
            // 
            this.gbSutdentAddressAddEdit.Controls.Add(this.btnStudentAddressAddUpdate);
            this.gbSutdentAddressAddEdit.Controls.Add(this.btnStudentAddressCancelAddUpdate);
            this.gbSutdentAddressAddEdit.Controls.Add(lookupProvinceLabel);
            this.gbSutdentAddressAddEdit.Controls.Add(this.cboStudentAddressProvince);
            this.gbSutdentAddressAddEdit.Controls.Add(lookupCountryLabel);
            this.gbSutdentAddressAddEdit.Controls.Add(this.cboStudentAddressCountry);
            this.gbSutdentAddressAddEdit.Controls.Add(lookupAddressTypeLabel);
            this.gbSutdentAddressAddEdit.Controls.Add(this.cboStudentAddressAddressType);
            this.gbSutdentAddressAddEdit.Controls.Add(addressLineOneLabel);
            this.gbSutdentAddressAddEdit.Controls.Add(this.txtStudentAddressLineOne);
            this.gbSutdentAddressAddEdit.Controls.Add(addressLineTwoLabel);
            this.gbSutdentAddressAddEdit.Controls.Add(this.txtStudentAddressLineTwo);
            this.gbSutdentAddressAddEdit.Controls.Add(addressTownLabel);
            this.gbSutdentAddressAddEdit.Controls.Add(this.txtStudentAddressTown);
            this.gbSutdentAddressAddEdit.Controls.Add(addressSuburbLabel);
            this.gbSutdentAddressAddEdit.Controls.Add(this.txtStudentAddressSuburb);
            this.gbSutdentAddressAddEdit.Controls.Add(addressAreaCodeLabel);
            this.gbSutdentAddressAddEdit.Controls.Add(this.txtStudentAddressAreaCode);
            this.gbSutdentAddressAddEdit.Controls.Add(this.chkStudnetAddressIsDefault);
            this.gbSutdentAddressAddEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSutdentAddressAddEdit.Location = new System.Drawing.Point(3, 3);
            this.gbSutdentAddressAddEdit.Name = "gbSutdentAddressAddEdit";
            this.gbSutdentAddressAddEdit.Size = new System.Drawing.Size(199, 0);
            this.gbSutdentAddressAddEdit.TabIndex = 38;
            this.gbSutdentAddressAddEdit.TabStop = false;
            this.gbSutdentAddressAddEdit.Text = "Edit Student Address";
            // 
            // btnStudentAddressAddUpdate
            // 
            this.btnStudentAddressAddUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentAddressAddUpdate.ImageList = this.imageListStudentRegisteration;
            this.btnStudentAddressAddUpdate.Location = new System.Drawing.Point(445, 27);
            this.btnStudentAddressAddUpdate.Name = "btnStudentAddressAddUpdate";
            this.btnStudentAddressAddUpdate.Size = new System.Drawing.Size(77, 37);
            this.btnStudentAddressAddUpdate.TabIndex = 46;
            this.btnStudentAddressAddUpdate.Text = "Update";
            this.btnStudentAddressAddUpdate.UseVisualStyleBackColor = true;
            this.btnStudentAddressAddUpdate.Click += new System.EventHandler(this.btnStudentAddressAddUpdate_Click);
            // 
            // imageListStudentRegisteration
            // 
            this.imageListStudentRegisteration.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStudentRegisteration.ImageStream")));
            this.imageListStudentRegisteration.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStudentRegisteration.Images.SetKeyName(0, "Documents-icon-32.png");
            this.imageListStudentRegisteration.Images.SetKeyName(1, "Downloads-icon-32.png");
            this.imageListStudentRegisteration.Images.SetKeyName(2, "Favorite-icon-32.png");
            this.imageListStudentRegisteration.Images.SetKeyName(3, "Network-icon-32.png");
            this.imageListStudentRegisteration.Images.SetKeyName(4, "Public-icon-32.png");
            this.imageListStudentRegisteration.Images.SetKeyName(5, "System-icon-32.png");
            this.imageListStudentRegisteration.Images.SetKeyName(6, "User-icon-32.png");
            this.imageListStudentRegisteration.Images.SetKeyName(7, "accept.png");
            this.imageListStudentRegisteration.Images.SetKeyName(8, "add.png");
            this.imageListStudentRegisteration.Images.SetKeyName(9, "add_to_folder.png");
            this.imageListStudentRegisteration.Images.SetKeyName(10, "delete.png");
            this.imageListStudentRegisteration.Images.SetKeyName(11, "delete_folder.png");
            this.imageListStudentRegisteration.Images.SetKeyName(12, "delete_page.png");
            this.imageListStudentRegisteration.Images.SetKeyName(13, "download.png");
            this.imageListStudentRegisteration.Images.SetKeyName(14, "folder_accept.png");
            this.imageListStudentRegisteration.Images.SetKeyName(15, "process.png");
            this.imageListStudentRegisteration.Images.SetKeyName(16, "promotion.png");
            this.imageListStudentRegisteration.Images.SetKeyName(17, "text_page.png");
            this.imageListStudentRegisteration.Images.SetKeyName(18, "user.png");
            this.imageListStudentRegisteration.Images.SetKeyName(19, "users.png");
            this.imageListStudentRegisteration.Images.SetKeyName(20, "warning.png");
            // 
            // btnStudentAddressCancelAddUpdate
            // 
            this.btnStudentAddressCancelAddUpdate.Location = new System.Drawing.Point(364, 27);
            this.btnStudentAddressCancelAddUpdate.Name = "btnStudentAddressCancelAddUpdate";
            this.btnStudentAddressCancelAddUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnStudentAddressCancelAddUpdate.TabIndex = 45;
            this.btnStudentAddressCancelAddUpdate.Text = "Cancel";
            this.btnStudentAddressCancelAddUpdate.UseVisualStyleBackColor = true;
            this.btnStudentAddressCancelAddUpdate.Visible = false;
            this.btnStudentAddressCancelAddUpdate.Click += new System.EventHandler(this.btnStudentAddressCancelAddUpdate_Click);
            // 
            // cboStudentAddressProvince
            // 
            this.cboStudentAddressProvince.DataSource = this.BindingSourceStudentAddressProvinces;
            this.cboStudentAddressProvince.DisplayMember = "Province";
            this.cboStudentAddressProvince.FormattingEnabled = true;
            this.cboStudentAddressProvince.Location = new System.Drawing.Point(138, 139);
            this.cboStudentAddressProvince.Name = "cboStudentAddressProvince";
            this.cboStudentAddressProvince.Size = new System.Drawing.Size(137, 22);
            this.cboStudentAddressProvince.TabIndex = 44;
            this.cboStudentAddressProvince.ValueMember = "ProvinceID";
            // 
            // BindingSourceStudentAddressProvinces
            // 
            this.BindingSourceStudentAddressProvinces.DataSource = typeof(Impendulo.Data.Models.LookupProvince);
            // 
            // cboStudentAddressCountry
            // 
            this.cboStudentAddressCountry.DataSource = this.BindingSourceStudentAddressCountry;
            this.cboStudentAddressCountry.DisplayMember = "CountryName";
            this.cboStudentAddressCountry.FormattingEnabled = true;
            this.cboStudentAddressCountry.Location = new System.Drawing.Point(138, 253);
            this.cboStudentAddressCountry.Name = "cboStudentAddressCountry";
            this.cboStudentAddressCountry.Size = new System.Drawing.Size(200, 22);
            this.cboStudentAddressCountry.TabIndex = 43;
            this.cboStudentAddressCountry.ValueMember = "CountryID";
            // 
            // BindingSourceStudentAddressCountry
            // 
            this.BindingSourceStudentAddressCountry.DataSource = typeof(Impendulo.Data.Models.LookupCountry);
            // 
            // cboStudentAddressAddressType
            // 
            this.cboStudentAddressAddressType.DataSource = this.BindingSourceStudentAddressAddressType;
            this.cboStudentAddressAddressType.DisplayMember = "AddressType";
            this.cboStudentAddressAddressType.FormattingEnabled = true;
            this.cboStudentAddressAddressType.Location = new System.Drawing.Point(139, 27);
            this.cboStudentAddressAddressType.Name = "cboStudentAddressAddressType";
            this.cboStudentAddressAddressType.Size = new System.Drawing.Size(136, 22);
            this.cboStudentAddressAddressType.TabIndex = 42;
            this.cboStudentAddressAddressType.ValueMember = "AddressTypeID";
            // 
            // BindingSourceStudentAddressAddressType
            // 
            this.BindingSourceStudentAddressAddressType.DataSource = typeof(Impendulo.Data.Models.LookupAddressType);
            // 
            // txtStudentAddressLineOne
            // 
            this.txtStudentAddressLineOne.Location = new System.Drawing.Point(138, 81);
            this.txtStudentAddressLineOne.Name = "txtStudentAddressLineOne";
            this.txtStudentAddressLineOne.Size = new System.Drawing.Size(384, 22);
            this.txtStudentAddressLineOne.TabIndex = 29;
            // 
            // txtStudentAddressLineTwo
            // 
            this.txtStudentAddressLineTwo.Location = new System.Drawing.Point(138, 109);
            this.txtStudentAddressLineTwo.Name = "txtStudentAddressLineTwo";
            this.txtStudentAddressLineTwo.Size = new System.Drawing.Size(384, 22);
            this.txtStudentAddressLineTwo.TabIndex = 31;
            // 
            // txtStudentAddressTown
            // 
            this.txtStudentAddressTown.Location = new System.Drawing.Point(138, 167);
            this.txtStudentAddressTown.Name = "txtStudentAddressTown";
            this.txtStudentAddressTown.Size = new System.Drawing.Size(240, 22);
            this.txtStudentAddressTown.TabIndex = 33;
            // 
            // txtStudentAddressSuburb
            // 
            this.txtStudentAddressSuburb.Location = new System.Drawing.Point(138, 195);
            this.txtStudentAddressSuburb.Name = "txtStudentAddressSuburb";
            this.txtStudentAddressSuburb.Size = new System.Drawing.Size(240, 22);
            this.txtStudentAddressSuburb.TabIndex = 35;
            // 
            // txtStudentAddressAreaCode
            // 
            this.txtStudentAddressAreaCode.Location = new System.Drawing.Point(138, 223);
            this.txtStudentAddressAreaCode.Name = "txtStudentAddressAreaCode";
            this.txtStudentAddressAreaCode.Size = new System.Drawing.Size(100, 22);
            this.txtStudentAddressAreaCode.TabIndex = 37;
            // 
            // chkStudnetAddressIsDefault
            // 
            this.chkStudnetAddressIsDefault.Location = new System.Drawing.Point(138, 55);
            this.chkStudnetAddressIsDefault.Name = "chkStudnetAddressIsDefault";
            this.chkStudnetAddressIsDefault.Size = new System.Drawing.Size(200, 24);
            this.chkStudnetAddressIsDefault.TabIndex = 39;
            this.chkStudnetAddressIsDefault.Text = "Is Default Address";
            this.chkStudnetAddressIsDefault.UseVisualStyleBackColor = true;
            // 
            // ToolStripContainerStudentAddresses
            // 
            // 
            // ToolStripContainerStudentAddresses.ContentPanel
            // 
            this.ToolStripContainerStudentAddresses.ContentPanel.Controls.Add(this.dgvStudentAddresses);
            this.ToolStripContainerStudentAddresses.ContentPanel.Size = new System.Drawing.Size(213, 129);
            this.ToolStripContainerStudentAddresses.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolStripContainerStudentAddresses.Location = new System.Drawing.Point(0, 15);
            this.ToolStripContainerStudentAddresses.Name = "ToolStripContainerStudentAddresses";
            this.ToolStripContainerStudentAddresses.Size = new System.Drawing.Size(213, 156);
            this.ToolStripContainerStudentAddresses.TabIndex = 39;
            this.ToolStripContainerStudentAddresses.Text = "toolStripContainer1";
            // 
            // ToolStripContainerStudentAddresses.TopToolStripPanel
            // 
            this.ToolStripContainerStudentAddresses.TopToolStripPanel.Controls.Add(this.BindingNavigatorStudentAddresses);
            // 
            // dgvStudentAddresses
            // 
            this.dgvStudentAddresses.AllowUserToAddRows = false;
            this.dgvStudentAddresses.AllowUserToDeleteRows = false;
            this.dgvStudentAddresses.AllowUserToOrderColumns = true;
            this.dgvStudentAddresses.AllowUserToResizeColumns = false;
            this.dgvStudentAddresses.AllowUserToResizeRows = false;
            this.dgvStudentAddresses.AutoGenerateColumns = false;
            this.dgvStudentAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddressType,
            this.addressIsDefaultDataGridViewCheckBoxColumn,
            this.addressLineOneDataGridViewTextBoxColumn,
            this.addressLineTwoDataGridViewTextBoxColumn,
            this.Province,
            this.addressTownDataGridViewTextBoxColumn,
            this.addressSuburbDataGridViewTextBoxColumn,
            this.addressAreaCodeDataGridViewTextBoxColumn,
            this.Country,
            this.addressModifiedDateDataGridViewTextBoxColumn});
            this.dgvStudentAddresses.DataSource = this.BindingSourceStudentAddresses;
            this.dgvStudentAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentAddresses.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentAddresses.Name = "dgvStudentAddresses";
            this.dgvStudentAddresses.ReadOnly = true;
            this.dgvStudentAddresses.RowTemplate.Height = 24;
            this.dgvStudentAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentAddresses.Size = new System.Drawing.Size(213, 129);
            this.dgvStudentAddresses.TabIndex = 36;
            this.dgvStudentAddresses.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStudentAddresses_DataBindingComplete);
            // 
            // AddressType
            // 
            this.AddressType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddressType.HeaderText = "Address Type";
            this.AddressType.Name = "AddressType";
            this.AddressType.ReadOnly = true;
            this.AddressType.Width = 107;
            // 
            // addressIsDefaultDataGridViewCheckBoxColumn
            // 
            this.addressIsDefaultDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressIsDefaultDataGridViewCheckBoxColumn.DataPropertyName = "AddressIsDefault";
            this.addressIsDefaultDataGridViewCheckBoxColumn.HeaderText = "Is Default";
            this.addressIsDefaultDataGridViewCheckBoxColumn.Name = "addressIsDefaultDataGridViewCheckBoxColumn";
            this.addressIsDefaultDataGridViewCheckBoxColumn.ReadOnly = true;
            this.addressIsDefaultDataGridViewCheckBoxColumn.Width = 65;
            // 
            // addressLineOneDataGridViewTextBoxColumn
            // 
            this.addressLineOneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressLineOneDataGridViewTextBoxColumn.DataPropertyName = "AddressLineOne";
            this.addressLineOneDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressLineOneDataGridViewTextBoxColumn.Name = "addressLineOneDataGridViewTextBoxColumn";
            this.addressLineOneDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressLineOneDataGridViewTextBoxColumn.Width = 75;
            // 
            // addressLineTwoDataGridViewTextBoxColumn
            // 
            this.addressLineTwoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressLineTwoDataGridViewTextBoxColumn.DataPropertyName = "AddressLineTwo";
            this.addressLineTwoDataGridViewTextBoxColumn.HeaderText = "LineTwo";
            this.addressLineTwoDataGridViewTextBoxColumn.Name = "addressLineTwoDataGridViewTextBoxColumn";
            this.addressLineTwoDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressLineTwoDataGridViewTextBoxColumn.Width = 79;
            // 
            // Province
            // 
            this.Province.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Province.HeaderText = "Province";
            this.Province.Name = "Province";
            this.Province.ReadOnly = true;
            this.Province.Width = 78;
            // 
            // addressTownDataGridViewTextBoxColumn
            // 
            this.addressTownDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressTownDataGridViewTextBoxColumn.DataPropertyName = "AddressTown";
            this.addressTownDataGridViewTextBoxColumn.HeaderText = "Town";
            this.addressTownDataGridViewTextBoxColumn.Name = "addressTownDataGridViewTextBoxColumn";
            this.addressTownDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressTownDataGridViewTextBoxColumn.Width = 64;
            // 
            // addressSuburbDataGridViewTextBoxColumn
            // 
            this.addressSuburbDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressSuburbDataGridViewTextBoxColumn.DataPropertyName = "AddressSuburb";
            this.addressSuburbDataGridViewTextBoxColumn.HeaderText = "Suburb";
            this.addressSuburbDataGridViewTextBoxColumn.Name = "addressSuburbDataGridViewTextBoxColumn";
            this.addressSuburbDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressSuburbDataGridViewTextBoxColumn.Width = 71;
            // 
            // addressAreaCodeDataGridViewTextBoxColumn
            // 
            this.addressAreaCodeDataGridViewTextBoxColumn.DataPropertyName = "AddressAreaCode";
            this.addressAreaCodeDataGridViewTextBoxColumn.HeaderText = "Area Code";
            this.addressAreaCodeDataGridViewTextBoxColumn.Name = "addressAreaCodeDataGridViewTextBoxColumn";
            this.addressAreaCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // addressModifiedDateDataGridViewTextBoxColumn
            // 
            this.addressModifiedDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressModifiedDateDataGridViewTextBoxColumn.DataPropertyName = "AddressModifiedDate";
            this.addressModifiedDateDataGridViewTextBoxColumn.HeaderText = "Last Modified";
            this.addressModifiedDateDataGridViewTextBoxColumn.Name = "addressModifiedDateDataGridViewTextBoxColumn";
            this.addressModifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BindingSourceStudentAddresses
            // 
            this.BindingSourceStudentAddresses.DataSource = typeof(Impendulo.Data.Models.Address);
            this.BindingSourceStudentAddresses.PositionChanged += new System.EventHandler(this.BindingSourceStudentAddresses_PositionChanged);
            // 
            // BindingNavigatorStudentAddresses
            // 
            this.BindingNavigatorStudentAddresses.AddNewItem = null;
            this.BindingNavigatorStudentAddresses.BindingSource = this.BindingSourceStudentAddresses;
            this.BindingNavigatorStudentAddresses.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorStudentAddresses.DeleteItem = null;
            this.BindingNavigatorStudentAddresses.Dock = System.Windows.Forms.DockStyle.None;
            this.BindingNavigatorStudentAddresses.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BindingNavigatorStudentAddresses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigatorStudentAddresses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAddStudentAddress,
            this.btnRemoveStudentAddress,
            this.toolStripSeparator1});
            this.BindingNavigatorStudentAddresses.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigatorStudentAddresses.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigatorStudentAddresses.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigatorStudentAddresses.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigatorStudentAddresses.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigatorStudentAddresses.Name = "BindingNavigatorStudentAddresses";
            this.BindingNavigatorStudentAddresses.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigatorStudentAddresses.Size = new System.Drawing.Size(213, 27);
            this.BindingNavigatorStudentAddresses.Stretch = true;
            this.BindingNavigatorStudentAddresses.TabIndex = 2;
            this.BindingNavigatorStudentAddresses.Text = "bindingNavigator1";
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
            // btnAddStudentAddress
            // 
            this.btnAddStudentAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddStudentAddress.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudentAddress.Image")));
            this.btnAddStudentAddress.Name = "btnAddStudentAddress";
            this.btnAddStudentAddress.RightToLeftAutoMirrorImage = true;
            this.btnAddStudentAddress.Size = new System.Drawing.Size(24, 24);
            this.btnAddStudentAddress.Text = "Add new";
            this.btnAddStudentAddress.Click += new System.EventHandler(this.btnAddStudnetAddress_Click);
            // 
            // btnRemoveStudentAddress
            // 
            this.btnRemoveStudentAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveStudentAddress.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveStudentAddress.Image")));
            this.btnRemoveStudentAddress.Name = "btnRemoveStudentAddress";
            this.btnRemoveStudentAddress.RightToLeftAutoMirrorImage = true;
            this.btnRemoveStudentAddress.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveStudentAddress.Text = "Delete";
            this.btnRemoveStudentAddress.Click += new System.EventHandler(this.btnRemoveStudentAddress_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // gbAddStudentContactDetailRadioButtons
            // 
            this.gbAddStudentContactDetailRadioButtons.Controls.Add(this.tabControl3);
            this.gbAddStudentContactDetailRadioButtons.Controls.Add(this.toolStripContainerStudentContacts);
            this.gbAddStudentContactDetailRadioButtons.Location = new System.Drawing.Point(697, 0);
            this.gbAddStudentContactDetailRadioButtons.Margin = new System.Windows.Forms.Padding(0);
            this.gbAddStudentContactDetailRadioButtons.Name = "gbAddStudentContactDetailRadioButtons";
            this.gbAddStudentContactDetailRadioButtons.Padding = new System.Windows.Forms.Padding(0);
            this.gbAddStudentContactDetailRadioButtons.Size = new System.Drawing.Size(280, 120);
            this.gbAddStudentContactDetailRadioButtons.TabIndex = 2;
            this.gbAddStudentContactDetailRadioButtons.TabStop = false;
            this.gbAddStudentContactDetailRadioButtons.Tag = "2";
            this.gbAddStudentContactDetailRadioButtons.Text = "Student Contact Details";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 210);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(280, 0);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbAddStudentContactInfo);
            this.tabPage3.Controls.Add(this.gbUpdateStudentContactInfo);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(272, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Add/Update Student Contact Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbAddStudentContactInfo
            // 
            this.gbAddStudentContactInfo.Controls.Add(this.btnCancelAddStudnetContactInfo);
            this.gbAddStudentContactInfo.Controls.Add(this.btnAddStudnetContactInfo);
            this.gbAddStudentContactInfo.Controls.Add(this.flowLayoutPanel1);
            this.gbAddStudentContactInfo.Controls.Add(this.flowLayoutPanelContactTypeOptions);
            this.gbAddStudentContactInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAddStudentContactInfo.Location = new System.Drawing.Point(3, 60);
            this.gbAddStudentContactInfo.Name = "gbAddStudentContactInfo";
            this.gbAddStudentContactInfo.Size = new System.Drawing.Size(266, 112);
            this.gbAddStudentContactInfo.TabIndex = 3;
            this.gbAddStudentContactInfo.TabStop = false;
            this.gbAddStudentContactInfo.Text = "Add Contact Type";
            this.gbAddStudentContactInfo.Visible = false;
            // 
            // btnCancelAddStudnetContactInfo
            // 
            this.btnCancelAddStudnetContactInfo.Location = new System.Drawing.Point(112, 79);
            this.btnCancelAddStudnetContactInfo.Name = "btnCancelAddStudnetContactInfo";
            this.btnCancelAddStudnetContactInfo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddStudnetContactInfo.TabIndex = 7;
            this.btnCancelAddStudnetContactInfo.Text = "Cancel";
            this.btnCancelAddStudnetContactInfo.UseVisualStyleBackColor = true;
            this.btnCancelAddStudnetContactInfo.Click += new System.EventHandler(this.btnCancelAddStudnetContactInfo_Click);
            // 
            // btnAddStudnetContactInfo
            // 
            this.btnAddStudnetContactInfo.Location = new System.Drawing.Point(193, 79);
            this.btnAddStudnetContactInfo.Name = "btnAddStudnetContactInfo";
            this.btnAddStudnetContactInfo.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudnetContactInfo.TabIndex = 6;
            this.btnAddStudnetContactInfo.Text = "Add ";
            this.btnAddStudnetContactInfo.UseVisualStyleBackColor = true;
            this.btnAddStudnetContactInfo.Click += new System.EventHandler(this.btnAddStudnetContactInfo_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.txtStudentContactTypeAddEmailAddress);
            this.flowLayoutPanel1.Controls.Add(this.txtStudentContactTypeAddContactNumber);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblAddControlType);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 25);
            this.panel6.TabIndex = 3;
            // 
            // lblAddControlType
            // 
            this.lblAddControlType.AutoSize = true;
            this.lblAddControlType.Location = new System.Drawing.Point(3, 4);
            this.lblAddControlType.Name = "lblAddControlType";
            this.lblAddControlType.Size = new System.Drawing.Size(38, 14);
            this.lblAddControlType.TabIndex = 0;
            this.lblAddControlType.Text = "label3";
            // 
            // txtStudentContactTypeAddEmailAddress
            // 
            this.txtStudentContactTypeAddEmailAddress.Location = new System.Drawing.Point(3, 35);
            this.txtStudentContactTypeAddEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txtStudentContactTypeAddEmailAddress.Name = "txtStudentContactTypeAddEmailAddress";
            this.txtStudentContactTypeAddEmailAddress.Size = new System.Drawing.Size(289, 22);
            this.txtStudentContactTypeAddEmailAddress.TabIndex = 2;
            // 
            // txtStudentContactTypeAddContactNumber
            // 
            this.txtStudentContactTypeAddContactNumber.Location = new System.Drawing.Point(3, 64);
            this.txtStudentContactTypeAddContactNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txtStudentContactTypeAddContactNumber.Mask = "(999) 000-0000";
            this.txtStudentContactTypeAddContactNumber.Name = "txtStudentContactTypeAddContactNumber";
            this.txtStudentContactTypeAddContactNumber.Size = new System.Drawing.Size(100, 22);
            this.txtStudentContactTypeAddContactNumber.TabIndex = 1;
            // 
            // flowLayoutPanelContactTypeOptions
            // 
            this.flowLayoutPanelContactTypeOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelContactTypeOptions.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanelContactTypeOptions.Name = "flowLayoutPanelContactTypeOptions";
            this.flowLayoutPanelContactTypeOptions.Size = new System.Drawing.Size(260, 25);
            this.flowLayoutPanelContactTypeOptions.TabIndex = 0;
            // 
            // gbUpdateStudentContactInfo
            // 
            this.gbUpdateStudentContactInfo.Controls.Add(this.flowLayoutPanel2);
            this.gbUpdateStudentContactInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUpdateStudentContactInfo.Location = new System.Drawing.Point(3, 3);
            this.gbUpdateStudentContactInfo.Name = "gbUpdateStudentContactInfo";
            this.gbUpdateStudentContactInfo.Size = new System.Drawing.Size(266, 57);
            this.gbUpdateStudentContactInfo.TabIndex = 1;
            this.gbUpdateStudentContactInfo.TabStop = false;
            this.gbUpdateStudentContactInfo.Text = "Update Contact Info";
            this.gbUpdateStudentContactInfo.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtStudentContactTypeUpdateEmailAddress);
            this.flowLayoutPanel2.Controls.Add(this.txtStudentContactTypeUpdateNumberField);
            this.flowLayoutPanel2.Controls.Add(this.btnStudentContactInfoUpdateDetail);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(260, 30);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // txtStudentContactTypeUpdateEmailAddress
            // 
            this.txtStudentContactTypeUpdateEmailAddress.Location = new System.Drawing.Point(3, 4);
            this.txtStudentContactTypeUpdateEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txtStudentContactTypeUpdateEmailAddress.Name = "txtStudentContactTypeUpdateEmailAddress";
            this.txtStudentContactTypeUpdateEmailAddress.Size = new System.Drawing.Size(394, 22);
            this.txtStudentContactTypeUpdateEmailAddress.TabIndex = 2;
            // 
            // txtStudentContactTypeUpdateNumberField
            // 
            this.txtStudentContactTypeUpdateNumberField.Location = new System.Drawing.Point(3, 33);
            this.txtStudentContactTypeUpdateNumberField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txtStudentContactTypeUpdateNumberField.Mask = "(999) 000-0000";
            this.txtStudentContactTypeUpdateNumberField.Name = "txtStudentContactTypeUpdateNumberField";
            this.txtStudentContactTypeUpdateNumberField.Size = new System.Drawing.Size(100, 22);
            this.txtStudentContactTypeUpdateNumberField.TabIndex = 1;
            // 
            // btnStudentContactInfoUpdateDetail
            // 
            this.btnStudentContactInfoUpdateDetail.Location = new System.Drawing.Point(109, 32);
            this.btnStudentContactInfoUpdateDetail.Name = "btnStudentContactInfoUpdateDetail";
            this.btnStudentContactInfoUpdateDetail.Size = new System.Drawing.Size(75, 23);
            this.btnStudentContactInfoUpdateDetail.TabIndex = 4;
            this.btnStudentContactInfoUpdateDetail.Text = "Update";
            this.btnStudentContactInfoUpdateDetail.UseVisualStyleBackColor = true;
            this.btnStudentContactInfoUpdateDetail.Click += new System.EventHandler(this.btnStudentContactInfoAddUpdateContactDetail_Click);
            // 
            // toolStripContainerStudentContacts
            // 
            // 
            // toolStripContainerStudentContacts.ContentPanel
            // 
            this.toolStripContainerStudentContacts.ContentPanel.Controls.Add(this.dgvStudentContactInfo);
            this.toolStripContainerStudentContacts.ContentPanel.Size = new System.Drawing.Size(280, 168);
            this.toolStripContainerStudentContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainerStudentContacts.Location = new System.Drawing.Point(0, 15);
            this.toolStripContainerStudentContacts.Name = "toolStripContainerStudentContacts";
            this.toolStripContainerStudentContacts.Size = new System.Drawing.Size(280, 195);
            this.toolStripContainerStudentContacts.TabIndex = 0;
            this.toolStripContainerStudentContacts.Text = "toolStripContainer1";
            // 
            // toolStripContainerStudentContacts.TopToolStripPanel
            // 
            this.toolStripContainerStudentContacts.TopToolStripPanel.Controls.Add(this.BindingNavigatorStudentContactInfo);
            // 
            // dgvStudentContactInfo
            // 
            this.dgvStudentContactInfo.AllowUserToAddRows = false;
            this.dgvStudentContactInfo.AllowUserToDeleteRows = false;
            this.dgvStudentContactInfo.AutoGenerateColumns = false;
            this.dgvStudentContactInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentContactInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactType,
            this.contactDetailValueDataGridViewTextBoxColumn});
            this.dgvStudentContactInfo.DataSource = this.BindingSourceStudentContactDetails;
            this.dgvStudentContactInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentContactInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentContactInfo.Name = "dgvStudentContactInfo";
            this.dgvStudentContactInfo.ReadOnly = true;
            this.dgvStudentContactInfo.RowTemplate.Height = 24;
            this.dgvStudentContactInfo.Size = new System.Drawing.Size(280, 168);
            this.dgvStudentContactInfo.TabIndex = 0;
            this.dgvStudentContactInfo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStudentContactInfo_DataBindingComplete);
            // 
            // ContactType
            // 
            this.ContactType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ContactType.HeaderText = "Contact Type";
            this.ContactType.MinimumWidth = 120;
            this.ContactType.Name = "ContactType";
            this.ContactType.ReadOnly = true;
            this.ContactType.Width = 120;
            // 
            // contactDetailValueDataGridViewTextBoxColumn
            // 
            this.contactDetailValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactDetailValueDataGridViewTextBoxColumn.DataPropertyName = "ContactDetailValue";
            this.contactDetailValueDataGridViewTextBoxColumn.HeaderText = "Contact Detail";
            this.contactDetailValueDataGridViewTextBoxColumn.Name = "contactDetailValueDataGridViewTextBoxColumn";
            this.contactDetailValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BindingSourceStudentContactDetails
            // 
            this.BindingSourceStudentContactDetails.DataSource = typeof(Impendulo.Data.Models.ContactDetail);
            this.BindingSourceStudentContactDetails.PositionChanged += new System.EventHandler(this.BindingSourceStudentContactDetails_PositionChanged);
            // 
            // BindingNavigatorStudentContactInfo
            // 
            this.BindingNavigatorStudentContactInfo.AddNewItem = null;
            this.BindingNavigatorStudentContactInfo.BindingSource = this.BindingSourceStudentContactDetails;
            this.BindingNavigatorStudentContactInfo.CountItem = this.bindingNavigatorCountItem1;
            this.BindingNavigatorStudentContactInfo.DeleteItem = null;
            this.BindingNavigatorStudentContactInfo.Dock = System.Windows.Forms.DockStyle.None;
            this.BindingNavigatorStudentContactInfo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BindingNavigatorStudentContactInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigatorStudentContactInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.btnAddStudentContactInfo,
            this.btnRemoveStudentClientInfo,
            this.toolStripSeparator2});
            this.BindingNavigatorStudentContactInfo.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigatorStudentContactInfo.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.BindingNavigatorStudentContactInfo.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.BindingNavigatorStudentContactInfo.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.BindingNavigatorStudentContactInfo.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.BindingNavigatorStudentContactInfo.Name = "BindingNavigatorStudentContactInfo";
            this.BindingNavigatorStudentContactInfo.PositionItem = this.bindingNavigatorPositionItem1;
            this.BindingNavigatorStudentContactInfo.Size = new System.Drawing.Size(280, 27);
            this.BindingNavigatorStudentContactInfo.Stretch = true;
            this.BindingNavigatorStudentContactInfo.TabIndex = 0;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAddStudentContactInfo
            // 
            this.btnAddStudentContactInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddStudentContactInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudentContactInfo.Image")));
            this.btnAddStudentContactInfo.Name = "btnAddStudentContactInfo";
            this.btnAddStudentContactInfo.RightToLeftAutoMirrorImage = true;
            this.btnAddStudentContactInfo.Size = new System.Drawing.Size(24, 24);
            this.btnAddStudentContactInfo.Text = "Add new";
            this.btnAddStudentContactInfo.Click += new System.EventHandler(this.btnAddStudentContactInfo_Click);
            // 
            // btnRemoveStudentClientInfo
            // 
            this.btnRemoveStudentClientInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveStudentClientInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveStudentClientInfo.Image")));
            this.btnRemoveStudentClientInfo.Name = "btnRemoveStudentClientInfo";
            this.btnRemoveStudentClientInfo.RightToLeftAutoMirrorImage = true;
            this.btnRemoveStudentClientInfo.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveStudentClientInfo.Text = "Delete";
            this.btnRemoveStudentClientInfo.Click += new System.EventHandler(this.btnRemoveStudentClientInfo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // gbStudentDisability
            // 
            this.gbStudentDisability.Controls.Add(this.tabControl4);
            this.gbStudentDisability.Controls.Add(this.toolStripContainerStudentDisablity);
            this.gbStudentDisability.Location = new System.Drawing.Point(0, 185);
            this.gbStudentDisability.Margin = new System.Windows.Forms.Padding(0);
            this.gbStudentDisability.Name = "gbStudentDisability";
            this.gbStudentDisability.Padding = new System.Windows.Forms.Padding(0);
            this.gbStudentDisability.Size = new System.Drawing.Size(322, 101);
            this.gbStudentDisability.TabIndex = 3;
            this.gbStudentDisability.TabStop = false;
            this.gbStudentDisability.Tag = "3";
            this.gbStudentDisability.Text = "Student Disabilities";
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(0, 225);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(322, 0);
            this.tabControl4.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.gbDisablitiyOptions);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(314, 0);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Add/Edit Student Disablities";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCancelAddingStudentDisablity);
            this.groupBox2.Controls.Add(this.btnAddUpdateStudentDisablity);
            this.groupBox2.Controls.Add(this.txtStudentDisablityNotes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(239, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(72, 0);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Notes";
            // 
            // btnCancelAddingStudentDisablity
            // 
            this.btnCancelAddingStudentDisablity.Location = new System.Drawing.Point(239, 138);
            this.btnCancelAddingStudentDisablity.Name = "btnCancelAddingStudentDisablity";
            this.btnCancelAddingStudentDisablity.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddingStudentDisablity.TabIndex = 6;
            this.btnCancelAddingStudentDisablity.Text = "&Cancel";
            this.btnCancelAddingStudentDisablity.UseVisualStyleBackColor = true;
            this.btnCancelAddingStudentDisablity.Click += new System.EventHandler(this.btnCancelAddingStudentDisablity_Click);
            // 
            // btnAddUpdateStudentDisablity
            // 
            this.btnAddUpdateStudentDisablity.Location = new System.Drawing.Point(320, 138);
            this.btnAddUpdateStudentDisablity.Name = "btnAddUpdateStudentDisablity";
            this.btnAddUpdateStudentDisablity.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdateStudentDisablity.TabIndex = 5;
            this.btnAddUpdateStudentDisablity.Text = "&Update Details";
            this.btnAddUpdateStudentDisablity.UseVisualStyleBackColor = true;
            this.btnAddUpdateStudentDisablity.Click += new System.EventHandler(this.btnAddUpdateStudentDisablity_Click);
            // 
            // txtStudentDisablityNotes
            // 
            this.txtStudentDisablityNotes.Location = new System.Drawing.Point(68, 31);
            this.txtStudentDisablityNotes.Multiline = true;
            this.txtStudentDisablityNotes.Name = "txtStudentDisablityNotes";
            this.txtStudentDisablityNotes.Size = new System.Drawing.Size(327, 101);
            this.txtStudentDisablityNotes.TabIndex = 4;
            // 
            // gbDisablitiyOptions
            // 
            this.gbDisablitiyOptions.Controls.Add(this.flowLayoutPanelDisablitiyCategory);
            this.gbDisablitiyOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDisablitiyOptions.Location = new System.Drawing.Point(3, 3);
            this.gbDisablitiyOptions.Name = "gbDisablitiyOptions";
            this.gbDisablitiyOptions.Size = new System.Drawing.Size(236, 0);
            this.gbDisablitiyOptions.TabIndex = 1;
            this.gbDisablitiyOptions.TabStop = false;
            this.gbDisablitiyOptions.Text = "Disability Categories";
            // 
            // flowLayoutPanelDisablitiyCategory
            // 
            this.flowLayoutPanelDisablitiyCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDisablitiyCategory.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanelDisablitiyCategory.Name = "flowLayoutPanelDisablitiyCategory";
            this.flowLayoutPanelDisablitiyCategory.Size = new System.Drawing.Size(230, 0);
            this.flowLayoutPanelDisablitiyCategory.TabIndex = 0;
            // 
            // toolStripContainerStudentDisablity
            // 
            // 
            // toolStripContainerStudentDisablity.ContentPanel
            // 
            this.toolStripContainerStudentDisablity.ContentPanel.Controls.Add(this.dgvStudentDisablity);
            this.toolStripContainerStudentDisablity.ContentPanel.Size = new System.Drawing.Size(322, 183);
            this.toolStripContainerStudentDisablity.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainerStudentDisablity.Location = new System.Drawing.Point(0, 15);
            this.toolStripContainerStudentDisablity.Name = "toolStripContainerStudentDisablity";
            this.toolStripContainerStudentDisablity.Size = new System.Drawing.Size(322, 210);
            this.toolStripContainerStudentDisablity.TabIndex = 0;
            this.toolStripContainerStudentDisablity.Text = "toolStripContainer1";
            // 
            // toolStripContainerStudentDisablity.TopToolStripPanel
            // 
            this.toolStripContainerStudentDisablity.TopToolStripPanel.Controls.Add(this.BindingNavigatorStudentDisablity);
            // 
            // dgvStudentDisablity
            // 
            this.dgvStudentDisablity.AllowUserToAddRows = false;
            this.dgvStudentDisablity.AllowUserToDeleteRows = false;
            this.dgvStudentDisablity.AutoGenerateColumns = false;
            this.dgvStudentDisablity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentDisablity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignnedDisablity,
            this.studentDisabilityNotesDataGridViewTextBoxColumn});
            this.dgvStudentDisablity.DataSource = this.BindingSourceStudentDisablity;
            this.dgvStudentDisablity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentDisablity.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentDisablity.Name = "dgvStudentDisablity";
            this.dgvStudentDisablity.ReadOnly = true;
            this.dgvStudentDisablity.RowTemplate.Height = 24;
            this.dgvStudentDisablity.Size = new System.Drawing.Size(322, 183);
            this.dgvStudentDisablity.TabIndex = 0;
            this.dgvStudentDisablity.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStudentDisablity_DataBindingComplete);
            // 
            // AssignnedDisablity
            // 
            this.AssignnedDisablity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AssignnedDisablity.HeaderText = "Disablity";
            this.AssignnedDisablity.Name = "AssignnedDisablity";
            this.AssignnedDisablity.ReadOnly = true;
            this.AssignnedDisablity.Width = 75;
            // 
            // studentDisabilityNotesDataGridViewTextBoxColumn
            // 
            this.studentDisabilityNotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentDisabilityNotesDataGridViewTextBoxColumn.DataPropertyName = "StudentDisabilityNotes";
            this.studentDisabilityNotesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.studentDisabilityNotesDataGridViewTextBoxColumn.Name = "studentDisabilityNotesDataGridViewTextBoxColumn";
            this.studentDisabilityNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BindingSourceStudentDisablity
            // 
            this.BindingSourceStudentDisablity.DataSource = typeof(Impendulo.Data.Models.StudentDisability);
            this.BindingSourceStudentDisablity.PositionChanged += new System.EventHandler(this.BindingSourceStudentDisablity_PositionChanged);
            // 
            // BindingNavigatorStudentDisablity
            // 
            this.BindingNavigatorStudentDisablity.AddNewItem = null;
            this.BindingNavigatorStudentDisablity.BindingSource = this.BindingSourceStudentDisablity;
            this.BindingNavigatorStudentDisablity.CountItem = this.bindingNavigatorCountItem2;
            this.BindingNavigatorStudentDisablity.DeleteItem = null;
            this.BindingNavigatorStudentDisablity.Dock = System.Windows.Forms.DockStyle.None;
            this.BindingNavigatorStudentDisablity.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BindingNavigatorStudentDisablity.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigatorStudentDisablity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.btnAddStudentDisablity,
            this.btnRemoveStudentDisablity,
            this.toolStripSeparator3});
            this.BindingNavigatorStudentDisablity.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigatorStudentDisablity.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.BindingNavigatorStudentDisablity.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.BindingNavigatorStudentDisablity.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.BindingNavigatorStudentDisablity.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.BindingNavigatorStudentDisablity.Name = "BindingNavigatorStudentDisablity";
            this.BindingNavigatorStudentDisablity.PositionItem = this.bindingNavigatorPositionItem2;
            this.BindingNavigatorStudentDisablity.Size = new System.Drawing.Size(322, 27);
            this.BindingNavigatorStudentDisablity.Stretch = true;
            this.BindingNavigatorStudentDisablity.TabIndex = 0;
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAddStudentDisablity
            // 
            this.btnAddStudentDisablity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddStudentDisablity.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudentDisablity.Image")));
            this.btnAddStudentDisablity.Name = "btnAddStudentDisablity";
            this.btnAddStudentDisablity.RightToLeftAutoMirrorImage = true;
            this.btnAddStudentDisablity.Size = new System.Drawing.Size(24, 24);
            this.btnAddStudentDisablity.Text = "Add new";
            this.btnAddStudentDisablity.Click += new System.EventHandler(this.btnAddStudentDisablity_Click);
            // 
            // btnRemoveStudentDisablity
            // 
            this.btnRemoveStudentDisablity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveStudentDisablity.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveStudentDisablity.Image")));
            this.btnRemoveStudentDisablity.Name = "btnRemoveStudentDisablity";
            this.btnRemoveStudentDisablity.RightToLeftAutoMirrorImage = true;
            this.btnRemoveStudentDisablity.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveStudentDisablity.Text = "Delete";
            this.btnRemoveStudentDisablity.Click += new System.EventHandler(this.btnRemoveStudentDisablity_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // gbStudentDetails
            // 
            this.gbStudentDetails.Controls.Add(this.tabControl2);
            this.gbStudentDetails.Location = new System.Drawing.Point(322, 185);
            this.gbStudentDetails.Margin = new System.Windows.Forms.Padding(0);
            this.gbStudentDetails.Name = "gbStudentDetails";
            this.gbStudentDetails.Padding = new System.Windows.Forms.Padding(0);
            this.gbStudentDetails.Size = new System.Drawing.Size(572, 442);
            this.gbStudentDetails.TabIndex = 0;
            this.gbStudentDetails.TabStop = false;
            this.gbStudentDetails.Tag = "0";
            this.gbStudentDetails.Text = "Student Details";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 15);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(572, 427);
            this.tabControl2.TabIndex = 54;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 400);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(studentIDLabel);
            this.groupBox3.Controls.Add(this.btnAddUpdateStudent);
            this.groupBox3.Controls.Add(label36);
            this.groupBox3.Controls.Add(qualificationLevelIDLabel);
            this.groupBox3.Controls.Add(martialStatusIDLabel);
            this.groupBox3.Controls.Add(this.cbolookupTitle);
            this.groupBox3.Controls.Add(genderIDLabel);
            this.groupBox3.Controls.Add(this.cboLookupQualificationLevel);
            this.groupBox3.Controls.Add(ethnicityIDLabel);
            this.groupBox3.Controls.Add(this.cboLookupMartialStatus);
            this.groupBox3.Controls.Add(individualSecondNameLabel);
            this.groupBox3.Controls.Add(this.cboLookupGender);
            this.groupBox3.Controls.Add(individualLastnameLabel);
            this.groupBox3.Controls.Add(this.cboLookupEthnicity);
            this.groupBox3.Controls.Add(individualIDNumberLabel);
            this.groupBox3.Controls.Add(individualFirstNameLabel);
            this.groupBox3.Controls.Add(this.txtStudentID);
            this.groupBox3.Controls.Add(this.txtStudentFirstName);
            this.groupBox3.Controls.Add(this.txtStudentSecondName);
            this.groupBox3.Controls.Add(this.txtStudentIDNumber);
            this.groupBox3.Controls.Add(this.txtStudentLastName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 394);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            // 
            // btnAddUpdateStudent
            // 
            this.btnAddUpdateStudent.Location = new System.Drawing.Point(288, 301);
            this.btnAddUpdateStudent.Name = "btnAddUpdateStudent";
            this.btnAddUpdateStudent.Size = new System.Drawing.Size(175, 42);
            this.btnAddUpdateStudent.TabIndex = 50;
            this.btnAddUpdateStudent.Text = "Add Student";
            this.btnAddUpdateStudent.UseVisualStyleBackColor = true;
            this.btnAddUpdateStudent.Click += new System.EventHandler(this.btnStudentAddStudent_Click);
            // 
            // cbolookupTitle
            // 
            this.cbolookupTitle.DisplayMember = "Title";
            this.cbolookupTitle.FormattingEnabled = true;
            this.cbolookupTitle.Location = new System.Drawing.Point(133, 49);
            this.cbolookupTitle.Name = "cbolookupTitle";
            this.cbolookupTitle.Size = new System.Drawing.Size(89, 22);
            this.cbolookupTitle.TabIndex = 69;
            this.cbolookupTitle.ValueMember = "TitleID";
            // 
            // cboLookupQualificationLevel
            // 
            this.cboLookupQualificationLevel.DisplayMember = "QualificationLevel";
            this.cboLookupQualificationLevel.FormattingEnabled = true;
            this.cboLookupQualificationLevel.Location = new System.Drawing.Point(134, 273);
            this.cboLookupQualificationLevel.Name = "cboLookupQualificationLevel";
            this.cboLookupQualificationLevel.Size = new System.Drawing.Size(329, 22);
            this.cboLookupQualificationLevel.TabIndex = 68;
            this.cboLookupQualificationLevel.ValueMember = "QualificationLevelID";
            // 
            // cboLookupMartialStatus
            // 
            this.cboLookupMartialStatus.DisplayMember = "MaritialStatus";
            this.cboLookupMartialStatus.FormattingEnabled = true;
            this.cboLookupMartialStatus.Location = new System.Drawing.Point(133, 245);
            this.cboLookupMartialStatus.Name = "cboLookupMartialStatus";
            this.cboLookupMartialStatus.Size = new System.Drawing.Size(167, 22);
            this.cboLookupMartialStatus.TabIndex = 66;
            this.cboLookupMartialStatus.ValueMember = "MartialStatusID";
            // 
            // cboLookupGender
            // 
            this.cboLookupGender.DisplayMember = "Gender";
            this.cboLookupGender.FormattingEnabled = true;
            this.cboLookupGender.Location = new System.Drawing.Point(133, 217);
            this.cboLookupGender.Name = "cboLookupGender";
            this.cboLookupGender.Size = new System.Drawing.Size(167, 22);
            this.cboLookupGender.TabIndex = 70;
            this.cboLookupGender.ValueMember = "GenderID";
            // 
            // cboLookupEthnicity
            // 
            this.cboLookupEthnicity.DisplayMember = "Ethnicity";
            this.cboLookupEthnicity.FormattingEnabled = true;
            this.cboLookupEthnicity.Location = new System.Drawing.Point(133, 189);
            this.cboLookupEthnicity.Name = "cboLookupEthnicity";
            this.cboLookupEthnicity.Size = new System.Drawing.Size(134, 22);
            this.cboLookupEthnicity.TabIndex = 67;
            this.cboLookupEthnicity.ValueMember = "EthnicityID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(133, 20);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(89, 22);
            this.txtStudentID.TabIndex = 57;
            this.txtStudentID.Text = "0";
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(133, 77);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtStudentFirstName.TabIndex = 59;
            // 
            // txtStudentSecondName
            // 
            this.txtStudentSecondName.Location = new System.Drawing.Point(133, 105);
            this.txtStudentSecondName.Name = "txtStudentSecondName";
            this.txtStudentSecondName.Size = new System.Drawing.Size(200, 22);
            this.txtStudentSecondName.TabIndex = 65;
            // 
            // txtStudentIDNumber
            // 
            this.txtStudentIDNumber.Location = new System.Drawing.Point(133, 161);
            this.txtStudentIDNumber.Name = "txtStudentIDNumber";
            this.txtStudentIDNumber.Size = new System.Drawing.Size(200, 22);
            this.txtStudentIDNumber.TabIndex = 61;
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(133, 133);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(200, 22);
            this.txtStudentLastName.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNextSection);
            this.panel1.Controls.Add(this.btnPreviousSection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 649);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(991, 73);
            this.panel1.TabIndex = 0;
            // 
            // btnNextSection
            // 
            this.btnNextSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSection.Location = new System.Drawing.Point(704, 5);
            this.btnNextSection.Name = "btnNextSection";
            this.btnNextSection.Size = new System.Drawing.Size(280, 61);
            this.btnNextSection.TabIndex = 1;
            this.btnNextSection.Text = "Next";
            this.btnNextSection.UseVisualStyleBackColor = true;
            this.btnNextSection.Click += new System.EventHandler(this.btnNextSection_Click);
            // 
            // btnPreviousSection
            // 
            this.btnPreviousSection.BackColor = System.Drawing.SystemColors.Control;
            this.btnPreviousSection.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPreviousSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousSection.Location = new System.Drawing.Point(5, 5);
            this.btnPreviousSection.Name = "btnPreviousSection";
            this.btnPreviousSection.Size = new System.Drawing.Size(280, 61);
            this.btnPreviousSection.TabIndex = 0;
            this.btnPreviousSection.Text = "Previous";
            this.btnPreviousSection.UseVisualStyleBackColor = false;
            this.btnPreviousSection.Click += new System.EventHandler(this.btnPreviousSection_Click);
            // 
            // BindingSourceStudentContactInfoContactType
            // 
            this.BindingSourceStudentContactInfoContactType.DataSource = typeof(Impendulo.Data.Models.LookupContactType);
            // 
            // frmAddUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1195, 722);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddUpdateStudent";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddUpdateStudent_FormClosing);
            this.Load += new System.EventHandler(this.frmAddUpdateStudent_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.MainflowLayoutPanel.ResumeLayout(false);
            this.gbStudentCompany.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.gbStudentNextOfKin.ResumeLayout(false);
            this.toolStripContainerStudentNextOfKin.ContentPanel.ResumeLayout(false);
            this.toolStripContainerStudentNextOfKin.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerStudentNextOfKin.TopToolStripPanel.PerformLayout();
            this.toolStripContainerStudentNextOfKin.ResumeLayout(false);
            this.toolStripContainerStudentNextOfKin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentNextOfKin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorStudnetNextOfKin)).EndInit();
            this.BindingNavigatorStudnetNextOfKin.ResumeLayout(false);
            this.BindingNavigatorStudnetNextOfKin.PerformLayout();
            this.gbStudentAddressDetails.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbSutdentAddressAddEdit.ResumeLayout(false);
            this.gbSutdentAddressAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentAddressProvinces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentAddressCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentAddressAddressType)).EndInit();
            this.ToolStripContainerStudentAddresses.ContentPanel.ResumeLayout(false);
            this.ToolStripContainerStudentAddresses.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainerStudentAddresses.TopToolStripPanel.PerformLayout();
            this.ToolStripContainerStudentAddresses.ResumeLayout(false);
            this.ToolStripContainerStudentAddresses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorStudentAddresses)).EndInit();
            this.BindingNavigatorStudentAddresses.ResumeLayout(false);
            this.BindingNavigatorStudentAddresses.PerformLayout();
            this.gbAddStudentContactDetailRadioButtons.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.gbAddStudentContactInfo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.gbUpdateStudentContactInfo.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.toolStripContainerStudentContacts.ContentPanel.ResumeLayout(false);
            this.toolStripContainerStudentContacts.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerStudentContacts.TopToolStripPanel.PerformLayout();
            this.toolStripContainerStudentContacts.ResumeLayout(false);
            this.toolStripContainerStudentContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentContactInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentContactDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorStudentContactInfo)).EndInit();
            this.BindingNavigatorStudentContactInfo.ResumeLayout(false);
            this.BindingNavigatorStudentContactInfo.PerformLayout();
            this.gbStudentDisability.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbDisablitiyOptions.ResumeLayout(false);
            this.toolStripContainerStudentDisablity.ContentPanel.ResumeLayout(false);
            this.toolStripContainerStudentDisablity.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerStudentDisablity.TopToolStripPanel.PerformLayout();
            this.toolStripContainerStudentDisablity.ResumeLayout(false);
            this.toolStripContainerStudentDisablity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDisablity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentDisablity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorStudentDisablity)).EndInit();
            this.BindingNavigatorStudentDisablity.ResumeLayout(false);
            this.BindingNavigatorStudentDisablity.PerformLayout();
            this.gbStudentDetails.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceStudentContactInfoContactType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel MainflowLayoutPanel;
        private System.Windows.Forms.GroupBox gbStudentDetails;
        private System.Windows.Forms.GroupBox gbStudentAddressDetails;
        private System.Windows.Forms.GroupBox gbAddStudentContactDetailRadioButtons;
        private System.Windows.Forms.GroupBox gbStudentDisability;
        private System.Windows.Forms.GroupBox gbStudentCompany;
        private System.Windows.Forms.GroupBox gbStudentNextOfKin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNextSection;
        private System.Windows.Forms.Button btnPreviousSection;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox gbSutdentAddressAddEdit;
        private System.Windows.Forms.ComboBox cboStudentAddressProvince;
        private System.Windows.Forms.ComboBox cboStudentAddressCountry;
        private System.Windows.Forms.ComboBox cboStudentAddressAddressType;
        private System.Windows.Forms.TextBox txtStudentAddressLineOne;
        private System.Windows.Forms.TextBox txtStudentAddressLineTwo;
        private System.Windows.Forms.TextBox txtStudentAddressTown;
        private System.Windows.Forms.TextBox txtStudentAddressSuburb;
        private System.Windows.Forms.TextBox txtStudentAddressAreaCode;
        private System.Windows.Forms.CheckBox chkStudnetAddressIsDefault;
        private System.Windows.Forms.BindingSource BindingSourceStudentAddressAddressType;
        private System.Windows.Forms.ToolStripContainer ToolStripContainerStudentAddresses;
        private System.Windows.Forms.DataGridView dgvStudentAddresses;
        private System.Windows.Forms.BindingNavigator BindingNavigatorStudentAddresses;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAddStudentAddress;
        private System.Windows.Forms.ToolStripButton btnRemoveStudentAddress;
        private System.Windows.Forms.Button btnStudentAddressAddUpdate;
        private System.Windows.Forms.Button btnStudentAddressCancelAddUpdate;
        private System.Windows.Forms.BindingSource BindingSourceStudentAddressProvinces;
        private System.Windows.Forms.BindingSource BindingSourceStudentAddressCountry;
        private System.Windows.Forms.GroupBox gbUpdateStudentContactInfo;
        private System.Windows.Forms.ToolStripContainer toolStripContainerStudentContacts;
        private System.Windows.Forms.DataGridView dgvStudentContactInfo;
        private System.Windows.Forms.BindingNavigator BindingNavigatorStudentContactInfo;
        private System.Windows.Forms.ToolStripButton btnAddStudentContactInfo;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton btnRemoveStudentClientInfo;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource BindingSourceStudentContactInfoContactType;
        private System.Windows.Forms.BindingSource BindingSourceStudentContactDetails;
        private System.Windows.Forms.Button btnStudentContactInfoUpdateDetail;
        private System.Windows.Forms.ToolStripContainer toolStripContainerStudentDisablity;
        private System.Windows.Forms.DataGridView dgvStudentDisablity;
        private System.Windows.Forms.BindingNavigator BindingNavigatorStudentDisablity;
        private System.Windows.Forms.ToolStripButton btnAddStudentDisablity;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton btnRemoveStudentDisablity;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.BindingSource BindingSourceStudentDisablity;
        private System.Windows.Forms.GroupBox gbStudnetNextOfKin;
        private System.Windows.Forms.ToolStripContainer toolStripContainerStudentNextOfKin;
        private System.Windows.Forms.DataGridView dgvStudentNextOfKin;
        private System.Windows.Forms.BindingNavigator BindingNavigatorStudnetNextOfKin;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private System.Windows.Forms.ImageList imageListStudentRegisteration;
        private System.Windows.Forms.BindingSource BindingSourceStudentAddresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addressIsDefaultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLineOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLineTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressTownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressSuburbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressAreaCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressModifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactType;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDetailValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddUpdateStudent;
        private System.Windows.Forms.ComboBox cbolookupTitle;
        private System.Windows.Forms.ComboBox cboLookupQualificationLevel;
        private System.Windows.Forms.ComboBox cboLookupMartialStatus;
        private System.Windows.Forms.ComboBox cboLookupGender;
        private System.Windows.Forms.ComboBox cboLookupEthnicity;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.TextBox txtStudentSecondName;
        private System.Windows.Forms.TextBox txtStudentIDNumber;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbAddStudentContactInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContactTypeOptions;
        private System.Windows.Forms.MaskedTextBox txtStudentContactTypeAddContactNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAddControlType;
        private System.Windows.Forms.TextBox txtStudentContactTypeAddEmailAddress;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCancelAddStudnetContactInfo;
        private System.Windows.Forms.Button btnAddStudnetContactInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtStudentContactTypeUpdateEmailAddress;
        private System.Windows.Forms.MaskedTextBox txtStudentContactTypeUpdateNumberField;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelAddingStudentDisablity;
        private System.Windows.Forms.Button btnAddUpdateStudentDisablity;
        private System.Windows.Forms.TextBox txtStudentDisablityNotes;
        private System.Windows.Forms.GroupBox gbDisablitiyOptions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDisablitiyCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignnedDisablity;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDisabilityNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearchForCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReviewCompanyDetails;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.TextBox companySARSLevyRegistrationNumberTextBox;
        private System.Windows.Forms.TextBox companySETANumberTextBox;
        private System.Windows.Forms.TextBox companySicCodeTextBox;
    }
}

