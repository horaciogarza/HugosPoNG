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
    public partial class PrincipalWindow : Form
    {
        public PrincipalWindow()
        {
            InitializeComponent();
        }

        private void PrincipalWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            gameWindow gw1 = new gameWindow();
            gw1.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About ab1 = new About();
            ab1.Show();
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            Highscore hs1 = new Highscore();
            hs1.Show();
        }
    }
}
