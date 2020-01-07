namespace WindowsFormsAppliction
{
    partial class WinFromApplication
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
            this.ServerLabel = new System.Windows.Forms.Label();
            this.serverValue = new System.Windows.Forms.Label();
            this.AlarmValue = new System.Windows.Forms.Label();
            this.AlarmLabel = new System.Windows.Forms.Label();
            this.insertTextLabel = new System.Windows.Forms.Label();
            this.InsertTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(12, 50);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(84, 13);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Server Number :";
            // 
            // serverValue
            // 
            this.serverValue.AutoSize = true;
            this.serverValue.Location = new System.Drawing.Point(92, 50);
            this.serverValue.Name = "serverValue";
            this.serverValue.Size = new System.Drawing.Size(35, 13);
            this.serverValue.TabIndex = 2;
            this.serverValue.Text = "empty";
            // 
            // AlarmValue
            // 
            this.AlarmValue.AutoSize = true;
            this.AlarmValue.Location = new System.Drawing.Point(92, 75);
            this.AlarmValue.Name = "AlarmValue";
            this.AlarmValue.Size = new System.Drawing.Size(35, 13);
            this.AlarmValue.TabIndex = 4;
            this.AlarmValue.Text = "empty";
            // 
            // AlarmLabel
            // 
            this.AlarmLabel.AutoSize = true;
            this.AlarmLabel.Location = new System.Drawing.Point(12, 75);
            this.AlarmLabel.Name = "AlarmLabel";
            this.AlarmLabel.Size = new System.Drawing.Size(79, 13);
            this.AlarmLabel.TabIndex = 3;
            this.AlarmLabel.Text = "Alarm Number :";
            // 
            // insertTextLabel
            // 
            this.insertTextLabel.AutoSize = true;
            this.insertTextLabel.Location = new System.Drawing.Point(12, 9);
            this.insertTextLabel.Name = "insertTextLabel";
            this.insertTextLabel.Size = new System.Drawing.Size(119, 13);
            this.insertTextLabel.TabIndex = 5;
            this.insertTextLabel.Text = "Insert Text in box below";
            // 
            // InsertTextBox
            // 
            this.InsertTextBox.ForeColor = System.Drawing.Color.Red;
            this.InsertTextBox.Location = new System.Drawing.Point(15, 25);
            this.InsertTextBox.Name = "InsertTextBox";
            this.InsertTextBox.Size = new System.Drawing.Size(647, 22);
            this.InsertTextBox.TabIndex = 6;
            this.InsertTextBox.Text = "Insert Text Here";
            this.InsertTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InserTextBox_KeyDown);
            this.InsertTextBox.Leave += new System.EventHandler(this.InserTextBox_Leave);
            // 
            // WinFromApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 103);
            this.Controls.Add(this.InsertTextBox);
            this.Controls.Add(this.insertTextLabel);
            this.Controls.Add(this.AlarmValue);
            this.Controls.Add(this.AlarmLabel);
            this.Controls.Add(this.serverValue);
            this.Controls.Add(this.ServerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WinFromApplication";
            this.Text = "WinFromApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label serverValue;
        private System.Windows.Forms.Label AlarmValue;
        private System.Windows.Forms.Label AlarmLabel;
        private System.Windows.Forms.Label insertTextLabel;
        private System.Windows.Forms.RichTextBox InsertTextBox;
        private Server m_server;
    }
}

