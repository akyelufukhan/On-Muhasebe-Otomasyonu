namespace OnMuhasebeOtomasyonu
{
    partial class frmStokListesi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.GridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urun_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urun_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urun_turu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urun_birim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onMuhasebeDataSet = new OnMuhasebeOtomasyonu.OnMuhasebeDataSet();
            this.tblUrunTableAdapter = new OnMuhasebeOtomasyonu.OnMuhasebeDataSetTableAdapters.tblUrunTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onMuhasebeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerControl1);
            this.panel1.Controls.Add(this.btnVazgec);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1274, 646);
            this.splitContainerControl1.SplitterPosition = 174;
            this.splitContainerControl1.TabIndex = 16;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(174, 646);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtStokAd);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtStokKodu);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(172, 621);
            this.xtraTabPage1.Text = "Arama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(6, 248);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(161, 37);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(6, 205);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(161, 37);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Stok Adı";
            // 
            // txtStokAd
            // 
            this.txtStokAd.Location = new System.Drawing.Point(6, 166);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokAd.Properties.Appearance.Options.UseFont = true;
            this.txtStokAd.Size = new System.Drawing.Size(161, 22);
            this.txtStokAd.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(6, 105);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokKodu.Properties.Appearance.Options.UseFont = true;
            this.txtStokKodu.Size = new System.Drawing.Size(161, 22);
            this.txtStokKodu.TabIndex = 4;
            // 
            // Liste
            // 
            this.Liste.Location = new System.Drawing.Point(3, 3);
            this.Liste.MainView = this.GridControl;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1084, 641);
            this.Liste.TabIndex = 7;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridControl});
            // 
            // GridControl
            // 
            this.GridControl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.urun_id,
            this.urun_adi,
            this.urun_turu,
            this.urun_birim});
            this.GridControl.GridControl = this.Liste;
            this.GridControl.Name = "GridControl";
            this.GridControl.OptionsFilter.InHeaderSearchMode = DevExpress.XtraGrid.Views.Grid.GridInHeaderSearchMode.TextSearch;
            this.GridControl.OptionsView.ShowGroupPanel = false;
            this.GridControl.DoubleClick += new System.EventHandler(this.GridControl_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.Width = 20;
            // 
            // urun_id
            // 
            this.urun_id.Caption = "Stok Kodu";
            this.urun_id.FieldName = "urun_kodu";
            this.urun_id.Name = "urun_id";
            this.urun_id.OptionsColumn.AllowEdit = false;
            this.urun_id.OptionsColumn.AllowFocus = false;
            this.urun_id.OptionsColumn.FixedWidth = true;
            this.urun_id.Visible = true;
            this.urun_id.VisibleIndex = 0;
            this.urun_id.Width = 35;
            // 
            // urun_adi
            // 
            this.urun_adi.Caption = "Stok Adı";
            this.urun_adi.FieldName = "urun_adi";
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.OptionsColumn.AllowEdit = false;
            this.urun_adi.OptionsColumn.AllowFocus = false;
            this.urun_adi.OptionsColumn.FixedWidth = true;
            this.urun_adi.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.urun_adi.Visible = true;
            this.urun_adi.VisibleIndex = 1;
            this.urun_adi.Width = 180;
            // 
            // urun_turu
            // 
            this.urun_turu.Caption = "Ürün Türü";
            this.urun_turu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.urun_turu.FieldName = "urun_turu";
            this.urun_turu.Name = "urun_turu";
            this.urun_turu.OptionsColumn.AllowEdit = false;
            this.urun_turu.OptionsColumn.AllowFocus = false;
            this.urun_turu.OptionsColumn.FixedWidth = true;
            this.urun_turu.Visible = true;
            this.urun_turu.VisibleIndex = 2;
            this.urun_turu.Width = 50;
            // 
            // urun_birim
            // 
            this.urun_birim.Caption = "Birim";
            this.urun_birim.FieldName = "urun_birim";
            this.urun_birim.Name = "urun_birim";
            this.urun_birim.OptionsColumn.AllowEdit = false;
            this.urun_birim.OptionsColumn.AllowFocus = false;
            this.urun_birim.OptionsColumn.FixedWidth = true;
            this.urun_birim.Visible = true;
            this.urun_birim.VisibleIndex = 3;
            this.urun_birim.Width = 50;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Location = new System.Drawing.Point(757, 655);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(224, 51);
            this.btnVazgec.TabIndex = 14;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(528, 655);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(224, 51);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(299, 655);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(224, 51);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 720);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // tblUrunBindingSource
            // 
            this.tblUrunBindingSource.DataMember = "tblUrun";
            this.tblUrunBindingSource.DataSource = this.onMuhasebeDataSet;
            // 
            // onMuhasebeDataSet
            // 
            this.onMuhasebeDataSet.DataSetName = "OnMuhasebeDataSet";
            this.onMuhasebeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUrunTableAdapter
            // 
            this.tblUrunTableAdapter.ClearBeforeFill = true;
            // 
            // frmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmStokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStokListesi_FormClosed);
            this.Load += new System.EventHandler(this.frmStokListesi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onMuhasebeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private OnMuhasebeDataSet onMuhasebeDataSet;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private OnMuhasebeDataSetTableAdapters.tblUrunTableAdapter tblUrunTableAdapter;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView GridControl;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn urun_id;
        private DevExpress.XtraGrid.Columns.GridColumn urun_adi;
        private DevExpress.XtraGrid.Columns.GridColumn urun_turu;
        private DevExpress.XtraGrid.Columns.GridColumn urun_birim;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStokAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
    }
}