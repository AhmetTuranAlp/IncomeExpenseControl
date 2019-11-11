namespace IncomeExpenseControl.WinForm
{
    partial class DailyCastingEntry_Restaurant_Cash_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnNewSave);
            this.panel1.Controls.Add(this.nudNumberOfPeople);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 148);
            this.panel1.TabIndex = 0;
            // 
            // nudNumberOfPeople
            // 
            this.nudNumberOfPeople.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudNumberOfPeople.Location = new System.Drawing.Point(90, 52);
            this.nudNumberOfPeople.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNumberOfPeople.Name = "nudNumberOfPeople";
            this.nudNumberOfPeople.Size = new System.Drawing.Size(175, 20);
            this.nudNumberOfPeople.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kişi Sayısı:";
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPrice.Location = new System.Drawing.Point(90, 26);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(175, 20);
            this.nudPrice.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fiyat:";
            // 
            // btnNewSave
            // 
            this.btnNewSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewSave.Location = new System.Drawing.Point(90, 90);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(175, 36);
            this.btnNewSave.TabIndex = 11;
            this.btnNewSave.Text = "Kaydet";
            this.btnNewSave.UseVisualStyleBackColor = true;
            this.btnNewSave.Click += new System.EventHandler(this.BtnNewSave_Click);
            // 
            // DailyCastingEntry_Restaurant_Cash_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 151);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DailyCastingEntry_Restaurant_Cash_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Nakit Ödeme";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudNumberOfPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewSave;
    }
}