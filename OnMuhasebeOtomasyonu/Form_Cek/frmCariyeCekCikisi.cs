using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnMuhasebeOtomasyonu.Form_Cek
{
    public partial class frmCariyeCekCikisi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();   
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public frmCariyeCekCikisi()
        {
            InitializeComponent();
        }

        private void frmCariyeCekCikisi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVade.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtBanka.Text = "";
            txtBelge.Text = "";
            txtCariAd.Text = "";
            txtCariKod.Text = "";
            txtCekNo.Text = "";
            txtSube.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            txtVade.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            Edit = false;
            frmMain.Aktarma = -1;
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILER.First(s => s.ID == CariID);
                txtCariAd.Text = Cari.cari_adi;
                txtCariKod.Text = Cari.cari_kod;
            }
            catch (Exception)
            {

            }
        }

        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.tblCekler Cek = DB.tblCekler.First(s => s.ID == CekID);
                txtBanka.Text = Cek.banka;
                txtCekNo.Text = Cek.cek_no;
                txtSube.Text = Cek.sube;
                txtVade.Text = Cek.vade_tarihi.Value.ToShortDateString();
                txtTutar.Text = Cek.tutar.Value.ToString();
                if (Cek.verilen_cari_id != null)
                {
                    if (Cek.verilen_cari_id.Value > 0)
                    {
                        CariAc(Cek.verilen_cari_id.Value);
                        txtBelge.Text = Cek.verilencari_belgeno;
                        txtTarih.Text = Cek.verilencari_tarihi.Value.ToShortDateString();
                    } 
                }
            }
            catch (Exception)
            {

            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tblCekler Cek = DB.tblCekler.First(s => s.ID == CekID);
                Cek.verilen_cari_id = CariID;
                Cek.verilencari_tarihi = DateTime.Parse(txtTarih.Text);
                Cek.verilencari_belgeno = txtBelge.Text;
                Cek.durum = "Caride";
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.aciklama = txtCekNo.Text + " çek numaralı ve " + txtBelge.Text + " belge numaralı çek";
                CariHareket.borc = decimal.Parse(txtTutar.Text);
                CariHareket.cari_id = CariID;
                CariHareket.evrak_id = CekID;
                CariHareket.evrak_turu = "Cariye Çek";
                CariHareket.tarih = DateTime.Now;
                CariHareket.tipi = "Çek İşlemi";
                DB.TBL_CARIHAREKETLERI.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                MessageBox.Show("Çek Çıkışı Yapıldı");
                Temizle();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.tblCekler Cek = DB.tblCekler.First(s => s.ID == CekID);
                Cek.verilen_cari_id = CariID;
                Cek.verilencari_tarihi = DateTime.Parse(txtTarih.Text);
                Cek.verilencari_belgeno = txtBelge.Text;
                Cek.durum = "Caride";
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERI.First(s => s.evrak_turu == "Cariye Çek" && s.evrak_id == CekID);
                CariHareket.aciklama = txtCekNo.Text + " çek numaralı ve " + txtBelge.Text + " belge numaralı çek";
                CariHareket.borc = decimal.Parse(txtTutar.Text);
                CariHareket.cari_id = CariID;
                CariHareket.evrak_id = CekID;
                CariHareket.evrak_turu = "Cariye Çek Çıkışı";
                CariHareket.tarih = DateTime.Now;
                CariHareket.tipi = "Çek İşlemi";
                DB.SubmitChanges();
                MessageBox.Show("Güncellendi");
                Temizle();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Ac(int CekIDsi)
        {
            try
            {
                CekID = CekIDsi;
                CekGetir(CekID);
                Edit = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void txtCariKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if(ID > 0) CariAc(ID);
            frmMain.Aktarma = -1;
        }

        private void txtCekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CekListesi(true);
            if (ID > 0) CekGetir(ID);
            frmMain.Aktarma = -1;   
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && CekID > 0) Guncelle();
            else if (CariID > 0 && CekID > 0) YeniKaydet();
            else MessageBox.Show("Çek veya Cari seçiniz");
        }
    }
}
