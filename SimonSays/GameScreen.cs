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
using System.Media;

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
        int p;  //p is used to keep track of pattern

        //Computers turn method
        public void computerTurn()
        {
            //program pauses and creates a random number that it adds to the pattern (represents 1 of 4 colors)
            Thread.Sleep(500);
            int rand = randNum.Next(1, 5);
            Form1.pattern.Add(rand);

            //updates current score
            currentScoreLabel.Text = Convert.ToString(Form1.o);Form1.o++;   
                    
            //This for loop detrmines what button lights up based on the random number next in the patern
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 4)
                {
                    //If the random number is 4, the green button flashes and makes a noise
                    greenButton.BackColor = Color.LimeGreen;
                    Refresh();
                    SoundPlayer player = new SoundPlayer(Properties.Resources.green);
                    player.Play();
                    Thread.Sleep(300);
                    greenButton.BackColor = Color.Green;
                    Refresh();
                }

                if (Form1.pattern[i] == 1)
                {
                    //If the random number is 1, the red button flashes and makes a noise
                    redButton.BackColor = Color.Red;
                    Refresh();
                    SoundPlayer player = new SoundPlayer(Properties.Resources.red);
                    player.Play();
                    Thread.Sleep(300);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                }

                if (Form1.pattern[i] == 2)
                {
                    //If the random number is 2, the yellow button flashes and makes a noise
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    SoundPlayer player = new SoundPlayer(Properties.Resources.yellow);
                    player.Play();
                    Thread.Sleep(300);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                }

                if (Form1.pattern[i] == 3)
                {
                    //If the random number is 3, the blue button flashes and makes a noise
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    SoundPlayer player = new SoundPlayer(Properties.Resources.blue);
                    player.Play();
                    Thread.Sleep(300);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();
                }
            }
            p = 0;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //upon loading the program creates a new pattern, pauses, and begins computers turn
            Form1.pattern.Clear();
            Refresh();
            this.DoubleBuffered = true;
            Thread.Sleep(600);
            computerTurn();        
        }   

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[p] == 4)
            {
                //green flashes and makes a noise when you click it                 
                greenButton.BackColor = Color.LimeGreen;
                Refresh();
                SoundPlayer player = new SoundPlayer(Properties.Resources.green);
                player.Play();
                Thread.Sleep(50);
                greenButton.BackColor = Color.Green;
                Refresh();

                //move to next color in pattern
                p++;
            }
            if (p == Form1.pattern.Count())
            {
                //If this is the last color in the pattern the program begin the computers turn again
                computerTurn();
            }
            else
            {
                //plays game over music and pause for a moment
                SoundPlayer player = new SoundPlayer(Properties.Resources.mistake);
                player.Play();
                Thread.Sleep(100);

                //leave game screen and open game over screen
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[p] == 1)
            {
                //red flashes and makes a noise when you click it 
                redButton.BackColor = Color.Red;
                Refresh();
                SoundPlayer player = new SoundPlayer(Properties.Resources.red);
                player.Play();
                Thread.Sleep(50);
                redButton.BackColor = Color.DarkRed;
                Refresh();

                //move to next color in pattern
                p++;
                if (p == Form1.pattern.Count())
                {
                    //If this is the last color in the pattern the program begin the computers turn again
                    computerTurn();
                }
            }
            else
            {
                //plays game over music and pause for a moment
                SoundPlayer player = new SoundPlayer(Properties.Resources.mistake);
                player.Play();
                Thread.Sleep(100);

                //leave game screen and open game over screen
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }

       
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[p] == 2)
            {
                //yellow flashes and makes a noise when you click it 
                yellowButton.BackColor = Color.Yellow;
                Refresh();
                SoundPlayer player = new SoundPlayer(Properties.Resources.yellow);
                player.Play();
                Thread.Sleep(50);
                yellowButton.BackColor = Color.Goldenrod;
                Refresh();

                //move to next color in pattern
                p++;
                if (p == Form1.pattern.Count())
                {
                    //If this is the last color in the pattern the program begin the computers turn again
                    computerTurn();
                }
            }
            else
            {
                //plays game over music and pause for a moment
                SoundPlayer player = new SoundPlayer(Properties.Resources.mistake);
                player.Play();
                Thread.Sleep(100);

                //leave game screen and open game over screen
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }          
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[p] == 3)
            {
                //blue flashes and makes a noise when you click it 
                blueButton.BackColor = Color.Blue;
                Refresh();
                SoundPlayer player = new SoundPlayer(Properties.Resources.blue);
                player.Play();
                Thread.Sleep(50);
                blueButton.BackColor = Color.DarkBlue;
                Refresh();

                //move to next color in pattern
                p++;
                if (p == Form1.pattern.Count())
                {
                    //If this is the last color in the pattern the program begin the computers turn again
                    computerTurn();
                }
            }
            else
            {
                //plays game over music and pause for a moment
                SoundPlayer player = new SoundPlayer(Properties.Resources.mistake);
                player.Play();
                Thread.Sleep(100);

                //leave game screen and open game over screen
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }          
        }
    }
}

