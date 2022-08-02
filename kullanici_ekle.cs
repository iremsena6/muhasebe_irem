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
    public partial class kullanici_ekle : Form
    {
        public kullanici_ekle()
        {
            InitializeComponent();
        }
        public string rsmadi = "", rsmyolu, rsmadi1 = "", rsmyolu1;

        static string constring = "Data Source=LENOVO-IREMS;Initial Catalog=muhasebe;Integrated Security=True";
        SqlConnection baglanti= new SqlConnection(constring);
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                checkBox1.Text = "Şifreyi Gizle";
            }
            else
            {
                textBox2.PasswordChar = '*';
                checkBox1.Text = "Şifreyi Göster";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand EKLE = new SqlCommand("insert into LOGİN(kullanici_adi,kullanici_psw,kullanici_yetki,kullanici_rsm) values (@ad, @psw,@yetki,@rsm)", baglanti);
                baglanti.Open();
                EKLE.Parameters.AddWithValue("@ad", textBox1.Text);
                EKLE.Parameters.AddWithValue("@psw", textBox2.Text);
                EKLE.Parameters.AddWithValue("@yetki", textBox3.Text);
                EKLE.Parameters.AddWithValue("@rsm", comboBox1.Text);


                EKLE.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KULLANICI OLUŞTURULDU");
                this.Hide();
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA = " + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya1 = new OpenFileDialog();
            dosya1.Filter = "Resim Dosyası |*.jpg;*.nef;*.png; |  Tüm Dosyalar |*.*";
            if (dosya1.ShowDialog() == DialogResult.OK)
            {
                rsmyolu1 = dosya1.FileName;
                pictureBox1.ImageLocation = rsmyolu1;
            }
            else
            {
                rsmyolu1 = Application.StartupPath + "\\resim\\noimg.jpg";
                pictureBox1.ImageLocation = rsmyolu1;
                MessageBox.Show("Resim seçilmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
