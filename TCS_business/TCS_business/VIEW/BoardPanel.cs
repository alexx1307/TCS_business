using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCS_business.MODEL;

namespace TCS_business.VIEW
{
    public partial class BoardPanel : UserControl
    {
        public BoardPanel()
        {
            InitializeComponent();
        }
        public void Initialize(Board board)
        {
            if(Board.NOFIELDS%4 !=0){
                throw new Exception("Cannot create board - incorrect fields number");
            }

        }
    }
}
