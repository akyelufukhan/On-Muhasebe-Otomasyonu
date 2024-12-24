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
    public partial class frmKullaniciDuzenle : Form
    {
        public frmKullaniciDuzenle(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }
        public int user_id;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-43F3JRK\\sqlexpress;Initial Catalog=OnMuhasebe;Integrated Security=True;TrustServerCertificate=True");

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
            gunaUserId.Text = user_id.ToString();
            kullaniciCek();
        }

        public void kullaniciCek()
        {
            string query = "SELECT Username, FullName, Email, Password FROM Users WHERE UserId = " + user_id;
            try
            {
                conn.Open();
                SqlCommand komut = new SqlCommand(query, conn);
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    gunaUsername.Text = reader["username"].ToString();
                    gunaName.Text = reader["fullname"].ToString();
                    gunaSifre.Text = reader["password"].ToString();
                    gunaMail.Text = reader["email"].ToString();
                }
                else
                {
                    MessageBox.Show("Kullanıcı yok");
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
        }

        public void kullaniciDuzenle()
        {
            string kullanici_adi = gunaUsername.Text;
            string sifre = gunaSifre.Text;  
            string ad_soyad = gunaName.Text;
            string email = gunaMail.Text;

            string query = "UPDATE Users SET Username = @username, Password = @password, FullName = @fullname, Email = @email WHERE UserId = @id";

            try
            {
                conn.Open();
                SqlCommand komut = new SqlCommand(query, conn);
                komut.Parameters.AddWithValue("@username", kullanici_adi);
                komut.Parameters.AddWithValue("@password", sifre);
                komut.Parameters.AddWithValue("@fullname", ad_soyad);
                komut.Parameters.AddWithValue("@email", email);
                komut.Parameters.AddWithValue("@id", user_id);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kullanıcı başarıyla güncellendi!");

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
            kullaniciDuzenle();
            frmSistemYonetimi frmSistem = new frmSistemYonetimi();  
            frmSistem.Show();
            this.Close();
        }
    }
}
