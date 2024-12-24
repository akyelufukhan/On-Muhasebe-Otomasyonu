namespace OnMuhasebeOtomasyonu
{
    partial class frmBankaListesi
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
            this.tblUrunTableAdapter = new OnMuhasebeOtomasyonu.OnMuhasebeDataSetTableAdapters.tblUrunTableAdapter();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onMuhasebeDataSet = new OnMuhasebeOtomasyonu.OnMuhasebeDataSet();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.hesap_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hesap_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.banka_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onMuhasebeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblUrunTableAdapter
            // 
            this.tblUrunTableAdapter.ClearBeforeFill = true;
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
            // hesap_no
            // 
            this.hesap_no.Caption = "Hesap No";
            this.hesap_no.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.hesap_no.FieldName = "hesap_no";
            this.hesap_no.Name = "hesap_no";
            this.hesap_no.OptionsColumn.AllowEdit = false;
            this.hesap_no.OptionsColumn.AllowFocus = false;
            this.hesap_no.OptionsColumn.FixedWidth = true;
            this.hesap_no.Visible = true;
            this.hesap_no.VisibleIndex = 2;
            this.hesap_no.Width = 100;
            // 
            // hesap_adi
            // 
            this.hesap_adi.Caption = "Hesap Adı";
            this.hesap_adi.FieldName = "hesap_adi";
            this.hesap_adi.Name = "hesap_adi";
            this.hesap_adi.OptionsColumn.AllowEdit = false;
            this.hesap_adi.OptionsColumn.AllowFocus = false;
            this.hesap_adi.OptionsColumn.FixedWidth = true;
            this.hesap_adi.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.hesap_adi.Visible = true;
            this.hesap_adi.VisibleIndex = 1;
            this.hesap_adi.Width = 100;
            // 
            // banka_adi
            // 
            this.banka_adi.Caption = "Banka Adı";
            this.banka_adi.FieldName = "banka_adi";
            this.banka_adi.Name = "banka_adi";
            this.banka_adi.OptionsColumn.AllowEdit = false;
            this.banka_adi.OptionsColumn.AllowFocus = false;
            this.banka_adi.OptionsColumn.FixedWidth = true;
            this.banka_adi.Visible = true;
            this.banka_adi.VisibleIndex = 0;
            this.banka_adi.Width = 150;
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
            // GridControl
            // 
            this.GridControl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.banka_adi,
            this.hesap_adi,
            this.hesap_no});
            this.GridControl.GridControl = this.Liste;
            this.GridControl.Name = "GridControl";
            this.GridControl.OptionsFilter.InHeaderSearchMode = DevExpress.XtraGrid.Views.Grid.GridInHeaderSearchMode.TextSearch;
            this.GridControl.OptionsView.ShowGroupPanel = false;
            this.GridControl.DoubleClick += new System.EventHandler(this.GridControl_DoubleClick);
            // 
            // Liste
            // 
            this.Liste.Location = new System.Drawing.Point(3, 3);
            this.Liste.MainView = this.GridControl;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1274, 641);
            this.Liste.TabIndex = 7;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridControl});
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
            this.panel1.TabIndex = 1;
            // 
            // frmBankaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Listesi";
            this.Load += new System.EventHandler(this.frmBankaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onMuhasebeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OnMuhasebeDataSetTableAdapters.tblUrunTableAdapter tblUrunTableAdapter;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private OnMuhasebeDataSet onMuhasebeDataSet;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraGrid.Columns.GridColumn hesap_no;
        private DevExpress.XtraGrid.Columns.GridColumn hesap_adi;
        private DevExpress.XtraGrid.Columns.GridColumn banka_adi;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView GridControl;
        private DevExpress.XtraGrid.GridControl Liste;
        private System.Windows.Forms.Panel panel1;
    }
}