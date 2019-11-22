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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using IncomeExpenseControl.Data.Entity;

namespace IncomeExpenseControl.WinForm
{
    public partial class ReportRevenue_CateringRevenues_Form : Form
    {
        public ReportRevenue_CateringRevenues_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void ReportCateringRevenues_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Catering_Service dailyCastingEntry_Catering_Service = new DailyCastingEntry_Catering_Service(unitofWork);
            List<DailyCastingEntry_Catering> dailyCastingEntry_Caterings = dailyCastingEntry_Catering_Service.GetAllCateringPaymentCasting();
            dataGridView1.DataSource = dailyCastingEntry_Caterings;

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Firma";
            dataGridView1.Columns[2].HeaderText = "Kişi";
            dataGridView1.Columns[3].HeaderText = "Tutar";
            dataGridView1.Columns[4].HeaderText = "Fatura";
            dataGridView1.Columns[5].HeaderText = "Ödeme Durumu";

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 6);

            txtRealRevenues.Text = dailyCastingEntry_Caterings.Sum(x => x.Price).ToString();
            txtTotalRevenues.Text = dailyCastingEntry_Caterings.Sum(x => x.Price).ToString();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.TransferringDatagridviewtoExcel(dataGridView1, Convert.ToDateTime(string.Format("{0: dd/MM/yyyy}", DateTime.Now)).ToString().Replace("00:00:00", "").Trim() + "_Catering Gelirleri");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Catering_Service dailyCastingEntry_Catering_Service = new DailyCastingEntry_Catering_Service(unitofWork);
            List<DailyCastingEntry_Catering> dailyCastingEntry_Caterings = dailyCastingEntry_Catering_Service.GetAllCateringPaymentCasting();
            dataGridView1.DataSource = dailyCastingEntry_Caterings;

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Firma";
            dataGridView1.Columns[2].HeaderText = "Kişi";
            dataGridView1.Columns[3].HeaderText = "Tutar";
            dataGridView1.Columns[4].HeaderText = "Fatura";
            dataGridView1.Columns[5].HeaderText = "Ödeme Durumu";

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 6);

            txtRealRevenues.Text = dailyCastingEntry_Caterings.Sum(x => x.Price).ToString();
            txtTotalRevenues.Text = dailyCastingEntry_Caterings.Sum(x => x.Price).ToString();
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            DateTime DateStart = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDateStart.Value));
            DateTime DateFinish = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDateFinish.Value));

            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Catering_Service dailyCastingEntry_Catering_Service = new DailyCastingEntry_Catering_Service(unitofWork);
            List<DailyCastingEntry_Catering> dailyCastingEntry_Caterings = dailyCastingEntry_Catering_Service.GetAllCateringPaymentCasting().Where(x => x.CastingDate >= DateStart && x.CastingDate <= DateFinish).ToList();
            dataGridView1.DataSource = dailyCastingEntry_Caterings;

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Firma";
            dataGridView1.Columns[2].HeaderText = "Kişi";
            dataGridView1.Columns[3].HeaderText = "Tutar";
            dataGridView1.Columns[4].HeaderText = "Fatura";
            dataGridView1.Columns[5].HeaderText = "Ödeme Durumu";

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 6);

            txtRealRevenues.Text = dailyCastingEntry_Caterings.Sum(x => x.Price).ToString();
            txtTotalRevenues.Text = dailyCastingEntry_Caterings.Sum(x => x.Price).ToString();

        }
    }
}
