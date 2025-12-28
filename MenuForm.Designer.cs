namespace ProjektZaliczeniowy
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.EasyRadioBtn = new System.Windows.Forms.RadioButton();
            this.MediumRadioBtn = new System.Windows.Forms.RadioButton();
            this.HardRadioBtn = new System.Windows.Forms.RadioButton();
            this.EnduranceRadioBtn = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.title_pulse = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.closeBtn.Location = new System.Drawing.Point(553, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 35);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // EasyRadioBtn
            // 
            this.EasyRadioBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.EasyRadioBtn.AutoSize = true;
            this.EasyRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.EasyRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EasyRadioBtn.Checked = true;
            this.EasyRadioBtn.FlatAppearance.BorderSize = 0;
            this.EasyRadioBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.EasyRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.EasyRadioBtn.ForeColor = System.Drawing.Color.Black;
            this.EasyRadioBtn.Location = new System.Drawing.Point(263, 230);
            this.EasyRadioBtn.Name = "EasyRadioBtn";
            this.EasyRadioBtn.Size = new System.Drawing.Size(89, 41);
            this.EasyRadioBtn.TabIndex = 1;
            this.EasyRadioBtn.TabStop = true;
            this.EasyRadioBtn.Text = "Easy";
            this.EasyRadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EasyRadioBtn.UseVisualStyleBackColor = false;
            this.EasyRadioBtn.Click += new System.EventHandler(this.EasyRadioBtn_CheckedChanged);
            // 
            // MediumRadioBtn
            // 
            this.MediumRadioBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.MediumRadioBtn.AutoSize = true;
            this.MediumRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.MediumRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MediumRadioBtn.FlatAppearance.BorderSize = 0;
            this.MediumRadioBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.MediumRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.MediumRadioBtn.ForeColor = System.Drawing.Color.Black;
            this.MediumRadioBtn.Location = new System.Drawing.Point(257, 277);
            this.MediumRadioBtn.Name = "MediumRadioBtn";
            this.MediumRadioBtn.Size = new System.Drawing.Size(125, 41);
            this.MediumRadioBtn.TabIndex = 2;
            this.MediumRadioBtn.Text = "Medium";
            this.MediumRadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MediumRadioBtn.UseVisualStyleBackColor = false;
            this.MediumRadioBtn.Click += new System.EventHandler(this.MediumRadioBtn_CheckedChanged);
            // 
            // HardRadioBtn
            // 
            this.HardRadioBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.HardRadioBtn.AutoSize = true;
            this.HardRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.HardRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HardRadioBtn.FlatAppearance.BorderSize = 0;
            this.HardRadioBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.HardRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.HardRadioBtn.ForeColor = System.Drawing.Color.Black;
            this.HardRadioBtn.Location = new System.Drawing.Point(265, 324);
            this.HardRadioBtn.Name = "HardRadioBtn";
            this.HardRadioBtn.Size = new System.Drawing.Size(87, 41);
            this.HardRadioBtn.TabIndex = 3;
            this.HardRadioBtn.Text = "Hard";
            this.HardRadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HardRadioBtn.UseVisualStyleBackColor = false;
            this.HardRadioBtn.Click += new System.EventHandler(this.HardRadioBtn_CheckedChanged);
            // 
            // EnduranceRadioBtn
            // 
            this.EnduranceRadioBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.EnduranceRadioBtn.AutoSize = true;
            this.EnduranceRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.EnduranceRadioBtn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnduranceRadioBtn.FlatAppearance.BorderSize = 0;
            this.EnduranceRadioBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.EnduranceRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnduranceRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.EnduranceRadioBtn.ForeColor = System.Drawing.Color.Black;
            this.EnduranceRadioBtn.Location = new System.Drawing.Point(226, 371);
            this.EnduranceRadioBtn.Name = "EnduranceRadioBtn";
            this.EnduranceRadioBtn.Size = new System.Drawing.Size(164, 41);
            this.EnduranceRadioBtn.TabIndex = 4;
            this.EnduranceRadioBtn.Text = "Endurance";
            this.EnduranceRadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnduranceRadioBtn.UseVisualStyleBackColor = false;
            this.EnduranceRadioBtn.Click += new System.EventHandler(this.EnduranceRadioBtn_CheckedChanged);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.startBtn.Location = new System.Drawing.Point(232, 451);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(150, 75);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(115, 74);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(395, 91);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "CATCHR!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_pulse
            // 
            this.title_pulse.Tick += new System.EventHandler(this.title_pulse_Tick);
            // 
            // MenuForm
            // 
            this.BackgroundImage = global::ProjektZaliczeniowy.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.EnduranceRadioBtn);
            this.Controls.Add(this.HardRadioBtn);
            this.Controls.Add(this.MediumRadioBtn);
            this.Controls.Add(this.EasyRadioBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer title_pulse;
        private System.Windows.Forms.RadioButton EasyRadioBtn;
        private System.Windows.Forms.RadioButton MediumRadioBtn;
        private System.Windows.Forms.RadioButton HardRadioBtn;
        private System.Windows.Forms.RadioButton EnduranceRadioBtn;

        #endregion

        //private System.Windows.Forms.Label lblTitle;
        //private System.Windows.Forms.Timer title_pulse;
        //private System.Windows.Forms.RadioButton EasyRadioBtn;
        //private System.Windows.Forms.RadioButton MediumRadioBtn;
        //private System.Windows.Forms.RadioButton HardRadioBtn;
        //private System.Windows.Forms.RadioButton EnduranceRadioBtn;
        //private System.Windows.Forms.Button startBtn;
        //private System.Windows.Forms.Button closeBtn;
    }
}