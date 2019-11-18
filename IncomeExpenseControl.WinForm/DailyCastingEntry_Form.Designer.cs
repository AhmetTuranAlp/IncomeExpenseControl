namespace IncomeExpenseControl.WinForm
{
    partial class DailyCastingEntry_Form
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnRestaurantCash = new System.Windows.Forms.Button();
            this.btnRestaurantFood = new System.Windows.Forms.Button();
            this.btnRestaurantCredit = new System.Windows.Forms.Button();
            this.btnCatering = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pnlInput);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 266);
            this.panel3.TabIndex = 2;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInput.Location = new System.Drawing.Point(307, 1);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(455, 205);
            this.pnlInput.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Location = new System.Drawing.Point(307, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 53);
            this.panel4.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(2, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(229, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 48);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPersonal);
            this.panel2.Controls.Add(this.btnRestaurantCash);
            this.panel2.Controls.Add(this.btnRestaurantFood);
            this.panel2.Controls.Add(this.btnRestaurantCredit);
            this.panel2.Controls.Add(this.btnCatering);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 261);
            this.panel2.TabIndex = 3;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.LightGray;
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonal.Location = new System.Drawing.Point(0, 0);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(301, 52);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "     Şahsi";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnRestaurantCash
            // 
            this.btnRestaurantCash.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestaurantCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestaurantCash.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestaurantCash.Location = new System.Drawing.Point(0, 102);
            this.btnRestaurantCash.Name = "btnRestaurantCash";
            this.btnRestaurantCash.Size = new System.Drawing.Size(301, 52);
            this.btnRestaurantCash.TabIndex = 3;
            this.btnRestaurantCash.Text = "     Restaurant > Nakit";
            this.btnRestaurantCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurantCash.UseVisualStyleBackColor = false;
            this.btnRestaurantCash.Click += new System.EventHandler(this.btnRestaurantCash_Click);
            // 
            // btnRestaurantFood
            // 
            this.btnRestaurantFood.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestaurantFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestaurantFood.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestaurantFood.Location = new System.Drawing.Point(0, 204);
            this.btnRestaurantFood.Name = "btnRestaurantFood";
            this.btnRestaurantFood.Size = new System.Drawing.Size(301, 52);
            this.btnRestaurantFood.TabIndex = 5;
            this.btnRestaurantFood.Text = "     Restaurant > Yemek Kartı";
            this.btnRestaurantFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurantFood.UseVisualStyleBackColor = false;
            this.btnRestaurantFood.Click += new System.EventHandler(this.btnRestaurantFood_Click);
            // 
            // btnRestaurantCredit
            // 
            this.btnRestaurantCredit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestaurantCredit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestaurantCredit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestaurantCredit.Location = new System.Drawing.Point(0, 153);
            this.btnRestaurantCredit.Name = "btnRestaurantCredit";
            this.btnRestaurantCredit.Size = new System.Drawing.Size(301, 52);
            this.btnRestaurantCredit.TabIndex = 4;
            this.btnRestaurantCredit.Text = "     Restaurant > Kredi Kartı";
            this.btnRestaurantCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurantCredit.UseVisualStyleBackColor = false;
            this.btnRestaurantCredit.Click += new System.EventHandler(this.btnRestaurantCredit_Click);
            // 
            // btnCatering
            // 
            this.btnCatering.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCatering.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCatering.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCatering.Location = new System.Drawing.Point(0, 51);
            this.btnCatering.Name = "btnCatering";
            this.btnCatering.Size = new System.Drawing.Size(301, 52);
            this.btnCatering.TabIndex = 2;
            this.btnCatering.Text = "     Catering";
            this.btnCatering.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatering.UseVisualStyleBackColor = false;
            this.btnCatering.Click += new System.EventHandler(this.btnCatering_Click);
            // 
            // DailyCastingEntry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(771, 268);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DailyCastingEntry_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Günlük Gelir Dökümü";
            this.Load += new System.EventHandler(this.DailyCastingEntry_Form_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnRestaurantCash;
        private System.Windows.Forms.Button btnRestaurantFood;
        private System.Windows.Forms.Button btnRestaurantCredit;
        private System.Windows.Forms.Button btnCatering;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlInput;
    }
}