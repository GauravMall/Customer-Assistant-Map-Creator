namespace Customer_Assistant_Map_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vertices");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Connections");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.map = new System.Windows.Forms.TreeView();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbVertex2 = new System.Windows.Forms.ComboBox();
            this.cmbVertex1 = new System.Windows.Forms.ComboBox();
            this.lblConnections = new System.Windows.Forms.Label();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.btnRemoveVertex = new System.Windows.Forms.Button();
            this.lblVertices = new System.Windows.Forms.Label();
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.process = new System.Windows.Forms.Timer(this.components);
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVertexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVertexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationAboutProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsPanel.SuspendLayout();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Location = new System.Drawing.Point(0, 24);
            this.map.Name = "map";
            treeNode1.Name = "vertices";
            treeNode1.Text = "Vertices";
            treeNode2.Name = "connections";
            treeNode2.Text = "Connections";
            this.map.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.map.Size = new System.Drawing.Size(679, 665);
            this.map.TabIndex = 4;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.btnExport);
            this.optionsPanel.Controls.Add(this.btnPreview);
            this.optionsPanel.Controls.Add(this.cmbVertex2);
            this.optionsPanel.Controls.Add(this.cmbVertex1);
            this.optionsPanel.Controls.Add(this.lblConnections);
            this.optionsPanel.Controls.Add(this.btnAddConnection);
            this.optionsPanel.Controls.Add(this.btnRemoveVertex);
            this.optionsPanel.Controls.Add(this.lblVertices);
            this.optionsPanel.Controls.Add(this.btnAddVertex);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.optionsPanel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsPanel.Location = new System.Drawing.Point(679, 24);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(121, 665);
            this.optionsPanel.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(11, 331);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 36);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(11, 289);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(97, 36);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // cmbVertex2
            // 
            this.cmbVertex2.Enabled = false;
            this.cmbVertex2.FormattingEnabled = true;
            this.cmbVertex2.Location = new System.Drawing.Point(12, 191);
            this.cmbVertex2.Name = "cmbVertex2";
            this.cmbVertex2.Size = new System.Drawing.Size(96, 26);
            this.cmbVertex2.TabIndex = 7;
            // 
            // cmbVertex1
            // 
            this.cmbVertex1.Enabled = false;
            this.cmbVertex1.FormattingEnabled = true;
            this.cmbVertex1.Location = new System.Drawing.Point(12, 159);
            this.cmbVertex1.Name = "cmbVertex1";
            this.cmbVertex1.Size = new System.Drawing.Size(96, 26);
            this.cmbVertex1.TabIndex = 6;
            // 
            // lblConnections
            // 
            this.lblConnections.AutoSize = true;
            this.lblConnections.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnections.Location = new System.Drawing.Point(10, 125);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(100, 18);
            this.lblConnections.TabIndex = 4;
            this.lblConnections.Text = "Connections";
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Enabled = false;
            this.btnAddConnection.Location = new System.Drawing.Point(29, 228);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(63, 28);
            this.btnAddConnection.TabIndex = 3;
            this.btnAddConnection.Text = "Add";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.BtnAddConnection_Click);
            // 
            // btnRemoveVertex
            // 
            this.btnRemoveVertex.Location = new System.Drawing.Point(63, 53);
            this.btnRemoveVertex.Name = "btnRemoveVertex";
            this.btnRemoveVertex.Size = new System.Drawing.Size(30, 28);
            this.btnRemoveVertex.TabIndex = 2;
            this.btnRemoveVertex.Text = "-";
            this.btnRemoveVertex.UseVisualStyleBackColor = true;
            this.btnRemoveVertex.Click += new System.EventHandler(this.BtnRemoveVertex_Click);
            // 
            // lblVertices
            // 
            this.lblVertices.AutoSize = true;
            this.lblVertices.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVertices.Location = new System.Drawing.Point(27, 25);
            this.lblVertices.Name = "lblVertices";
            this.lblVertices.Size = new System.Drawing.Size(66, 18);
            this.lblVertices.TabIndex = 1;
            this.lblVertices.Text = "Vertices";
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.Location = new System.Drawing.Point(30, 53);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(30, 28);
            this.btnAddVertex.TabIndex = 0;
            this.btnAddVertex.Text = "+";
            this.btnAddVertex.UseVisualStyleBackColor = true;
            this.btnAddVertex.Click += new System.EventHandler(this.BtnAddVertex_Click);
            // 
            // process
            // 
            this.process.Interval = 1;
            this.process.Tick += new System.EventHandler(this.Process_Tick);
            // 
            // exportDialog
            // 
            this.exportDialog.Filter = "Map Files(*.map)|.map";
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(800, 24);
            this.main_menu.TabIndex = 6;
            this.main_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVertexToolStripMenuItem,
            this.deleteVertexToolStripMenuItem,
            this.previewToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // addVertexToolStripMenuItem
            // 
            this.addVertexToolStripMenuItem.Name = "addVertexToolStripMenuItem";
            this.addVertexToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addVertexToolStripMenuItem.Text = "Add Vertex";
            this.addVertexToolStripMenuItem.Click += new System.EventHandler(this.AddVertexToolStripMenuItem_Click);
            // 
            // deleteVertexToolStripMenuItem
            // 
            this.deleteVertexToolStripMenuItem.Name = "deleteVertexToolStripMenuItem";
            this.deleteVertexToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteVertexToolStripMenuItem.Text = "Delete Vertex";
            this.deleteVertexToolStripMenuItem.Click += new System.EventHandler(this.DeleteVertexToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.PreviewToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationAboutProjectToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informationAboutProjectToolStripMenuItem
            // 
            this.informationAboutProjectToolStripMenuItem.Name = "informationAboutProjectToolStripMenuItem";
            this.informationAboutProjectToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.informationAboutProjectToolStripMenuItem.Text = "Information about project";
            this.informationAboutProjectToolStripMenuItem.Click += new System.EventHandler(this.InformationAboutProjectToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.map);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.main_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Assistant Map Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView map;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button btnRemoveVertex;
        private System.Windows.Forms.Label lblVertices;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Timer process;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbVertex2;
        private System.Windows.Forms.ComboBox cmbVertex1;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.Button btnAddConnection;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVertexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVertexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationAboutProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

