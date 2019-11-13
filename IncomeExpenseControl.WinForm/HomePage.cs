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

        private void ŞahsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCastingEntry_Personal_Form dailyCastingEntry_Personal_Form = new DailyCastingEntry_Personal_Form();
            Subform(dailyCastingEntry_Personal_Form);
        }

        private void cateringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCastingEntry_Catering_Form dailyCastingEntry_Catering_Form = new DailyCastingEntry_Catering_Form();
            Subform(dailyCastingEntry_Catering_Form);
        }

        private void CateringFirmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateringCompanies_Form cateringCompanies_Form = new CateringCompanies_Form();
            Subform(cateringCompanies_Form);
        }

        private void NakitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCastingEntry_Restaurant_Cash_Form dailyCastingEntry_Restaurant_Cash_Form = new DailyCastingEntry_Restaurant_Cash_Form();
            Subform(dailyCastingEntry_Restaurant_Cash_Form);
        }

        private void bankaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banks_Form banks_Form = new Banks_Form();
            Subform(banks_Form);
        }

        private void krediKartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCastingEntry_Restaurant_Bank_Form dailyCastingEntry_Restaurant_Bank_Form = new DailyCastingEntry_Restaurant_Bank_Form();
            Subform(dailyCastingEntry_Restaurant_Bank_Form);
        }

        private void yemekKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodCards_Form foodCards_Form = new FoodCards_Form();
            Subform(foodCards_Form);
        }

        private void yemekKarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCastingEntry_Restaurant_Food_Form dailyCastingEntry_Restaurant_Food_Form = new DailyCastingEntry_Restaurant_Food_Form();
            Subform(dailyCastingEntry_Restaurant_Food_Form);
        }

        private void TedarikçiFirmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierCompanies_Form supplierCompanies_Form = new SupplierCompanies_Form();
            Subform(supplierCompanies_Form);
        }

        private void tedarikçilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense_Suppliers_Form expense_Suppliers_Form = new Expense_Suppliers_Form();
            Subform(expense_Suppliers_Form);
        }

        private void araçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense_Vehicle_Form expense_Vehicle_Form = new Expense_Vehicle_Form();
            Subform(expense_Vehicle_Form);
        }

        private void faturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense_Invoice_Form expense_Invoice_Form = new Expense_Invoice_Form();
            Subform(expense_Invoice_Form);
        }
    }
}
