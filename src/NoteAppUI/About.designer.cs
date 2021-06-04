
namespace NoteAppUI
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.noteAppLabel = new System.Windows.Forms.Label();
            this.verLabel = new System.Windows.Forms.Label();
            this.autorLabel = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.GitLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.emLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // noteAppLabel
            // 
            this.noteAppLabel.AutoSize = true;
            this.noteAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteAppLabel.Location = new System.Drawing.Point(12, 9);
            this.noteAppLabel.Name = "noteAppLabel";
            this.noteAppLabel.Size = new System.Drawing.Size(94, 25);
            this.noteAppLabel.TabIndex = 0;
            this.noteAppLabel.Text = "Note App";
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.Location = new System.Drawing.Point(14, 50);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(43, 13);
            this.verLabel.TabIndex = 1;
            this.verLabel.Text = "v. 1.0.0";
            // 
            // autorLabel
            // 
            this.autorLabel.AutoSize = true;
            this.autorLabel.Location = new System.Drawing.Point(14, 86);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(90, 13);
            this.autorLabel.TabIndex = 2;
            this.autorLabel.Text = "Autor: Egor Belov";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(14, 129);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(100, 13);
            this.eLabel.TabIndex = 3;
            this.eLabel.Text = "e-mail for feedback:";
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.Location = new System.Drawing.Point(14, 152);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(43, 13);
            this.GitLabel.TabIndex = 4;
            this.GitLabel.Text = "GitHub:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(14, 212);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(98, 13);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "2021 Egor Belov ©";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(63, 152);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/SP3KTRAL";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // emLinkLabel
            // 
            this.emLinkLabel.AutoSize = true;
            this.emLinkLabel.Location = new System.Drawing.Point(120, 129);
            this.emLinkLabel.Name = "emLinkLabel";
            this.emLinkLabel.Size = new System.Drawing.Size(104, 13);
            this.emLinkLabel.TabIndex = 9;
            this.emLinkLabel.TabStop = true;
            this.emLinkLabel.Text = "egorbrlov16@mail.ru";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 246);
            this.Controls.Add(this.emLinkLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.GitLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.autorLabel);
            this.Controls.Add(this.verLabel);
            this.Controls.Add(this.noteAppLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noteAppLabel;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label GitLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel emLinkLabel;
    }
}