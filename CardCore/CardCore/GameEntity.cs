using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    public class GameEntity
    {
        public enum EntityType
        {
            TYPE_NONE      = 0x0000,
            TYPE_PLAYER    = 0x0001,
            TYPE_MONSTER   = 0x0002,
            TYPE_RELIC     = 0x0004,
            TYPE_SPELL     = 0x0008,
            TYPE_DEFSPELL  = 0x0010,
            TYPE_HAND      = 0x0020,
            TYPE_LIBRARY   = 0x0040,
            TYPE_GRAVEYARD = 0x0080,
        };
    }
}
