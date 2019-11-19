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
    public partial class ReportRevenue_TotalRevenues_Form : Form
    {
        public ReportRevenue_TotalRevenues_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void IncomeReports_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork);
            dataGridView1.DataSource = dailyCastingEntry_TotalRevenue_Service.GetAllTotalRevenue();

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Şahsi_Toplam";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "CT_Kişi";
            dataGridView1.Columns[4].HeaderText = "CT_Toplam";
            dataGridView1.Columns[5].HeaderText = "CT_Real";
            dataGridView1.Columns[6].HeaderText = "R_Nakit_Kişi";
            dataGridView1.Columns[7].HeaderText = "R_Nakit_Toplam";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].HeaderText = "R_KK_Kişi";
            dataGridView1.Columns[10].HeaderText = "R_KK_Toplam";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].HeaderText = "R_YK_Kişi";
            dataGridView1.Columns[13].HeaderText = "R_YK_Toplam";
            dataGridView1.Columns[14].HeaderText = "R_YK_Real";
            dataGridView1.Columns[15].HeaderText = "G_Toplam";
            dataGridView1.Columns[16].HeaderText = "G_Real";
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 14);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.TransferringDatagridviewtoExcel(dataGridView1, Convert.ToDateTime(string.Format("{0: dd/MM/yyyy}", DateTime.Now)).ToString().Replace("00:00:00", "").Trim() + "_Toplam Gelirler");
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDate.Value));
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork);
            dataGridView1.DataSource = dailyCastingEntry_TotalRevenue_Service.GetAllTotalRevenue().Where(x => x.CastingDate == CastingDate).ToList();

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Şahsi_Toplam";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "CT_Kişi";
            dataGridView1.Columns[4].HeaderText = "CT_Toplam";
            dataGridView1.Columns[5].HeaderText = "CT_Real";
            dataGridView1.Columns[6].HeaderText = "R_Nakit_Kişi";
            dataGridView1.Columns[7].HeaderText = "R_Nakit_Toplam";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].HeaderText = "R_KK_Kişi";
            dataGridView1.Columns[10].HeaderText = "R_KK_Toplam";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].HeaderText = "R_YK_Kişi";
            dataGridView1.Columns[13].HeaderText = "R_YK_Toplam";
            dataGridView1.Columns[14].HeaderText = "R_YK_Real";
            dataGridView1.Columns[15].HeaderText = "G_Toplam";
            dataGridView1.Columns[16].HeaderText = "G_Real";
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 14);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork);
            dataGridView1.DataSource = dailyCastingEntry_TotalRevenue_Service.GetAllTotalRevenue();

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Şahsi_Toplam";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "CT_Kişi";
            dataGridView1.Columns[4].HeaderText = "CT_Toplam";
            dataGridView1.Columns[5].HeaderText = "CT_Real";
            dataGridView1.Columns[6].HeaderText = "R_Nakit_Kişi";
            dataGridView1.Columns[7].HeaderText = "R_Nakit_Toplam";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].HeaderText = "R_KK_Kişi";
            dataGridView1.Columns[10].HeaderText = "R_KK_Toplam";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].HeaderText = "R_YK_Kişi";
            dataGridView1.Columns[13].HeaderText = "R_YK_Toplam";
            dataGridView1.Columns[14].HeaderText = "R_YK_Real";
            dataGridView1.Columns[15].HeaderText = "G_Toplam";
            dataGridView1.Columns[16].HeaderText = "G_Real";
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 14);
        }
    }
}
