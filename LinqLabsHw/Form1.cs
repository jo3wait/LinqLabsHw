using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabsHw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHw1 hw1 = new FrmHw1();
            hw1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHw2 hw2 = new FrmHw2();
            hw2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmHw3 hw3 = new FrmHw3();
            hw3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmHw4 hw4 = new FrmHw4();
            hw4.Show();
        }
    }
}
