namespace RockPaperScissors
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screenPc = new System.Windows.Forms.PictureBox();
            this.screenPlayer = new System.Windows.Forms.PictureBox();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.round1 = new System.Windows.Forms.Label();
            this.round2 = new System.Windows.Forms.Label();
            this.round3 = new System.Windows.Forms.Label();
            this.round1Result = new System.Windows.Forms.Label();
            this.round2Result = new System.Windows.Forms.Label();
            this.round3Result = new System.Windows.Forms.Label();
            this.scoreTitle = new System.Windows.Forms.Label();
            this.playerTitle = new System.Windows.Forms.Label();
            this.pcTitle = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.pcScore = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screenPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // screenPc
            // 
            this.screenPc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.screenPc.Location = new System.Drawing.Point(185, 22);
            this.screenPc.Name = "screenPc";
            this.screenPc.Size = new System.Drawing.Size(200, 200);
            this.screenPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenPc.TabIndex = 0;
            this.screenPc.TabStop = false;
            // 
            // screenPlayer
            // 
            this.screenPlayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.screenPlayer.Location = new System.Drawing.Point(185, 228);
            this.screenPlayer.Name = "screenPlayer";
            this.screenPlayer.Size = new System.Drawing.Size(200, 200);
            this.screenPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenPlayer.TabIndex = 1;
            this.screenPlayer.TabStop = false;
            // 
            // rockButton
            // 
            this.rockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockButton.Location = new System.Drawing.Point(28, 252);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(100, 45);
            this.rockButton.TabIndex = 2;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // paperButton
            // 
            this.paperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperButton.Location = new System.Drawing.Point(28, 303);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(100, 45);
            this.paperButton.TabIndex = 3;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // scissorsButton
            // 
            this.scissorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorsButton.Location = new System.Drawing.Point(28, 354);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(100, 45);
            this.scissorsButton.TabIndex = 4;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(28, 22);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(109, 39);
            this.gameTitle.TabIndex = 5;
            this.gameTitle.Text = "Game";
            // 
            // round1
            // 
            this.round1.AutoSize = true;
            this.round1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round1.Location = new System.Drawing.Point(11, 99);
            this.round1.Name = "round1";
            this.round1.Size = new System.Drawing.Size(82, 24);
            this.round1.TabIndex = 8;
            this.round1.Text = "Round 1";
            // 
            // round2
            // 
            this.round2.AutoSize = true;
            this.round2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round2.Location = new System.Drawing.Point(11, 136);
            this.round2.Name = "round2";
            this.round2.Size = new System.Drawing.Size(82, 24);
            this.round2.TabIndex = 9;
            this.round2.Text = "Round 2";
            // 
            // round3
            // 
            this.round3.AutoSize = true;
            this.round3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round3.Location = new System.Drawing.Point(11, 172);
            this.round3.Name = "round3";
            this.round3.Size = new System.Drawing.Size(82, 24);
            this.round3.TabIndex = 10;
            this.round3.Text = "Round 3";
            // 
            // round1Result
            // 
            this.round1Result.AutoSize = true;
            this.round1Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round1Result.Location = new System.Drawing.Point(103, 99);
            this.round1Result.Name = "round1Result";
            this.round1Result.Size = new System.Drawing.Size(25, 24);
            this.round1Result.TabIndex = 11;
            this.round1Result.Text = "...";
            // 
            // round2Result
            // 
            this.round2Result.AutoSize = true;
            this.round2Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round2Result.Location = new System.Drawing.Point(103, 136);
            this.round2Result.Name = "round2Result";
            this.round2Result.Size = new System.Drawing.Size(25, 24);
            this.round2Result.TabIndex = 12;
            this.round2Result.Text = "...";
            // 
            // round3Result
            // 
            this.round3Result.AutoSize = true;
            this.round3Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round3Result.Location = new System.Drawing.Point(103, 172);
            this.round3Result.Name = "round3Result";
            this.round3Result.Size = new System.Drawing.Size(25, 24);
            this.round3Result.TabIndex = 13;
            this.round3Result.Text = "...";
            // 
            // scoreTitle
            // 
            this.scoreTitle.AutoSize = true;
            this.scoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.Location = new System.Drawing.Point(428, 22);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(106, 39);
            this.scoreTitle.TabIndex = 14;
            this.scoreTitle.Text = "Score";
            // 
            // playerTitle
            // 
            this.playerTitle.AutoSize = true;
            this.playerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTitle.Location = new System.Drawing.Point(418, 82);
            this.playerTitle.Name = "playerTitle";
            this.playerTitle.Size = new System.Drawing.Size(62, 24);
            this.playerTitle.TabIndex = 15;
            this.playerTitle.Text = "Player";
            // 
            // pcTitle
            // 
            this.pcTitle.AutoSize = true;
            this.pcTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcTitle.Location = new System.Drawing.Point(527, 82);
            this.pcTitle.Name = "pcTitle";
            this.pcTitle.Size = new System.Drawing.Size(35, 24);
            this.pcTitle.TabIndex = 16;
            this.pcTitle.Text = "PC";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.Location = new System.Drawing.Point(431, 136);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(30, 24);
            this.playerScore.TabIndex = 17;
            this.playerScore.Text = "00";
            // 
            // pcScore
            // 
            this.pcScore.AutoSize = true;
            this.pcScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcScore.Location = new System.Drawing.Point(527, 136);
            this.pcScore.Name = "pcScore";
            this.pcScore.Size = new System.Drawing.Size(30, 24);
            this.pcScore.TabIndex = 18;
            this.pcScore.Text = "00";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.Location = new System.Drawing.Point(435, 266);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(99, 82);
            this.playAgainButton.TabIndex = 19;
            this.playAgainButton.Text = "Play again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Coral;
            this.label13.Location = new System.Drawing.Point(419, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 31);
            this.label13.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(265, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "PC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 431);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.pcScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.pcTitle);
            this.Controls.Add(this.playerTitle);
            this.Controls.Add(this.scoreTitle);
            this.Controls.Add(this.round3Result);
            this.Controls.Add(this.round2Result);
            this.Controls.Add(this.round1Result);
            this.Controls.Add(this.round3);
            this.Controls.Add(this.round2);
            this.Controls.Add(this.round1);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.screenPlayer);
            this.Controls.Add(this.screenPc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock, Paper, Scissors Game";
            ((System.ComponentModel.ISupportInitialize)(this.screenPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox screenPc;
        private System.Windows.Forms.PictureBox screenPlayer;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label round1;
        private System.Windows.Forms.Label round2;
        private System.Windows.Forms.Label round3;
        private System.Windows.Forms.Label round1Result;
        private System.Windows.Forms.Label round2Result;
        private System.Windows.Forms.Label round3Result;
        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Label playerTitle;
        private System.Windows.Forms.Label pcTitle;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label pcScore;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

