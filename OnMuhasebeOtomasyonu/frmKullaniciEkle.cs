using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnMuhasebeOtomasyonu
{
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-43F3JRK\\sqlexpress;Initial Catalog=OnMuhasebe;Integrated Security=True;TrustServerCertificate=True");

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {

        }

        public void kullaniciEkle()
        {
            string kullanici_adi = gunaUsername.Text;
            string sifre = gunaSifre.Text;  
            string ad_soyad = gunaName.Text;
            string email = gunaMail.Text;

            string query = "INSERT INTO Users (Username, Password, FullName, Email) VALUES (@username, @password, @fullname, @email)";

            try
            {
                conn.Open();
                SqlCommand komut = new SqlCommand(query, conn);
                komut.Parameters.AddWithValue("@username", kullanici_adi);
                komut.Parameters.AddWithValue("@password", sifre);
                komut.Parameters.AddWithValue("@fullname", ad_soyad);
                komut.Parameters.AddWithValue("@email", email);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kullanıcı başarıyla eklendi!");

                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hata: " + ex);
            }
        }

        private void gunaVazgec_Click(object sender, EventArgs e)
        {
            frmSistemYonetimi frmSistem = new frmSistemYonetimi();
            frmSistem.Show();
            this.Close();
        }

        private void gunaKaydet_Click(object sender, EventArgs e)
        {
            kullaniciEkle();
            frmSistemYonetimi frmSistem = new frmSistemYonetimi();  
            frmSistem.Show();
            this.Close();
        }
    }
}
