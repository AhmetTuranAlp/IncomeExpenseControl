using IncomeExpenseControl.Common;
using IncomeExpenseControl.Data.Context;
using IncomeExpenseControl.Data.Entity;
using IncomeExpenseControl.Data.Model;
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
    public partial class Expense_Invoice_Form : Form
    {
        public Expense_Invoice_Form()
        {
            InitializeComponent();
        }
        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        EnumHelper enumHelper = new EnumHelper();
        private void Expense_Invoice_Form_Load(object sender, EventArgs e)
        {

            List<SelectListItem> expense_SuppliersList = new List<SelectListItem>();
            expense_SuppliersList.Add(new SelectListItem() { Value = "", Text = "Fatura Tipi Seçiniz..." });
            expense_SuppliersList.AddRange(enumHelper.GetEnumListWithDescription(typeof(InvoiceType)));

            cmbInvoice.DataSource = expense_SuppliersList;
            cmbInvoice.DisplayMember = "Text";
            cmbInvoice.ValueMember = "Value";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Variables
            DateTime ExpenseDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
            InvoiceType invoiceType = new  InvoiceType();
            switch (cmbInvoice.SelectedValue)
            {
                case "0":
                    invoiceType = InvoiceType.That; break;
                case "1":
                    invoiceType = InvoiceType.Electricity; break;
                case "2":
                    invoiceType = InvoiceType.NaturalGas; break;
                case "3":
                    invoiceType = InvoiceType.Internet; break;
                case "4":
                    invoiceType = InvoiceType.Other; break;
                default:
                    break;
            }


            string Descriptions = txtDescriptions.Text;
            decimal Price = nudPrice.Value;
            #endregion

            #region Service
            UnitofWork unitofWork = new UnitofWork(ctx);
            Expense_Invoice_Service expense_Invoice_Service = new Expense_Invoice_Service(unitofWork);
            TotalExpenses_Service totalExpenses_Service = new TotalExpenses_Service(unitofWork);
            #endregion

            if (Price > 0 && cmbInvoice.Text != "Fatura Tipi Seçiniz...")
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Expense_Invoice expense_Invoice = new Expense_Invoice()
                    {
                        ExpenseDate = ExpenseDate,
                        InvoiceType = invoiceType,
                        Descriptions = Descriptions,
                        Price = Price,
                        Status = Status.Active
                    };
                    if (expense_Invoice_Service.Insert(expense_Invoice))
                    {
                        TotalExpenses totalExpenses = totalExpenses_Service.GetTotalExpenses(ExpenseDate, ExpenseType.Invoice);
                        if (totalExpenses != null)
                        {
                            totalExpenses.Price += Price;
                            if (totalExpenses_Service.Update(totalExpenses))
                            {
                                MessageBox.Show("İşlem Başarılı.");

                                cmbInvoice.SelectedIndex = 0;
                                txtDescriptions.Text = "";
                                nudPrice.Value = 0;
                            }
                            else
                            {
                                MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            totalExpenses = new TotalExpenses()
                            {
                                ExpenseDate = ExpenseDate,
                                ExpenseType = ExpenseType.Invoice,
                                Price = Price,
                                Status = Status.Active,
                            };
                            if (totalExpenses_Service.Insert(totalExpenses))
                            {
                                MessageBox.Show("İşlem Başarılı.");

                                cmbInvoice.SelectedIndex = 0;
                                txtDescriptions.Text = "";
                                nudPrice.Value = 0;
                            }
                            else
                            {
                                MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

    
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
