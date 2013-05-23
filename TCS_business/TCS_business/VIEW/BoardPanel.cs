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
        FieldPanel[] fieldPanels;
        public BoardPanel()
        {
            InitializeComponent();
        }
        public void Initialize(Board board)
        {
            if (Board.NOFIELDS % 4 != 0)
            {
                throw new Exception("Cannot create board - incorrect fields number");
            }
            else
            {
                fieldPanels = new FieldPanel[Board.NOFIELDS];
                for (int i = 0; i < Board.NOFIELDS; i++)
                {
                    fieldPanels[i] = new FieldPanel(board.Fields[i]);
                    this.Controls.Add(fieldPanels[i]);
                }
                Point origin = new Point(5, 5);
                byte fieldsPerSide = Board.NOFIELDS / 4;

                for (int i = 0; i <fieldsPerSide; i++)
                {
                    fieldPanels[i].Location = new Point(origin.X + i * fieldPanels[i].Width, origin.Y);
                }
                for (int i = 0; i < fieldsPerSide; i++)    //in work
                {
                    fieldPanels[i + fieldsPerSide].Location = new Point(origin.X + fieldsPerSide * fieldPanels[i].Width, origin.Y + i * fieldPanels[i].Height);
                }
                for (int i = 0; i < fieldsPerSide; i++)    //in work
                {
                    fieldPanels[i + 2*fieldsPerSide].Location = new Point(origin.X + (fieldsPerSide -i)* fieldPanels[i].Width , origin.Y + fieldsPerSide * fieldPanels[i].Height);
                }
                for (int i = 0; i < fieldsPerSide; i++)    //in work
                {
                    fieldPanels[i + 3 * fieldsPerSide].Location = new Point(origin.X, origin.Y + (fieldsPerSide-i) * fieldPanels[i].Height);
                }
            }

        }

        internal void Update(Board board)
        {
            
            for(int i=0;i<Board.NOFIELDS;i++)
            {
                FieldPanel fp = fieldPanels[i];
                fp.Update(board.Fields[i]);
                fp.setPawn(System.Drawing.Color.Transparent);
            }
            foreach (Player p in board.Positions.Keys)
            {
                int position = board.Positions[p];
                fieldPanels[position].setPawn(p.Color);
            }
        }
    }
}
