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

namespace OnMuhasebeOtomasyonu
{
    public partial class frmCariKarti : Form
    {
        Fonksiyonlar.Ayarlar Ayarlar = new Fonksiyonlar.Ayarlar();
        SqlConnection baglanti = new SqlConnection(Ayarlar.Baglanti);
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;

        public frmCariKarti()
        {
            InitializeComponent();
        }

        private void frmCariKarti_Load(object sender, EventArgs e)
        {
            textEdit1.Text = Numara.CariKodNumarasi();
            CalisanCek();
        }

        public void CalisanCek()
        {
            baglanti.Open();
            SqlCommand calisanKomut = new SqlCommand("SELECT * FROM tblCalisan", baglanti);
            SqlDataReader reader = calisanKomut.ExecuteReader();

            while (reader.Read()) 
            {
                txtSatisEleman.Properties.Items.Add(reader["calisan_adi"].ToString());
            }
            
            baglanti.Close();
            reader.Close();
        }

        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";

            foreach (Control CE in groupControl2.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";

            textEdit1.Text = Numara.CariKodNumarasi();
            txtCariTuru.SelectedIndex = 0;
            txtSatisEleman.SelectedIndex = 0;
            Edit = false;
            CariID = -1;
            GrupID = -1;
            frmMain.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARILER Cari = new Fonksiyonlar.TBL_CARILER();
                Cari.cari_adi = txtCariAdi.Text;
                Cari.cari_adres = txtAdres.Text;
                Cari.cari_email = txtMail.Text;
                Cari.cari_fax = txtFax.Text;
                Cari.cari_kod = textEdit1.Text;
                Cari.cari_satiselemani = txtSatisEleman.SelectedIndex;
                Cari.cari_telefon = txtTel1.Text;
                Cari.cari_telefon2 = txtTel2.Text;
                Cari.cari_turu = txtCariTuru.Text;
                Cari.cari_vergidaire = txtVergiDaire.Text;
                Cari.cari_vergino = txtVergiNumara.Text;
                Cari.cari_kimlik = txtKimlik.Text;
                Cari.cari_grup_id = GrupID;
                DB.TBL_CARILER.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Oluşturuldu!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("Kayıt Oluşturulurken Bir Hata Oluştu! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILER.First(s => s.ID == CariID);
                Cari.cari_adi = txtCariAdi.Text;
                Cari.cari_adres = txtAdres.Text;
                Cari.cari_email = txtMail.Text;
                Cari.cari_fax = txtFax.Text;
                Cari.cari_kod = textEdit1.Text;
                Cari.cari_satiselemani = txtSatisEleman.SelectedIndex;
                Cari.cari_telefon = txtTel1.Text;
                Cari.cari_telefon2 = txtTel2.Text;
                Cari.cari_turu = txtCariTuru.Text;
                Cari.cari_vergidaire = txtVergiDaire.Text;
                Cari.cari_vergino = txtVergiNumara.Text;
                Cari.cari_kimlik = txtKimlik.Text;
                Cari.cari_grup_id = GrupID;
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("Kayıt Güncellenirken Bir Hata Oluştu! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_CARILER.DeleteOnSubmit(DB.TBL_CARILER.First(s => s.ID == CariID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("Kayıt Silinirken Bir Hata Oluştu! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GrupAc(int ID)
        {
            try
            {
                GrupID = ID;
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = DB.TBL_CARIGRUPLARI.First(s => s.ID == GrupID);
                txtGrupAdi.Text = Grup.grup_ad;
                txtGrupKodu.Text = Grup.grup_kodu;
            }
            catch (Exception e)
            {
                MessageBox.Show("Bir Hata Oluştu! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILER.First(s => s.ID == CariID);
                txtAdres.Text = Cari.cari_adres;
                txtCariAdi.Text = Cari.cari_adi;
                textEdit1.Text = Cari.cari_kod;
                txtCariTuru.Text = Cari.cari_turu;
                txtFax.Text = Cari.cari_fax;
                txtKimlik.Text = Cari.cari_kimlik;
                txtMail.Text = Cari.cari_email;
                txtSatisEleman.SelectedIndex = Cari.cari_satiselemani;
                txtTel1.Text = Cari.cari_telefon;
                txtTel2.Text = Cari.cari_telefon2;
                txtVergiDaire.Text = Cari.cari_vergidaire;
                txtVergiNumara.Text = Cari.cari_vergino;
                GrupAc(Cari.cari_grup_id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Bir Hata Oluştu! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0) Guncelle();
            else YeniKaydet();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCariTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCariTuru.SelectedIndex == 1)
            {
                labelTc.Visible = true;
                txtKimlik.Visible = true;
                txtVergiNumara.Enabled = false;
                txtVergiDaire.Enabled = false;
                txtVergiDaire.Text = "";
                txtVergiNumara.Text = "";
            }
            else if (txtCariTuru.SelectedIndex == 0)
            {
                labelTc.Visible = false;
                txtKimlik.Visible = false;
                txtVergiNumara.Enabled = true;
                txtVergiDaire.Enabled = true;
                txtKimlik.Text = "";
            }
        }

        private void txtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariGruplari(true);
            if(ID > 0)
            {
                GrupAc(ID);
            }
            frmMain.Aktarma = -1;
        }

        private void textEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            frmMain.Aktarma = -1;
        }
    }
}
