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
                Coder coder = new Coder();
                coder.Name = "Ahmet Turan";
                coder.Surname = "Alp";
                ctx.Coder.Add(coder);
                ctx.SaveChanges();
            }
        }

        private void CateringToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CateringCompanyPaymentForm cateringCompanyPayment = new CateringCompanyPaymentForm();
            Subform(cateringCompanyPayment);
        }

        private void YemekGönderimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateringFoodDeliveryForm cateringFoodDelivery = new CateringFoodDeliveryForm();
            Subform(cateringFoodDelivery);
        }

        private void FirmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateringCompanySettingsForm cateringCompanyAdd = new CateringCompanySettingsForm();
            Subform(cateringCompanyAdd);
        }

        private void AylıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateringMonthlyTurnoverForm cateringMonthlyTurnoverForm = new CateringMonthlyTurnoverForm();
            Subform(cateringMonthlyTurnoverForm);
        }

        private void GünlükRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateringDailyTurnoverForm cateringDailyTurnoverForm = new CateringDailyTurnoverForm();
            Subform(cateringDailyTurnoverForm);
        }

        private void HizmetRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CateringServiceReportForm cateringServiceReportForm = new CateringServiceReportForm();
            Subform(cateringServiceReportForm);
        }
    }
}
