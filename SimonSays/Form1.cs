﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        //List to store pattern
        public static List<int> patternList = new List<int>();

        public static SoundPlayer green = new SoundPlayer (Properties.Resources.green);
        public static SoundPlayer yellow = new SoundPlayer(Properties.Resources.yellow);
        public static SoundPlayer blue = new SoundPlayer(Properties.Resources.blue);
        public static SoundPlayer red = new SoundPlayer(Properties.Resources.red);
        public static SoundPlayer gameOver = new SoundPlayer(Properties.Resources.mistake);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //launches menu screen when Form1 loads 
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
