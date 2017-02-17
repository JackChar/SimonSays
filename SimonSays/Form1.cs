using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// JacK Charlton 
/// Strated Febuary 13, 2017
/// Completed Febuary 17, 2017
/// Program is a basic "Simon Says" memory game
/// </summary>
namespace SimonSays
{
    public partial class Form1 : Form
    {
        //global Varibles
        public static List<int> pattern = new List<int>();
        public static int o = 0;

        public Form1()
        {
            InitializeComponent();
            //Open Main Screen
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
    }
}
