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
            TCSBusinessApplication.getInstance().ShowGameConfigDialog();

        }

        private void registerNewPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCSBusinessApplication.getInstance().ShowAddPlayerDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONTROLER.TCSBusinessApplication.Exit();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCSBusinessApplication.getInstance().RunGame();
            
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
