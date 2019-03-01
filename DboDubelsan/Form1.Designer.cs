namespace DboDubelsan
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.buttonMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.buttonGruplar = new DevExpress.XtraBars.BarButtonItem();
            this.buttonMail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.buttonMusteriler,
            this.buttonGruplar,
            this.buttonMail});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 300;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(984, 141);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // buttonMusteriler
            // 
            this.buttonMusteriler.Caption = "MÜŞTERİLER";
            this.buttonMusteriler.Id = 1;
            this.buttonMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonMusteriler.ImageOptions.Image")));
            this.buttonMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonMusteriler.ImageOptions.LargeImage")));
            this.buttonMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.buttonMusteriler.Name = "buttonMusteriler";
            this.buttonMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMusteriler_ItemClick);
            // 
            // buttonGruplar
            // 
            this.buttonGruplar.Caption = "GRUPLAR";
            this.buttonGruplar.Id = 2;
            this.buttonGruplar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonGruplar.ImageOptions.Image")));
            this.buttonGruplar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonGruplar.ImageOptions.LargeImage")));
            this.buttonGruplar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGruplar.ItemAppearance.Normal.Options.UseFont = true;
            this.buttonGruplar.Name = "buttonGruplar";
            this.buttonGruplar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonGruplar_ItemClick);
            // 
            // buttonMail
            // 
            this.buttonMail.Caption = "E-POSTA";
            this.buttonMail.Id = 3;
            this.buttonMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonMail.ImageOptions.Image")));
            this.buttonMail.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonMail.ImageOptions.LargeImage")));
            this.buttonMail.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMail.ItemAppearance.Normal.Options.UseFont = true;
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Dübelsan";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonGruplar);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonMail);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem buttonMusteriler;
        private DevExpress.XtraBars.BarButtonItem buttonGruplar;
        private DevExpress.XtraBars.BarButtonItem buttonMail;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

