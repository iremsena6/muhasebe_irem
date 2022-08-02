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

namespace muhasebe_irem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=LENOVO-IREMS;Initial Catalog=muhasebe;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(constring);
        string password;
        public static string yetki, kullanici_adi;

       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kullanici_adi = comboBox1.Text;
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();


        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_ekle k = new kullanici_ekle();
            k.Show();
        }
    }
}