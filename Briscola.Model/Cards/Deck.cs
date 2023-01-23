namespace Briscola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Deck
{
    public List<Card> DeckOfCards = new List<Card>();

    public Deck()
    {
        for(int i = 0; i < 40; i++)
        {
            CardSuite suite = (CardSuite)(Math.Floor((decimal)i/10));
            CardRank rank = (CardRank)((decimal)i%13);
            DeckOfCards.Add(new Card(suite, rank));
        }
    }

    public void shuffleDeck()
    {
        Random rng = new Random((int)DateTime.Now.Ticks);
        int n = DeckOfCards.Count;
        while (n > 1){
            n--;
            int k = rng.Next(n + 1);
            Card temp = DeckOfCards[k];
            DeckOfCards[k] = DeckOfCards[n];
            DeckOfCards[n] = temp;
        }
    }

    public Card drawCard()
    {
        if(DeckOfCards.Count==0){
            throw new Exception("Deck is empty");
        }
        Card card = DeckOfCards[0];
        DeckOfCards.RemoveAt(0);
        return card;
    }
}