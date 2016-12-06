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
    public partial class Form_startMeny : Form
    {
        public Form_startMeny()
        {
            InitializeComponent();
        }

        GameForm newForm = new GameForm();

        private void pBox_Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tack för att du har spelat");
            Application.Exit();
            
            //Stänger ner hela applicationen
        }

        private void Form_startMeny_Load(object sender, EventArgs e)
        {

            panel_difficulty.Visible = false;
            panel_difficulty.Hide(); //Vi Hidear difficulty menyn i början då start menyn ska visas först

        }

        private void pBox_Start_Click(object sender, EventArgs e)
        {

            panel_difficulty.Visible = true;

            panel_difficulty.Show();

        }

        private void pBox_Easy_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Hide();
        }

        private void pBox_Medium_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Hide();
        }

        private void pBox_Hard_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Hide();
        }

        private void pBox_Hardcore_Click(object sender, EventArgs e)
        {
            newForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_difficulty.Visible = false;
            panel_difficulty.Hide();
        }
    }
}
