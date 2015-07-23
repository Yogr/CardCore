using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class Effect
    {
        public Effect(string name, uint id)
        {
            mName = name;
            mId = id;
            mModifiers = new List<Modifier>();
        }

        public Effect()
        {
            mModifiers = new List<Modifier>();
        }

        ~Effect()
        {
            mModifiers.Clear();
        }

        public class Modifier
        {
            private ModifierType mType;
            private int mValue;

            public ModifierType Type
            {
                get { return mType; }
                set { this.mType = value; }
            }

            public int Value
            {
                get { return mValue; }
                set { this.mValue = value; }
            }
        }

        public enum ModifierType
        {
            MODTYPE_NONE = 0,
            MODTYPE_MODIFYHP,          //<! Changes target hitpoints by value
            MODTYPE_MODIFYMP,          //<! Changes target mana by value
            MODTYPE_MODIFYCOST,        //<! Changes target cost by value
            MODTYPE_MODIFYATTACK,      //<! Changes target attack by value
            MODTYPE_MODIFYDEFENSE,     //<! Changes target defense by value
            MODTYPE_DRAWCARD,          //<! Target draws value number of cards
            MODTYPE_DESTROY,           //<! Destroy target
            MODTYPE_RETURN_TO_HAND,    //<! Return target to hand
            MODTYPE_RETURN_TO_LIBRARY, //<! Return target to hand
            MODTYPE_SHROUD,            //<! Provides target immunity to spells
            MODTYPE_INDESTRUCTIBLE,    //<! Target cannot die due to damage
            MODTYPE_MILL,              //<! Put the top x cards from library into graveyard
            MODTYPE_LIFELINK,          //<! Whenever target deals damage, heals itself for x (0 to match damage)
            MODTYPE_LIFELINK_USER,     //<! Whenever target deals damage, heals owner for x (0 to match damage)
            MODTYPE_STUN,              //<! Disables target with the STUN modifier
            MODTYPE_SLEEP,             //<! Disables target with the SLEEP modifier
            MODTYPE_COUNT,
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

        private string         mName;
        private List<Modifier> mModifiers;
        private GameEntity     mTarget;
        private TargetRange    mTargetRange;
        private uint           mTargetTypes;
        private uint           mId;

        public string Name
        {
            get { return this.mName; }
            set { this.mName = value; }
        }

        public TargetRange Range
        {
            get { return this.mTargetRange; }
            set { this.mTargetRange = value; }
        }

        public uint Id
        {
            get { return this.mId; }
            set { this.mId = value; }
        }

        public GameEntity Target
        {
            get { return this.mTarget; }
        }

        public bool CanTargetEntity(GameEntity.EntityType type)
        {
            return 0 != (mTargetTypes & Convert.ToUInt32(type));
        }

        public void SetTargetTypes(uint types)
        {
            mTargetTypes = types;
        }

        public uint GetTargetTypes()
        {
            return mTargetTypes;
        }

        public void AddTargetType(GameEntity.EntityType type)
        {
            mTargetTypes |= Convert.ToUInt32(type);
        }

        public void AddModifier(Modifier mod)
        {
            mModifiers.Add(mod);
        }

        public void RemoveModifier(Modifier mod)
        {
            mModifiers.Remove(mod);
        }

        public void RemoveAllModifiers()
        {
            mModifiers.Clear();
        }

        public List<Modifier> GetModifiers()
        {
            return mModifiers;
        }

        public void AddTarget(GameEntity entity)
        {
            //if(CanTargetEntity(entity.EntityType))
            {
                mTarget = entity;
            }
        }

    }
}
