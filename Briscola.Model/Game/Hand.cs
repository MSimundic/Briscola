namespace Briscola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Hand
{
    public List<Card> PlayerHand = new List<Card>(3);
    public Hand()
    {
        
    }

    public void CardToHand(Card card)
    {
        PlayerHand.Append(card);
    }

    public Card CardFromHand(int id)
    {
        Card cardToThrow = new Card(PlayerHand[id].CardSuite, PlayerHand[id].CardRank);
        PlayerHand.RemoveAt(id);
        return cardToThrow;
    }
}