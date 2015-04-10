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
            this.editCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.jungleTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.editCommandsToolStripMenuItem,
            this.editConfigurationToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // editCommandsToolStripMenuItem
            // 
            this.editCommandsToolStripMenuItem.Name = "editCommandsToolStripMenuItem";
            this.editCommandsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editCommandsToolStripMenuItem.Text = "Commands";
            this.editCommandsToolStripMenuItem.Click += new System.EventHandler(this.openCommandsFile);
            // 
            // editConfigurationToolStripMenuItem
            // 
            this.editConfigurationToolStripMenuItem.Name = "editConfigurationToolStripMenuItem";
            this.editConfigurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editConfigurationToolStripMenuItem.Text = "Preferences";
            this.editConfigurationToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationFile);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(284, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.jungleTimerToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // switchGameToolStripMenuItem
            // 
            this.switchGameToolStripMenuItem.Name = "switchGameToolStripMenuItem";
            this.switchGameToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.switchGameToolStripMenuItem.Text = "Switch Game";
            this.switchGameToolStripMenuItem.Click += new System.EventHandler(this.openGameSwitchWindow);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // jungleTimerToolStripMenuItem
            // 
            this.jungleTimerToolStripMenuItem.Name = "jungleTimerToolStripMenuItem";
            this.jungleTimerToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.jungleTimerToolStripMenuItem.Text = "Jungle Timer";
            this.jungleTimerToolStripMenuItem.Click += new System.EventHandler(this.toggleJungle);
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem jungleTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editConfigurationToolStripMenuItem;
    }
}

