namespace Briscola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Game : GameResult
{
    
    public Game(
        int id,
        int idPlayer1,
        int idPlayer2):base(id, idPlayer1, idPlayer2)
    {

    }

    public void InitialDeal(Deck deck, Hand hand1, Hand hand2){
        for(int i = 0; i < 3; i++)
        {
            hand1.CardToHand(deck.drawCard());
            hand2.CardToHand(deck.drawCard());
        }
    }

    

}