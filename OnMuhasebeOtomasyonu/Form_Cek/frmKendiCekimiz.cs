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
    public partial class frmKendiCekimiz : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int CekID = -1;
        int BankaID = -1;
        bool Edit = false;
        public frmKendiCekimiz()
        {
            InitializeComponent();
        }

        private void frmKendiCekimiz_Load(object sender, EventArgs e)
        {
            txtVade.Text = DateTime.Now.ToShortDateString();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBanka.Text = "";
            txtBelge.Text = "";
            txtCek.Text = "";
            txtHesap.Text = "";
            txtSube.Text = "";
            txtTutar.Text = "";
            txtVade.Text = "";
            CekID = -1;
            BankaID = -1;
            Edit = false;
            frmMain.Aktarma = -1;
        }

        public void Ac(int CekinID)
        {
            try
            {
                CekID = CekinID;
                Fonksiyonlar.tblCekler Cek = DB.tblCekler.First(s => s.ID == CekID);
                BankaAc(DB.TBL_BANKALAR.First(s => s.banka_adi == Cek.banka && s.hesap_no == Cek.hesap_no).ID);
                txtAciklama.Text = Cek.aciklama;
                txtBelge.Text = Cek.belge_no;
                txtCek.Text = Cek.cek_no;
                txtTutar.Text = Cek.tutar.Value.ToString();
                txtVade.Text = Cek.vade_tarihi.Value.ToShortDateString();
                Edit = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
                Temizle();
            }
        }
        
        void BankaAc(int BankaninID)
        {
            try
            {
                BankaID = BankaninID;
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALAR.First(s => s.ID == BankaID);
                txtBanka.Text = Banka.banka_adi;
                txtHesap.Text = Banka.hesap_no;
                txtSube.Text = Banka.sube;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.tblCekler Cek = new Fonksiyonlar.tblCekler();
                Cek.aciklama = txtAciklama.Text;
                Cek.ac_kodu = "A";
                Cek.banka = txtBanka.Text;
                Cek.belge_no = txtBelge.Text;
                Cek.cek_no = txtCek.Text;
                Cek.durum = "Portföy";
                Cek.hesap_no = txtHesap.Text;
                Cek.sube = txtSube.Text;
                Cek.tahsil = "Hayır";
                Cek.tarih = DateTime.Now;
                Cek.tip = "Kendi Çekimiz";
                Cek.tutar = decimal.Parse(txtTutar.Text);
                Cek.vade_tarihi = DateTime.Parse(txtVade.Text);
                DB.tblCekler.InsertOnSubmit(Cek);
                DB.SubmitChanges();
                Fonksiyonlar.TBL_BANKAHAREKETLERI BankaHareketi = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                BankaHareketi.aciklama = txtCek.Text + " nolu ve " + txtVade.Text + " vadeli kendi çekimiz.";
                BankaHareketi.banka_id = BankaID;
                BankaHareketi.belge_no = txtBelge.Text;
                BankaHareketi.evrak_id = Cek.ID;
                BankaHareketi.evrak_turu = "KendiCekimiz";
                BankaHareketi.gckodu = "C";
                BankaHareketi.tarih = DateTime.Now;
                BankaHareketi.tutar = 0;
                DB.TBL_BANKAHAREKETLERI.InsertOnSubmit(BankaHareketi);
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Oluşturuldu!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Cek.aciklama = txtAciklama.Text;
                Cek.ac_kodu = "A";
                Cek.banka = txtBanka.Text;
                Cek.belge_no = txtBelge.Text;
                Cek.cek_no = txtCek.Text;
                Cek.durum = "Portföy";
                Cek.hesap_no = txtHesap.Text;
                Cek.sube = txtSube.Text;
                Cek.tahsil = "Hayır";
                Cek.tarih = DateTime.Now;
                Cek.tip = "Kendi Çekimiz";
                Cek.tutar = decimal.Parse(txtTutar.Text);
                Cek.vade_tarihi = DateTime.Parse(txtVade.Text);
                DB.SubmitChanges();
                Fonksiyonlar.TBL_BANKAHAREKETLERI BankaHareketi = DB.TBL_BANKAHAREKETLERI.First(s => s.evrak_id == CekID && s.evrak_turu == "Kendi Çekimiz");
                BankaHareketi.aciklama = txtCek.Text + " nolu ve " + txtVade.Text + " vadeli kendi çekimiz.";
                BankaHareketi.banka_id = BankaID;
                BankaHareketi.belge_no = txtBelge.Text;
                BankaHareketi.evrak_id = Cek.ID;
                BankaHareketi.evrak_turu = "KendiCekimiz";
                BankaHareketi.gckodu = "C";
                BankaHareketi.tarih = DateTime.Now;
                BankaHareketi.tutar = 0;
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtHesap_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if(Id > 0)
            {
                BankaAc(Id);
                frmMain.Aktarma = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0) Guncelle();
            else YeniKaydet();
        }
    }
}
