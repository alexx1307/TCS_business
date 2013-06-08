using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TCS_business.MODEL
{
    class BoardGenerator
    {
        public static Board Generate()
        {
            Country[] countries = new Country[8];
            countries[0] = new Country("Greece", Color.LavenderBlush);
            countries[1] = new Country("Italy", Color.LightGreen);
            countries[2] = new Country("Spain", Color.LightSkyBlue);
            countries[3] = new Country("Great Britain", Color.LightPink);
            countries[4] = new Country("Benelux", Color.PaleGoldenrod);
            countries[5] = new Country("Sweden", Color.PaleTurquoise);
            countries[6] = new Country("Germany", Color.SandyBrown);
            countries[7] = new Country("Austria", Color.Gray);
            Board board = new Board();

            board.Fields[0]= new StartField("Start");

            board.Fields[2] = new Chance("Chance1", 2);
            board.Fields[7] = new Chance("Chance2", 7);
            board.Fields[17] = new Chance("Chance3", 17);
            board.Fields[22] = new Chance("Chance4", 22);
            board.Fields[33] = new Chance("Chance5", 33);
            board.Fields[36] = new Chance("Chance6", 36);

            board.Fields[5] = new Railway("North");
            board.Fields[15] = new Railway("East");
            board.Fields[25] = new Railway("South");
            board.Fields[35] = new Railway("West");

            board.Fields[4] = new Tax("tax1");
            board.Fields[38] = new Tax("tax2");

            board.Fields[10] = new JailField("JAIL");

            board.Fields[20] = new FreeParking("Parking");
            board.Fields[30] = new FreeField();

            board.Fields[12] = new Powerhouse("Power");
            board.Fields[28] = new Powerhouse("Waterworks");

            board.Fields[1] = new City("Saloniki",countries[0]);
            board.Fields[3] = new City("Athens", countries[0]);

            board.Fields[6] = new City("Naples", countries[1]);
            board.Fields[8] = new City("Milan", countries[1]);
            board.Fields[9] = new City("Rome", countries[1]);

            board.Fields[11] = new City("Barcelona", countries[2]);
            board.Fields[13] = new City("Seville", countries[2]);
            board.Fields[14] = new City("Madrid", countries[2]);

            board.Fields[16] = new City("Liverpool", countries[3]);
            board.Fields[18] = new City("Glasgow", countries[3]);
            board.Fields[19] = new City("London", countries[3]);

            board.Fields[21] = new City("Rotterdam", countries[4]);
            board.Fields[23] = new City("Brussels", countries[4]);
            board.Fields[24] = new City("Amsterdam", countries[4]);

            board.Fields[26] = new City("Malmo", countries[5]);
            board.Fields[27] = new City("Goteborg", countries[5]);
            board.Fields[29] = new City("Stockholm", countries[5]);

            board.Fields[31] = new City("Frankfurt", countries[6]);
            board.Fields[32] = new City("Cologne", countries[6]);
            board.Fields[34] = new City("Bonn", countries[6]);

            board.Fields[37] = new City("Innsbruck", countries[7]);
            board.Fields[39] = new City("Wien", countries[7]);

            return board;
        }

    }
}
