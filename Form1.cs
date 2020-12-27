using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = 1;
            int sayi = Convert.ToInt32(textBox1.Text);
            for(int i = 1; i <= sayi; i++)
            {
                f = f * i;
            }
            label1.Text = "Faktöriyeli: " + f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
