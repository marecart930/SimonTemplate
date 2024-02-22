using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create an int guess variable to track what part of the pattern the user is at
        int guess;
        public static int round;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1
            Form1.patternList.Clear();
            //TODO: refresh
            Refresh();
            //TODO: pause for a bit
            Thread.Sleep(500);
            //TODO: run ComputerTurn()
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list. Each number represents a button. For example, 0 may be green, 1 may be blue, etc.
            Random randGen = new Random();
            //guess = randGen.Next(0,4);
            Form1.patternList.Add(randGen.Next(0, 4));
            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.patternList.Count; i++)
            {
                 Thread.Sleep(400);
                // switch (Form1.patternList[i])

                if (Form1.patternList[i] == 0)
                {
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(800);
                    greenButton.BackColor = Color.ForestGreen;
                    Refresh();
                }
                if (Form1.patternList[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(800);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                }
               if (Form1.patternList[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(800);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                }
                if (Form1.patternList[i] == 3)
                {
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(800);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();

                }

            }
            //TODO: set guess value back to 0
            guess = 0;
        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[guess] == 0)
            {
                greenButton.BackColor = Color.Green;
                Form1.green.Play();
                Refresh();
                Thread.Sleep(800);
                greenButton.BackColor = Color.ForestGreen;
                guess  ++;
            }
            else
            {
                GameOver();
            }
            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            if (guess >= Form1.patternList.Count)
            {
                round++;
                ComputerTurn();
            }

        }

        public void GameOver()
        {
            //TODO: Play a game over sound
            Form1.gameOver.Play();
            //TODO: close this screen and open the GameOverScreen
            GameOverScreen gos = new GameOverScreen();
            this.Controls.Add(gos);
            gos.Location = new Point((this.Width - gos.Width) / 2, (this.Height - gos.Height) / 2);
            blueButton.Visible = false;
            yellowButton.Visible = false;
            greenButton.Visible = false;
            redButton.Visible = false;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[guess] == 1)
            {
                redButton.BackColor = Color.Red;
                Form1.red.Play();
                Refresh();
                Thread.Sleep(800);
                redButton.BackColor = Color.DarkRed;
                guess ++;
            }
            else
            {
                GameOver();
            }
            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            if (guess >= Form1.patternList.Count)
            {
                round++;
                ComputerTurn();
            }
            
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[guess] == 2)
            {
                yellowButton.BackColor = Color.Yellow;
                Form1.yellow.Play();
                Refresh();
                Thread.Sleep(800);
                yellowButton.BackColor = Color.Goldenrod;
                guess ++;
            }
            else
            {
                GameOver();
            }
            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            if (guess >= Form1.patternList.Count)
            {
                round++;
                ComputerTurn();
            }

        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[guess] == 3)
            {
                blueButton.BackColor = Color.Blue;
                Form1.blue.Play();
                Refresh();
                Thread.Sleep(800);
                blueButton.BackColor = Color.DarkBlue;
                guess ++;
            }
            else
            {
                GameOver();
            }
            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            if (guess >= Form1.patternList.Count)
            {
                guess++;
                ComputerTurn();
            }

        }

    }
}
