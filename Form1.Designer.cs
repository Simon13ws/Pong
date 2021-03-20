namespace Pong
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
            this.playerPaddle = new System.Windows.Forms.PictureBox();
            this.cpuPaddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPaddle
            // 
            this.playerPaddle.BackColor = System.Drawing.Color.YellowGreen;
            this.playerPaddle.Location = new System.Drawing.Point(12, 185);
            this.playerPaddle.Name = "playerPaddle";
            this.playerPaddle.Size = new System.Drawing.Size(16, 68);
            this.playerPaddle.TabIndex = 1;
            this.playerPaddle.TabStop = false;
            // 
            // cpuPaddle
            // 
            this.cpuPaddle.BackColor = System.Drawing.Color.Gold;
            this.cpuPaddle.Location = new System.Drawing.Point(772, 185);
            this.cpuPaddle.Name = "cpuPaddle";
            this.cpuPaddle.Size = new System.Drawing.Size(16, 68);
            this.cpuPaddle.TabIndex = 2;
            this.cpuPaddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.IndianRed;
            this.ball.Location = new System.Drawing.Point(392, 199);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 16);
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerScore.ForeColor = System.Drawing.Color.YellowGreen;
            this.playerScore.Location = new System.Drawing.Point(327, 28);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(38, 26);
            this.playerScore.TabIndex = 4;
            this.playerScore.Text = "00";
            // 
            // cpuScore
            // 
            this.cpuScore.AutoSize = true;
            this.cpuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpuScore.ForeColor = System.Drawing.Color.OrangeRed;
            this.cpuScore.Location = new System.Drawing.Point(426, 28);
            this.cpuScore.Name = "cpuScore";
            this.cpuScore.Size = new System.Drawing.Size(38, 26);
            this.cpuScore.TabIndex = 6;
            this.cpuScore.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpuScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cpuPaddle);
            this.Controls.Add(this.playerPaddle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPaddle;
        private System.Windows.Forms.PictureBox cpuPaddle;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuScore;
    }
}

