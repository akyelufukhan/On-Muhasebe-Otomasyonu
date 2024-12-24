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
    public partial class frmCariGruplari : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();

        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;
        public frmCariGruplari()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CARIGRUPLARI
                      select s;
            Liste.DataSource = lst;
        }

        void Temizle()
        {
            txtGrupAd.Text = "";
            txtGrupKodu.Text = Numara.CariGrupKodNumarasi();
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAd.Text = gridView1.GetFocusedRowCellValue("grup_ad").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("grup_kodu").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void YeniKayit()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = new Fonksiyonlar.TBL_CARIGRUPLARI();
                Grup.grup_ad = txtGrupAd.Text;
                Grup.grup_kodu = txtGrupKodu.Text;
                DB.TBL_CARIGRUPLARI.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                MessageBox.Show("GRUP BAŞARIYLA EKLENMİŞTİR!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("GRUP EKLENİRKEN BİR HATA OLUŞTU! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = DB.TBL_CARIGRUPLARI.First(s => s.ID == SecimID);
                Grup.grup_ad = txtGrupAd.Text;
                Grup.grup_kodu = txtGrupKodu.Text;
                DB.SubmitChanges();
                MessageBox.Show("GRUP BAŞARIYLA GÜNCELLENMİŞTİR!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception e)
            {

                MessageBox.Show("GRUP GÜNCELLENİRKEN BİR HATA OLUŞTU! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_CARIGRUPLARI.DeleteOnSubmit(DB.TBL_CARIGRUPLARI.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("GRUP SİLİNİRKEN BİR HATA OLUŞTU! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0) Guncelle();
            else YeniKayit();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Edit && SecimID > 0)
            {
                Sil();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
            txtGrupKodu.Text = Numara.CariGrupKodNumarasi();
        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                frmMain.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}
