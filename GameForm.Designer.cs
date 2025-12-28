namespace ProjektZaliczeniowy
{
    partial class GameForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnTarget = new System.Windows.Forms.Button();
            this.lblLives = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTarget
            // 
            this.btnTarget.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTarget.FlatAppearance.BorderSize = 2;
            this.btnTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTarget.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTarget.Location = new System.Drawing.Point(275, 425);
            this.btnTarget.Margin = new System.Windows.Forms.Padding(0);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(50, 50);
            this.btnTarget.TabIndex = 5;
            this.btnTarget.Text = "Click!";
            this.btnTarget.UseVisualStyleBackColor = false;
            this.btnTarget.Visible = false;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.Transparent;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLives.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLives.Location = new System.Drawing.Point(467, 554);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(80, 25);
            this.lblLives.TabIndex = 2;
            this.lblLives.Text = "Lives: 3";
            this.lblLives.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblCountdown
            // 
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCountdown.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCountdown.Location = new System.Drawing.Point(175, 75);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(250, 75);
            this.lblCountdown.TabIndex = 3;
            this.lblCountdown.Text = "READY?";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore.Location = new System.Drawing.Point(45, 554);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 25);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            this.lblScore.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 25);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time to Click: ";
            this.lblTime.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjektZaliczeniowy.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.lblLives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Catchr!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
    }
}

