using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pong
{

    public partial class Form1 : Form
    {
        bool goUp; //boolean to detect player up position
        bool goDown; //same but down position
        int speed = 5;
        int ballX = 5; //horizontal X speed value
        int ballY = 5; //vertical Y speed value of ball
        int scorePlayer = 0; //player score
        int scoreCPU = 0; //CPU score

        public System.Windows.Media.MediaPlayer backgroundMusic = new System.Windows.Media.MediaPlayer();
        public System.Windows.Media.MediaPlayer tap = new System.Windows.Media.MediaPlayer();
        public System.Windows.Media.MediaPlayer wall = new System.Windows.Media.MediaPlayer();
        public Form1()
        {

            tap.Open(new System.Uri(@"C:\Users\Szymon\Desktop\Sounds\knock.wav"));
            tap.Volume = 0.1;

            wall.Open(new System.Uri(@"C:\Users\Szymon\Desktop\Sounds\tap.wav"));

            backgroundMusic.Open(new System.Uri(@"C:\Users\Szymon\Desktop\Sounds\sound1.wav"));
            backgroundMusic.Volume = 0.1;
            backgroundMusic.MediaEnded += new EventHandler(backgroundMediaEnded);
            backgroundMusic.Play();
            InitializeComponent();
        }

        private void backgroundMediaEnded(object sender, EventArgs e)
        {
            backgroundMusic.Position = TimeSpan.Zero;
            backgroundMusic.Play();
        }
        private void keyIsDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Up)
                goUp = true;
            if (e.KeyCode == Keys.Down)
                goDown = true;
        }

        private void keyIsUp(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Up)
                goUp = false;
            if (e.KeyCode == Keys.Down)
                goDown = false;
        }

        private void timerTick(object sender, EventArgs e){
            playerScore.Text = scorePlayer.ToString();
            cpuScore.Text = scoreCPU.ToString();
          

            ball.Top -= ballY;
            ball.Left -= ballX;

            cpuPaddle.Top += speed;
            
            if(scorePlayer < 5)
            {
                if (cpuPaddle.Top < 0 || cpuPaddle.Top > 455)
                    speed = -speed;
            }
            else
            {
                cpuPaddle.Top = ball.Top + 30;
            }

            //ball has gone pass the player through the left, reset it to middle and update score
            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballX = -5;
                scoreCPU++;
            }

            //ball has gone past the right, reset it to middle and update score
            if(ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballX = 5;
                scorePlayer++;
            }

            //ball reaches the top or bottom of the screen, bounce it in other direction
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                wall.Position = TimeSpan.Zero;
                wall.Play();
                ballY = -ballY;
            }

            //ball hits the player or cpu paddle
            if (ball.Bounds.IntersectsWith(playerPaddle.Bounds) || ball.Bounds.IntersectsWith(cpuPaddle.Bounds))
            {
                tap.Position = TimeSpan.Zero;
                tap.Play();
                ballX = -ballX;
            }
            //moving up
            if (goUp == true && playerPaddle.Top > 0)
                playerPaddle.Top -= 8;

            //moving down
            if (goDown == true && playerPaddle.Top < ClientSize.Height - playerPaddle.Height)
                playerPaddle.Top += 8;

            //ending game
            if(scorePlayer > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You win!");
            }

            if(scoreCPU > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("CPU wins the game!");
            }
        }
      
    }
}
