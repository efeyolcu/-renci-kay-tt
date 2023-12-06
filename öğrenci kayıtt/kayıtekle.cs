using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrenci_kayıtt
{
    public partial class kayıtekle : Form
    {
        public kayıtekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad=textBox1.Text;
            string soyad=textBox2.Text;
            

            string num=textBox3.Text;
            int numara=int.Parse(num);

            label4.Text = "kayıt başarılı";


        }

        private void gor_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;


            string num = textBox3.Text;
            int numara = int.Parse(num);

            label4.Text = "kayıt görüntüleniyor";


            textBox4.Text=(ad+" " + soyad+" " + numara);



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
