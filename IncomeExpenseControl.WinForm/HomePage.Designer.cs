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
            this.günlükDökümGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cateringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nakitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediKartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekKarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şahsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cateringFirmaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiFirmaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geliirleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamGelirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cateringGelirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şahsiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükDökümGirişiToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.tanımlamalarToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // günlükDökümGirişiToolStripMenuItem
            // 
            this.günlükDökümGirişiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cateringToolStripMenuItem,
            this.restoranToolStripMenuItem,
            this.şahsiToolStripMenuItem});
            this.günlükDökümGirişiToolStripMenuItem.Name = "günlükDökümGirişiToolStripMenuItem";
            this.günlükDökümGirişiToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.günlükDökümGirişiToolStripMenuItem.Text = "Günlük Döküm Girişi";
            // 
            // cateringToolStripMenuItem
            // 
            this.cateringToolStripMenuItem.Name = "cateringToolStripMenuItem";
            this.cateringToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cateringToolStripMenuItem.Text = "Catering";
            this.cateringToolStripMenuItem.Click += new System.EventHandler(this.cateringToolStripMenuItem_Click);
            // 
            // restoranToolStripMenuItem
            // 
            this.restoranToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nakitToolStripMenuItem,
            this.krediKartToolStripMenuItem,
            this.yemekKarToolStripMenuItem});
            this.restoranToolStripMenuItem.Name = "restoranToolStripMenuItem";
            this.restoranToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.restoranToolStripMenuItem.Text = "Restaurant";
            // 
            // nakitToolStripMenuItem
            // 
            this.nakitToolStripMenuItem.Name = "nakitToolStripMenuItem";
            this.nakitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nakitToolStripMenuItem.Text = "Nakit";
            this.nakitToolStripMenuItem.Click += new System.EventHandler(this.NakitToolStripMenuItem_Click);
            // 
            // krediKartToolStripMenuItem
            // 
            this.krediKartToolStripMenuItem.Name = "krediKartToolStripMenuItem";
            this.krediKartToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.krediKartToolStripMenuItem.Text = "Kredi Kart";
            this.krediKartToolStripMenuItem.Click += new System.EventHandler(this.krediKartToolStripMenuItem_Click);
            // 
            // yemekKarToolStripMenuItem
            // 
            this.yemekKarToolStripMenuItem.Name = "yemekKarToolStripMenuItem";
            this.yemekKarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.yemekKarToolStripMenuItem.Text = "Yemek Kart";
            this.yemekKarToolStripMenuItem.Click += new System.EventHandler(this.yemekKarToolStripMenuItem_Click);
            // 
            // şahsiToolStripMenuItem
            // 
            this.şahsiToolStripMenuItem.Name = "şahsiToolStripMenuItem";
            this.şahsiToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.şahsiToolStripMenuItem.Text = "Şahsi";
            this.şahsiToolStripMenuItem.Click += new System.EventHandler(this.ŞahsiToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tedarikçilerToolStripMenuItem,
            this.araçToolStripMenuItem,
            this.faturalarToolStripMenuItem});
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // tedarikçilerToolStripMenuItem
            // 
            this.tedarikçilerToolStripMenuItem.Name = "tedarikçilerToolStripMenuItem";
            this.tedarikçilerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tedarikçilerToolStripMenuItem.Text = "Tedarikçiler";
            this.tedarikçilerToolStripMenuItem.Click += new System.EventHandler(this.tedarikçilerToolStripMenuItem_Click);
            // 
            // araçToolStripMenuItem
            // 
            this.araçToolStripMenuItem.Name = "araçToolStripMenuItem";
            this.araçToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.araçToolStripMenuItem.Text = "Araç";
            this.araçToolStripMenuItem.Click += new System.EventHandler(this.araçToolStripMenuItem_Click);
            // 
            // faturalarToolStripMenuItem
            // 
            this.faturalarToolStripMenuItem.Name = "faturalarToolStripMenuItem";
            this.faturalarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.faturalarToolStripMenuItem.Text = "Faturalar";
            this.faturalarToolStripMenuItem.Click += new System.EventHandler(this.faturalarToolStripMenuItem_Click);
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cateringFirmaEkleToolStripMenuItem,
            this.tedarikçiFirmaEkleToolStripMenuItem,
            this.bankaToolStripMenuItem,
            this.yemekKartıToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // cateringFirmaEkleToolStripMenuItem
            // 
            this.cateringFirmaEkleToolStripMenuItem.Name = "cateringFirmaEkleToolStripMenuItem";
            this.cateringFirmaEkleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cateringFirmaEkleToolStripMenuItem.Text = "Catering Firma";
            this.cateringFirmaEkleToolStripMenuItem.Click += new System.EventHandler(this.CateringFirmaEkleToolStripMenuItem_Click);
            // 
            // tedarikçiFirmaEkleToolStripMenuItem
            // 
            this.tedarikçiFirmaEkleToolStripMenuItem.Name = "tedarikçiFirmaEkleToolStripMenuItem";
            this.tedarikçiFirmaEkleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.tedarikçiFirmaEkleToolStripMenuItem.Text = "Tedarikçi Firma";
            this.tedarikçiFirmaEkleToolStripMenuItem.Click += new System.EventHandler(this.TedarikçiFirmaEkleToolStripMenuItem_Click);
            // 
            // bankaToolStripMenuItem
            // 
            this.bankaToolStripMenuItem.Name = "bankaToolStripMenuItem";
            this.bankaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bankaToolStripMenuItem.Text = "Banka";
            this.bankaToolStripMenuItem.Click += new System.EventHandler(this.bankaToolStripMenuItem_Click);
            // 
            // yemekKartıToolStripMenuItem
            // 
            this.yemekKartıToolStripMenuItem.Name = "yemekKartıToolStripMenuItem";
            this.yemekKartıToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yemekKartıToolStripMenuItem.Text = "Yemek Kartı";
            this.yemekKartıToolStripMenuItem.Click += new System.EventHandler(this.yemekKartıToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geliirleToolStripMenuItem,
            this.giderlerToolStripMenuItem1,
            this.tanımlamalarToolStripMenuItem1});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // geliirleToolStripMenuItem
            // 
            this.geliirleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplamGelirToolStripMenuItem,
            this.cateringGelirToolStripMenuItem,
            this.restaurantToolStripMenuItem,
            this.şahsiToolStripMenuItem1});
            this.geliirleToolStripMenuItem.Name = "geliirleToolStripMenuItem";
            this.geliirleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.geliirleToolStripMenuItem.Text = "Gelirler";
            // 
            // toplamGelirToolStripMenuItem
            // 
            this.toplamGelirToolStripMenuItem.Name = "toplamGelirToolStripMenuItem";
            this.toplamGelirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toplamGelirToolStripMenuItem.Text = "Toplam Gelir";
            this.toplamGelirToolStripMenuItem.Click += new System.EventHandler(this.ToplamGelirToolStripMenuItem_Click);
            // 
            // cateringGelirToolStripMenuItem
            // 
            this.cateringGelirToolStripMenuItem.Name = "cateringGelirToolStripMenuItem";
            this.cateringGelirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cateringGelirToolStripMenuItem.Text = "Catering";
            this.cateringGelirToolStripMenuItem.Click += new System.EventHandler(this.CateringGelirToolStripMenuItem_Click);
            // 
            // restaurantToolStripMenuItem
            // 
            this.restaurantToolStripMenuItem.Name = "restaurantToolStripMenuItem";
            this.restaurantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurantToolStripMenuItem.Text = "Restaurant";
            // 
            // şahsiToolStripMenuItem1
            // 
            this.şahsiToolStripMenuItem1.Name = "şahsiToolStripMenuItem1";
            this.şahsiToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.şahsiToolStripMenuItem1.Text = "Şahsi";
            // 
            // giderlerToolStripMenuItem1
            // 
            this.giderlerToolStripMenuItem1.Name = "giderlerToolStripMenuItem1";
            this.giderlerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.giderlerToolStripMenuItem1.Text = "Giderler";
            // 
            // tanımlamalarToolStripMenuItem1
            // 
            this.tanımlamalarToolStripMenuItem1.Name = "tanımlamalarToolStripMenuItem1";
            this.tanımlamalarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tanımlamalarToolStripMenuItem1.Text = "Tanımlamalar";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IncomeExpenseControl.WinForm.Properties.Resources._753114_download_white_black_wallpapers_dh45_1920x1080_h;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripMenuItem günlükDökümGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cateringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cateringFirmaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikçiFirmaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekKartıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nakitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediKartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekKarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şahsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikçilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geliirleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toplamGelirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cateringGelirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şahsiToolStripMenuItem1;
    }
}