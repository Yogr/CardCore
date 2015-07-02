using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CardCore
{
    public class CardParser : Parser
    {
        private const string ROOT_NODE  = "cards/card";
        private const string CARDS_NODE = "Cards";
        private const string CARD_NODE  = "Card";
        private const string P_NAME     = "Name";
        private const string P_TYPE     = "Type";
        private const string P_SUBTYPE  = "SubType";
        private const string P_ID       = "Id";
        private const string P_COST     = "Cost";
        private const string P_EFFECTS  = "Effects";
        private const string P_EFFECT   = "Effect";

        public CardParser(String filename)
            : base(filename)
        {
        }

        public void Parse(List<Card> outList)
        {
            XmlDocument doc = new XmlDocument();
            XmlNodeList nodes = doc.SelectNodes(ROOT_NODE);
            
            foreach (XmlNode node in nodes)
            {
                Card card = new Card();

                outList.Add(card);
            }
        }

        public void EditNode(XmlNode node, int position)
        {
            // Find node at position

            // Replace with node
        }

        public void InsertNode(XmlNode node, int position)
        {
            // Insert node at position
        }

        public void AppendNode(XmlNode node)
        {
            // Add node to end of nodes
        }

        public void SaveExistingFile()
        {
            
        }

        public void CreateNewFile(String filename, List<Card> cards)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);

            doc.AppendChild(dec);

            XmlElement docRoot = doc.CreateElement(CARDS_NODE);

            doc.AppendChild(docRoot);

            foreach(Card card in cards)
            {
                _AppendCardNode(doc, docRoot, card);
            }

            doc.Save(filename);
        }

        private void _AppendCardNode(XmlDocument doc, XmlElement root, Card data)
        {
            // Set up our card element
            XmlElement card = doc.CreateElement(CARD_NODE);

            // Declare element storage
            XmlElement element;

            // Create attribute nodes
            element = doc.CreateElement(P_NAME);
            element.InnerText = data.Name;
            card.AppendChild(element);

            element = doc.CreateElement(P_TYPE);
            element.InnerText = data.Type.ToString();
            card.AppendChild(element);

            element = doc.CreateElement(P_SUBTYPE);
            element.InnerText = data.SubType.ToString();
            card.AppendChild(element);

            element = doc.CreateElement(P_ID);
            element.InnerText = data.Id.ToString();
            card.AppendChild(element);

            element = doc.CreateElement(P_COST);
            element.InnerText = data.Cost.ToString();
            card.AppendChild(element);

            List<Effect> effectsList = data.GetAllEffects();
            if (0 < effectsList.Count)
            {
                XmlElement effects = doc.CreateElement(P_EFFECTS);

                foreach (Effect e in effectsList)
                {
                    XmlElement effect = doc.CreateElement(P_EFFECT);

                    XmlElement efel = doc.CreateElement(P_NAME);
                    efel.InnerText = e.Name;
                    effect.AppendChild(efel);

                    efel = doc.CreateElement(P_TYPE);
                    efel.InnerText = e.Type.ToString();
                    effect.AppendChild(efel);

                    efel = doc.CreateElement("Target");
                    efel.InnerText = e.Target.ToString();
                    effect.AppendChild(efel);

                    efel = doc.CreateElement("Value");
                    efel.InnerText = e.Value.ToString();
                    effect.AppendChild(efel);

                    effects.AppendChild(effect);
                }

                card.AppendChild(effects);
            }

            // Append this to our root element
            root.AppendChild(card);
        }
    }
}
