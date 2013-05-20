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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            coloursList.Add(System.Drawing.Color.Red);
            coloursList.Add(System.Drawing.Color.Green);
            coloursList.Add(System.Drawing.Color.Blue);
            coloursList.Add(System.Drawing.Color.Yellow);
            coloursList.Add(System.Drawing.Color.Purple);

=======
>>>>>>> 7ad7c9a4f1020bf980ee7d463e72f792ef81d688
=======
>>>>>>> 7ad7c9a4f1020bf980ee7d463e72f792ef81d688
=======
>>>>>>> 7ad7c9a4f1020bf980ee7d463e72f792ef81d688
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
<<<<<<< HEAD
                PlayersListPanel.Controls.Clear();
                for (int i = 0; i < list.Count(); i++)
                {
                    PlayerInfo PlayerInfoControl = new PlayerInfo(list[i].Name, list[i].Cash, coloursList[i]);
                    PlayerInfoControl.Location = new Point(0, i*74);
                    PlayersListPanel.Controls.Add(PlayerInfoControl);
                }
            });
            //UpdateCash(list);
=======
                tab[2 * i].Text = list.ElementAt(i).Name;
                //tab[2 * i + 1].Text = list.Cash.ToString();
            }
            if (0 < list.Count()) pictureBox1.BackColor = OccupiedColors[0];
            if (1 < list.Count()) pictureBox2.BackColor = OccupiedColors[1];
            if (2 < list.Count()) pictureBox3.BackColor = OccupiedColors[2];
            if (3 < list.Count()) pictureBox4.BackColor = OccupiedColors[3];
            UpdateCash(list);
>>>>>>> 7ad7c9a4f1020bf980ee7d463e72f792ef81d688
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
