using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CardCore
{
    public class EffectParser : Parser
    {
        private const string ROOT_NODE = "Effects/Effect";
        private const string EFFECTS_NODE = "Effects";
        private const string EFFECT_NODE = "Effect";
        private const string P_NAME = "Name";
        private const string P_ID = "Id";
        private const string P_TARGETRANGE = "TargetRange";
        private const string P_TARGETTYPES = "TargetTypes";
        private const string P_MODIFIERS = "Modifiers";
        private const string P_MODIFIER  = "Modifier";
        private const string P_TYPE = "Type";
        private const string P_VALUE = "Value";

        public EffectParser(String filename)
            : base(filename)
        {
        }

        public void Parse(List<Effect> outList)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(mFilename);

            XmlNodeList nodes = doc.SelectNodes(ROOT_NODE);

            foreach (XmlNode node in nodes)
            {
                Effect effect = new Effect();

                foreach (XmlNode c in node.ChildNodes)
                {
                    switch (c.Name)
                    {
                        case P_NAME:
                            {
                                effect.Name = c.InnerText;
                                break;
                            }
                        case P_ID:
                            {
                                effect.Id = Convert.ToUInt32(c.InnerText);
                                break;
                            }
                        case P_TARGETRANGE:
                            {
                                effect.Range = ParseEnum<Effect.TargetRange>(c.InnerText);
                                break;
                            }
                        case P_TARGETTYPES:
                            {
                                effect.SetTargetTypes(Convert.ToUInt32(c.InnerText));
                                break;
                            }
                        case P_MODIFIERS:
                            {
                                foreach(XmlNode n in c.ChildNodes)
                                {
                                    Effect.Modifier mod = new Effect.Modifier();
                                    mod.Type = ParseEnum<Effect.ModifierType>(n.SelectSingleNode(P_TYPE).InnerText);
                                    mod.Value = Convert.ToInt32(n.SelectSingleNode(P_VALUE).InnerText);
                                    effect.AddModifier(mod);
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Unhandled node type: " + c.Name);
                                break;
                            }
                    }
                }

                outList.Add(effect);
            }
        }

        public void CreateNewFile(String filename, List<Effect> effects)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);

            doc.AppendChild(dec);

            XmlElement docRoot = doc.CreateElement(EFFECTS_NODE);

            doc.AppendChild(docRoot);

            foreach (Effect effect in effects)
            {
                _AppendEffectNode(doc, docRoot, effect);
            }

            doc.Save(filename);
        }

        private void _AppendEffectNode(XmlDocument doc, XmlElement root, Effect data)
        {
            // Set up our effect element
            XmlElement effect = doc.CreateElement(EFFECT_NODE);

            // Declare element storage
            XmlElement element;

            // Create attribute nodes
            element = doc.CreateElement(P_NAME);
            element.InnerText = data.Name;
            effect.AppendChild(element);

            element = doc.CreateElement(P_ID);
            element.InnerText = data.Id.ToString();
            effect.AppendChild(element);

            element = doc.CreateElement(P_TARGETRANGE);
            element.InnerText = data.Range.ToString();
            effect.AppendChild(element);

            element = doc.CreateElement(P_TARGETTYPES);
            element.InnerText = data.GetTargetTypes().ToString();
            effect.AppendChild(element);

            List<Effect.Modifier> modsList = data.GetModifiers();
            if(0 < modsList.Count)
            {
                XmlElement mods = doc.CreateElement(P_MODIFIERS);

                foreach(Effect.Modifier mod in modsList)
                {
                    XmlElement modNode = doc.CreateElement(P_MODIFIER);

                    XmlElement modEle;

                    modEle = doc.CreateElement(P_TYPE);
                    modEle.InnerText = mod.Type.ToString();
                    modNode.AppendChild(modEle);

                    modEle = doc.CreateElement(P_VALUE);
                    modEle.InnerText = mod.Value.ToString();
                    modNode.AppendChild(modEle);

                    mods.AppendChild(modNode);
                }

                effect.AppendChild(mods);
            }

            // Finally, add our new effect node
            root.AppendChild(effect);
        }

    }
}
