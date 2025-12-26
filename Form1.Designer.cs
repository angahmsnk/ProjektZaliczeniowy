namespace ProjektZaliczeniowy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTarget = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLifes = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnTarget
            // 
            this.btnTarget.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTarget.FlatAppearance.BorderSize = 2;
            this.btnTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTarget.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTarget.Location = new System.Drawing.Point(275, 275);
            this.btnTarget.Margin = new System.Windows.Forms.Padding(0);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(50, 50);
            this.btnTarget.TabIndex = 0;
            this.btnTarget.Text = "Click!";
            this.btnTarget.UseVisualStyleBackColor = false;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore.Location = new System.Drawing.Point(36, 516);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(289, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Click button to Start New Game!";
            // 
            // lblLifes
            // 
            this.lblLifes.AutoSize = true;
            this.lblLifes.BackColor = System.Drawing.Color.Transparent;
            this.lblLifes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLifes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLifes.Location = new System.Drawing.Point(455, 516);
            this.lblLifes.Name = "lblLifes";
            this.lblLifes.Size = new System.Drawing.Size(75, 25);
            this.lblLifes.TabIndex = 2;
            this.lblLifes.Text = "Lifes: 3";
            this.lblLifes.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjektZaliczeniowy.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.lblLifes);
            this.Controls.Add(this.lblScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLifes;
        private System.Windows.Forms.Timer gameTimer;
    }
}

