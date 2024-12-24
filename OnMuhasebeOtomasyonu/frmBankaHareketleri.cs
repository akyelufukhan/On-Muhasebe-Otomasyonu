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
    public partial class frmBankaHareketleri : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int BankaID = -1;
        int IslemID = -1;

        public frmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void frmBankaHareketleri_Load(object sender, EventArgs e)
        {

        }

        public void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.VW_BANKALISTESI Banka = DB.VW_BANKALISTESI.First(s => s.ID == BankaID);
                txtHesapAdi.Text = Banka.hesap_adi;
                txtHesapNo.Text = Banka.hesap_no;
                txtGiris.Text = Banka.giris.Value.ToString();
                txtCikis.Text = Banka.cikis.Value.ToString();   
                txtBakiye.Text = Banka.bakiye.Value.ToString();
                Listele();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Listele()
        {
            var lst = from s in DB.VW_BANKAHAREKETLERI
                      where s.banka_id == BankaID
                      select s;
            gridControl1.DataSource = lst;
        }

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            frmMain.Aktarma = -1;
        }
    }
}
