namespace SortedTree
{
    partial class UserInput
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SetValue_Button = new System.Windows.Forms.Button();
            this.GetValue_Button = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserInputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(126, 153);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 27;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(46, 99);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(155, 20);
            this.textBoxValue.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Value:";
            // 
            // SetValue_Button
            // 
            this.SetValue_Button.Location = new System.Drawing.Point(235, 102);
            this.SetValue_Button.Name = "SetValue_Button";
            this.SetValue_Button.Size = new System.Drawing.Size(75, 23);
            this.SetValue_Button.TabIndex = 24;
            this.SetValue_Button.Text = "Set value";
            this.SetValue_Button.UseVisualStyleBackColor = true;
            this.SetValue_Button.Click += new System.EventHandler(this.SetValue_Button_Click);
            // 
            // GetValue_Button
            // 
            this.GetValue_Button.Location = new System.Drawing.Point(235, 64);
            this.GetValue_Button.Name = "GetValue_Button";
            this.GetValue_Button.Size = new System.Drawing.Size(75, 23);
            this.GetValue_Button.TabIndex = 23;
            this.GetValue_Button.Text = "Get value";
            this.GetValue_Button.UseVisualStyleBackColor = true;
            this.GetValue_Button.Click += new System.EventHandler(this.GetValue_Button_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(46, 64);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(155, 20);
            this.textBoxKey.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Key:";
            // 
            // UserInputText
            // 
            this.UserInputText.AutoSize = true;
            this.UserInputText.Location = new System.Drawing.Point(12, 9);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(300, 13);
            this.UserInputText.TabIndex = 20;
            this.UserInputText.Text = "Enter a Key and Get its value or Enter a Key and Set its value.";
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 198);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetValue_Button);
            this.Controls.Add(this.GetValue_Button);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserInputText);
            this.Name = "UserInput";
            this.Text = "Get or Set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetValue_Button;
        private System.Windows.Forms.Button GetValue_Button;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserInputText;
    }
}