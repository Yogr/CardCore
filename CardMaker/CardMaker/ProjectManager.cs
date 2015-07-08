using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CardCore;

namespace CardMaker
{
    public class ProjectManager
    {
        static ProjectManager sInstance = null;

        public static ProjectManager GetInstance()
        {
            if(null == sInstance)
            {
                sInstance = new ProjectManager();
            }
            return sInstance;
        }

        private ProjectManager() { }
        ~ProjectManager() { }

        private string mActiveProjectName;
        private string mActiveProjectFp;
        private string mActiveFolderRoot;

        public string GetActiveProject() { return mActiveProjectName; }

        public bool CreateNewFile(string name)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);

            doc.AppendChild(dec);

            XmlElement docRoot = doc.CreateElement("Master");

            doc.AppendChild(docRoot);

            XmlElement mainNode = doc.CreateElement("CardSet");
            mainNode.InnerText = name;
            docRoot.AppendChild(mainNode);

            string fp = FilePaths.DATA_PATH;

            mActiveFolderRoot = fp + name;

            System.IO.Directory.CreateDirectory(mActiveFolderRoot);

            mActiveProjectFp = mActiveFolderRoot + "/" + name + ".xml";

            System.IO.Directory.CreateDirectory(mActiveFolderRoot + "/sets");
            System.IO.Directory.CreateDirectory(mActiveFolderRoot + "/cards");
            System.IO.Directory.CreateDirectory(mActiveFolderRoot + "/effects");

            mActiveProjectName = name;

            SaveActiveProject();

            doc.Save(mActiveProjectFp);

            return true;
        }

        public bool LoadProject(string filepath)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filepath);

                XmlNode node = doc.SelectSingleNode("Master/CardSet");

                mActiveProjectName = node.InnerText;
                mActiveProjectFp = filepath;
                mActiveFolderRoot = filepath.Substring(0, filepath.LastIndexOf('\\'));

                // Load Effects
                EffectManager.GetInstance().LoadEffectData(mActiveFolderRoot);

                // Load Cards
                CardManager.GetInstance().LoadCardData(mActiveFolderRoot);

                // Load Sets
                SetManager.GetInstance().LoadSetData(mActiveFolderRoot);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void SaveActiveProject()
        {
            // Save Effects
            EffectManager.GetInstance().SaveDataToFile(mActiveFolderRoot);

            // Save Cards
            CardManager.GetInstance().SaveDataToFile(mActiveFolderRoot);

            // Save Sets
            SetManager.GetInstance().SaveDataToFile(mActiveFolderRoot);

            // Save active doc 
            //.Save(mActiveProjectFp);
        }
    }
}
