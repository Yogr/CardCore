using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CardCore
{
    static public class FilePaths
    {
        static public string DATA_PATH = "data/";
        static public string CARDS_PATH = "/cards/Cards.xml";
        static public string SETS_PATH = "/sets/Sets.xml";
        static public string EFFECTS_PATH = "/effects/Effects.xml";
        static public string GetFullPath(string fp) { return System.IO.Path.GetFullPath(fp); }
    }
}
