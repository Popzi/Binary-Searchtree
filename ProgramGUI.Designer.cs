namespace SortedTree
{
    partial class ProgramGUI
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
            this.PictureBoxTree = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TraverseListbox = new System.Windows.Forms.ListBox();
            this.TraverseButton = new System.Windows.Forms.Button();
            this.TreeContains = new System.Windows.Forms.Button();
            this.GetValue_Button = new System.Windows.Forms.Button();
            this.TreeHeight_Button = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SaveToFile_Button = new System.Windows.Forms.Button();
            this.ImportTxtButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTree)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxTree
            // 
            this.PictureBoxTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxTree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxTree.Location = new System.Drawing.Point(12, 69);
            this.PictureBoxTree.Name = "PictureBoxTree";
            this.PictureBoxTree.Size = new System.Drawing.Size(403, 359);
            this.PictureBoxTree.TabIndex = 7;
            this.PictureBoxTree.TabStop = false;
            this.PictureBoxTree.Paint += new System.Windows.Forms.PaintEventHandler(this.treePictureBox_Paint);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(204, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add Node";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(43, 14);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(155, 20);
            this.textBoxKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Key:";
            // 
            // TraverseListbox
            // 
            this.TraverseListbox.FormattingEnabled = true;
            this.TraverseListbox.Location = new System.Drawing.Point(442, 69);
            this.TraverseListbox.Name = "TraverseListbox";
            this.TraverseListbox.Size = new System.Drawing.Size(120, 264);
            this.TraverseListbox.TabIndex = 8;
            // 
            // TraverseButton
            // 
            this.TraverseButton.Location = new System.Drawing.Point(569, 69);
            this.TraverseButton.Name = "TraverseButton";
            this.TraverseButton.Size = new System.Drawing.Size(75, 23);
            this.TraverseButton.TabIndex = 9;
            this.TraverseButton.Text = "Traverse";
            this.TraverseButton.UseVisualStyleBackColor = true;
            this.TraverseButton.Click += new System.EventHandler(this.TraverseButton_Click);
            // 
            // TreeContains
            // 
            this.TreeContains.Location = new System.Drawing.Point(285, 11);
            this.TreeContains.Name = "TreeContains";
            this.TreeContains.Size = new System.Drawing.Size(81, 23);
            this.TreeContains.TabIndex = 10;
            this.TreeContains.Text = "Tree Contains";
            this.TreeContains.UseVisualStyleBackColor = true;
            this.TreeContains.Click += new System.EventHandler(this.TreeContains_Click);
            // 
            // GetValue_Button
            // 
            this.GetValue_Button.Location = new System.Drawing.Point(372, 11);
            this.GetValue_Button.Name = "GetValue_Button";
            this.GetValue_Button.Size = new System.Drawing.Size(83, 23);
            this.GetValue_Button.TabIndex = 11;
            this.GetValue_Button.Text = "Get/Set value";
            this.GetValue_Button.UseVisualStyleBackColor = true;
            this.GetValue_Button.Click += new System.EventHandler(this.GetValue_Button_Click);
            // 
            // TreeHeight_Button
            // 
            this.TreeHeight_Button.Location = new System.Drawing.Point(462, 10);
            this.TreeHeight_Button.Name = "TreeHeight_Button";
            this.TreeHeight_Button.Size = new System.Drawing.Size(75, 23);
            this.TreeHeight_Button.TabIndex = 12;
            this.TreeHeight_Button.Text = "Tree Height";
            this.TreeHeight_Button.UseVisualStyleBackColor = true;
            this.TreeHeight_Button.Click += new System.EventHandler(this.TreeHeight_Button_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(204, 41);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(84, 23);
            this.RemoveButton.TabIndex = 13;
            this.RemoveButton.Text = "Remove Node";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SaveToFile_Button
            // 
            this.SaveToFile_Button.Location = new System.Drawing.Point(569, 99);
            this.SaveToFile_Button.Name = "SaveToFile_Button";
            this.SaveToFile_Button.Size = new System.Drawing.Size(75, 23);
            this.SaveToFile_Button.TabIndex = 14;
            this.SaveToFile_Button.Text = "Save to file";
            this.SaveToFile_Button.UseVisualStyleBackColor = true;
            this.SaveToFile_Button.Click += new System.EventHandler(this.SaveToFile_Button_Click);
            // 
            // ImportTxtButton
            // 
            this.ImportTxtButton.Location = new System.Drawing.Point(294, 40);
            this.ImportTxtButton.Name = "ImportTxtButton";
            this.ImportTxtButton.Size = new System.Drawing.Size(97, 23);
            this.ImportTxtButton.TabIndex = 15;
            this.ImportTxtButton.Text = "Importera fil";
            this.ImportTxtButton.UseVisualStyleBackColor = true;
            this.ImportTxtButton.Click += new System.EventHandler(this.ImportTxtButton_Click);
            // 
            // ProgramGUI
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 440);
            this.Controls.Add(this.ImportTxtButton);
            this.Controls.Add(this.SaveToFile_Button);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.TreeHeight_Button);
            this.Controls.Add(this.GetValue_Button);
            this.Controls.Add(this.TreeContains);
            this.Controls.Add(this.TraverseButton);
            this.Controls.Add(this.TraverseListbox);
            this.Controls.Add(this.PictureBoxTree);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Name = "ProgramGUI";
            this.Text = "SortedTree";
            this.Load += new System.EventHandler(this.ProgramGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxTree;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TraverseListbox;
        private System.Windows.Forms.Button TraverseButton;
        private System.Windows.Forms.Button TreeContains;
        private System.Windows.Forms.Button GetValue_Button;
        private System.Windows.Forms.Button TreeHeight_Button;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SaveToFile_Button;
        private System.Windows.Forms.Button ImportTxtButton;
    }
}

