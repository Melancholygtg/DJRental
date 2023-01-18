using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJRental
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void login()
        {
            String user_name = txtUserName.Text.Trim();
            String password = txtPassword.Text.Trim();
            if (user_name == "")
            {
                MessageBox.Show("Please enter valid user name");
                txtUserName.Focus();
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Please enter valid password");
                txtPassword.Focus();
                return;
            }


            String filter = String.Format("[UID] = '{0}' AND [Passwd] = '{1}' AND locked=0", user_name, password);
            DataRow[] result = rmDataSet.Employee.Select(filter);


            if (result.Length < 1)
            {
                MessageBox.Show("Please enter valid user name or password");
                txtUserName.Focus();
                return;
            }

            rmDataSet.viewInvoice.Clear();
            txtInvoiceID.Clear();
            txtPaymentAmount.Clear();
            dateTimePickerPayDate.Refresh();
            rmDataSet.Payment.Clear();
            panelLogin.Hide();
            mainPanel.Show();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            login();

        }
        private void resize()
        {
            this.panelLogin.Location = new Point((this.Size.Width - panelLogin.Width) / 2, (this.Size.Height - panelLogin.Height) / 2);
            this.mainPanel.Size = new Size(this.Size.Width - 50, this.Size.Height - 70);
        }
        private void init()
        {
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'rmDataSet.Invoice' table. You can move, or remove it, as needed.
            // this.invoiceTableAdapter.Fill(this.rmDataSet.Invoice);
            String dateStartLaundryIncome = String.Format("{0}/{1}/{2}", 1, 1, DateTime.Now.Year); 
            dateLundryIncomeFrom.Text = dateStartLaundryIncome;
            String dateEndLaundryIncome = String.Format("{0}/{1}/{2}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);
            dateLundryIncomeTo.Text = dateEndLaundryIncome;
            String dateStartMileage = String.Format("{0}/{1}/{2}", 1, 1, DateTime.Now.Year);
            dateTimePickerMileageFrom.Text = dateStartMileage;
            String dateEndMileage = String.Format("{0}/{1}/{2}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);
            dateTimePickerMileageTo.Text = dateEndMileage;


            // TODO: This line of code loads data into the 'rmDataSet.RentalUnit' table. You can move, or remove it, as needed.
            this.rentalUnitTableAdapter.Fill(this.rmDataSet.RentalUnit);
            //https://stackoverflow.com/questions/9497689/update-dataset-structure-in-visual-studio-to-match-new-sql-database-structure
            employeeTableAdapter1.Fill(rmDataSet.Employee);
            expenseCategoryTableAdapter1.Fill(rmDataSet.ExpenseCategory);
            utilityTypeTableAdapter1.Fill(rmDataSet.UtilityType);
            vendorTableAdapter1.Fill(rmDataSet.Vendor);
            buildingTypeTableAdapter1.Fill(rmDataSet.BuildingType);
            buildingTableAdapter1.Fill(rmDataSet.Building);
            rentalUnitTableAdapter.Fill(rmDataSet.RentalUnit);
            tenantTableAdapter1.Fill(rmDataSet.Tenant);
            leaseTypeTableAdapter1.Fill(rmDataSet.LeaseType);
            mileageTableAdapter1.Fill(rmDataSet.Mileage);
            paymentTypeTableAdapter1.Fill(rmDataSet.PaymentType);
            paymentCategoryTableAdapter1.Fill(rmDataSet.PaymentCategory);
            expenseTableAdapter1.Fill(rmDataSet.Expense);
            leaseTableAdapter1.Fill(rmDataSet.Lease);
            rentIncreaseRateTableAdapter1.Fill(rmDataSet.RentIncreaseRate);
            laundryIncomeTableAdapter1.Fill(rmDataSet.LaundryIncome);

            dateTimePickerInvoice.Value = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddMonths(1);

            this.panelLogin.Show();
            this.mainPanel.Hide();
            this.WindowState = FormWindowState.Maximized;
            resize();
            refreshLaundryIncome();
            refreshMileageAmount();
   

        }

  
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                login();
            }
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                login();
            }
        }

        private void FrmMain_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_MaximumSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void SaveExpenseCatagory_Click(object sender, EventArgs e)
        {
            expenseCategoryTableAdapter1.Update(rmDataSet.ExpenseCategory);
            dataGridViewExpenseCategory.ReadOnly = true;
            btnEditExpenseCategory.Enabled = true;
            btnSaveExpenseCategory.Enabled = false;
        }

        private void BtnEditExpenseCategory_Click(object sender, EventArgs e)
        {
            
            dataGridViewExpenseCategory.ReadOnly = false;
            btnSaveExpenseCategory.Enabled = true;
            btnEditExpenseCategory.Enabled = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEditVendor_Click(object sender, EventArgs e)
        {
            dataGridViewVendor.ReadOnly = false;
            btnSaveVendor.Enabled = true;
            btnEditVendor.Enabled = false;
        }

        private void BtnSaveVendor_Click(object sender, EventArgs e)
        {
            vendorTableAdapter1.Update(rmDataSet.Vendor);
            dataGridViewVendor.ReadOnly = true;
            btnEditVendor.Enabled = true;
            btnSaveVendor.Enabled = false;
        }

        private void BtnEditUtilityType_Click(object sender, EventArgs e)
        {
            dataGridViewUtilityType.ReadOnly = false;
            btnSaveUtilityType.Enabled = true;
            btnEditUtilityType.Enabled = false;
        }

        private void BtnSaveUtilityType_Click(object sender, EventArgs e)
        {
            utilityTypeTableAdapter1.Update(rmDataSet.UtilityType);
            dataGridViewUtilityType.ReadOnly = true;
            btnEditUtilityType.Enabled = true;
            btnSaveUtilityType.Enabled = false;
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            dataGridViewEmployee.ReadOnly = false;
            btnSaveEmployee.Enabled = true;
            btnEditEmployee.Enabled = false;
        }

        private void BtnSaveEmployee_Click(object sender, EventArgs e)
        {
            employeeTableAdapter1.Update(rmDataSet.Employee);
            dataGridViewEmployee.ReadOnly = true;
            btnEditEmployee.Enabled = true;
            btnSaveEmployee.Enabled = false;
        }

        private void BtnEditBuildingType_Click(object sender, EventArgs e)
        {
            dataGridViewBuildingType.ReadOnly = false;

            btnSaveBuildingType.Enabled = true;
            btnEditBuildingType.Enabled = false;
        }

        private void BtnSaveBuildingType_Click(object sender, EventArgs e)
        {
            buildingTypeTableAdapter1.Update(rmDataSet.BuildingType);
            dataGridViewBuildingType.ReadOnly = true;
            btnEditBuildingType.Enabled = true;
            btnSaveBuildingType.Enabled = false;
        }

        private void BtnEditBuilding_Click(object sender, EventArgs e)
        {
   
            btnSaveBuilding.Enabled = true;
            btnEditBuilding.Enabled = false;
        }

        private void BtnSaveBuilding_Click(object sender, EventArgs e)
        {
            buildingTableAdapter1.Update(rmDataSet.Building);
    
            btnEditBuilding.Enabled = true;
            btnSaveBuilding.Enabled = false;
        }

        private void BtnEditRentalUnit_Click(object sender, EventArgs e)
        {
            dataGridViewRentalUnit.ReadOnly = false;
            btnSaveRentalUnit.Enabled = true;
            btnEditRentalUnit.Enabled = false;

        }

        private void BtnSaveRentalUnit_Click(object sender, EventArgs e)
        {
            rentalUnitTableAdapter.Update(rmDataSet.RentalUnit);
            dataGridViewRentalUnit.ReadOnly = true;
            btnEditRentalUnit.Enabled = true;
            btnSaveRentalUnit.Enabled = false;
        }

        private void BtnEditTenant_Click(object sender, EventArgs e)
        {
            dataGridViewTenant.ReadOnly = false;
            btnSaveTenant.Enabled = true;
            btnEditTenant.Enabled = false;
        }

        private void BtnSaveTenant_Click(object sender, EventArgs e)
        {
            tenantTableAdapter1.Update(rmDataSet.Tenant);
            dataGridViewTenant.ReadOnly = true;
            btnEditTenant.Enabled = true;
            btnSaveTenant.Enabled = false;
        }

        private void BtnEditLeaseType_Click(object sender, EventArgs e)
        {
            dataGridViewLeaseType.ReadOnly = false;
            btnSaveLeaseType.Enabled = true;
            btnEditLeaseType.Enabled = false;
        }

        private void BtnSaveLeaseType_Click(object sender, EventArgs e)
        {
            leaseTypeTableAdapter1.Update(rmDataSet.LeaseType);
            dataGridViewLeaseType.ReadOnly = true;
            btnEditLeaseType.Enabled = true;
            btnSaveLeaseType.Enabled = false;
        }

        private void BtnEditMileage_Click(object sender, EventArgs e)
        {
            dataGridViewMileage.ReadOnly = false;
            btnSaveMileage.Enabled = true;
            btnEditMileage.Enabled = false;
        }

        private void BtnSaveMileage_Click(object sender, EventArgs e)
        {
            mileageTableAdapter1.Update(rmDataSet.Mileage);
            dataGridViewMileage.ReadOnly = true;
            btnEditMileage.Enabled = true;
            btnSaveMileage.Enabled = false;
        }
     

        private void BtnEditPaymentType_Click_1(object sender, EventArgs e)
        {
            dataGridViewPaymentType.ReadOnly = false;
            btnSavePaymentType.Enabled = true;
            btnEditPaymentType.Enabled = false;
        }

        private void BtnSavePaymentType_Click(object sender, EventArgs e)
        {
            paymentTypeTableAdapter1.Update(rmDataSet.PaymentType);
            dataGridViewPaymentType.ReadOnly = true;
            btnEditPaymentType.Enabled = true;
            btnSavePaymentType.Enabled = false;
        }

        private void BtnEditPaymentCategory_Click(object sender, EventArgs e)
        {
            dataGridViewPaymentCategory.ReadOnly = false;
            btnSavePaymentType.Enabled = true;
            btnEditPaymentCategory.Enabled = false;
        }

        private void BtnSavePaymentCategory_Click(object sender, EventArgs e)
        {
            paymentCategoryTableAdapter1.Update(rmDataSet.PaymentCategory);
            dataGridViewPaymentType.ReadOnly = true;
            btnEditPaymentType.Enabled = true;
            btnSavePaymentCategory.Enabled = false;
        }

        private void BtnEditLanduaryIncome_Click(object sender, EventArgs e)
        {
            dataGridViewLanduaryIncome.ReadOnly = false;
            btnSaveLanduaryIncome.Enabled = true;
            btnEditLanduaryIncome.Enabled = false;
        }

        private void BtnSaveLanduaryIncome_Click(object sender, EventArgs e)
        {
            laundryIncomeTableAdapter1.Update(rmDataSet.LaundryIncome);
            dataGridViewLanduaryIncome.ReadOnly = true;
            btnEditLanduaryIncome.Enabled = true;
            btnSaveLanduaryIncome.Enabled = false;
        }

        private void BtnEditLease_Click(object sender, EventArgs e)
        {
            //dataGridViewLease.ReadOnly = false;
            btnSaveLease.Enabled = true;
            btnEditLease.Enabled = false;
        }

        private void BtnSaveLease_Click(object sender, EventArgs e)
        {
            leaseTableAdapter1.Update(rmDataSet.Lease);
            //dataGridViewLease.ReadOnly = true;
            btnEditLease.Enabled = true;
            btnSaveLease.Enabled = false;
        }

        private void DataGridViewRentIncrease_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            rentIncreaseRateTableAdapter1.Update(rmDataSet.RentIncreaseRate);
        }

        private void BtnRentIncrease_Click(object sender, EventArgs e)
        {
            if ( dataGridViewRentIncrease.SelectedRows.Count == 1)
            {
                // String rate =  dataGridViewRentIncrease.SelectedRows[0].Cells[2].ToString();
                //MessageBox.Show(""+rate);
                DataGridViewRow row = this.dataGridViewRentIncrease.SelectedRows[0];
                String rate = row.Cells[2].Value.ToString();
                Double factor = 1+ Double.Parse(rate) * 0.01;
                foreach (DataRow r in rmDataSet.Lease.Rows)
                {
                    double new_rent = (int)(factor * Double.Parse(r["Rent"].ToString()));
                    r["NewRent"] = new_rent;

                }
                leaseTableAdapter1.Update(rmDataSet.Lease);

                
            } else
            {
                MessageBox.Show("Please select the Rate increase of a year.");
            }
        }

        private void BtnEditExpense_Click(object sender, EventArgs e)
        {
            
            btnSaveExpense.Enabled = true;
            btnEditExpense.Enabled = false;
        }

        private void BtnSaveExpense_Click(object sender, EventArgs e)
        {
            expenseTableAdapter1.Update(rmDataSet.Expense);
          
            btnEditExpense.Enabled = true;
            btnSaveExpense.Enabled = false;
        }

        private void refreshLaundryIncome()
        {
            //set filter by using date
            //calculate total
            
            String startDateLaundryIncome = dateLundryIncomeFrom.Text;
            if (startDateLaundryIncome == null || startDateLaundryIncome == "")
            {
                startDateLaundryIncome = String.Format("{0}/{1}/{2}", 1, 1, DateTime.Now.Year);
            }
            String endDateLaundryIncome = dateLundryIncomeTo.Text;
            if (endDateLaundryIncome == null || endDateLaundryIncome == "")
            {
                endDateLaundryIncome = String.Format("{0}/{1}/{2}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);
            }
            DateTime datelaundryincomefrom = Convert.ToDateTime(startDateLaundryIncome);
            DateTime datelaundryincomeTo = Convert.ToDateTime(endDateLaundryIncome);
            rmDataSet.LaundryIncome.Clear();
            String sql = String.Format("select * from LaundryIncome where [date] >= '{0}' and  date <= '{1}'", startDateLaundryIncome, endDateLaundryIncome);
            laundryIncomeTableAdapter1.Adapter.SelectCommand.CommandText = sql;
            laundryIncomeTableAdapter1.Fill(rmDataSet.LaundryIncome);
            double totalLaundryIncome = 0;
            foreach (DataRow d in rmDataSet.LaundryIncome)
            {
                totalLaundryIncome += (int)(Double.Parse(d["Amount"].ToString()));
            }
            txtTotalLanduaryIncome.Text = string.Format("{0:N2}", totalLaundryIncome);
            laundryIncomeTableAdapter1.Update(rmDataSet.LaundryIncome);

        }
        private void BtnFreshLaundryIncome_Click(object sender, EventArgs e)
        {
            refreshLaundryIncome();
        }

        private void BtnRefreshMileage_Click(object sender, EventArgs e)
        {
            refreshMileageAmount();
        }
        private void refreshMileageAmount()
        {
            String startDateMileage = dateTimePickerMileageFrom.Text;
            if (startDateMileage == null || startDateMileage == "")
            {
                startDateMileage = String.Format("{0}/{1}/{2}", 1, 1, DateTime.Now.Year);
            }
            String endDateMileage = dateTimePickerMileageTo.Text;
            if (endDateMileage == null || endDateMileage == "")
            {
                endDateMileage = String.Format("{0}/{1}/{2}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);
            }
            DateTime dateMileagerrom = Convert.ToDateTime(startDateMileage);
            DateTime dateMileageto = Convert.ToDateTime(endDateMileage);
            rmDataSet.Mileage.Clear();
            String sql = String.Format("select * from Mileage where [date] >= '{0}' and  date <= '{1}'", startDateMileage, endDateMileage);
            mileageTableAdapter1.Adapter.SelectCommand.CommandText = sql;
            mileageTableAdapter1.Fill(rmDataSet.Mileage);
            double totalMileage = 0;
            foreach (DataRow d in rmDataSet.Mileage)
            {
                totalMileage += (int)(Double.Parse(d["Mileage"].ToString()));
            }
            txtTotalMileage.Text = string.Format("{0:N2}", totalMileage);
            Double x =Double.Parse(txtXValue.Text.ToString());
            txtMileageAmount.Text = string.Format("{0:N2}", totalMileage * x);
            laundryIncomeTableAdapter1.Update(rmDataSet.LaundryIncome);
        }

        private void CheckBoxExpenseExpenseCategory_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CheckBoxExpenseVendor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxExpenseRentalUnit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxExpenseBuilding_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DateToExpense_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RefreshExpense_Click(object sender, EventArgs e)
        {
            /*
               
            String startDateExpense = dateTimePickerFromExpense.Text;
            if (startDateExpense == null || startDateExpense == "")
            {
                startDateExpense = String.Format("{0}/{1}/{2}", 1, 1, DateTime.Now.Year);
            }
            String endDateExpense = dateTimePickerToExpense.Text;
            if (endDateExpense == null || endDateExpense == "")
            {
                endDateExpense = String.Format("{0}/{1}/{2}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);
            }
            DateTime dateMileagerrom = Convert.ToDateTime(startDateExpense);
            DateTime dateMileageto = Convert.ToDateTime(endDateExpense);
            rmDataSet.Expense.Clear();
            String sql = String.Format("select * from Expense where [date] >= '{0}' and  [date] <= '{1}' ", startDateExpense, endDateExpense);
           
            if (!checkBoxExpenseExpenseCategory.Checked)
            {
                if (comboBoxExpenseExpenseCategory.SelectedIndex>=0)
                {
                    sql += " and [ExpenseCategoryID] = " + comboBoxExpenseExpenseCategory.SelectedValue;
                }
            }
            if (!checkBoxExpenseVendor.Checked)
            {
                if (comboBoxExpenseVendor.SelectedIndex >= 0)
                {
                    sql += " and [VendorID] = " + comboBoxExpenseVendor.SelectedValue;
                }
            }
            if (!checkBoxExpenseRentalUnit.Checked)
            {
                if (comboBoxExpenseRentalUnit.SelectedIndex >= 0)
                {
                    sql += " and [RentalUnitID] = " + comboBoxExpenseRentalUnit;
                }
            }
            if (!checkBoxExpenseBuilding.Checked)
            {
                if (comboBoxExpenseBuilding.SelectedIndex >= 0)
                {
                    sql += " and [BuildingID] = " + comboBoxExpenseBuilding;
                }
            }
            expenseTableAdapter1.Adapter.SelectCommand.CommandText = sql;
            expenseTableAdapter1.Fill(rmDataSet.Expense);
            expenseTableAdapter1.Update(rmDataSet.Expense);
            */
            
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.expenseCategoryTableAdapter1.FillBy(this.rmDataSet.ExpenseCategory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            

        }

        private void DateTimePickerInvoice_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerInvoice.Text = (new DateTime(dateTimePickerInvoice.Value.Year, dateTimePickerInvoice.Value.Month, 1)).ToShortDateString();

        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {
            String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DJRental.Properties.Settings.RmConnectionString"].ConnectionString;
            String dueDateInvoice = dateTimePickerInvoice.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                String sql = String.Format("create_invoice");
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("month", dueDateInvoice);
                cmd.ExecuteNonQuery();
            } catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            
            } finally
            {
                conn.Close();
            }
        }

        private void DataGridViewLease_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Object id = 0;
               //dataGridViewLease.Rows[e.RowIndex].Cells[0].Value;
                if (id != null)
                {
                    // MessageBox.Show("" + id);
                    rmDataSet.viewInvoice.Clear();
                    String sql = String.Format("select * from viewInvoice where LeaseId=" + id);
                    if (viewInvoiceTableAdapter.Adapter.SelectCommand != null)
                    {
                        viewInvoiceTableAdapter.Adapter.SelectCommand.CommandText = sql;
                        viewInvoiceTableAdapter.Fill(rmDataSet.viewInvoice);
                    } else
                    {
                        viewInvoiceTableAdapter.Adapter.SelectCommand =  new SqlCommand(sql);
                        viewInvoiceTableAdapter.Fill(rmDataSet.viewInvoice);
                    }

                } else
                {
                    rmDataSet.viewInvoice.Clear();
                }
            }
            

        }

        
        private void CheckBoxInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInvoice.Checked)
            {

            }
        }

        private void DataGridViewInvoice_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                Object id = dataGridViewInvoice.Rows[e.RowIndex].Cells[0].Value;
                Object receivedAmountObj = dataGridViewInvoice.Rows[e.RowIndex].Cells[4].Value;
                double rent = Convert.ToDouble(dataGridViewInvoice.Rows[e.RowIndex].Cells[3].Value);
                double receivedAmount = 0;   
                if (receivedAmountObj.ToString()!="")
                {
                    receivedAmount = Double.Parse(receivedAmountObj.ToString());
                }
                if (id != null)
                {
                    rmDataSet.Payment.Clear();
                    String sql = String.Format("select * from Payment where InvoiceId=" + id);
                    if (receivedAmount.Equals(null) || receivedAmount < rent)
                    {
                        
                        txtInvoiceID.Text = id.ToString();
                        txtPaymentAmount.Text = "" + (rent - receivedAmount);
                        this.dateTimePickerPayDate.Value = DateTime.Now;
                    }
                    if (paymentTableAdapter1.Adapter.SelectCommand != null)
                    {
                        paymentTableAdapter1.Adapter.SelectCommand.CommandText = sql;
                        paymentTableAdapter1.Fill(rmDataSet.Payment);
                    }
                    else
                    {
                        paymentTableAdapter1.Adapter.SelectCommand = new SqlCommand(sql);
                        paymentTableAdapter1.Fill(rmDataSet.Payment);
                    }


                }
                else
                {
                    rmDataSet.Payment.Clear();
                }

            }
        }

        private void BtnAddToPayment_Click(object sender, EventArgs e)
        {
            rmDataSet.Payment.Clear();
            String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DJRental.Properties.Settings.RmConnectionString"].ConnectionString;
            String invoice_ID = txtInvoiceID.Text;
            String paydate = dateTimePickerPayDate.Text;
            String amount = txtPaymentAmount.Text;
            String note = txtPaymentNote.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                String sql = String.Format("create_payment");
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@invoice_id", invoice_ID);
                cmd.Parameters.AddWithValue("date", paydate);
                cmd.Parameters.AddWithValue("amount", amount);
                cmd.Parameters.AddWithValue("note", note);
                cmd.ExecuteNonQuery();
                paymentTableAdapter1.Fill(rmDataSet.Payment);
                viewInvoiceTableAdapter.Fill(rmDataSet.viewInvoice);              
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());

            }
            finally
            {
                conn.Close();
            }
        }

        private void DataGridViewRentIncrease_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
