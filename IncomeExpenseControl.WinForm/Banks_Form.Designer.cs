namespace IncomeExpenseControl.WinForm
{
    partial class Banks_Form
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
            this.btnBankSave = new System.Windows.Forms.Button();
            this.txtBankDescriptions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnBankSave);
            this.panel1.Controls.Add(this.txtBankDescriptions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBankName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 176);
            this.panel1.TabIndex = 0;
            // 
            // btnBankSave
            // 
            this.btnBankSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankSave.Location = new System.Drawing.Point(83, 124);
            this.btnBankSave.Name = "btnBankSave";
            this.btnBankSave.Size = new System.Drawing.Size(235, 33);
            this.btnBankSave.TabIndex = 17;
            this.btnBankSave.Text = "Kaydet";
            this.btnBankSave.UseVisualStyleBackColor = true;
            this.btnBankSave.Click += new System.EventHandler(this.btnBankSave_Click);
            // 
            // txtBankDescriptions
            // 
            this.txtBankDescriptions.Location = new System.Drawing.Point(83, 40);
            this.txtBankDescriptions.Multiline = true;
            this.txtBankDescriptions.Name = "txtBankDescriptions";
            this.txtBankDescriptions.Size = new System.Drawing.Size(235, 78);
            this.txtBankDescriptions.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Açıklama:";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(83, 14);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(235, 20);
            this.txtBankName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Banka Adı:";
            // 
            // Banks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 180);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Banks_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Ekle";
            this.Load += new System.EventHandler(this.Banks_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBankDescriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBankSave;
    }
}