namespace IncomeExpenseControl.WinForm
{
    partial class FoodCards_Form
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
            this.btnFoodCardSave = new System.Windows.Forms.Button();
            this.txtFoodCardDescriptions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodCardName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnFoodCardSave);
            this.panel1.Controls.Add(this.txtFoodCardDescriptions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFoodCardName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 176);
            this.panel1.TabIndex = 1;
            // 
            // btnFoodCardSave
            // 
            this.btnFoodCardSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFoodCardSave.Location = new System.Drawing.Point(83, 124);
            this.btnFoodCardSave.Name = "btnFoodCardSave";
            this.btnFoodCardSave.Size = new System.Drawing.Size(235, 33);
            this.btnFoodCardSave.TabIndex = 17;
            this.btnFoodCardSave.Text = "Kaydet";
            this.btnFoodCardSave.UseVisualStyleBackColor = true;
            this.btnFoodCardSave.Click += new System.EventHandler(this.btnFoodCardSave_Click);
            // 
            // txtFoodCardDescriptions
            // 
            this.txtFoodCardDescriptions.Location = new System.Drawing.Point(83, 40);
            this.txtFoodCardDescriptions.Multiline = true;
            this.txtFoodCardDescriptions.Name = "txtFoodCardDescriptions";
            this.txtFoodCardDescriptions.Size = new System.Drawing.Size(235, 78);
            this.txtFoodCardDescriptions.TabIndex = 16;
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
            // txtFoodCardName
            // 
            this.txtFoodCardName.Location = new System.Drawing.Point(83, 14);
            this.txtFoodCardName.Name = "txtFoodCardName";
            this.txtFoodCardName.Size = new System.Drawing.Size(235, 20);
            this.txtFoodCardName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kart Adı:";
            // 
            // FoodCards_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 181);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FoodCards_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek Kartı Ekle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFoodCardSave;
        private System.Windows.Forms.TextBox txtFoodCardDescriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoodCardName;
        private System.Windows.Forms.Label label6;
    }
}