﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //TODO: remove this screen and start the GameScreen
            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);
            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);

            exitButton.Visible = false;
            newButton.Visible = false;
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: end the application
            Application.Exit();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
