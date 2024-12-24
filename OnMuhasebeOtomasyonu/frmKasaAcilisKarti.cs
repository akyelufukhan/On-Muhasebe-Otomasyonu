using OnMuhasebeOtomasyonu.Fonksiyonlar;
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
    public partial class frmKasaAcilisKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();

        bool Edit = false;
        int SecimID = -1;
        public frmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            Listele();
            txtKasaKodu.Text = Numara.KasaKodNumarasi();
        }

        void Temizle()
        {
            txtKasaKodu.Text = Numara.KasaKodNumarasi();
            txtKasaAdi.Text = "";
            txtAciklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void YeniKayit()
        {
            try
            {
                Fonksiyonlar.TBL_KASALAR Kasa = new Fonksiyonlar.TBL_KASALAR();
                Kasa.aciklama = txtAciklama.Text;
                Kasa.kasa_adi = txtKasaAdi.Text;
                Kasa.kasa_kodu = txtKasaKodu.Text;
                db.TBL_KASALAR.InsertOnSubmit(Kasa);
                db.SubmitChanges();
                MessageBox.Show("Kayıt Oluşturuldu!");
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata Oluştu!" + e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_KASALAR Kasa = db.TBL_KASALAR.First(s => s.ID == SecimID);
                Kasa.aciklama = txtAciklama.Text;
                Kasa.kasa_adi = txtKasaAdi.Text;
                Kasa.kasa_kodu = txtKasaKodu.Text;
                db.SubmitChanges();
                MessageBox.Show("Kayıt Güncellendi!");
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata Oluştu!" + e);
            }
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtKasaKodu.Text = gridView1.GetFocusedRowCellValue("kasa_kodu").ToString();
                txtKasaAdi.Text = gridView1.GetFocusedRowCellValue("kasa_adi").ToString();
                txtAciklama.Text = gridView1.GetFocusedRowCellValue("aciklama").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void Listele()
        {
            var lst = from s in db.TBL_KASALAR
                      select s;
            gridControl1.DataSource = lst;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtKasaAdi.Text != "" && txtAciklama.Text != "")
            {
                if (Edit && SecimID > 0) Guncelle();
                else YeniKayit();
            }
            else
            {
                MessageBox.Show("Kasa Adı ve Açıklama Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}
