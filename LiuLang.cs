﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LiuLang : Form
    {
        public LiuLang()
        {
            InitializeComponent();
        }



        private void LiuLang_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dengluchengg dengluchengg = new Dengluchengg();
            dengluchengg.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LLDQGP lLDQGP = new LLDQGP();
            lLDQGP.Show();
            this.Close();
        }
    }
}
