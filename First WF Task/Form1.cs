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
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += TimerForBaku;
        }

        private void BakuBtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.baku;
            BakuBtn.BackColor = Color.LimeGreen;
            LondonBtn.BackColor = Color.Gray;
            timer.Tick += TimerForBaku;
        }
        private void TimerForBaku(object sender, EventArgs e)
        {
            timeLbl.Text = $"Time in Baku: {DateTime.Now.ToLongTimeString()}";
        }
        private void LondonBtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.london;
            LondonBtn.BackColor = Color.LimeGreen;
            BakuBtn.BackColor = Color.Gray;
            timer.Tick += TimerForLondon;
        }

        private void TimerForLondon(object sender, EventArgs e)
        {
            DateTime TimeLondon = new DateTime();
            TimeLondon = DateTime.Now.AddHours(-4);
            timeLbl.Text = $"Time in London: {TimeLondon.ToLongTimeString()}";
        }

 
    }
}
