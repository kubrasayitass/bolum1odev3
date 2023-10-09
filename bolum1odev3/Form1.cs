using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum1odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kullanici_adi;
            kullanici_adi = textBox1.Text;
            if (kullanici_adi == "milliegitim@meb.k12.tr")
            {
            MessageBox.Show("kullanıcı sisteme kayıtlıdır.");
            }
            else
            {
                MessageBox.Show("kullanıcı adınız yanlıştır.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
