using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoPiano
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnManuel_Click(object sender, EventArgs e)
        {
            Form4 formkapa = new Form4();
            formkapa.Close();
            Form1 formac = new Form1();
            formac.Show();
            this.Hide();
        }

        private void btnAutoPlay_Click(object sender, EventArgs e)
        {
            Form4 formkapa = new Form4();
            formkapa.Close();
            Form2 formac = new Form2();
            formac.Show();
            this.Hide();
        }
    }
}
