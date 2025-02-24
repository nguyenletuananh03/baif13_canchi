using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baif13_canchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntn_Click(object sender, EventArgs e)
        {
            string[] canarr = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] chiarr = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mẹo", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            string giatritrave = canarr[Convert.ToInt32(txtnam.Text) % 10] + " " + chiarr[Convert.ToInt32(txtnam.Text) % 12];
            txtkq.Text = giatritrave;
            for (int nam = 2000; nam <= 2050; nam++)
            {
                lstnam.Items.Add(nam + " - " + canarr[nam % 10] + " " + chiarr[nam % 12]);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
