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
    public partial class frmFaturaListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public bool Secimm = false;
        public frmFaturaListesi(bool Secim)
        {
            InitializeComponent();
            Secimm = Secim;
        }

        private void frmFaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.VW_FATURALISTESI
                      select s;
            Liste.DataSource = lst;
        }

        private void txtFaturaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            int ID = int.Parse(GridControl.GetFocusedRowCellValue("ID").ToString());
            if (ID > 0)
            {
                Formlar.SatisFatura(true, ID, false);
            }
        }

        private void sagtikyenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Formlar.SatisFatura();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
