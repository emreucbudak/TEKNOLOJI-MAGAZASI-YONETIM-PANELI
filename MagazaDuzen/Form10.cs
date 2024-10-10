using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazaDuzen
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=emre\\MSSQLSERVER01;Initial Catalog=Technology;Integrated Security=True;Encrypt=False");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'technologyDataSet5.SuperAdminLogin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.superAdminLoginTableAdapter.Fill(this.technologyDataSet5.SuperAdminLogin);
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.superAdminLoginTableAdapter.Fill(this.technologyDataSet5.SuperAdminLogin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutekle = new SqlCommand("insert into SuperAdminLogin (Supername,Superkullanici,Supersifre) values (@k1,@k2,@k3)", conn);
            komutekle.Parameters.AddWithValue("@k1", textBox1.Text);
            komutekle.Parameters.AddWithValue("@k2", textBox2.Text);
            komutekle.Parameters.AddWithValue("@k3", textBox3.Text);
            komutekle.ExecuteNonQuery();
            conn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutupdate = new SqlCommand("update SuperAdminLogin set Supername = @t1, Superkullanici = @t2 , Supersifre = @t3 where Supername = @l1 and Superkullanici = @l2 and Supersifre = @l3", conn);
            komutupdate.Parameters.AddWithValue("@t1", textBox1.Text);
            komutupdate.Parameters.AddWithValue("@t2", textBox2.Text);
            komutupdate.Parameters.AddWithValue("@t3", textBox3.Text);
            komutupdate.Parameters.AddWithValue("@l1", label5.Text);
            komutupdate.Parameters.AddWithValue("@l2", label6.Text);
            komutupdate.Parameters.AddWithValue("@l3", label7.Text);
            komutupdate.ExecuteNonQuery();

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label5.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            label6.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            label7.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutsil = new SqlCommand("Delete from SuperAdminLogin where Supername = @k1", conn);
            komutsil.Parameters.AddWithValue("@k1", label5.Text);
            komutsil.ExecuteNonQuery();

            conn.Close();
        }
    }
}
