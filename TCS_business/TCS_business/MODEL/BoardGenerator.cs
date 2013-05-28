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

            board.Fields[20] = new FreeParking("Parking");
            board.Fields[30] = new FreeField();

            board.Fields[1] = new City("Thessaloniki");
            board.Fields[3] = new City("Athens");

            board.Fields[6] = new City("Naples");
            board.Fields[8] = new City("Milan");
            board.Fields[9] = new City("Rome");

            board.Fields[11] = new City("Barcelona");
            board.Fields[13] = new City("Seville");
            board.Fields[14] = new City("Madrid");

            board.Fields[16] = new City("Liverpool");
            board.Fields[18] = new City("Glasgow");
            board.Fields[19] = new City("London");

            board.Fields[21] = new City("Rotterdam");
            board.Fields[23] = new City("Brussels");
            board.Fields[24] = new City("Amsterdam");

            board.Fields[26] = new City("Malmo");
            board.Fields[27] = new City("Goteborg");
            board.Fields[26] = new City("Stockholm");

            board.Fields[31] = new City("Frankfurt");
            board.Fields[32] = new City("Cologne");
            board.Fields[34] = new City("Bonn");

            board.Fields[37] = new City("Innsbruck");
            board.Fields[39] = new City("Wien");

            for (int i = 0; i < Board.NOFIELDS; i++)
                if (board.Fields[i] == null)
                {
                    board.Fields[i] = new City("field no." + i.ToString());
                }
            return board;
        }

    }
}
