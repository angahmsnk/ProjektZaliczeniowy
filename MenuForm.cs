using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class MenuForm : Form
    {

        private bool title_growing = true;

        public MenuForm()
        {
            InitializeComponent();

            MenuCentralization();
            EasyRadioBtn.ForeColor = Color.GreenYellow;
        }

        private void title_pulse_Tick(object sender, EventArgs e)
        {
            if(title_growing)
            {
                lblTitle.Font = new Font(lblTitle.Font.FontFamily, lblTitle.Font.Size + 1);
                if (lblTitle.Font.Size >= 48)
                {
                    title_growing = false;
                }
            }
            else
            {
                lblTitle.Font = new Font(lblTitle.Font.FontFamily, lblTitle.Font.Size - 1);
                if (lblTitle.Font.Size <= 36)
                {
                    title_growing = true;
                }
            }     
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int clickTime = 1000;
            int livesLeft = 3;

            if(EasyRadioBtn.Checked)
            {
                clickTime = 1100;
                livesLeft = 3;
            }
            else if (MediumRadioBtn.Checked)
            {
                clickTime = 900;
                livesLeft = 3;
            }
            else if (HardRadioBtn.Checked)
            {
                clickTime = 700;
                livesLeft = 3;
            }
            else if (EnduranceRadioBtn.Checked)
            {
                clickTime = 1500;
                livesLeft = 5;
            }

            GameForm oknoGry = new GameForm(clickTime, livesLeft);
            oknoGry.StartPosition = FormStartPosition.Manual;
            oknoGry.Location = this.Location;
            oknoGry.Size = this.Size;
            oknoGry.Show();
            this.Hide();
        }

        

        private void MenuCentralization()
        {
            lblTitle.Location = new Point((this.ClientSize.Width - lblTitle.Width) / 2, lblTitle.Location.Y);
            startBtn.Location = new Point((this.ClientSize.Width - startBtn.Width) / 2, startBtn.Location.Y);
            EasyRadioBtn.Location = new Point((this.ClientSize.Width - EasyRadioBtn.Width) / 2, EasyRadioBtn.Location.Y);
            MediumRadioBtn.Location = new Point((this.ClientSize.Width - MediumRadioBtn.Width) / 2, MediumRadioBtn.Location.Y);
            HardRadioBtn.Location = new Point((this.ClientSize.Width - HardRadioBtn.Width) / 2, HardRadioBtn.Location.Y);
            EnduranceRadioBtn.Location = new Point((this.ClientSize.Width - EnduranceRadioBtn.Width) / 2, EnduranceRadioBtn.Location.Y);
        }

        private void EasyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            EasyRadioBtn.ForeColor = Color.GreenYellow;
            MediumRadioBtn.ForeColor = Color.Black;
            HardRadioBtn.ForeColor = Color.Black;
            EnduranceRadioBtn.ForeColor = Color.Black;
        }

        private void MediumRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            HardRadioBtn.ForeColor = Color.Black;
            MediumRadioBtn.ForeColor = Color.Yellow;
            EasyRadioBtn.ForeColor = Color.Black;
            EnduranceRadioBtn.ForeColor = Color.Black;
        }

        private void HardRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            HardRadioBtn.ForeColor = Color.Red;
            MediumRadioBtn.ForeColor = Color.Black;
            EasyRadioBtn.ForeColor = Color.Black;
            EnduranceRadioBtn.ForeColor = Color.Black;
        }

        private void EnduranceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            EnduranceRadioBtn.ForeColor = Color.Purple;
            MediumRadioBtn.ForeColor = Color.Black;
            HardRadioBtn.ForeColor = Color.Black;
            EasyRadioBtn.ForeColor = Color.Black;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
