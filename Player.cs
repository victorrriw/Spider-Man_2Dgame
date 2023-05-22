using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace _2D_game
{
    class Player
    {
        Random rnd;
        int playerSpeed;

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            playerSpeed = 7;
        }
    }
}
