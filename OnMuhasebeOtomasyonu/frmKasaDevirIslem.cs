using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnMuhasebeOtomasyonu
{
    public partial class frmKasaDevirIslem : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;
        public frmKasaDevirIslem()
        {
            InitializeComponent();
        }

        private void frmKasaDevirIslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTutar.Text = "0";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            frmMain.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                Hareket.aciklama = txtAciklama.Text;
                Hareket.belge_no = txtBelgeNo.Text;
                Hareket.evrak_turu = "Kasa Devir Kartı";
                if (rBtnCikis.Checked) Hareket.gckodu = "C";
                if (rBtnGiris.Checked) Hareket.gckodu = "G";
                Hareket.kasa_id = KasaID;
                Hareket.tarih = DateTime.Parse(txtTarih.Text);
                Hareket.tutar = decimal.Parse(txtTutar.Text);
                DB.TBL_KASAHAREKETLERI.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Oluşturuldu!");
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!" + ex);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERI.First(s => s.ID == IslemID);
                Hareket.aciklama = txtAciklama.Text;
                Hareket.belge_no = txtBelgeNo.Text;
                Hareket.evrak_turu = "Kasa Devir Kartı";
                if (rBtnCikis.Checked) Hareket.gckodu = "C";
                if (rBtnGiris.Checked) Hareket.gckodu = "G";
                Hareket.kasa_id = KasaID;
                Hareket.tarih = DateTime.Parse(txtTarih.Text);
                Hareket.tutar = decimal.Parse(txtTutar.Text);
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Güncellendi!");
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!" + ex);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0) Guncelle();
            else YeniKaydet();
        }

        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaAdi.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).kasa_adi;
                txtKasaKodu.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).kasa_kodu;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERI.First(s => s.ID == IslemID);
                txtAciklama.Text = Hareket.aciklama;
                txtBelgeNo.Text = Hareket.belge_no;
                KasaAc(Hareket.kasa_id.Value);
                txtTarih.Text = Hareket.tarih.Value.ToShortDateString();
                txtTutar.Text = Hareket.tutar.Value.ToString();
                if (Hareket.gckodu == "G") rBtnGiris.Checked = true;
                if (Hareket.gckodu == "C") rBtnCikis.Checked = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if(ID > 0)
            {
                KasaAc(ID);
                frmMain.Aktarma = -1;
            }
        }

        private void txtBelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
