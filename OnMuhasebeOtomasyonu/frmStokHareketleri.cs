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
    public partial class frmStokHareketleri : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int StokID = -1;
        int IslemID = -1;
        public frmStokHareketleri()
        {
            InitializeComponent();
        }

        private void frmStokHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }


        void Listele()
        {
            var lst = from s in DB.VW_STOKHAREKETLERI
                      select s;
            gridControl1.DataSource = lst;
        }

    }
}
