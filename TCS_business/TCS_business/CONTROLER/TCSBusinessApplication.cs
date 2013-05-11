using System;
using System.Collections.Generic;
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
            if (gameConfigData == null)
            {
                gameConfigData = guiManager.ShowGameConfigDialog(); // in particular gameConfigData could still be null
            }
            else
            {
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
        }
        public void ShowGameConfigDialog()
        {
            gameConfigData = guiManager.ShowGameConfigDialog();
        }
        public void ShowAddPlayerDialog()
        {
            if (game.isNextPlayerRequired())
            {
                game.AddNextPlayer(guiManager.ShowAddPlayerDialog());
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
