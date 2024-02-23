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
            exitButton.Visible = false;
            newButton.Visible = false;
            //removes this screen and start the GameScreen
            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);
            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);
            
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //ends the application
            Application.Exit();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
