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
            for (int i = 0; i < 40; i++) board.Fields[i] = null;

            board.Fields[0] = new StartField("Start");

            board.Fields[2] = new Chance();
            board.Fields[7] = new Chance();
            board.Fields[22] = new Chance();
            board.Fields[33] = new Chance();

            board.Fields[5] = new Railway();
            board.Fields[15] = new Railway();
            board.Fields[25] = new Railway();
            board.Fields[35] = new Railway();

            board.Fields[4] = new Tax();
            board.Fields[38] = new Tax();

            board.Fields[10] = new JailField("Więzienie");

            board.Fields[20] = new FreeParking("Parking"); //w eurobiznesie tutaj jest parking
            board.Fields[30] = new FreeField(); //w eurobiznesie tutaj idzie się do więzienia


            for (int i = 0; i < Board.NOFIELDS; i++)
                if(board.Fields[i] != null)
                    board.Fields[i] = new City("field no." + i.ToString());
            return board;
        }

    }
}
