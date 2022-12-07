using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(ShowDateTime);
            tmr.Enabled = true;
        }

        private void ShowDateTime(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm");
            label2.Text = DateTime.Now.ToString("D");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTimer();
            ShowDateTime( sender,  e);
        }
    }
}
