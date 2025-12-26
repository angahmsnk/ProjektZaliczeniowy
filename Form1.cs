using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int lives = 3;
        bool isGameOver = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            isGameOver = false;
            lblScore.Text = "Score: " + score++;
            if(isGameOver == false)
            {
                lblLifes.Visible = true;
                gameTimer.Start();
            }
            gameTimer.Stop();
            gameTimer.Start();
            RandomPosition();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            lblLifes.Text = "Lives: " + --lives;
            if (lives == 0)
            {
                gameTimer.Stop();
                btnTarget.Enabled = false;
            }
        }

        private void RandomPosition()
        {
            Random random = new Random();
            btnTarget.Left = random.Next(0, this.ClientSize.Width - btnTarget.Width);
            btnTarget.Top = random.Next(0, this.ClientSize.Height - btnTarget.Height);
        }
    }
}
