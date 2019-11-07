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
    public partial class CateringServiceReportForm : Form
    {
        public CateringServiceReportForm()
        {
            InitializeComponent();
        }

        private void CateringServiceReportForm_Load(object sender, EventArgs e)
        {
            IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringFoodDeliveryService cateringFoodDeliveryService = new CateringFoodDeliveryService(unitofWork);
            dgwServiceReport.DataSource = cateringFoodDeliveryService.GetAllCateringFoodDelivery();
            #region Kolon Adı Değişenler
            dgwServiceReport.Columns[0].HeaderText = "Firma Adı";
            dgwServiceReport.Columns[2].HeaderText = "Açıklama";
            dgwServiceReport.Columns[3].HeaderText = "Hizmet Tarihi";
            dgwServiceReport.Columns[4].HeaderText = "Kişi Sayısı";
            dgwServiceReport.Columns[5].HeaderText = "Fiyat";
            #endregion

            #region Gizlenen Kolonlar
            dgwServiceReport.Columns[1].Visible = false;
            dgwServiceReport.Columns[6].Visible = false;
            dgwServiceReport.Columns[7].Visible = false;
            dgwServiceReport.Columns[8].Visible = false;
            dgwServiceReport.Columns[9].Visible = false;
            #endregion

            #region Kolon Genişlikleri Ayarlanır
            Tools tools = new Tools();
            tools.DataGridViewResize(dgwServiceReport, 5);
            #endregion
        }
    }
}
