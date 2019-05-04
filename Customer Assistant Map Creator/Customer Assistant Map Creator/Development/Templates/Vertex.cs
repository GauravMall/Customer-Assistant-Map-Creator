using System;

namespace Customer_Assistant_Map_Creator.Development.Templates
{
    public class Vertex
    {
        string identifier;

        public Vertex(double x, double y, bool starting)
        {
            X = x;
            Y = y;
            identifier = "startingVertex";
        }

        public Vertex(double x, double y)
        {
            X = x;
            Y = y;
            identifier = "vertex-" + Convert.ToString(Properties.Settings.Default.vertices.Count);
        }
        public Vertex(double x, double y, string identifier)
        {
            X = x;
            Y = y;
            this.identifier = identifier;
        }

        public double X { get; set; }
        public double Y { get; set; }

        override
        public string ToString()
        {
            return identifier;
        }
    }
}
