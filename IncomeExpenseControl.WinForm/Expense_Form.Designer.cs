namespace IncomeExpenseControl.WinForm
{
    partial class Expense_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlInput = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnRestaurantFood = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInput.Location = new System.Drawing.Point(307, 1);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(455, 359);
            this.pnlInput.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pnlInput);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(1, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 420);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Location = new System.Drawing.Point(307, 361);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 53);
            this.panel4.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(2, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(224, 48);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(229, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 48);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnVehicle);
            this.panel2.Controls.Add(this.btnSuppliers);
            this.panel2.Controls.Add(this.btnRestaurantFood);
            this.panel2.Controls.Add(this.btnStaff);
            this.panel2.Controls.Add(this.btnInvoice);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 413);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(0, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 52);
            this.button3.TabIndex = 8;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(0, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 52);
            this.button2.TabIndex = 7;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(0, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 52);
            this.button1.TabIndex = 6;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnVehicle
            // 
            this.btnVehicle.BackColor = System.Drawing.Color.LightGray;
            this.btnVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVehicle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVehicle.Location = new System.Drawing.Point(0, 0);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(301, 52);
            this.btnVehicle.TabIndex = 1;
            this.btnVehicle.Text = "     Araç Giderleri";
            this.btnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicle.UseVisualStyleBackColor = false;
            this.btnVehicle.Click += new System.EventHandler(this.BtnVehicle_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSuppliers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSuppliers.Location = new System.Drawing.Point(0, 102);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(301, 52);
            this.btnSuppliers.TabIndex = 3;
            this.btnSuppliers.Text = "     Tedarikçi Giderleri";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
            // 
            // btnRestaurantFood
            // 
            this.btnRestaurantFood.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestaurantFood.Enabled = false;
            this.btnRestaurantFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestaurantFood.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestaurantFood.Location = new System.Drawing.Point(0, 204);
            this.btnRestaurantFood.Name = "btnRestaurantFood";
            this.btnRestaurantFood.Size = new System.Drawing.Size(301, 52);
            this.btnRestaurantFood.TabIndex = 5;
            this.btnRestaurantFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurantFood.UseVisualStyleBackColor = false;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStaff.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStaff.Location = new System.Drawing.Point(0, 153);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(301, 52);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "     Personel Giderleri";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoice.Location = new System.Drawing.Point(0, 51);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(301, 52);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "     Fatura Giderleri";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.BtnInvoice_Click);
            // 
            // Expense_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 420);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Expense_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Ekle";
            this.Load += new System.EventHandler(this.Expense_Form_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnRestaurantFood;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}