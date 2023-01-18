namespace DJRental
{
    partial class frmMain
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rmDataSet = new DJRental.RmDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilityTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mileageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new DJRental.RmDataSetTableAdapters.EmployeeTableAdapter();
            this.expenseCategoryTableAdapter1 = new DJRental.RmDataSetTableAdapters.ExpenseCategoryTableAdapter();
            this.vendorTableAdapter1 = new DJRental.RmDataSetTableAdapters.VendorTableAdapter();
            this.utilityTypeTableAdapter1 = new DJRental.RmDataSetTableAdapters.UtilityTypeTableAdapter();
            this.employeeTableAdapter2 = new DJRental.RmDataSetTableAdapters.EmployeeTableAdapter();
            this.buildingTableAdapter1 = new DJRental.RmDataSetTableAdapters.BuildingTableAdapter();
            this.rentalUnitTableAdapter = new DJRental.RmDataSetTableAdapters.RentalUnitTableAdapter();
            this.expenseTableAdapter1 = new DJRental.RmDataSetTableAdapters.ExpenseTableAdapter();
            this.tenantTableAdapter1 = new DJRental.RmDataSetTableAdapters.TenantTableAdapter();
            this.leaseTypeTableAdapter1 = new DJRental.RmDataSetTableAdapters.LeaseTypeTableAdapter();
            this.leaseTypeTableAdapter2 = new DJRental.RmDataSetTableAdapters.LeaseTypeTableAdapter();
            this.mileageTableAdapter1 = new DJRental.RmDataSetTableAdapters.MileageTableAdapter();
            this.tabMileage = new System.Windows.Forms.TabPage();
            this.dataGridViewMileage = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalUnitIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.txtXValue = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtMileageAmount = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTotalMileage = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnRefreshMileage = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dateTimePickerMileageTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMileageFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSaveMileage = new System.Windows.Forms.Button();
            this.btnEditMileage = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tabLeaseType = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveLeaseType = new System.Windows.Forms.Button();
            this.btnEditLeaseType = new System.Windows.Forms.Button();
            this.dataGridViewLeaseType = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRentalUnit = new System.Windows.Forms.TabPage();
            this.dataGridViewRentalUnit = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalUnitBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.btnSaveRentalUnit = new System.Windows.Forms.Button();
            this.btnEditRentalUnit = new System.Windows.Forms.Button();
            this.tabBuildingType = new System.Windows.Forms.TabPage();
            this.dataGridViewBuildingType = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveBuildingType = new System.Windows.Forms.Button();
            this.btnEditBuildingType = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabBuilding = new System.Windows.Forms.TabPage();
            this.dataGridViewBuilding = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveBuilding = new System.Windows.Forms.Button();
            this.btnEditBuilding = new System.Windows.Forms.Button();
            this.buildingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabExpenseCategory = new System.Windows.Forms.TabPage();
            this.btnEditExpenseCategory = new System.Windows.Forms.Button();
            this.dataGridViewExpenseCategory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseCategoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveExpenseCategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabUtilityType = new System.Windows.Forms.TabPage();
            this.btnSaveUtilityType = new System.Windows.Forms.Button();
            this.btnEditUtilityType = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewUtilityType = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilityTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabVendor = new System.Windows.Forms.TabPage();
            this.btnSaveVendor = new System.Windows.Forms.Button();
            this.btnEditVendor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewVendor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabTenant = new System.Windows.Forms.TabPage();
            this.dataGridViewTenant = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveTenant = new System.Windows.Forms.Button();
            this.btnEditTenant = new System.Windows.Forms.Button();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabLease = new System.Windows.Forms.TabPage();
            this.dataGridViewLease = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalUnitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextIncreaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaseTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilityTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.btnAddToPayment = new System.Windows.Forms.Button();
            this.txtPaymentNote = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.dateTimePickerPayDate = new System.Windows.Forms.DateTimePicker();
            this.label37 = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.checkBoxInvoice = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerInvoice = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.btnRentIncrease = new System.Windows.Forms.Button();
            this.dataGridViewRentIncrease = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentIncreaseRateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveLease = new System.Windows.Forms.Button();
            this.btnEditLease = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.leaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabExpense = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaclUnitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxExpenseBuilding = new System.Windows.Forms.CheckBox();
            this.checkBoxExpenseRentalUnit = new System.Windows.Forms.CheckBox();
            this.checkBoxExpenseVendor = new System.Windows.Forms.CheckBox();
            this.checkBoxExpenseExpenseCategory = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dateTimePickerToExpense = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.dateTimePickerFromExpense = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.btnEditExpense = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.buildingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentalUnitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.expenseCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.expenseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.laundryIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainPanel = new System.Windows.Forms.TabControl();
            this.tabLaundryIncome = new System.Windows.Forms.TabPage();
            this.btnFreshLaundryIncome = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.dateLundryIncomeTo = new System.Windows.Forms.DateTimePicker();
            this.dateLundryIncomeFrom = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTotalLanduaryIncome = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSaveLanduaryIncome = new System.Windows.Forms.Button();
            this.btnEditLanduaryIncome = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridViewLanduaryIncome = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPaymentType = new System.Windows.Forms.TabPage();
            this.btnEditPaymentType = new System.Windows.Forms.Button();
            this.btnSavePaymentType = new System.Windows.Forms.Button();
            this.dataGridViewPaymentType = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.tabPaymentCategory = new System.Windows.Forms.TabPage();
            this.btnSavePaymentCategory = new System.Windows.Forms.Button();
            this.btnEditPaymentCategory = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewPaymentCategory = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTypeTableAdapter1 = new DJRental.RmDataSetTableAdapters.PaymentTypeTableAdapter();
            this.paymentCategoryTableAdapter1 = new DJRental.RmDataSetTableAdapters.PaymentCategoryTableAdapter();
            this.laundryIncomeTableAdapter1 = new DJRental.RmDataSetTableAdapters.LaundryIncomeTableAdapter();
            this.leaseTableAdapter1 = new DJRental.RmDataSetTableAdapters.LeaseTableAdapter();
            this.rentIncreaseRateTableAdapter1 = new DJRental.RmDataSetTableAdapters.RentIncreaseRateTableAdapter();
            this.rentIncreaseRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewInvoiceTableAdapter = new DJRental.RmDataSetTableAdapters.viewInvoiceTableAdapter();
            this.paymentTableAdapter1 = new DJRental.RmDataSetTableAdapters.PaymentTableAdapter();
            this.invoiceTableAdapter1 = new DJRental.RmDataSetTableAdapters.InvoiceTableAdapter();
            this.buildingTypeTableAdapter1 = new DJRental.RmDataSetTableAdapters.BuildingTypeTableAdapter();
            this.expenseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.leaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageBindingSource)).BeginInit();
            this.tabMileage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageBindingSource1)).BeginInit();
            this.tabLeaseType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaseType)).BeginInit();
            this.tabRentalUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentalUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalUnitBindingSource2)).BeginInit();
            this.tabBuildingType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuildingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingTypeBindingSource1)).BeginInit();
            this.tabBuilding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource2)).BeginInit();
            this.tabExpenseCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource2)).BeginInit();
            this.tabUtilityType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilityType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityTypeBindingSource1)).BeginInit();
            this.tabVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource2)).BeginInit();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.tabTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            this.tabLease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseBindingSource2)).BeginInit();
            this.paymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentIncreaseRateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseBindingSource)).BeginInit();
            this.tabExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalUnitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryIncomeBindingSource)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.tabLaundryIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanduaryIncome)).BeginInit();
            this.tabPaymentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
            this.tabPaymentCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentIncreaseRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(155, 218);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(73, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(47, 174);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "wcadmin";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(47, 106);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(181, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "boli";
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = " ";
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.panelLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtUserName);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(1014, 971);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Padding = new System.Windows.Forms.Padding(5);
            this.panelLogin.Size = new System.Drawing.Size(454, 235);
            this.panelLogin.TabIndex = 7;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.rmDataSet;
            this.bindingSource1.Position = 0;
            // 
            // rmDataSet
            // 
            this.rmDataSet.DataSetName = "RmDataSet";
            this.rmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentalUnitBindingSource
            // 
            this.rentalUnitBindingSource.DataMember = "RentalUnit";
            this.rentalUnitBindingSource.DataSource = this.bindingSource1;
            // 
            // leaseTypeBindingSource
            // 
            this.leaseTypeBindingSource.DataMember = "LeaseType";
            this.leaseTypeBindingSource.DataSource = this.bindingSource1;
            // 
            // mileageBindingSource
            // 
            this.mileageBindingSource.DataMember = "Mileage";
            this.mileageBindingSource.DataSource = this.bindingSource1;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // expenseCategoryTableAdapter1
            // 
            this.expenseCategoryTableAdapter1.ClearBeforeFill = true;
            // 
            // vendorTableAdapter1
            // 
            this.vendorTableAdapter1.ClearBeforeFill = true;
            // 
            // utilityTypeTableAdapter1
            // 
            this.utilityTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeTableAdapter2
            // 
            this.employeeTableAdapter2.ClearBeforeFill = true;
            // 
            // buildingTableAdapter1
            // 
            this.buildingTableAdapter1.ClearBeforeFill = true;
            // 
            // rentalUnitTableAdapter
            // 
            this.rentalUnitTableAdapter.ClearBeforeFill = true;
            // 
            // expenseTableAdapter1
            // 
            this.expenseTableAdapter1.ClearBeforeFill = true;
            // 
            // tenantTableAdapter1
            // 
            this.tenantTableAdapter1.ClearBeforeFill = true;
            // 
            // leaseTypeTableAdapter1
            // 
            this.leaseTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // leaseTypeTableAdapter2
            // 
            this.leaseTypeTableAdapter2.ClearBeforeFill = true;
            // 
            // mileageTableAdapter1
            // 
            this.mileageTableAdapter1.ClearBeforeFill = true;
            // 
            // tabMileage
            // 
            this.tabMileage.Controls.Add(this.dataGridViewMileage);
            this.tabMileage.Controls.Add(this.label27);
            this.tabMileage.Controls.Add(this.txtXValue);
            this.tabMileage.Controls.Add(this.label26);
            this.tabMileage.Controls.Add(this.txtMileageAmount);
            this.tabMileage.Controls.Add(this.label25);
            this.tabMileage.Controls.Add(this.txtTotalMileage);
            this.tabMileage.Controls.Add(this.label24);
            this.tabMileage.Controls.Add(this.btnRefreshMileage);
            this.tabMileage.Controls.Add(this.label23);
            this.tabMileage.Controls.Add(this.label22);
            this.tabMileage.Controls.Add(this.dateTimePickerMileageTo);
            this.tabMileage.Controls.Add(this.dateTimePickerMileageFrom);
            this.tabMileage.Controls.Add(this.btnSaveMileage);
            this.tabMileage.Controls.Add(this.btnEditMileage);
            this.tabMileage.Controls.Add(this.label14);
            this.tabMileage.Location = new System.Drawing.Point(4, 25);
            this.tabMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMileage.Name = "tabMileage";
            this.tabMileage.Size = new System.Drawing.Size(1840, 908);
            this.tabMileage.TabIndex = 13;
            this.tabMileage.Text = "Mileage";
            this.tabMileage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMileage
            // 
            this.dataGridViewMileage.AutoGenerateColumns = false;
            this.dataGridViewMileage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMileage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn4,
            this.employeeIDDataGridViewTextBoxColumn1,
            this.mileageDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.noteDataGridViewTextBoxColumn1,
            this.rentalUnitIDDataGridViewTextBoxColumn1,
            this.buildingIDDataGridViewTextBoxColumn1});
            this.dataGridViewMileage.DataSource = this.mileageBindingSource1;
            this.dataGridViewMileage.Location = new System.Drawing.Point(39, 116);
            this.dataGridViewMileage.Name = "dataGridViewMileage";
            this.dataGridViewMileage.RowHeadersWidth = 51;
            this.dataGridViewMileage.RowTemplate.Height = 24;
            this.dataGridViewMileage.Size = new System.Drawing.Size(1000, 189);
            this.dataGridViewMileage.TabIndex = 17;
            // 
            // iDDataGridViewTextBoxColumn4
            // 
            this.iDDataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn4.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn4.Name = "iDDataGridViewTextBoxColumn4";
            this.iDDataGridViewTextBoxColumn4.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn4.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn1
            // 
            this.employeeIDDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn1.Name = "employeeIDDataGridViewTextBoxColumn1";
            this.employeeIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // mileageDataGridViewTextBoxColumn
            // 
            this.mileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage";
            this.mileageDataGridViewTextBoxColumn.HeaderText = "Mileage";
            this.mileageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mileageDataGridViewTextBoxColumn.Name = "mileageDataGridViewTextBoxColumn";
            this.mileageDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            this.noteDataGridViewTextBoxColumn1.Width = 125;
            // 
            // rentalUnitIDDataGridViewTextBoxColumn1
            // 
            this.rentalUnitIDDataGridViewTextBoxColumn1.DataPropertyName = "RentalUnitID";
            this.rentalUnitIDDataGridViewTextBoxColumn1.HeaderText = "RentalUnitID";
            this.rentalUnitIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.rentalUnitIDDataGridViewTextBoxColumn1.Name = "rentalUnitIDDataGridViewTextBoxColumn1";
            this.rentalUnitIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // buildingIDDataGridViewTextBoxColumn1
            // 
            this.buildingIDDataGridViewTextBoxColumn1.DataPropertyName = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn1.HeaderText = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.buildingIDDataGridViewTextBoxColumn1.Name = "buildingIDDataGridViewTextBoxColumn1";
            this.buildingIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // mileageBindingSource1
            // 
            this.mileageBindingSource1.DataMember = "Mileage";
            this.mileageBindingSource1.DataSource = this.bindingSource1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(307, 501);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 20);
            this.label27.TabIndex = 16;
            this.label27.Text = "*X";
            // 
            // txtXValue
            // 
            this.txtXValue.Location = new System.Drawing.Point(363, 501);
            this.txtXValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXValue.Name = "txtXValue";
            this.txtXValue.Size = new System.Drawing.Size(95, 22);
            this.txtXValue.TabIndex = 15;
            this.txtXValue.Text = "0.57";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(749, 501);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(250, 17);
            this.label26.TabIndex = 13;
            this.label26.Text = "*Total Mileage * X = Amount of Money ";
            // 
            // txtMileageAmount
            // 
            this.txtMileageAmount.Location = new System.Drawing.Point(592, 501);
            this.txtMileageAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMileageAmount.Name = "txtMileageAmount";
            this.txtMileageAmount.Size = new System.Drawing.Size(95, 22);
            this.txtMileageAmount.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(488, 501);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 20);
            this.label25.TabIndex = 11;
            this.label25.Text = "Amount:";
            // 
            // txtTotalMileage
            // 
            this.txtTotalMileage.Location = new System.Drawing.Point(171, 501);
            this.txtTotalMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalMileage.Name = "txtTotalMileage";
            this.txtTotalMileage.Size = new System.Drawing.Size(95, 22);
            this.txtTotalMileage.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(85, 501);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 20);
            this.label24.TabIndex = 9;
            this.label24.Text = "Total:";
            // 
            // btnRefreshMileage
            // 
            this.btnRefreshMileage.Location = new System.Drawing.Point(671, 60);
            this.btnRefreshMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshMileage.Name = "btnRefreshMileage";
            this.btnRefreshMileage.Size = new System.Drawing.Size(75, 25);
            this.btnRefreshMileage.TabIndex = 8;
            this.btnRefreshMileage.Text = "Refresh";
            this.btnRefreshMileage.UseVisualStyleBackColor = true;
            this.btnRefreshMileage.Click += new System.EventHandler(this.BtnRefreshMileage_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(360, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 17);
            this.label23.TabIndex = 7;
            this.label23.Text = "To:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(55, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 17);
            this.label22.TabIndex = 6;
            this.label22.Text = "From:";
            // 
            // dateTimePickerMileageTo
            // 
            this.dateTimePickerMileageTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMileageTo.Location = new System.Drawing.Point(411, 60);
            this.dateTimePickerMileageTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerMileageTo.Name = "dateTimePickerMileageTo";
            this.dateTimePickerMileageTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerMileageTo.TabIndex = 5;
            // 
            // dateTimePickerMileageFrom
            // 
            this.dateTimePickerMileageFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMileageFrom.Location = new System.Drawing.Point(120, 60);
            this.dateTimePickerMileageFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerMileageFrom.Name = "dateTimePickerMileageFrom";
            this.dateTimePickerMileageFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerMileageFrom.TabIndex = 4;
            // 
            // btnSaveMileage
            // 
            this.btnSaveMileage.Enabled = false;
            this.btnSaveMileage.Location = new System.Drawing.Point(1300, 494);
            this.btnSaveMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveMileage.Name = "btnSaveMileage";
            this.btnSaveMileage.Size = new System.Drawing.Size(100, 30);
            this.btnSaveMileage.TabIndex = 3;
            this.btnSaveMileage.Text = "Save";
            this.btnSaveMileage.UseVisualStyleBackColor = true;
            this.btnSaveMileage.Click += new System.EventHandler(this.BtnSaveMileage_Click);
            // 
            // btnEditMileage
            // 
            this.btnEditMileage.Location = new System.Drawing.Point(1073, 494);
            this.btnEditMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditMileage.Name = "btnEditMileage";
            this.btnEditMileage.Size = new System.Drawing.Size(100, 30);
            this.btnEditMileage.TabIndex = 2;
            this.btnEditMileage.Text = "Edit..";
            this.btnEditMileage.UseVisualStyleBackColor = true;
            this.btnEditMileage.Click += new System.EventHandler(this.BtnEditMileage_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Mileage";
            // 
            // tabLeaseType
            // 
            this.tabLeaseType.Controls.Add(this.label11);
            this.tabLeaseType.Controls.Add(this.btnSaveLeaseType);
            this.tabLeaseType.Controls.Add(this.btnEditLeaseType);
            this.tabLeaseType.Controls.Add(this.dataGridViewLeaseType);
            this.tabLeaseType.Location = new System.Drawing.Point(4, 25);
            this.tabLeaseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLeaseType.Name = "tabLeaseType";
            this.tabLeaseType.Size = new System.Drawing.Size(1840, 908);
            this.tabLeaseType.TabIndex = 12;
            this.tabLeaseType.Text = "Lease Type";
            this.tabLeaseType.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Lease Type";
            // 
            // btnSaveLeaseType
            // 
            this.btnSaveLeaseType.Enabled = false;
            this.btnSaveLeaseType.Location = new System.Drawing.Point(640, 121);
            this.btnSaveLeaseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveLeaseType.Name = "btnSaveLeaseType";
            this.btnSaveLeaseType.Size = new System.Drawing.Size(100, 30);
            this.btnSaveLeaseType.TabIndex = 11;
            this.btnSaveLeaseType.Text = "Save";
            this.btnSaveLeaseType.UseVisualStyleBackColor = true;
            this.btnSaveLeaseType.Click += new System.EventHandler(this.BtnSaveLeaseType_Click);
            // 
            // btnEditLeaseType
            // 
            this.btnEditLeaseType.Location = new System.Drawing.Point(640, 60);
            this.btnEditLeaseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditLeaseType.Name = "btnEditLeaseType";
            this.btnEditLeaseType.Size = new System.Drawing.Size(100, 30);
            this.btnEditLeaseType.TabIndex = 10;
            this.btnEditLeaseType.Text = "Edit..";
            this.btnEditLeaseType.UseVisualStyleBackColor = true;
            this.btnEditLeaseType.Click += new System.EventHandler(this.BtnEditLeaseType_Click);
            // 
            // dataGridViewLeaseType
            // 
            this.dataGridViewLeaseType.AutoGenerateColumns = false;
            this.dataGridViewLeaseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaseType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn9,
            this.typeDataGridViewTextBoxColumn3});
            this.dataGridViewLeaseType.DataSource = this.leaseTypeBindingSource;
            this.dataGridViewLeaseType.Location = new System.Drawing.Point(40, 60);
            this.dataGridViewLeaseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLeaseType.Name = "dataGridViewLeaseType";
            this.dataGridViewLeaseType.ReadOnly = true;
            this.dataGridViewLeaseType.RowHeadersWidth = 51;
            this.dataGridViewLeaseType.RowTemplate.Height = 24;
            this.dataGridViewLeaseType.Size = new System.Drawing.Size(540, 380);
            this.dataGridViewLeaseType.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn9
            // 
            this.iDDataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn9.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn9.Name = "iDDataGridViewTextBoxColumn9";
            this.iDDataGridViewTextBoxColumn9.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn9.Width = 30;
            // 
            // typeDataGridViewTextBoxColumn3
            // 
            this.typeDataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn3.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn3.Name = "typeDataGridViewTextBoxColumn3";
            this.typeDataGridViewTextBoxColumn3.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn3.Width = 200;
            // 
            // tabRentalUnit
            // 
            this.tabRentalUnit.Controls.Add(this.dataGridViewRentalUnit);
            this.tabRentalUnit.Controls.Add(this.label12);
            this.tabRentalUnit.Controls.Add(this.btnSaveRentalUnit);
            this.tabRentalUnit.Controls.Add(this.btnEditRentalUnit);
            this.tabRentalUnit.Location = new System.Drawing.Point(4, 25);
            this.tabRentalUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRentalUnit.Name = "tabRentalUnit";
            this.tabRentalUnit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRentalUnit.Size = new System.Drawing.Size(1840, 908);
            this.tabRentalUnit.TabIndex = 11;
            this.tabRentalUnit.Text = "Rental Unit";
            this.tabRentalUnit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRentalUnit
            // 
            this.dataGridViewRentalUnit.AutoGenerateColumns = false;
            this.dataGridViewRentalUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentalUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn6,
            this.descriptionDataGridViewTextBoxColumn,
            this.buildingIDDataGridViewTextBoxColumn2,
            this.unitNumberDataGridViewTextBoxColumn});
            this.dataGridViewRentalUnit.DataSource = this.rentalUnitBindingSource2;
            this.dataGridViewRentalUnit.Location = new System.Drawing.Point(32, 53);
            this.dataGridViewRentalUnit.Name = "dataGridViewRentalUnit";
            this.dataGridViewRentalUnit.RowHeadersWidth = 51;
            this.dataGridViewRentalUnit.RowTemplate.Height = 24;
            this.dataGridViewRentalUnit.Size = new System.Drawing.Size(619, 150);
            this.dataGridViewRentalUnit.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn6
            // 
            this.iDDataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn6.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn6.Name = "iDDataGridViewTextBoxColumn6";
            this.iDDataGridViewTextBoxColumn6.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn6.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // buildingIDDataGridViewTextBoxColumn2
            // 
            this.buildingIDDataGridViewTextBoxColumn2.DataPropertyName = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn2.HeaderText = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.buildingIDDataGridViewTextBoxColumn2.Name = "buildingIDDataGridViewTextBoxColumn2";
            this.buildingIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // unitNumberDataGridViewTextBoxColumn
            // 
            this.unitNumberDataGridViewTextBoxColumn.DataPropertyName = "UnitNumber";
            this.unitNumberDataGridViewTextBoxColumn.HeaderText = "UnitNumber";
            this.unitNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitNumberDataGridViewTextBoxColumn.Name = "unitNumberDataGridViewTextBoxColumn";
            this.unitNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentalUnitBindingSource2
            // 
            this.rentalUnitBindingSource2.DataMember = "RentalUnit";
            this.rentalUnitBindingSource2.DataSource = this.bindingSource1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Rental Unit";
            // 
            // btnSaveRentalUnit
            // 
            this.btnSaveRentalUnit.Enabled = false;
            this.btnSaveRentalUnit.Location = new System.Drawing.Point(1000, 121);
            this.btnSaveRentalUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveRentalUnit.Name = "btnSaveRentalUnit";
            this.btnSaveRentalUnit.Size = new System.Drawing.Size(100, 30);
            this.btnSaveRentalUnit.TabIndex = 2;
            this.btnSaveRentalUnit.Text = "Save";
            this.btnSaveRentalUnit.UseVisualStyleBackColor = true;
            this.btnSaveRentalUnit.Click += new System.EventHandler(this.BtnSaveRentalUnit_Click);
            // 
            // btnEditRentalUnit
            // 
            this.btnEditRentalUnit.Location = new System.Drawing.Point(1000, 60);
            this.btnEditRentalUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRentalUnit.Name = "btnEditRentalUnit";
            this.btnEditRentalUnit.Size = new System.Drawing.Size(100, 30);
            this.btnEditRentalUnit.TabIndex = 1;
            this.btnEditRentalUnit.Text = "Edit..";
            this.btnEditRentalUnit.UseVisualStyleBackColor = true;
            this.btnEditRentalUnit.Click += new System.EventHandler(this.BtnEditRentalUnit_Click);
            // 
            // tabBuildingType
            // 
            this.tabBuildingType.Controls.Add(this.dataGridViewBuildingType);
            this.tabBuildingType.Controls.Add(this.btnSaveBuildingType);
            this.tabBuildingType.Controls.Add(this.btnEditBuildingType);
            this.tabBuildingType.Controls.Add(this.label8);
            this.tabBuildingType.Location = new System.Drawing.Point(4, 25);
            this.tabBuildingType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBuildingType.Name = "tabBuildingType";
            this.tabBuildingType.Size = new System.Drawing.Size(1840, 908);
            this.tabBuildingType.TabIndex = 5;
            this.tabBuildingType.Text = "BuildingType";
            this.tabBuildingType.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuildingType
            // 
            this.dataGridViewBuildingType.AutoGenerateColumns = false;
            this.dataGridViewBuildingType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuildingType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridViewBuildingType.DataSource = this.buildingTypeBindingSource1;
            this.dataGridViewBuildingType.Location = new System.Drawing.Point(44, 60);
            this.dataGridViewBuildingType.Name = "dataGridViewBuildingType";
            this.dataGridViewBuildingType.RowHeadersWidth = 51;
            this.dataGridViewBuildingType.RowTemplate.Height = 24;
            this.dataGridViewBuildingType.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewBuildingType.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // buildingTypeBindingSource1
            // 
            this.buildingTypeBindingSource1.DataMember = "BuildingType";
            this.buildingTypeBindingSource1.DataSource = this.bindingSource1;
            // 
            // btnSaveBuildingType
            // 
            this.btnSaveBuildingType.Enabled = false;
            this.btnSaveBuildingType.Location = new System.Drawing.Point(629, 121);
            this.btnSaveBuildingType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveBuildingType.Name = "btnSaveBuildingType";
            this.btnSaveBuildingType.Size = new System.Drawing.Size(100, 30);
            this.btnSaveBuildingType.TabIndex = 3;
            this.btnSaveBuildingType.Text = "Save";
            this.btnSaveBuildingType.UseVisualStyleBackColor = true;
            this.btnSaveBuildingType.Click += new System.EventHandler(this.BtnSaveBuildingType_Click);
            // 
            // btnEditBuildingType
            // 
            this.btnEditBuildingType.Location = new System.Drawing.Point(629, 60);
            this.btnEditBuildingType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditBuildingType.Name = "btnEditBuildingType";
            this.btnEditBuildingType.Size = new System.Drawing.Size(100, 30);
            this.btnEditBuildingType.TabIndex = 2;
            this.btnEditBuildingType.Text = "Edit..";
            this.btnEditBuildingType.UseVisualStyleBackColor = true;
            this.btnEditBuildingType.Click += new System.EventHandler(this.BtnEditBuildingType_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Building Type";
            // 
            // tabBuilding
            // 
            this.tabBuilding.Controls.Add(this.dataGridViewBuilding);
            this.tabBuilding.Controls.Add(this.label9);
            this.tabBuilding.Controls.Add(this.btnSaveBuilding);
            this.tabBuilding.Controls.Add(this.btnEditBuilding);
            this.tabBuilding.Location = new System.Drawing.Point(4, 25);
            this.tabBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBuilding.Name = "tabBuilding";
            this.tabBuilding.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBuilding.Size = new System.Drawing.Size(1840, 908);
            this.tabBuilding.TabIndex = 10;
            this.tabBuilding.Text = "Building";
            this.tabBuilding.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuilding
            // 
            this.dataGridViewBuilding.AutoGenerateColumns = false;
            this.dataGridViewBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuilding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.buildingTypeIDDataGridViewTextBoxColumn});
            this.dataGridViewBuilding.DataSource = this.buildingBindingSource3;
            this.dataGridViewBuilding.Location = new System.Drawing.Point(44, 79);
            this.dataGridViewBuilding.Name = "dataGridViewBuilding";
            this.dataGridViewBuilding.RowHeadersWidth = 51;
            this.dataGridViewBuilding.RowTemplate.Height = 24;
            this.dataGridViewBuilding.Size = new System.Drawing.Size(675, 150);
            this.dataGridViewBuilding.TabIndex = 13;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // buildingTypeIDDataGridViewTextBoxColumn
            // 
            this.buildingTypeIDDataGridViewTextBoxColumn.DataPropertyName = "BuildingTypeID";
            this.buildingTypeIDDataGridViewTextBoxColumn.HeaderText = "BuildingTypeID";
            this.buildingTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingTypeIDDataGridViewTextBoxColumn.Name = "buildingTypeIDDataGridViewTextBoxColumn";
            this.buildingTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // buildingBindingSource3
            // 
            this.buildingBindingSource3.DataMember = "Building";
            this.buildingBindingSource3.DataSource = this.bindingSource1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Building";
            // 
            // btnSaveBuilding
            // 
            this.btnSaveBuilding.Enabled = false;
            this.btnSaveBuilding.Location = new System.Drawing.Point(755, 136);
            this.btnSaveBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveBuilding.Name = "btnSaveBuilding";
            this.btnSaveBuilding.Size = new System.Drawing.Size(100, 30);
            this.btnSaveBuilding.TabIndex = 11;
            this.btnSaveBuilding.Text = "Save";
            this.btnSaveBuilding.UseVisualStyleBackColor = true;
            this.btnSaveBuilding.Click += new System.EventHandler(this.BtnSaveBuilding_Click);
            // 
            // btnEditBuilding
            // 
            this.btnEditBuilding.Location = new System.Drawing.Point(755, 79);
            this.btnEditBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditBuilding.Name = "btnEditBuilding";
            this.btnEditBuilding.Size = new System.Drawing.Size(100, 30);
            this.btnEditBuilding.TabIndex = 10;
            this.btnEditBuilding.Text = "Edit..";
            this.btnEditBuilding.UseVisualStyleBackColor = true;
            this.btnEditBuilding.Click += new System.EventHandler(this.BtnEditBuilding_Click);
            // 
            // buildingBindingSource2
            // 
            this.buildingBindingSource2.DataMember = "Building";
            this.buildingBindingSource2.DataSource = this.bindingSource1;
            // 
            // tabExpenseCategory
            // 
            this.tabExpenseCategory.Controls.Add(this.btnEditExpenseCategory);
            this.tabExpenseCategory.Controls.Add(this.dataGridViewExpenseCategory);
            this.tabExpenseCategory.Controls.Add(this.btnSaveExpenseCategory);
            this.tabExpenseCategory.Controls.Add(this.label4);
            this.tabExpenseCategory.Location = new System.Drawing.Point(4, 25);
            this.tabExpenseCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExpenseCategory.Name = "tabExpenseCategory";
            this.tabExpenseCategory.Size = new System.Drawing.Size(1840, 908);
            this.tabExpenseCategory.TabIndex = 9;
            this.tabExpenseCategory.Text = "Expense Category";
            this.tabExpenseCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditExpenseCategory
            // 
            this.btnEditExpenseCategory.Location = new System.Drawing.Point(629, 60);
            this.btnEditExpenseCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditExpenseCategory.Name = "btnEditExpenseCategory";
            this.btnEditExpenseCategory.Size = new System.Drawing.Size(100, 30);
            this.btnEditExpenseCategory.TabIndex = 4;
            this.btnEditExpenseCategory.Text = "Edit..";
            this.btnEditExpenseCategory.UseVisualStyleBackColor = true;
            this.btnEditExpenseCategory.Click += new System.EventHandler(this.BtnEditExpenseCategory_Click);
            // 
            // dataGridViewExpenseCategory
            // 
            this.dataGridViewExpenseCategory.AllowUserToDeleteRows = false;
            this.dataGridViewExpenseCategory.AutoGenerateColumns = false;
            this.dataGridViewExpenseCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenseCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataGridViewExpenseCategory.DataSource = this.expenseCategoryBindingSource2;
            this.dataGridViewExpenseCategory.Location = new System.Drawing.Point(40, 60);
            this.dataGridViewExpenseCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewExpenseCategory.Name = "dataGridViewExpenseCategory";
            this.dataGridViewExpenseCategory.ReadOnly = true;
            this.dataGridViewExpenseCategory.RowHeadersWidth = 51;
            this.dataGridViewExpenseCategory.RowTemplate.Height = 24;
            this.dataGridViewExpenseCategory.Size = new System.Drawing.Size(531, 375);
            this.dataGridViewExpenseCategory.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn11.HeaderText = "Type";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // expenseCategoryBindingSource2
            // 
            this.expenseCategoryBindingSource2.DataMember = "ExpenseCategory";
            this.expenseCategoryBindingSource2.DataSource = this.bindingSource1;
            // 
            // btnSaveExpenseCategory
            // 
            this.btnSaveExpenseCategory.Enabled = false;
            this.btnSaveExpenseCategory.Location = new System.Drawing.Point(629, 121);
            this.btnSaveExpenseCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveExpenseCategory.Name = "btnSaveExpenseCategory";
            this.btnSaveExpenseCategory.Size = new System.Drawing.Size(100, 30);
            this.btnSaveExpenseCategory.TabIndex = 2;
            this.btnSaveExpenseCategory.Text = "Save";
            this.btnSaveExpenseCategory.UseVisualStyleBackColor = true;
            this.btnSaveExpenseCategory.Click += new System.EventHandler(this.SaveExpenseCatagory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Expense Category";
            // 
            // tabUtilityType
            // 
            this.tabUtilityType.Controls.Add(this.btnSaveUtilityType);
            this.tabUtilityType.Controls.Add(this.btnEditUtilityType);
            this.tabUtilityType.Controls.Add(this.label6);
            this.tabUtilityType.Controls.Add(this.dataGridViewUtilityType);
            this.tabUtilityType.Location = new System.Drawing.Point(4, 25);
            this.tabUtilityType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUtilityType.Name = "tabUtilityType";
            this.tabUtilityType.Size = new System.Drawing.Size(1840, 908);
            this.tabUtilityType.TabIndex = 8;
            this.tabUtilityType.Text = "Utility Type";
            this.tabUtilityType.UseVisualStyleBackColor = true;
            // 
            // btnSaveUtilityType
            // 
            this.btnSaveUtilityType.Enabled = false;
            this.btnSaveUtilityType.Location = new System.Drawing.Point(629, 121);
            this.btnSaveUtilityType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveUtilityType.Name = "btnSaveUtilityType";
            this.btnSaveUtilityType.Size = new System.Drawing.Size(100, 30);
            this.btnSaveUtilityType.TabIndex = 12;
            this.btnSaveUtilityType.Text = "Save";
            this.btnSaveUtilityType.UseVisualStyleBackColor = true;
            this.btnSaveUtilityType.Click += new System.EventHandler(this.BtnSaveUtilityType_Click);
            // 
            // btnEditUtilityType
            // 
            this.btnEditUtilityType.Location = new System.Drawing.Point(629, 60);
            this.btnEditUtilityType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditUtilityType.Name = "btnEditUtilityType";
            this.btnEditUtilityType.Size = new System.Drawing.Size(100, 30);
            this.btnEditUtilityType.TabIndex = 11;
            this.btnEditUtilityType.Text = "Edit..";
            this.btnEditUtilityType.UseVisualStyleBackColor = true;
            this.btnEditUtilityType.Click += new System.EventHandler(this.BtnEditUtilityType_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Utility Type";
            // 
            // dataGridViewUtilityType
            // 
            this.dataGridViewUtilityType.AutoGenerateColumns = false;
            this.dataGridViewUtilityType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilityType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridViewUtilityType.DataSource = this.utilityTypeBindingSource1;
            this.dataGridViewUtilityType.Location = new System.Drawing.Point(40, 60);
            this.dataGridViewUtilityType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUtilityType.Name = "dataGridViewUtilityType";
            this.dataGridViewUtilityType.ReadOnly = true;
            this.dataGridViewUtilityType.RowHeadersWidth = 51;
            this.dataGridViewUtilityType.RowTemplate.Height = 24;
            this.dataGridViewUtilityType.Size = new System.Drawing.Size(531, 375);
            this.dataGridViewUtilityType.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn9.HeaderText = "Type";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // utilityTypeBindingSource1
            // 
            this.utilityTypeBindingSource1.DataMember = "UtilityType";
            this.utilityTypeBindingSource1.DataSource = this.bindingSource1;
            // 
            // tabVendor
            // 
            this.tabVendor.Controls.Add(this.btnSaveVendor);
            this.tabVendor.Controls.Add(this.btnEditVendor);
            this.tabVendor.Controls.Add(this.label5);
            this.tabVendor.Controls.Add(this.dataGridViewVendor);
            this.tabVendor.Location = new System.Drawing.Point(4, 25);
            this.tabVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVendor.Name = "tabVendor";
            this.tabVendor.Size = new System.Drawing.Size(1840, 908);
            this.tabVendor.TabIndex = 7;
            this.tabVendor.Text = "Vendor";
            this.tabVendor.UseVisualStyleBackColor = true;
            // 
            // btnSaveVendor
            // 
            this.btnSaveVendor.Enabled = false;
            this.btnSaveVendor.Location = new System.Drawing.Point(629, 121);
            this.btnSaveVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveVendor.Name = "btnSaveVendor";
            this.btnSaveVendor.Size = new System.Drawing.Size(100, 30);
            this.btnSaveVendor.TabIndex = 3;
            this.btnSaveVendor.Text = "Save";
            this.btnSaveVendor.UseVisualStyleBackColor = true;
            this.btnSaveVendor.Click += new System.EventHandler(this.BtnSaveVendor_Click);
            // 
            // btnEditVendor
            // 
            this.btnEditVendor.Location = new System.Drawing.Point(629, 60);
            this.btnEditVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditVendor.Name = "btnEditVendor";
            this.btnEditVendor.Size = new System.Drawing.Size(100, 30);
            this.btnEditVendor.TabIndex = 2;
            this.btnEditVendor.Text = "Edit..";
            this.btnEditVendor.UseVisualStyleBackColor = true;
            this.btnEditVendor.Click += new System.EventHandler(this.BtnEditVendor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vendor";
            // 
            // dataGridViewVendor
            // 
            this.dataGridViewVendor.AutoGenerateColumns = false;
            this.dataGridViewVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dataGridViewVendor.DataSource = this.vendorBindingSource2;
            this.dataGridViewVendor.Location = new System.Drawing.Point(40, 60);
            this.dataGridViewVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVendor.Name = "dataGridViewVendor";
            this.dataGridViewVendor.ReadOnly = true;
            this.dataGridViewVendor.RowHeadersWidth = 51;
            this.dataGridViewVendor.RowTemplate.Height = 24;
            this.dataGridViewVendor.Size = new System.Drawing.Size(531, 375);
            this.dataGridViewVendor.TabIndex = 0;
            this.dataGridViewVendor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn16.HeaderText = "ID";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn17.HeaderText = "Name";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // vendorBindingSource2
            // 
            this.vendorBindingSource2.DataMember = "Vendor";
            this.vendorBindingSource2.DataSource = this.bindingSource1;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.btnSaveEmployee);
            this.tabEmployee.Controls.Add(this.btnEditEmployee);
            this.tabEmployee.Controls.Add(this.label7);
            this.tabEmployee.Controls.Add(this.dataGridViewEmployee);
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(1840, 908);
            this.tabEmployee.TabIndex = 6;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Enabled = false;
            this.btnSaveEmployee.Location = new System.Drawing.Point(940, 121);
            this.btnSaveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnSaveEmployee.TabIndex = 3;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.BtnSaveEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(940, 60);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Edit..";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.BtnEditEmployee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Employee";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridViewEmployee.DataSource = this.employeeBindingSource1;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(40, 60);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(840, 375);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn18.HeaderText = "ID";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn19.HeaderText = "Name";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "UID";
            this.dataGridViewTextBoxColumn20.HeaderText = "UID";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Passwd";
            this.dataGridViewTextBoxColumn21.HeaderText = "Passwd";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "locked";
            this.dataGridViewCheckBoxColumn1.HeaderText = "locked";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.bindingSource1;
            // 
            // tabTenant
            // 
            this.tabTenant.Controls.Add(this.dataGridViewTenant);
            this.tabTenant.Controls.Add(this.label10);
            this.tabTenant.Controls.Add(this.btnSaveTenant);
            this.tabTenant.Controls.Add(this.btnEditTenant);
            this.tabTenant.Location = new System.Drawing.Point(4, 25);
            this.tabTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTenant.Name = "tabTenant";
            this.tabTenant.Size = new System.Drawing.Size(1840, 908);
            this.tabTenant.TabIndex = 4;
            this.tabTenant.Text = "Tenant";
            this.tabTenant.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTenant
            // 
            this.dataGridViewTenant.AutoGenerateColumns = false;
            this.dataGridViewTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn5,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emergencyContactDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.licensePlateDataGridViewTextBoxColumn});
            this.dataGridViewTenant.DataSource = this.tenantBindingSource1;
            this.dataGridViewTenant.Location = new System.Drawing.Point(106, 135);
            this.dataGridViewTenant.Name = "dataGridViewTenant";
            this.dataGridViewTenant.RowHeadersWidth = 51;
            this.dataGridViewTenant.RowTemplate.Height = 24;
            this.dataGridViewTenant.Size = new System.Drawing.Size(930, 157);
            this.dataGridViewTenant.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn5
            // 
            this.iDDataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn5.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn5.Name = "iDDataGridViewTextBoxColumn5";
            this.iDDataGridViewTextBoxColumn5.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn5.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emergencyContactDataGridViewTextBoxColumn
            // 
            this.emergencyContactDataGridViewTextBoxColumn.DataPropertyName = "EmergencyContact";
            this.emergencyContactDataGridViewTextBoxColumn.HeaderText = "EmergencyContact";
            this.emergencyContactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emergencyContactDataGridViewTextBoxColumn.Name = "emergencyContactDataGridViewTextBoxColumn";
            this.emergencyContactDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.Width = 125;
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            this.licensePlateDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenantBindingSource1
            // 
            this.tenantBindingSource1.DataMember = "Tenant";
            this.tenantBindingSource1.DataSource = this.bindingSource1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tenant";
            // 
            // btnSaveTenant
            // 
            this.btnSaveTenant.Enabled = false;
            this.btnSaveTenant.Location = new System.Drawing.Point(1300, 450);
            this.btnSaveTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveTenant.Name = "btnSaveTenant";
            this.btnSaveTenant.Size = new System.Drawing.Size(100, 30);
            this.btnSaveTenant.TabIndex = 2;
            this.btnSaveTenant.Text = "Save";
            this.btnSaveTenant.UseVisualStyleBackColor = true;
            this.btnSaveTenant.Click += new System.EventHandler(this.BtnSaveTenant_Click);
            // 
            // btnEditTenant
            // 
            this.btnEditTenant.Location = new System.Drawing.Point(1069, 450);
            this.btnEditTenant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditTenant.Name = "btnEditTenant";
            this.btnEditTenant.Size = new System.Drawing.Size(100, 30);
            this.btnEditTenant.TabIndex = 1;
            this.btnEditTenant.Text = "Edit..";
            this.btnEditTenant.UseVisualStyleBackColor = true;
            this.btnEditTenant.Click += new System.EventHandler(this.BtnEditTenant_Click);
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataMember = "Tenant";
            this.tenantBindingSource.DataSource = this.bindingSource1;
            // 
            // tabLease
            // 
            this.tabLease.Controls.Add(this.dataGridViewLease);
            this.tabLease.Controls.Add(this.paymentPanel);
            this.tabLease.Controls.Add(this.checkBoxInvoice);
            this.tabLease.Controls.Add(this.label35);
            this.tabLease.Controls.Add(this.dataGridViewPayment);
            this.tabLease.Controls.Add(this.dataGridViewInvoice);
            this.tabLease.Controls.Add(this.dateTimePickerInvoice);
            this.tabLease.Controls.Add(this.label34);
            this.tabLease.Controls.Add(this.btnCreateInvoice);
            this.tabLease.Controls.Add(this.btnRentIncrease);
            this.tabLease.Controls.Add(this.dataGridViewRentIncrease);
            this.tabLease.Controls.Add(this.btnSaveLease);
            this.tabLease.Controls.Add(this.btnEditLease);
            this.tabLease.Controls.Add(this.label18);
            this.tabLease.Location = new System.Drawing.Point(4, 25);
            this.tabLease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLease.Name = "tabLease";
            this.tabLease.Size = new System.Drawing.Size(1840, 908);
            this.tabLease.TabIndex = 3;
            this.tabLease.Text = "Lease";
            this.tabLease.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLease
            // 
            this.dataGridViewLease.AllowUserToDeleteRows = false;
            this.dataGridViewLease.AutoGenerateColumns = false;
            this.dataGridViewLease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.rentalUnitIDDataGridViewTextBoxColumn,
            this.tenantIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.rentDataGridViewTextBoxColumn,
            this.depositDataGridViewTextBoxColumn,
            this.nextIncreaseDateDataGridViewTextBoxColumn,
            this.newRentDataGridViewTextBoxColumn,
            this.leaseTypeIDDataGridViewTextBoxColumn,
            this.utilityTypeIDDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn2});
            this.dataGridViewLease.DataSource = this.leaseBindingSource2;
            this.dataGridViewLease.Location = new System.Drawing.Point(40, 60);
            this.dataGridViewLease.Name = "dataGridViewLease";
            this.dataGridViewLease.RowHeadersWidth = 51;
            this.dataGridViewLease.RowTemplate.Height = 24;
            this.dataGridViewLease.Size = new System.Drawing.Size(1450, 370);
            this.dataGridViewLease.TabIndex = 19;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn3.Width = 30;
            // 
            // rentalUnitIDDataGridViewTextBoxColumn
            // 
            this.rentalUnitIDDataGridViewTextBoxColumn.DataPropertyName = "RentalUnitID";
            this.rentalUnitIDDataGridViewTextBoxColumn.HeaderText = "RentalUnitID";
            this.rentalUnitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalUnitIDDataGridViewTextBoxColumn.Name = "rentalUnitIDDataGridViewTextBoxColumn";
            this.rentalUnitIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenantIDDataGridViewTextBoxColumn
            // 
            this.tenantIDDataGridViewTextBoxColumn.DataPropertyName = "TenantID";
            this.tenantIDDataGridViewTextBoxColumn.HeaderText = "TenantID";
            this.tenantIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenantIDDataGridViewTextBoxColumn.Name = "tenantIDDataGridViewTextBoxColumn";
            this.tenantIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentDataGridViewTextBoxColumn
            // 
            this.rentDataGridViewTextBoxColumn.DataPropertyName = "Rent";
            this.rentDataGridViewTextBoxColumn.HeaderText = "Rent";
            this.rentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentDataGridViewTextBoxColumn.Name = "rentDataGridViewTextBoxColumn";
            this.rentDataGridViewTextBoxColumn.Width = 125;
            // 
            // depositDataGridViewTextBoxColumn
            // 
            this.depositDataGridViewTextBoxColumn.DataPropertyName = "Deposit";
            this.depositDataGridViewTextBoxColumn.HeaderText = "Deposit";
            this.depositDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depositDataGridViewTextBoxColumn.Name = "depositDataGridViewTextBoxColumn";
            this.depositDataGridViewTextBoxColumn.Width = 125;
            // 
            // nextIncreaseDateDataGridViewTextBoxColumn
            // 
            this.nextIncreaseDateDataGridViewTextBoxColumn.DataPropertyName = "NextIncreaseDate";
            this.nextIncreaseDateDataGridViewTextBoxColumn.HeaderText = "NextIncreaseDate";
            this.nextIncreaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nextIncreaseDateDataGridViewTextBoxColumn.Name = "nextIncreaseDateDataGridViewTextBoxColumn";
            this.nextIncreaseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // newRentDataGridViewTextBoxColumn
            // 
            this.newRentDataGridViewTextBoxColumn.DataPropertyName = "NewRent";
            this.newRentDataGridViewTextBoxColumn.HeaderText = "NewRent";
            this.newRentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newRentDataGridViewTextBoxColumn.Name = "newRentDataGridViewTextBoxColumn";
            this.newRentDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaseTypeIDDataGridViewTextBoxColumn
            // 
            this.leaseTypeIDDataGridViewTextBoxColumn.DataPropertyName = "LeaseTypeID";
            this.leaseTypeIDDataGridViewTextBoxColumn.HeaderText = "LeaseTypeID";
            this.leaseTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaseTypeIDDataGridViewTextBoxColumn.Name = "leaseTypeIDDataGridViewTextBoxColumn";
            this.leaseTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // utilityTypeIDDataGridViewTextBoxColumn
            // 
            this.utilityTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UtilityTypeID";
            this.utilityTypeIDDataGridViewTextBoxColumn.HeaderText = "UtilityTypeID";
            this.utilityTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.utilityTypeIDDataGridViewTextBoxColumn.Name = "utilityTypeIDDataGridViewTextBoxColumn";
            this.utilityTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // noteDataGridViewTextBoxColumn2
            // 
            this.noteDataGridViewTextBoxColumn2.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn2.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn2.Name = "noteDataGridViewTextBoxColumn2";
            this.noteDataGridViewTextBoxColumn2.Width = 125;
            // 
            // leaseBindingSource2
            // 
            this.leaseBindingSource2.DataMember = "Lease";
            this.leaseBindingSource2.DataSource = this.bindingSource1;
            // 
            // paymentPanel
            // 
            this.paymentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentPanel.Controls.Add(this.btnAddToPayment);
            this.paymentPanel.Controls.Add(this.txtPaymentNote);
            this.paymentPanel.Controls.Add(this.label39);
            this.paymentPanel.Controls.Add(this.txtPaymentAmount);
            this.paymentPanel.Controls.Add(this.label38);
            this.paymentPanel.Controls.Add(this.dateTimePickerPayDate);
            this.paymentPanel.Controls.Add(this.label37);
            this.paymentPanel.Controls.Add(this.txtInvoiceID);
            this.paymentPanel.Controls.Add(this.label36);
            this.paymentPanel.Location = new System.Drawing.Point(1475, 517);
            this.paymentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(299, 257);
            this.paymentPanel.TabIndex = 18;
            // 
            // btnAddToPayment
            // 
            this.btnAddToPayment.Location = new System.Drawing.Point(180, 213);
            this.btnAddToPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToPayment.Name = "btnAddToPayment";
            this.btnAddToPayment.Size = new System.Drawing.Size(100, 30);
            this.btnAddToPayment.TabIndex = 8;
            this.btnAddToPayment.Text = "Add Payment";
            this.btnAddToPayment.UseVisualStyleBackColor = true;
            this.btnAddToPayment.Click += new System.EventHandler(this.BtnAddToPayment_Click);
            // 
            // txtPaymentNote
            // 
            this.txtPaymentNote.Location = new System.Drawing.Point(100, 172);
            this.txtPaymentNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentNote.Name = "txtPaymentNote";
            this.txtPaymentNote.Size = new System.Drawing.Size(100, 22);
            this.txtPaymentNote.TabIndex = 7;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(13, 172);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(42, 17);
            this.label39.TabIndex = 6;
            this.label39.Text = "Note:";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(100, 123);
            this.txtPaymentAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(100, 22);
            this.txtPaymentAmount.TabIndex = 5;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(13, 123);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(60, 17);
            this.label38.TabIndex = 4;
            this.label38.Text = "Amount:";
            // 
            // dateTimePickerPayDate
            // 
            this.dateTimePickerPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPayDate.Location = new System.Drawing.Point(100, 74);
            this.dateTimePickerPayDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerPayDate.Name = "dateTimePickerPayDate";
            this.dateTimePickerPayDate.Size = new System.Drawing.Size(131, 22);
            this.dateTimePickerPayDate.TabIndex = 3;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(13, 74);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(42, 17);
            this.label37.TabIndex = 2;
            this.label37.Text = "Date:";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(100, 25);
            this.txtInvoiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.ReadOnly = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(100, 22);
            this.txtInvoiceID.TabIndex = 1;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(13, 25);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 17);
            this.label36.TabIndex = 0;
            this.label36.Text = "InvoiceID:";
            // 
            // checkBoxInvoice
            // 
            this.checkBoxInvoice.AutoSize = true;
            this.checkBoxInvoice.Checked = true;
            this.checkBoxInvoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInvoice.Location = new System.Drawing.Point(160, 524);
            this.checkBoxInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInvoice.Name = "checkBoxInvoice";
            this.checkBoxInvoice.Size = new System.Drawing.Size(146, 21);
            this.checkBoxInvoice.TabIndex = 17;
            this.checkBoxInvoice.Text = "Show Unpaid Only";
            this.checkBoxInvoice.UseVisualStyleBackColor = true;
            this.checkBoxInvoice.CheckedChanged += new System.EventHandler(this.CheckBoxInvoice_CheckedChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(923, 534);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 20);
            this.label35.TabIndex = 12;
            this.label35.Text = "Payment";
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.AllowUserToAddRows = false;
            this.dataGridViewPayment.AutoGenerateColumns = false;
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn17,
            this.invoiceIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn3,
            this.amountDataGridViewTextBoxColumn3,
            this.notesDataGridViewTextBoxColumn2});
            this.dataGridViewPayment.DataSource = this.paymentBindingSource;
            this.dataGridViewPayment.Location = new System.Drawing.Point(927, 574);
            this.dataGridViewPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.RowHeadersWidth = 51;
            this.dataGridViewPayment.RowTemplate.Height = 24;
            this.dataGridViewPayment.Size = new System.Drawing.Size(495, 199);
            this.dataGridViewPayment.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn17
            // 
            this.iDDataGridViewTextBoxColumn17.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn17.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn17.Name = "iDDataGridViewTextBoxColumn17";
            this.iDDataGridViewTextBoxColumn17.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn17.Width = 30;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateDataGridViewTextBoxColumn3
            // 
            this.dateDataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn3.Name = "dateDataGridViewTextBoxColumn3";
            this.dateDataGridViewTextBoxColumn3.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn3
            // 
            this.amountDataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn3.Name = "amountDataGridViewTextBoxColumn3";
            this.amountDataGridViewTextBoxColumn3.Width = 70;
            // 
            // notesDataGridViewTextBoxColumn2
            // 
            this.notesDataGridViewTextBoxColumn2.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn2.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn2.Name = "notesDataGridViewTextBoxColumn2";
            this.notesDataGridViewTextBoxColumn2.Width = 150;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.bindingSource1;
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInvoice.AutoGenerateColumns = false;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn16,
            this.leaseIDDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn2,
            this.receivedAmountDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn3,
            this.notesDataGridViewTextBoxColumn1});
            this.dataGridViewInvoice.DataSource = this.viewInvoiceBindingSource;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(40, 574);
            this.dataGridViewInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowHeadersWidth = 51;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(829, 199);
            this.dataGridViewInvoice.TabIndex = 10;
            this.dataGridViewInvoice.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewInvoice_RowEnter);
            // 
            // iDDataGridViewTextBoxColumn16
            // 
            this.iDDataGridViewTextBoxColumn16.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn16.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn16.Name = "iDDataGridViewTextBoxColumn16";
            this.iDDataGridViewTextBoxColumn16.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn16.Width = 30;
            // 
            // leaseIDDataGridViewTextBoxColumn
            // 
            this.leaseIDDataGridViewTextBoxColumn.DataPropertyName = "LeaseID";
            this.leaseIDDataGridViewTextBoxColumn.HeaderText = "LeaseID";
            this.leaseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaseIDDataGridViewTextBoxColumn.Name = "leaseIDDataGridViewTextBoxColumn";
            this.leaseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaseIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // amountDataGridViewTextBoxColumn2
            // 
            this.amountDataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn2.Name = "amountDataGridViewTextBoxColumn2";
            this.amountDataGridViewTextBoxColumn2.Width = 60;
            // 
            // receivedAmountDataGridViewTextBoxColumn
            // 
            this.receivedAmountDataGridViewTextBoxColumn.DataPropertyName = "ReceivedAmount";
            this.receivedAmountDataGridViewTextBoxColumn.HeaderText = "ReceivedAmount";
            this.receivedAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receivedAmountDataGridViewTextBoxColumn.Name = "receivedAmountDataGridViewTextBoxColumn";
            this.receivedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.receivedAmountDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn3.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn1
            // 
            this.notesDataGridViewTextBoxColumn1.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn1.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn1.Name = "notesDataGridViewTextBoxColumn1";
            this.notesDataGridViewTextBoxColumn1.Width = 155;
            // 
            // viewInvoiceBindingSource
            // 
            this.viewInvoiceBindingSource.DataMember = "viewInvoice";
            this.viewInvoiceBindingSource.DataSource = this.bindingSource1;
            // 
            // dateTimePickerInvoice
            // 
            this.dateTimePickerInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInvoice.Location = new System.Drawing.Point(311, 457);
            this.dateTimePickerInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerInvoice.Name = "dateTimePickerInvoice";
            this.dateTimePickerInvoice.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerInvoice.TabIndex = 9;
            this.dateTimePickerInvoice.Value = new System.DateTime(2020, 9, 3, 14, 56, 12, 0);
            this.dateTimePickerInvoice.ValueChanged += new System.EventHandler(this.DateTimePickerInvoice_ValueChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(40, 524);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(68, 20);
            this.label34.TabIndex = 8;
            this.label34.Text = "Invoice";
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Location = new System.Drawing.Point(44, 455);
            this.btnCreateInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(261, 30);
            this.btnCreateInvoice.TabIndex = 6;
            this.btnCreateInvoice.Text = "Create Invoice  for month";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.BtnCreateInvoice_Click);
            // 
            // btnRentIncrease
            // 
            this.btnRentIncrease.Location = new System.Drawing.Point(1589, 405);
            this.btnRentIncrease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRentIncrease.Name = "btnRentIncrease";
            this.btnRentIncrease.Size = new System.Drawing.Size(204, 36);
            this.btnRentIncrease.TabIndex = 5;
            this.btnRentIncrease.Text = "Set Rent Increase";
            this.btnRentIncrease.UseVisualStyleBackColor = true;
            this.btnRentIncrease.Click += new System.EventHandler(this.BtnRentIncrease_Click);
            // 
            // dataGridViewRentIncrease
            // 
            this.dataGridViewRentIncrease.AutoGenerateColumns = false;
            this.dataGridViewRentIncrease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentIncrease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn15,
            this.yearDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.dataGridViewRentIncrease.DataSource = this.rentIncreaseRateBindingSource1;
            this.dataGridViewRentIncrease.Location = new System.Drawing.Point(1520, 234);
            this.dataGridViewRentIncrease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRentIncrease.Name = "dataGridViewRentIncrease";
            this.dataGridViewRentIncrease.RowHeadersWidth = 51;
            this.dataGridViewRentIncrease.RowTemplate.Height = 24;
            this.dataGridViewRentIncrease.Size = new System.Drawing.Size(275, 150);
            this.dataGridViewRentIncrease.TabIndex = 4;
            this.dataGridViewRentIncrease.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewRentIncrease_CellContentClick);
            this.dataGridViewRentIncrease.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewRentIncrease_RowValidated);
            // 
            // iDDataGridViewTextBoxColumn15
            // 
            this.iDDataGridViewTextBoxColumn15.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn15.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn15.Name = "iDDataGridViewTextBoxColumn15";
            this.iDDataGridViewTextBoxColumn15.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn15.Width = 30;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 60;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Width = 60;
            // 
            // rentIncreaseRateBindingSource1
            // 
            this.rentIncreaseRateBindingSource1.DataMember = "RentIncreaseRate";
            this.rentIncreaseRateBindingSource1.DataSource = this.bindingSource1;
            // 
            // btnSaveLease
            // 
            this.btnSaveLease.Enabled = false;
            this.btnSaveLease.Location = new System.Drawing.Point(1520, 117);
            this.btnSaveLease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveLease.Name = "btnSaveLease";
            this.btnSaveLease.Size = new System.Drawing.Size(100, 30);
            this.btnSaveLease.TabIndex = 3;
            this.btnSaveLease.Text = "Save";
            this.btnSaveLease.UseVisualStyleBackColor = true;
            this.btnSaveLease.Click += new System.EventHandler(this.BtnSaveLease_Click);
            // 
            // btnEditLease
            // 
            this.btnEditLease.Location = new System.Drawing.Point(1520, 60);
            this.btnEditLease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditLease.Name = "btnEditLease";
            this.btnEditLease.Size = new System.Drawing.Size(100, 30);
            this.btnEditLease.TabIndex = 2;
            this.btnEditLease.Text = "Edit..";
            this.btnEditLease.UseVisualStyleBackColor = true;
            this.btnEditLease.Click += new System.EventHandler(this.BtnEditLease_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(40, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Lease";
            // 
            // leaseBindingSource
            // 
            this.leaseBindingSource.DataMember = "Lease";
            this.leaseBindingSource.DataSource = this.bindingSource1;
            // 
            // tabExpense
            // 
            this.tabExpense.AutoScroll = true;
            this.tabExpense.Controls.Add(this.button1);
            this.tabExpense.Controls.Add(this.comboBox4);
            this.tabExpense.Controls.Add(this.comboBox3);
            this.tabExpense.Controls.Add(this.comboBox2);
            this.tabExpense.Controls.Add(this.comboBox1);
            this.tabExpense.Controls.Add(this.dataGridView1);
            this.tabExpense.Controls.Add(this.checkBoxExpenseBuilding);
            this.tabExpense.Controls.Add(this.checkBoxExpenseRentalUnit);
            this.tabExpense.Controls.Add(this.checkBoxExpenseVendor);
            this.tabExpense.Controls.Add(this.checkBoxExpenseExpenseCategory);
            this.tabExpense.Controls.Add(this.label33);
            this.tabExpense.Controls.Add(this.label32);
            this.tabExpense.Controls.Add(this.label31);
            this.tabExpense.Controls.Add(this.label30);
            this.tabExpense.Controls.Add(this.dateTimePickerToExpense);
            this.tabExpense.Controls.Add(this.label29);
            this.tabExpense.Controls.Add(this.dateTimePickerFromExpense);
            this.tabExpense.Controls.Add(this.label28);
            this.tabExpense.Controls.Add(this.btnSaveExpense);
            this.tabExpense.Controls.Add(this.btnEditExpense);
            this.tabExpense.Controls.Add(this.label13);
            this.tabExpense.Location = new System.Drawing.Point(4, 25);
            this.tabExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExpense.Name = "tabExpense";
            this.tabExpense.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExpense.Size = new System.Drawing.Size(1840, 908);
            this.tabExpense.TabIndex = 0;
            this.tabExpense.Text = "Expense";
            this.tabExpense.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1320, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(1157, 115);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 34;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(907, 115);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 33;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(670, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(427, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.employeeIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.vendorIDDataGridViewTextBoxColumn,
            this.expenseCategoryIDDataGridViewTextBoxColumn,
            this.rentaclUnitIDDataGridViewTextBoxColumn,
            this.buildingIDDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expenseBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(58, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            this.vendorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenseCategoryIDDataGridViewTextBoxColumn
            // 
            this.expenseCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "ExpenseCategoryID";
            this.expenseCategoryIDDataGridViewTextBoxColumn.HeaderText = "ExpenseCategoryID";
            this.expenseCategoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expenseCategoryIDDataGridViewTextBoxColumn.Name = "expenseCategoryIDDataGridViewTextBoxColumn";
            this.expenseCategoryIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentaclUnitIDDataGridViewTextBoxColumn
            // 
            this.rentaclUnitIDDataGridViewTextBoxColumn.DataPropertyName = "RentaclUnitID";
            this.rentaclUnitIDDataGridViewTextBoxColumn.HeaderText = "RentaclUnitID";
            this.rentaclUnitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentaclUnitIDDataGridViewTextBoxColumn.Name = "rentaclUnitIDDataGridViewTextBoxColumn";
            this.rentaclUnitIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // buildingIDDataGridViewTextBoxColumn
            // 
            this.buildingIDDataGridViewTextBoxColumn.DataPropertyName = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn.HeaderText = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingIDDataGridViewTextBoxColumn.Name = "buildingIDDataGridViewTextBoxColumn";
            this.buildingIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenseBindingSource3
            // 
            this.expenseBindingSource3.DataMember = "Expense";
            this.expenseBindingSource3.DataSource = this.bindingSource1;
            // 
            // checkBoxExpenseBuilding
            // 
            this.checkBoxExpenseBuilding.AutoSize = true;
            this.checkBoxExpenseBuilding.Checked = true;
            this.checkBoxExpenseBuilding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExpenseBuilding.Location = new System.Drawing.Point(1157, 90);
            this.checkBoxExpenseBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxExpenseBuilding.Name = "checkBoxExpenseBuilding";
            this.checkBoxExpenseBuilding.Size = new System.Drawing.Size(93, 21);
            this.checkBoxExpenseBuilding.TabIndex = 28;
            this.checkBoxExpenseBuilding.Text = "Include all";
            this.checkBoxExpenseBuilding.UseVisualStyleBackColor = true;
            this.checkBoxExpenseBuilding.CheckedChanged += new System.EventHandler(this.CheckBoxExpenseBuilding_CheckedChanged);
            // 
            // checkBoxExpenseRentalUnit
            // 
            this.checkBoxExpenseRentalUnit.AutoSize = true;
            this.checkBoxExpenseRentalUnit.Checked = true;
            this.checkBoxExpenseRentalUnit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExpenseRentalUnit.Location = new System.Drawing.Point(907, 90);
            this.checkBoxExpenseRentalUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxExpenseRentalUnit.Name = "checkBoxExpenseRentalUnit";
            this.checkBoxExpenseRentalUnit.Size = new System.Drawing.Size(93, 21);
            this.checkBoxExpenseRentalUnit.TabIndex = 27;
            this.checkBoxExpenseRentalUnit.Text = "Include all";
            this.checkBoxExpenseRentalUnit.UseVisualStyleBackColor = true;
            this.checkBoxExpenseRentalUnit.CheckedChanged += new System.EventHandler(this.CheckBoxExpenseRentalUnit_CheckedChanged);
            // 
            // checkBoxExpenseVendor
            // 
            this.checkBoxExpenseVendor.AutoSize = true;
            this.checkBoxExpenseVendor.Checked = true;
            this.checkBoxExpenseVendor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExpenseVendor.Location = new System.Drawing.Point(677, 90);
            this.checkBoxExpenseVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxExpenseVendor.Name = "checkBoxExpenseVendor";
            this.checkBoxExpenseVendor.Size = new System.Drawing.Size(93, 21);
            this.checkBoxExpenseVendor.TabIndex = 26;
            this.checkBoxExpenseVendor.Text = "Include all";
            this.checkBoxExpenseVendor.UseVisualStyleBackColor = true;
            this.checkBoxExpenseVendor.CheckedChanged += new System.EventHandler(this.CheckBoxExpenseVendor_CheckedChanged);
            // 
            // checkBoxExpenseExpenseCategory
            // 
            this.checkBoxExpenseExpenseCategory.AutoSize = true;
            this.checkBoxExpenseExpenseCategory.Checked = true;
            this.checkBoxExpenseExpenseCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExpenseExpenseCategory.Location = new System.Drawing.Point(427, 90);
            this.checkBoxExpenseExpenseCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxExpenseExpenseCategory.Name = "checkBoxExpenseExpenseCategory";
            this.checkBoxExpenseExpenseCategory.Size = new System.Drawing.Size(93, 21);
            this.checkBoxExpenseExpenseCategory.TabIndex = 25;
            this.checkBoxExpenseExpenseCategory.Text = "Include all";
            this.checkBoxExpenseExpenseCategory.UseVisualStyleBackColor = true;
            this.checkBoxExpenseExpenseCategory.CheckedChanged += new System.EventHandler(this.CheckBoxExpenseExpenseCategory_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(1147, 60);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(62, 17);
            this.label33.TabIndex = 23;
            this.label33.Text = "Building;";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(667, 60);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(58, 17);
            this.label32.TabIndex = 21;
            this.label32.Text = "Vendor:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(897, 60);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(82, 17);
            this.label31.TabIndex = 19;
            this.label31.Text = "Rental Unit:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(417, 60);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(127, 17);
            this.label30.TabIndex = 17;
            this.label30.Text = "Expense Category:";
            // 
            // dateTimePickerToExpense
            // 
            this.dateTimePickerToExpense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToExpense.Location = new System.Drawing.Point(257, 90);
            this.dateTimePickerToExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerToExpense.Name = "dateTimePickerToExpense";
            this.dateTimePickerToExpense.Size = new System.Drawing.Size(140, 22);
            this.dateTimePickerToExpense.TabIndex = 16;
            this.dateTimePickerToExpense.ValueChanged += new System.EventHandler(this.DateToExpense_ValueChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(245, 60);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 17);
            this.label29.TabIndex = 15;
            this.label29.Text = "To:";
            // 
            // dateTimePickerFromExpense
            // 
            this.dateTimePickerFromExpense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromExpense.Location = new System.Drawing.Point(75, 90);
            this.dateTimePickerFromExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFromExpense.Name = "dateTimePickerFromExpense";
            this.dateTimePickerFromExpense.Size = new System.Drawing.Size(140, 22);
            this.dateTimePickerFromExpense.TabIndex = 14;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(55, 60);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 17);
            this.label28.TabIndex = 13;
            this.label28.Text = "From:";
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.Enabled = false;
            this.btnSaveExpense.Location = new System.Drawing.Point(1300, 580);
            this.btnSaveExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(100, 30);
            this.btnSaveExpense.TabIndex = 12;
            this.btnSaveExpense.Text = "Save";
            this.btnSaveExpense.UseVisualStyleBackColor = true;
            this.btnSaveExpense.Click += new System.EventHandler(this.BtnSaveExpense_Click);
            // 
            // btnEditExpense
            // 
            this.btnEditExpense.Location = new System.Drawing.Point(1069, 580);
            this.btnEditExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.Size = new System.Drawing.Size(100, 30);
            this.btnEditExpense.TabIndex = 11;
            this.btnEditExpense.Text = "Edit..";
            this.btnEditExpense.UseVisualStyleBackColor = true;
            this.btnEditExpense.Click += new System.EventHandler(this.BtnEditExpense_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Expense";
            // 
            // buildingBindingSource1
            // 
            this.buildingBindingSource1.DataMember = "Building";
            this.buildingBindingSource1.DataSource = this.bindingSource1;
            // 
            // rentalUnitBindingSource1
            // 
            this.rentalUnitBindingSource1.DataMember = "RentalUnit";
            this.rentalUnitBindingSource1.DataSource = this.bindingSource1;
            // 
            // expenseCategoryBindingSource1
            // 
            this.expenseCategoryBindingSource1.DataMember = "ExpenseCategory";
            this.expenseCategoryBindingSource1.DataSource = this.bindingSource1;
            // 
            // expenseBindingSource2
            // 
            this.expenseBindingSource2.DataMember = "Expense";
            this.expenseBindingSource2.DataSource = this.bindingSource1;
            // 
            // vendorBindingSource1
            // 
            this.vendorBindingSource1.DataMember = "Vendor";
            this.vendorBindingSource1.DataSource = this.bindingSource1;
            // 
            // laundryIncomeBindingSource
            // 
            this.laundryIncomeBindingSource.DataMember = "LaundryIncome";
            this.laundryIncomeBindingSource.DataSource = this.bindingSource1;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tabLease);
            this.mainPanel.Controls.Add(this.tabExpense);
            this.mainPanel.Controls.Add(this.tabMileage);
            this.mainPanel.Controls.Add(this.tabLaundryIncome);
            this.mainPanel.Controls.Add(this.tabTenant);
            this.mainPanel.Controls.Add(this.tabEmployee);
            this.mainPanel.Controls.Add(this.tabVendor);
            this.mainPanel.Controls.Add(this.tabRentalUnit);
            this.mainPanel.Controls.Add(this.tabBuilding);
            this.mainPanel.Controls.Add(this.tabExpenseCategory);
            this.mainPanel.Controls.Add(this.tabBuildingType);
            this.mainPanel.Controls.Add(this.tabPaymentType);
            this.mainPanel.Controls.Add(this.tabPaymentCategory);
            this.mainPanel.Controls.Add(this.tabLeaseType);
            this.mainPanel.Controls.Add(this.tabUtilityType);
            this.mainPanel.Location = new System.Drawing.Point(37, 26);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.SelectedIndex = 0;
            this.mainPanel.Size = new System.Drawing.Size(1848, 937);
            this.mainPanel.TabIndex = 8;
            // 
            // tabLaundryIncome
            // 
            this.tabLaundryIncome.Controls.Add(this.btnFreshLaundryIncome);
            this.tabLaundryIncome.Controls.Add(this.label21);
            this.tabLaundryIncome.Controls.Add(this.dateLundryIncomeTo);
            this.tabLaundryIncome.Controls.Add(this.dateLundryIncomeFrom);
            this.tabLaundryIncome.Controls.Add(this.label20);
            this.tabLaundryIncome.Controls.Add(this.txtTotalLanduaryIncome);
            this.tabLaundryIncome.Controls.Add(this.label19);
            this.tabLaundryIncome.Controls.Add(this.btnSaveLanduaryIncome);
            this.tabLaundryIncome.Controls.Add(this.btnEditLanduaryIncome);
            this.tabLaundryIncome.Controls.Add(this.label17);
            this.tabLaundryIncome.Controls.Add(this.dataGridViewLanduaryIncome);
            this.tabLaundryIncome.Location = new System.Drawing.Point(4, 25);
            this.tabLaundryIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLaundryIncome.Name = "tabLaundryIncome";
            this.tabLaundryIncome.Size = new System.Drawing.Size(1840, 908);
            this.tabLaundryIncome.TabIndex = 17;
            this.tabLaundryIncome.Text = "Laundry Income";
            this.tabLaundryIncome.UseVisualStyleBackColor = true;
            // 
            // btnFreshLaundryIncome
            // 
            this.btnFreshLaundryIncome.Location = new System.Drawing.Point(600, 60);
            this.btnFreshLaundryIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFreshLaundryIncome.Name = "btnFreshLaundryIncome";
            this.btnFreshLaundryIncome.Size = new System.Drawing.Size(75, 25);
            this.btnFreshLaundryIncome.TabIndex = 10;
            this.btnFreshLaundryIncome.Text = "Refresh";
            this.btnFreshLaundryIncome.UseVisualStyleBackColor = true;
            this.btnFreshLaundryIncome.Click += new System.EventHandler(this.BtnFreshLaundryIncome_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(325, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 17);
            this.label21.TabIndex = 9;
            this.label21.Text = "To";
            // 
            // dateLundryIncomeTo
            // 
            this.dateLundryIncomeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLundryIncomeTo.Location = new System.Drawing.Point(375, 60);
            this.dateLundryIncomeTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateLundryIncomeTo.Name = "dateLundryIncomeTo";
            this.dateLundryIncomeTo.Size = new System.Drawing.Size(200, 22);
            this.dateLundryIncomeTo.TabIndex = 8;
            // 
            // dateLundryIncomeFrom
            // 
            this.dateLundryIncomeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLundryIncomeFrom.Location = new System.Drawing.Point(101, 62);
            this.dateLundryIncomeFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateLundryIncomeFrom.Name = "dateLundryIncomeFrom";
            this.dateLundryIncomeFrom.Size = new System.Drawing.Size(200, 22);
            this.dateLundryIncomeFrom.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 17);
            this.label20.TabIndex = 6;
            this.label20.Text = "From";
            // 
            // txtTotalLanduaryIncome
            // 
            this.txtTotalLanduaryIncome.Location = new System.Drawing.Point(221, 414);
            this.txtTotalLanduaryIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalLanduaryIncome.Name = "txtTotalLanduaryIncome";
            this.txtTotalLanduaryIncome.Size = new System.Drawing.Size(92, 22);
            this.txtTotalLanduaryIncome.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(116, 415);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Total:";
            // 
            // btnSaveLanduaryIncome
            // 
            this.btnSaveLanduaryIncome.Enabled = false;
            this.btnSaveLanduaryIncome.Location = new System.Drawing.Point(908, 148);
            this.btnSaveLanduaryIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveLanduaryIncome.Name = "btnSaveLanduaryIncome";
            this.btnSaveLanduaryIncome.Size = new System.Drawing.Size(100, 30);
            this.btnSaveLanduaryIncome.TabIndex = 3;
            this.btnSaveLanduaryIncome.Text = "Save ";
            this.btnSaveLanduaryIncome.UseVisualStyleBackColor = true;
            this.btnSaveLanduaryIncome.Click += new System.EventHandler(this.BtnSaveLanduaryIncome_Click);
            // 
            // btnEditLanduaryIncome
            // 
            this.btnEditLanduaryIncome.Location = new System.Drawing.Point(908, 103);
            this.btnEditLanduaryIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditLanduaryIncome.Name = "btnEditLanduaryIncome";
            this.btnEditLanduaryIncome.Size = new System.Drawing.Size(100, 30);
            this.btnEditLanduaryIncome.TabIndex = 2;
            this.btnEditLanduaryIncome.Text = "Edit..";
            this.btnEditLanduaryIncome.UseVisualStyleBackColor = true;
            this.btnEditLanduaryIncome.Click += new System.EventHandler(this.BtnEditLanduaryIncome_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(40, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Laundry Income";
            // 
            // dataGridViewLanduaryIncome
            // 
            this.dataGridViewLanduaryIncome.AutoGenerateColumns = false;
            this.dataGridViewLanduaryIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLanduaryIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn13,
            this.dateDataGridViewTextBoxColumn2,
            this.amountDataGridViewTextBoxColumn1,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridViewLanduaryIncome.DataSource = this.laundryIncomeBindingSource;
            this.dataGridViewLanduaryIncome.Location = new System.Drawing.Point(40, 100);
            this.dataGridViewLanduaryIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLanduaryIncome.Name = "dataGridViewLanduaryIncome";
            this.dataGridViewLanduaryIncome.ReadOnly = true;
            this.dataGridViewLanduaryIncome.RowHeadersWidth = 51;
            this.dataGridViewLanduaryIncome.RowTemplate.Height = 24;
            this.dataGridViewLanduaryIncome.Size = new System.Drawing.Size(851, 304);
            this.dataGridViewLanduaryIncome.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn13
            // 
            this.iDDataGridViewTextBoxColumn13.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn13.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn13.Name = "iDDataGridViewTextBoxColumn13";
            this.iDDataGridViewTextBoxColumn13.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn13.Width = 30;
            // 
            // dateDataGridViewTextBoxColumn2
            // 
            this.dateDataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn2.Name = "dateDataGridViewTextBoxColumn2";
            this.dateDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn2.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn1.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabPaymentType
            // 
            this.tabPaymentType.Controls.Add(this.btnEditPaymentType);
            this.tabPaymentType.Controls.Add(this.btnSavePaymentType);
            this.tabPaymentType.Controls.Add(this.dataGridViewPaymentType);
            this.tabPaymentType.Controls.Add(this.label15);
            this.tabPaymentType.Location = new System.Drawing.Point(4, 25);
            this.tabPaymentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPaymentType.Name = "tabPaymentType";
            this.tabPaymentType.Size = new System.Drawing.Size(1840, 908);
            this.tabPaymentType.TabIndex = 14;
            this.tabPaymentType.Text = "Payment Type";
            this.tabPaymentType.UseVisualStyleBackColor = true;
            // 
            // btnEditPaymentType
            // 
            this.btnEditPaymentType.Location = new System.Drawing.Point(640, 60);
            this.btnEditPaymentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPaymentType.Name = "btnEditPaymentType";
            this.btnEditPaymentType.Size = new System.Drawing.Size(100, 30);
            this.btnEditPaymentType.TabIndex = 3;
            this.btnEditPaymentType.Text = "Edit..";
            this.btnEditPaymentType.UseVisualStyleBackColor = true;
            this.btnEditPaymentType.Click += new System.EventHandler(this.BtnEditPaymentType_Click_1);
            // 
            // btnSavePaymentType
            // 
            this.btnSavePaymentType.Enabled = false;
            this.btnSavePaymentType.Location = new System.Drawing.Point(640, 121);
            this.btnSavePaymentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePaymentType.Name = "btnSavePaymentType";
            this.btnSavePaymentType.Size = new System.Drawing.Size(100, 30);
            this.btnSavePaymentType.TabIndex = 2;
            this.btnSavePaymentType.Text = "Save";
            this.btnSavePaymentType.UseVisualStyleBackColor = true;
            this.btnSavePaymentType.Click += new System.EventHandler(this.BtnSavePaymentType_Click);
            // 
            // dataGridViewPaymentType
            // 
            this.dataGridViewPaymentType.AutoGenerateColumns = false;
            this.dataGridViewPaymentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaymentType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn11,
            this.paymentTypeDataGridViewTextBoxColumn});
            this.dataGridViewPaymentType.DataSource = this.paymentTypeBindingSource;
            this.dataGridViewPaymentType.Location = new System.Drawing.Point(40, 60);
            this.dataGridViewPaymentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPaymentType.Name = "dataGridViewPaymentType";
            this.dataGridViewPaymentType.ReadOnly = true;
            this.dataGridViewPaymentType.RowHeadersWidth = 51;
            this.dataGridViewPaymentType.RowTemplate.Height = 24;
            this.dataGridViewPaymentType.Size = new System.Drawing.Size(540, 380);
            this.dataGridViewPaymentType.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn11
            // 
            this.iDDataGridViewTextBoxColumn11.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn11.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn11.Name = "iDDataGridViewTextBoxColumn11";
            this.iDDataGridViewTextBoxColumn11.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn11.Width = 30;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentTypeBindingSource
            // 
            this.paymentTypeBindingSource.DataMember = "PaymentType";
            this.paymentTypeBindingSource.DataSource = this.bindingSource1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Payment Type";
            // 
            // tabPaymentCategory
            // 
            this.tabPaymentCategory.Controls.Add(this.btnSavePaymentCategory);
            this.tabPaymentCategory.Controls.Add(this.btnEditPaymentCategory);
            this.tabPaymentCategory.Controls.Add(this.label16);
            this.tabPaymentCategory.Controls.Add(this.dataGridViewPaymentCategory);
            this.tabPaymentCategory.Location = new System.Drawing.Point(4, 25);
            this.tabPaymentCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPaymentCategory.Name = "tabPaymentCategory";
            this.tabPaymentCategory.Size = new System.Drawing.Size(1840, 908);
            this.tabPaymentCategory.TabIndex = 15;
            this.tabPaymentCategory.Text = "Payment Category";
            this.tabPaymentCategory.UseVisualStyleBackColor = true;
            // 
            // btnSavePaymentCategory
            // 
            this.btnSavePaymentCategory.Enabled = false;
            this.btnSavePaymentCategory.Location = new System.Drawing.Point(640, 121);
            this.btnSavePaymentCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePaymentCategory.Name = "btnSavePaymentCategory";
            this.btnSavePaymentCategory.Size = new System.Drawing.Size(100, 30);
            this.btnSavePaymentCategory.TabIndex = 3;
            this.btnSavePaymentCategory.Text = "Save";
            this.btnSavePaymentCategory.UseVisualStyleBackColor = true;
            this.btnSavePaymentCategory.Click += new System.EventHandler(this.BtnSavePaymentCategory_Click);
            // 
            // btnEditPaymentCategory
            // 
            this.btnEditPaymentCategory.Location = new System.Drawing.Point(640, 60);
            this.btnEditPaymentCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPaymentCategory.Name = "btnEditPaymentCategory";
            this.btnEditPaymentCategory.Size = new System.Drawing.Size(100, 30);
            this.btnEditPaymentCategory.TabIndex = 2;
            this.btnEditPaymentCategory.Text = "Edit..";
            this.btnEditPaymentCategory.UseVisualStyleBackColor = true;
            this.btnEditPaymentCategory.Click += new System.EventHandler(this.BtnEditPaymentCategory_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(40, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Payment Category";
            // 
            // dataGridViewPaymentCategory
            // 
            this.dataGridViewPaymentCategory.AutoGenerateColumns = false;
            this.dataGridViewPaymentCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaymentCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn12,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridViewPaymentCategory.DataSource = this.paymentCategoryBindingSource;
            this.dataGridViewPaymentCategory.Location = new System.Drawing.Point(40, 60);
            this.dataGridViewPaymentCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPaymentCategory.Name = "dataGridViewPaymentCategory";
            this.dataGridViewPaymentCategory.RowHeadersWidth = 51;
            this.dataGridViewPaymentCategory.RowTemplate.Height = 24;
            this.dataGridViewPaymentCategory.Size = new System.Drawing.Size(540, 380);
            this.dataGridViewPaymentCategory.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn12
            // 
            this.iDDataGridViewTextBoxColumn12.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn12.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn12.Name = "iDDataGridViewTextBoxColumn12";
            this.iDDataGridViewTextBoxColumn12.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn12.Width = 30;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 250;
            // 
            // paymentCategoryBindingSource
            // 
            this.paymentCategoryBindingSource.DataMember = "PaymentCategory";
            this.paymentCategoryBindingSource.DataSource = this.bindingSource1;
            // 
            // paymentTypeTableAdapter1
            // 
            this.paymentTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentCategoryTableAdapter1
            // 
            this.paymentCategoryTableAdapter1.ClearBeforeFill = true;
            // 
            // laundryIncomeTableAdapter1
            // 
            this.laundryIncomeTableAdapter1.ClearBeforeFill = true;
            // 
            // leaseTableAdapter1
            // 
            this.leaseTableAdapter1.ClearBeforeFill = true;
            // 
            // rentIncreaseRateTableAdapter1
            // 
            this.rentIncreaseRateTableAdapter1.ClearBeforeFill = true;
            // 
            // rentIncreaseRateBindingSource
            // 
            this.rentIncreaseRateBindingSource.DataMember = "RentIncreaseRate";
            this.rentIncreaseRateBindingSource.DataSource = this.bindingSource1;
            // 
            // viewInvoiceTableAdapter
            // 
            this.viewInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter1
            // 
            this.invoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // buildingTypeTableAdapter1
            // 
            this.buildingTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // expenseBindingSource1
            // 
            this.expenseBindingSource1.DataMember = "Expense";
            this.expenseBindingSource1.DataSource = this.bindingSource1;
            // 
            // leaseBindingSource1
            // 
            this.leaseBindingSource1.DataMember = "Lease";
            this.leaseBindingSource1.DataSource = this.bindingSource1;
            // 
            // vendorBindingSource3
            // 
            this.vendorBindingSource3.DataMember = "Vendor";
            this.vendorBindingSource3.DataSource = this.bindingSource1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1810, 1076);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Home";
            this.MaximumSizeChanged += new System.EventHandler(this.FrmMain_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageBindingSource)).EndInit();
            this.tabMileage.ResumeLayout(false);
            this.tabMileage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageBindingSource1)).EndInit();
            this.tabLeaseType.ResumeLayout(false);
            this.tabLeaseType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaseType)).EndInit();
            this.tabRentalUnit.ResumeLayout(false);
            this.tabRentalUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentalUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalUnitBindingSource2)).EndInit();
            this.tabBuildingType.ResumeLayout(false);
            this.tabBuildingType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuildingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingTypeBindingSource1)).EndInit();
            this.tabBuilding.ResumeLayout(false);
            this.tabBuilding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource2)).EndInit();
            this.tabExpenseCategory.ResumeLayout(false);
            this.tabExpenseCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource2)).EndInit();
            this.tabUtilityType.ResumeLayout(false);
            this.tabUtilityType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilityType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityTypeBindingSource1)).EndInit();
            this.tabVendor.ResumeLayout(false);
            this.tabVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource2)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.tabTenant.ResumeLayout(false);
            this.tabTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            this.tabLease.ResumeLayout(false);
            this.tabLease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseBindingSource2)).EndInit();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentIncreaseRateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseBindingSource)).EndInit();
            this.tabExpense.ResumeLayout(false);
            this.tabExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalUnitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryIncomeBindingSource)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.tabLaundryIncome.ResumeLayout(false);
            this.tabLaundryIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanduaryIncome)).EndInit();
            this.tabPaymentType.ResumeLayout(false);
            this.tabPaymentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).EndInit();
            this.tabPaymentCategory.ResumeLayout(false);
            this.tabPaymentCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentIncreaseRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RmDataSet rmDataSet;
        private RmDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private RmDataSetTableAdapters.ExpenseCategoryTableAdapter expenseCategoryTableAdapter1;
        private System.Windows.Forms.BindingSource expenseCategoryBindingSource;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private RmDataSetTableAdapters.VendorTableAdapter vendorTableAdapter1;
        private System.Windows.Forms.BindingSource utilityTypeBindingSource;
        private RmDataSetTableAdapters.UtilityTypeTableAdapter utilityTypeTableAdapter1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private RmDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter2;
        private System.Windows.Forms.BindingSource buildingTypeBindingSource;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private RmDataSetTableAdapters.BuildingTableAdapter buildingTableAdapter1;
        private RmDataSetTableAdapters.RentalUnitTableAdapter rentalUnitTableAdapter;
        private System.Windows.Forms.BindingSource rentalUnitBindingSource;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private RmDataSetTableAdapters.ExpenseTableAdapter expenseTableAdapter1;
        private RmDataSetTableAdapters.TenantTableAdapter tenantTableAdapter1;
        private System.Windows.Forms.BindingSource leaseTypeBindingSource;
        private RmDataSetTableAdapters.LeaseTypeTableAdapter leaseTypeTableAdapter1;
        private RmDataSetTableAdapters.LeaseTypeTableAdapter leaseTypeTableAdapter2;
        private System.Windows.Forms.BindingSource mileageBindingSource;
        private RmDataSetTableAdapters.MileageTableAdapter mileageTableAdapter1;
        private System.Windows.Forms.TabPage tabMileage;
        private System.Windows.Forms.Button btnSaveMileage;
        private System.Windows.Forms.Button btnEditMileage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabLeaseType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveLeaseType;
        private System.Windows.Forms.Button btnEditLeaseType;
        private System.Windows.Forms.DataGridView dataGridViewLeaseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage tabRentalUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveRentalUnit;
        private System.Windows.Forms.Button btnEditRentalUnit;
        private System.Windows.Forms.TabPage tabBuildingType;
        private System.Windows.Forms.Button btnSaveBuildingType;
        private System.Windows.Forms.Button btnEditBuildingType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabBuilding;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSaveBuilding;
        private System.Windows.Forms.Button btnEditBuilding;
        private System.Windows.Forms.TabPage tabExpenseCategory;
        private System.Windows.Forms.Button btnEditExpenseCategory;
        private System.Windows.Forms.DataGridView dataGridViewExpenseCategory;
        private System.Windows.Forms.Button btnSaveExpenseCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabUtilityType;
        private System.Windows.Forms.Button btnSaveUtilityType;
        private System.Windows.Forms.Button btnEditUtilityType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewUtilityType;
        private System.Windows.Forms.TabPage tabVendor;
        private System.Windows.Forms.Button btnSaveVendor;
        private System.Windows.Forms.Button btnEditVendor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewVendor;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TabPage tabTenant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveTenant;
        private System.Windows.Forms.Button btnEditTenant;
        private System.Windows.Forms.TabPage tabLease;
        private System.Windows.Forms.TabPage tabExpense;
        private System.Windows.Forms.Button btnSaveExpense;
        private System.Windows.Forms.Button btnEditExpense;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl mainPanel;
        private System.Windows.Forms.TabPage tabPaymentType;
        private System.Windows.Forms.Button btnEditPaymentType;
        private System.Windows.Forms.Button btnSavePaymentType;
        private System.Windows.Forms.DataGridView dataGridViewPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource;
        private System.Windows.Forms.Label label15;
        private RmDataSetTableAdapters.PaymentTypeTableAdapter paymentTypeTableAdapter1;
        private System.Windows.Forms.TabPage tabPaymentCategory;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridViewPaymentCategory;
        private System.Windows.Forms.BindingSource paymentCategoryBindingSource;
        private RmDataSetTableAdapters.PaymentCategoryTableAdapter paymentCategoryTableAdapter1;
        private System.Windows.Forms.Button btnSavePaymentCategory;
        private System.Windows.Forms.Button btnEditPaymentCategory;
        private System.Windows.Forms.TabPage tabLaundryIncome;
        private System.Windows.Forms.Button btnSaveLanduaryIncome;
        private System.Windows.Forms.Button btnEditLanduaryIncome;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridViewLanduaryIncome;
        private System.Windows.Forms.BindingSource laundryIncomeBindingSource;
        private RmDataSetTableAdapters.LaundryIncomeTableAdapter laundryIncomeTableAdapter1;
        private System.Windows.Forms.Button btnSaveLease;
        private System.Windows.Forms.Button btnEditLease;
        private System.Windows.Forms.BindingSource leaseBindingSource;
        private System.Windows.Forms.Label label18;
        private RmDataSetTableAdapters.LeaseTableAdapter leaseTableAdapter1;
        private RmDataSetTableAdapters.RentIncreaseRateTableAdapter rentIncreaseRateTableAdapter1;
        private System.Windows.Forms.BindingSource rentIncreaseRateBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewRentIncrease;
        private System.Windows.Forms.BindingSource rentIncreaseRateBindingSource1;
        private System.Windows.Forms.Button btnRentIncrease;
        //private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateLundryIncomeFrom;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTotalLanduaryIncome;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnFreshLaundryIncome;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dateLundryIncomeTo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dateTimePickerMileageTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerMileageFrom;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnRefreshMileage;
        private System.Windows.Forms.TextBox txtMileageAmount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtTotalMileage;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtXValue;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dateTimePickerToExpense;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromExpense;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        //private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxExpenseBuilding;
        private System.Windows.Forms.CheckBox checkBoxExpenseRentalUnit;
        private System.Windows.Forms.CheckBox checkBoxExpenseVendor;
        private System.Windows.Forms.CheckBox checkBoxExpenseExpenseCategory;
        private System.Windows.Forms.BindingSource expenseCategoryBindingSource1;
        private System.Windows.Forms.BindingSource buildingBindingSource1;
        private System.Windows.Forms.BindingSource vendorBindingSource1;
        private System.Windows.Forms.BindingSource rentalUnitBindingSource1;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lockedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        */
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoice;
        private System.Windows.Forms.BindingSource viewInvoiceBindingSource;
        private RmDataSetTableAdapters.viewInvoiceTableAdapter viewInvoiceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.DataGridView dataGridViewPayment;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private RmDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox checkBoxInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel paymentPanel;
        private System.Windows.Forms.Button btnAddToPayment;
        private System.Windows.Forms.TextBox txtPaymentNote;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DateTimePicker dateTimePickerPayDate;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label label36;
        private RmDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource utilityTypeBindingSource1;
        private System.Windows.Forms.BindingSource tenantBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource expenseCategoryBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.BindingSource vendorBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewBuildingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource buildingTypeBindingSource1;
        private System.Windows.Forms.BindingSource buildingBindingSource2;
        private System.Windows.Forms.BindingSource expenseBindingSource1;
        private RmDataSetTableAdapters.BuildingTypeTableAdapter buildingTypeTableAdapter1;
        private System.Windows.Forms.BindingSource leaseBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewLease;
        private System.Windows.Forms.BindingSource leaseBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalUnitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextIncreaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaseTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilityTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridViewMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalUnitIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource mileageBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tenantBindingSource1;
        private System.Windows.Forms.BindingSource expenseBindingSource2;
        private System.Windows.Forms.DataGridView dataGridViewRentalUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rentalUnitBindingSource2;
        private System.Windows.Forms.DataGridView dataGridViewBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource buildingBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseCategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaclUnitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource expenseBindingSource3;
        private System.Windows.Forms.BindingSource vendorBindingSource3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

