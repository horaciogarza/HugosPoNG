using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pongGame
{
    


    public partial class gameWindow : Form
    {

        protected int x = 10, y= 10;
        protected int yPlayer1 = 132, player1Score = 0;
        protected int yPlayer2 = 132, player2Score = 0;
        protected int xBall = 380;
        protected int yBall = 135;
        System.Media.SoundPlayer bounceSound = new System.Media.SoundPlayer(@"C:\Users\hgx95\Desktop\bounceSound.wav");
        System.Media.SoundPlayer bounceSound2 = new System.Media.SoundPlayer(@"C:\Users\hgx95\Desktop\bounceSound2.wav");
        System.Media.SoundPlayer loose = new System.Media.SoundPlayer(@"C:\Users\hgx95\Desktop\overSound.wav");





        public gameWindow()
        {
            InitializeComponent();
        }

        private void gameWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void playerTwo_Click(object sender, EventArgs e)
        {

        }
        

        private void timerForGame_Tick(object sender, EventArgs e)
        {


            moveBall();
            
            
            ball.Location = new Point(xBall, yBall);
            checkIfBounce();
            checkIfLoose();

            
        }
        /// <summary>
        /// the move Ball indicates each move of X and Y
        /// </summary>
        private void moveBall()
        {
            
            xBall +=  x;
            yBall += y;
        }

        /// <summary>
        /// checkIfBounce() method is used for checking if the ball is in the area where it can bounce, like the rackets (players),
        /// the collisions with the walls (in Y)
        /// </summary>
        private void checkIfBounce()
        {
            //The first second player code (The right one)
            if (xBall >= 730 &&  yBall <= (yPlayer2+80) && yBall >= yPlayer2)
            {
                bounceSound.Play();
                x = x * (-1);
                if (yBall == (yPlayer2+40))
                {
                    yBall = 0;
                    y = 0;
                }
                else
                {
                    if (yBall > (yPlayer2+40))
                    {
                         y += 3*(yBall - (yPlayer2 + 40))/4;
                    }
                    else
                    {
                       y +=  3*((yPlayer2+40)- yBall)/4;
                    }
                }
                
            }

            //The first player code (The left one)
            if (xBall <= 42 && yBall <= (yPlayer1 + 80) && yBall >= yPlayer1)
            {
                bounceSound2.Play();
                x = x * (-1);

                if (yBall == (yPlayer1 + 40))
                {
                    yBall = 0;
                    y = 0;
                }
                else
                {
                    if (yBall > (yPlayer1 + 40))
                    {
                        y += 3 * (yBall - (yPlayer1 + 40)) / 4;
                    }
                    else
                    {
                        y += 3 * ((yPlayer1 + 40) - yBall) / 4;
                        
                    }
                }


            }


            if (yBall >= 340 || yBall <= 10)
            {
                y = y * (-1);
            }

         

        }

        /// <summary>
        /// Here we created a method for checking if the ball is in the loosing area
        /// </summary>
        /// 
        private void checkIfLoose()
        {
            //Checking the right player
            if (xBall >= 744 && (yBall >= (yPlayer2 + 80) || yBall <= yPlayer2))
            {
                loose.Play();
                player1Score += 1;
                y = 10;
                
                
                label1.Text = player1Score.ToString();

                xBall = 380; //We initalate in the center of the screen
            }

            //Checking the left player
            if (xBall <= 42 && (yBall >= (yPlayer1 + 80) || yBall <= yPlayer1))
            {
                loose.Play();
                player2Score += 1;
                y = 10;
                
                label2.Text = player2Score.ToString();

                xBall = 380; //We initalate in the center of the screen
            }
        }

       

        /// <summary>
        /// This method is used for constantly checking if one key is pressed or not
        /// </summary>
        /// <param name="sender">Default parameter</param>
        /// <param name="e">Default parameter</param>
        private void gameWindow_KeyUp(object sender, KeyEventArgs e)
        {


            switch (e.KeyData)
            {
                case Keys.W:

                        if (yPlayer1 > 20)
                        {
                            yPlayer1 -= 20;
                            playerOne.Location = new Point(40, yPlayer1);
                        }
                    break;

                case Keys.S:

                        if (yPlayer1 < 260)
                        {
                            yPlayer1 += 20;
                            playerOne.Location = new Point(40, yPlayer1);
                        }

                    break;


                case Keys.Up:

                        if (yPlayer2 > 20)
                        {
                            yPlayer2 -= 20;
                            playerTwo.Location = new Point(734, yPlayer2);
                        }
                    break;

                case Keys.Down:

                        if (yPlayer2 < 260)
                        {
                            yPlayer2 += 20;
                            playerTwo.Location = new Point(734, yPlayer2);
                        }

                    break;


            }
            








        }


        //Unused methods
        private void gameWindow_MouseUp(object sender, MouseEventArgs e)
        {
           
        }
        private void playerOne_Click(object sender, EventArgs e)
        {

        } 
        private void gameWindow_KeyPress(object sender, KeyPressEventArgs e)
        {



        }
        private void gameWindow_KeyDown(object sender, KeyEventArgs e)
        {

            
            

            
        }
    }
}
