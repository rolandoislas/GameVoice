namespace GameVoice.Gui {
    partial class SettingsEditWindow {
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
            this.labelConfidenceThreshold = new System.Windows.Forms.Label();
            this.trackBarConfidenceThreshold = new System.Windows.Forms.TrackBar();
            this.labelFailAlertThreshold = new System.Windows.Forms.Label();
            this.trackBarFailAlertThreshold = new System.Windows.Forms.TrackBar();
            this.checkBoxLanguageCultureNotification = new System.Windows.Forms.CheckBox();
            this.labelConfidenceThresholdPercent = new System.Windows.Forms.Label();
            this.labelFailAlertThresholdPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarConfidenceThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFailAlertThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConfidenceThreshold
            // 
            this.labelConfidenceThreshold.AutoSize = true;
            this.labelConfidenceThreshold.Location = new System.Drawing.Point(12, 9);
            this.labelConfidenceThreshold.Name = "labelConfidenceThreshold";
            this.labelConfidenceThreshold.Size = new System.Drawing.Size(111, 13);
            this.labelConfidenceThreshold.TabIndex = 0;
            this.labelConfidenceThreshold.Text = "Confidence Threshold";
            // 
            // trackBarConfidenceThreshold
            // 
            this.trackBarConfidenceThreshold.LargeChange = 1;
            this.trackBarConfidenceThreshold.Location = new System.Drawing.Point(129, 9);
            this.trackBarConfidenceThreshold.Maximum = 100;
            this.trackBarConfidenceThreshold.Name = "trackBarConfidenceThreshold";
            this.trackBarConfidenceThreshold.Size = new System.Drawing.Size(108, 45);
            this.trackBarConfidenceThreshold.TabIndex = 1;
            this.trackBarConfidenceThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarConfidenceThreshold.Scroll += new System.EventHandler(this.confidenceThresholdScroll);
            // 
            // labelFailAlertThreshold
            // 
            this.labelFailAlertThreshold.AutoSize = true;
            this.labelFailAlertThreshold.Location = new System.Drawing.Point(26, 38);
            this.labelFailAlertThreshold.Name = "labelFailAlertThreshold";
            this.labelFailAlertThreshold.Size = new System.Drawing.Size(97, 13);
            this.labelFailAlertThreshold.TabIndex = 2;
            this.labelFailAlertThreshold.Text = "Fail Alert Threshold";
            // 
            // trackBarFailAlertThreshold
            // 
            this.trackBarFailAlertThreshold.LargeChange = 1;
            this.trackBarFailAlertThreshold.Location = new System.Drawing.Point(129, 34);
            this.trackBarFailAlertThreshold.Maximum = 100;
            this.trackBarFailAlertThreshold.Name = "trackBarFailAlertThreshold";
            this.trackBarFailAlertThreshold.Size = new System.Drawing.Size(108, 45);
            this.trackBarFailAlertThreshold.TabIndex = 3;
            this.trackBarFailAlertThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarFailAlertThreshold.Scroll += new System.EventHandler(this.failAlertThresholdScroll);
            // 
            // checkBoxLanguageCultureNotification
            // 
            this.checkBoxLanguageCultureNotification.AutoSize = true;
            this.checkBoxLanguageCultureNotification.Location = new System.Drawing.Point(15, 79);
            this.checkBoxLanguageCultureNotification.Name = "checkBoxLanguageCultureNotification";
            this.checkBoxLanguageCultureNotification.Size = new System.Drawing.Size(166, 17);
            this.checkBoxLanguageCultureNotification.TabIndex = 5;
            this.checkBoxLanguageCultureNotification.Text = "Language Culture Notification";
            this.checkBoxLanguageCultureNotification.UseVisualStyleBackColor = true;
            this.checkBoxLanguageCultureNotification.Click += new System.EventHandler(this.languageCultureNotificationCheckboxClick);
            // 
            // labelConfidenceThresholdPercent
            // 
            this.labelConfidenceThresholdPercent.AutoSize = true;
            this.labelConfidenceThresholdPercent.Location = new System.Drawing.Point(238, 9);
            this.labelConfidenceThresholdPercent.Name = "labelConfidenceThresholdPercent";
            this.labelConfidenceThresholdPercent.Size = new System.Drawing.Size(0, 13);
            this.labelConfidenceThresholdPercent.TabIndex = 8;
            // 
            // labelFailAlertThresholdPercent
            // 
            this.labelFailAlertThresholdPercent.AutoSize = true;
            this.labelFailAlertThresholdPercent.Location = new System.Drawing.Point(238, 38);
            this.labelFailAlertThresholdPercent.Name = "labelFailAlertThresholdPercent";
            this.labelFailAlertThresholdPercent.Size = new System.Drawing.Size(0, 13);
            this.labelFailAlertThresholdPercent.TabIndex = 9;
            // 
            // SettingsEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 105);
            this.Controls.Add(this.labelFailAlertThresholdPercent);
            this.Controls.Add(this.labelConfidenceThresholdPercent);
            this.Controls.Add(this.checkBoxLanguageCultureNotification);
            this.Controls.Add(this.trackBarFailAlertThreshold);
            this.Controls.Add(this.labelFailAlertThreshold);
            this.Controls.Add(this.trackBarConfidenceThreshold);
            this.Controls.Add(this.labelConfidenceThreshold);
            this.MaximizeBox = false;
            this.Name = "SettingsEditWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.init);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarConfidenceThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFailAlertThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConfidenceThreshold;
        private System.Windows.Forms.TrackBar trackBarConfidenceThreshold;
        private System.Windows.Forms.Label labelFailAlertThreshold;
        private System.Windows.Forms.TrackBar trackBarFailAlertThreshold;
        private System.Windows.Forms.CheckBox checkBoxLanguageCultureNotification;
        private System.Windows.Forms.Label labelConfidenceThresholdPercent;
        private System.Windows.Forms.Label labelFailAlertThresholdPercent;
    }
}