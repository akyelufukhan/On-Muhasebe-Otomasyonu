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
    public partial class frmKasaTahsilat : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        bool Edit = false;
        int IslemID = -1;
        int KasaID = -1;
        int CariID = -1;
        int CariHareketID = -1;
        string IslemTuru = "Kasa Tahsilat";
        public frmKasaTahsilat()
        {
            InitializeComponent();
        }

        private void frmKasaTahsilat_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            IslemTuru = txtIslemTuru.SelectedItem.ToString();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtIslemTuru.SelectedIndex = 0;
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            KasaID  = -1;
            CariID = -1;
            CariHareketID = -1;
            frmMain.Aktarma = -1;
        }

        public void Ac(int HareketID)
        {
            try
            {
                Edit = true;
                IslemID = HareketID;
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = DB.TBL_KASAHAREKETLERI.First(s => s.ID == IslemID);
                CariHareketID = DB.TBL_CARIHAREKETLERI.First(s => s.evrak_turu == KasaHareketi.evrak_turu && s.evrak_id == IslemID).ID;
                txtAciklama.Text = KasaHareketi.aciklama;
                txtBelgeNo.Text = KasaHareketi.belge_no;
                if (KasaHareketi.evrak_turu == "Kasa Tahsilat") txtIslemTuru.SelectedIndex = 0;
                if (KasaHareketi.evrak_turu == "Kasa Ödeme") txtIslemTuru.SelectedIndex = 1;
                txtTarih.Text = KasaHareketi.tarih.Value.ToShortDateString();
                txtTutar.Text = KasaHareketi.tutar.Value.ToString();
                KasaAc(KasaHareketi.kasa_id.Value);
                CariAc(KasaHareketi.cari_id.Value);
            }
            catch (Exception ex)
            {
                Temizle();
                MessageBox.Show("hata: " + ex);
            }
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
                KasaID = -1;
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariAdi.Text = DB.TBL_CARILER.First(s => s.ID == CariID).cari_adi;
                txtCariKodu.Text = DB.TBL_CARILER.First(s => s.ID == CariID).cari_kod;
            }
            catch (Exception)
            {
                CariID = -1;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                KasaHareketi.aciklama = txtAciklama.Text;
                KasaHareketi.belge_no = txtBelgeNo.Text;
                KasaHareketi.cari_id = CariID;
                KasaHareketi.evrak_turu = IslemTuru;
                if (txtIslemTuru.SelectedIndex == 0) KasaHareketi.gckodu = "G";
                if (txtIslemTuru.SelectedIndex == 1) KasaHareketi.gckodu = "C";
                KasaHareketi.kasa_id = KasaID;
                KasaHareketi.tarih = DateTime.Parse(txtTarih.Text);
                KasaHareketi.tutar = decimal.Parse(txtTutar.Text);
                DB.TBL_KASAHAREKETLERI.InsertOnSubmit(KasaHareketi);
                DB.SubmitChanges();
                MessageBox.Show(txtIslemTuru.SelectedIndex + " yeni kasa hareketi olarak işlenmiştir.");
                
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareketi = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareketi.aciklama = txtBelgeNo.Text + " belge numaralı " + txtIslemTuru.SelectedItem.ToString() + " işlemi";
                if (txtIslemTuru.SelectedIndex == 0) CariHareketi.alacak = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) CariHareketi.borc = decimal.Parse(txtTutar.Text);
                CariHareketi.cari_id = CariID;
                CariHareketi.evrak_id = KasaHareketi.ID;
                CariHareketi.evrak_turu = txtIslemTuru.SelectedItem.ToString();
                CariHareketi.tarih = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) CariHareketi.tipi = "KT";
                if (txtIslemTuru.SelectedIndex == 1) CariHareketi.tipi = "KÖ";
                DB.TBL_CARIHAREKETLERI.InsertOnSubmit(CariHareketi);
                DB.SubmitChanges();
                MessageBox.Show(txtIslemTuru.SelectedIndex + " yeni cari hareketi olarak işlenmiştir.");
            }
            catch (Exception e)
            {

                throw;
            }
        }

        void Guncelle()
        {

            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI KasaHareketi = DB.TBL_KASAHAREKETLERI.First(s => s.ID == IslemID);
                KasaHareketi.aciklama = txtAciklama.Text;
                KasaHareketi.belge_no = txtBelgeNo.Text;
                KasaHareketi.cari_id = CariID;
                KasaHareketi.evrak_turu = IslemTuru;
                if (txtIslemTuru.SelectedIndex == 0) KasaHareketi.gckodu = "G";
                if (txtIslemTuru.SelectedIndex == 1) KasaHareketi.gckodu = "C";
                KasaHareketi.kasa_id = KasaID;
                KasaHareketi.tarih = DateTime.Parse(txtTarih.Text);
                KasaHareketi.tutar = decimal.Parse(txtTutar.Text);
                DB.SubmitChanges();
                MessageBox.Show(txtIslemTuru.SelectedIndex + " yeni kasa hareketi olarak işlenmiştir.");


                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareketi = DB.TBL_CARIHAREKETLERI.First(s => s.ID == CariHareketID);
                CariHareketi.aciklama = txtBelgeNo.Text + " belge numaralı " + txtIslemTuru.SelectedItem.ToString() + " işlemi";
                if (txtIslemTuru.SelectedIndex == 0) CariHareketi.alacak = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) CariHareketi.borc = decimal.Parse(txtTutar.Text);
                CariHareketi.cari_id = CariID;
                CariHareketi.evrak_id = KasaHareketi.ID;
                CariHareketi.evrak_turu = txtIslemTuru.SelectedItem.ToString();
                CariHareketi.tarih = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) CariHareketi.tipi = "KT";
                if (txtIslemTuru.SelectedIndex == 1) CariHareketi.tipi = "KÖ";
                DB.SubmitChanges();
                MessageBox.Show(txtIslemTuru.SelectedIndex + " yeni cari hareketi olarak işlenmiştir.");

                Temizle();
            }
            catch (Exception e)
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

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if(ID > 0)
            {
                CariAc(ID);
                frmMain.Aktarma = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID > 0) Guncelle();
            else YeniKaydet();
        }
    }
}
