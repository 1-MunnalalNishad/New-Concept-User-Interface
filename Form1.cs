using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movies1.Hide();
            tv1.Hide();
            music1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movies1.Show();
            movies1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tv1.Show();
            tv1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            music1.Show();
            music1.BringToFront();
        }
    }
}
