using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlGameScreenLibrary
{
    public partial class Statistics : UserControl
    {
        int statHealth, statWater, statSteps;
        DateTime start;
        int StatFive;

        private void Statistics_Load(object sender, EventArgs e)
        {
            start = DateTime.Now;
            tmrPlaytime.Start();
        }

        private void tmrPlaytime_Tick(object sender, EventArgs e)
        {
            TimeSpan playTime = DateTime.Now - start;
            lblTime.Text = string.Format("Time Played: {0}:{1}", playTime.Minutes, playTime.Seconds);
        }

        public int StatHealth
        {
            get
            {
                return statHealth;
            }
            set
            {
                statHealth = value;
                lblHealth.Text = string.Format("Health: {0}", statHealth);
            }
        }

        public int StatWater
        {
            get
            {
                return statWater;
            }
            set
            {
                statWater = value;
                lblWater.Text = string.Format("Water: {0}", statWater);
            }
        }

        public int StatSteps
        {
            get
            {
                return statSteps;
            }
            set
            {
                statSteps = value;
                lblSteps.Text = string.Format("Steps: {0}", statSteps);
            }
        }

        

        public Statistics()
        {
            InitializeComponent();
        }
    }
}
