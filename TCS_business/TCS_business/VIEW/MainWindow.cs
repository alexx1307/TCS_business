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
        private Dictionary<Player, VIEW.PlayerInfo> playersPanelsMap = new Dictionary<Player, VIEW.PlayerInfo>();
        public Dictionary<Player, VIEW.PlayerInfo> PlayersPanelsMap { get { return playersPanelsMap; } }

        public BoardPanel BoardPanel
        {
            get { return boardPanel1; }
        }

        public MainWindow()
        {
            InitializeComponent();
            Text = "TCS Business";
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
            DialogResult dialogResult = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) CONTROLER.ApplicationController.Exit();
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
                PlayerInfo PlayerPanel = new PlayerInfo(list[i].Name, list[i].Cash, list[i].Color, list[i].Time);
                PlayerPanel.Location = new Point(0, i * 74);
                playersListPanel.Controls.Add(PlayerPanel);
                playersPanelsMap.Add(list[i], PlayerPanel);
            }
        }

        public static Color[] OccupiedColors = new Color[9];
        static int nr = 0;

        public static void SetColor(Color c)
        {
            OccupiedColors[nr++] = c;
        }

        internal void EnableAddingPlayers()
        {
            registerNewPlayerToolStripMenuItem.Enabled = true;
        }

        internal void DisableGameRun()
        {
            runToolStripMenuItem.Enabled = false;
        }

        internal void EnableGameRun()
        {
            runToolStripMenuItem.Enabled = true;
        }

        internal void EnableBuyButton()
        {
            Buy.Enabled = true;
        }

        internal void DisableBuyButton()
        {
            Buy.Enabled = false;
        }

        internal void EnableEndTurnButton()
        {
            TurnEnd.Enabled = true;
        }

        internal void DisableGameSettings()
        {
            gameSettingsToolStripMenuItem.Enabled = false;
        }

        internal void DisableAddingPlayers()
        {
            registerNewPlayerToolStripMenuItem.Enabled = false;
        }

        private void TurnEnd_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            Game.TurnEndEvent(sender, null);
        }

        public void ChangeCommunicate(string s)
        {
            Action<int> updateAction = new Action<int>((value) => textBox1.Text = s);
            textBox1.Invoke(updateAction, 32);
        }

        public void ChangeDice(int i, int j)
        {
            if (i == 1) dice1.Image = global::TCS_business.Properties.Resources._1;
            else if (i == 2) dice1.Image = global::TCS_business.Properties.Resources._2;
            else if (i == 3) dice1.Image = global::TCS_business.Properties.Resources._3;
            else if (i == 4) dice1.Image = global::TCS_business.Properties.Resources._4;
            else if (i == 5) dice1.Image = global::TCS_business.Properties.Resources._5;
            else if (i == 6) dice1.Image = global::TCS_business.Properties.Resources._6;
            if (j == 1) dice2.Image = global::TCS_business.Properties.Resources._1;
            else if (j == 2) dice2.Image = global::TCS_business.Properties.Resources._2;
            else if (j == 3) dice2.Image = global::TCS_business.Properties.Resources._3;
            else if (j == 4) dice2.Image = global::TCS_business.Properties.Resources._4;
            else if (j == 5) dice2.Image = global::TCS_business.Properties.Resources._5;
            else if (j == 6) dice2.Image = global::TCS_business.Properties.Resources._6;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            fieldInfoPanel1.Visible = false;
        }

        internal void UpdateFieldInfoPanel(Field field, bool shouldBuyButtonBeSeen, bool shouldPledgeButtonBeSeen)
        {
            MessageBox.Show("DUPA");
            this.fieldInfoPanel1.UpdateContent(field, shouldBuyButtonBeSeen, shouldPledgeButtonBeSeen);
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            ApplicationController.Instance.Game.BuyField();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }
        public void ShowCard(string s)
        {
            label1.Text = s;
            label1.Visible = true;
            label2.Text = "Chance";
            label2.Visible = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().Show();
        }

        public void ShowPayInfo(string s)
        {
            label2.Text = s;
            label2.Visible = true;
        }
    }
}
