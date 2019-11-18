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
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geliirleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şahsiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cateringGelirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamGelirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçilerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.araçToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cateringFirmaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiFirmaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükDökümGirişiToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.tanımlamalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // günlükDökümGirişiToolStripMenuItem
            // 
            this.günlükDökümGirişiToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.günlükDökümGirişiToolStripMenuItem.Name = "günlükDökümGirişiToolStripMenuItem";
            this.günlükDökümGirişiToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.günlükDökümGirişiToolStripMenuItem.Text = "Günlük Döküm Girişi";
            this.günlükDökümGirişiToolStripMenuItem.Click += new System.EventHandler(this.günlükDökümGirişiToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            this.giderlerToolStripMenuItem.Click += new System.EventHandler(this.GiderlerToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geliirleToolStripMenuItem,
            this.giderlerToolStripMenuItem1,
            this.tanımlamalarToolStripMenuItem1});
            this.raporlarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // geliirleToolStripMenuItem
            // 
            this.geliirleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şahsiToolStripMenuItem1,
            this.cateringGelirToolStripMenuItem,
            this.restaurantToolStripMenuItem,
            this.toplamGelirToolStripMenuItem});
            this.geliirleToolStripMenuItem.Name = "geliirleToolStripMenuItem";
            this.geliirleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.geliirleToolStripMenuItem.Text = "Gelirler";
            // 
            // şahsiToolStripMenuItem1
            // 
            this.şahsiToolStripMenuItem1.Name = "şahsiToolStripMenuItem1";
            this.şahsiToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.şahsiToolStripMenuItem1.Text = "Şahsi";
            this.şahsiToolStripMenuItem1.Click += new System.EventHandler(this.şahsiToolStripMenuItem1_Click);
            // 
            // cateringGelirToolStripMenuItem
            // 
            this.cateringGelirToolStripMenuItem.Name = "cateringGelirToolStripMenuItem";
            this.cateringGelirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cateringGelirToolStripMenuItem.Text = "Catering";
            this.cateringGelirToolStripMenuItem.Click += new System.EventHandler(this.CateringGelirToolStripMenuItem_Click);
            // 
            // restaurantToolStripMenuItem
            // 
            this.restaurantToolStripMenuItem.Name = "restaurantToolStripMenuItem";
            this.restaurantToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.restaurantToolStripMenuItem.Text = "Restaurant";
            this.restaurantToolStripMenuItem.Click += new System.EventHandler(this.RestaurantToolStripMenuItem_Click);
            // 
            // toplamGelirToolStripMenuItem
            // 
            this.toplamGelirToolStripMenuItem.Name = "toplamGelirToolStripMenuItem";
            this.toplamGelirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.toplamGelirToolStripMenuItem.Text = "Toplam Gelir";
            this.toplamGelirToolStripMenuItem.Click += new System.EventHandler(this.ToplamGelirToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem1
            // 
            this.giderlerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tedarikçilerToolStripMenuItem1,
            this.personellerToolStripMenuItem,
            this.faturalarToolStripMenuItem1,
            this.araçToolStripMenuItem1});
            this.giderlerToolStripMenuItem1.Name = "giderlerToolStripMenuItem1";
            this.giderlerToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.giderlerToolStripMenuItem1.Text = "Giderler";
            // 
            // tedarikçilerToolStripMenuItem1
            // 
            this.tedarikçilerToolStripMenuItem1.Name = "tedarikçilerToolStripMenuItem1";
            this.tedarikçilerToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.tedarikçilerToolStripMenuItem1.Text = "Tedarikçiler";
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.personellerToolStripMenuItem.Text = "Personeller";
            // 
            // faturalarToolStripMenuItem1
            // 
            this.faturalarToolStripMenuItem1.Name = "faturalarToolStripMenuItem1";
            this.faturalarToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.faturalarToolStripMenuItem1.Text = "Faturalar";
            // 
            // araçToolStripMenuItem1
            // 
            this.araçToolStripMenuItem1.Name = "araçToolStripMenuItem1";
            this.araçToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.araçToolStripMenuItem1.Text = "Araç";
            // 
            // tanımlamalarToolStripMenuItem1
            // 
            this.tanımlamalarToolStripMenuItem1.Name = "tanımlamalarToolStripMenuItem1";
            this.tanımlamalarToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.tanımlamalarToolStripMenuItem1.Text = "Tanımlamalar";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cateringFirmaEkleToolStripMenuItem,
            this.tedarikçiFirmaEkleToolStripMenuItem,
            this.bankaToolStripMenuItem,
            this.yemekKartıToolStripMenuItem,
            this.personelToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // cateringFirmaEkleToolStripMenuItem
            // 
            this.cateringFirmaEkleToolStripMenuItem.Name = "cateringFirmaEkleToolStripMenuItem";
            this.cateringFirmaEkleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cateringFirmaEkleToolStripMenuItem.Text = "Catering Firma";
            this.cateringFirmaEkleToolStripMenuItem.Click += new System.EventHandler(this.CateringFirmaEkleToolStripMenuItem_Click);
            // 
            // tedarikçiFirmaEkleToolStripMenuItem
            // 
            this.tedarikçiFirmaEkleToolStripMenuItem.Name = "tedarikçiFirmaEkleToolStripMenuItem";
            this.tedarikçiFirmaEkleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tedarikçiFirmaEkleToolStripMenuItem.Text = "Tedarikçi Firma";
            this.tedarikçiFirmaEkleToolStripMenuItem.Click += new System.EventHandler(this.TedarikçiFirmaEkleToolStripMenuItem_Click);
            // 
            // bankaToolStripMenuItem
            // 
            this.bankaToolStripMenuItem.Name = "bankaToolStripMenuItem";
            this.bankaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bankaToolStripMenuItem.Text = "Banka";
            this.bankaToolStripMenuItem.Click += new System.EventHandler(this.bankaToolStripMenuItem_Click);
            // 
            // yemekKartıToolStripMenuItem
            // 
            this.yemekKartıToolStripMenuItem.Name = "yemekKartıToolStripMenuItem";
            this.yemekKartıToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yemekKartıToolStripMenuItem.Text = "Yemek Kartı";
            this.yemekKartıToolStripMenuItem.Click += new System.EventHandler(this.yemekKartıToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cateringFirmaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikçiFirmaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekKartıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geliirleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toplamGelirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cateringGelirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şahsiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikçilerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem araçToolStripMenuItem1;
    }
}