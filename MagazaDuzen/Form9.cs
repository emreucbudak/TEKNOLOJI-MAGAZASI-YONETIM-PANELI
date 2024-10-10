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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'technologyDataSet4.Login' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.loginTableAdapter1.Fill(this.technologyDataSet4.Login);
            // TODO: Bu kod satırı 'technologyDataSet3.Login' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }

        SqlConnection conn = new SqlConnection("Data Source=emre\\MSSQLSERVER01;Initial Catalog=Technology;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.loginTableAdapter1.Fill(this.technologyDataSet4.Login);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutekle = new SqlCommand("insert into Login (Kullaniciadi,Sifre) values (@k1,@k2)",conn);
            komutekle.Parameters.AddWithValue("@k1", textBox1.Text);
            komutekle.Parameters.AddWithValue("@k2", textBox2.Text);
            komutekle.ExecuteNonQuery();
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutupdate = new SqlCommand("update Login set Kullaniciadi = @t1, Sifre = @t2 where Kullaniciadi = @l1 and Sifre = @l2",conn);
            komutupdate.Parameters.AddWithValue("@t1",textBox1.Text);
            komutupdate.Parameters.AddWithValue("@t2", textBox2.Text);
            komutupdate.Parameters.AddWithValue("@l1", label4.Text);
            komutupdate.Parameters.AddWithValue("@l2", label5.Text);
            komutupdate.ExecuteNonQuery();

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label4.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            label5.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Login where KullaniciAdi = @k1",conn);
            komutsil.Parameters.AddWithValue("@k1", label4.Text);
            komutsil.ExecuteNonQuery();

            conn.Close();
        }
    }
}
