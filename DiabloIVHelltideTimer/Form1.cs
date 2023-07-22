using System;
using System.Windows.Forms;

namespace DiabloIVHelltideTimer
{
    public partial class Form1 : Form
    {
        static readonly DateTime HELLTIDEINITIALDATETIME = new DateTime(2023, 7, 19, 22, 0, 0);
        static readonly int HELLTIDEACTIVETIMER = 3600; // Helltide active for 1 hour
        static readonly int HELLTIDEBREAKTIMER = 4500; // Helltide break time for 1 hour 15 minutes
        int helltideSecondTimer = 0; 
        bool helltideEventRunning = false; 
        public Form1()
        {
            InitializeComponent();
            tmrClock.Start();
            timeCatchUp();
        }
       
        private void currentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTimeDisplay.Text = DateTime.Now.ToLongTimeString();
            lblCountdownDisplay.Text = timeFormat(helltideSecondTimer);
            
            helltideSecondTimer--;
            if (helltideSecondTimer < 0)
            {
                if (helltideEventRunning)
                {
                    helltideEventRunning = false;
                    helltideSecondTimer = HELLTIDEBREAKTIMER;
                }
                else { helltideEventRunning = true; helltideSecondTimer = HELLTIDEACTIVETIMER; }
            }
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
            int remainMilSecVal = roundDeltaInitDateCurDate % (HELLTIDEBREAKTIMER + HELLTIDEACTIVETIMER);
            Console.WriteLine(remainMilSecVal);
            if (remainMilSecVal > HELLTIDEBREAKTIMER)
            {
                helltideEventRunning = true;
                helltideSecondTimer = (HELLTIDEBREAKTIMER + HELLTIDEACTIVETIMER - 2) - remainMilSecVal;
                
            }
            else 
            {
                helltideEventRunning = false;
                helltideSecondTimer = (HELLTIDEBREAKTIMER - 2) - remainMilSecVal;
                
            }
        }

        

    }
}
