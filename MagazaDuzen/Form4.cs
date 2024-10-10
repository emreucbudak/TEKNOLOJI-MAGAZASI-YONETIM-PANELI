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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmn = new Form2();
            frmn.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokKontrolDataSet.DeviceInformation' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.deviceInformationTableAdapter.Fill(this.stokKontrolDataSet.DeviceInformation);
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.deviceInformationTableAdapter.Fill(this.stokKontrolDataSet.DeviceInformation);
        }
    }
}
