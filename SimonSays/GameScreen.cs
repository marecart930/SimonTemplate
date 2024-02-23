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
        // guess variable to track what part of the pattern the user is at
        int guess;
        public static int round;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //clears the pattern list from form1, refreshes, runs computer turn
            Form1.patternList.Clear();
            Refresh();
            Thread.Sleep(500);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            //TODO: gets rand num between 0 and 4 (0, 1, 2, 3) and adds to pattern list
            Random randGen = new Random();
            Form1.patternList.Add(randGen.Next(0, 4));
            // for loop shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.patternList.Count; i++)
            {
                 Thread.Sleep(400);

                if (Form1.patternList[i] == 0)
                {
                    greenButton.BackColor = Color.LimeGreen;
                    Form1.green.Play();
                    Refresh();
                    Thread.Sleep(800);
                    greenButton.BackColor = Color.ForestGreen;
                    Refresh();
                }
                if (Form1.patternList[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    Form1.red.Play();
                    Refresh();
                    Thread.Sleep(800);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                }
               if (Form1.patternList[i] == 2)
                {
                    Form1.yellow.Play();
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(800);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                }
                if (Form1.patternList[i] == 3)
                {
                    Form1.blue.Play();
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(800);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();

                }

            }
            guess = 0;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.patternList[guess] == 0)
            {
                greenButton.BackColor = Color.LimeGreen;
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
            //check to see if we are at the end of the pattern
            if (guess >= Form1.patternList.Count)
            {
                round++;
                ComputerTurn();
            }

        }

        //close this screen and open the GameOverScreen
          public void GameOver()
        {
            Form1.gameOver.Play();
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
            if (guess >= Form1.patternList.Count)
            {
                guess++;
                ComputerTurn();
            }

        }

    }
}
