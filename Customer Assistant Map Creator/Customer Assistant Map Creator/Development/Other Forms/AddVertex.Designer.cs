namespace Customer_Assistant_Map_Creator.Development.Other_Forms
{
    partial class AddVertex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVertex));
            this.lblAddVertex = new System.Windows.Forms.Label();
            this.rdGiveXY = new System.Windows.Forms.RadioButton();
            this.rdFromAnotherVertex = new System.Windows.Forms.RadioButton();
            this.XYGroupBox = new System.Windows.Forms.GroupBox();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.relationGroupBox = new System.Windows.Forms.GroupBox();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.numDistance = new System.Windows.Forms.NumericUpDown();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.cmbVertex = new System.Windows.Forms.ComboBox();
            this.lblVertex = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblInDM = new System.Windows.Forms.Label();
            this.XYGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.relationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddVertex
            // 
            this.lblAddVertex.AutoSize = true;
            this.lblAddVertex.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVertex.Location = new System.Drawing.Point(14, 11);
            this.lblAddVertex.Name = "lblAddVertex";
            this.lblAddVertex.Size = new System.Drawing.Size(97, 18);
            this.lblAddVertex.TabIndex = 0;
            this.lblAddVertex.Text = "Add Vertex";
            // 
            // rdGiveXY
            // 
            this.rdGiveXY.AutoSize = true;
            this.rdGiveXY.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGiveXY.Location = new System.Drawing.Point(17, 50);
            this.rdGiveXY.Name = "rdGiveXY";
            this.rdGiveXY.Size = new System.Drawing.Size(145, 20);
            this.rdGiveXY.TabIndex = 1;
            this.rdGiveXY.TabStop = true;
            this.rdGiveXY.Text = "Enter (x,y) values";
            this.rdGiveXY.UseVisualStyleBackColor = true;
            this.rdGiveXY.CheckedChanged += new System.EventHandler(this.RdGiveXY_CheckedChanged);
            // 
            // rdFromAnotherVertex
            // 
            this.rdFromAnotherVertex.AutoSize = true;
            this.rdFromAnotherVertex.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFromAnotherVertex.Location = new System.Drawing.Point(187, 50);
            this.rdFromAnotherVertex.Name = "rdFromAnotherVertex";
            this.rdFromAnotherVertex.Size = new System.Drawing.Size(259, 20);
            this.rdFromAnotherVertex.TabIndex = 2;
            this.rdFromAnotherVertex.TabStop = true;
            this.rdFromAnotherVertex.Text = "Define in relation to another vertex";
            this.rdFromAnotherVertex.UseVisualStyleBackColor = true;
            this.rdFromAnotherVertex.CheckedChanged += new System.EventHandler(this.RdFromAnotherVertex_CheckedChanged);
            // 
            // XYGroupBox
            // 
            this.XYGroupBox.Controls.Add(this.numY);
            this.XYGroupBox.Controls.Add(this.numX);
            this.XYGroupBox.Controls.Add(this.lblY);
            this.XYGroupBox.Controls.Add(this.lblX);
            this.XYGroupBox.Enabled = false;
            this.XYGroupBox.Location = new System.Drawing.Point(17, 77);
            this.XYGroupBox.Name = "XYGroupBox";
            this.XYGroupBox.Size = new System.Drawing.Size(145, 170);
            this.XYGroupBox.TabIndex = 3;
            this.XYGroupBox.TabStop = false;
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(47, 63);
            this.numY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(58, 21);
            this.numY.TabIndex = 10;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(47, 29);
            this.numX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(58, 21);
            this.numX.TabIndex = 9;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(18, 65);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(19, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(18, 31);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            // 
            // relationGroupBox
            // 
            this.relationGroupBox.Controls.Add(this.lblInDM);
            this.relationGroupBox.Controls.Add(this.numAngle);
            this.relationGroupBox.Controls.Add(this.numDistance);
            this.relationGroupBox.Controls.Add(this.lblAngle);
            this.relationGroupBox.Controls.Add(this.lblDistance);
            this.relationGroupBox.Controls.Add(this.cmbVertex);
            this.relationGroupBox.Controls.Add(this.lblVertex);
            this.relationGroupBox.Enabled = false;
            this.relationGroupBox.Location = new System.Drawing.Point(187, 77);
            this.relationGroupBox.Name = "relationGroupBox";
            this.relationGroupBox.Size = new System.Drawing.Size(306, 170);
            this.relationGroupBox.TabIndex = 4;
            this.relationGroupBox.TabStop = false;
            this.relationGroupBox.Text = "Select another vertex, the distance and angle";
            // 
            // numAngle
            // 
            this.numAngle.Location = new System.Drawing.Point(107, 99);
            this.numAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(60, 21);
            this.numAngle.TabIndex = 11;
            // 
            // numDistance
            // 
            this.numDistance.DecimalPlaces = 1;
            this.numDistance.Location = new System.Drawing.Point(107, 63);
            this.numDistance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(60, 21);
            this.numDistance.TabIndex = 10;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngle.Location = new System.Drawing.Point(20, 107);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(48, 13);
            this.lblAngle.TabIndex = 8;
            this.lblAngle.Text = "Angle:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(20, 68);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(67, 13);
            this.lblDistance.TabIndex = 6;
            this.lblDistance.Text = "Distance:";
            // 
            // cmbVertex
            // 
            this.cmbVertex.FormattingEnabled = true;
            this.cmbVertex.Location = new System.Drawing.Point(107, 29);
            this.cmbVertex.Name = "cmbVertex";
            this.cmbVertex.Size = new System.Drawing.Size(124, 21);
            this.cmbVertex.TabIndex = 5;
            // 
            // lblVertex
            // 
            this.lblVertex.AutoSize = true;
            this.lblVertex.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVertex.Location = new System.Drawing.Point(20, 32);
            this.lblVertex.Name = "lblVertex";
            this.lblVertex.Size = new System.Drawing.Size(54, 13);
            this.lblVertex.TabIndex = 4;
            this.lblVertex.Text = "Vertex:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(402, 257);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 33);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // lblInDM
            // 
            this.lblInDM.AutoSize = true;
            this.lblInDM.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInDM.Location = new System.Drawing.Point(173, 71);
            this.lblInDM.Name = "lblInDM";
            this.lblInDM.Size = new System.Drawing.Size(43, 13);
            this.lblInDM.TabIndex = 12;
            this.lblInDM.Text = "in dm";
            // 
            // AddVertex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 302);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.relationGroupBox);
            this.Controls.Add(this.XYGroupBox);
            this.Controls.Add(this.rdFromAnotherVertex);
            this.Controls.Add(this.rdGiveXY);
            this.Controls.Add(this.lblAddVertex);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddVertex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vertex";
            this.Load += new System.EventHandler(this.AddVertex_Load);
            this.XYGroupBox.ResumeLayout(false);
            this.XYGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.relationGroupBox.ResumeLayout(false);
            this.relationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddVertex;
        private System.Windows.Forms.RadioButton rdGiveXY;
        private System.Windows.Forms.RadioButton rdFromAnotherVertex;
        private System.Windows.Forms.GroupBox XYGroupBox;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox relationGroupBox;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.ComboBox cmbVertex;
        private System.Windows.Forms.Label lblVertex;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.Label lblInDM;
    }
}