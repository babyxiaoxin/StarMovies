﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Down : Form
    {
        public Down()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GLYUI gLYUI = new GLYUI();
            gLYUI.Show();
            this.Close();

        }
    }
}
