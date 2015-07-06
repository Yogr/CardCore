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
        }

        public Effect()
        {

        }

        public struct Modifier
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
            MODTYPE_NONE,
            MODTYPE_MODIFYHP,
            MODTYPE_MODIFYMP,
            MODTYPE_MODIFYCOST,
            MODTYPE_MODIFYATTACK,
            MODTYPE_MODIFYDEFENSE,
            MODTYPE_DRAWCARD,
            MODTYPE_MOVECARD,
            MODTYPE_DESTROY,
            MODTYPE_RETURN,
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
