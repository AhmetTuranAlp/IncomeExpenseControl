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
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cateringToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirlerToolStripMenuItem,
            this.cateringToolStripMenuItem,
            this.raporlarToolStripMenuItem});
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
            this.gelirlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.gelirlerToolStripMenuItem.Text = "Gelirler";
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
            this.yemekGönderimiToolStripMenuItem});
            this.cateringToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cateringToolStripMenuItem.Name = "cateringToolStripMenuItem";
            this.cateringToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cateringToolStripMenuItem.Text = "Catering";
            // 
            // firmaEkleToolStripMenuItem
            // 
            this.firmaEkleToolStripMenuItem.Name = "firmaEkleToolStripMenuItem";
            this.firmaEkleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.firmaEkleToolStripMenuItem.Text = "Firma İşlemleri";
            this.firmaEkleToolStripMenuItem.Click += new System.EventHandler(this.FirmaEkleToolStripMenuItem_Click);
            // 
            // yemekGönderimiToolStripMenuItem
            // 
            this.yemekGönderimiToolStripMenuItem.Name = "yemekGönderimiToolStripMenuItem";
            this.yemekGönderimiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.yemekGönderimiToolStripMenuItem.Text = "Yemek Servis";
            this.yemekGönderimiToolStripMenuItem.Click += new System.EventHandler(this.YemekGönderimiToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cateringToolStripMenuItem2});
            this.raporlarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // cateringToolStripMenuItem2
            // 
            this.cateringToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aylıkRaporToolStripMenuItem,
            this.günlükRaporToolStripMenuItem,
            this.hizmetRaporuToolStripMenuItem});
            this.cateringToolStripMenuItem2.Name = "cateringToolStripMenuItem2";
            this.cateringToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cateringToolStripMenuItem2.Text = "Catering";
            // 
            // aylıkRaporToolStripMenuItem
            // 
            this.aylıkRaporToolStripMenuItem.Name = "aylıkRaporToolStripMenuItem";
            this.aylıkRaporToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aylıkRaporToolStripMenuItem.Text = "Aylık Ciro";
            this.aylıkRaporToolStripMenuItem.Click += new System.EventHandler(this.AylıkRaporToolStripMenuItem_Click);
            // 
            // günlükRaporToolStripMenuItem
            // 
            this.günlükRaporToolStripMenuItem.Name = "günlükRaporToolStripMenuItem";
            this.günlükRaporToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.günlükRaporToolStripMenuItem.Text = "Günlük Ciro";
            this.günlükRaporToolStripMenuItem.Click += new System.EventHandler(this.GünlükRaporToolStripMenuItem_Click);
            // 
            // hizmetRaporuToolStripMenuItem
            // 
            this.hizmetRaporuToolStripMenuItem.Name = "hizmetRaporuToolStripMenuItem";
            this.hizmetRaporuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hizmetRaporuToolStripMenuItem.Text = "Hizmet Raporu";
            this.hizmetRaporuToolStripMenuItem.Click += new System.EventHandler(this.HizmetRaporuToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cateringToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aylıkRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizmetRaporuToolStripMenuItem;
    }
}