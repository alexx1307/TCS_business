using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS_business.MODEL;

namespace TCS_business.CONTROLER
{
    enum ApplicationState
    {
        WAITING_FOR_PLAYERS,
        READY_FOR_GAME,
        GAME_IN_PROGRESS

    }
    public class TCSBusinessApplication
    {
        static TCSBusinessApplication instance;
        GuiManager guiManager;
        ApplicationState appState;

        public GuiManager GuiManager
        {
            get { return guiManager; }
        }


        GameConfig gameConfigData;
        internal Game game;
        public static TCSBusinessApplication GetInstance()
        {
            if (instance == null)
                instance = new TCSBusinessApplication();
            return instance;
        }
        private TCSBusinessApplication()
        {
        }
        public void Initialize()
        {
            try
            {
                gameConfigData = new GameConfigBuilder().build();
                appState = ApplicationState.WAITING_FOR_PLAYERS;
                game = new Game(gameConfigData);
                guiManager = new GuiManager();
                guiManager.InitializeMainWindow();
                guiManager.UpdateMainWindowButtons(appState);
            }
            catch (Exception e)
            {
                guiManager.ShowErrorMessage("In initializing:" + e.Message);
            }

        }
        public void RunGame()
        {
            if (appState != ApplicationState.READY_FOR_GAME)
                guiManager.ShowMessage("Game cannot be launched right now");
            try
            {
                appState = ApplicationState.GAME_IN_PROGRESS;
                guiManager.UpdateMainWindowButtons(appState);
                game.Start();
            }
            catch (Exception e)
            {
                guiManager.ShowErrorMessage("Error during game executution: "+e.Message);
            }

        }
        public void ShowGameConfigDialog()
        {
            gameConfigData = guiManager.ShowGameConfigDialog();
            if (gameConfigData.PlayersNumber < game.PlayersNumber)
            {
                game.resetPlayerList();
                appState = ApplicationState.WAITING_FOR_PLAYERS;
                guiManager.UpdateMainWindowButtons(appState);
            }
            game.setGameConfigData(gameConfigData);
        }
      
        public void ShowAddPlayerDialog()
        {
            if (game.AllPlayersJoined())
            {
                guiManager.ShowMessage("All required players are present");
            }
            else
            {
                Player newPlayer = guiManager.ShowAddPlayerDialog();
                game.registerNewPlayer(newPlayer);
                if (game.AllPlayersJoined())
                {
                    appState = ApplicationState.READY_FOR_GAME;
                    guiManager.UpdateMainWindowButtons(appState);
                }
                guiManager.UpdatePlayersList();
            }

            
        }
        public void Run()
        {
            guiManager.ShowMainWindow();
            
        }

        internal static void Exit()
        {
            Environment.Exit(0);
        }

        internal GameConfig getLastConfigData()
        {
            return gameConfigData;
        }
    }
}
