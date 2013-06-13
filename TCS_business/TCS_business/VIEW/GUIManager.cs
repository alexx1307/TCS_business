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
        public void HideFieldInfoPanel()
        {
            mainWindow.HideFieldInfoPanel();
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
                    mainWindow.EnableGameRun();
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

        public void DisableGameSettings()
        {
            mainWindow.DisableGameSettings();
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

        public void EnableBuyButton()
        {
            mainWindow.BeginInvoke((MethodInvoker)delegate { mainWindow.EnableBuyButton(); });
        }

        public void DisableBuyButton()
        {
            mainWindow.BeginInvoke((MethodInvoker)delegate { mainWindow.DisableBuyButton(); });
        }

        public void EnableEndTurnButton()
        {
            mainWindow.BeginInvoke((MethodInvoker)delegate { mainWindow.EnableEndTurnButton(); });
        }

        public void ShowTurnPrompt(string playerName)
        {
            MessageBox.Show("Turn of player: " + playerName);
        }

        public void ShowCardPrompt(string s)
        {
            mainWindow.BeginInvoke((MethodInvoker)delegate { mainWindow.ShowCard(s); });
        }

        public void ShowInformation(string s)
        {
            mainWindow.BeginInvoke((MethodInvoker)delegate { mainWindow.ShowInformation(s); });
        }

        public void UpdateFieldInfoPanel(Field field, bool shouldBuyButtonBeSeen, bool shouldPledgeButtonBeSeen)
        {
            mainWindow.UpdateFieldInfoPanel(field, shouldBuyButtonBeSeen, shouldPledgeButtonBeSeen);
        }

        public void ShowPayInfo(string s)
        {
            mainWindow.BeginInvoke((MethodInvoker)delegate { mainWindow.ShowPayInfo(s); });
        }


        public int ShowAuctionDialog(Player currentPlayer, IPurchasable field, int minPrice)
        {
            AuctionDialog auctionDialog = new AuctionDialog(currentPlayer.Name, currentPlayer.Color, field.Name, minPrice, currentPlayer.Cash);
            auctionDialog.ShowDialog();
            return auctionDialog.Result;
        }
    }
}
