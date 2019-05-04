using System;
using System.Drawing;
using System.Windows.Forms;
using Customer_Assistant_Map_Creator.Development.Templates;

namespace Customer_Assistant_Map_Creator.Development.Other_Forms
{
    public partial class PreviewForm : Form
    {
        private Map map;

        public PreviewForm(Map map)
        {
            InitializeComponent();
            this.map = map;
        }

        private void PreviewMap_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            //Drawing the map
            Connection[] connections = map.getConnections();

            foreach (Connection connection in connections)
            {
                Vertex v1;
                Vertex v2;

                v1 = connection.GetFirstVertex();
                v2 = connection.GetSecondVertex();

                Pen pen = new Pen(Color.White);
                pen.Width = 5;

                //Centering the map and drawing it.
                graphics.DrawLine(pen, new Point((int)v1.X  + previewMap.Width / 2, (int)v1.Y + previewMap.Height / 2), new Point((int)v2.X + previewMap.Width / 2, (int)v2.Y + previewMap.Height / 2));
            }
        }

        private void BtnAddLabel_Click(object sender, System.EventArgs e)
        {
            if (!txtLabel.Text.Equals(string.Empty))
            {
                Properties.Settings.Default.labels.Add(txtLabel.Text);

                loadLabels();
            }

            else
            {
                MessageBox.Show("Please type a label name.");
            }
        }

        private void BtnRemoveLabel_Click(object sender, System.EventArgs e)
        {
            if (labelsList.SelectedItem != null && !labelsList.SelectedItem.ToString().Equals("Nothing"))
            {
                Properties.Settings.Default.labels.Remove(labelsList.SelectedItem.ToString());
                labelsList.Items.Remove(labelsList.SelectedItem);

                loadLabels();
            }
        }

        private void loadLabels()
        {
            labelsList.Items.Clear();
            cmbLabels.Items.Clear();

            foreach (string item in Properties.Settings.Default.labels)
            {
                labelsList.Items.Add(item);
                cmbLabels.Items.Add(item);
            }
        }

        private void loadConnections()
        {
            for(int i = 0; i < Properties.Settings.Default.connections.Count; i++)
            {
                cmbConnections.Items.Add("connection-" + Convert.ToString(i + 1));
            }
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            loadConnections();
            loadLabels();
        }

        //Applying the label and the finishing touches
        private void BtnApplyLabel_Click(object sender, EventArgs e)
        {
            if (cmbConnections.SelectedItem != null && cmbLabels.SelectedItem != null)
            {
                string connection = cmbConnections.SelectedItem.ToString();
                int num = Convert.ToInt16(connection.Replace("connection-", string.Empty)) - 1;

                //Get the connection that is to be labeled.
                Connection[] connections = Utilities.GetConnections();
                Connection requestedConnection = connections[num];

                //Get the label.
                string label = cmbLabels.SelectedItem.ToString();

                //Calculate the coordinates of the median point of the connection.
                double distanceFromStart = (double)distanceFrom.Value;
                double distanceOfLabel = (double)distanceTo.Value;
                double absoluteDistance = distanceFromStart + distanceOfLabel / 2;
                double connectionDistance = Math.Sqrt((requestedConnection.GetSecondVertex().X - requestedConnection.GetFirstVertex().X) *
                    (requestedConnection.GetSecondVertex().X - requestedConnection.GetFirstVertex().X) + (requestedConnection.GetSecondVertex().Y - requestedConnection.GetFirstVertex().Y) *
                    (requestedConnection.GetSecondVertex().Y - requestedConnection.GetFirstVertex().Y));

                double t = absoluteDistance / connectionDistance;
                double x_median = (1 - t) * requestedConnection.GetFirstVertex().X + t * requestedConnection.GetSecondVertex().X;
                double y_median = (1 - t) * requestedConnection.GetFirstVertex().Y + t * requestedConnection.GetSecondVertex().Y;

                Vertex vertex_median = new Vertex(x_median, y_median);

                //Store that median point with the label.
                string labelInfo = "\"" + vertex_median.X + "\"," + Environment.NewLine + "\"" + vertex_median.Y + "\"," + Environment.NewLine + "\"" + label + "\",";

                if (!Properties.Settings.Default.appliedLabels.Contains(labelInfo))
                {
                    //Storing that label info.
                    Properties.Settings.Default.appliedLabels.Add(labelInfo);
                }
                else
                {
                    MessageBox.Show("The '" + connection + "' has been already assigned to label '" + label + "'.");
                }
            }
        }
    }
}
