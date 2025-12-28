using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Automation;

namespace ProjektZaliczeniowy
{
    public partial class GameForm : Form
    {
        int countdown;
        private int score = 0;
        private int lives;
        private int currentInterval;
        private readonly bool isEndurance;

        public GameForm(int interval, int lives)
        {
            InitializeComponent();
            this.currentInterval = interval;
            this.lives = lives;

            this.isEndurance = (lives == 5);

            this.countdown = 3;
            countdownTimer.Start();

            lblTime.Visible = true;
            lblTime.Text = "Clicktime: " + (currentInterval / 1000.0).ToString() + "s";
            lblLives.Text = "Lives: " + lives.ToString();
        }

        private void MoveButton()
        {
            Random random = new Random();
            btnTarget.Left = random.Next(0, this.ClientSize.Width - btnTarget.Width);
            btnTarget.Top = random.Next(0, this.ClientSize.Height - btnTarget.Height);
        }     

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                lblCountdown.Text = countdown.ToString();
                lblCountdown.ForeColor = Color.LawnGreen;
                countdown--;
            }
            else if (countdown == 0)
            {
                lblCountdown.Text = "START";
                lblCountdown.ForeColor = Color.Yellow;
                countdown--;
            }
            else
            {
                countdownTimer.Stop();
                lblCountdown.Visible = false;
                StartActualGame();
            }
        }
        private void StartActualGame()
        {
            // Ustawienia początkowe
            gameTimer.Interval = currentInterval;
            btnTarget.Visible = true;
            lblLives.Visible = true;
            lblScore.Visible = true;
            
            gameTimer.Start();
            MoveButton();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            lives--;
            lblLives.Text = "Lives: " + lives.ToString();

            if (lives == 0)
            {
                GameOver();
            }
            else
            {
                MoveButton();
            }
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "Score: " + score.ToString();

            if (isEndurance)
            {
                lblTime.Text = "Time to Click: " + (gameTimer.Interval / 1000.0).ToString() + "s";
                if (gameTimer.Interval > 300)
                    gameTimer.Interval -= 20;
            }

            gameTimer.Stop();
            MoveButton();
            gameTimer.Start();
        }
        private void GameOver()
        {
            gameTimer.Stop();
            btnTarget.Enabled = false;

            GameOverForm goForm = new GameOverForm(score);
            goForm.Location = this.Location;
            goForm.StartPosition = FormStartPosition.Manual;

            goForm.Show();
            this.Close();
        }
    }
}
