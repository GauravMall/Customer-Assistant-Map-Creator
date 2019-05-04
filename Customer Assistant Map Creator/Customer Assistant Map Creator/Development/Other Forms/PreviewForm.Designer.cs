namespace Customer_Assistant_Map_Creator.Development.Other_Forms
{
    partial class PreviewForm
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
            this.previewMap = new System.Windows.Forms.Panel();
            this.lblLabelConnections = new System.Windows.Forms.Label();
            this.lblLabels = new System.Windows.Forms.Label();
            this.labelsList = new System.Windows.Forms.ListBox();
            this.btnAddLabel = new System.Windows.Forms.Button();
            this.btnRemoveLabel = new System.Windows.Forms.Button();
            this.cmbConnections = new System.Windows.Forms.ComboBox();
            this.cmbLabels = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.distanceFrom = new System.Windows.Forms.NumericUpDown();
            this.lblMeters = new System.Windows.Forms.Label();
            this.lblMetres2 = new System.Windows.Forms.Label();
            this.distanceTo = new System.Windows.Forms.NumericUpDown();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnApplyLabel = new System.Windows.Forms.Button();
            this.txtLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.distanceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceTo)).BeginInit();
            this.SuspendLayout();
            // 
            // previewMap
            // 
            this.previewMap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.previewMap.Location = new System.Drawing.Point(231, 16);
            this.previewMap.Name = "previewMap";
            this.previewMap.Size = new System.Drawing.Size(733, 439);
            this.previewMap.TabIndex = 1;
            this.previewMap.Paint += new System.Windows.Forms.PaintEventHandler(this.PreviewMap_Paint);
            // 
            // lblLabelConnections
            // 
            this.lblLabelConnections.AutoSize = true;
            this.lblLabelConnections.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelConnections.Location = new System.Drawing.Point(11, 203);
            this.lblLabelConnections.Name = "lblLabelConnections";
            this.lblLabelConnections.Size = new System.Drawing.Size(196, 18);
            this.lblLabelConnections.TabIndex = 2;
            this.lblLabelConnections.Text = "Label your connections";
            // 
            // lblLabels
            // 
            this.lblLabels.AutoSize = true;
            this.lblLabels.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabels.Location = new System.Drawing.Point(11, 16);
            this.lblLabels.Name = "lblLabels";
            this.lblLabels.Size = new System.Drawing.Size(61, 18);
            this.lblLabels.TabIndex = 3;
            this.lblLabels.Text = "Labels";
            // 
            // labelsList
            // 
            this.labelsList.FormattingEnabled = true;
            this.labelsList.Items.AddRange(new object[] {
            "Nothing"});
            this.labelsList.Location = new System.Drawing.Point(15, 66);
            this.labelsList.Name = "labelsList";
            this.labelsList.Size = new System.Drawing.Size(192, 108);
            this.labelsList.TabIndex = 4;
            // 
            // btnAddLabel
            // 
            this.btnAddLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLabel.Location = new System.Drawing.Point(153, 14);
            this.btnAddLabel.Name = "btnAddLabel";
            this.btnAddLabel.Size = new System.Drawing.Size(24, 24);
            this.btnAddLabel.TabIndex = 5;
            this.btnAddLabel.Text = "+";
            this.btnAddLabel.UseVisualStyleBackColor = true;
            this.btnAddLabel.Click += new System.EventHandler(this.BtnAddLabel_Click);
            // 
            // btnRemoveLabel
            // 
            this.btnRemoveLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLabel.Location = new System.Drawing.Point(183, 14);
            this.btnRemoveLabel.Name = "btnRemoveLabel";
            this.btnRemoveLabel.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveLabel.TabIndex = 6;
            this.btnRemoveLabel.Text = "-";
            this.btnRemoveLabel.UseVisualStyleBackColor = true;
            this.btnRemoveLabel.Click += new System.EventHandler(this.BtnRemoveLabel_Click);
            // 
            // cmbConnections
            // 
            this.cmbConnections.FormattingEnabled = true;
            this.cmbConnections.Location = new System.Drawing.Point(15, 241);
            this.cmbConnections.Name = "cmbConnections";
            this.cmbConnections.Size = new System.Drawing.Size(192, 21);
            this.cmbConnections.TabIndex = 7;
            // 
            // cmbLabels
            // 
            this.cmbLabels.FormattingEnabled = true;
            this.cmbLabels.Location = new System.Drawing.Point(15, 278);
            this.cmbLabels.Name = "cmbLabels";
            this.cmbLabels.Size = new System.Drawing.Size(192, 21);
            this.cmbLabels.TabIndex = 8;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(12, 318);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(61, 18);
            this.lblFrom.TabIndex = 9;
            this.lblFrom.Text = "From: ";
            // 
            // distanceFrom
            // 
            this.distanceFrom.Location = new System.Drawing.Point(79, 320);
            this.distanceFrom.Name = "distanceFrom";
            this.distanceFrom.Size = new System.Drawing.Size(89, 20);
            this.distanceFrom.TabIndex = 10;
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeters.Location = new System.Drawing.Point(174, 322);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(33, 18);
            this.lblMeters.TabIndex = 11;
            this.lblMeters.Text = "dm";
            // 
            // lblMetres2
            // 
            this.lblMetres2.AutoSize = true;
            this.lblMetres2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetres2.Location = new System.Drawing.Point(174, 362);
            this.lblMetres2.Name = "lblMetres2";
            this.lblMetres2.Size = new System.Drawing.Size(33, 18);
            this.lblMetres2.TabIndex = 14;
            this.lblMetres2.Text = "dm";
            // 
            // distanceTo
            // 
            this.distanceTo.Location = new System.Drawing.Point(79, 360);
            this.distanceTo.Name = "distanceTo";
            this.distanceTo.Size = new System.Drawing.Size(89, 20);
            this.distanceTo.TabIndex = 13;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(12, 358);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 18);
            this.lblTo.TabIndex = 12;
            this.lblTo.Text = "To:";
            // 
            // btnApplyLabel
            // 
            this.btnApplyLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApplyLabel.Location = new System.Drawing.Point(15, 420);
            this.btnApplyLabel.Name = "btnApplyLabel";
            this.btnApplyLabel.Size = new System.Drawing.Size(192, 35);
            this.btnApplyLabel.TabIndex = 15;
            this.btnApplyLabel.Text = "Apply Label";
            this.btnApplyLabel.UseVisualStyleBackColor = true;
            this.btnApplyLabel.Click += new System.EventHandler(this.BtnApplyLabel_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(15, 44);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(192, 20);
            this.txtLabel.TabIndex = 16;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(976, 474);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.btnApplyLabel);
            this.Controls.Add(this.lblMetres2);
            this.Controls.Add(this.distanceTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblMeters);
            this.Controls.Add(this.distanceFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cmbLabels);
            this.Controls.Add(this.cmbConnections);
            this.Controls.Add(this.btnRemoveLabel);
            this.Controls.Add(this.btnAddLabel);
            this.Controls.Add(this.labelsList);
            this.Controls.Add(this.lblLabels);
            this.Controls.Add(this.lblLabelConnections);
            this.Controls.Add(this.previewMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PreviewForm";
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.PreviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distanceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel previewMap;
        private System.Windows.Forms.Label lblLabelConnections;
        private System.Windows.Forms.Label lblLabels;
        private System.Windows.Forms.ListBox labelsList;
        private System.Windows.Forms.Button btnAddLabel;
        private System.Windows.Forms.Button btnRemoveLabel;
        private System.Windows.Forms.ComboBox cmbConnections;
        private System.Windows.Forms.ComboBox cmbLabels;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.NumericUpDown distanceFrom;
        private System.Windows.Forms.Label lblMeters;
        private System.Windows.Forms.Label lblMetres2;
        private System.Windows.Forms.NumericUpDown distanceTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnApplyLabel;
        private System.Windows.Forms.TextBox txtLabel;
    }
}