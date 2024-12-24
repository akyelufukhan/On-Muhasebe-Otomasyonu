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
    public partial class frmAyar : Form
    {
        public frmAyar()
        {
            InitializeComponent();
        }

        private void chkYeni_CheckedChanged(object sender, EventArgs e)
        {
            txtSunucu.Enabled = !txtSunucu.Enabled;
            btnKaydet.Enabled = !btnKaydet.Enabled;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.cs_Sunucu = txtSunucu.Text.Trim() + "\\SQLEXPRESS" + ";";
            Properties.Settings.Default.cs_Veritabani = txtVeritabani.Text.Trim() + ";";
            Properties.Settings.Default.cs_UserID = txtUser.Text.Trim() + ";";
            Properties.Settings.Default.cs_Pass = txtPass.Text.Trim() + ";";
            Properties.Settings.Default.Database = txtVeritabani.Text.Trim();
            Properties.Settings.Default.Save();
            //Application.Restart();
            this.Close();
        }

        private void frmAyar_Load(object sender, EventArgs e)
        {
            labelControl2.Text = Properties.Settings.Default.cs1 + Properties.Settings.Default.cs_Sunucu + Properties.Settings.Default.cs2 + Properties.Settings.Default.cs_Veritabani + Properties.Settings.Default.cs3 + Properties.Settings.Default.cs_UserID + Properties.Settings.Default.cs4 + Properties.Settings.Default.cs_Pass + Properties.Settings.Default.cs5;
        }
    }
}
