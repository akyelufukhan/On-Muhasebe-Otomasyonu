using OnMuhasebeOtomasyonu.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnMuhasebeOtomasyonu
{
    public partial class frmStokKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public bool Edit = false;
        int StokID = -1;
        int GrupId = -1;

        public frmStokKarti()
        {
            InitializeComponent();
        }

        private void frmStokKarti_Load(object sender, EventArgs e)
        {
            txtStokKod.Text = Numara.StokKodNumarasi();
        }

        void Temizle()
        {
            txtStokKod.Text = Numara.StokKodNumarasi();
            txtStokAdi.Text = "";
            txtSatisKdv.Text = "0";
            txtSatisFiyat.Text = "0";
            txtGrupKod.Text = "";
            txtGrupAdi.Text = "";
            txtBirim.SelectedIndex = 0;
            txtAlisKdv.Text = "0";
            txtAlisFiyat.Text = "0";
            GrupId = -1;
            StokID = -1;
        }

        public void Ac(int ID)
        {
            Edit = true;
            StokID = ID;
            Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
            GrupAc(Stok.urun_grup_id);
            txtAlisFiyat.Text = Stok.urun_alisf.ToString();
            txtAlisKdv.Text = Stok.urun_alisv.ToString();
            txtBirim.Text = Stok.urun_birim;
            txtSatisFiyat.Text = Stok.urun_satisf.ToString();
            txtSatisKdv.Text = Stok.urun_satisv.ToString();
            txtStokAdi.Text = Stok.urun_adi;
            txtStokKod.Text = Stok.urun_kodu;
        }

        void GrupAc(int ID)
        {
            GrupId = ID;
            txtGrupAdi.Text = DB.TBL_STOKGRUPLARI.First(s => s.ID == GrupId).grup_ad;
            txtGrupKod.Text = DB.TBL_STOKGRUPLARI.First(s => s.ID == GrupId).grup_kod;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = new Fonksiyonlar.TBL_STOKLAR();
                Stok.urun_adi = txtStokAdi.Text;
                Stok.urun_alisf = decimal.Parse(txtAlisFiyat.Text);
                Stok.urun_alisv = decimal.Parse(txtAlisKdv.Text);
                Stok.urun_birim = txtBirim.Text;
                Stok.urun_kodu = txtStokKod.Text;
                Stok.urun_satisf = decimal.Parse(txtSatisFiyat.Text);
                Stok.urun_satisv = decimal.Parse(txtSatisKdv.Text);
                Stok.urun_turu = txtStokTuru.Text;
                Stok.urun_grup_id = GrupId;
                DB.TBL_STOKLAR.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                MessageBox.Show("ÜRÜN BAŞARIYLA EKLENMİŞTİR!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();

                frmStokListesi frmStokListesi = new frmStokListesi();
                frmStokListesi.Show();
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ÜRÜN EKLENİRKEN BİR HATA OLUŞTU! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
                Stok.urun_adi = txtStokAdi.Text;
                Stok.urun_alisf = decimal.Parse(txtAlisFiyat.Text);
                Stok.urun_alisv = decimal.Parse(txtAlisKdv.Text);
                Stok.urun_birim = txtBirim.Text;
                Stok.urun_kodu = txtStokKod.Text;
                Stok.urun_satisf = decimal.Parse(txtSatisFiyat.Text);
                Stok.urun_satisv = decimal.Parse(txtSatisKdv.Text);
                Stok.urun_turu = txtStokTuru.Text;
                Stok.urun_grup_id = GrupId;
                DB.SubmitChanges();
                MessageBox.Show("ÜRÜN BAŞARIYLA GÜNCELLENMİŞTİR!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();

                frmStokListesi frmStokListesi = new frmStokListesi();
                frmStokListesi.Show();
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ÜRÜN EKLENİRKEN BİR HATA OLUŞTU! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_STOKLAR.DeleteOnSubmit(DB.TBL_STOKLAR.First(s => s.ID == StokID));
            }
            catch
            {
                MessageBox.Show("ÜRÜN SİLİNİRKEN BİR HATA OLUŞTU!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0) Guncelle();
            else YeniKaydet();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtStokKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0) 
            {
                Ac(ID);
            }
            frmMain.Aktarma = -1;
        }

        private void txtGrupKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokGruplari(true);
            if(ID > 0)
            {
                GrupAc(ID);
            }
            frmMain.Aktarma = -1;
        }
    }
}
