using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
            //Display Score
            scoreLabel.Text = Convert.ToString(Form1.o -1);
        }         

        private void mainScreenButton_Click(object sender, EventArgs e)
        {
            //Return score to 0
            Form1.o = 0;
            //Return to Main menu
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
        }
    }
}
