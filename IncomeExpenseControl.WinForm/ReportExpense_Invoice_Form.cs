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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseControl.WinForm
{
    public partial class ReportExpense_Invoice_Form : Form
    {
        public ReportExpense_Invoice_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void ReportExpense_Invoice_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            Expense_Invoice_Service expense_Invoice_Service = new Expense_Invoice_Service(unitofWork);
            List<Expense_Invoice> expense_Invoices = expense_Invoice_Service.GetAllExpense_Invoice();
            dataGridView1.DataSource = expense_Invoices;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Fatura Tipi";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].HeaderText = "Tutar";

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 4);

            txtTotalRevenues.Text = expense_Invoices.Sum(x => x.Price).ToString();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.TransferringDatagridviewtoExcel(dataGridView1, Convert.ToDateTime(string.Format("{0: dd/MM/yyyy}", DateTime.Now)).ToString().Replace("00:00:00", "").Trim() + "_Fatura Giderleri");
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            Expense_Invoice_Service expense_Invoice_Service = new Expense_Invoice_Service(unitofWork);
            List<Expense_Invoice> expense_Invoices = expense_Invoice_Service.GetAllExpense_Invoice();
            dataGridView1.DataSource = expense_Invoices;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Fatura Tipi";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].HeaderText = "Tutar";

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 4);

            txtTotalRevenues.Text = expense_Invoices.Sum(x => x.Price).ToString();
        }


        private void btnFillter_Click(object sender, EventArgs e)
        {
            DateTime DateStart = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDateStart.Value));
            DateTime DateFinish = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDateFinish.Value));

            UnitofWork unitofWork = new UnitofWork(ctx);
            Expense_Invoice_Service expense_Invoice_Service = new Expense_Invoice_Service(unitofWork);
            List<Expense_Invoice> expense_Invoices = expense_Invoice_Service.GetAllExpense_Invoice().Where(x => x.ExpenseDate >= DateStart && x.ExpenseDate <= DateFinish).ToList();
            dataGridView1.DataSource = expense_Invoices;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Fatura Tipi";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].HeaderText = "Tutar";

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 4);

            txtTotalRevenues.Text = expense_Invoices.Sum(x => x.Price).ToString();
        }
    }
}
