using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS_business.MODEL;

namespace TCS_business.CONTROLER
{

    class GuiManager 
    {
        public static GuiManager getGUIManager()
        {
            return new GuiManager();
        }
        public int InitializeMainWindow() { throw new NotImplementedException(); } //returns 0 if the window is correctly initialized  //todo: pawel
        public void ShowMainWindow() { throw new NotImplementedException(); } // todo: pawel
        public GameConfig ShowGameConfigDialog() { throw new NotImplementedException(); }
        public Player ShowAddPlayerDialog() { throw new NotImplementedException(); }
        public void ShowErrorMessage(String msg)
        {
            MessageBox.Show(msg);
            TCSBusinessApplication.Exit();
        }
    }
}
