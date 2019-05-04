using System;
using System.Windows.Forms;
using Customer_Assistant_Map_Creator.Development.Other_Forms;
using Customer_Assistant_Map_Creator.Development.Templates;
using System.IO;

namespace Customer_Assistant_Map_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region ClickMethods
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void BtnAddVertex_Click(object sender, EventArgs e)
        {
            addVertex();
        }

        private void BtnRemoveVertex_Click(object sender, EventArgs e)
        {
            removeVertex();
        }

        private void AddVertexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addVertex();
        }

        private void DeleteVertexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeVertex();
        }

        private void PreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preview();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            Preview();
        }

        private void BtnAddConnection_Click(object sender, EventArgs e)
        {
            if (cmbVertex1.SelectedItem != null || cmbVertex2.SelectedItem != null)
            {
                if (!cmbVertex1.SelectedItem.Equals(cmbVertex2.SelectedItem))
                {
                    TreeNodeCollection itemCollection = map.Nodes;

                    string v1_id = cmbVertex1.Text;
                    string v2_id = cmbVertex2.Text;

                    double x1 = findXOfVertex(v1_id, itemCollection);
                    double y1 = findYOfVertex(v1_id, itemCollection);

                    Vertex v1 = new Vertex(x1, y1, v1_id);

                    double x2 = findXOfVertex(v2_id, itemCollection);
                    double y2 = findYOfVertex(v2_id, itemCollection);

                    Vertex v2 = new Vertex(x2, y2, v2_id);

                    Connection connection = new Connection(v1, v2);
                    Properties.Settings.Default.connections.Add(connection.ToString());

                    TreeNode connectionNode = new TreeNode("connection-" + Properties.Settings.Default.connections.Count);
                    itemCollection[1].Nodes.Add(connectionNode);
                    connectionNode.Nodes.Add(v1_id);
                    connectionNode.Nodes.Add(v2_id);
                }

                else
                {
                    MessageBox.Show("Please select two vertices that are not the same.");
                }
            }
            else
            {
                MessageBox.Show("Please select two vertices.");
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void InformationAboutProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GauravMall/Customer-Assistant-Map-Creator");
        }
        #endregion

        #region doubleMethods
        private void addVertex()
        {
            process.Start();
            AddVertex addVertex = new AddVertex();
            addVertex.Show();
        }

        private void removeVertex()
        {
            TreeNode selectedNode = map.SelectedNode;

            if (selectedNode.Text.Contains("vertex"))
            {
                string id = selectedNode.Text;
                Properties.Settings.Default.vertices.Remove(id);
                map.Nodes.Remove(selectedNode);

                CheckConnectionControls();
            }
        }

        private void Preview()
        {
            PreviewForm previewForm = new PreviewForm(Utilities.GetMap());
            previewForm.Show();
        }

        private void Export()
        {
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(exportDialog.FileName))
                    {
                        streamWriter.Write(Utilities.GetMap().Export());
                    }

                    MessageBox.Show("File was saved succesfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void CheckConnectionControls()
        {
            if (Properties.Settings.Default.vertices.Count < 2)
            {
                //Disabling the Controls enabled prior to the removing of these vertices.
                cmbVertex1.Enabled = false;
                cmbVertex2.Enabled = false;
                btnAddConnection.Enabled = false;
                btnPreview.Enabled = false;
                btnExport.Enabled = false;
            }

            else
            {
                //Enabling the Controls disabled prior to the adding of these vertices.
                cmbVertex1.Enabled = true;
                cmbVertex2.Enabled = true;
                btnAddConnection.Enabled = true;
                btnPreview.Enabled = true;
                btnExport.Enabled = true;
            }
        }
        #endregion

        #region FunctionalityMethods
        private double findXOfVertex(string id, TreeNodeCollection itemCollection)
        {
            return Convert.ToDouble(itemCollection.Find(id, true)[0].Nodes[0].Text.Replace("x:", string.Empty));
        }

        private double findYOfVertex(string id, TreeNodeCollection itemCollection)
        {
            return Convert.ToDouble(itemCollection.Find(id, true)[0].Nodes[1].Text.Replace("y:", string.Empty));
        }

        #endregion

        private void Process_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.process == true)
            {
                if (Properties.Settings.Default.method == true)
                {
                    double x = Properties.Settings.Default.x;
                    double y = Properties.Settings.Default.y;

                    Vertex v1;

                    if (Properties.Settings.Default.vertices.Count == 0)
                    {
                        v1 = new Vertex(x, y, true);
                    }
                    else
                    {
                        v1 = new Vertex(x, y);
                    }

                    Properties.Settings.Default.vertices.Add(v1.ToString());

                    TreeNode vertex = new TreeNode(v1.ToString()) { Name = v1.ToString() };
                    map.Nodes[0].Nodes.Add(vertex);
                    vertex.Nodes.Add("x: " + v1.X);
                    vertex.Nodes.Add("y: " + v1.Y);
                }
                else
                {
                    double distance = Properties.Settings.Default.distance;
                    double angle = Properties.Settings.Default.angle;

                    double x = new double();
                    double y = new double();

                    double radians;

                    if (angle <= 90)
                    {
                        angle = 90 - angle;
                        radians = angle * Math.PI / 180;

                        x = Math.Abs(Math.Sin(radians) * distance);
                        y = Math.Sqrt((distance * distance) - (x * x));
                    }
                    else if (angle > 90 && angle <= 180)
                    {
                        angle = angle - 90;
                        radians = angle * Math.PI / 180;

                        x = -Math.Abs(Math.Sin(radians) * distance);
                        y = Math.Sqrt((distance * distance) - (x * x));
                    }

                    else if (angle > 180 && angle <= 270)
                    {
                        angle = 270 - angle;
                        radians = angle * Math.PI / 180;

                        x = -Math.Abs(Math.Sin(radians) * distance);
                        y = -Math.Sqrt((distance * distance) - (x * x));
                    }

                    else if (angle > 270 && angle <= 360)
                    {
                        angle = angle - 270;
                        radians = angle * Math.PI / 180;

                        x = Math.Abs(Math.Sin(radians) * distance);
                        y = -Math.Sqrt((distance * distance) - (x * x));
                    }

                    string vertexFrom = Properties.Settings.Default.vertex;

                    TreeNodeCollection itemCollection = map.Nodes;

                    double vertexFromX = findXOfVertex(vertexFrom, itemCollection);
                    double vertexFromY = findYOfVertex(vertexFrom, itemCollection);

                    double realX = x + vertexFromX;
                    double realY = y + vertexFromY;

                    Vertex v1 = new Vertex(realX, realY);

                    Properties.Settings.Default.vertices.Add(v1.ToString());

                    TreeNode vertex = new TreeNode(v1.ToString()) { Name = v1.ToString() };
                    map.Nodes[0].Nodes.Add(vertex);
                    vertex.Nodes.Add("x: " + v1.X);
                    vertex.Nodes.Add("y: " + v1.Y);

                }

                CheckConnectionControls();

                cmbVertex1.Items.Clear();
                cmbVertex2.Items.Clear();

                foreach (string item in Properties.Settings.Default.vertices)
                {
                    cmbVertex1.Items.Add(item);
                    cmbVertex2.Items.Add(item);
                }

                resetProcess();
                process.Stop();
            }
        }

        private void resetProcess()
        {
            Properties.Settings.Default.x = 0;
            Properties.Settings.Default.y = 0;
            Properties.Settings.Default.vertex = string.Empty;
            Properties.Settings.Default.distance = 0;
            Properties.Settings.Default.angle = 0;
            Properties.Settings.Default.method = true;
            Properties.Settings.Default.process = false;
        }

        private void resetEverything()
        {

            Properties.Settings.Default.Reset();
        }

        //Resseting Everything before the form closes.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetEverything();
        }
    }
}
