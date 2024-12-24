using DevExpress.Office.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebeOtomasyonu.Fonksiyonlar
{
    class Formlar
    {
        #region Stok İslemleri
        public int StokListesi(bool Secim = false)
        {
            frmStokListesi frm = new frmStokListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.Show();
            }
            return frmMain.Aktarma;
        }

        public int StokGruplari(bool Secim = false)
        {
            frmStokGruplari frm = new frmStokGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();


            return frmMain.Aktarma;
        }

        public void StokHareketleri()
        {
            frmStokHareketleri frm = new frmStokHareketleri();
            frm.ShowDialog();
        }

        public void StokKarti(bool Ac = false)
        {
            frmStokKarti frm = new frmStokKarti();
            frm.ShowDialog();
        }
        #endregion

        #region Cari İslem
        public int CariListesi(bool Secim = false)
        {
            frmCariListesi frm = new frmCariListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.Show();
            }
            return frmMain.Aktarma;
        }

        public int CariGruplari(bool Secim = false)
        {
            frmCariGruplari frm = new frmCariGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();

            return frmMain.Aktarma;
        }

        public void CariKarti(bool Ac = false, int CariID = -1)
        {
            frmCariKarti frm = new frmCariKarti();
            if (Ac) frm.Ac(CariID);
            frm.ShowDialog();
        }

        public void CariHareketleri(bool Ac = false)
        {

        } 
        #endregion

        public void BankaKarti()
        {
            frmBankaKarti frm = new frmBankaKarti();
            frm.ShowDialog();
        }

        public void BankaHareketleri(bool Ac = false, int ID = -1)
        {
            frmBankaHareketleri frm = new frmBankaHareketleri();
            if (Ac) frm.BankaAc(ID);
            frm.ShowDialog();
        }

        public void BankaIslem(bool Ac = false, int ID = -1)
        {
            frmBankaIslem frm = new frmBankaIslem();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public int BankaListesi(bool Secim = false)
        {
            frmBankaListesi frm = new frmBankaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
            return frmMain.Aktarma;
        }

        public void KasaKarti()
        {
            frmKasaAcilisKarti frm = new frmKasaAcilisKarti();
            frm.ShowDialog();
        }

        public int KasaListesi(bool Secim = false)
        {
            frmKasaListesi frm = new frmKasaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.Show();
            }
            return frmMain.Aktarma;
        }

        public void KasaTahsilat(bool Ac = false, int ID = -1)
        {
            frmKasaTahsilat frm = new frmKasaTahsilat();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public int FaturaListesi(bool Secim = false)
        {
            frmFaturaListesi frm = new frmFaturaListesi(Secim);
            if (Secim)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.Show();
            }
            return frmMain.Aktarma;
        }

        public int IrsaliyeListesi(bool Secim = false)
        {
            //frmFaturaListesi frm = new frmFaturaListesi();
            //if (Secim)
            //{
            //    frm.Secim = Secim;
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    frm.Show();
            //}
            return frmMain.Aktarma;
        }

        public void SatisFatura(bool Ac = false, int ID = -1, bool Irsaliye = false)
        {
            frmFaturaSatis frm = new frmFaturaSatis(Ac, ID, Irsaliye);
            frm.Show();
        }

        public void KasaDevir(bool Ac = false, int IslemID = -1)
        {
            frmKasaDevirIslem frm = new frmKasaDevirIslem();
            if (Ac) frm.Ac(IslemID);
            frm.ShowDialog();
        }

        public void KasaHareketleri(bool Ac = false, int ID = -1)
        {
            frmKasaHareketleri frm = new frmKasaHareketleri();
            if(Ac) frm.Ac(ID);
            frm.Show();
        }

        public void KendiCekimiz(bool Ac = false, int ID = -1)
        {
            Form_Cek.frmKendiCekimiz frm = new Form_Cek.frmKendiCekimiz();
            //if (Ac) ;
            frm.ShowDialog();
        }

        public void MusteriCeki(bool Ac = false, int ID = -1)
        {
            Form_Cek.frmMusteriCeki frm = new Form_Cek.frmMusteriCeki();
            //if (Ac) ;
            frm.ShowDialog();
        }

        public void CariCekCikisi()
        {
            Form_Cek.frmCariyeCekCikisi frm = new Form_Cek.frmCariyeCekCikisi();
            frm.ShowDialog();
        }

        public int CekListesi(bool Secim = false)
        {
            Form_Cek.frmCekListesi frm = new Form_Cek.frmCekListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.Show();
            }
            return frmMain.Aktarma;
        }
    }
}
