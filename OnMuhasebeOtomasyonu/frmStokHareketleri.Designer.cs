namespace OnMuhasebeOtomasyonu
{
    partial class frmStokHareketleri
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
            this.evrak_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.evrak_turu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.belge_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // evrak_id
            // 
            this.evrak_id.Caption = "Fatura No";
            this.evrak_id.FieldName = "FATURANO";
            this.evrak_id.Name = "evrak_id";
            this.evrak_id.Visible = true;
            this.evrak_id.VisibleIndex = 3;
            // 
            // tarih
            // 
            this.tarih.Caption = "Miktar";
            this.tarih.FieldName = "MIKTAR";
            this.tarih.Name = "tarih";
            this.tarih.OptionsColumn.AllowEdit = false;
            this.tarih.OptionsColumn.AllowFocus = false;
            this.tarih.OptionsColumn.FixedWidth = true;
            this.tarih.Visible = true;
            this.tarih.VisibleIndex = 2;
            this.tarih.Width = 90;
            // 
            // evrak_turu
            // 
            this.evrak_turu.Caption = "Stok Adı";
            this.evrak_turu.FieldName = "urun_adi";
            this.evrak_turu.Name = "evrak_turu";
            this.evrak_turu.OptionsColumn.AllowEdit = false;
            this.evrak_turu.OptionsColumn.AllowFocus = false;
            this.evrak_turu.OptionsColumn.FixedWidth = true;
            this.evrak_turu.Visible = true;
            this.evrak_turu.VisibleIndex = 1;
            this.evrak_turu.Width = 100;
            // 
            // belge_no
            // 
            this.belge_no.Caption = "Stok Kodu";
            this.belge_no.FieldName = "STOKKODU";
            this.belge_no.Name = "belge_no";
            this.belge_no.OptionsColumn.AllowEdit = false;
            this.belge_no.OptionsColumn.AllowFocus = false;
            this.belge_no.OptionsColumn.FixedWidth = true;
            this.belge_no.Visible = true;
            this.belge_no.VisibleIndex = 0;
            this.belge_no.Width = 100;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.belge_no,
            this.evrak_turu,
            this.tarih,
            this.evrak_id});
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(796, 425);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(800, 450);
            this.groupControl3.TabIndex = 25;
            this.groupControl3.Text = "Hareket Listesi";
            // 
            // frmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupControl3);
            this.Name = "frmStokHareketleri";
            this.Text = "Stok Hareketleri";
            this.Load += new System.EventHandler(this.frmStokHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn evrak_id;
        private DevExpress.XtraGrid.Columns.GridColumn tarih;
        private DevExpress.XtraGrid.Columns.GridColumn evrak_turu;
        private DevExpress.XtraGrid.Columns.GridColumn belge_no;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}