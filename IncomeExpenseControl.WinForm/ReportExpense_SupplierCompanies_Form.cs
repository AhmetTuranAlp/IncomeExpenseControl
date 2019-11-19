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
    public partial class ReportExpense_SupplierCompanies_Form : Form
    {
        public ReportExpense_SupplierCompanies_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void ReportExpense_SupplierCompanies_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            Expense_Suppliers_Service expense_Suppliers_Service = new Expense_Suppliers_Service(unitofWork);
            dataGridView1.DataSource = expense_Suppliers_Service.GetAllExpense_Suppliers();

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Firma";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].HeaderText = "Tutar";

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 4);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.TransferringDatagridviewtoExcel(dataGridView1, Convert.ToDateTime(string.Format("{0: dd/MM/yyyy}", DateTime.Now)).ToString().Replace("00:00:00", "").Trim() + "_Tedarikçi Giderleri");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            Expense_Suppliers_Service expense_Suppliers_Service = new Expense_Suppliers_Service(unitofWork);
            dataGridView1.DataSource = expense_Suppliers_Service.GetAllExpense_Suppliers();

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Firma";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].HeaderText = "Tutar";

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 4);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime ExpenseDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDate.Value));
            UnitofWork unitofWork = new UnitofWork(ctx);
            Expense_Suppliers_Service expense_Suppliers_Service = new Expense_Suppliers_Service(unitofWork);
            dataGridView1.DataSource = expense_Suppliers_Service.GetAllExpense_Suppliers().Where(x => x.ExpenseDate == ExpenseDate).ToList();

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Firma";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].HeaderText = "Tutar";

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 4);
        }
    }
}
