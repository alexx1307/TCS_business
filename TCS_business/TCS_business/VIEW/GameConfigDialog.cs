using System;
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

            playersNumber.Maximum = MODEL.GameConfig.maxPlayersNumber;
            playersNumber.Minimum = MODEL.GameConfig.minPlayersNumber;
            playersNumber.Value = MODEL.GameConfig.defaultPlayersNumber;

            playerTime.Minimum = MODEL.GameConfig.minPlayerTime;
            playerTime.Maximum = MODEL.GameConfig.maxPlayerTime;
            playerTime.Value = MODEL.GameConfig.defaultPlayerTime;

            cash.Minimum = MODEL.GameConfig.minStartCash;
            cash.Maximum = MODEL.GameConfig.maxStartCash;
            cash.Value = MODEL.GameConfig.defaultStartCash;
        }

        /// <summary>
        /// Sets configuration of the game. 
        /// This method also updates the minimum value of the players 
        ///     - it cannot be less than actual number of registered players
        /// </summary>
        /// <param name="gameConfig">The current configuration of the game</param>
        public void SetGameConfig(GameConfig gameConfig)
        {
            playerTime.Value = gameConfig.PlayerTime;
            playersNumber.Value = gameConfig.PlayersNumber;
            cash.Value = gameConfig.StartCash;
            playersNumber.Minimum = Math.Max(
                MODEL.GameConfig.minPlayersNumber, 
                ApplicationController.Instance.Game.GameState.PlayersList.Count);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            ApplicationController.Instance.SetNewGameConfig(
                new GameConfig((int)playersNumber.Value, (int)playerTime.Value, (int)cash.Value));
        }
    }
}
