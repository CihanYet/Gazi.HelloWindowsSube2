using Oyun.Model;
using System;
using System.Windows.Forms;

namespace Gazi.HelloWindowsSube2
{
    public enum Seviye
    {
        Kolay,
        Orta,
        Zor
    }
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Seviye level;

            if (rdKolay.Checked)
            {
                level = Seviye.Kolay;
            }
            else if (rdOrta.Checked)
            {
                level = Seviye.Orta;
            }
            else
            {
                level = Seviye.Zor;
            }
            var frm = new frmOyun(new User { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Sehir = txtSehir.Text.Trim() }, level);
            frm.Show();
        }
    }
}
