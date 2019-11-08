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
            this.gelirlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cateringToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restoranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şahsiGelirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cateringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekGönderimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirlerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cateringToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sahsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamGelirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirlerToolStripMenuItem,
            this.cateringToolStripMenuItem,
            this.raporlarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gelirlerToolStripMenuItem
            // 
            this.gelirlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cateringToolStripMenuItem1,
            this.restoranToolStripMenuItem,
            this.şahsiGelirToolStripMenuItem});
            this.gelirlerToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirlerToolStripMenuItem.Name = "gelirlerToolStripMenuItem";
            this.gelirlerToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.gelirlerToolStripMenuItem.Text = "Gelir Girişi";
            // 
            // cateringToolStripMenuItem1
            // 
            this.cateringToolStripMenuItem1.Name = "cateringToolStripMenuItem1";
            this.cateringToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.cateringToolStripMenuItem1.Text = "Catering";
            this.cateringToolStripMenuItem1.Click += new System.EventHandler(this.CateringToolStripMenuItem1_Click);
            // 
            // restoranToolStripMenuItem
            // 
            this.restoranToolStripMenuItem.Name = "restoranToolStripMenuItem";
            this.restoranToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.restoranToolStripMenuItem.Text = "Restaurant";
            // 
            // şahsiGelirToolStripMenuItem
            // 
            this.şahsiGelirToolStripMenuItem.Name = "şahsiGelirToolStripMenuItem";
            this.şahsiGelirToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.şahsiGelirToolStripMenuItem.Text = "Şahsi Gelir";
            // 
            // cateringToolStripMenuItem
            // 
            this.cateringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaEkleToolStripMenuItem,
            this.yemekGönderimiToolStripMenuItem,
            this.hizmetlerToolStripMenuItem});
            this.cateringToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cateringToolStripMenuItem.Name = "cateringToolStripMenuItem";
            this.cateringToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cateringToolStripMenuItem.Text = "Catering";
            // 
            // firmaEkleToolStripMenuItem
            // 
            this.firmaEkleToolStripMenuItem.Name = "firmaEkleToolStripMenuItem";
            this.firmaEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaEkleToolStripMenuItem.Text = "Firma İşlemleri";
            this.firmaEkleToolStripMenuItem.Click += new System.EventHandler(this.FirmaEkleToolStripMenuItem_Click);
            // 
            // yemekGönderimiToolStripMenuItem
            // 
            this.yemekGönderimiToolStripMenuItem.Name = "yemekGönderimiToolStripMenuItem";
            this.yemekGönderimiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yemekGönderimiToolStripMenuItem.Text = "Yemek Servis";
            this.yemekGönderimiToolStripMenuItem.Click += new System.EventHandler(this.YemekGönderimiToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem1
            // 
            this.raporlarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirlerToolStripMenuItem2,
            this.giderlerToolStripMenuItem});
            this.raporlarToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporlarToolStripMenuItem1.Name = "raporlarToolStripMenuItem1";
            this.raporlarToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.raporlarToolStripMenuItem1.Text = "Raporlar";
            // 
            // gelirlerToolStripMenuItem2
            // 
            this.gelirlerToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cateringToolStripMenuItem3,
            this.restaurantToolStripMenuItem,
            this.sahsiToolStripMenuItem,
            this.toplamGelirToolStripMenuItem});
            this.gelirlerToolStripMenuItem2.Name = "gelirlerToolStripMenuItem2";
            this.gelirlerToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.gelirlerToolStripMenuItem2.Text = "Gelirler";
            // 
            // cateringToolStripMenuItem3
            // 
            this.cateringToolStripMenuItem3.Name = "cateringToolStripMenuItem3";
            this.cateringToolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            this.cateringToolStripMenuItem3.Text = "Catering Gelirleri";
            // 
            // restaurantToolStripMenuItem
            // 
            this.restaurantToolStripMenuItem.Name = "restaurantToolStripMenuItem";
            this.restaurantToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.restaurantToolStripMenuItem.Text = "Restaurant Gelirleri";
            // 
            // sahsiToolStripMenuItem
            // 
            this.sahsiToolStripMenuItem.Name = "sahsiToolStripMenuItem";
            this.sahsiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sahsiToolStripMenuItem.Text = "Şahsi Gelirler";
            // 
            // toplamGelirToolStripMenuItem
            // 
            this.toplamGelirToolStripMenuItem.Name = "toplamGelirToolStripMenuItem";
            this.toplamGelirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.toplamGelirToolStripMenuItem.Text = "Detaylı Raporlama";
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // hizmetlerToolStripMenuItem
            // 
            this.hizmetlerToolStripMenuItem.Name = "hizmetlerToolStripMenuItem";
            this.hizmetlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hizmetlerToolStripMenuItem.Text = "Hizmetler";
            this.hizmetlerToolStripMenuItem.Click += new System.EventHandler(this.hizmetlerToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem gelirlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cateringToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restoranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şahsiGelirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gelirlerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cateringToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem restaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sahsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamGelirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizmetlerToolStripMenuItem;
    }
}