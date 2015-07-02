using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace CardCore
{
    public class Parser
    {
        protected String mFilename;
        protected XmlDocument mDoc;

        public Parser(String filename = "")
        {
            mFilename = filename;
            mDoc = new XmlDocument();
        }
    }
}
