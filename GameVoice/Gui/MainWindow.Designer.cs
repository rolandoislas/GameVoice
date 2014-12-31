namespace GameVoice
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.micLevelBar = new System.Windows.Forms.ProgressBar();
            this.micLevelLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // micLevelBar
            // 
            this.micLevelBar.Location = new System.Drawing.Point(108, 130);
            this.micLevelBar.Name = "micLevelBar";
            this.micLevelBar.Size = new System.Drawing.Size(164, 10);
            this.micLevelBar.TabIndex = 0;
            // 
            // micLevelLabel
            // 
            this.micLevelLabel.AutoSize = true;
            this.micLevelLabel.Location = new System.Drawing.Point(12, 127);
            this.micLevelLabel.Name = "micLevelLabel";
            this.micLevelLabel.Size = new System.Drawing.Size(90, 13);
            this.micLevelLabel.TabIndex = 1;
            this.micLevelLabel.Text = "Microphone Input";
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Location = new System.Drawing.Point(15, 27);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(257, 97);
            this.textBox.TabIndex = 5;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editConfigurationToolStripMenuItem,
            this.editCommandsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // editConfigurationToolStripMenuItem
            // 
            this.editConfigurationToolStripMenuItem.Name = "editConfigurationToolStripMenuItem";
            this.editConfigurationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editConfigurationToolStripMenuItem.Text = "Edit Configuration";
            this.editConfigurationToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationFile);
            // 
            // editCommandsToolStripMenuItem
            // 
            this.editCommandsToolStripMenuItem.Name = "editCommandsToolStripMenuItem";
            this.editCommandsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editCommandsToolStripMenuItem.Text = "Edit Commands";
            this.editCommandsToolStripMenuItem.Click += new System.EventHandler(this.openCommandsFile);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(284, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.micLevelLabel);
            this.Controls.Add(this.micLevelBar);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "GameVoice";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar micLevelBar;
        private System.Windows.Forms.Label micLevelLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCommandsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}

