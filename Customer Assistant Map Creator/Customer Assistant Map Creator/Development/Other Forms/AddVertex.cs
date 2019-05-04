using System;
using System.Windows.Forms;

namespace Customer_Assistant_Map_Creator.Development.Other_Forms
{
    public partial class AddVertex : Form
    {
        public AddVertex()
        {
            InitializeComponent();
        }

        private void RdGiveXY_CheckedChanged(object sender, EventArgs e)
        {
            relationGroupBox.Enabled = false;
            XYGroupBox.Enabled = true;
        }

        private void RdFromAnotherVertex_CheckedChanged(object sender, EventArgs e)
        {
            XYGroupBox.Enabled = false;
            relationGroupBox.Enabled = true;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.process = true;

            if (rdGiveXY.Checked)
            {
                double x = (double)numX.Value;
                double y = (double)numY.Value;
                Properties.Settings.Default.method = true;
                Properties.Settings.Default.x = x;
                Properties.Settings.Default.y = y;
            }
            else
            {
                string vertex = cmbVertex.SelectedItem.ToString();
                
                double d = (double)numDistance.Value;
                double a = (double)numAngle.Value;

                Properties.Settings.Default.method = false;
                Properties.Settings.Default.vertex = vertex;
                Properties.Settings.Default.distance = d;
                Properties.Settings.Default.angle = a;
            }

            Close();
        }

        private void AddVertex_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.vertices.Count == 0)
            {
                rdFromAnotherVertex.Enabled = false;
            }
            else
            {
                foreach (string vertex in Properties.Settings.Default.vertices)
                {
                    cmbVertex.Items.Add(vertex);
                }
            }
        }
    }
}
