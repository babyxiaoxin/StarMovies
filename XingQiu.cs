using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class XingQiu : Form
    {
        public XingQiu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dengluchengg dengluchengg = new Dengluchengg();
            dengluchengg.Show();
            this.Close();
        }
    }
}
