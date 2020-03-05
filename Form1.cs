using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSR_Project
{
    public partial class RPS_GAME : Form
    {
        Random generator = new Random();
        public RPS_GAME()
        {
            InitializeComponent();
            
        }

        private void RadRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.rock;
        }

        private void RadPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
        }

        private void RadScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.scissors_cartoon;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            int comChoice = generator.Next(1, 4); //1=rock 2=paper 3=scissors

            if (comChoice == 1)
            {
                imgOpponent.Image = Properties.Resources.rock;
            }
            else if (comChoice == 2)
            {
                imgOpponent.Image = Properties.Resources.paper;
            }
            else if (comChoice == 3)
            {
                imgOpponent.Image = Properties.Resources.scissors_cartoon;
            }

        }
