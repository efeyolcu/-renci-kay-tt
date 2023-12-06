using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace öğrenci_kayıtt
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2JR0BBO\\SQLEXPRESS; Initial Catalog=okulveritabani;  Integrated Security=TRUE"); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıadı = kadi.Text;
            connection.Open();
          
            if (kadi.Text == "efe" && sifre.Text=="1212")
            {
                kayıtekle ekle = new kayıtekle();
                ekle.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı girdiniz!!!");
                kadi.Clear();
                sifre.Clear();
                kadi.Focus();
            }
            SqlCommand command = new SqlCommand("Select *fromkayıt", connection);
            SqlDataReader reader = command.ExecuteReader();
        }
    }
}
