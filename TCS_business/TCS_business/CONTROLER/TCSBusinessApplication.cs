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
    public class TCSBusinessApplication
    {
        static TCSBusinessApplication instance;
        GuiManager guiManager;


        public GuiManager GuiManager
        {
            get { return guiManager; }
        }


        GameConfig gameConfigData;
        Game game;
        public static TCSBusinessApplication getInstance()
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
                guiManager = new GuiManager();
                guiManager.InitializeMainWindow();
                gameConfigData = new GameConfigBuilder().build();
               
            }
            catch (Exception e)
            {
                guiManager.ShowErrorMessage("In initializing:" + e.Message);
            }

        }
        public void RunGame()
        {
            try
            {
                game = new Game(gameConfigData);
                game.Start();
            }catch(Exception e){
                guiManager.ShowErrorMessage("Error during starting game");
            }
        }
        public void ShowGameConfigDialog()
        {
            gameConfigData = guiManager.ShowGameConfigDialog();
        }
        public void ShowAddPlayerDialog()
        {
            if (game.AllPlayersJoined())
            {
                guiManager.ShowMessage("All required players are present");
            }
            else
            {
                game.registerNewPlayer();
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

        internal GameConfig getLastConfigData()
        {
            return gameConfigData;
        }
    }
}
