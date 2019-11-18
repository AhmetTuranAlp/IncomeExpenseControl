using IncomeExpenseControl.Common;
using IncomeExpenseControl.Data.Context;
using IncomeExpenseControl.Data.Entity;
using IncomeExpenseControl.Data.Model;
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
    public partial class DailyCastingEntry_Form : Form
    {
        public DailyCastingEntry_Form()
        {
            InitializeComponent();
        }

        #region Variables
        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        NumericUpDown nudPrice = new NumericUpDown();
        NumericUpDown nudNumberOfPeope = new NumericUpDown();
        TextBox txtDesciptions = new TextBox();
        ComboBox cmbCateringCustomer = new ComboBox();
        ComboBox cmbCateringInvoice = new ComboBox();
        ComboBox cmbCateringPayment = new ComboBox();
        ComboBox cmbBanks = new ComboBox();
        ComboBox cmbFoods = new ComboBox();
        int DailyCastingEntryType = 1;
        #endregion

        #region Dynamic Form Items
        public void Label(Panel panel, string text, int X, int Y)
        {
            Label label = new Label()
            {
                Text = text + ":",
                Width = 100,
                Font = new Font("Arial", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(X, Y)
            };
            panel.Controls.Add(label);
        }

        public NumericUpDown NumericUpDown(Panel panel, string text, int X, int Y)
        {
            NumericUpDown nud = new NumericUpDown()
            {
                Width = 380,
                Name = text + ":",
                Location = new Point(X, Y),
                Maximum = 10000000,
                Font = new Font("Arial", 8, FontStyle.Bold),
            };
            panel.Controls.Add(nud);
            return nud;
        }

        public TextBox MultiLineTextBox(Panel panel, string text, int X, int Y, int Height)
        {
            TextBox txt = new TextBox()
            {
                Width = 380,
                Name = text,
                Location = new Point(X, Y),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                WordWrap = true,
                Height = Height,
                Font = new Font("Arial", 8, FontStyle.Bold),
            };
            panel.Controls.Add(txt);
            return txt;
        }

        public ComboBox Combobox(Panel panel, string text, int X, int Y)
        {
            ComboBox comboBox = new ComboBox()
            {
                Width = 380,
                Name = text,
                Location = new Point(X, Y),
                Font = new Font("Arial", 8, FontStyle.Bold)
            };
            panel.Controls.Add(comboBox);
            return comboBox;
        }

        #endregion

        private void DailyCastingEntry_Form_Load(object sender, EventArgs e)
        {
            #region Personal Control Inputs
            pnlInput.Controls.Clear();

            Label(pnlInput, "Tutar", 38, 21);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 45);

            Label(pnlInput, "Açıklama", 38, 75);
            txtDesciptions = MultiLineTextBox(pnlInput, "txtDesciptions", 40, 100, 150);
            #endregion
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            DailyCastingEntryType = 1;

            #region Left Menu Color Change
            btnPersonal.BackColor = Color.LightGray;
            btnCatering.BackColor = Color.WhiteSmoke;
            btnRestaurantCash.BackColor = Color.WhiteSmoke;
            btnRestaurantCredit.BackColor = Color.WhiteSmoke;
            btnRestaurantFood.BackColor = Color.WhiteSmoke;
            #endregion

            #region Personal Control Inputs
            pnlInput.Controls.Clear();

            Label(pnlInput, "Tutar", 38, 21);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 45);

            Label(pnlInput, "Açıklama", 38, 75);
            txtDesciptions = MultiLineTextBox(pnlInput, "txtDesciptions", 40, 100, 150);
            #endregion

        }

        private void btnCatering_Click(object sender, EventArgs e)
        {
            DailyCastingEntryType = 2;

            #region Left Menu Color Change
            btnCatering.BackColor = Color.LightGray;
            btnPersonal.BackColor = Color.WhiteSmoke;
            btnRestaurantCash.BackColor = Color.WhiteSmoke;
            btnRestaurantCredit.BackColor = Color.WhiteSmoke;
            btnRestaurantFood.BackColor = Color.WhiteSmoke;
            #endregion

            #region Catering Control Inputs
            pnlInput.Controls.Clear();

            Label(pnlInput, "Firma", 38, 20);
            cmbCateringCustomer = Combobox(pnlInput, "cmbCateringCustomer", 40, 45);

            UnitofWork unitofWork = new UnitofWork(ctx);
            CateringCompanies_Service cateringCompanies_Service = new CateringCompanies_Service(unitofWork);
            List<CateringCompanies> CateringCompanyList = new List<CateringCompanies>();
            CateringCompanyList.Add(new CateringCompanies() { Code = "", Name = "Firma Seçiniz..." });
            CateringCompanyList.AddRange(cateringCompanies_Service.GetAllCateringCompanies());
            cmbCateringCustomer.DataSource = CateringCompanyList;
            cmbCateringCustomer.DisplayMember = "Name";
            cmbCateringCustomer.ValueMember = "Code";

            Label(pnlInput, "Tutar", 38, 75);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 100);

            Label(pnlInput, "Kişi Sayısı", 38, 130);
            nudNumberOfPeope = NumericUpDown(pnlInput, "nudNumberOfPeope", 40, 155);

            Label(pnlInput, "Fatura", 38, 185);
            cmbCateringInvoice = Combobox(pnlInput, "cmbCateringInvoice", 40, 210);
            List<SelectListItem> CateringInvoiceList = new List<SelectListItem>();
            CateringInvoiceList.Add(new SelectListItem() { Value = "0", Text = "Fatura Durumunu Seçiniz..." });
            CateringInvoiceList.Add(new SelectListItem() { Value = "1", Text = "Kesildi" });
            CateringInvoiceList.Add(new SelectListItem() { Value = "2", Text = "Kesilmedi" });
            cmbCateringInvoice.DataSource = CateringInvoiceList;
            cmbCateringInvoice.DisplayMember = "Text";
            cmbCateringInvoice.ValueMember = "Value";

            Label(pnlInput, "Ödeme", 38, 240);
            cmbCateringPayment = Combobox(pnlInput, "cmbCateringPayment", 40, 265);
            List<SelectListItem> CateringPaymentList = new List<SelectListItem>();
            CateringPaymentList.Add(new SelectListItem() { Value = "0", Text = "Ödeme Durumunu Seçiniz..." });
            CateringPaymentList.Add(new SelectListItem() { Value = "1", Text = "Yapıldı" });
            CateringPaymentList.Add(new SelectListItem() { Value = "2", Text = "Yapılmadı" });
            cmbCateringPayment.DataSource = CateringPaymentList;
            cmbCateringPayment.DisplayMember = "Text";
            cmbCateringPayment.ValueMember = "Value";
            #endregion

        }

        private void btnRestaurantCash_Click(object sender, EventArgs e)
        {
            DailyCastingEntryType = 3;

            #region Left Menu Color Change
            btnRestaurantCash.BackColor = Color.LightGray;
            btnCatering.BackColor = Color.WhiteSmoke;
            btnPersonal.BackColor = Color.WhiteSmoke;
            btnRestaurantCredit.BackColor = Color.WhiteSmoke;
            btnRestaurantFood.BackColor = Color.WhiteSmoke;
            #endregion

            #region Restaurant Cash Control Items
            pnlInput.Controls.Clear();

            Label(pnlInput, "Tutar", 38, 20);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 45);

            Label(pnlInput, "Kişi Sayısı", 38, 75);
            nudNumberOfPeope = NumericUpDown(pnlInput, "nudNumberOfPeope", 40, 100);
            #endregion

        }

        private void btnRestaurantCredit_Click(object sender, EventArgs e)
        {
            DailyCastingEntryType = 4;

            #region Left Menu Color Change
            btnRestaurantCredit.BackColor = Color.LightGray;
            btnCatering.BackColor = Color.WhiteSmoke;
            btnPersonal.BackColor = Color.WhiteSmoke;
            btnRestaurantFood.BackColor = Color.WhiteSmoke;
            btnRestaurantCash.BackColor = Color.WhiteSmoke;
            #endregion

            #region Restaurant Credit Card Control Items
            pnlInput.Controls.Clear();

            Label(pnlInput, "Firma", 38, 20);
            cmbBanks = Combobox(pnlInput, "cmbBanks", 40, 45);

            UnitofWork unitofWork = new UnitofWork(ctx);
            Banks_Service banks_Service = new Banks_Service(unitofWork);

            List<Banks> bankList = new List<Banks>();
            bankList.Add(new Banks() { BankCode = "", BankName = "Banka Seçiniz..." });
            bankList.AddRange(banks_Service.GetAllBanks());

            cmbBanks.DataSource = bankList;
            cmbBanks.DisplayMember = "BankName";
            cmbBanks.ValueMember = "BankCode";

            Label(pnlInput, "Tutar", 38, 75);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 100);

            Label(pnlInput, "Kişi Sayısı", 38, 130);
            nudNumberOfPeope = NumericUpDown(pnlInput, "nudNumberOfPeope", 40, 155);
            #endregion

        }

        private void btnRestaurantFood_Click(object sender, EventArgs e)
        {
            DailyCastingEntryType = 5;

            #region Left Menu Color Change
            btnRestaurantFood.BackColor = Color.LightGray;
            btnCatering.BackColor = Color.WhiteSmoke;
            btnPersonal.BackColor = Color.WhiteSmoke;
            btnRestaurantCash.BackColor = Color.WhiteSmoke;
            btnRestaurantCredit.BackColor = Color.WhiteSmoke;
            #endregion

            #region Restaurant Food Card Control Items
            pnlInput.Controls.Clear();

            Label(pnlInput, "Kart", 38, 20);
            cmbFoods = Combobox(pnlInput, "cmbFoods", 40, 45);

            UnitofWork unitofWork = new UnitofWork(ctx);
            FoodCards_Service foodCards_Service = new FoodCards_Service(unitofWork);

            List<FoodCards> foodCardsList = new List<FoodCards>();
            foodCardsList.Add(new FoodCards() { Code = "", Name = "Yemek Kartı Seçiniz..." });
            foodCardsList.AddRange(foodCards_Service.GetAllFoodCards());

            cmbFoods.DataSource = foodCardsList;
            cmbFoods.DisplayMember = "Name";
            cmbFoods.ValueMember = "Code";

            Label(pnlInput, "Tutar", 38, 75);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 100);

            Label(pnlInput, "Kişi Sayısı", 38, 130);
            nudNumberOfPeope = NumericUpDown(pnlInput, "nudNumberOfPeope", 40, 155);
            #endregion

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region General Services
            UnitofWork unitofWork = new UnitofWork(ctx);
            DailyCastingEntry_TotalRevenue_Service dailyCastingEntry_TotalRevenue_Service = new DailyCastingEntry_TotalRevenue_Service(unitofWork);
            #endregion

            if (DailyCastingEntryType == 1)
            {
                DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                decimal Price = nudPrice.Value;
                string Desciptions = txtDesciptions.Text;
                if (Price > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DailyCastingEntry_Personal_Service dailyCastingEntry_Personal_Service = new DailyCastingEntry_Personal_Service(unitofWork);
                        DailyCastingEntry_Personal dailyCastingEntry_Personal = new DailyCastingEntry_Personal
                        {
                            CastingDate = CastingDate,
                            Status = Status.Active,
                            Price = Price,
                            Descriptions = Desciptions
                        };

                        if (dailyCastingEntry_Personal_Service.Insert(dailyCastingEntry_Personal))
                        {
                            DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                            if (dailyCastingEntry_TotalRevenue != null)
                            {
                                if (dailyCastingEntry_TotalRevenue.Personal_ReelPrice > 0)
                                {
                                    dailyCastingEntry_TotalRevenue.Personal_ReelPrice += Price;
                                    dailyCastingEntry_TotalRevenue.Personal_TotalPrice += Price;
                                }
                                else
                                {
                                    dailyCastingEntry_TotalRevenue.Personal_ReelPrice = Price;
                                    dailyCastingEntry_TotalRevenue.Personal_TotalPrice = Price;
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
                                    Personal_ReelPrice = Price,
                                    Personal_TotalPrice = Price,
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
                            nudPrice.Value = 0;
                            txtDesciptions.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Hata Oluştu.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (DailyCastingEntryType == 2)
            {
                #region Variables
                DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                decimal Price = nudPrice.Value;
                int NumberOfPeople = Convert.ToInt32(nudNumberOfPeope.Value);
                string CateringCode = cmbCateringCustomer.SelectedValue.ToString();
                bool PaymentMade = cmbCateringPayment.Text == "Yapıldı" ? true : false;
                bool InvoiceCut = cmbCateringInvoice.Text == "Kesildi" ? true : false;
                #endregion

                #region Service Instance
                CateringCompanies_Service cateringCompanies_Service = new CateringCompanies_Service(unitofWork);
                DailyCastingEntry_Catering_Service dailyCastingEntry_Catering_Service = new DailyCastingEntry_Catering_Service(unitofWork);
                #endregion

                if (Price > 0 && NumberOfPeople > 0 && !string.IsNullOrEmpty(CateringCode) && !string.IsNullOrEmpty(cmbCateringInvoice.Text) && !string.IsNullOrEmpty(cmbCateringPayment.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DailyCastingEntry_Catering dailyCastingEntry_Catering = new DailyCastingEntry_Catering()
                        {
                            CastingDate = CastingDate,
                            CompanyCode = cateringCompanies_Service.GetCateringCompanies(CateringCode).Code,
                            CateringCompany = cateringCompanies_Service.GetCateringCompanies(CateringCode).Name,
                            NumberOfPeople = NumberOfPeople,
                            Price = Price,
                            Status = Status.Active,
                            PaymentMade = PaymentMade,
                            InvoiceCut = InvoiceCut
                        };
                        if (dailyCastingEntry_Catering_Service.Insert(dailyCastingEntry_Catering))
                        {
                            DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                            if (dailyCastingEntry_TotalRevenue != null)
                            {
                                if (PaymentMade)
                                {
                                    dailyCastingEntry_TotalRevenue.Catering_ReelPrice = dailyCastingEntry_TotalRevenue.Catering_ReelPrice > 0 ? dailyCastingEntry_TotalRevenue.Catering_ReelPrice + Price : Price;
                                }
                                dailyCastingEntry_TotalRevenue.Catering_TotalPrice = dailyCastingEntry_TotalRevenue.Catering_TotalPrice > 0 ? dailyCastingEntry_TotalRevenue.Catering_TotalPrice + Price : Price;

                                dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople = dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople > 0 ? dailyCastingEntry_TotalRevenue.Catering_NumberOfPeople + NumberOfPeople : NumberOfPeople;

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
                                #region DailyCastingEntry_TotalRevenue Yeni Kayıt Oluşturuluyor ve Catering Bilgileri Ekleniyor.
                                dailyCastingEntry_TotalRevenue = new DailyCastingEntry_TotalRevenue
                                {
                                    CastingDate = CastingDate,
                                    Catering_NumberOfPeople = NumberOfPeople,
                                    Catering_TotalPrice = Price,
                                    Catering_ReelPrice = PaymentMade == true ? Price : 0
                                };

                                if (dailyCastingEntry_TotalRevenue_Service.Insert(dailyCastingEntry_TotalRevenue))
                                {
                                    MessageBox.Show("İşlem Başarılı.");
                                }
                                else
                                {
                                    MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                #endregion
                            }

                            nudPrice.Value = 0;
                            nudNumberOfPeope.Value = 0;
                            cmbCateringCustomer.SelectedIndex = 0;

                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (DailyCastingEntryType == 3)
            {
                #region Variables
                DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                decimal Price = nudPrice.Value;
                int NumberOfPeople = Convert.ToInt32(nudNumberOfPeope.Value);
                #endregion

                if (Price > 0 && NumberOfPeople > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DailyCastingEntry_Restaurant_Cash dailyCastingEntry_Restaurant_Cash = new DailyCastingEntry_Restaurant_Cash()
                        {
                            CastingDate = CastingDate,
                            NumberOfPeople = NumberOfPeople,
                            Price = Price,
                            Status = Status.Active
                        };
                        DailyCastingEntry_Restaurant_Cash_Service dailyCastingEntry_Restaurant_Cash_Service = new DailyCastingEntry_Restaurant_Cash_Service(unitofWork);
                        if (dailyCastingEntry_Restaurant_Cash_Service.Insert(dailyCastingEntry_Restaurant_Cash))
                        {
                            DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                            if (dailyCastingEntry_TotalRevenue != null)
                            {
                                dailyCastingEntry_TotalRevenue.RestaurantCash_ReelPrice = dailyCastingEntry_TotalRevenue.RestaurantCash_ReelPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantCash_ReelPrice + Price : Price;

                                dailyCastingEntry_TotalRevenue.RestaurantCash_TotalPrice = dailyCastingEntry_TotalRevenue.RestaurantCash_TotalPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantCash_TotalPrice + Price : Price;

                                dailyCastingEntry_TotalRevenue.RestaurantCash_NumberOfPeople = dailyCastingEntry_TotalRevenue.RestaurantCash_NumberOfPeople > 0 ? dailyCastingEntry_TotalRevenue.RestaurantCash_NumberOfPeople + NumberOfPeople : NumberOfPeople;

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
                                #region DailyCastingEntry_TotalRevenue Yeni Kayıt Oluşturuluyor ve Catering Bilgileri Ekleniyor.
                                dailyCastingEntry_TotalRevenue = new DailyCastingEntry_TotalRevenue
                                {
                                    RestaurantCash_NumberOfPeople = NumberOfPeople,
                                    RestaurantCash_TotalPrice = Price,
                                    RestaurantCash_ReelPrice = Price,
                                    CastingDate = CastingDate
                                };

                                if (dailyCastingEntry_TotalRevenue_Service.Insert(dailyCastingEntry_TotalRevenue))
                                {
                                    MessageBox.Show("İşlem Başarılı");
                                }
                                else
                                {
                                    MessageBox.Show("İşlem Başarısız", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                #endregion
                            }

                            nudNumberOfPeope.Value = 0;
                            nudPrice.Value = 0;
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (DailyCastingEntryType == 4)
            {
                #region Variables
                DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                string BankName = cmbBanks.Text;
                string BankCode = cmbBanks.SelectedValue.ToString();
                decimal Price = nudPrice.Value;
                int NumberOfPeople = Convert.ToInt32(nudNumberOfPeope.Value);
                #endregion

                #region Services
                Banks_Service banks_Service = new Banks_Service(unitofWork);
                DailyCastingEntry_Restaurant_Bank_Service dailyCastingEntry_Restaurant_Bank_Service = new DailyCastingEntry_Restaurant_Bank_Service(unitofWork);
                #endregion

                if (!string.IsNullOrEmpty(BankCode) && Price > 0 && NumberOfPeople > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Banks banks = banks_Service.GetBanks(BankCode);
                        DailyCastingEntry_Restaurant_Bank dailyCastingEntry_Restaurant_Bank = new DailyCastingEntry_Restaurant_Bank()
                        {
                            BankName = banks.BankName,
                            BankCode = banks.BankCode,
                            CastingDate = CastingDate,
                            NumberOfPeople = NumberOfPeople,
                            Price = Price,
                            Status = Status.Active
                        };
                        if (dailyCastingEntry_Restaurant_Bank_Service.Insert(dailyCastingEntry_Restaurant_Bank))
                        {
                            DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                            if (dailyCastingEntry_TotalRevenue != null)
                            {
                                dailyCastingEntry_TotalRevenue.RestaurantBank_ReelPrice = dailyCastingEntry_TotalRevenue.RestaurantBank_ReelPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantBank_ReelPrice + Price : Price;

                                dailyCastingEntry_TotalRevenue.RestaurantBank_TotalPrice = dailyCastingEntry_TotalRevenue.RestaurantBank_TotalPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantBank_TotalPrice + Price : Price;

                                dailyCastingEntry_TotalRevenue.RestaurantBank_NumberOfPeople = dailyCastingEntry_TotalRevenue.RestaurantBank_NumberOfPeople > 0 ? dailyCastingEntry_TotalRevenue.RestaurantBank_NumberOfPeople + NumberOfPeople : NumberOfPeople;

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
                                dailyCastingEntry_TotalRevenue = new DailyCastingEntry_TotalRevenue
                                {
                                    RestaurantBank_NumberOfPeople = NumberOfPeople,
                                    RestaurantBank_TotalPrice = Price,
                                    RestaurantBank_ReelPrice = Price,
                                    CastingDate = CastingDate
                                };

                                if (dailyCastingEntry_TotalRevenue_Service.Insert(dailyCastingEntry_TotalRevenue))
                                {
                                    MessageBox.Show("İşlem Başarılı");
                                }
                                else
                                {
                                    MessageBox.Show("İşlem Başarısız", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            };

                            cmbBanks.SelectedIndex = 0;
                            nudPrice.Value = 0;
                            nudNumberOfPeope.Value = 0;
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (DailyCastingEntryType == 5)
            {
                #region Variables
                DateTime CastingDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                string Name = cmbFoods.Text;
                string Code = cmbFoods.SelectedValue.ToString();
                decimal Price = nudPrice.Value;
                int NumberOfPeople = Convert.ToInt32(nudNumberOfPeope.Value);
                #endregion

                #region Services
                FoodCards_Service foodCards_Service = new FoodCards_Service(unitofWork);
                DailyCastingEntry_Restaurant_Food_Service dailyCastingEntry_Restaurant_Food_Service = new DailyCastingEntry_Restaurant_Food_Service(unitofWork);
                #endregion

                if (!string.IsNullOrEmpty(Code) && Price > 0 && NumberOfPeople > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FoodCards foodCards = foodCards_Service.GetFoodCards(Code);
                        DailyCastingEntry_Restaurant_Food dailyCastingEntry_Restaurant_Food = new DailyCastingEntry_Restaurant_Food()
                        {
                            FoodCardCode = foodCards.Code,
                            FoodCardName = foodCards.Name,
                            CastingDate = CastingDate,
                            NumberOfPeople = NumberOfPeople,
                            Price = Price,
                            Status = Status.Active
                        };
                        if (dailyCastingEntry_Restaurant_Food_Service.Insert(dailyCastingEntry_Restaurant_Food))
                        {
                            DailyCastingEntry_TotalRevenue dailyCastingEntry_TotalRevenue = dailyCastingEntry_TotalRevenue_Service.GetTotalRevenue(CastingDate);
                            if (dailyCastingEntry_TotalRevenue != null)
                            {
                                dailyCastingEntry_TotalRevenue.RestaurantFood_ReelPrice = dailyCastingEntry_TotalRevenue.RestaurantFood_ReelPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantFood_ReelPrice + Price : Price;

                                dailyCastingEntry_TotalRevenue.RestaurantFood_TotalPrice = dailyCastingEntry_TotalRevenue.RestaurantFood_TotalPrice > 0 ? dailyCastingEntry_TotalRevenue.RestaurantFood_TotalPrice + Price : Price;

                                dailyCastingEntry_TotalRevenue.RestaurantFood_NumberOfPeople = dailyCastingEntry_TotalRevenue.RestaurantFood_NumberOfPeople > 0 ? dailyCastingEntry_TotalRevenue.RestaurantFood_NumberOfPeople + NumberOfPeople : NumberOfPeople;

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
                                dailyCastingEntry_TotalRevenue = new DailyCastingEntry_TotalRevenue
                                {
                                    RestaurantFood_NumberOfPeople = NumberOfPeople,
                                    RestaurantFood_TotalPrice = Price,
                                    RestaurantFood_ReelPrice = Price,
                                    CastingDate = CastingDate
                                };

                                if (dailyCastingEntry_TotalRevenue_Service.Insert(dailyCastingEntry_TotalRevenue))
                                {
                                    MessageBox.Show("İşlem Başarılı");
                                }
                                else
                                {
                                    MessageBox.Show("İşlem Başarısız", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            cmbFoods.SelectedIndex = 0;
                            nudPrice.Value = 0;
                            nudNumberOfPeope.Value = 0;
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Boş Geçilemez.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch (DailyCastingEntryType)
            {
                case 1:
                    nudPrice.Value = 0;
                    txtDesciptions.Text = "";
                    break;
                case 2:
                    cmbCateringCustomer.SelectedIndex = 0;
                    nudPrice.Value = 0;
                    nudNumberOfPeope.Value = 0;
                    cmbCateringInvoice.SelectedIndex = 0;
                    cmbCateringPayment.SelectedIndex = 0;
                    break;
                case 3:
                    nudPrice.Value = 0;
                    nudNumberOfPeope.Value = 0;
                    break;
                case 4:
                    nudPrice.Value = 0;
                    nudNumberOfPeope.Value = 0;
                    cmbBanks.SelectedIndex = 0;
                    break;
                case 5:
                    nudPrice.Value = 0;
                    nudNumberOfPeope.Value = 0;
                    cmbFoods.SelectedIndex = 0;
                    break;
                default:
                    break;
            }
        }
    }
}
