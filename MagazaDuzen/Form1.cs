using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MagazaDuzen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=emre\\MSSQLSERVER01;Initial Catalog=Technology;Integrated Security=True;Encrypt=False");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand giris = new SqlCommand("Select * from Login where KullaniciAdi = @k1 and Sifre = @k2",conn);
            giris.Parameters.AddWithValue("@k1",textBox1.Text);
            giris.Parameters.AddWithValue("@k2", txtPass.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı adı veya şifre ", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;

            // Tam ekran için daha kesin ayarlama

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
