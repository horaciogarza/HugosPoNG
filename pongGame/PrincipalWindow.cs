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
    }
}
