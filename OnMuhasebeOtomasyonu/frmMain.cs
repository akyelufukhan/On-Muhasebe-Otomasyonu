using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using OnMuhasebeOtomasyonu.Fonksiyonlar;
using OnMuhasebeOtomasyonu.Form_Cek;
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
    public partial class frmMain : Form
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public frmMain(int userId)
        {
            InitializeComponent();
            timer1.Start();
            this.user_id = userId;
        }
        public static int Aktarma = -1;
        public int user_id;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-43F3JRK\\sqlexpress;Initial Catalog=OnMuhasebe;Integrated Security=True;TrustServerCertificate=True");
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            saat_label.Text = dateTime.ToString("dd.MM.yy HH:mm:ss");
        }

        public void kullaniciCek(int userId)
        {
            try
            {
                conn.Open();
                string query = "SELECT FullName FROM Users WHERE UserId = " + userId;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    label1.Text = reader["FullName"].ToString();
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hata: " + ex);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            kullaniciCek(user_id);
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //Bir şey yapma kanka
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaStokBtn_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            gunaStokPanel.Visible = true;
        }

        private void gunaCariBtn_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            gunaCariPanel.Visible = true;
        }

        private void gunaBankaBtn_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            gunaBankaPanel.Visible = true;
        }

        private void gunaKasaBtn_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            gunaKasaPanel.Visible = true;
        }

        private void gunaFaturaBtn_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            gunaFaturaPanel.Visible = true;
        }

        private void gunaSistemBtn_Click(object sender, EventArgs e)
        {
            if (user_id == 1)
            {
                frmSistemYonetimi frmSistem = new frmSistemYonetimi();
                frmSistem.Show();
                this.Hide();    
            }
            else
            {
                MessageBox.Show("Yetkisiz erişim sistem yöneticisine başvurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region cek_islemleri
        private void gunaCekBtn_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;    
            gunaCekPanel.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            gunaCekPanel.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Formlar.KendiCekimiz();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Formlar.MusteriCeki();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Formlar.CariCekCikisi();
        }
        #endregion

        //Stok Listesi Buton
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Formlar.StokListesi();
        }

        //Stok Grupları Buton
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Formlar.StokGruplari();
        }

        //Stok Listesi Buton
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Formlar.StokKarti();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            gunaStokPanel.Visible = false;
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            gunaCariPanel.Visible = false;
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            Formlar.CariListesi();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            Formlar.CariKarti();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            Formlar.BankaKarti();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            Formlar.BankaHareketleri();
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            Formlar.BankaIslem();
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            gunaBankaPanel.Visible = false;
        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            gunaKasaPanel.Visible = false;
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            Formlar.KasaHareketleri();
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            Formlar.KasaDevir();
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            Formlar.KasaTahsilat();
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            Formlar.BankaListesi();
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            Formlar.FaturaListesi();
        }

        private void guna2Button30_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            gunaFaturaPanel.Visible = false;
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            Formlar.SatisFatura();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Formlar.CekListesi();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Formlar.StokHareketleri();
        }
    }
}
