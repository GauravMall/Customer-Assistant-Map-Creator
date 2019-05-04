namespace Customer_Assistant_Map_Creator.Development.Templates
{
    public class Connection
    {
        private Vertex v1, v2;

        public Connection(Vertex v1, Vertex v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Vertex GetFirstVertex()
        {
            return v1;
        }

        public Vertex GetSecondVertex()
        {
            return v2;
        }

        override
        public string ToString()
        {
            return "[" + v1.ToString() + ",X1: " + v1.X + ",Y1: " + v1.Y + "|" + v2.ToString() +",X2: " 
                + v2.X + ",Y2: " + v2.Y + "]";
        }
    }
}
