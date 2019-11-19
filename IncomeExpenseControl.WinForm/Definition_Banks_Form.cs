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
    public partial class Definition_Banks_Form : Form
    {
        public Definition_Banks_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();

        private void Banks_Form_Load(object sender, EventArgs e)
        {

        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region Variables
            string BankName = txtName.Text;
            string BankDescriptions = txtDescriptions.Text;
            #endregion

            if (!string.IsNullOrEmpty(BankName))
            {

                DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    #region Service
                    UnitofWork unitofWork = new UnitofWork(ctx);
                    Banks_Service banks_Service = new Banks_Service(unitofWork);
                    #endregion
                    Tools tools = new Tools();
                    Banks banks = new Banks()
                    {
                        BankCode = tools.CreateCode(),
                        BankName = BankName,
                        Descriptions = BankDescriptions
                    };
                    if (banks_Service.Insert(banks))
                    {
                        MessageBox.Show("İşlem Başarılı.");
                        txtName.Text = "";
                        txtDescriptions.Text = "";
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDescriptions.Text = "";
        }
    }
}
