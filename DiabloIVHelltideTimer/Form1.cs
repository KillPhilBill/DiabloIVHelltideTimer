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
        static readonly System.DateTime HELLTIDEINITIALDATETIME = new System.DateTime(2023, 7, 19, 22, 0, 0);
        int helltideSecondTimer = 4500;
        bool helltideEventRunning = false;
        public Form1()
        {
            InitializeComponent();
            tmrClock.Start();
            Console.WriteLine(HELLTIDEINITIALDATETIME.ToString());
            timeCatchUp();
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

        private void timeCatchUp()
        {
            DateTime curDate = DateTime.Now;
            TimeSpan deltaInitDateCurDate = curDate - HELLTIDEINITIALDATETIME;
            int roundDeltaInitDateCurDate = Convert.ToInt32(deltaInitDateCurDate.TotalSeconds);
            int remainMilSecVal = roundDeltaInitDateCurDate % 8100;
            Console.WriteLine(remainMilSecVal);
            if (remainMilSecVal > 4500)
            {
                helltideEventRunning = true;
                helltideSecondTimer = 8098 - remainMilSecVal;
            }
            else if(remainMilSecVal <= 4500)
            {
                helltideEventRunning = false;
                helltideSecondTimer = 4498 - remainMilSecVal;
            }
        }

        

    }
}
