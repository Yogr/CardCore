using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class Card
    {
        public Card()
        {
            mEffects = new List<uint>();
        }

        ~Card()
        {
            mEffects.Clear();
        }

        public enum CardType
        {
            CARDTYPE_NONE,
            CARDTYPE_SPELL,
            CARDTYPE_DEFSPELL,
            CARDTYPE_CREATURE,
            CARDTYPE_RELIC,
            CARDTYPE_COUNT,
        };

        public enum CardSubType
        {
            CARDSUBTYPE_NONE,
            CARDSUBTYPE_COUNT,
        };

        public enum CardRarity
        {
            RARITY_COMMON,
            RARITY_UNCOMMON,
            RARITY_RARE,
            RARITY_TREASURERARE,
        };

        public enum eFrameColor
        {
            FRAMECOLOR_DEFAULT,
            FRAMECOLOR_GRAY,
            FRAMECOLOR_PURPLE,
            FRAMECOLOR_BLACK,
            FRAMECOLOR_RED,
            FRAMECOLOR_GREEN,
            FRAMECOLOR_ORANGE,
            FRAMECOLOR_COUNT,
        };

        private string       mName;
        private uint         mId;
        private uint         mCost;
        private CardType     mType;
        private CardSubType  mSubType;
        private CardRarity   mRarity;
        private eFrameColor   mFrameColor;
        private uint         mFactions;
        private int          mAttack;
        private int          mDefense;
        private int          mHitpoints;
        private List<uint>   mEffects;
        private bool         mIsTapped;

        public string Name
        {
            set { this.mName = value; }
            get { return this.mName; }
        }

        public uint Id
        {
            set { this.mId = value; }
            get { return this.mId; }
        }

        public uint Cost
        {
            set { this.mCost = value; }
            get { return this.mCost; }
        }

        public CardType Type
        {
            set { this.mType = value; }
            get { return this.mType; }
        }

        public CardSubType SubType
        {
            set { this.mSubType = value; }
            get { return this.mSubType; }
        }

        public CardRarity Rarity
        {
            set { this.mRarity = value; }
            get { return this.mRarity; }
        }

        public eFrameColor FrameColor
        {
            set { this.mFrameColor = value; }
            get { return this.mFrameColor; }
        }

        public int Attack
        {
            set { this.mAttack = value; }
            get { return this.mAttack; }
        }

        public int Defense
        {
            set { this.mDefense = value; }
            get { return this.mDefense; }
        }

        public int Hitpoints
        {
            set { this.mHitpoints = value; }
            get { return this.mHitpoints; }
        }

        public bool BelongsToFaction(GameEntity.Faction faction)
        {
            return 0 != (mFactions & Convert.ToUInt32(faction));
        }

        public void SetFactions(uint factions)
        {
            mFactions = factions;
        }

        public uint GetFactions()
        {
            return mFactions;
        }

        public void AddFaction(GameEntity.Faction faction)
        {
            mFactions |= Convert.ToUInt32(faction);
        }

        public void RemoveFaction(GameEntity.Faction faction)
        { 
            mFactions &= ~Convert.ToUInt32(faction);
        }

        public List<uint> GetAllEffectIds() { return mEffects; }

        public void GetEffects(List<Effect> outList)
        {
            foreach(uint e in mEffects)
            {
                outList.Add(EffectManager.GetInstance().GetEffectById(e));
            }
        }

        public void AddEffectById(uint id) { mEffects.Add(id); }

        public void RemoveAllEffects() { mEffects.Clear(); }

        public bool RemoveEffectById(uint id) { return mEffects.Remove(id); }

        public uint GetEffectIdAtIndex(int index) { return mEffects[index]; }

        public void RemoveEffectAtIndex(int index) { mEffects.RemoveAt(index); }

        public bool IsTapped() { return mIsTapped; }
        
    }
}
