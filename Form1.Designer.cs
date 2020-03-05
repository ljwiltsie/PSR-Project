namespace PSR_Project
{
    partial class RPS_GAME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPS_GAME));
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.grpPlayerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(179, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(483, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ROCK PAPER SCISSORS";
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::PSR_Project.Properties.Resources.Computer_good;
            this.imgOpponent.Location = new System.Drawing.Point(413, 128);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(375, 239);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOpponent.TabIndex = 1;
            this.imgOpponent.TabStop = false;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblComputer.Location = new System.Drawing.Point(562, 104);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(79, 21);
            this.lblComputer.TabIndex = 3;
            this.lblComputer.Text = "Computer";
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::PSR_Project.Properties.Resources.player_good;
            this.imgPlayer.Location = new System.Drawing.Point(39, 128);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(340, 224);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPlayer.TabIndex = 4;
            this.imgPlayer.TabStop = false;

            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPlayer.Location = new System.Drawing.Point(174, 104);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(54, 21);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "Player";
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpPlayerChoice.BackColor = System.Drawing.Color.Black;
            this.grpPlayerChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpPlayerChoice.Controls.Add(this.radScissors);
            this.grpPlayerChoice.Controls.Add(this.radPaper);
            this.grpPlayerChoice.Controls.Add(this.radRock);
            this.grpPlayerChoice.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerChoice.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpPlayerChoice.Location = new System.Drawing.Point(1, 331);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(135, 118);
            this.grpPlayerChoice.TabIndex = 6;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice";
            // 
            // radScissors
            // 
            this.radScissors.Appearance = System.Windows.Forms.Appearance.Button;
            this.radScissors.AutoSize = true;
            this.radScissors.BackColor = System.Drawing.Color.Black;
            this.radScissors.Checked = true;
            this.radScissors.Location = new System.Drawing.Point(6, 83);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(81, 31);
            this.radScissors.TabIndex = 2;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = false;
            this.radScissors.CheckedChanged += new System.EventHandler(this.RadScissors_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.Appearance = System.Windows.Forms.Appearance.Button;
            this.radPaper.AutoSize = true;
            this.radPaper.BackColor = System.Drawing.Color.Black;
            this.radPaper.Location = new System.Drawing.Point(6, 51);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(61, 31);
            this.radPaper.TabIndex = 1;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = false;
            this.radPaper.CheckedChanged += new System.EventHandler(this.RadPaper_CheckedChanged);
            // 
            // radRock
            // 
            this.radRock.Appearance = System.Windows.Forms.Appearance.Button;
            this.radRock.AutoSize = true;
            this.radRock.BackColor = System.Drawing.Color.Black;
            this.radRock.Location = new System.Drawing.Point(6, 19);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(55, 31);
            this.radRock.TabIndex = 0;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = false;
            this.radRock.CheckedChanged += new System.EventHandler(this.RadRock_CheckedChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlay.Location = new System.Drawing.Point(7, 294);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(81, 31);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // RPS_GAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPS_GAME";
            this.Text = "RPS GAME";
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.Button btnPlay;
    }
}

