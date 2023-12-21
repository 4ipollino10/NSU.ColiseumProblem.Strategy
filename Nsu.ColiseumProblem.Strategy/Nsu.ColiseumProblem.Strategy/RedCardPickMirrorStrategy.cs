using Nsu.ColiseumProblem.Contracts;
using Nsu.ColiseumProblem.Contracts.Cards;

namespace Nsu.ColiseumProblem.Strategy;

public class RedCardPickMirrorStrategy : ICardPickStrategy
{
    public int Pick(Card[] cards)
    {
        for (var i = 0; i < cards.Length; ++i)
        {
            if(cards[i].Color is not CardColor.Red) continue;

            return i;
        }

        return 0;
    }
}