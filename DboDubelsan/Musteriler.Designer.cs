namespace DboDubelsan
{
    partial class Musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            this.veriTablosu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grupEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ilceEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ilEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.silButton = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleButton = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetButton = new DevExpress.XtraEditors.SimpleButton();
            this.notlarText = new System.Windows.Forms.RichTextBox();
            this.notLabel = new System.Windows.Forms.Label();
            this.grupLabel = new System.Windows.Forms.Label();
            this.adresEditText = new System.Windows.Forms.RichTextBox();
            this.mailText = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.telEdit2 = new System.Windows.Forms.MaskedTextBox();
            this.telEdit = new System.Windows.Forms.MaskedTextBox();
            this.Tellabel2 = new System.Windows.Forms.Label();
            this.telLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ilceLabel = new System.Windows.Forms.Label();
            this.ilLabel = new System.Windows.Forms.Label();
            this.YetkiliTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.YetkiliLabel = new System.Windows.Forms.Label();
            this.FirmaEditText = new DevExpress.XtraEditors.TextEdit();
            this.FirmaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.veriTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilceEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YetkiliTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmaEditText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // veriTablosu
            // 
            this.veriTablosu.Location = new System.Drawing.Point(0, 0);
            this.veriTablosu.MainView = this.gridView1;
            this.veriTablosu.Name = "veriTablosu";
            this.veriTablosu.Size = new System.Drawing.Size(704, 525);
            this.veriTablosu.TabIndex = 0;
            this.veriTablosu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.veriTablosu.Click += new System.EventHandler(this.veriTablosu_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.veriTablosu;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grupEdit);
            this.groupControl1.Controls.Add(this.ilceEdit);
            this.groupControl1.Controls.Add(this.ilEdit);
            this.groupControl1.Controls.Add(this.silButton);
            this.groupControl1.Controls.Add(this.guncelleButton);
            this.groupControl1.Controls.Add(this.kaydetButton);
            this.groupControl1.Controls.Add(this.notlarText);
            this.groupControl1.Controls.Add(this.notLabel);
            this.groupControl1.Controls.Add(this.grupLabel);
            this.groupControl1.Controls.Add(this.adresEditText);
            this.groupControl1.Controls.Add(this.mailText);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.telEdit2);
            this.groupControl1.Controls.Add(this.telEdit);
            this.groupControl1.Controls.Add(this.Tellabel2);
            this.groupControl1.Controls.Add(this.telLabel);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ilceLabel);
            this.groupControl1.Controls.Add(this.ilLabel);
            this.groupControl1.Controls.Add(this.YetkiliTextEdit);
            this.groupControl1.Controls.Add(this.YetkiliLabel);
            this.groupControl1.Controls.Add(this.FirmaEditText);
            this.groupControl1.Controls.Add(this.FirmaLabel);
            this.groupControl1.Location = new System.Drawing.Point(705, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(278, 525);
            this.groupControl1.TabIndex = 1;
            // 
            // grupEdit
            // 
            this.grupEdit.Location = new System.Drawing.Point(98, 303);
            this.grupEdit.Name = "grupEdit";
            this.grupEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupEdit.Properties.Appearance.Options.UseFont = true;
            this.grupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grupEdit.Size = new System.Drawing.Size(159, 24);
            this.grupEdit.TabIndex = 24;
            this.grupEdit.SelectedIndexChanged += new System.EventHandler(this.grupEdit_SelectedIndexChanged);
            // 
            // ilceEdit
            // 
            this.ilceEdit.Location = new System.Drawing.Point(98, 103);
            this.ilceEdit.Name = "ilceEdit";
            this.ilceEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilceEdit.Properties.Appearance.Options.UseFont = true;
            this.ilceEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ilceEdit.Size = new System.Drawing.Size(159, 24);
            this.ilceEdit.TabIndex = 23;
            // 
            // ilEdit
            // 
            this.ilEdit.Location = new System.Drawing.Point(98, 73);
            this.ilEdit.Name = "ilEdit";
            this.ilEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilEdit.Properties.Appearance.Options.UseFont = true;
            this.ilEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ilEdit.Size = new System.Drawing.Size(159, 24);
            this.ilEdit.TabIndex = 22;
            this.ilEdit.SelectedIndexChanged += new System.EventHandler(this.ilEdit_SelectedIndexChanged);
            // 
            // silButton
            // 
            this.silButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Appearance.Options.UseFont = true;
            this.silButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.silButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silButton.ImageOptions.Image")));
            this.silButton.Location = new System.Drawing.Point(90, 453);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(160, 30);
            this.silButton.TabIndex = 21;
            this.silButton.Text = "Sil";
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleButton.Appearance.Options.UseFont = true;
            this.guncelleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.guncelleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleButton.ImageOptions.Image")));
            this.guncelleButton.Location = new System.Drawing.Point(90, 487);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(160, 30);
            this.guncelleButton.TabIndex = 20;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // kaydetButton
            // 
            this.kaydetButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButton.Appearance.Options.UseFont = true;
            this.kaydetButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.kaydetButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetButton.ImageOptions.Image")));
            this.kaydetButton.Location = new System.Drawing.Point(90, 419);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(160, 30);
            this.kaydetButton.TabIndex = 19;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // notlarText
            // 
            this.notlarText.Location = new System.Drawing.Point(98, 331);
            this.notlarText.Name = "notlarText";
            this.notlarText.Size = new System.Drawing.Size(159, 82);
            this.notlarText.TabIndex = 18;
            this.notlarText.Text = "";
            // 
            // notLabel
            // 
            this.notLabel.AutoSize = true;
            this.notLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notLabel.Location = new System.Drawing.Point(38, 330);
            this.notLabel.Name = "notLabel";
            this.notLabel.Size = new System.Drawing.Size(61, 18);
            this.notLabel.TabIndex = 17;
            this.notLabel.Text = "Notlar:";
            this.notLabel.Click += new System.EventHandler(this.notLabel_Click);
            // 
            // grupLabel
            // 
            this.grupLabel.AutoSize = true;
            this.grupLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupLabel.Location = new System.Drawing.Point(50, 304);
            this.grupLabel.Name = "grupLabel";
            this.grupLabel.Size = new System.Drawing.Size(49, 18);
            this.grupLabel.TabIndex = 16;
            this.grupLabel.Text = "Grup:";
            // 
            // adresEditText
            // 
            this.adresEditText.Location = new System.Drawing.Point(98, 131);
            this.adresEditText.Name = "adresEditText";
            this.adresEditText.Size = new System.Drawing.Size(159, 81);
            this.adresEditText.TabIndex = 15;
            this.adresEditText.Text = "";
            // 
            // mailText
            // 
            this.mailText.Location = new System.Drawing.Point(98, 273);
            this.mailText.Name = "mailText";
            this.mailText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailText.Properties.Appearance.Options.UseFont = true;
            this.mailText.Size = new System.Drawing.Size(159, 24);
            this.mailText.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // telEdit2
            // 
            this.telEdit2.Location = new System.Drawing.Point(98, 246);
            this.telEdit2.Mask = "(999) 000-0000";
            this.telEdit2.Name = "telEdit2";
            this.telEdit2.Size = new System.Drawing.Size(159, 21);
            this.telEdit2.TabIndex = 12;
            // 
            // telEdit
            // 
            this.telEdit.Location = new System.Drawing.Point(98, 219);
            this.telEdit.Mask = "(999) 000-0000";
            this.telEdit.Name = "telEdit";
            this.telEdit.Size = new System.Drawing.Size(159, 21);
            this.telEdit.TabIndex = 11;
            // 
            // Tellabel2
            // 
            this.Tellabel2.AutoSize = true;
            this.Tellabel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tellabel2.Location = new System.Drawing.Point(16, 245);
            this.Tellabel2.Name = "Tellabel2";
            this.Tellabel2.Size = new System.Drawing.Size(83, 18);
            this.Tellabel2.TabIndex = 10;
            this.Tellabel2.Text = "Telefon 2:";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telLabel.Location = new System.Drawing.Point(30, 218);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(69, 18);
            this.telLabel.TabIndex = 9;
            this.telLabel.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adres:";
            // 
            // ilceLabel
            // 
            this.ilceLabel.AutoSize = true;
            this.ilceLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilceLabel.Location = new System.Drawing.Point(57, 103);
            this.ilceLabel.Name = "ilceLabel";
            this.ilceLabel.Size = new System.Drawing.Size(42, 18);
            this.ilceLabel.TabIndex = 5;
            this.ilceLabel.Text = "İlçe:";
            // 
            // ilLabel
            // 
            this.ilLabel.AutoSize = true;
            this.ilLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilLabel.Location = new System.Drawing.Point(74, 75);
            this.ilLabel.Name = "ilLabel";
            this.ilLabel.Size = new System.Drawing.Size(25, 18);
            this.ilLabel.TabIndex = 4;
            this.ilLabel.Text = "İl:";
            // 
            // YetkiliTextEdit
            // 
            this.YetkiliTextEdit.Location = new System.Drawing.Point(98, 42);
            this.YetkiliTextEdit.Name = "YetkiliTextEdit";
            this.YetkiliTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YetkiliTextEdit.Properties.Appearance.Options.UseFont = true;
            this.YetkiliTextEdit.Size = new System.Drawing.Size(159, 24);
            this.YetkiliTextEdit.TabIndex = 3;
            // 
            // YetkiliLabel
            // 
            this.YetkiliLabel.AutoSize = true;
            this.YetkiliLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YetkiliLabel.Location = new System.Drawing.Point(8, 45);
            this.YetkiliLabel.Name = "YetkiliLabel";
            this.YetkiliLabel.Size = new System.Drawing.Size(91, 18);
            this.YetkiliLabel.TabIndex = 2;
            this.YetkiliLabel.Text = "Yetkili Adı:";
            // 
            // FirmaEditText
            // 
            this.FirmaEditText.Location = new System.Drawing.Point(98, 12);
            this.FirmaEditText.Name = "FirmaEditText";
            this.FirmaEditText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirmaEditText.Properties.Appearance.Options.UseFont = true;
            this.FirmaEditText.Size = new System.Drawing.Size(159, 24);
            this.FirmaEditText.TabIndex = 1;
            // 
            // FirmaLabel
            // 
            this.FirmaLabel.AutoSize = true;
            this.FirmaLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirmaLabel.Location = new System.Drawing.Point(15, 15);
            this.FirmaLabel.Name = "FirmaLabel";
            this.FirmaLabel.Size = new System.Drawing.Size(84, 18);
            this.FirmaLabel.TabIndex = 0;
            this.FirmaLabel.Text = "Firma Adı:";
            this.FirmaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.veriTablosu);
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veriTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilceEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YetkiliTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmaEditText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl veriTablosu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label FirmaLabel;
        private DevExpress.XtraEditors.TextEdit FirmaEditText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox telEdit2;
        private System.Windows.Forms.MaskedTextBox telEdit;
        private System.Windows.Forms.Label Tellabel2;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ilceLabel;
        private System.Windows.Forms.Label ilLabel;
        private DevExpress.XtraEditors.TextEdit YetkiliTextEdit;
        private System.Windows.Forms.Label YetkiliLabel;
        private DevExpress.XtraEditors.TextEdit mailText;
        private System.Windows.Forms.RichTextBox notlarText;
        private System.Windows.Forms.Label notLabel;
        private System.Windows.Forms.Label grupLabel;
        private System.Windows.Forms.RichTextBox adresEditText;
        private DevExpress.XtraEditors.SimpleButton kaydetButton;
        private DevExpress.XtraEditors.SimpleButton silButton;
        private DevExpress.XtraEditors.SimpleButton guncelleButton;
        private DevExpress.XtraEditors.ComboBoxEdit grupEdit;
        private DevExpress.XtraEditors.ComboBoxEdit ilceEdit;
        private DevExpress.XtraEditors.ComboBoxEdit ilEdit;
    }
}