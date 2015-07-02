using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class Effect
    {
        public Effect(string name, EffectType type, int value, TargetType target, TargetRange range)
        {
            mName = name;
            mType = type;
            mTarget = target;
            mValue = value;
        }

        public enum EffectType
        {
            EFFECTTYPE_NONE,
            EFFECTTYPE_MODIFYHP,
            EFFECTTYPE_MODIFYMP,
            EFFECTTYPE_MODIFYCOST,
            EFFECTTYPE_MODIFYATTACK,
            EFFECTTYPE_MODIFYDEFENSE,
            EFFECTTYPE_DRAWCARD,
            EFFECTTYPE_MOVECARD,
            EFFECTTYPE_DESTROY,
            EFFECTTYPE_RETURN,
            EFFECTTYPE_COUNT,
        };

        public enum TargetRange
        {
            TARGETRANGE_NONE,
            TARGETRANGE_GLOBAL_ALL,
            TARGETRANGE_GLOBAL_ONE,
            TARGETRANGE_SELF,
            TARGETRANGE_OPPONENTS_ALL,
            TARGETRANGE_OPPONENTS_ONE,
            TARGETRANGE_ALLIES_ALL,
            TARGETRANGE_ALLIES_ONE,
            TARGETRANGE_COUNT,
        };

        public enum TargetType
        {
            TARGETTYPE_NONE,
            TARGETTYPE_PLAYER,
            TARGETTYPE_MONSTER,
            TARGETTYPE_LIVING,
            TARGETTYPE_SPELL,
            TARGETTYPE_DEFSPELL,
            TARGETTYPE_RELIC,
            TARGETTYPE_GRAVEYARD,
            TARGETTYPE_LIBRARY,
            TARGETTYPE_HAND,
            TARGETTYPE_LAND,
            TARGETTYPE_COUNT,
        };

        private string      mName;
        private EffectType  mType;
        private TargetType  mTarget;
        private TargetRange mTargetRange;
        private int         mValue;

        public string Name
        {
            get { return this.mName; }
            set { this.mName = value; }
        }

        public EffectType Type
        {
            get { return this.mType; }
            set { this.mType = value; }
        }

        public TargetType Target
        {
            get { return this.mTarget; }
            set { this.mTarget = value; }
        }

        public TargetRange Range
        {
            get { return this.mTargetRange; }
            set { this.mTargetRange = value; }
        }

        public int Value
        {
            get { return this.mValue; }
            set { this.mValue = value; }
        }
    }

    public class Card
    {
        public Card()
        {
            mEffects = new List<Effect>();
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
            CARDTYPE_MONSTER,
            CARDTYPE_RELIC,
            CARDTYPE_COUNT,
        };

        public enum CardSubType
        {
            CARDSUBTYPE_NONE,
            CARDSUBTYPE_COUNT,
        };

        private string       mName;
        private uint         mId;
        private uint         mCost;
        private CardType     mType;
        private CardSubType  mSubType;
        private List<Effect> mEffects;
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

        public List<Effect> GetAllEffects() { return mEffects; }

        public void AddEffect(Effect e) { mEffects.Add(e); }

        public bool RemoveEffect(Effect e) { return mEffects.Remove(e); }

        public Effect GetEffectAtIndex(int index) { return mEffects[index]; }

        public void RemoveEffectAtIndex(int index) { mEffects.RemoveAt(index); }

        public bool IsTapped() { return mIsTapped; }
        
    }
}
