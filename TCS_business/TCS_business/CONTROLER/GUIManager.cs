using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS_business.MODEL;

namespace TCS_business.CONTROLER
{

    class GuiManager          //maybe should this class  use singleton pattern? 
    {

        public static GuiManager getGUIManager()
        {
            return new GuiManager();
        }
        public int InitializeMainWindow() { throw new NotImplementedException(); } //todo: pawel //returns 0 if the window is correctly initialized  //todo: pawel
        public void ShowMainWindow() { throw new NotImplementedException(); } // todo: pawel
        public GameConfig ShowGameConfigDialog() { throw new NotImplementedException(); } //todo: Anita //if config data is filled incorrectly this method should return null!
        public Player ShowAddPlayerDialog() { throw new NotImplementedException(); } // todo: Anita //napisalas ze juz zrobilas wiec wystarczy tylko podpiac pod te metode 
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
