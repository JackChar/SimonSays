using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        public static List<int> pattern = new List<int>();
        public static int guesses;
        public static int counter;

        public Form1()
        {
            InitializeComponent();

            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
