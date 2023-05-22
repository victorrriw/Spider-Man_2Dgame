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
    class Bullets
    {
        PictureBox[] bullets;
        int bulletspeed;

        private void Form1_Load(object sender, EventArgs e)
        {
            bullets = new PictureBox[1];
            bulletspeed = 80;

            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(20, 5);
                bullets[i].BackColor = Color.White;
            }
        }
      
        private void MoveBulletsTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i].Left += bulletspeed;
            }
        }
    }
}

