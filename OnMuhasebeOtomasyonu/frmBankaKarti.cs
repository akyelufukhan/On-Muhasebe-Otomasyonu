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
    public partial class frmBankaKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        
        bool Edit = false;
        int SecimID = -1;
        public frmBankaKarti()
        {
            InitializeComponent();
        }

        private void frmBankaKarti_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Temizle()
        {
            txtAdres.Text = "";
            txtBankaAdi.Text = "";
            txtHesapNo.Text = "";
            txtIban.Text = "";
            txtTelefon.Text = "";
            txtHesapAdi.Text = "";
            txtSube.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_BANKALAR
                      select s;
            gridControl1.DataSource = lst;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = new Fonksiyonlar.TBL_BANKALAR();
                Banka.adres = txtAdres.Text;
                Banka.banka_adi = txtBankaAdi.Text;
                Banka.hesap_adi = txtHesapAdi.Text;
                Banka.hesap_no = txtHesapNo.Text;
                Banka.iban = txtIban.Text;
                Banka.sube = txtSube.Text;
                Banka.telefon = txtTelefon.Text;
                DB.TBL_BANKALAR.InsertOnSubmit(Banka);
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Oluşturuldu!");
                Temizle();
            }
            catch (Exception)
            {

            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALAR.First(s => s.ID == SecimID);
                Banka.adres = txtAdres.Text;
                Banka.banka_adi = txtBankaAdi.Text;
                Banka.hesap_adi = txtHesapAdi.Text;
                Banka.hesap_no = txtHesapNo.Text;
                Banka.iban = txtIban.Text;
                Banka.sube = txtSube.Text;
                Banka.telefon = txtTelefon.Text;
                DB.SubmitChanges();
                MessageBox.Show("Kayıt Güncellendi");
                Temizle();
            }
            catch (Exception)
            {

            }
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString()); 
                if(SecimID > 0)
                {
                    Ac();
                }
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
            }
        }

        void Ac()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALAR.First(s => s.ID == SecimID);
                txtAdres.Text = Banka.adres;
                txtBankaAdi.Text = Banka.banka_adi;
                txtHesapAdi.Text = Banka.hesap_adi;
                txtHesapNo.Text = Banka.hesap_no;
                txtIban.Text = Banka.iban;
                txtSube.Text = Banka.sube;  
                txtTelefon.Text = Banka.telefon;    
            }
            catch (Exception)
            {

            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0) Guncelle();
            else YeniKaydet();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}
