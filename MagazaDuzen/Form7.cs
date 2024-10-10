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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=emre\\MSSQLSERVER01;Initial Catalog=Technology;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutgir = new SqlCommand("Select * from SuperAdminLogin where Superkullanici = @k1 and Supersifre = @k2",conn);
            komutgir.Parameters.AddWithValue("@k1", textBox1.Text);
            komutgir.Parameters.AddWithValue("@k2", textBox2.Text);
            SqlDataReader reader = komutgir.ExecuteReader();
            if (reader.Read())
            {
                Form8 form8 = new Form8();
                form8.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
