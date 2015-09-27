using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pongGame
{
    class Player
    {

        private int y;
        private int score;

        public Player()
        {
            int y = 0;
            int score = 0;
        }

        public Player(int y, int score)
        {
            this.y = y;
            this.score = score;
        }



        
        //Here's the method where we will sum the Y coord
        public int sumY()
        {
            this.y += 5;
            return this.y;
        }

        public int substractY()
        {
            this.y -= 5;
            return this.y;
        }

        //Method to sumY
        public int getY()
        {
            return this.y;
        }

        //Adding 1 to the score variable
        public void addPointScore()
        {
            this.score += 1;
        }





    }
}
