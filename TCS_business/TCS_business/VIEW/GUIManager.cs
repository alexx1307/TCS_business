using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS_business.CONTROLER;
using TCS_business.MODEL;
using TCS_business.VIEW;
namespace TCS_business.VIEW
{


    public class GuiManager : IView
    {
        MainWindow mainWindow;


        public void InitializeMainWindow()
        {
            mainWindow = new MainWindow();
        }
        public void ShowMainWindow()
        {
            Thread guiThread = new Thread((ThreadStart)delegate
            {
                Application.Run(mainWindow);
            });
            guiThread.Start();

        }


        public void InitializeGamePanel(Board board)
        {
            mainWindow.BoardPanel.Initialize(board);
        }

        public void UpdatePlayersList(List<Player> list)
        {
            mainWindow.Invoke((MethodInvoker)delegate { mainWindow.setPlayers(list); });
            //todo: Zygmunt: to ma nie byc wywolywane z main window 
            //tylko main window ma posiadac panel odpowiedzialny za listowanie graczy i jego metode masz wywolac.
            //poza tym zmien nazwe tej metody (jakis update)
        }

        public void UpdateFieldState(Field field)
        {
            throw new NotImplementedException();
        }

        public void UpdateTurnStatePanel(TurnState turnState, GameState gameState)
        {
            throw new NotImplementedException();
        }

        public void ShowLoginDialog()
        {
            AddPlayerDialog addPlayerDialog = new AddPlayerDialog();

            addPlayerDialog.Show();
        }

        public void ShowConfigDialog(GameConfig gameConfig)
        {
            GameConfigDialog configDialog = new GameConfigDialog();
            configDialog.SetGameConfig(gameConfig);
            configDialog.Show();
        }

        /// <summary>
        /// This method finds proper player's panel and updates the data (money etc.)
        /// </summary>
        /// <param name="player"></param>
        public void UpdatePlayerPanel(Player player)
        {
            mainWindow.PlayersPanelsMap[player].Update(player);
        }

        public void UpdateTimeLeftPanel(TimeSpan timeLeft)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string msg)
        {
            mainWindow.BeginInvoke((MethodInvoker)delegate { MessageBox.Show(msg); });

            //mainWindow.ChangeCommunicate(msg);
        }

        public void AdjustButtonsAvailability(ApplicationState appState)
        {
            switch (appState)
            {
                case ApplicationState.WAITING_FOR_PLAYERS:
                    mainWindow.EnableAddingPlayers();
                    mainWindow.DisableGameRun();
                    break;
                case ApplicationState.READY_FOR_GAME:
                    //mainWindow.DisableAddingPlayers();
                    mainWindow.EnsableGameRun();
                    break;
                case ApplicationState.GAME_IN_PROGRESS:
                    mainWindow.DisableAddingPlayers();
                    mainWindow.DisableGameRun();
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false, "Unknown enum type");
                    break;
            }
        }

        public void DisableAddingPlayers()
        {
            mainWindow.DisableAddingPlayers();
        }

        public void EnableAddingPlayers()
        {
            mainWindow.EnableAddingPlayers();
        }

        public void UpdateBoard(Board board)
        {
            mainWindow.BoardPanel.Update(board);
        }

        public void UpdateDice(int i, int j)
        {
            mainWindow.ChangeDice(i, j);
        }

        public void UpdateCommunicate(string s)
        {
            mainWindow.BeginInvoke((MethodInvoker)delegate { mainWindow.ChangeCommunicate(s); });
        }


        public void ShowBuyPrompt()
        {
            BuyDialog buyDialog = new BuyDialog();
            buyDialog.ShowDialog();
            if (buyDialog.DialogResult == DialogResult.Yes)
            {
                ApplicationController.Instance.Game.BuyField();
            }
            else
            {
                ApplicationController.Instance.Game.Auction();
            }
        }

        public void ShowTurnPrompt(string playerName)
        {
            MessageBox.Show("Tura gracza " + playerName);
        }

        public void ShowCardPrompt(string s)
        {
            CardDialog cardDialog = new CardDialog(s);
            cardDialog.ShowDialog();
        }


        public void UpdateFieldInfoPanel(Field field, bool shouldBuyButtonBeSeen, bool shouldPledgeButtonBeSeen)
        {
            mainWindow.UpdateFieldInfoPanel(field, shouldBuyButtonBeSeen, shouldPledgeButtonBeSeen);
        }
    }
}
