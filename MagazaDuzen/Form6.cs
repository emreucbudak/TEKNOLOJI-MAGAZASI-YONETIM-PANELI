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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokKontrolDataSet2.ComputerInformation' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.computerInformationTableAdapter.Fill(this.stokKontrolDataSet2.ComputerInformation);
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}
