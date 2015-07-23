using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CardCore
{
    class SetParser : Parser
    {
        private const string ROOT_NODE = "Sets/Set";
        private const string SETS_NODE = "Sets";
        private const string SET_NODE = "Set";
        private const string P_NAME = "Name";
        private const string P_TYPE = "Type";
        private const string P_BLOCK = "Block";
        private const string P_ID = "Id";
        private const string P_CARDS = "Cards";
        private const string P_CARDID = "CardId";

        public SetParser(String filename)
            : base(filename)
        {
        }

        public void Parse(List<Set> outList)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(mFilename);

            XmlNodeList nodes = doc.SelectNodes(ROOT_NODE);

            foreach (XmlNode node in nodes)
            {
                Set set = new Set();

                foreach (XmlNode n in node.ChildNodes)
                {
                    switch (n.Name)
                    {
                        case P_NAME:
                            {
                                set.Name = n.InnerText;
                                break;
                            }
                        case P_TYPE:
                            {
                                set.SetSetType(ParseEnum<Set.SetType>(n.InnerText));
                                break;
                            }
                        case P_ID:
                            {
                                
                                break;
                            }
                        case P_CARDS:
                            {
                                foreach(XmlNode card in n.ChildNodes)
                                {
                                    set.AddCard(Convert.ToUInt32(card.InnerText));
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Unhandled node type: " + n.Name);
                                break;
                            }
                    }
                }

                outList.Add(set);
            }
        }


        public void CreateNewFile(String filename, List<Set> sets)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);

            doc.AppendChild(dec);

            XmlElement docRoot = doc.CreateElement(SETS_NODE);

            doc.AppendChild(docRoot);

            foreach (Set set in sets)
            {
                _AppendSetNode(doc, docRoot, set);
            }

            doc.Save(filename);
        }

        private void _AppendSetNode(XmlDocument doc, XmlElement root, Set data)
        {
            // Set up our effect element
            XmlElement set = doc.CreateElement(SET_NODE);

            // Declare element storage
            XmlElement element;

            // Create attribute nodes
            element = doc.CreateElement(P_NAME);
            element.InnerText = data.Name;
            set.AppendChild(element);

            element = doc.CreateElement(P_TYPE);
            element.InnerText = data.GetSetType().ToString();
            set.AppendChild(element);

            List<uint> cardsList = data.GetCardIds();
            if (0 < cardsList.Count)
            {
                XmlElement cards = doc.CreateElement(P_CARDS);

                foreach (uint cId in cardsList)
                {
                    XmlElement card = doc.CreateElement(P_CARDID);
                    card.InnerText = cId.ToString();
                    cards.AppendChild(card);
                }

                set.AppendChild(cards);
            }

            // Finally, add our new set node
            root.AppendChild(set);
        }
    }
}
