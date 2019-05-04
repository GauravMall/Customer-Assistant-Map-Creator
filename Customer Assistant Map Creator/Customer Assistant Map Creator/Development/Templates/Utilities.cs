using System;
using System.Collections.Specialized;

namespace Customer_Assistant_Map_Creator.Development.Templates
{
    public static class Utilities
    {
        public static Map GetMap()
        {
            Connection[] _connections = GetConnections();
            StringCollection _labels = Properties.Settings.Default.appliedLabels;
            return new Map(_connections, _labels);
        }

        public static Connection[] GetConnections()
        {
            //The connections
            StringCollection connections = Properties.Settings.Default.connections;

            Connection[] _connections = new Connection[connections.Count];


            for (int i = 0; i < connections.Count; i++)
            {
                string[] v_info = connections[i].Split('|');
                string v1_info = v_info[0].Replace("|", string.Empty);
                string v2_info = v_info[1];

                string[] v1_parameters = v1_info.Split(',');
                string[] v2_parameters = v2_info.Split(',');

                string v1_id = v1_parameters[0].Replace("[", string.Empty).Replace(",", string.Empty);
                double v1_x = Convert.ToDouble(v1_parameters[1].Replace(",", string.Empty).Replace("X1:", string.Empty));
                double v1_y = Convert.ToDouble(v1_parameters[2].Replace(",", string.Empty).Replace("Y1:", string.Empty));

                string v2_id = v2_parameters[0].Replace(",", string.Empty);
                double v2_x = Convert.ToDouble(v2_parameters[1].Replace(",", string.Empty).Replace("X2:", string.Empty));
                double v2_y = Convert.ToDouble(v2_parameters[2].Replace(",", string.Empty).Replace("]", string.Empty).Replace("Y2:", string.Empty));

                _connections[i] = new Connection(new Vertex(v1_x, v1_y, v1_id), new Vertex(v2_x, v2_y, v2_id));
            }

            return _connections;
        }
    }
}
