namespace GameVoice.Gui {
    partial class GameSwitchWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSwitchWindow));
            this.smiteButton = new System.Windows.Forms.Button();
            this.tf2Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smiteButton
            // 
            this.smiteButton.Location = new System.Drawing.Point(12, 12);
            this.smiteButton.Name = "smiteButton";
            this.smiteButton.Size = new System.Drawing.Size(75, 23);
            this.smiteButton.TabIndex = 0;
            this.smiteButton.Text = "Smite";
            this.smiteButton.UseVisualStyleBackColor = true;
            this.smiteButton.Click += new System.EventHandler(this.doChangeGame);
            // 
            // tf2Button
            // 
            this.tf2Button.Location = new System.Drawing.Point(94, 11);
            this.tf2Button.Name = "tf2Button";
            this.tf2Button.Size = new System.Drawing.Size(75, 23);
            this.tf2Button.TabIndex = 1;
            this.tf2Button.Text = "TF2";
            this.tf2Button.UseVisualStyleBackColor = true;
            this.tf2Button.Click += new System.EventHandler(this.doChangeGame);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "LoL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.doChangeGame);
            // 
            // GameSwitchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 76);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tf2Button);
            this.Controls.Add(this.smiteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSwitchWindow";
            this.ShowIcon = false;
            this.Text = "Change Game";
            this.Activated += new System.EventHandler(this.formActivated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button smiteButton;
        private System.Windows.Forms.Button tf2Button;
        private System.Windows.Forms.Button button1;



    }
}