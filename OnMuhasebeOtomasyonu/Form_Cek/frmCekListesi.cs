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

namespace OnMuhasebeOtomasyonu.Form_Cek
{
    public partial class frmCekListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();  

        int SecilenID = -1;
        public bool Secim = false;
        public frmCekListesi()
        {
            InitializeComponent();
        }

        private void frmCekListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.tblCekler
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecilenID = int.Parse(GridControl.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecilenID > 0)
            {
                frmMain.Aktarma = SecilenID;
                this.Close();
            }
        }
    }
}
