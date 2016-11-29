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
            
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            DialogResult exitGame = MessageBox.Show("Are you sure you want to exit? Saving is not possible at this time.", "Exit game?", MessageBoxButtons.YesNo);
            if (exitGame == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
