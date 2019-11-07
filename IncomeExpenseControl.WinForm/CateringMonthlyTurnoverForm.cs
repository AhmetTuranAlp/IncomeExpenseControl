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
    public partial class CateringMonthlyTurnoverForm : Form
    {
        public CateringMonthlyTurnoverForm()
        {
            InitializeComponent();
        }

        private void CateringMonthlyTurnoverForm_Load(object sender, EventArgs e)
        {
            IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringIncomeStatusService cateringIncomeStatusService = new CateringIncomeStatusService(unitofWork);
            dgwMonthlyTurnover.DataSource = cateringIncomeStatusService.GetAllCateringIncomeStatus();

            #region Kolon Adı Değişenler
            dgwMonthlyTurnover.Columns[0].HeaderText = "Firma Adı";
            dgwMonthlyTurnover.Columns[2].HeaderText = "İlgili Ay";
            dgwMonthlyTurnover.Columns[3].HeaderText = "Toplam Alınacak Tutar";
            dgwMonthlyTurnover.Columns[4].HeaderText = "Toplam Alınan Tutar";
            dgwMonthlyTurnover.Columns[5].HeaderText = "Kalan Miktar"; 
            #endregion

            #region Gizlenen Kolonlar
            dgwMonthlyTurnover.Columns[1].Visible = false;
            dgwMonthlyTurnover.Columns[6].Visible = false;
            dgwMonthlyTurnover.Columns[7].Visible = false;
            dgwMonthlyTurnover.Columns[8].Visible = false;
            dgwMonthlyTurnover.Columns[9].Visible = false;
            #endregion

            #region Kolon Genişlikleri Ayarlanır
            Tools tools = new Tools();
            tools.DataGridViewResize(dgwMonthlyTurnover, 5); 
            #endregion
        }
    }
}
