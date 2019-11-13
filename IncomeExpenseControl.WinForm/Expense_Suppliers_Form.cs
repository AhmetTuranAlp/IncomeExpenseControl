using IncomeExpenseControl.Data.Context;
using IncomeExpenseControl.Data.Entity;
using IncomeExpenseControl.DataAccess.Base.UnitofWork;
using IncomeExpenseControl.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.WinForm
{
    public partial class Expense_Suppliers_Form : Form
    {
        public Expense_Suppliers_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void Expense_Suppliers_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            SupplierCompanies_Service supplierCompanies_Service = new SupplierCompanies_Service(unitofWork);


            List<SupplierCompanies> expense_SuppliersList = new List<SupplierCompanies>();
            expense_SuppliersList.Add(new SupplierCompanies() { Code = "", Name = "Firma Seçiniz..." });
            expense_SuppliersList.AddRange(supplierCompanies_Service.GetAllSupplierCompanies());
            
            cmbSuppliers.DataSource = expense_SuppliersList;
            cmbSuppliers.DisplayMember = "Name";
            cmbSuppliers.ValueMember = "Code";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Variables
            DateTime ExpenseDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
            string SupplirsCode = cmbSuppliers.SelectedValue.ToString();
            decimal Price = nudPrice.Value;
            string Descriptions = txtDescriptions.Text;
            #endregion

            #region Service
            UnitofWork unitofWork = new UnitofWork(ctx);
            SupplierCompanies_Service supplierCompanies_Service = new SupplierCompanies_Service(unitofWork);
            Expense_Suppliers_Service expense_Suppliers_Service = new Expense_Suppliers_Service(unitofWork);
            TotalExpenses_Service totalExpenses_Service = new TotalExpenses_Service(unitofWork);
            #endregion

            if (!string.IsNullOrEmpty(SupplirsCode) && Price > 0)
            {
                Expense_Suppliers expense_Suppliers = new Expense_Suppliers()
                {
                    Status = Status.Active,
                    ExpenseDate = ExpenseDate,
                    Price = Price,
                    Descriptions = Descriptions,
                    SupplierCompanies = supplierCompanies_Service.GetSupplierCompanies(SupplirsCode)
                };
                if (expense_Suppliers_Service.Insert(expense_Suppliers))
                {
                    TotalExpenses totalExpenses = totalExpenses_Service.GetTotalExpenses(ExpenseDate, ExpenseType.Suppliers);
                    if (totalExpenses != null)
                    {
                        totalExpenses.Price += Price;
                        if (totalExpenses_Service.Update(totalExpenses))
                        {
                            MessageBox.Show("İşlem Başarılı.");

                            cmbSuppliers.SelectedIndex = 0;
                            txtDescriptions.Text = "";
                            nudPrice.Value = 0;
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız.");
                        }
                    }
                    else
                    {
                        totalExpenses = new TotalExpenses()
                        {
                            ExpenseDate = ExpenseDate,
                            ExpenseType = ExpenseType.Suppliers,
                            Price = Price,
                            Status = Status.Active,
                        };
                        if (totalExpenses_Service.Insert(totalExpenses))
                        {
                            MessageBox.Show("İşlem Başarılı.");

                            cmbSuppliers.SelectedIndex = 0;
                            txtDescriptions.Text = "";
                            nudPrice.Value = 0;
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız.");
                }
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.");
            }
        }
    }
}
