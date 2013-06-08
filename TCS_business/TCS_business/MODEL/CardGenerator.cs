using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS_business.MODEL
{
    public class CardGenerator
    {
        public static Card[] Generate()
        {
            Card[] cards = new Card[Deck.NOCARDS];
            cards[0] = new GoToJailCard();
            cards[1] = new GetCard("You won a beauty contest. You get 200$", 200);
            cards[2] = new GoOutFromJailCard();
            cards[3] = new PayCard("You pay a contribution to the hospital in the amount of 400$", 400);
            cards[4] = new MoveCard("You go back to START", 0);
            cards[5] = new GetCard("You receive an annual pension of 200$", 200);
            cards[6] = new PayCard("You've been drinking during working hours, pay 40$ fine.", 40);
            cards[7] = new MoveCard("You go to East Railway", 15);
            cards[8] = new GetCard("You get a tax refund income 40$.", 40);
            cards[9] = new GoOutFromJailCard();
            cards[10] = new PayCard("The term of office for a fast ride. You pay 30$.", 30);
            cards[11] = new MoveCard("You go back to Madrid", 14); 
            cards[12] = new GetCard("Bank pays you a percentage of 100$", 100);
            cards[13] = new PayCard("You pay a fee for damage 300$.", 300);
            cards[14] = new GetCard("You get to drop 200$", 200);
            cards[15] = new MoveCard("You go to Wien", 39);
            cards[16] = new GoToJailCard();
            cards[17] = new GetCard("Well solved crossword puzzle. As I get a 200$ reward.", 200);
            cards[18] = new PayCard("You pay the insurance premium in the amount of $ 20.", 20);
            cards[19] = new PayCard("You pay medical expenses in the amount of $ 20.", 20);
            return cards;
        }
    }
}

