﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS_business.MODEL;
using TCS_business.CONTROLER;
namespace TCS_business.VIEW
{
    public partial class GameConfigDialog : Form
    {
        public GameConfigDialog()
        {
            InitializeComponent();
        }
        public void SetGameConfigProperties(GameConfig gameConfig)
        {
            minutes.Value = gameConfig.TurnTime.Minutes;
            seconds.Value = gameConfig.TurnTime.Seconds;
            playersNumber.Value = gameConfig.PlayersNumber;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
            this.Close();
            ApplicationController.Instance.SetNewGameConfig(new GameConfig((int)playersNumber.Value, new TimeSpan(0, (int)minutes.Value, (int)seconds.Value)));
        }
    }
}
