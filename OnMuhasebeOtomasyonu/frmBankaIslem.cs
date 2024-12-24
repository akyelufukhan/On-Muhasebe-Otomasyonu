using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnMuhasebeOtomasyonu
{
    public partial class frmBankaIslem : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;

        public frmBankaIslem()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBankaIslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtHesapNo.Text = "";
            txtHesapTuru.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
        }

        void YeniKayit()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Hareket.aciklama = txtAciklama.Text;
                Hareket.banka_id = BankaID;
                Hareket.belge_no = txtBelgeNo.Text;
                Hareket.evrak_turu = "Banka İşlem";
                if (rBtnGiris.Checked) Hareket.gckodu = "G";
                if (rBtnCikis.Checked) Hareket.gckodu = "C";
                Hareket.tarih = DateTime.Parse(txtTarih.Text);
                Hareket.tutar = decimal.Parse(txtTutar.Text);
                DB.TBL_BANKAHAREKETLERI.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Oluşturuldu!");
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = DB.TBL_BANKAHAREKETLERI.First(s=> s.ID == IslemID);
                Hareket.aciklama = txtAciklama.Text;
                Hareket.banka_id = BankaID;
                Hareket.belge_no = txtBelgeNo.Text;
                Hareket.evrak_turu = "Banka İşlem";
                if (rBtnGiris.Checked) Hareket.gckodu = "G";
                if (rBtnCikis.Checked) Hareket.gckodu = "C";
                Hareket.tarih = DateTime.Parse(txtTarih.Text);
                Hareket.tutar = decimal.Parse(txtTutar.Text);
                DB.TBL_BANKAHAREKETLERI.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Oluşturuldu!");
                Temizle();
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
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = DB.TBL_BANKAHAREKETLERI.First(s => s.ID == IslemID);
                BankaAc(Hareket.banka_id.Value);
                txtAciklama.Text = Hareket.aciklama;
                txtBelgeNo.Text = Hareket.belge_no;
                txtTarih.Text = Hareket.tarih.Value.ToShortDateString();
                txtTutar.Text = Hareket.tutar.ToString();
                if(Hareket.gckodu == "G") rBtnGiris.Checked = true;
                if(Hareket.gckodu == "C") rBtnGiris.Checked = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapTuru.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).hesap_adi;
                txtHesapNo.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).hesap_no;
            }
            catch (Exception)
            {

            }
        }

        private void txtHesapTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.BankaListesi(true);
            if(ID > 0) BankaAc(ID);
            frmMain.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0) Guncelle();
            else YeniKayit();   
        }
    }
}
