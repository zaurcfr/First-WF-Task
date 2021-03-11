using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_WF_Task
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            button1.Location = new Point(random.Next(0, 900), random.Next(0, 500));
            button1.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }
    }
}
