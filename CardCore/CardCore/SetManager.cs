using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class SetManager
    {
        private List<Set> mSets;

        private static SetManager sInstance = null;

        public static SetManager GetInstance()
        {
            if(null == sInstance)
            {
                sInstance = new SetManager();
            }
            return sInstance;
        }

        public List<uint> GetSetCardIds(int setIndex)
        {
            return mSets[setIndex].GetCardIds();
        }

        public void AddSet(Set newSet)
        {
            mSets.Add(newSet);
        }

        public void RemoveSet(Set set)
        {
            mSets.Remove(set);
        }

        public void SaveDataToFile(string rootFolder)
        {
            string setFp = FilePaths.GetFullPath(rootFolder + FilePaths.SETS_PATH);

            Console.WriteLine(setFp);

            SetParser parser = new SetParser(setFp);

            //parser.CreateNewFile(cardFp, mSets);
        }

        public void LoadSetData(string rootfolder)
        {
            string setFp = FilePaths.GetFullPath(rootfolder + FilePaths.SETS_PATH);

            SetParser parser = new SetParser(setFp);

            //mNextId = parser.Parse(mSets);
        }
    }
}
