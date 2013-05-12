using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCS_business.CONTROLER
{
    public class TCSBusinessApplication
    {
        GuiManager guiManager;
        GameConfig gameConfigData;
        Game game;
        public void Initialize()
        {
            try
            {
                guiManager = GuiManager.getGUIManager();
                guiManager.InitializeMainWindow();
            }
            catch (Exception e)
            {
                guiManager.ShowErrorMessage("In initializing:" + e.Message);
            }

        }
        public void RunGame()
        {

            Debug.Assert(gameConfigData != null);
            try
            {
                game = GameBuilder.build();
            }
            catch (Exception e)
            {
                guiManager.ShowErrorMessage(e.Message);
            }
            game.Start();

        }
        public void ShowGameConfigDialog()
        {
            gameConfigData = guiManager.ShowGameConfigDialog();
            if (gameConfigData != null)
            {
                guiManager.EnableAddPlayerButton();
            }
        }
        public void ShowAddPlayerDialog()
        {
            Debug.Assert(game != null);
            if (game.AllPlayersJoined())
            {
                guiManager.ShowMessage("All required players are present");
            }
            else
            {
                guiManager.ShowAddPlayerDialog();
                if (game.AllPlayersJoined())
                {
                    guiManager.EnableRunGameButton();
                    guiManager.DisableAddPlayerButton(); //temporarily before we will make net application
                }
            }

            
        }
        public void Run()
        {
            guiManager.ShowMainWindow();

        }

        internal static void Exit()
        {
            Environment.Exit(1);
        }
    }
}
