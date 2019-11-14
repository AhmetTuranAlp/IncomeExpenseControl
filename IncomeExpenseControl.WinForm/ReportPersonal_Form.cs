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
    public partial class ReportPersonal_Form : Form
    {
        public ReportPersonal_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void ReportPersonal_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Personal_Service dailyCastingEntry_Personal_Service = new DailyCastingEntry_Personal_Service(unitofWork);
            dataGridView1.DataSource = dailyCastingEntry_Personal_Service.GetAllDailyCastingEntry_Personal();

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Tutar";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 3);
        }
    }
}
