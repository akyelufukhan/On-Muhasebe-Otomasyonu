using DevExpress.Utils.IoC;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnMuhasebeOtomasyonu
{
    public partial class frmFaturaSatis : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();

        int CariID = -1;
        int OdemeID = -1;
        int FaturaID = -1;  
        int IrsaliyeID = -1;
        bool Edit = false;
        bool IrsaliyeAc = false;

        void Temizle()
        {
            CariID = -1;
            OdemeID = -1;
            FaturaID = -1;
            IrsaliyeID = -1;
            Edit = false;
            IrsaliyeAc = false;
            txtAciklama.Text = "";
            txtAratoplam.Text = "0.00";
            txtCariAdi.Text = "";
            txtCariKod.Text = "";
            txtFaturaNo.Text = Numara.FaturaNumarasi();
            txtFaturaTarihi.Text = DateTime.Now.ToShortDateString();
            txtFaturaTur.SelectedIndex = 0;
            txtGenelToplam.Text = "0.00";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtIrsaliyeNo.Text = Numara.IrsaliyeNumarasi(); 
            txtIrsaliyeTarih.Text = DateTime.Now.ToShortDateString();
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtKdv.Text = "0.00";
            txtOdemeYeri.SelectedIndex = 0;
            frmMain.Aktarma = -1;
            for (int i = gridView1.RowCount; i > -1; i--)
            {
                gridView1.DeleteRow(i);
            }
        }

        public frmFaturaSatis(bool Ac, int ID, bool Irsaliye)
        {
            InitializeComponent();
            Edit = Ac;
            if(Irsaliye) IrsaliyeID = ID;
            else FaturaID = ID;
            IrsaliyeAc = Irsaliye;
            this.Shown += FrmFaturaSatis_Shown;
        }

        private void FrmFaturaSatis_Shown(object sender, EventArgs e)
        {
            if (Edit) FaturaGetir();
        }

        void FaturaGetir()
        {
            try
            {
                Fonksiyonlar.TBL_FATURALAR Fatura = DB.TBL_FATURALAR.First(s => s.ID == FaturaID);
                IrsaliyeID = Fatura.IRSALIYEID.Value;
                txtAciklama.Text = Fatura.ACIKLAMA;
                txtFaturaNo.Text = Fatura.FATURANO;
                if(Fatura.ODEMEYERIID > 0)
                {
                    txtFaturaTur.SelectedIndex = 1;
                    OdemeID = Fatura.ODEMEYERIID.Value;
                }
                else if(Fatura.ODEMEYERIID < 1)
                {
                    txtFaturaTur.SelectedIndex = 0;
                }
                txtIrsaliyeNo.Text = DB.TBL_IRSALIYELER.First(s => s.ID == Fatura.IRSALIYEID).IRSALIYENO;
                txtIrsaliyeTarih.EditValue = DB.TBL_IRSALIYELER.First(s => s.ID == Fatura.IRSALIYEID).TARIHI.Value.ToShortDateString();
                txtCariAdi.Text = DB.TBL_CARILER.First(s => s.cari_kod == Fatura.CARIKODU).cari_adi;
                txtCariKod.Text = Fatura.CARIKODU;
                txtFaturaTarihi.EditValue = Fatura.TARIHI.Value.ToShortDateString();
                var srg = from s in DB.VW_KALEMLER
                          where s.FATURAID == FaturaID
                          select s;
                foreach(Fonksiyonlar.VW_KALEMLER k in srg)
                {
                    gridView1.AddNewRow();
                    gridView1.SetFocusedRowCellValue("miktar", k.MIKTAR);
                    gridView1.SetFocusedRowCellValue("urun_satisf", k.BIRIMFIYAT);
                    gridView1.SetFocusedRowCellValue("urun_satisv", k.KDV);
                    gridView1.SetFocusedRowCellValue("urun_kodu", k.urun_kodu);
                    gridView1.SetFocusedRowCellValue("urun_adi", k.urun_adi);
                    gridView1.SetFocusedRowCellValue("birim", k.urun_birim);
                    gridView1.UpdateCurrentRow();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        void StokGetir(int StokID)
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue("miktar", "0");
                gridView1.SetFocusedRowCellValue("urun_kodu", Stok.urun_kodu);
                gridView1.SetFocusedRowCellValue("urun_adi", Stok.urun_adi);
                gridView1.SetFocusedRowCellValue("urun_birim", Stok.urun_birim);
                gridView1.SetFocusedRowCellValue("urun_satisf", Stok.urun_satisf);
                gridView1.SetFocusedRowCellValue("urun_satisv", Stok.urun_satisv);
                frmMain.Aktarma = -1;
            }
            catch (Exception)
            {

            }
        }

        private void btnStokSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int StokID = Formlar.StokListesi(true);
            if(StokID > 0)
            {
                StokGetir(StokID);
            }
        }

        private void frmFaturaSatis_Load(object sender, EventArgs e)
        {
            txtFaturaTarihi.Text = DateTime.Now.ToShortDateString();
            txtIrsaliyeTarih.Text = DateTime.Now.ToShortDateString();
            txtIrsaliyeNo.Text = Numara.IrsaliyeNumarasi();
            txtFaturaNo.Text = Numara.FaturaNumarasi();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                decimal miktar = 0, birim_fiyat = 0, toplam = 0;

                if (e.Column.Name != "toplam")
                {
                    miktar = decimal.Parse(gridView1.GetFocusedRowCellValue("miktar").ToString());
                    if (gridView1.GetFocusedRowCellValue("urun_satisf").ToString() != "") birim_fiyat = decimal.Parse(gridView1.GetFocusedRowCellValue("urun_satisf").ToString());
                    toplam = miktar * birim_fiyat;

                    gridView1.SetFocusedRowCellValue("toplam", toplam);
                    
                }

                Hesapla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Hesapla()
        {
            try
            {
                //decimal birim_fiyat = 0, miktar = 0, genel_toplam = 0, ara_toplam = 0, kdv = 0, iskonto = 0;
                //for (int i = 1; i < gridView1.RowCount; i++)
                //{
                //    birim_fiyat = decimal.Parse(gridView1.GetRowCellValue(i, "urun_satisf").ToString());
                //    miktar = decimal.Parse(gridView1.GetRowCellValue(i, "miktar").ToString());
                //    kdv = decimal.Parse(gridView1.GetRowCellValue(i, "urun_satisv").ToString()) / 100 + 1;
                //    iskonto = decimal.Parse(txtIskonto.ToString());
                //    ara_toplam += miktar * birim_fiyat;
                //    genel_toplam += decimal.Parse(gridView1.GetRowCellValue(i, "toplam").ToString()) * kdv - iskonto;
                //}
                //txtAratoplam.Text = ara_toplam.ToString("0.00");
                //txtKdv.Text = (genel_toplam - ara_toplam).ToString("0.00");
                //txtGenelToplam.Text = genel_toplam.ToString("0.00");
                //txtIskonto.Text = iskonto.ToString("0.00");

                decimal birim_fiyat = 0, miktar = 0, genel_toplam = 0, ara_toplam = 0, kdv = 0, iskonto = 0;

                iskonto = string.IsNullOrEmpty(txtIskonto.Text) ? 0 : decimal.Parse(txtIskonto.Text);

                for (int i = 0; i < gridView1.RowCount; i++) // İlk satırı da dahil ettik.
                {
                    birim_fiyat = string.IsNullOrEmpty(gridView1.GetRowCellValue(i, "urun_satisf")?.ToString())
                        ? 0
                        : decimal.Parse(gridView1.GetRowCellValue(i, "urun_satisf").ToString());

                    miktar = string.IsNullOrEmpty(gridView1.GetRowCellValue(i, "miktar")?.ToString())
                        ? 0
                        : decimal.Parse(gridView1.GetRowCellValue(i, "miktar").ToString());

                    kdv = string.IsNullOrEmpty(gridView1.GetRowCellValue(i, "urun_satisv")?.ToString())
                        ? 1
                        : decimal.Parse(gridView1.GetRowCellValue(i, "urun_satisv").ToString()) / 100 + 1;

                    ara_toplam += miktar * birim_fiyat;

                    decimal toplam = string.IsNullOrEmpty(gridView1.GetRowCellValue(i, "toplam")?.ToString())
                        ? 0
                        : decimal.Parse(gridView1.GetRowCellValue(i, "toplam").ToString());

                    genel_toplam += toplam * kdv - iskonto;
                }

                txtAratoplam.Text = ara_toplam.ToString("0.00");
                txtKdv.Text = (genel_toplam - ara_toplam).ToString("0.00");
                txtGenelToplam.Text = genel_toplam.ToString("0.00");
                txtIskonto.Text = iskonto.ToString("0.00");

            }
            catch (Exception)
            {

            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Hesapla();
        }

        private void txtIskonto_EditValueChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void txtCariKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if(ID > 0) CariSec(ID);
            frmMain.Aktarma = -1;
        }

        void CariSec(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILER.First(s => s.ID == CariID);
                txtCariKod.Text = Cari.cari_kod;
                txtCariAdi.Text = Cari.cari_adi;
            }
            catch (Exception)
            {

            }
        }

        private void txtFaturaTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFaturaTur.SelectedIndex == 1) pnlOdeme.Enabled = false;
            if (txtFaturaTur.SelectedIndex == 0) pnlOdeme.Enabled = true;
        }

        void FaturaGuncelle()
        {
            try
            {
                Fonksiyonlar.TBL_FATURALAR Fatura = DB.TBL_FATURALAR.First(s => s.ID == FaturaID);
                Fatura.ACIKLAMA = txtAciklama.Text;
                Fatura.CARIKODU = txtCariKod.Text;
                Fatura.FATURANO = txtFaturaNo.Text;
                Fatura.GENELTOPLAM = decimal.Parse(txtGenelToplam.Text);
                Fatura.ODEMEYERI = txtOdemeYeri.Text;
                Fatura.ODEMEYERIID = OdemeID;
                DB.SubmitChanges();
                Fonksiyonlar.TBL_IRSALIYELER Irsaliye = DB.TBL_IRSALIYELER.First(s => s.ID == IrsaliyeID);
                Irsaliye.IRSALIYENO = txtIrsaliyeNo.Text;
                Irsaliye.TARIHI = DateTime.Parse(txtIrsaliyeTarih.Text);
                DB.TBL_STOKHAREKETLERI.DeleteAllOnSubmit(DB.TBL_STOKHAREKETLERI.Where(s => s.FATURAID == FaturaID));
                DB.SubmitChanges();
                Fonksiyonlar.TBL_STOKHAREKETLERI[] StokHareketi = new Fonksiyonlar.TBL_STOKHAREKETLERI[gridView1.RowCount];
                for(int i = 0; i < gridView1.RowCount; i++)
                {
                    StokHareketi[i] = new Fonksiyonlar.TBL_STOKHAREKETLERI();
                    StokHareketi[i].FATURAID = FaturaID;
                    StokHareketi[i].BIRIMFIYAT = decimal.Parse(gridView1.GetRowCellValue(i, "urun_satisf").ToString());
                    StokHareketi[i].GCKODU = "C";
                    StokHareketi[i].IRSALIYEID = IrsaliyeID;
                    StokHareketi[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "urun_satisv").ToString());
                    StokHareketi[i].MIKTAR = int.Parse(gridView1.GetRowCellValue(i, "miktar").ToString());
                    StokHareketi[i].STOKKODU = gridView1.GetRowCellValue(i, "urun_kodu").ToString();
                    StokHareketi[i].TIPI = "Satış Faturası";
                    DB.TBL_STOKHAREKETLERI.InsertOnSubmit(StokHareketi[i]);
                }
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERI.First(s => s.evrak_turu == "Satış Faturası" && s.evrak_id == FaturaID);
                if(txtFaturaTur.SelectedIndex == 0)
                {
                    CariHareket.alacak = 0;
                    CariHareket.borc = decimal.Parse(txtGenelToplam.Text);
                }
                else if(txtFaturaTur.SelectedIndex == 1)
                {
                    CariHareket.borc = decimal.Parse(txtGenelToplam.Text);
                    CariHareket.alacak = decimal.Parse(txtGenelToplam.Text);
                }
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void YeniFaturaKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_FATURALAR Fatura = new Fonksiyonlar.TBL_FATURALAR();
                Fatura.ACIKLAMA = txtAciklama.Text;
                Fatura.CARIKODU = txtCariKod.Text;
                Fatura.FATURANO = txtFaturaNo.Text;
                Fatura.FATURATURU = txtFaturaTur.Text;  
                Fatura.GENELTOPLAM = decimal.Parse(txtGenelToplam.Text);
                Fatura.IRSALIYEID = IrsaliyeID;
                Fatura.ODEMEYERI = txtOdemeYeri.Text;
                Fatura.ODEMEYERIID = OdemeID;
                Fatura.TARIHI = DateTime.Parse(txtFaturaTarihi.Text);
                DB.TBL_FATURALAR.InsertOnSubmit(Fatura);
                DB.SubmitChanges();
                if (IrsaliyeID < 0)
                {
                    Fonksiyonlar.TBL_IRSALIYELER Irsaliye = new Fonksiyonlar.TBL_IRSALIYELER();
                    Irsaliye.ACIKLAMA = txtAciklama.Text;
                    Irsaliye.CARIKODU = txtCariKod.Text;
                    Irsaliye.FATURAID = Fatura.ID;
                    Irsaliye.IRSALIYENO = txtIrsaliyeNo.Text;
                    Irsaliye.TARIHI = DateTime.Parse(txtIrsaliyeTarih.Text);
                    DB.TBL_IRSALIYELER.InsertOnSubmit(Irsaliye);
                    DB.SubmitChanges();
                    IrsaliyeID = Irsaliye.ID;
                    Fatura.IRSALIYEID = IrsaliyeID;
                }
                Fonksiyonlar.TBL_STOKHAREKETLERI[] StokHareketi = new Fonksiyonlar.TBL_STOKHAREKETLERI[gridView1.RowCount];
                for(int i = 0; i < gridView1.RowCount; i++)
                {
                    StokHareketi[i] = new Fonksiyonlar.TBL_STOKHAREKETLERI();
                    StokHareketi[i].BIRIMFIYAT = decimal.Parse(gridView1.GetRowCellValue(i, "urun_satisf").ToString());
                    StokHareketi[i].FATURAID = Fatura.ID;
                    StokHareketi[i].GCKODU = "C";
                    StokHareketi[i].MIKTAR = int.Parse(gridView1.GetRowCellValue(i, "miktar").ToString());
                    StokHareketi[i].IRSALIYEID = IrsaliyeID;
                    StokHareketi[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "urun_satisv").ToString());
                    StokHareketi[i].STOKKODU = gridView1.GetRowCellValue(i, "urun_kodu").ToString();
                    StokHareketi[i].TIPI = "Satış Faturası";
                    DB.TBL_STOKHAREKETLERI.InsertOnSubmit(StokHareketi[i]);
                }
                DB.SubmitChanges();

                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.aciklama = txtFaturaNo.Text + " no'lu satış fatura tutarı";
                if(txtFaturaTur.SelectedIndex == 0)
                {
                    CariHareket.alacak = 0;
                    CariHareket.borc = decimal.Parse(txtGenelToplam.Text);
                }
                else if (txtFaturaTur.SelectedIndex == 1)
                {
                    CariHareket.alacak = decimal.Parse(txtGenelToplam.Text);
                    CariHareket.borc = 0;
                }
                CariHareket.cari_id = CariID;
                CariHareket.tarih = DateTime.Now;
                CariHareket.tipi = "SF";
                CariHareket.evrak_turu = "Satış Faturası";
                CariHareket.evrak_id = Fatura.ID;
                DB.TBL_CARIHAREKETLERI.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                MessageBox.Show("Yeni Fatura Kaydı Oluşturuldu");
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show (e.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && FaturaID > 0) FaturaGuncelle();
            else YeniFaturaKaydet();

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            var srg = DB.VW_FATURALAR.Where(s => s.FATURANO == txtFaturaNo.Text);

            DataSet ds = new DataSet();
            ds.Tables.Add(LINQToDataTable(srg));

            rprSatisFatura rpr = new rprSatisFatura();
            rpr.DataSource = ds;
            rpr.ShowPreview();
        }

        public DataTable LINQToDataTable<T>(IEnumerable<T> Lnqlst)
        {
            DataTable dt = new DataTable();


            PropertyInfo[] columns = null;

            if (Lnqlst == null) return dt;

            foreach (T Record in Lnqlst)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

    }
}
