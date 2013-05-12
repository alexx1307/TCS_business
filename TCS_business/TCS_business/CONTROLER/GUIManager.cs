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
        Form mainWindow;
        public void InitializeMainWindow() {
            mainWindow = new MainWindow();
        } 
        public void ShowMainWindow() {
            Application.Run(mainWindow);

            
        
        } // todo: pawel
        public GameConfig ShowGameConfigDialog() {
            GameConfigDialog gameConfigDialog = new GameConfigDialog();
            if (gameConfigDialog.ShowDialog() == DialogResult.OK)
            {
                return gameConfigDialog.getGameConfigData();
            }
            else return TCSBusinessApplication.getInstance().getLastConfigData();
        }
<<<<<<< HEAD
        public Player ShowAddPlayerDialog() { throw new NotImplementedException(); } // todo: Anita //napisalas ze juz zrobilas wiec wystarczy tylko podpiac pod te metode 
=======
        public int InitializeMainWindow() { throw new NotImplementedException(); } //todo: pawel //returns 0 if the window is correctly initialized  //todo: pawel
        public void ShowMainWindow() { throw new NotImplementedException(); } // todo: pawel
        public GameConfig ShowGameConfigDialog() { 
            throw new NotImplementedException(); 
        } //todo: Anita //if config data is filled incorrectly this method should return null!

        public Player ShowAddPlayerDialog() {
            new TCS_business.VIEW.AddPlayer();
            return null;
        } // todo: Anita //napisalas ze juz zrobilas wiec wystarczy tylko podpiac pod te metode 

>>>>>>> b46f265a2b796ac9e204f6cd90e7299396979c3e
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
            throw new NotImplementedException();
        }

        internal void DisableAddPlayerButton()
        {
            throw new NotImplementedException();
        }

        //this method invokes GUI methods to update and repaint main game view 
        //(when for example turn was changed or someone buy something and it's cash changed)
        void UpdateGameView()   
        {
            throw new NotImplementedException();
        }
    }
}
