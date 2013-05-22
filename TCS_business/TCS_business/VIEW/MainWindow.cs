﻿using System;
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
        private Dictionary<Player, VIEW.PlayerInfo> playersPanelsMap = new Dictionary<Player, VIEW.PlayerInfo>();
        public Dictionary<Player, VIEW.PlayerInfo> PlayersPanelsMap { get { return playersPanelsMap; } }
        
public BoardPanel BoardPanel
        {
            get { return boardPanel1; }
        }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void InitializeBoardPanel(Board board)
        {
            boardPanel1.Initialize(board);
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
            playersPanelsMap.Clear();
            playersListPanel.Controls.Clear();
            for (int i = 0; i < list.Count(); i++)
            {
                PlayerInfo PlayerPanel = new PlayerInfo(list[i].Name, list[i].Cash, list[i].Color);
                PlayerPanel.Location = new Point(0, i * 74);
                playersListPanel.Controls.Add(PlayerPanel);
                playersPanelsMap.Add(list[i], PlayerPanel);
            }
            //UpdateCash(list, playersPanelsMap);
        }

        public static Color[] OccupiedColors = new Color[9];
        static int nr = 0;

        public static void SetColor(Color c)
        {
            OccupiedColors[nr++] = c;
        }


        /* private void UpdateCash(List<Player> list, Dictionary<Player, VIEW.PlayerInfo> playersPanelsMap)
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
         }*/

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
