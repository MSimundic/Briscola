namespace Briscola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Card
{
    public CardSuite CardSuite { get; }
    public CardRank CardRank { get; }

    public Card(
        CardSuite cardSuite,
        CardRank cardRank)
    {
        CardSuite = cardSuite;
        CardRank = cardRank;
    }

}