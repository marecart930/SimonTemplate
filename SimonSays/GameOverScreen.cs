using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //shows the length of the pattern
            lengthLabel.Text = $"{GameScreen.round - 1}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //closes this screen and open the MenuScreen
            patternLabel.Visible = false;
            closeButton.Visible = false;
            gameOverLabel.Visible = false;
            lengthLabel.Visible = false;    
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
