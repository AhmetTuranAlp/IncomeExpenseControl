using IncomeExpenseControl.Common;
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

namespace IncomeExpenseControl.WinForm
{
    public partial class Banks_Form : Form
    {
        public Banks_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();

        private void btnBankSave_Click(object sender, EventArgs e)
        {
            #region Variables
            string BankName = txtBankName.Text;
            string BankDescriptions = txtBankDescriptions.Text;
            #endregion

            #region Service
            UnitofWork unitofWork = new UnitofWork(ctx);
            Banks_Service banks_Service = new Banks_Service(unitofWork); 
            #endregion

            if (!string.IsNullOrEmpty(BankName))
            {
                Tools tools = new Tools();
                Banks banks = new Banks()
                {
                    BankCode = tools.CreateCode(),
                    BankName=BankName,
                    Descriptions = BankDescriptions
                };
                if (banks_Service.Insert(banks))
                {
                    MessageBox.Show("İşlem Başarılı.");
                    txtBankName.Text = "";
                    txtBankDescriptions.Text = "";
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
