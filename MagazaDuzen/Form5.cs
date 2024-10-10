using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazaDuzen
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokKontrolDataSet1.WhiteInformation' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.whiteInformationTableAdapter.Fill(this.stokKontrolDataSet1.WhiteInformation);
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
