using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.HelloWindowsSube2
{
    public partial class frmParametre : Form
    {
        int toplam = 0;
        public frmParametre()
        {
            InitializeComponent();
        }

        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //MessageBox.Show(btn.Text);
            toplam += int.Parse(btn.Text);
        }

        private void frmParametre_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X:{e.X} Y:{e.Y}";
        }

        private void frmParametre_Load(object sender, EventArgs e)
        {
            var rnd = new Random();
            //button1.Text = rnd.Next(0, 100).ToString();
            //button2.Text = rnd.Next(0, 100).ToString();
            //button3.Text = rnd.Next(0, 100).ToString();

            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Tag != null && item.Tag.ToString() == "1")
                {
                    item.Text = rnd.Next(100).ToString();
                }
            }
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"İşlemin Sonucu:{toplam}");
        }
    }
}
