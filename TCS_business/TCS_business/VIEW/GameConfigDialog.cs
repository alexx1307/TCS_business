using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCS_business.VIEW
{
    public partial class GameConfigDialog : Form
    {
        public GameConfigDialog()
        {
            InitializeComponent();

        }

        internal CONTROLER.GameConfig getGameConfigData()
        {
            return new CONTROLER.GameConfigBuilder().setRemainingPlayersNumber((int)playersNumber.Value).setTurnTime(new TimeSpan(0, (int)minutes.Value, (int)seconds.Value)).build();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo: Zygmunt - walidacja z uzyciem statycznych pol z gameConfig - w wypadku niepomyslnej walidacji wiadomosc i do poprawy :)
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
