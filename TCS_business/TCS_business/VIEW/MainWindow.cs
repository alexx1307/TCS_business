using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.CONTROLER;

namespace TCS_business.VIEW
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void gameSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCSBusinessApplication.GetInstance().ShowGameConfigDialog();

        }

        private void registerNewPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCSBusinessApplication.GetInstance().ShowAddPlayerDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONTROLER.TCSBusinessApplication.Exit();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCSBusinessApplication.GetInstance().RunGame();

        }
        internal void setPlayers()
        {
            Label[] tab = new Label[2 * 4];
            tab[0] = label8; tab[1] = label12;
            tab[2] = label9; tab[3] = label13;
            tab[4] = label10; tab[5] = label14;
            tab[6] = label11; tab[7] = label15;
            for (int i = 0; i < TCSBusinessApplication.GetInstance().game.gameStateData.PlayersList.Count(); i++)
            {
                tab[2 * i].Text = TCSBusinessApplication.GetInstance().game.gameStateData.PlayersList.ElementAt(i).Name;
                tab[2 * i + 1].Text = TCSBusinessApplication.GetInstance().game.gameStateData.PlayersList.ElementAt(i).Cash.ToString();
            }
        }

        internal void UpdateCash()
        {
            this.Invoke((MethodInvoker)delegate
            {
                Label[] tab = new Label[4];
                tab[0] = label12; tab[1] = label13;
                tab[2] = label14; tab[3] = label15;
                for (int i = 0; i < TCSBusinessApplication.GetInstance().game.gameStateData.PlayersList.Count(); i++)
                {
                    tab[i].Text = TCSBusinessApplication.GetInstance().game.gameStateData.PlayersList.ElementAt(i).Cash.ToString();
                    tab[i].Invalidate();
                    tab[i].Update();
                    tab[i].Refresh();
                }
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

    }
}
