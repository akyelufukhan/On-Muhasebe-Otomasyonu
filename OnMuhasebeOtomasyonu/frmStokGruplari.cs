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
    public partial class frmStokGruplari : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Numara No = new Fonksiyonlar.Numara();
        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;
        public frmStokGruplari()
        {
            InitializeComponent();
        }

        private void frmStokGruplari_Load(object sender, EventArgs e)
        {
            Listele();
            txtGrupKodu.Text = No.StokGrupKodNumarasi();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_STOKGRUPLARI
                      select s;
            Liste.DataSource = lst;
        }

        void Temizle()
        {
            txtGrupAd.Text = "";
            txtGrupKodu.Text = No.StokGrupKodNumarasi();
            Edit = false;
            Listele();
        }

        void YeniKayit()
        {
            try
            {
                Fonksiyonlar.TBL_STOKGRUPLARI Grup = new Fonksiyonlar.TBL_STOKGRUPLARI();
                Grup.grup_ad = txtGrupAd.Text;
                Grup.grup_kod = txtGrupKodu.Text;
                DB.TBL_STOKGRUPLARI.InsertOnSubmit(Grup);
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
                Fonksiyonlar.TBL_STOKGRUPLARI Grup = DB.TBL_STOKGRUPLARI.First(s => s.ID == SecimID);
                Grup.grup_ad = txtGrupAd.Text;
                Grup.grup_kod = txtGrupKodu.Text;
                DB.SubmitChanges();
                MessageBox.Show("GRUP BAŞARIYLA GÜNCELLENMİŞTİR!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show("GRUP GÜNCELLENİRKEN BİR HATA OLUŞTU! " + e.Message, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit && SecimID > 0) Guncelle();
            else YeniKayit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAd.Text = gridView1.GetFocusedRowCellValue("grup_ad").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("grup_kod").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0) 
            {
                frmMain.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}
