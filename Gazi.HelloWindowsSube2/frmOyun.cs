using Oyun.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gazi.HelloWindowsSube2
{
    public partial class frmOyun : Form
    {
        int skor = 0, sure = 3, maxskor = 0;
        bool basla = true;
        Seviye seviye;
        Random rnd = new Random();
        public frmOyun(User usr, Seviye seviye)
        {
            InitializeComponent();
            this.seviye = seviye;
            SeviyeIslemleri();
            lblKullanici.Text = $"{usr.Ad} {usr.Soyad} {usr.Sehir}";
            lblSure.Text = sure.ToString();
            btnOyun.Location = new Point(rnd.Next(this.ClientSize.Width - btnOyun.Width - pnlGosterge.Width), rnd.Next(this.ClientSize.Height - btnOyun.Height));
        }
      
        void SeviyeIslemleri()
        {
            switch (seviye)
            {
                case Seviye.Kolay:
                    sure = 15;
                    this.Size = new Size(300, 300);
                    break;
                case Seviye.Orta:
                    sure = 10;
                    this.Size = new Size(500, 500);
                    break;
                case Seviye.Zor:
                    sure = 5;
                    this.Size = new Size(700, 700);
                    break;               
            }
        }

        private void btnOyun_MouseMove(object sender, MouseEventArgs e)
        {
            if (basla)
            {
                tmrSure.Start();
                basla = false;
            }

            skor++;
            lblSkor.Text = skor.ToString();
            btnOyun.Location = new Point(rnd.Next(this.ClientSize.Width - btnOyun.Width - pnlGosterge.Width), rnd.Next(this.ClientSize.Height - btnOyun.Height));
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            //pnlGosterge.Location = new Point(this.ClientSize.Width - pnlGosterge.Width, 0);
            //pnlGosterge.Height = this.ClientSize.Height;
        }

        private void btnOyun_MouseHover(object sender, EventArgs e)
        {

        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                tmrSure.Stop();
                btnOyun.Enabled = false;
                if (skor > maxskor)
                {
                    maxskor = skor;
                }
                DialogResult cvp = MessageBox.Show($"Oyun Bitti. Skorunuz:{skor}\nYeniden başlamak ister misiniz?", "Oyun Bitti", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    Basla();
                }
                else
                {
                    MessageBox.Show($"Oyun Bitti. Aldığınız en yüksek puan:{maxskor}");
                }
            }
        }

        void Basla()
        {
            SeviyeIslemleri();
            btnOyun.Enabled = true;
            skor = 0;
            basla = true;
            lblSure.Text = sure.ToString();
            lblSkor.Text = skor.ToString();
        }
    }
}
