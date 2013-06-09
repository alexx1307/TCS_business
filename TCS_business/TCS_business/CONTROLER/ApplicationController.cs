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
        private Game game;
        public Game Game { get { return game; } }
        private IView guiManager;

        public static ApplicationController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ApplicationController();
                return instance;
            }
        }

        private ApplicationController() { }

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
                guiManager.EnableEndTurnButton();
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
            if (gameConfig.PlayersNumber != game.PlayersNumber)
            {
                appState = ApplicationState.WAITING_FOR_PLAYERS;
                guiManager.AdjustButtonsAvailability(appState);
            }
            else guiManager.DisableAddingPlayers();
            game.GameConfig = gameConfig;
            foreach (Player p in game.GameState.PlayersList)
            {
                p.Cash = gameConfig.StartCash;
                p.Time = new TimeSpan(0, gameConfig.PlayerTime, 0);
                guiManager.UpdatePlayerPanel(p);
            }
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

        public void RegisterNewPlayer(string s, System.Drawing.Color colour)
        {
            game.RegisterNewPlayer(new Player(s, game.NextPlayerId(), colour, game.GameConfig.StartCash, game.GameConfig.PlayerTime));
            if (game.AllPlayersJoined())
            {
                appState = ApplicationState.READY_FOR_GAME;
                guiManager.DisableAddingPlayers();
                guiManager.AdjustButtonsAvailability(appState);
            }
            else guiManager.EnableAddingPlayers();
            guiManager.UpdatePlayersList(game.GameState.PlayersList);
        }

        internal void UpdateBoardView(Board board)
        {
            guiManager.UpdateBoard(board);
        }
        internal void InitializeGamePanel(Board board)
        {
            guiManager.InitializeGamePanel(board);
        }
        internal void UpdatePlayerDataView(Player player)
        {
            guiManager.UpdatePlayerPanel(player);
        }
        internal void RollDice(Tuple<int, int> meshes)
        {
            guiManager.UpdateDice(meshes.Item1, meshes.Item2);
        }
        internal void SendMessage(string msg)
        {
            guiManager.UpdateCommunicate(msg);
            //guiManager.ShowMessage(msg);
        }

        //internal void ShowBuyPrompt()
        //{
        //    guiManager.ShowBuyPrompt();
        //}

        internal void ShowCardPrompt(string s)
        {
            guiManager.ShowCardPrompt(s);
        }

        internal void ShowTurnPrompt(string playerName)
        {
            guiManager.ShowTurnPrompt(playerName);
        }

        internal void EnableBuyButton()
        {
            guiManager.EnableBuyButton();
        }

        internal void DisableBuyButton()
        {
            guiManager.DisableBuyButton();
        }

        internal void DisableGameSettings()
        {
            guiManager.DisableGameSettings();
        }

        internal void UpdateFieldInfoPanel(Field field, bool shouldBuyButtonBeSeen, bool shouldPledgeButtonBeSeen)
        {
            guiManager.UpdateFieldInfoPanel(field, shouldBuyButtonBeSeen, shouldPledgeButtonBeSeen);
        }

        internal void ShowPayInfo(string s)
        {
            guiManager.ShowPayInfo(s);
        }
    }
}
