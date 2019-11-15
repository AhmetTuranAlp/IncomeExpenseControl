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
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.WinForm
{
    public partial class DailyCastingEntry_Personal_Form : Form
    {
        public DailyCastingEntry_Personal_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (nudPrice.Value > 0)
                {
                    DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                    UnitofWork unitofWork = new UnitofWork(ctx);
                    DailyCastingEntry_Personal_Service dailyCastingEntry_Personal_Service = new DailyCastingEntry_Personal_Service(unitofWork);
                    DailyCastingEntry_Personal dailyCastingEntry_Personal = new DailyCastingEntry_Personal
                    {
                        CastingDate = CastingDate,
                        Status = Status.Active,
                        Price = nudPrice.Value,
                        Descriptions = txtDesciptions.Text
                    };
                    if (dailyCastingEntry_Personal_Service.Insert(dailyCastingEntry_Personal))
                    {
                        DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork);
                        DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                        if (dailyCastingEntry_TotalRevenue != null)
                        {
                            if (dailyCastingEntry_TotalRevenue.Personal_ReelPrice > 0)
                            {
                                dailyCastingEntry_TotalRevenue.Personal_ReelPrice += nudPrice.Value;
                                dailyCastingEntry_TotalRevenue.Personal_TotalPrice += nudPrice.Value;
                            }
                            else
                            {
                                dailyCastingEntry_TotalRevenue.Personal_ReelPrice = nudPrice.Value;
                                dailyCastingEntry_TotalRevenue.Personal_TotalPrice = nudPrice.Value;
                            }

                            if (dailyCastingEntry_TotalRevenue_Service.Update(dailyCastingEntry_TotalRevenue))
                            {
                                MessageBox.Show("İşlem Başarılı");
                            }
                            else
                            {
                                MessageBox.Show("İşlem Başarısız", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            DailyCastingEntry_TotalRevenue newDailyCastingEntry_TotalRevenue = new DailyCastingEntry_TotalRevenue
                            {
                                Personal_ReelPrice = nudPrice.Value,
                                Personal_TotalPrice = nudPrice.Value,
                                Status = Status.Active,
                                CastingDate = CastingDate
                            };
                            if (dailyCastingEntry_TotalRevenue_Service.Insert(newDailyCastingEntry_TotalRevenue))
                            {
                                MessageBox.Show("İşlem Başarılı");
                            }
                            else
                            {
                                MessageBox.Show("İşlem Başarısız", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hata Oluştu.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fiyat Alanı Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

         
        }

        private void DailyCastingEntry_Personal_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
