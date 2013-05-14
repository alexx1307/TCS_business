using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS_business.MODEL;
using TCS_business.VIEW;
namespace TCS_business.CONTROLER
{

    
    public class GuiManager          //maybe should this class  use singleton pattern? 
    {
        MainWindow mainWindow;
        public void InitializeMainWindow() {
            mainWindow = new MainWindow();
        } 
        public void ShowMainWindow() {
            Application.Run(mainWindow);

            
        
        } // todo: pawel //pozostale wlasciwosci
        public GameConfig ShowGameConfigDialog() {
            GameConfigDialog gameConfigDialog = new GameConfigDialog();
            if (gameConfigDialog.ShowDialog() == DialogResult.OK)
            {
                return gameConfigDialog.getGameConfigData();
            }
            else return TCSBusinessApplication.getInstance().getLastConfigData();
        }
       
        public Player ShowAddPlayerDialog() {
            AddPlayer addPlayer = new AddPlayer();
            if (addPlayer.ShowDialog() == DialogResult.OK)
                return addPlayer.ResultPlayer;
            else
                return null;
        } 

        //todo: pawel proste funkcje zmieniajace stan okienka np umozliwienie lub zablokowanie wywolania jakichs okienek itd
        public void ShowErrorMessage(String msg) //mozesz zmienic te funkcje zeby poprawnie korzystala z watku od GUI - zrobilem ja na szybko gdy potrzebowalem
        {
            MessageBox.Show(msg);
            TCSBusinessApplication.Exit();
        }

        internal void EnableAddPlayerButton()  
        {
            throw new NotImplementedException();
        }

        internal void EnableRunGameButton()
        {
            throw new NotImplementedException();
        }

        internal void ShowMessage(string p)
        {
            MessageBox.Show(p);
        }
        internal void UpdateMainWindowButtons(ApplicationState appState)
        {
            switch (appState)
            {
                case ApplicationState.WAITING_FOR_PLAYERS:
                    mainWindow.EnableAddingPlayers();
                    mainWindow.DisableGameRun();
                    break;
                case ApplicationState.READY_FOR_GAME:
                    mainWindow.DisableAddingPlayers();
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
        public void UpdatePlayersList()
        {
            int playersNumber = TCSBusinessApplication.getInstance().game.PlayersNumber;
            String name = TCSBusinessApplication.getInstance().game.gameStateData.PlayersList.ElementAt(playersNumber-1).Name;
            switch(playersNumber)
            {
                case 1:
                    mainWindow.setPlayer1(name);
                    break;
                case 2:
                    mainWindow.setPlayer2(name);
                    break;
                case 3:
                    mainWindow.setPlayer3(name);
                    break;
                case 4:
                    mainWindow.setPlayer4(name);
                    break;
            }
        }
    }
}
