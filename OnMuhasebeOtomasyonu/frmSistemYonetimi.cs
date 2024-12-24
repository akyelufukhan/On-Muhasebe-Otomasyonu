using Guna.UI2.WinForms;
using OnMuhasebeOtomasyonu.Fonksiyonlar;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OnMuhasebeOtomasyonu
{
    public partial class frmSistemYonetimi : Form
    {
        public frmSistemYonetimi()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Ayarlar.Baglanti);
        CurrencyManager cm;  // Kullanıcılar için CurrencyManager
        CurrencyManager acm; // Çalışanlar için CurrencyManager

        private void frmSistemYonetimi_Load(object sender, EventArgs e)
        {
            kullaniciData();
            calisanData();
        }

        // Kullanıcı Verileri Yükleme
        public void kullaniciData()
        {
            FormatDataGridView(dataKullanici);

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT UserId, Username, FullName, Email FROM Users", conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "tblkullanici");
                dataKullanici.DataSource = ds.Tables["tblkullanici"];
                cm = (CurrencyManager)BindingContext[ds.Tables["tblkullanici"]];
            }

            dataKullanici.Columns["UserId"].HeaderText = "ID";
            dataKullanici.Columns["Username"].HeaderText = "Kullanıcı Adı";
            dataKullanici.Columns["FullName"].HeaderText = "Ad Soyad";
            dataKullanici.Columns["Email"].HeaderText = "E-Posta Adresi";

            dataKullanici.Columns["UserId"].Width = 46;
            dataKullanici.Columns["Username"].Width = 150;
            dataKullanici.Columns["FullName"].Width = 200;
            dataKullanici.Columns["Email"].Width = 284;

            cm.Position = 0;
            UpdateCountLabel(cm, gunaCountLabel);
        }

        // Çalışan Verileri Yükleme
        public void calisanData()
        {
            FormatDataGridView(dataCalisan);

            SqlDataAdapter da = new SqlDataAdapter("SELECT calisan_id, calisan_adi FROM tblCalisan", conn);
            
                DataSet ds = new DataSet();
                da.Fill(ds, "tblcalisan");
                dataCalisan.DataSource = ds.Tables["tblcalisan"];
                acm = (CurrencyManager)BindingContext[ds.Tables["tblcalisan"]];
            

            dataCalisan.Columns["calisan_id"].HeaderText = "ID";
            dataCalisan.Columns["calisan_adi"].HeaderText = "Plasiyer Adı";

            dataCalisan.Columns["calisan_id"].Width = 50;
            dataCalisan.Columns["calisan_adi"].Width = 630;

            acm.Position = 0;
            UpdateCountLabel(acm, gunaPlaLabel);
        }

        // DataGridView Formatlama
        private void FormatDataGridView(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 30;
            dgv.DefaultCellStyle.Font = new Font("Century Gothic", 13, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 13, FontStyle.Bold);
        }

        // Sayfa Sayısını Güncelleme
        private void UpdateCountLabel(CurrencyManager manager, Guna2HtmlLabel label)
        {
            label.Text = (manager.Position + 1) + " / " + manager.Count;
        }

        // Kullanıcılar İçin Navigasyon İşlemleri
        private void gunaEnSol_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
            UpdateCountLabel(cm, gunaCountLabel);
        }

        private void gunaSol_Click(object sender, EventArgs e)
        {
            cm.Position = Math.Max(0, cm.Position - 1);
            UpdateCountLabel(cm, gunaCountLabel);
        }

        private void gunaSag_Click(object sender, EventArgs e)
        {
            cm.Position = Math.Min(cm.Count - 1, cm.Position + 1);
            UpdateCountLabel(cm, gunaCountLabel);
        }

        private void gunaEnSag_Click(object sender, EventArgs e)
        {
            cm.Position = cm.Count - 1;
            UpdateCountLabel(cm, gunaCountLabel);
        }

        // Çalışanlar İçin Navigasyon İşlemleri
        private void gunaCalisanEnSol_Click(object sender, EventArgs e)
        {
            acm.Position = 0;
            UpdateCountLabel(acm, gunaPlaLabel);
        }

        private void gunaCalisanSol_Click(object sender, EventArgs e)
        {
            acm.Position--;
            UpdateCountLabel(acm, gunaPlaLabel);
        }

        private void gunaCalisanSag_Click(object sender, EventArgs e)
        {
            acm.Position++;
            UpdateCountLabel(acm, gunaPlaLabel);
        }

        private void gunaCalisanEnSag_Click(object sender, EventArgs e)
        {
            acm.Position = acm.Count;
            UpdateCountLabel(acm, gunaPlaLabel);
        }

        private void gunaEkleBtn_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frmKullaniciEkle = new frmKullaniciEkle();
            frmKullaniciEkle.Show();
            this.Hide();
        }

        private void gunaDuzenleBtn_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataKullanici.SelectedRows[0].Cells[0].Value);
            frmKullaniciDuzenle frmKullaniciDuzenle = new frmKullaniciDuzenle(selectedID);
            frmKullaniciDuzenle.Show();
            this.Hide();
        }

        private void gunaSilBtn_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataKullanici.SelectedRows[0].Cells[0].Value);
            string query = "DELETE FROM Users WHERE UserId = @id";
            try
            {
                conn.Open();
                SqlCommand komut = new SqlCommand(query, conn);
                komut.Parameters.AddWithValue("@id", selectedID);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kullanıcı Başarıyla Silinmiştir!");

                kullaniciData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata"  + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain(1);
            main.Show();
            this.Close();
        }
    }
}
