﻿using System;
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
    public partial class Form3 : Form
    {
        Form2 frm;
        public Form3(Form2 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnBaslik_Click(object sender, EventArgs e)
        {
            frm.Text = txtBaslik.Text;
        }
    }
}
