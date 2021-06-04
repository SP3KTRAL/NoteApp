
namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleNoteListBox = new System.Windows.Forms.ListBox();
            this.removeNoteButton = new System.Windows.Forms.Button();
            this.editNoteButton = new System.Windows.Forms.Button();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.noteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.textNoteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.modifiedNoteLabel = new System.Windows.Forms.Label();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.createdNoteLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.catrgoryNoteLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.titleNoteLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.titleNoteListBox);
            this.splitContainer1.Panel1.Controls.Add(this.removeNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.editNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.addNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.noteCategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textNoteRichTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.modifiedNoteLabel);
            this.splitContainer1.Panel2.Controls.Add(this.modifiedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.createdNoteLabel);
            this.splitContainer1.Panel2.Controls.Add(this.createdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.catrgoryNoteLabel);
            this.splitContainer1.Panel2.Controls.Add(this.categoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.titleNoteLabel);
            this.splitContainer1.Size = new System.Drawing.Size(970, 605);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 0;
            // 
            // titleNoteListBox
            // 
            this.titleNoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleNoteListBox.FormattingEnabled = true;
            this.titleNoteListBox.IntegralHeight = false;
            this.titleNoteListBox.Location = new System.Drawing.Point(12, 36);
            this.titleNoteListBox.Name = "titleNoteListBox";
            this.titleNoteListBox.Size = new System.Drawing.Size(303, 524);
            this.titleNoteListBox.TabIndex = 7;
            this.titleNoteListBox.SelectedIndexChanged += new System.EventHandler(this.titleNoteListBox_SelectedIndexChanged);
            // 
            // removeNoteButton
            // 
            this.removeNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeNoteButton.BackgroundImage")));
            this.removeNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeNoteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.removeNoteButton.FlatAppearance.BorderSize = 0;
            this.removeNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.removeNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeNoteButton.Location = new System.Drawing.Point(70, 572);
            this.removeNoteButton.Name = "removeNoteButton";
            this.removeNoteButton.Size = new System.Drawing.Size(23, 23);
            this.removeNoteButton.TabIndex = 6;
            this.removeNoteButton.UseVisualStyleBackColor = true;
            this.removeNoteButton.Click += new System.EventHandler(this.removeNoteButton_Click);
            // 
            // editNoteButton
            // 
            this.editNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editNoteButton.BackgroundImage")));
            this.editNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editNoteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.editNoteButton.FlatAppearance.BorderSize = 0;
            this.editNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.editNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.editNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNoteButton.Location = new System.Drawing.Point(41, 572);
            this.editNoteButton.Name = "editNoteButton";
            this.editNoteButton.Size = new System.Drawing.Size(23, 23);
            this.editNoteButton.TabIndex = 5;
            this.editNoteButton.UseVisualStyleBackColor = true;
            this.editNoteButton.Click += new System.EventHandler(this.editNoteButton_Click);
            // 
            // addNoteButton
            // 
            this.addNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNoteButton.BackgroundImage")));
            this.addNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNoteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.addNoteButton.FlatAppearance.BorderSize = 0;
            this.addNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoteButton.Location = new System.Drawing.Point(12, 572);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(23, 23);
            this.addNoteButton.TabIndex = 3;
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // noteCategoryComboBox
            // 
            this.noteCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noteCategoryComboBox.FormattingEnabled = true;
            this.noteCategoryComboBox.Location = new System.Drawing.Point(97, 9);
            this.noteCategoryComboBox.Name = "noteCategoryComboBox";
            this.noteCategoryComboBox.Size = new System.Drawing.Size(218, 21);
            this.noteCategoryComboBox.TabIndex = 1;
            this.noteCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.noteCategoryComboBox_SelectedIndexChanged);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(9, 12);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowCategoryLabel.TabIndex = 0;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // textNoteRichTextBox
            // 
            this.textNoteRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNoteRichTextBox.BackColor = System.Drawing.Color.White;
            this.textNoteRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNoteRichTextBox.Location = new System.Drawing.Point(6, 86);
            this.textNoteRichTextBox.Name = "textNoteRichTextBox";
            this.textNoteRichTextBox.ReadOnly = true;
            this.textNoteRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textNoteRichTextBox.Size = new System.Drawing.Size(625, 509);
            this.textNoteRichTextBox.TabIndex = 7;
            this.textNoteRichTextBox.Text = "";
            // 
            // modifiedNoteLabel
            // 
            this.modifiedNoteLabel.AutoSize = true;
            this.modifiedNoteLabel.Location = new System.Drawing.Point(224, 59);
            this.modifiedNoteLabel.Name = "modifiedNoteLabel";
            this.modifiedNoteLabel.Size = new System.Drawing.Size(0, 13);
            this.modifiedNoteLabel.TabIndex = 6;
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.Location = new System.Drawing.Point(168, 59);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.modifiedLabel.TabIndex = 5;
            this.modifiedLabel.Text = "Modified:";
            // 
            // createdNoteLabel
            // 
            this.createdNoteLabel.AutoSize = true;
            this.createdNoteLabel.Location = new System.Drawing.Point(54, 59);
            this.createdNoteLabel.Name = "createdNoteLabel";
            this.createdNoteLabel.Size = new System.Drawing.Size(0, 13);
            this.createdNoteLabel.TabIndex = 4;
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(3, 59);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(47, 13);
            this.createdLabel.TabIndex = 3;
            this.createdLabel.Text = "Created:";
            // 
            // catrgoryNoteLabel
            // 
            this.catrgoryNoteLabel.AutoSize = true;
            this.catrgoryNoteLabel.Location = new System.Drawing.Point(60, 38);
            this.catrgoryNoteLabel.Name = "catrgoryNoteLabel";
            this.catrgoryNoteLabel.Size = new System.Drawing.Size(0, 13);
            this.catrgoryNoteLabel.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(3, 38);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category:";
            // 
            // titleNoteLabel
            // 
            this.titleNoteLabel.AutoSize = true;
            this.titleNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleNoteLabel.Location = new System.Drawing.Point(-1, 9);
            this.titleNoteLabel.Name = "titleNoteLabel";
            this.titleNoteLabel.Size = new System.Drawing.Size(0, 25);
            this.titleNoteLabel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.removeNoteToolStripMenuItem.Text = "RemoveNote Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 634);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(986, 673);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox noteCategoryComboBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.Button editNoteButton;
        private System.Windows.Forms.Button removeNoteButton;
        private System.Windows.Forms.ListBox titleNoteListBox;
        private System.Windows.Forms.Label titleNoteLabel;
        private System.Windows.Forms.Label catrgoryNoteLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.Label createdNoteLabel;
        private System.Windows.Forms.Label modifiedNoteLabel;
        private System.Windows.Forms.RichTextBox textNoteRichTextBox;
    }
}

