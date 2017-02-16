using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
            p = 0;        
        }

        public static Random randNum = new Random();

        int p;

        public void computerTurn()
        {
            Thread.Sleep(500);
            int rand = randNum.Next(1, 5);
            Form1.pattern.Add(rand);

            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    button1.BackColor = Color.LimeGreen;
                    Refresh();
                    Thread.Sleep(300);
                    button1.BackColor = Color.Green;
                    Refresh();
                }

                if (Form1.pattern[i] == 1)
                {
                    button2.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(300);
                    button2.BackColor = Color.DarkRed;
                    Refresh();
                }

                if (Form1.pattern[i] == 2)
                {
                    button3.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(300);
                    button3.BackColor = Color.Goldenrod;
                    Refresh();
                }

                if (Form1.pattern[i] == 3)
                {
                    button4.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(300);
                    button4.BackColor = Color.DarkBlue;
                    Refresh();
                }
            }
            p = 0;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            this.DoubleBuffered = true;
            Thread.Sleep(600);
            computerTurn();        
        }   

        private void button1_Click(object sender, EventArgs e)
        {          
            if (Form1.pattern[p] == 0)
            {

                button1.BackColor = Color.LimeGreen;
                Refresh();
                Thread.Sleep(50);
                button1.BackColor = Color.Green;
                Refresh();
                p++;
            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }

            if (p == Form1.pattern.Count())
            {
                computerTurn();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[p] == 1)
            {
                button2.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(50);
                button2.BackColor = Color.DarkRed;
                Refresh();
                p++;
            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }

            if (p == Form1.pattern.Count())
            {
                computerTurn();
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[p] == 2)
            {
                button3.BackColor = Color.Yellow;
                Refresh();
                Thread.Sleep(50);
                button3.BackColor = Color.Goldenrod;
                Refresh();
                p++;
            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }

            if (p == Form1.pattern.Count())
            {
                computerTurn();
            }          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[p] == 3)
            {
                button4.BackColor = Color.Blue;
                Refresh();
                Thread.Sleep(50);
                button4.BackColor = Color.DarkBlue;
                Refresh();
                p++;
            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }

            if (p == Form1.pattern.Count())
            {
                computerTurn();              
            }            
        }
    }
}

