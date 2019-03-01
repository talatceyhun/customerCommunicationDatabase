namespace DboDubelsan
{
    partial class Gruplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gruplar));
            this.grupControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grupUyeleriControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.guncelleButton = new DevExpress.XtraEditors.SimpleButton();
            this.silButton = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetButton = new DevExpress.XtraEditors.SimpleButton();
            this.grupAciklamaText = new System.Windows.Forms.RichTextBox();
            this.grupAdıText = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupUyeleriControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupAdıText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grupControl
            // 
            this.grupControl.Location = new System.Drawing.Point(0, 0);
            this.grupControl.MainView = this.gridView1;
            this.grupControl.Name = "grupControl";
            this.grupControl.Size = new System.Drawing.Size(642, 293);
            this.grupControl.TabIndex = 0;
            this.grupControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grupControl.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grupControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grupUyeleriControl
            // 
            this.grupUyeleriControl.Location = new System.Drawing.Point(0, 299);
            this.grupUyeleriControl.MainView = this.gridView2;
            this.grupUyeleriControl.Name = "grupUyeleriControl";
            this.grupUyeleriControl.Size = new System.Drawing.Size(983, 220);
            this.grupUyeleriControl.TabIndex = 1;
            this.grupUyeleriControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grupUyeleriControl.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grupUyeleriControl;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.guncelleButton);
            this.groupControl1.Controls.Add(this.silButton);
            this.groupControl1.Controls.Add(this.kaydetButton);
            this.groupControl1.Controls.Add(this.grupAciklamaText);
            this.groupControl1.Controls.Add(this.grupAdıText);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(648, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(335, 293);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Yeni Grup Ekleme";
            // 
            // guncelleButton
            // 
            this.guncelleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleButton.Appearance.Options.UseFont = true;
            this.guncelleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.guncelleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleButton.ImageOptions.Image")));
            this.guncelleButton.Location = new System.Drawing.Point(114, 253);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(160, 30);
            this.guncelleButton.TabIndex = 6;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Appearance.Options.UseFont = true;
            this.silButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.silButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silButton.ImageOptions.Image")));
            this.silButton.Location = new System.Drawing.Point(114, 217);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(160, 30);
            this.silButton.TabIndex = 5;
            this.silButton.Text = "Sil";
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // kaydetButton
            // 
            this.kaydetButton.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButton.Appearance.Options.UseFont = true;
            this.kaydetButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.kaydetButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetButton.ImageOptions.Image")));
            this.kaydetButton.Location = new System.Drawing.Point(114, 181);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(160, 30);
            this.kaydetButton.TabIndex = 4;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // grupAciklamaText
            // 
            this.grupAciklamaText.Location = new System.Drawing.Point(114, 66);
            this.grupAciklamaText.Name = "grupAciklamaText";
            this.grupAciklamaText.Size = new System.Drawing.Size(203, 109);
            this.grupAciklamaText.TabIndex = 3;
            this.grupAciklamaText.Text = "";
            // 
            // grupAdıText
            // 
            this.grupAdıText.Location = new System.Drawing.Point(114, 34);
            this.grupAdıText.Name = "grupAdıText";
            this.grupAdıText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupAdıText.Properties.Appearance.Options.UseFont = true;
            this.grupAdıText.Size = new System.Drawing.Size(203, 24);
            this.grupAdıText.TabIndex = 2;
            this.grupAdıText.EditValueChanged += new System.EventHandler(this.grupAdıText_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grup Tanımı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grup Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gruplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grupUyeleriControl);
            this.Controls.Add(this.grupControl);
            this.Name = "Gruplar";
            this.Text = "Gruplar";
            this.Load += new System.EventHandler(this.Gruplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupUyeleriControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupAdıText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grupControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grupUyeleriControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit grupAdıText;
        private System.Windows.Forms.RichTextBox grupAciklamaText;
        private DevExpress.XtraEditors.SimpleButton kaydetButton;
        private DevExpress.XtraEditors.SimpleButton guncelleButton;
        private DevExpress.XtraEditors.SimpleButton silButton;
    }
}