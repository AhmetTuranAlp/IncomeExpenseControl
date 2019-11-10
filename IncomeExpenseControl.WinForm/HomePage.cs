using IncomeExpenseControl.Data.Context;
using IncomeExpenseControl.Data.Entity;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public void Subform(Form form)
        {
            try
            {
                bool status = false;
                foreach (Form element in this.MdiChildren)
                {
                    if (element.Text == form.Text)
                    {
                        status = true;
                        element.Activate();
                    }
                    else
                    {
                        element.Close();
                    }
                }
                if (status == false)
                {
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            IncomeExpenseControlDbContext ctx = new IncomeExpenseControlDbContext();
            if (ctx.Coder.Count() == 0)
            {
                Coder coder = new Coder();
                coder.Name = "Ahmet Turan";
                coder.Surname = "Alp";
                ctx.Coder.Add(coder);
                ctx.SaveChanges();
            }
        }

        private void ŞahsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCastingEntry_Personal_Form dailyCastingEntry_Personal_Form = new DailyCastingEntry_Personal_Form();
            Subform(dailyCastingEntry_Personal_Form);
        }
    }
}
