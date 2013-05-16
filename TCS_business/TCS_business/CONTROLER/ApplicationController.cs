using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS_business.MODEL;
using TCS_business.VIEW;
namespace TCS_business.CONTROLER
{

    public class ApplicationController
    {
        private static ApplicationController instance;

        ApplicationState appState;
        Game game; //todo: 
        IView guiManager;
        public static ApplicationController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ApplicationController();
                return instance;
            }
        }
        private ApplicationController()
        {

        }
        public void InitializeAndRun()
        {

            appState = ApplicationState.WAITING_FOR_PLAYERS;

            guiManager = new GuiManager();
            guiManager.InitializeMainWindow();
            guiManager.ShowMainWindow();
            game = new Game();
            guiManager.AdjustButtonsAvailability(appState);

        }
        public void RunGame()
        {
            if (appState != ApplicationState.READY_FOR_GAME)
                guiManager.ShowMessage("Game cannot be launched right now");
            try
            {
                appState = ApplicationState.GAME_IN_PROGRESS;
                guiManager.AdjustButtonsAvailability(appState);
                game.Start();
            }
            catch (Exception e)
            {
                guiManager.ShowMessage("Error during game executution: " + e.Message);
                Exit();
            }

        }
        public void ShowGameConfigDialog()
        {
            guiManager.ShowConfigDialog(game.GameConfig);
        }
        public void SetNewGameConfig(GameConfig gameConfig)
        {
            if (game.GameConfig.PlayersNumber < game.PlayersNumber)
            {
                game.ResetPlayerList();
                appState = ApplicationState.WAITING_FOR_PLAYERS;
                guiManager.AdjustButtonsAvailability(appState);
            }
            game.GameConfig = gameConfig;
        }
        public void ShowAddPlayerDialog()
        {
            if (game.AllPlayersJoined())
            {
                guiManager.ShowMessage("All required players are present");
            }
            else
            {
                guiManager.ShowLoginDialog();
            }


        }

        public static void Exit()
        {
            Environment.Exit(0);
        }

        public void RegisterNewPlayer(string s)
        {
            game.RegisterNewPlayer(new Player(s, game.NextPlayerId()));
            if (game.AllPlayersJoined())
            {
                appState = ApplicationState.READY_FOR_GAME;
                guiManager.AdjustButtonsAvailability(appState);
            }
            guiManager.UpdatePlayersList(game.GameState.PlayersList);

        }

        internal void UpdateBoardView(Board board)
        {
            guiManager.UpdateBoard(board);
        }

        internal void UpdatePlayerDataView(Player player)
        {
            guiManager.UpdatePlayerPanel(player);
        }
    }
}
