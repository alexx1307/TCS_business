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
        public MainWindow()
        {
            InitializeComponent();
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
            Label[] tab = new Label[2 * 4];
            tab[0] = label8; tab[1] = label12;
            tab[2] = label9; tab[3] = label13;
            tab[4] = label10; tab[5] = label14;
            tab[6] = label11; tab[7] = label15;
            for (int i = 0; i < list.Count(); i++)
            {
                tab[2 * i].Text = list.ElementAt(i).Name;
                //tab[2 * i + 1].Text = list.Cash.ToString();
            }
            if (0 < list.Count()) pictureBox1.BackColor = OccupiedColors[0];
            if (1 < list.Count()) pictureBox2.BackColor = OccupiedColors[1];
            if (2 < list.Count()) pictureBox3.BackColor = OccupiedColors[2];
            if (3 < list.Count()) pictureBox4.BackColor = OccupiedColors[3];
            UpdateCash(list);
        }

        public static Color[] OccupiedColors = new Color[4];
        static int nr = 0;

        public static void SetColor(Color c)
        {
            OccupiedColors[nr++] = c;
        }


        private void UpdateCash(List<Player> list)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Label[] tab = new Label[4];
                tab[0] = label12; tab[1] = label13;
                tab[2] = label14; tab[3] = label15;
                for (int i = 0; i < list.Count(); i++)
                {
                    tab[i].Text = list.ElementAt(i).Cash.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Game.OnTimeoutEvent(sender, null);
            this.Close();
        }

    }
}
