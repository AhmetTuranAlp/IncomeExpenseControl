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
    public partial class Expense_Form : Form
    {
        public Expense_Form()
        {
            InitializeComponent();
        }

        #region Variables
        IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
        EnumHelper enumHelper = new EnumHelper();
        NumericUpDown nudPrice = new NumericUpDown();
        TextBox txtDesciptions = new TextBox();
        ComboBox cmbInvoice = new ComboBox();
        ComboBox cmbSuppliers = new ComboBox();
        ComboBox cmbStaffs = new ComboBox();
        ComboBox cmbStaffExpense = new ComboBox();

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
                BackColor = Color.FromArgb(224, 224, 224)
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
                BackColor = Color.FromArgb(224, 224, 224)
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
                Font = new Font("Arial", 8, FontStyle.Bold),
                BackColor = Color.FromArgb(224, 224, 224)
            };
            panel.Controls.Add(comboBox);
            return comboBox;
        }

        #endregion

        private void Expense_Form_Load(object sender, EventArgs e)
        {
            #region Vehicle Control Inputs
            pnlInput.Controls.Clear();

            Label(pnlInput, "Tutar", 38, 21);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 45);

            Label(pnlInput, "Açıklama", 38, 75);
            txtDesciptions = MultiLineTextBox(pnlInput, "txtDesciptions", 40, 100, 200);
            #endregion
        }

        private void BtnVehicle_Click(object sender, EventArgs e)
        {
            DailyCastingEntryType = 1;

            #region Left Menu Color Change
            btnVehicle.BackColor = Color.LightGray;
            btnInvoice.BackColor = Color.WhiteSmoke;
            btnSuppliers.BackColor = Color.WhiteSmoke;
            btnStaff.BackColor = Color.WhiteSmoke;
            #endregion

            #region Vehicle Control Inputs
            pnlInput.Controls.Clear();

            Label(pnlInput, "Tutar", 38, 21);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 45);

            Label(pnlInput, "Açıklama", 38, 75);
            txtDesciptions = MultiLineTextBox(pnlInput, "txtDesciptions", 40, 100, 200);
            #endregion
        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            DailyCastingEntryType = 2;

            #region Left Menu Color Change
            btnInvoice.BackColor = Color.LightGray;
            btnVehicle.BackColor = Color.WhiteSmoke;
            btnSuppliers.BackColor = Color.WhiteSmoke;
            btnStaff.BackColor = Color.WhiteSmoke;
            #endregion

            #region Invoice Control Items
            pnlInput.Controls.Clear();

            Label(pnlInput, "Fatura Tipi", 38, 20);
            cmbInvoice = Combobox(pnlInput, "cmbInvoice", 40, 45);

            List<SelectListItem> expense_SuppliersList = new List<SelectListItem>();
            expense_SuppliersList.Add(new SelectListItem() { Value = "", Text = "Fatura Tipi Seçiniz..." });
            expense_SuppliersList.AddRange(enumHelper.GetEnumListWithDescription(typeof(InvoiceType)));

            cmbInvoice.DataSource = expense_SuppliersList;
            cmbInvoice.DisplayMember = "Text";
            cmbInvoice.ValueMember = "Value";

            Label(pnlInput, "Tutar", 38, 75);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 100);

            Label(pnlInput, "Açıklama", 38, 130);
            txtDesciptions = MultiLineTextBox(pnlInput, "txtDesciptions", 40, 155, 150);

            #endregion
        }

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            DailyCastingEntryType = 3;

            #region Left Menu Color Change
            btnSuppliers.BackColor = Color.LightGray;
            btnInvoice.BackColor = Color.WhiteSmoke;
            btnVehicle.BackColor = Color.WhiteSmoke;
            btnStaff.BackColor = Color.WhiteSmoke;
            #endregion

            #region Invoice Control Items
            pnlInput.Controls.Clear();

            Label(pnlInput, "Firma", 38, 20);
            cmbSuppliers = Combobox(pnlInput, "cmbSuppliers", 40, 45);
            UnitofWork unitofWork = new UnitofWork(ctx);
            SupplierCompanies_Service supplierCompanies_Service = new SupplierCompanies_Service(unitofWork);
            List<SupplierCompanies> expense_SuppliersList = new List<SupplierCompanies>();
            expense_SuppliersList.Add(new SupplierCompanies() { Code = "", Name = "Firma Seçiniz..." });
            expense_SuppliersList.AddRange(supplierCompanies_Service.GetAllSupplierCompanies());
            cmbSuppliers.DataSource = expense_SuppliersList;
            cmbSuppliers.DisplayMember = "Name";
            cmbSuppliers.ValueMember = "Code";

            Label(pnlInput, "Tutar", 38, 75);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 100);

            Label(pnlInput, "Açıklama", 38, 130);
            txtDesciptions = MultiLineTextBox(pnlInput, "txtDesciptions", 40, 155, 150);

            #endregion
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            DailyCastingEntryType = 4;

            #region Left Menu Color Change
            btnStaff.BackColor = Color.LightGray;
            btnInvoice.BackColor = Color.WhiteSmoke;
            btnSuppliers.BackColor = Color.WhiteSmoke;
            btnVehicle.BackColor = Color.WhiteSmoke;
            #endregion

            #region Staff Control Inputs
            pnlInput.Controls.Clear();
            Label(pnlInput, "Personel", 38, 20);
            cmbStaffs = Combobox(pnlInput, "cmbStaffs", 40, 45);

            UnitofWork unitofWork = new UnitofWork(ctx);
            Staff_Service staff_Service = new Staff_Service(unitofWork);
            List<Staff> staffsList = new List<Staff>();
            staffsList.Add(new Staff() { Id = 0, FullName = "Personel Seçiniz..." });
            staffsList.AddRange(staff_Service.GetAllStaffs());
            cmbStaffs.DataSource = staffsList;
            cmbStaffs.DisplayMember = "FullName";
            cmbStaffs.ValueMember = "Id";

            Label(pnlInput, "Gider Türü", 38, 75);
            cmbStaffExpense = Combobox(pnlInput, "cmbStaffExpense", 40, 100);
            List<SelectListItem> expense_StaffsList = new List<SelectListItem>();
            expense_StaffsList.Add(new SelectListItem() { Value = "", Text = "Gider Tipi Seçiniz..." });
            expense_StaffsList.AddRange(enumHelper.GetEnumListWithDescription(typeof(StaffExpenseType)));

            cmbStaffExpense.DataSource = expense_StaffsList;
            cmbStaffExpense.DisplayMember = "Text";
            cmbStaffExpense.ValueMember = "Value";

            cmbStaffExpense.SelectedIndexChanged += new EventHandler(cmbStaffExpense_SelectedIndexChanged);


            Label(pnlInput, "Tutar", 38, 130);
            nudPrice = NumericUpDown(pnlInput, "nudPrice", 40, 155);
            #endregion
        }

        private void cmbStaffExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbStaffs.Text) && cmbStaffs.Text != "Personel Seçiniz..." && cmbStaffExpense.Text == "Maaş")
            {
                UnitofWork unitofWork = new UnitofWork(ctx);
                Staff_Service staff_Service = new Staff_Service(unitofWork);
                nudPrice.Value = staff_Service.GetStaff(cmbStaffs.Text).Salary;
            }
            else
            {
                nudPrice.Value = 0;
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DailyCastingEntryType == 1)
            {
                #region Variables
                DateTime ExpenseDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                decimal Price = nudPrice.Value;
                string Descriptions = txtDesciptions.Text;
                #endregion

                #region Service
                UnitofWork unitofWork = new UnitofWork(ctx);
                Expense_Vehicle_Service expense_Vehicle_Service = new Expense_Vehicle_Service(unitofWork);
                TotalExpenses_Service totalExpenses_Service = new TotalExpenses_Service(unitofWork);
                #endregion

                if (Price > 0 && !string.IsNullOrEmpty(Descriptions))
                {
                    DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Expense_Vehicle expense_Vehicle = new Expense_Vehicle()
                        {
                            ExpenseDate = ExpenseDate,
                            Descriptions = Descriptions,
                            Price = Price
                        };
                        if (expense_Vehicle_Service.Insert(expense_Vehicle))
                        {
                            TotalExpenses totalExpenses = totalExpenses_Service.GetTotalExpenses(ExpenseDate, ExpenseType.Vehicle);
                            if (totalExpenses != null)
                            {
                                totalExpenses.Price += Price;
                                if (totalExpenses_Service.Update(totalExpenses))
                                {
                                    MessageBox.Show("İşlem Başarılı.");

                                    txtDesciptions.Text = "";
                                    nudPrice.Value = 0;
                                }
                                else
                                {
                                    MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                totalExpenses = new TotalExpenses()
                                {
                                    ExpenseDate = ExpenseDate,
                                    ExpenseType = ExpenseType.Vehicle,
                                    ExpenseTypeDesciptions = "Araç",
                                    Price = Price,
                                    Status = Status.Active,
                                };
                                if (totalExpenses_Service.Insert(totalExpenses))
                                {
                                    MessageBox.Show("İşlem Başarılı.");

                                    txtDesciptions.Text = "";
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
                            MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DateTime ExpenseDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                InvoiceType invoiceType = new InvoiceType();
                switch (cmbInvoice.SelectedValue)
                {
                    case "0":
                        invoiceType = InvoiceType.That; break;
                    case "1":
                        invoiceType = InvoiceType.Electricity; break;
                    case "2":
                        invoiceType = InvoiceType.NaturalGas; break;
                    case "3":
                        invoiceType = InvoiceType.Internet; break;
                    case "4":
                        invoiceType = InvoiceType.Other; break;
                    default:
                        break;
                }
                string Descriptions = txtDesciptions.Text;
                decimal Price = nudPrice.Value;
                #endregion

                #region Service
                UnitofWork unitofWork = new UnitofWork(ctx);
                Expense_Invoice_Service expense_Invoice_Service = new Expense_Invoice_Service(unitofWork);
                TotalExpenses_Service totalExpenses_Service = new TotalExpenses_Service(unitofWork);
                #endregion

                if (Price > 0 && cmbInvoice.Text != "Fatura Tipi Seçiniz...")
                {
                    DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Expense_Invoice expense_Invoice = new Expense_Invoice()
                        {
                            ExpenseDate = ExpenseDate,
                            InvoiceType = enumHelper.GetEnumDescription(invoiceType),
                            Descriptions = Descriptions,
                            Price = Price,
                            Status = Status.Active
                        };
                        if (expense_Invoice_Service.Insert(expense_Invoice))
                        {
                            TotalExpenses totalExpenses = totalExpenses_Service.GetTotalExpenses(ExpenseDate, ExpenseType.Invoice);
                            if (totalExpenses != null)
                            {
                                totalExpenses.Price += Price;
                                if (totalExpenses_Service.Update(totalExpenses))
                                {
                                    MessageBox.Show("İşlem Başarılı.");

                                    cmbInvoice.SelectedIndex = 0;
                                    txtDesciptions.Text = "";
                                    nudPrice.Value = 0;
                                }
                                else
                                {
                                    MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                totalExpenses = new TotalExpenses()
                                {
                                    ExpenseDate = ExpenseDate,
                                    ExpenseType = ExpenseType.Invoice,
                                    ExpenseTypeDesciptions = "Fatura",
                                    Price = Price,
                                    Status = Status.Active,
                                };
                                if (totalExpenses_Service.Insert(totalExpenses))
                                {
                                    MessageBox.Show("İşlem Başarılı.");

                                    cmbInvoice.SelectedIndex = 0;
                                    txtDesciptions.Text = "";
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
                DateTime ExpenseDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                string SupplirsCode = cmbSuppliers.SelectedValue.ToString();
                decimal Price = nudPrice.Value;
                string Descriptions = txtDesciptions.Text;
                #endregion

                #region Service
                UnitofWork unitofWork = new UnitofWork(ctx);
                SupplierCompanies_Service supplierCompanies_Service = new SupplierCompanies_Service(unitofWork);
                Expense_Suppliers_Service expense_Suppliers_Service = new Expense_Suppliers_Service(unitofWork);
                TotalExpenses_Service totalExpenses_Service = new TotalExpenses_Service(unitofWork);
                #endregion

                if (!string.IsNullOrEmpty(SupplirsCode) && Price > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SupplierCompanies supplierCompanies = supplierCompanies_Service.GetSupplierCompanies(SupplirsCode);
                        Expense_Suppliers expense_Suppliers = new Expense_Suppliers()
                        {
                            Status = Status.Active,
                            ExpenseDate = ExpenseDate,
                            Price = Price,
                            Descriptions = Descriptions,
                            SupplierCode = supplierCompanies.Code,
                            SupplierName = supplierCompanies.Name
                        };
                        if (expense_Suppliers_Service.Insert(expense_Suppliers))
                        {
                            TotalExpenses totalExpenses = totalExpenses_Service.GetTotalExpenses(ExpenseDate, ExpenseType.Suppliers);
                            if (totalExpenses != null)
                            {
                                totalExpenses.Price += Price;
                                if (totalExpenses_Service.Update(totalExpenses))
                                {
                                    MessageBox.Show("İşlem Başarılı.");

                                    cmbSuppliers.SelectedIndex = 0;
                                    txtDesciptions.Text = "";
                                    nudPrice.Value = 0;
                                }
                                else
                                {
                                    MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                totalExpenses = new TotalExpenses()
                                {
                                    ExpenseDate = ExpenseDate,
                                    ExpenseType = ExpenseType.Suppliers,
                                    ExpenseTypeDesciptions = "Tedarikçi",
                                    Price = Price,
                                    Status = Status.Active,
                                };
                                if (totalExpenses_Service.Insert(totalExpenses))
                                {
                                    MessageBox.Show("İşlem Başarılı.");

                                    cmbSuppliers.SelectedIndex = 0;
                                    txtDesciptions.Text = "";
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
                DateTime ExpenseDate = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", DateTime.Now));
                string FullName = cmbStaffs.Text;
                string StaffExpenseType = cmbStaffExpense.Text;
                decimal Price = nudPrice.Value;
                #endregion

                #region Service
                UnitofWork unitofWork = new UnitofWork(ctx);
                Staff_Service staff_Service = new Staff_Service(unitofWork);
                Expense_Staff_Service expense_Staff_Service = new Expense_Staff_Service(unitofWork);
                TotalExpenses_Service totalExpenses_Service = new TotalExpenses_Service(unitofWork);
                #endregion

                if (!string.IsNullOrEmpty(FullName) && !string.IsNullOrEmpty(StaffExpenseType) && Price > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek İstediğinize Emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Expense_Staff expense_Staff = new Expense_Staff()
                        {
                            ExpenseDate = ExpenseDate,
                            FullName = FullName,
                            Price = Price,
                            StaffExpenseType = StaffExpenseType,
                            Status = Status.Active
                        };
                        if (expense_Staff_Service.Insert(expense_Staff))
                        {
                            TotalExpenses totalExpenses = totalExpenses_Service.GetTotalExpenses(ExpenseDate, ExpenseType.Staff);
                            if (totalExpenses != null)
                            {
                                totalExpenses.Price += Price;
                                if (totalExpenses_Service.Update(totalExpenses))
                                {
                                    MessageBox.Show("İşlem Başarılı.");

                                    cmbStaffs.SelectedIndex = 0;
                                    cmbStaffExpense.SelectedIndex = 0;
                                    nudPrice.Value = 0;
                                }
                                else
                                {
                                    MessageBox.Show("İşlem Başarısız.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                totalExpenses = new TotalExpenses()
                                {
                                    ExpenseDate = ExpenseDate,
                                    ExpenseType = ExpenseType.Staff,
                                    ExpenseTypeDesciptions = "Personel",
                                    Price = Price,
                                    Status = Status.Active,
                                };
                                if (totalExpenses_Service.Insert(totalExpenses))
                                {
                                    MessageBox.Show("İşlem Başarılı.");

                                    cmbStaffs.SelectedIndex = 0;
                                    cmbStaffExpense.SelectedIndex = 0;
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
                    cmbInvoice.SelectedIndex = 0;
                    nudPrice.Value = 0;
                    txtDesciptions.Text = "";
                    break;
                case 3:
                    cmbSuppliers.SelectedIndex = 0;
                    nudPrice.Value = 0;
                    txtDesciptions.Text = "";
                    break;
                case 4:
                    nudPrice.Value = 0;
                    cmbStaffs.SelectedIndex = 0;
                    cmbStaffExpense.SelectedIndex = 0;
                    break;
                default:
                    break;
            }
        }
    }
}
