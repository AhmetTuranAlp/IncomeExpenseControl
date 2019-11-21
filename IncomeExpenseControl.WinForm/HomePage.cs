using IncomeExpenseControl.Data.Context;
using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseControl.WinForm
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public void Subform(Form form)
        {
            try
            {
                bool status = false;
                foreach (Form element in this.MdiChildren)
                {
                    if (element.Text == form.Text)
                    {
                        status = true;
                        element.Activate();
                    }
                    else
                    {
                        element.Close();
                    }
                }
                if (status == false)
                {
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Rectangle ekran = Screen.PrimaryScreen.Bounds;

            IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
            if (ctx.Coder.Count() == 0)
            {
                Coder coder = new Coder();
                coder.Name = "Ahmet Turan";
                coder.Surname = "Alp";
                ctx.Coder.Add(coder);
                ctx.SaveChanges();
            }

        }

        private void CateringFirmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definition_CateringCompanies_Form cateringCompanies_Form = new Definition_CateringCompanies_Form();
            Subform(cateringCompanies_Form);
        }

        private void bankaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definition_Banks_Form banks_Form = new Definition_Banks_Form();
            Subform(banks_Form);
        }

        private void yemekKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definition_FoodCards_Form foodCards_Form = new Definition_FoodCards_Form();
            Subform(foodCards_Form);
        }

        private void TedarikçiFirmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definition_SupplierCompanies_Form supplierCompanies_Form = new Definition_SupplierCompanies_Form();
            Subform(supplierCompanies_Form);
        }

        private void ToplamGelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportRevenue_TotalRevenues_Form reportTotalRevenues_Form = new ReportRevenue_TotalRevenues_Form();
            Subform(reportTotalRevenues_Form);
        }

        private void CateringGelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportRevenue_CateringRevenues_Form reportCateringRevenues_Form = new ReportRevenue_CateringRevenues_Form();
            Subform(reportCateringRevenues_Form);
        }

        private void şahsiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportRevenue_Personal_Form reportPersonal_Form = new ReportRevenue_Personal_Form();
            Subform(reportPersonal_Form);
        }

        private void RestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportRevenue_Restaurant_Form reportRestaurant_Form = new ReportRevenue_Restaurant_Form();
            Subform(reportRestaurant_Form);
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definition_Staff_Form staff_Form = new Definition_Staff_Form();
            Subform(staff_Form);
        }

        private void günlükDökümGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCastingEntry_Form dailyCastingEntry_Form = new DailyCastingEntry_Form();
            Subform(dailyCastingEntry_Form);
        }

        private void GiderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense_Form expense_Form = new Expense_Form();
            Subform(expense_Form);
        }

        private void tedarikçilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportExpense_SupplierCompanies_Form reportExpense_SupplierCompanies_Form = new ReportExpense_SupplierCompanies_Form();
            Subform(reportExpense_SupplierCompanies_Form);
        }

        private void araçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportExpense_Vehicle_Form reportExpense_Vehicle_Form = new ReportExpense_Vehicle_Form();
            Subform(reportExpense_Vehicle_Form);
        }

        private void faturalarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportExpense_Invoice_Form reportExpense_Invoice_Form = new ReportExpense_Invoice_Form();
            Subform(reportExpense_Invoice_Form);
        }

        private void toplamGiderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportExpense_TotalExpenses_Form reportExpense_TotalExpenses_Form = new ReportExpense_TotalExpenses_Form();
            Subform(reportExpense_TotalExpenses_Form);
        }
    }
}
