using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0,Width-button1.Width-25);
            int y = rnd.Next(0, Height-button1.Height-25);
            button1.Location = new Point(x,y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
