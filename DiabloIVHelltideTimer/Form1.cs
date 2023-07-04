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
        int helltideSecondTimer = 4500;
        bool helltideEventRunning = false;
        public Form1()
        {
            InitializeComponent();
            tmrClock.Start();
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTimeDisplay.Text = DateTime.Now.ToLongTimeString();
            lblCountdownDisplay.Text = timeFormat(helltideSecondTimer);
            helltideSecondTimer--;
            
        }

        private string timeFormat(int helltideSecVar)
        {
            double helltideHour = Math.Floor(helltideSecVar / 3600.0);
            double helltideMinute = Math.Floor(helltideSecVar / 60.0) % 60;
            double helltideSeconds = helltideSecVar % 60;
            string helltideFormattedTime = helltideHour.ToString("00") + ":" + helltideMinute.ToString("00") + ":" + helltideSeconds.ToString("00");

            return helltideFormattedTime;

        }

    }
}
