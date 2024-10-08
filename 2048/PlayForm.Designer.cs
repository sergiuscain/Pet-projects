﻿namespace _2048
{
    partial class PlayForm
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
            scoreLabel = new Label();
            recordLabel = new Label();
            nameLabel = new Label();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(1, 3);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(0, 15);
            scoreLabel.TabIndex = 0;
            // 
            // recordLabel
            // 
            recordLabel.AutoSize = true;
            recordLabel.Location = new Point(126, 4);
            recordLabel.Name = "recordLabel";
            recordLabel.Size = new Size(0, 15);
            recordLabel.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(230, 6);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(37, 15);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "name";
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(210, 242, 187);
            ClientSize = new Size(284, 261);
            Controls.Add(nameLabel);
            Controls.Add(recordLabel);
            Controls.Add(scoreLabel);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PlayForm";
            Text = "PlayForm";
            FormClosed += PlayForm_FormClosed;
            Load += PlayForm_Load;
            KeyDown += PlayForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLabel;
        private Label recordLabel;
        private Label nameLabel;
    }
}