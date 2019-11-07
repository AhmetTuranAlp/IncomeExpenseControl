using IncomeExpenseControl.Common;
using IncomeExpenseControl.Data.Context;
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
    public partial class CateringDailyTurnoverForm : Form
    {
        public CateringDailyTurnoverForm()
        {
            InitializeComponent();
        }

        private void CateringDailyTurnoverForm_Load(object sender, EventArgs e)
        {
            IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringPaymentService cateringPaymentService = new CateringPaymentService(unitofWork);
            dgwDailyTurnover.DataSource = cateringPaymentService.GetAllCateringPayment();

            #region Kolon Adı Değişenler
            dgwDailyTurnover.Columns[0].HeaderText = "Firma Adı";
            dgwDailyTurnover.Columns[2].HeaderText = "Açıklama";
            dgwDailyTurnover.Columns[3].HeaderText = "Ödeme Tarihi";
            dgwDailyTurnover.Columns[4].HeaderText = "Fiyat";
            dgwDailyTurnover.Columns[5].HeaderText = "Fatura Kesimi";
            #endregion

            #region Gizlenen Kolonlar
            dgwDailyTurnover.Columns[1].Visible = false;
            dgwDailyTurnover.Columns[6].Visible = false;
            dgwDailyTurnover.Columns[7].Visible = false;
            dgwDailyTurnover.Columns[8].Visible = false;
            dgwDailyTurnover.Columns[9].Visible = false;
            #endregion

            #region Kolon Genişlikleri Ayarlanır
            Tools tools = new Tools();
            tools.DataGridViewResize(dgwDailyTurnover, 5);
            #endregion
        }
    }
}
