using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace RandLaunch
{
    public class XMLProbe
    {

        private string filePath;
        private XmlDocument probeDoc;

        private XmlNode parentNode;
        private XmlNode workingNode;

        private const char PATH_SEPERATOR = '/';

        public XMLProbe(string filePath)
        {
            this.filePath = filePath;
        }

        public void SetWorkingNode(string path, XmlNode node = null)
        {
            //Create and load the xmlfile provided on instanciation, if not already loaded.
            if(probeDoc == null)
            {
                probeDoc = new XmlDocument();
                probeDoc.Load(filePath);
            }

            //If path contains no seperators set the node.
            if (!path.Contains(PATH_SEPERATOR))
            {
                workingNode = Find(path, node);
                return;
            }

            //Split the given path on seperator.
            string[] names = path.Split(PATH_SEPERATOR);

            //Recursively set paths.
            SetWorkingNode(path.Substring(names[0].Count() + PATH_SEPERATOR, path.Count() - (names[0].Count() + 1)), Find(names[0], node));
        }

        public string GetSetting(string name, Boolean nonFatal = false)
        {
            //If settingsDoc not loaded, load.
            if(probeDoc == null)
            {
                probeDoc = new XmlDocument();
                probeDoc.Load(filePath);
            }

            //Recusrive search for setting.
            XmlNode settingNode = Find(name, workingNode);

            //If setting not found, throw error.
            if(settingNode == null)
            {
                string exitNotification = "Program will now exit!";
                if (nonFatal) { exitNotification = ""; }

                MessageBox.Show("A setting could not be found.\n" +
                                "File: " + filePath + "\n" +
                                "Node: " + workingNode.Name + "\n" +
                                "Setting: " + name + "\n\n" +
                                exitNotification,
                                "Error Loading XML: " + filePath,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                if (!nonFatal) { Environment.Exit(0); }
            }
            return settingNode.InnerText;
        }

        private XmlNode Find(string name, XmlNode node)
        {
            if(node == null)
            {
                //Recursive search all root children for potential matches.
                for(int i = 0; i < probeDoc.ChildNodes.Count; i++)
                {
                    if(probeDoc.ChildNodes[i].Name == name)
                    {
                        return probeDoc.ChildNodes[i];
                    }
                }
            }
            else
            {
                //Recursive search all node children for potential matches.
                for (int i = 0; i < node.ChildNodes.Count; i++)
                {
                    if (node.ChildNodes[i].Name == name)
                    {
                        return node.ChildNodes[i];
                    }
                }
            }

            //No match found
            return null;
        }
    }
}
