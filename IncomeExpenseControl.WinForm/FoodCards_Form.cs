
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseControl.WinForm
{
    public partial class FoodCards_Form : Form
    {
        public FoodCards_Form()
        {
            InitializeComponent();
        }

        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        private void btnFoodCardSave_Click(object sender, EventArgs e)
        {
            #region Variables
            string FoodCardName = txtFoodCardName.Text;
            string FoodCardDescriptions = txtFoodCardDescriptions.Text;
            #endregion

            #region Service
            UnitofWork unitofWork = new UnitofWork(ctx);
            FoodCards_Service foodCard_Service = new FoodCards_Service(unitofWork);
            #endregion

            if (!string.IsNullOrEmpty(FoodCardName))
            {
                Tools tools = new Tools();
                FoodCards banks = new FoodCards()
                {
                    Code = tools.CreateCode(),
                    Name = FoodCardName,
                    Descriptions = FoodCardDescriptions
                };
                if (foodCard_Service.Insert(banks))
                {
                    MessageBox.Show("İşlem Başarılı.");
                    txtFoodCardName.Text = "";
                    txtFoodCardDescriptions.Text = "";
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız.");
                }
            }
            else
            {
                MessageBox.Show("Boş Geçilemez.");
            }
        }
    }
}
