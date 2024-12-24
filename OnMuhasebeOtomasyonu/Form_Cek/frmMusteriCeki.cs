using DevExpress.Accessibility;
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
    public partial class frmMusteriCeki : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext(); 
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        int cariId = -1;
        int cekId = -1;
        bool Edit = false;

        public frmMusteriCeki()
        {
            InitializeComponent();
        }

        private void frmMusteriCeki_Load(object sender, EventArgs e)
        {
            txtVade.Text = DateTime.Now.ToShortDateString();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Ac(int ID)
        {
            try
            {
                cekId = ID;
                Fonksiyonlar.tblCekler Cek = DB.tblCekler.First(s => s.ID == cekId);
                txtAciklama.Text = Cek.aciklama;
                if (Cek.ac_kodu == "A") txtTur.SelectedIndex = 0;
                if(Cek.ac_kodu == "C") txtTur.SelectedIndex = 1;
                txtBorclu.Text = Cek.asil_borclu;
                txtBanka.Text = Cek.banka;
                txtBelge.Text = Cek.belge_no;
                txtCek.Text = Cek.cek_no;
                txtHesap.Text = Cek.hesap_no;
                txtSube.Text = Cek.sube;
                txtTutar.Text = Cek.tutar.Value.ToString();
                txtVade.Text = Cek.vade_tarihi.Value.ToShortDateString();
                CariAc(Cek.alinan_cari_id.Value);
                Edit = true;
            }
            catch (Exception)
            {
                Temizle();
            }
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBanka.Text = "";
            txtBelge.Text = "";
            txtBorclu.Text = "";
            txtCariAd.Text = "";
            txtCariKod.Text = "";
            txtCek.Text = "";
            txtHesap.Text = "";
            txtSube.Text = "";
            txtTur.SelectedIndex = 0;
            txtTutar.Text = "";
            txtVade.Text = DateTime.Now.ToShortDateString();
            cariId = -1;
            cekId = -1;
            Edit = false;
            frmMain.Aktarma = -1;
        }

        void YeniCekKaydet()
        {
            try
            {
                Fonksiyonlar.tblCekler Cek = new Fonksiyonlar.tblCekler();
                Cek.aciklama = txtAciklama.Text;
                if (txtTur.SelectedIndex == 0) Cek.ac_kodu = "A";
                if (txtTur.SelectedIndex == 1) Cek.ac_kodu = "C";
                Cek.alinan_cari_id = cariId;
                Cek.banka = txtBanka.Text;
                Cek.belge_no = txtBelge.Text;
                Cek.cek_no = txtCek.Text;
                Cek.durum = "Portföy";
                Cek.hesap_no = txtHesap.Text;
                Cek.sube = txtSube.Text;
                Cek.tahsil = "Hayır";
                Cek.vade_tarihi = DateTime.Parse(txtVade.Text);
                Cek.tutar = decimal.Parse(txtTutar.Text);
                Cek.tip = "Müşteri Çeki";
                Cek.asil_borclu = txtBorclu.Text;
                Cek.tarih = DateTime.Now;
                DB.tblCekler.InsertOnSubmit(Cek);
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.aciklama = txtBelge.Text + " belge numaralı " + txtCek.Text + " çek numaralı müşteri çeki";
                CariHareket.cari_id = cariId;
                CariHareket.evrak_id = Cek.ID;
                CariHareket.evrak_turu = "Müşteri Çeki";
                CariHareket.tarih = DateTime.Now;
                CariHareket.tipi = "MÇ";
                DB.TBL_CARIHAREKETLERI.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Oluşturuldu!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.tblCekler Cek = DB.tblCekler.First(s => s.ID == cekId);
                Cek.aciklama = txtAciklama.Text;
                if (txtTur.SelectedIndex == 0) Cek.ac_kodu = "A";
                if (txtTur.SelectedIndex == 1) Cek.ac_kodu = "C";
                Cek.alinan_cari_id = cariId;
                Cek.banka = txtBanka.Text;
                Cek.belge_no = txtBelge.Text;
                Cek.cek_no = txtCek.Text;
                Cek.durum = "Portföy";
                Cek.hesap_no = txtHesap.Text;
                Cek.sube = txtSube.Text;
                Cek.tahsil = "Hayır";
                Cek.vade_tarihi = DateTime.Parse(txtVade.Text);
                Cek.tutar = decimal.Parse(txtTutar.Text);
                Cek.tip = "Müşteri Çeki";
                Cek.asil_borclu = txtBorclu.Text;
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERI.First(s => s.evrak_id == cekId && s.evrak_turu == "Müşteri Çeki");
                CariHareket.aciklama = txtBelge.Text + " belge numaralı " + txtCek.Text + " çek numaralı müşteri çeki";
                CariHareket.cari_id = cariId;
                CariHareket.evrak_id = Cek.ID;
                CariHareket.evrak_turu = "Müşteri Çeki";
                CariHareket.tarih = DateTime.Now;
                CariHareket.tipi = "MÇ";
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
            }
        }



        void CariAc(int ID)
        {
            cariId = ID;
            Fonksiyonlar.TBL_CARILER cari = DB.TBL_CARILER.First(s => s.ID == cariId);
            txtCariAd.Text = cari.cari_adi;
            txtCariKod.Text = cari.cari_kod;
        }

        private void txtCariKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);
            if(id > 0)
            {
                CariAc(id);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit) Guncelle();
            else YeniCekKaydet();
        }
    }
}
