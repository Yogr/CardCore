using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCore
{
    class SetParser : Parser
    {
        private const string ROOT_NODE = "sets/set";
        private const string SETS_NODE = "Sets";
        private const string SET_NODE = "Set";
        private const string P_NAME = "Name";
        private const string P_TYPE = "Type";
        private const string P_ID = "Id";
        private const string P_CARDS = "Cards";
        private const string P_CARDID = "CardId";

        public SetParser(String filename)
            : base(filename)
        {
        }


    }
}
