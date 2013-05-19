using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.CONTROLER;
using TCS_business.MODEL;

namespace TCS_business.VIEW
{
    public partial class MainWindow : Form
    {
        private List<System.Drawing.Color> coloursList = new List<System.Drawing.Color>();
        public MainWindow()
        {
            InitializeComponent();
            coloursList.Add(System.Drawing.Color.Red);
            coloursList.Add(System.Drawing.Color.Green);
            coloursList.Add(System.Drawing.Color.Blue);
            coloursList.Add(System.Drawing.Color.Yellow);
            coloursList.Add(System.Drawing.Color.Purple);

        }

        private void gameSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationController.Instance.ShowGameConfigDialog();

        }

        private void registerNewPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationController.Instance.ShowAddPlayerDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONTROLER.ApplicationController.Exit();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationController.Instance.RunGame();

        }
        internal void setPlayers(List<Player> list)
        {
            this.Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < list.Count(); i++)
                    PlayersListPanel.Controls.Add(new PlayerInfo(list[i].Name,list[i].Cash,coloursList[list.Count()]));
            });
            //UpdateCash(list);
        }

        private void UpdateCash(List<Player> list)
        {
            this.Invoke((MethodInvoker)delegate
            {
               
            });
        }

        internal void EnableAddingPlayers()
        {
            registerNewPlayerToolStripMenuItem.Enabled = true;
        }

        internal void DisableGameRun()
        {
            runToolStripMenuItem.Enabled = false;
        }

        internal void EnsableGameRun()
        {
            runToolStripMenuItem.Enabled = true;
        }

        internal void DisableAddingPlayers()
        {
            registerNewPlayerToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.OnTimeoutEvent(sender, null);
        }

    }
}
