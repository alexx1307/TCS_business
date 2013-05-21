using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    class BoardGenerator
    {
        Board Generate()
        {
            Board board = new Board();
            for (int i = 0; i < 40; i++)
                board.Fields[i] = new City("field no." + i.ToString(), i);

            return board;
        }

    }
}
