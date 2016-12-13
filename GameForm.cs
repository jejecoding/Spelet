﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spelet123
{
    public partial class GameForm : Form
    {
        Player play = new Player();
        
        public GameForm()
        {
            InitializeComponent();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult exitGame = MessageBox.Show("Are you sure you want to exit to main menu? Saving is not possible at this time.", "Exit to main menu?", MessageBoxButtons.YesNo);
            if (exitGame == DialogResult.Yes)
            {
                Form_startMeny newForm = new Form_startMeny();
                newForm.Show();
                this.Hide();
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            DialogResult exitGame = MessageBox.Show("Are you sure you want to exit? Saving is not possible at this time.", "Exit game?", MessageBoxButtons.YesNo);
            if (exitGame == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SetDefaultValues()
        {
            statistics1.StatHealth = play.Health = 100;
            statistics1.StatWater = play.Water = 100;
            statistics1.StatSteps = play.Steps = 0;
        }

        private void btnStepTest_Click(object sender, EventArgs e)
        {
            statistics1.StatSteps = play.StepTaken();
            if (statistics1.StatWater > 0)
                statistics1.StatWater = play.Thirst();
            else
            {
                statistics1.StatHealth = play.DamageTaken();
                if (statistics1.StatHealth <= 0)
                {
                    MessageBox.Show("GameOver");
                    btnStepTest.Enabled = false;
                }
            }                        
        }

        private void statistics1_Load(object sender, EventArgs e)
        {

        }
    }
}
