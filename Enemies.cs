using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_game
{
    class Enemies
    {
        PictureBox[] enemies;
        int sizeEnemy;
        int enemiesSpeed;
        Random rnd;

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            enemies = new PictureBox[4];
            int sizeEnemy = rnd.Next(60, 80);
            enemiesSpeed = 6;

            Image easyEnemies = Image.FromFile("assest\\monster.png");

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(sizeEnemy, sizeEnemy);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Image = easyEnemies;
                enemies[i].Location = new Point((i + 1) * rnd.Next(90, 160) + 1080, rnd.Next(450, 600));

            }
        }

        private void MoveEnemis(PictureBox[] enemies, int speed)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Left -= speed + (int)(Math.Sin(enemies[i].Left * Math.PI / 180) + Math.Cos(enemies[i].Left * Math.PI / 180));
            }
        }

        private void MoveEnemiesTimer_Tick_1(object sender, EventArgs e)
        {
            MoveEnemis(enemies, enemiesSpeed);
        }
    }
}
