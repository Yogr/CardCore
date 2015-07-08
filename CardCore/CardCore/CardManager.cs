using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class CardManager : IDisposable
    {
        private List<Card> mCards;

        private static CardManager sInstance = null;

        public static CardManager GetInstance()
        {
            if(null == sInstance)
            {
                sInstance = new CardManager();
            }
            return sInstance;
        }

        private CardManager()
        {
            mCards = new List<Card>();
        }

        ~CardManager()
        {

        }

        public void Dispose()
        {
            mCards.Clear();
            mCards = null;
        }

        /// <summary>
        /// Returns the next valid (unused) Id
        /// </summary>
        /// <returns>next valid unsigned int id</returns>
        public uint GetNextValidId()
        {
            if(mCards.Count > 0)
            {
                return mCards.Last().Id + 1;
            }
            
            return 0;
        }

        public List<Card> GetListCards()
        {
            return mCards;
        }

        public Card GetCardAtIndex(int index)
        {
            return mCards[index];
        }

        public void AddCard(Card card)
        {
            mCards.Add(card);
        }

        public void SaveDataToFile(string rootFolder)
        {
            string cardFp = FilePaths.GetFullPath(rootFolder + FilePaths.CARDS_PATH);

            Console.WriteLine(cardFp);
            
            CardParser parser = new CardParser(cardFp);

            parser.CreateNewFile(cardFp, mCards);
        }
        
        public void LoadCardData(string rootfolder)
        {
            string cardFp = FilePaths.GetFullPath(rootfolder + FilePaths.CARDS_PATH);

            CardParser parser = new CardParser(cardFp);

            if (null == mCards)
            {
                mCards = new List<Card>();
            }

            parser.Parse(mCards);
        }

    }
}
