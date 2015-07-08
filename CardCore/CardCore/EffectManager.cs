using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class EffectManager : IDisposable
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

        private EffectManager()
        {
            mEffects = new List<Effect>();
        }

        ~EffectManager()
        {

        }

        public void Dispose()
        {
            mEffects.Clear();
            mEffects = null;
        }

        /// <summary>
        /// Returns the next valid (unused) Id
        /// </summary>
        /// <returns>next valid unsigned int id</returns>
        public uint GetNextValidId()
        {
            if (mEffects.Count > 0)
            {
                return mEffects.Last().Id + 1;
            }

            return 0;
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

        public Effect GetEffectByIndex(int index)
        {
            return mEffects[index];
        }

        public List<Effect> GetAllEffects()
        {
            return mEffects;
        }

        public void AddEffect(Effect e)
        {
            mEffects.Add(e);
        }

        public void SaveDataToFile(string rootFolder)
        {
            string effectFp = FilePaths.GetFullPath(rootFolder + FilePaths.EFFECTS_PATH);

            Console.WriteLine(effectFp);

            EffectParser parser = new EffectParser(effectFp);

            parser.CreateNewFile(effectFp, mEffects);
        }

        public void LoadEffectData(string rootfolder)
        {
            string effectFp = FilePaths.GetFullPath(rootfolder + FilePaths.EFFECTS_PATH);

            EffectParser parser = new EffectParser(effectFp);

            if(null == mEffects)
            {
                mEffects = new List<Effect>();
            }

            parser.Parse(mEffects);
        }

    }
}
