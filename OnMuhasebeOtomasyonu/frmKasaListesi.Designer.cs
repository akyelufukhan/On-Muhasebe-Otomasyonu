namespace OnMuhasebeOtomasyonu
{
    partial class frmKasaListesi
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
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.GridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kasa_kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kasa_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.onMuhasebeDataSet = new OnMuhasebeOtomasyonu.OnMuhasebeDataSet();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUrunTableAdapter = new OnMuhasebeOtomasyonu.OnMuhasebeDataSetTableAdapters.tblUrunTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onMuhasebeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Liste);
            this.panel1.Controls.Add(this.btnVazgec);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 2;
            // 
            // Liste
            // 
            this.Liste.Location = new System.Drawing.Point(3, 3);
            this.Liste.MainView = this.GridControl;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1274, 638);
            this.Liste.TabIndex = 7;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridControl});
            // 
            // GridControl
            // 
            this.GridControl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.kasa_kodu,
            this.kasa_adi,
            this.giris,
            this.cikis,
            this.bakiye});
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
            // kasa_kodu
            // 
            this.kasa_kodu.Caption = "Kasa Kodu";
            this.kasa_kodu.FieldName = "kasa_kodu";
            this.kasa_kodu.Name = "kasa_kodu";
            this.kasa_kodu.OptionsColumn.AllowEdit = false;
            this.kasa_kodu.OptionsColumn.AllowFocus = false;
            this.kasa_kodu.OptionsColumn.FixedWidth = true;
            this.kasa_kodu.Visible = true;
            this.kasa_kodu.VisibleIndex = 0;
            this.kasa_kodu.Width = 35;
            // 
            // kasa_adi
            // 
            this.kasa_adi.Caption = "Kasa Adı";
            this.kasa_adi.FieldName = "kasa_adi";
            this.kasa_adi.Name = "kasa_adi";
            this.kasa_adi.OptionsColumn.AllowEdit = false;
            this.kasa_adi.OptionsColumn.AllowFocus = false;
            this.kasa_adi.OptionsColumn.FixedWidth = true;
            this.kasa_adi.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.kasa_adi.Visible = true;
            this.kasa_adi.VisibleIndex = 1;
            this.kasa_adi.Width = 180;
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
            this.giris.Width = 45;
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
            this.cikis.Width = 45;
            // 
            // bakiye
            // 
            this.bakiye.Caption = "Bakiye";
            this.bakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bakiye.FieldName = "bakiye";
            this.bakiye.Name = "bakiye";
            this.bakiye.OptionsColumn.AllowEdit = false;
            this.bakiye.OptionsColumn.AllowFocus = false;
            this.bakiye.OptionsColumn.FixedWidth = true;
            this.bakiye.Visible = true;
            this.bakiye.VisibleIndex = 4;
            this.bakiye.Width = 55;
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
            // onMuhasebeDataSet
            // 
            this.onMuhasebeDataSet.DataSetName = "OnMuhasebeDataSet";
            this.onMuhasebeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUrunBindingSource
            // 
            this.tblUrunBindingSource.DataMember = "tblUrun";
            this.tblUrunBindingSource.DataSource = this.onMuhasebeDataSet;
            // 
            // tblUrunTableAdapter
            // 
            this.tblUrunTableAdapter.ClearBeforeFill = true;
            // 
            // frmKasaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Listesi";
            this.Load += new System.EventHandler(this.frmKasaListesi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onMuhasebeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView GridControl;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn kasa_kodu;
        private DevExpress.XtraGrid.Columns.GridColumn kasa_adi;
        private DevExpress.XtraGrid.Columns.GridColumn bakiye;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Splitter splitter1;
        private OnMuhasebeDataSet onMuhasebeDataSet;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private OnMuhasebeDataSetTableAdapters.tblUrunTableAdapter tblUrunTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn giris;
        private DevExpress.XtraGrid.Columns.GridColumn cikis;
    }
}