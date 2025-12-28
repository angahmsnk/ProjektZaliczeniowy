namespace ProjektZaliczeniowy
{
    partial class GameOverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEndgame = new System.Windows.Forms.Label();
            this.lblEndgameScore = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEndgame
            // 
            this.lblEndgame.AutoSize = true;
            this.lblEndgame.BackColor = System.Drawing.Color.Transparent;
            this.lblEndgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblEndgame.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEndgame.Location = new System.Drawing.Point(124, 78);
            this.lblEndgame.Name = "lblEndgame";
            this.lblEndgame.Size = new System.Drawing.Size(369, 37);
            this.lblEndgame.TabIndex = 0;
            this.lblEndgame.Text = "Game Over! Your Score:";
            // 
            // lblEndgameScore
            // 
            this.lblEndgameScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndgameScore.AutoSize = true;
            this.lblEndgameScore.BackColor = System.Drawing.Color.Transparent;
            this.lblEndgameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblEndgameScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEndgameScore.Location = new System.Drawing.Point(218, 177);
            this.lblEndgameScore.Name = "lblEndgameScore";
            this.lblEndgameScore.Size = new System.Drawing.Size(168, 63);
            this.lblEndgameScore.TabIndex = 1;
            this.lblEndgameScore.Text = "Score";
            this.lblEndgameScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newGameBtn
            // 
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.newGameBtn.Location = new System.Drawing.Point(229, 388);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(150, 75);
            this.newGameBtn.TabIndex = 2;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.closeBtn.Location = new System.Drawing.Point(553, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 35);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjektZaliczeniowy.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.lblEndgameScore);
            this.Controls.Add(this.lblEndgame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOverForm";
            this.Text = "GameOverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEndgame;
        private System.Windows.Forms.Label lblEndgameScore;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}