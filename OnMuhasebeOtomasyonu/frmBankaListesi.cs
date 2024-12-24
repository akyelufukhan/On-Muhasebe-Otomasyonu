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
    public partial class frmBankaListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public bool Secim = false;
        int SecimID = -1;

        public frmBankaListesi()
        {
            InitializeComponent();
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in db.VW_BANKALISTESI
                      select s;
            Liste.DataSource = lst;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
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
                throw;
            }
        }

        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                frmMain.Aktarma = SecimID;
                this.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Formlar.BankaKarti();
        }
    }
}
