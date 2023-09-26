using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_türleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(texSayi.Text);
            int sonuc = sayi * sayi;
           
            lblSonuc.Text = sonuc.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
