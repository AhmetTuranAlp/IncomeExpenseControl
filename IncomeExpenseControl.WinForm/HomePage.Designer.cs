namespace IncomeExpenseControl.WinForm
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cateringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekGönderimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cateringToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cateringToolStripMenuItem
            // 
            this.cateringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaEkleToolStripMenuItem,
            this.yemekGönderimiToolStripMenuItem,
            this.ödemeToolStripMenuItem});
            this.cateringToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cateringToolStripMenuItem.Name = "cateringToolStripMenuItem";
            this.cateringToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cateringToolStripMenuItem.Text = "Catering";
            // 
            // firmaEkleToolStripMenuItem
            // 
            this.firmaEkleToolStripMenuItem.Name = "firmaEkleToolStripMenuItem";
            this.firmaEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaEkleToolStripMenuItem.Text = "Firma Ekle";
            this.firmaEkleToolStripMenuItem.Click += new System.EventHandler(this.FirmaEkleToolStripMenuItem_Click);
            // 
            // yemekGönderimiToolStripMenuItem
            // 
            this.yemekGönderimiToolStripMenuItem.Name = "yemekGönderimiToolStripMenuItem";
            this.yemekGönderimiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yemekGönderimiToolStripMenuItem.Text = "Yemek Gönderimi";
            this.yemekGönderimiToolStripMenuItem.Click += new System.EventHandler(this.YemekGönderimiToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ödemeToolStripMenuItem.Text = "Ödeme";
            this.ödemeToolStripMenuItem.Click += new System.EventHandler(this.ÖdemeToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IncomeExpenseControl.WinForm.Properties.Resources.White_Stripes_and_Red_Stripe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cateringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekGönderimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
    }
}