using System;
using System.Collections.Specialized;

namespace Customer_Assistant_Map_Creator.Development.Templates
{
    public class Map
    {
        Connection[] Connections;
        StringCollection Labels;

        public Map(Connection[] connections, StringCollection labels)
        {
            Connections = connections;
            Labels = labels;
        }

        public Connection[] getConnections()
        {
            return Connections;
        }

        //Exporting the whole thing in a compact code.
        public string Export()
        {
            StringCollection exportMaterial = new StringCollection();
            
            //The connections listed in the .map file in a compact and convenient way, stored to be later decrypted by the arduino script.
            for (int i = 0; i < Connections.Length; i++)
            {
                string line = "\"" + Connections[i].GetFirstVertex().X + "\"," + Environment.NewLine + "\"" + Connections[i].GetFirstVertex().Y + "\"," + Environment.NewLine +
                    "\"" + Connections[i].GetSecondVertex().X + "\"," + Environment.NewLine + "\"" + Connections[i].GetSecondVertex().Y + "\"," + Environment.NewLine + Labels[i];
                exportMaterial.Add(line);
            }

            //Converting into string.
            string export = "";

            foreach (string line in exportMaterial)
            {
                export += line;
                export += Environment.NewLine;
            }

            //The final step.
            return export;
        }
    }
}
