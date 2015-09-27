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

        Player p1 = new Player(132, 0);
        Player p2 = new Player(132, 0);

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

           
            
            if (playerOne.Location.Y > 790 || playerOne.Location.Y < 20 )
            {

            }
            else
            {

                playerOne.Location = new Point(40, p1.sumY());
            }
        }

        private void gameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (playerOne.Location.Y > 790 || playerOne.Location.Y < 20)
            {

            }
            else
            {
                
                playerOne.Location = new Point(40, p1.sumY());
            }
        }
    }
}
