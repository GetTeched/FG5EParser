﻿namespace FG5EParser.User_Controls.Class_Controls
{
    partial class Class_Features
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFeatureName = new System.Windows.Forms.TextBox();
            this.txtFeatureLevels = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbFeatureDescription = new System.Windows.Forms.RichTextBox();
            this.cmsFormattingText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makeHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBoldPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkIsArchtype = new System.Windows.Forms.CheckBox();
            this.cmsFormattingText.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 38);
            this.label1.TabIndex = 229;
            this.label1.Text = "CLASS FEATURES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 230;
            this.label2.Text = "Feature Name";
            // 
            // txtFeatureName
            // 
            this.txtFeatureName.Location = new System.Drawing.Point(111, 47);
            this.txtFeatureName.Name = "txtFeatureName";
            this.txtFeatureName.Size = new System.Drawing.Size(571, 22);
            this.txtFeatureName.TabIndex = 231;
            // 
            // txtFeatureLevels
            // 
            this.txtFeatureLevels.Location = new System.Drawing.Point(111, 75);
            this.txtFeatureLevels.Name = "txtFeatureLevels";
            this.txtFeatureLevels.Size = new System.Drawing.Size(571, 22);
            this.txtFeatureLevels.TabIndex = 232;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 233;
            this.label3.Text = "Feature Levels";
            // 
            // rtbFeatureDescription
            // 
            this.rtbFeatureDescription.ContextMenuStrip = this.cmsFormattingText;
            this.rtbFeatureDescription.Location = new System.Drawing.Point(111, 104);
            this.rtbFeatureDescription.Name = "rtbFeatureDescription";
            this.rtbFeatureDescription.Size = new System.Drawing.Size(571, 308);
            this.rtbFeatureDescription.TabIndex = 234;
            this.rtbFeatureDescription.Text = "";
            // 
            // cmsFormattingText
            // 
            this.cmsFormattingText.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsFormattingText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeHeaderToolStripMenuItem,
            this.makeBoldPointToolStripMenuItem,
            this.makeTableToolStripMenuItem,
            this.makeListToolStripMenuItem});
            this.cmsFormattingText.Name = "cmsFormattingText";
            this.cmsFormattingText.Size = new System.Drawing.Size(193, 108);
            // 
            // makeHeaderToolStripMenuItem
            // 
            this.makeHeaderToolStripMenuItem.Name = "makeHeaderToolStripMenuItem";
            this.makeHeaderToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.makeHeaderToolStripMenuItem.Text = "Make Header";
            this.makeHeaderToolStripMenuItem.Click += new System.EventHandler(this.makeHeaderToolStripMenuItem_Click);
            // 
            // makeBoldPointToolStripMenuItem
            // 
            this.makeBoldPointToolStripMenuItem.Name = "makeBoldPointToolStripMenuItem";
            this.makeBoldPointToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.makeBoldPointToolStripMenuItem.Text = "Make Bold Point";
            this.makeBoldPointToolStripMenuItem.Click += new System.EventHandler(this.makeBoldPointToolStripMenuItem_Click);
            // 
            // makeTableToolStripMenuItem
            // 
            this.makeTableToolStripMenuItem.Name = "makeTableToolStripMenuItem";
            this.makeTableToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.makeTableToolStripMenuItem.Text = "Make Table";
            this.makeTableToolStripMenuItem.Click += new System.EventHandler(this.makeTableToolStripMenuItem_Click);
            // 
            // makeListToolStripMenuItem
            // 
            this.makeListToolStripMenuItem.Name = "makeListToolStripMenuItem";
            this.makeListToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.makeListToolStripMenuItem.Text = "Make List";
            this.makeListToolStripMenuItem.Click += new System.EventHandler(this.makeListToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 235;
            this.label4.Text = "Description";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(111, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 29);
            this.btnAdd.TabIndex = 236;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(210, 418);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 29);
            this.btnRefresh.TabIndex = 237;
            this.btnRefresh.Text = "REFRESH ALL";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkIsArchtype
            // 
            this.chkIsArchtype.AutoSize = true;
            this.chkIsArchtype.Location = new System.Drawing.Point(543, 418);
            this.chkIsArchtype.Name = "chkIsArchtype";
            this.chkIsArchtype.Size = new System.Drawing.Size(139, 21);
            this.chkIsArchtype.TabIndex = 238;
            this.chkIsArchtype.Text = "Archtype Feature";
            this.chkIsArchtype.UseVisualStyleBackColor = true;
            // 
            // Class_Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkIsArchtype);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbFeatureDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFeatureLevels);
            this.Controls.Add(this.txtFeatureName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Class_Features";
            this.Size = new System.Drawing.Size(685, 453);
            this.cmsFormattingText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFeatureName;
        private System.Windows.Forms.TextBox txtFeatureLevels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbFeatureDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ContextMenuStrip cmsFormattingText;
        private System.Windows.Forms.ToolStripMenuItem makeHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBoldPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeListToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkIsArchtype;
    }
}
