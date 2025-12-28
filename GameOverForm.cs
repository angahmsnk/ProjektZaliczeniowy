using System;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class GameOverForm : Form
    {
        public GameOverForm(int score)
        {
            InitializeComponent();

            lblEndgameScore.Text = score.ToString();
            lblEndgameScore.Location = new System.Drawing.Point(
                (this.ClientSize.Width - lblEndgameScore.Size.Width) / 2,
                lblEndgameScore.Location.Y
            );
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Location = this.Location;
            menuForm.StartPosition = FormStartPosition.Manual;
            menuForm.Show();
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
