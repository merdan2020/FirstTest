using System;
using System.Windows.Forms;

namespace KareAlanHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double kenar;
            if (double.TryParse(txtKenar.Text, out kenar) && kenar > 0)
            {
                double alan = kenar * kenar;
                lblSonuc.Text = $"Alan: {alan}";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir pozitif sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKenar.Clear();
            lblSonuc.Text = "";
        }
    }
}
