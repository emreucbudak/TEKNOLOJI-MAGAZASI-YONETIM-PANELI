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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=emre\\MSSQLSERVER01;Initial Catalog=StokKontrol;Integrated Security=True;Encrypt=False");
        private void btn_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokKontrolDataSet4.ComputerInformation' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.computerInformationTableAdapter.Fill(this.stokKontrolDataSet4.ComputerInformation);
            pictureBox1.BorderStyle = BorderStyle.None;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.computerInformationTableAdapter.Fill(this.stokKontrolDataSet4.ComputerInformation);
        }

        bool a;
        private void btnekle_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a = true;
            }
            else if (radioButton2.Checked)
            {
                a = false;
            }
            else
            {
                MessageBox.Show("Hatalı Seçim Lütfen Stok Durumu Seçin", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Open();
            SqlCommand komutekle = new SqlCommand("insert into ComputerInformation (Devicename,Devicestock,Deviceprize,Deviceram,Devicememory,Devicescreen,Devicefrom) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7)", conn);
            komutekle.Parameters.AddWithValue("@k1", textBox2.Text);
            komutekle.Parameters.AddWithValue("@k2", a);
            komutekle.Parameters.AddWithValue("@k3", textBox3.Text);
            komutekle.Parameters.AddWithValue("@k4", textBox4.Text);
            komutekle.Parameters.AddWithValue("@k5", textBox6.Text);
            komutekle.Parameters.AddWithValue("@k6", textBox7.Text);
            komutekle.Parameters.AddWithValue("@k7", textBox5.Text);
            komutekle.ExecuteNonQuery();
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
            SqlCommand komutupdate = new SqlCommand("update ComputerInformation set Devicename = @a1, Devicestock= @a2, Deviceprize = @a3, Deviceram = @a4, Devicememory = @a5,Devicescreen = @a6,Devicefrom = @a7 where Deviceid = @a8", conn);
            komutupdate.Parameters.AddWithValue("@a1", textBox2.Text);
            komutupdate.Parameters.AddWithValue("@a2", b);
            komutupdate.Parameters.AddWithValue("@a3", textBox3.Text);
            komutupdate.Parameters.AddWithValue("@a4", textBox4.Text);
            komutupdate.Parameters.AddWithValue("@a5", textBox6.Text);
            komutupdate.Parameters.AddWithValue("@a6", textBox7.Text);
            komutupdate.Parameters.AddWithValue("@a7", textBox5.Text);
            komutupdate.Parameters.AddWithValue("@a8", textBox1.Text);
            komutupdate.ExecuteNonQuery();


            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            label10.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            if (label10.Text == "True")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komutsil = new SqlCommand("delete from ComputerInformation where Deviceid = @l1", conn);
            komutsil.Parameters.AddWithValue("@l1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            conn.Close();
        }
    }
}
