using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Difficulty_settings
{
    public partial class Form1 : Form
    {   //heroname and difficultyLevel message strings 
        string heroName;
        string difficultyLevel;
        public Form1()
        {
            InitializeComponent();
        }

         
        private void easyButton_Click(object sender, EventArgs e)
        {   //easy button
            easyButton.BackColor = Color.Green;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;

            difficultyLevel = "easy";

        }

        private void mediumButton_Click(object sender, EventArgs e)
        {   //medium button
            mediumButton.BackColor = Color.Orange;
            easyButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;

            difficultyLevel = "medium";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {   //hard button
            hardButton.BackColor = Color.Red;
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;

            difficultyLevel = "hard";
        }

        private void begin_Click(object sender, EventArgs e)
        {   //Weloce message 
            heroName = heronameOutput.Text;
            welcomeOutput.Text = $"Welcome {heroName}";
            //difficulty level message
            outputLabel.Text += $"A true brave Hero!Go forth and conquer the {difficultyLevel} path!";
        }

         
    }
}
