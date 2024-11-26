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
    public partial class Form1 : Form
    {
        public Form1()
        {
            var btn = new Button();
            btn.Text = "Bizim buton";
            btn.Name = "btn";
            btn.Size = new Size(100, 50);
            btn.Location = new Point(100, 50);
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(txtSayi1.Text) + int.Parse(txtSayi2.Text)).ToString());
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtHelloWindows.Text);
        }

    }
}
