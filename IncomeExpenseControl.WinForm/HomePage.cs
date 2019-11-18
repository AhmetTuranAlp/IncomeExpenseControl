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
            CateringCompanies_Form cateringCompanies_Form = new CateringCompanies_Form();
            Subform(cateringCompanies_Form);
        }

        private void bankaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banks_Form banks_Form = new Banks_Form();
            Subform(banks_Form);
        }

        private void yemekKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodCards_Form foodCards_Form = new FoodCards_Form();
            Subform(foodCards_Form);
        }

        private void TedarikçiFirmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierCompanies_Form supplierCompanies_Form = new SupplierCompanies_Form();
            Subform(supplierCompanies_Form);
        }

        private void ToplamGelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportTotalRevenues_Form reportTotalRevenues_Form = new ReportTotalRevenues_Form();
            Subform(reportTotalRevenues_Form);
        }

        private void CateringGelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCateringRevenues_Form reportCateringRevenues_Form = new ReportCateringRevenues_Form();
            Subform(reportCateringRevenues_Form);
        }

        private void şahsiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportPersonal_Form reportPersonal_Form = new ReportPersonal_Form();
            Subform(reportPersonal_Form);
        }

        private void RestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportRestaurant_Form reportRestaurant_Form = new ReportRestaurant_Form();
            Subform(reportRestaurant_Form);
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_Form staff_Form = new Staff_Form();
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
    }
}
