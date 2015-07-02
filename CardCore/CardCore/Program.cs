using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string masterFp = FilePaths.DATA_PATH + "Wizard";
            string cardFp = System.IO.Path.GetFullPath(masterFp + FilePaths.CARDS_PATH);

            Console.WriteLine(cardFp);
            
            CardParser parser = new CardParser(cardFp);

            List<Card> cardList = new List<Card>();
            Card card1 = new Card();
            card1.Name = "Sorceror of the Shore";
            card1.Id = 0;
            card1.Type = Card.CardType.CARDTYPE_MONSTER;
            card1.SubType = Card.CardSubType.CARDSUBTYPE_NONE;
            card1.Cost = 45;
            card1.AddEffect(new Effect("Tap to Ping", Effect.EffectType.EFFECTTYPE_MODIFYHP, 1, Effect.TargetType.TARGETTYPE_LIVING, Effect.TargetRange.TARGETRANGE_GLOBAL_ONE));
            cardList.Add(card1);

            Card card2 = new Card();
            card2.Name = "Barbarian Shaman";
            card2.Id = 1;
            card2.Type = Card.CardType.CARDTYPE_MONSTER;
            card2.SubType = Card.CardSubType.CARDSUBTYPE_NONE;
            card2.Cost = 20;
            card2.AddEffect(new Effect("All Barbarians +X/+0", Effect.EffectType.EFFECTTYPE_MODIFYATTACK, 2, Effect.TargetType.TARGETTYPE_MONSTER, Effect.TargetRange.TARGETRANGE_ALLIES_ALL));
            card2.AddEffect(new Effect("All Barbarians +0/+X", Effect.EffectType.EFFECTTYPE_MODIFYDEFENSE, 2, Effect.TargetType.TARGETTYPE_MONSTER, Effect.TargetRange.TARGETRANGE_ALLIES_ALL));
            cardList.Add(card2);

            parser.CreateNewFile(cardFp, cardList);
        }
    }
}
