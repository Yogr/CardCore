using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class Set
    {
        private string     mName;
        private List<uint> mCardIds;
        private string     mBoxImagePath;

        public List<uint> GetCardIds()
        {
            return mCardIds;
        }

        public void AddCard(uint id)
        {
            mCardIds.Add(id);
        }

        public void RemoveCard(uint id)
        {
            mCardIds.Remove(id);
        }

        public string Name
        {
            get { return this.mName; }
            set { this.mName = value; }
        }
    }
}
