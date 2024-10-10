using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazaDuzen
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=emre\\MSSQLSERVER01;Initial Catalog=Technology;Integrated Security=True;Encrypt=False");
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'technologyDataSet1.PersonelDurum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelDurumTableAdapter1.Fill(this.technologyDataSet1.PersonelDurum);
            // TODO: Bu kod satırı 'technologyDataSet.PersonelDurum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutsil = new SqlCommand("Delete from PersonelDurum where Personelid = @a1",conn);
            komutsil.Parameters.AddWithValue("@a1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            conn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.personelDurumTableAdapter1.Fill(this.technologyDataSet1.PersonelDurum);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;


            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        bool a;
        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                a = true;
            }
            else if (radioButton2.Checked)
            {
                a = false;
            }
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into PersonelDurum (PersonelAd,PersonelSoyad,PersonelDurum,PersonelYetki) values (@p1,@p2,@p4,@p5)",conn);
            komut.Parameters.AddWithValue("@p1", textBox4.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", a);
            komut.Parameters.AddWithValue("@p5", textBox5.Text);
            komut.ExecuteNonQuery();

            conn.Close();
        }
        bool b;
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            conn.Open();
            SqlCommand komutupdate = new SqlCommand("Update PersonelDurum set PersonelAd = @k1,PersonelSoyad = @k2,PersonelDurum = @k4,PersonelYetki = @k5 where Personelid= @k6",conn);
            komutupdate.Parameters.AddWithValue("@k1", textBox4.Text);
            komutupdate.Parameters.AddWithValue("@k2", textBox3.Text);
            komutupdate.Parameters.AddWithValue("@k4", b);
            komutupdate.Parameters.AddWithValue("@k5", textBox5.Text);
            komutupdate.Parameters.AddWithValue("@k6", textBox1.Text);
            komutupdate.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frmm = new Form2();
            frmm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutbul = new SqlCommand("Select * from PersonelDurum where PersonelAd=@t1",conn);
            komutbul.Parameters.AddWithValue("@t1", textBox4.Text);
            komutbul.ExecuteNonQuery();
            conn.Close();
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
