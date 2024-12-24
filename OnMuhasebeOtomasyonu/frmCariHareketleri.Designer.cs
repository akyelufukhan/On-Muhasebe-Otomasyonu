namespace OnMuhasebeOtomasyonu
{
    partial class frmCariHareketleri
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
            this.components = new System.ComponentModel.Container();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tahsilatOdeme = new System.Windows.Forms.ToolStripMenuItem();
            this.devirKartiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.belge_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.evrak_turu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.evrak_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            this.SagTik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnVazgec);
            this.groupControl2.Controls.Add(this.btnTemizle);
            this.groupControl2.Controls.Add(this.btnKaydet);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 368);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(800, 82);
            this.groupControl2.TabIndex = 27;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVazgec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Location = new System.Drawing.Point(476, 28);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(5);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(131, 45);
            this.btnVazgec.TabIndex = 21;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTemizle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(335, 28);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(5);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(131, 45);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(194, 28);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 45);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(79, 25);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKasaKodu.Properties.Appearance.Options.UseFont = true;
            this.txtKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaKodu.Size = new System.Drawing.Size(161, 22);
            this.txtKasaKodu.TabIndex = 16;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtBakiye);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtCikis);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtGiris);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 84);
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(521, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Bakiye :";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(564, 25);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBakiye.Properties.Appearance.Options.UseFont = true;
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(84, 22);
            this.txtBakiye.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(397, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Çıkış :";
            // 
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(431, 25);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCikis.Properties.Appearance.Options.UseFont = true;
            this.txtCikis.Properties.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(84, 22);
            this.txtCikis.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(261, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Giriş :";
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(304, 25);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiris.Properties.Appearance.Options.UseFont = true;
            this.txtGiris.Properties.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(84, 22);
            this.txtGiris.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Kasa Adı :";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(79, 53);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKasaAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKasaAdi.Properties.ReadOnly = true;
            this.txtKasaAdi.Size = new System.Drawing.Size(161, 22);
            this.txtKasaAdi.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Kasa Kodu :";
            // 
            // tahsilatOdeme
            // 
            this.tahsilatOdeme.Enabled = false;
            this.tahsilatOdeme.Name = "tahsilatOdeme";
            this.tahsilatOdeme.Size = new System.Drawing.Size(252, 22);
            this.tahsilatOdeme.Text = "Tahsilat / Ödeme İşlemini Düzenle";
            // 
            // devirKartiDuzenle
            // 
            this.devirKartiDuzenle.Enabled = false;
            this.devirKartiDuzenle.Name = "devirKartiDuzenle";
            this.devirKartiDuzenle.Size = new System.Drawing.Size(252, 22);
            this.devirKartiDuzenle.Text = "Devir İşlemini Düzenle";
            // 
            // SagTik
            // 
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devirKartiDuzenle,
            this.tahsilatOdeme});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(253, 48);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 85);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 282);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.belge_no,
            this.evrak_turu,
            this.evrak_id,
            this.giris,
            this.cikis,
            this.aciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // belge_no
            // 
            this.belge_no.Caption = "Belge No";
            this.belge_no.FieldName = "belge_no";
            this.belge_no.Name = "belge_no";
            this.belge_no.OptionsColumn.AllowEdit = false;
            this.belge_no.OptionsColumn.AllowFocus = false;
            this.belge_no.OptionsColumn.FixedWidth = true;
            this.belge_no.Visible = true;
            this.belge_no.VisibleIndex = 0;
            this.belge_no.Width = 100;
            // 
            // evrak_turu
            // 
            this.evrak_turu.Caption = "Evrak Türü";
            this.evrak_turu.FieldName = "evrak_turu";
            this.evrak_turu.Name = "evrak_turu";
            this.evrak_turu.OptionsColumn.AllowEdit = false;
            this.evrak_turu.OptionsColumn.AllowFocus = false;
            this.evrak_turu.OptionsColumn.FixedWidth = true;
            this.evrak_turu.Visible = true;
            this.evrak_turu.VisibleIndex = 1;
            this.evrak_turu.Width = 100;
            // 
            // evrak_id
            // 
            this.evrak_id.Caption = "Evrak ID";
            this.evrak_id.FieldName = "evrak_id";
            this.evrak_id.Name = "evrak_id";
            // 
            // giris
            // 
            this.giris.Caption = "Giriş";
            this.giris.FieldName = "giris";
            this.giris.Name = "giris";
            this.giris.OptionsColumn.AllowEdit = false;
            this.giris.OptionsColumn.AllowFocus = false;
            this.giris.OptionsColumn.FixedWidth = true;
            this.giris.Visible = true;
            this.giris.VisibleIndex = 2;
            // 
            // cikis
            // 
            this.cikis.Caption = "Çıkış";
            this.cikis.FieldName = "cikis";
            this.cikis.Name = "cikis";
            this.cikis.OptionsColumn.AllowEdit = false;
            this.cikis.OptionsColumn.AllowFocus = false;
            this.cikis.OptionsColumn.FixedWidth = true;
            this.cikis.Visible = true;
            this.cikis.VisibleIndex = 3;
            // 
            // aciklama
            // 
            this.aciklama.Caption = "Açıklama";
            this.aciklama.FieldName = "aciklama";
            this.aciklama.Name = "aciklama";
            this.aciklama.OptionsColumn.AllowEdit = false;
            this.aciklama.OptionsColumn.AllowFocus = false;
            this.aciklama.Visible = true;
            this.aciklama.VisibleIndex = 4;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(800, 450);
            this.groupControl3.TabIndex = 29;
            this.groupControl3.Text = "Hareket Listesi";
            // 
            // frmCariHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hareketleri";
            this.Load += new System.EventHandler(this.frmCariHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            this.SagTik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private DevExpress.XtraEditors.ButtonEdit txtKasaKodu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCikis;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtGiris;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ToolStripMenuItem tahsilatOdeme;
        private System.Windows.Forms.ToolStripMenuItem devirKartiDuzenle;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn belge_no;
        private DevExpress.XtraGrid.Columns.GridColumn evrak_turu;
        private DevExpress.XtraGrid.Columns.GridColumn evrak_id;
        private DevExpress.XtraGrid.Columns.GridColumn giris;
        private DevExpress.XtraGrid.Columns.GridColumn cikis;
        private DevExpress.XtraGrid.Columns.GridColumn aciklama;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}