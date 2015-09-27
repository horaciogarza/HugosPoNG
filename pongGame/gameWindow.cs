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

        
        protected int yPlayer1 = 132;
        protected int yPlayer2 = 132;
        

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

            
        }

        private void gameWindow_KeyPress(object sender, KeyPressEventArgs e)
        {



        }
        private void gameWindow_KeyDown(object sender, KeyEventArgs e)
        {

            
            

            
        }

        private void gameWindow_KeyUp(object sender, KeyEventArgs e)
        {


            switch (e.KeyData)
            {
                case Keys.Up:

                        if (yPlayer1 > 20)
                        {
                            yPlayer1 -= 20;
                            playerOne.Location = new Point(40, yPlayer1);
                        }
                    break;

                case Keys.Down:

                        if (yPlayer1 < 260)
                        {
                            yPlayer1 += 20;
                            playerOne.Location = new Point(40, yPlayer1);
                        }

                    break;


                case Keys.W:

                    if (yPlayer2 > 20)
                    {
                        yPlayer2 -= 20;
                        playerTwo.Location = new Point(734, yPlayer2);
                    }
                    break;

                case Keys.S:

                    if (yPlayer2 < 260)
                    {
                        yPlayer2 += 20;
                        playerTwo.Location = new Point(734, yPlayer2);
                    }

                    break;


            }
            








        }

        private void gameWindow_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void playerOne_Click(object sender, EventArgs e)
        {

        }
    }
}
