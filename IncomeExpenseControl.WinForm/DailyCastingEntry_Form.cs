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
    public partial class DailyCastingEntry_Form : Form
    {
        public DailyCastingEntry_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void DailyCastingEntry_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            #region Left Menu Color Change
            btnPersonal.BackColor = Color.LightGray;
            btnCatering.BackColor = Color.WhiteSmoke;
            btnRestaurantCash.BackColor = Color.WhiteSmoke;
            btnRestaurantCredit.BackColor = Color.WhiteSmoke;
            btnRestaurantFood.BackColor = Color.WhiteSmoke;
            #endregion

            #region Personal Control Inputs
            pnlInput.Controls.Clear();

            Label lblPrice = new Label()
            {
                Text = "Tutar:",
                Width = 100,
                Font = new Font("Arial", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(68, 16)
            };
            pnlInput.Controls.Add(lblPrice);
            
            NumericUpDown nudPrice = new NumericUpDown()
            {
                Width = 300,
                Name = "nudPrice",
                Location = new Point(70, 40),
                Maximum = 10000000
            };
            pnlInput.Controls.Add(nudPrice);
            
            Label lblDesciptions = new Label()
            {
                Text = "Açıklama:",
                Width = 100,
                Font = new Font("Arial", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(68, 70),

            };
            pnlInput.Controls.Add(lblDesciptions);
            
            TextBox txtDesciptions = new TextBox()
            {
                Width = 300,
                Name = "txtDesciptions",
                Location = new Point(70, 95),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                WordWrap = true,
                Height = 80
            };
            pnlInput.Controls.Add(txtDesciptions); 
            #endregion
        }

        private void btnCatering_Click(object sender, EventArgs e)
        {
            #region Left Menu Color Change
            btnCatering.BackColor = Color.LightGray;
            btnPersonal.BackColor = Color.WhiteSmoke;
            btnRestaurantCash.BackColor = Color.WhiteSmoke;
            btnRestaurantCredit.BackColor = Color.WhiteSmoke;
            btnRestaurantFood.BackColor = Color.WhiteSmoke;
            #endregion

            #region Catering Control Inputs
            pnlInput.Controls.Clear();

            Label lblCateringCustomer = new Label()
            {
                Text = "Firma:",
                Width = 100,
                Font = new Font("Arial", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(68, 16)
            };
            pnlInput.Controls.Add(lblCateringCustomer);

            ComboBox cmbCateringCustomer = new ComboBox()
            {
                Width = 300,
                Name = "cmbCateringCustomer",
                Location = new Point(70, 40),
                Font = new Font("Arial", 8, FontStyle.Bold)
            };
            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanies_Service cateringCompanies_Service = new CateringCompanies_Service(unitofWork);
            List<CateringCompanies> CateringCompanyList = new List<CateringCompanies>();
            CateringCompanyList.Add(new CateringCompanies() { Code = "", Name = "Firma Seçiniz..." });
            CateringCompanyList.AddRange(cateringCompanies_Service.GetAllCateringCompanies());

            cmbCateringCustomer.DataSource = CateringCompanyList;
            cmbCateringCustomer.DisplayMember = "Name";
            cmbCateringCustomer.ValueMember = "Code";

            pnlInput.Controls.Add(cmbCateringCustomer);
            #endregion


        }

        private void btnRestaurantCash_Click(object sender, EventArgs e)
        {
            #region Left Menu Color Change
            btnRestaurantCash.BackColor = Color.LightGray;
            btnCatering.BackColor = Color.WhiteSmoke;
            btnPersonal.BackColor = Color.WhiteSmoke;
            btnRestaurantCredit.BackColor = Color.WhiteSmoke;
            btnRestaurantFood.BackColor = Color.WhiteSmoke;
            #endregion
            

        }

        private void btnRestaurantCredit_Click(object sender, EventArgs e)
        {
            #region Left Menu Color Change
            btnRestaurantCredit.BackColor = Color.LightGray;
            btnCatering.BackColor = Color.WhiteSmoke;
            btnPersonal.BackColor = Color.WhiteSmoke;
            btnRestaurantFood.BackColor = Color.WhiteSmoke;
            btnRestaurantCash.BackColor = Color.WhiteSmoke;
            #endregion



            pnlInput.Controls.Clear();

        }

        private void btnRestaurantFood_Click(object sender, EventArgs e)
        {
            #region Left Menu Color Change
            btnRestaurantFood.BackColor = Color.LightGray;
            btnCatering.BackColor = Color.WhiteSmoke;
            btnPersonal.BackColor = Color.WhiteSmoke;
            btnRestaurantCash.BackColor = Color.WhiteSmoke;
            btnRestaurantCredit.BackColor = Color.WhiteSmoke;
            #endregion
        }


    }
}
