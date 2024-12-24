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
    public partial class frmKasaHareketleri : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        int HareketID = -1;
        int EvrakID = -1;
        int KasaID = -1;
        string EvrakTuru;
        public frmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {

        }


        public void Ac(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaKodu.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).kasa_kodu;
                txtKasaAdi.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).kasa_adi;
                DurumGetir();
                Listele();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void DurumGetir()
        {
            Fonksiyonlar.VW_KASADURUM Kasa = DB.VW_KASADURUM.First(s => s.kasa_id == KasaID);   
            txtGiris.Text = Kasa.giris.Value.ToString();
            txtCikis.Text = Kasa.cikis.Value.ToString();
            txtBakiye.Text = Kasa.bakiye.Value.ToString();
        }

        void Listele()
        {
            var lst = from s in DB.VW_KASAHAREKETLERI
                      where s.kasa_id == KasaID
                      select s;
            gridControl1.DataSource = lst;
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                frmMain.Aktarma = -1;
            }
        }

        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                
                //EvrakID = int.Parse(gridView1.GetFocusedRowCellValue("evrak_id").ToString());
                
                EvrakTuru = gridView1.GetFocusedRowCellValue("evrak_turu").ToString();
            }
            catch (Exception)
            {
                HareketID = -1;
                EvrakID = -1;
                EvrakTuru = "";
            }
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (EvrakTuru == "Kasa Devir Kartı")
            {
                devirKartiDuzenle.Enabled = true;   
                tahsilatOdeme.Enabled = false;
            }
            else if(EvrakTuru == "Kasa Tahsilat" ||  EvrakTuru == "Kasa Ödeme")
            {
                devirKartiDuzenle.Enabled = false;
                tahsilatOdeme.Enabled = true;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            Sec();
        }

        private void devirKartiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.KasaDevir(true, HareketID);
        }

        private void tahsilatOdeme_Click(object sender, EventArgs e)
        {
            Formlar.KasaTahsilat(true, HareketID);
        }
    }
}
