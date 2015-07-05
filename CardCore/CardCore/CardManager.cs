using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class CardManager
    {
        private List<Card> mCards;
        private uint mNextId;

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

        public List<Card> GetListCards()
        {
            return mCards;
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

            mNextId = parser.Parse(mCards);
        }

    }
}
