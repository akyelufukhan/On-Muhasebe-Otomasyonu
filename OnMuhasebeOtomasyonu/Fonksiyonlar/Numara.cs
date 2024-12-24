using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebeOtomasyonu.Fonksiyonlar
{
    class Numara
    {
        DatabaseDataContext DB = new DatabaseDataContext();

        public string StokKodNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.TBL_STOKLAR
                                        orderby s.ID descending
                                        select s).First().urun_kodu);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch
            {
                return "0000001";
            }
        }

        public string StokGrupKodNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.TBL_STOKGRUPLARI
                                        orderby s.ID descending
                                        select s).First().grup_kod);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch
            {
                return "0000001";
            }
        }

        public string CariKodNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.TBL_CARILER
                                        orderby s.ID descending
                                        select s).First().cari_kod);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }

            catch
            {
                return "0000001";
            }
        }

        public string CariGrupKodNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.TBL_CARIGRUPLARI
                                        orderby s.ID descending
                                        select s).First().grup_kodu);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch
            {
                return "0000001";
            }
        }

        public string KasaKodNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.TBL_KASALAR
                                        orderby s.ID descending
                                        select s).First().kasa_kodu);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch
            {
                return "0000001";
            }
        }

        public string FaturaNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.TBL_FATURALAR
                                        orderby s.ID descending
                                        select s).First().FATURANO);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch
            {
                return "0000001";
            }
        }

        public string IrsaliyeNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.TBL_IRSALIYELER
                                        orderby s.ID descending
                                        select s).First().IRSALIYENO);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch
            {
                return "0000001";
            }
        }
    }
}
