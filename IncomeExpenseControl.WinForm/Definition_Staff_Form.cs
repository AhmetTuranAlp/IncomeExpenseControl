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
    public partial class Definition_Staff_Form : Form
    {
        public Definition_Staff_Form()
        {
            InitializeComponent();
        }


        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void btnFoodCardSave_Click(object sender, EventArgs e)
        {
            #region Variables
            string FullName = txtFullName.Text;
            DateTime TimetoWork = dtpDate.Value;
            decimal Salary = nudSalary.Value;
            #endregion

            DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                #region Service
                UnitofWork unitofWork = new UnitofWork(ctx);
                Staff_Service staff_Service = new Staff_Service(unitofWork);
                #endregion

                if (string.IsNullOrEmpty(FullName) && Salary > 0)
                {
                    Staff staff = new Staff()
                    {
                        FullName = FullName,
                        Salary = Salary,
                        TimetoWork = TimetoWork
                    };
                    if (staff_Service.Insert(staff))
                    {
                        MessageBox.Show("İşlem Başarılı.");
                        txtFullName.Text = "";
                        nudSalary.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            nudSalary.Value = 0;            
        }

        private void Staff_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
