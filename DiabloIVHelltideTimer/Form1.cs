using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiabloIVHelltideTimer
{
    public partial class Form1 : Form
    {
        int helltideHour = 1;
        int helltideOffMinute = 15;
        int sixtySecondTimer = 00;
        bool helltideEventRunning = false;
        public Form1()
        {
            InitializeComponent();
            tmrClock.Start();
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTimeDisplay.Text = DateTime.Now.ToLongTimeString();
            lblCountdownDisplay.Text = "00:00:" + sixtySecondTimer.ToString("D2");
        }

    }
}
