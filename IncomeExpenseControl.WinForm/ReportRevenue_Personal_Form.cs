﻿using IncomeExpenseControl.Common;
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
    public partial class ReportRevenue_Personal_Form : Form
    {
        public ReportRevenue_Personal_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void ReportPersonal_Form_Load(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Personal_Service dailyCastingEntry_Personal_Service = new DailyCastingEntry_Personal_Service(unitofWork);
            List<DailyCastingEntry_Personal> dailyCastingEntry_Personals = dailyCastingEntry_Personal_Service.GetAllDailyCastingEntry_Personal();
            dataGridView1.DataSource = dailyCastingEntry_Personals;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Tutar";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 3);

            txtTotalRevenues.Text = dailyCastingEntry_Personals.Sum(x => x.Price).ToString();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.TransferringDatagridviewtoExcel(dataGridView1, Convert.ToDateTime(string.Format("{0: dd/MM/yyyy}", DateTime.Now)).ToString().Replace("00:00:00", "").Trim() + "_Şahsi Gelirler");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Personal_Service dailyCastingEntry_Personal_Service = new DailyCastingEntry_Personal_Service(unitofWork);
            List<DailyCastingEntry_Personal> dailyCastingEntry_Personals = dailyCastingEntry_Personal_Service.GetAllDailyCastingEntry_Personal();
            dataGridView1.DataSource = dailyCastingEntry_Personals;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Tutar";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 3);

            txtTotalRevenues.Text = dailyCastingEntry_Personals.Sum(x => x.Price).ToString();
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            DateTime DateStart = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDateStart.Value));
            DateTime DateFinish = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpDateFinish.Value));

            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_Personal_Service dailyCastingEntry_Personal_Service = new DailyCastingEntry_Personal_Service(unitofWork);
            List<DailyCastingEntry_Personal> dailyCastingEntry_Personals = dailyCastingEntry_Personal_Service.GetAllDailyCastingEntry_Personal().Where(x => x.CastingDate >= DateStart && x.CastingDate <= DateFinish).ToList();
            dataGridView1.DataSource = dailyCastingEntry_Personals;

            dataGridView1.Columns[0].HeaderText = "Tarih";
            dataGridView1.Columns[1].HeaderText = "Tutar";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            Tools tools = new Tools();
            tools.DataGridViewResize(dataGridView1, 3);

            txtTotalRevenues.Text = dailyCastingEntry_Personals.Sum(x => x.Price).ToString();
        }
    }
}
