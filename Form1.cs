using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedYellowGreen
{
    public partial class TrafficLights : Form
    {
        private Timer timerSwitch;
        private int timeCounter = 0;

        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLights();
            InitializeTimerSwitch();
        }

        private void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
            timerSwitch.Start();
        }

        private void TimerSwitch_Tick(object sender, EventArgs e)
        {
            if(timeCounter == 0)
            {
                RedLight.BackColor = Color.Red; //red on
            }
            else if(timeCounter == 3)
            {
                RedLight.BackColor = Color.Gray; //red off
                YellowLight.BackColor = Color.Yellow; //yellow on
            }
            else if (timeCounter == 6)
            {
                YellowLight.BackColor = Color.Gray; //yellow off
                GreenLight.BackColor = Color.Green; //green on
            }
            else if (timeCounter == 9)
            {
                GreenLight.BackColor = Color.Gray; //green off
                YellowLight.BackColor = Color.Yellow; //yellow on                
            }
            else if (timeCounter == 12)
            {
                YellowLight.BackColor = Color.Gray; //yellow off
                RedLight.BackColor = Color.Red; //red on
                timeCounter = -1;
            }
            timeCounter++;
        }

        private void InitializeTrafficLights()
        {
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
        }
    }
}
