namespace OnMuhasebeOtomasyonu.Form_Cek
{
    partial class frmCekListesi
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
            this.banka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cek_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tip = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.Liste.Size = new System.Drawing.Size(1274, 714);
            this.Liste.TabIndex = 7;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridControl});
            // 
            // GridControl
            // 
            this.GridControl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.banka,
            this.cek_no,
            this.tip});
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
            // banka
            // 
            this.banka.Caption = "Banka";
            this.banka.FieldName = "banka";
            this.banka.Name = "banka";
            this.banka.OptionsColumn.AllowEdit = false;
            this.banka.OptionsColumn.AllowFocus = false;
            this.banka.OptionsColumn.FixedWidth = true;
            this.banka.Visible = true;
            this.banka.VisibleIndex = 0;
            this.banka.Width = 150;
            // 
            // cek_no
            // 
            this.cek_no.Caption = "Çek Numarası";
            this.cek_no.FieldName = "cek_no";
            this.cek_no.Name = "cek_no";
            this.cek_no.OptionsColumn.AllowEdit = false;
            this.cek_no.OptionsColumn.AllowFocus = false;
            this.cek_no.OptionsColumn.FixedWidth = true;
            this.cek_no.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.cek_no.Visible = true;
            this.cek_no.VisibleIndex = 1;
            this.cek_no.Width = 100;
            // 
            // tip
            // 
            this.tip.Caption = "Çek Türü";
            this.tip.FieldName = "tip";
            this.tip.Name = "tip";
            this.tip.OptionsColumn.AllowEdit = false;
            this.tip.OptionsColumn.AllowFocus = false;
            this.tip.OptionsColumn.FixedWidth = true;
            this.tip.Visible = true;
            this.tip.VisibleIndex = 2;
            this.tip.Width = 100;
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
            // frmCekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCekListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCekListesi";
            this.Load += new System.EventHandler(this.frmCekListesi_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn banka;
        private DevExpress.XtraGrid.Columns.GridColumn cek_no;
        private DevExpress.XtraGrid.Columns.GridColumn tip;
        private System.Windows.Forms.Splitter splitter1;
        private OnMuhasebeDataSet onMuhasebeDataSet;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private OnMuhasebeDataSetTableAdapters.tblUrunTableAdapter tblUrunTableAdapter;
    }
}