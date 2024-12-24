using OnMuhasebeOtomasyonu.Fonksiyonlar;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnMuhasebeOtomasyonu
{
    public partial class frmGiris : Form
    {
        Fonksiyonlar.Ayarlar Ayarlar = new Fonksiyonlar.Ayarlar();
        public frmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre doğrulama
            string username = txtKullanici.Text;
            string password = txtSifre.Text;

            if (IsValidUser(username, password))
            {
                // Kullanıcı adı ile UserId'yi al
                int userId = GetUserIdByUsername(username);
                
                if (userId > 0) // Kullanıcı ID bulunduysa
                {
                    // Oturumu başlat ve SessionId'yi al
                    Guid sessionId = StartSession(userId);

                    // Ana formu göster ve giriş formunu gizle
                    frmMain frmMain = new frmMain(userId);
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            // Veritabanından kullanıcı adı ve şifre kontrolü yapılır
            using (var connection = new SqlConnection(Ayarlar.Baglanti))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int result = (int)command.ExecuteScalar();
                return result > 0;
            }
        }

        private int GetUserIdByUsername(string username)
        {
            int userId = -1;
            using (var connection = new SqlConnection(Ayarlar.Baglanti))
            {
                string query = "SELECT UserId FROM Users WHERE Username = @Username";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
            }
            return userId;
        }

        private Guid StartSession(int userId)
        {
            Guid sessionId = Guid.NewGuid();
            using (var connection = new SqlConnection(Ayarlar.Baglanti))
            {
                string query = "INSERT INTO Sessions (SessionId, UserId, StartTime, IsActive) VALUES (@SessionId, @UserId, @StartTime, 1)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SessionId", sessionId);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@StartTime", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
            }
            return sessionId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAyar frm = new frmAyar();
            frm.ShowDialog();
        }
    }
}
