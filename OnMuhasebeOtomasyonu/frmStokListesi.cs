using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Input;
using OnMuhasebeOtomasyonu.Fonksiyonlar;

namespace OnMuhasebeOtomasyonu
{
    public partial class frmStokListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public bool Secim = false;
        int SecimID = -1;
        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            var lst = from s in DB.TBL_STOKLAR
                      where s.urun_adi.Contains(txtStokAd.Text) && s.urun_kodu.Contains(txtStokKodu.Text)
                      orderby s.urun_adi ascending
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(GridControl.GetFocusedRowCellValue("ID").ToString());
            }

            catch (Exception)
            {
                SecimID = -1;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Formlar.StokKarti();
        }

        private void frmStokListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                
            }

            catch
            {

            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                frmMain.Aktarma = SecimID;
                this.Close();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtStokAd.Text = "";
            txtStokKodu.Text = "";
        }
    }
}