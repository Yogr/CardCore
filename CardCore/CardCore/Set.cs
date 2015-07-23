using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class Set
    {
        public Set()
        {
            mCardIds = new List<uint>();
        }

        ~Set()
        {
            mCardIds.Clear();
        }

        public enum SetType
        {
            SETTYPE_NONE,
            SETTYPE_CORE,
            SETTYPE_EXPANSION,
            SETTYPE_COUNT,
        };

        public struct SetBlock
        {
            int mId;
            string mName;

            public int Id
            {
                get { return this.mId; }
                set { this.mId = value; }
            }

            public string Name
            {
                get { return this.mName; }
                set { this.mName = value; }
            }
        };

        private string     mName;
        private SetType    mType;
        private SetBlock   mBlock;
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

        public void RemoveAllCards()
        {
            mCardIds.Clear();
        }

        public string Name
        {
            get { return this.mName; }
            set { this.mName = value; }
        }

        public SetBlock Block
        {
            get { return this.mBlock; }
            set { this.mBlock = value; }
        }

        public SetType GetSetType() { return this.mType; }
        public void SetSetType(SetType value) { this.mType = value; }
    }
}
