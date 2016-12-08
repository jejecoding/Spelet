using System;
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

        public GameForm()
        {
            InitializeComponent();
        }
        public void DifficultyCheck(Enum_Difficulty saken)
        {
            switch(saken)
            {
                case Enum_Difficulty.Easy:
                    GameForm.ActiveForm.Text += " - Easy";
                    break;
                case Enum_Difficulty.Medium:
                    GameForm.ActiveForm.Text += " - Medium";
                    break;
                case Enum_Difficulty.Hard:
                    GameForm.ActiveForm.Text += " - Hard";
                    break;
                case Enum_Difficulty.Hardcore:
                    GameForm.ActiveForm.Text += " - Hardcore";
                    break;
                default:
                    GameForm.ActiveForm.Text += " - fel";
                    break;
            }
            
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
            statistics1.StatHealth = 100;
            statistics1.StatWater = 100;
            statistics1.StatSteps = 0;

            description1.DescriptionText = "Helo and welkome to de gaem. press de buton in midle to play or smthng! xD";
        }

        private void btnStepTest_Click(object sender, EventArgs e)
        {
            statistics1.StatSteps++;
            if (statistics1.StatWater > 0)
                statistics1.StatWater = statistics1.StatWater - 5;
            else
            {
                statistics1.StatHealth = statistics1.StatHealth - 5;
                if (statistics1.StatHealth <= 0)
                {
                    MessageBox.Show("GameOver");
                    btnStepTest.Enabled = false;
                }
            }

            description1.DescriptionText = "Det funkar";                       
        }
    }
}
