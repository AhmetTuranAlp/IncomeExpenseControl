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
            if (ctx.CateringCompany.Count() == 0)
            {
                CateringCompany cateringCompany = new CateringCompany();
                cateringCompany.Name = "Test";
                cateringCompany.Descriptions = "Test";
                cateringCompany.CompanyCode = "Test";
                ctx.CateringCompany.Add(cateringCompany);
                ctx.SaveChanges();
            }
        }

        private void FirmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateringCompanyAddForm cateringCompanyAdd = new CateringCompanyAddForm();
            Subform(cateringCompanyAdd);
        }

        private void YemekGönderimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateringFoodDeliveryForm cateringFoodDelivery = new CateringFoodDeliveryForm();
            Subform(cateringFoodDelivery);
        }

        private void ÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateringCompanyPayment cateringCompanyPayment = new CateringCompanyPayment();
            Subform(cateringCompanyPayment);
        }
    }
}
