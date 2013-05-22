using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    class BoardGenerator
    {
        public static Board Generate()
        {

            Board board = new Board();

            board.Fields[0]= new StartField("Start");
            
            board.Fields[2] = new Chance("Chance1");
            board.Fields[7] = new Chance("Chance2");
            board.Fields[22] = new Chance("Chance3");
            board.Fields[33] = new Chance("Chance4");

            board.Fields[5] = new Railway("North");
            board.Fields[15] = new Railway("East");
            board.Fields[25] = new Railway("South");
            board.Fields[35] = new Railway("West");

            board.Fields[4] = new Tax("tax1");
            board.Fields[38] = new Tax("tax2");

            board.Fields[10] = new JailField("JAIL");

            board.Fields[20] = new FreeParking("Parking"); //w eurobiznesie tutaj jest parking
            board.Fields[30] = new FreeField(); //w eurobiznesie tutaj idzie się do więzienia
            for (int i = 0; i < Board.NOFIELDS; i++)
                if (board.Fields[i] == null)
                {
                    board.Fields[i] = new City("field no." + i.ToString());
                }

            for (int i = 0; i < Board.NOFIELDS; i++)
            {
                Console.WriteLine(board.Fields[i].Description);
            }
            return board;
        }

    }
}
