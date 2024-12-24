﻿using OnMuhasebeOtomasyonu.Fonksiyonlar;
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
    public partial class frmKasaListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public bool Secim = false;
        int SecimID = -1;
        public frmKasaListesi()
        {
            InitializeComponent();
        }

        private void frmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.VW_KASALISTESI
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
            Formlar.KasaKarti();
        }
    }
}
