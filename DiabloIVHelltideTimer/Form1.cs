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
        bool helltideEventRunning = false;
        public Form1()
        {
            InitializeComponent();
            tmrClock.Start();
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTimeDisplay.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
