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
    public partial class Expense_Vehicle_Form : Form
    {
        public Expense_Vehicle_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Variables
            DateTime ExpenseDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
            decimal Price = nudPrice.Value;
            string Descriptions = txtDescriptions.Text;
            #endregion

            #region Service
            UnitofWork unitofWork = new UnitofWork(ctx);
            Expense_Vehicle_Service expense_Vehicle_Service = new Expense_Vehicle_Service(unitofWork);
            TotalExpenses_Service totalExpenses_Service = new TotalExpenses_Service(unitofWork);
            #endregion

            if (Price > 0 && !string.IsNullOrEmpty(Descriptions))
            {
                Expense_Vehicle expense_Vehicle = new Expense_Vehicle()
                {
                    ExpenseDate = ExpenseDate,
                    Descriptions = Descriptions,
                    Price = Price
                };
                if (expense_Vehicle_Service.Insert(expense_Vehicle))
                {
                    TotalExpenses totalExpenses = totalExpenses_Service.GetTotalExpenses(ExpenseDate, ExpenseType.Vehicle);
                    if (totalExpenses != null)
                    {
                        totalExpenses.Price += Price;
                        if (totalExpenses_Service.Update(totalExpenses))
                        {
                            MessageBox.Show("İşlem Başarılı.");
                            
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
                            ExpenseType = ExpenseType.Vehicle,
                            Price = Price,
                            Status = Status.Active,
                        };
                        if (totalExpenses_Service.Insert(totalExpenses))
                        {
                            MessageBox.Show("İşlem Başarılı.");
                            
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
