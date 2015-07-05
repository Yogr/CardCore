using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class EffectManager
    {
        private List<Effect> mEffects;

        private static EffectManager sInstance = null;

        public static EffectManager GetInstance()
        {
            if(null == sInstance)
            {
                sInstance = new EffectManager();
            }
            return sInstance;
        }

        public Effect GetEffectById(uint id)
        {
            foreach(Effect e in mEffects)
            {
                if(id == e.Id)
                {
                    return e;
                }
            }
            return null;
        }

        public void SaveDataToFile(string rootFolder)
        {
            string effectFp = FilePaths.GetFullPath(rootFolder + FilePaths.EFFECTS_PATH);

            Console.WriteLine(effectFp);

            EffectParser parser = new EffectParser(effectFp);

            //parser.CreateNewFile(cardFp, mSets);
        }

        public void LoadEffectData(string rootfolder)
        {
            string effectFp = FilePaths.GetFullPath(rootfolder + FilePaths.EFFECTS_PATH);

            EffectParser parser = new EffectParser(effectFp);

            //mNextId = parser.Parse(mSets);
        }
    }
}
