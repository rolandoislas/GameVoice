using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameVoice.Gui {
    public partial class SettingsEditWindow : Form {

        JObject settings;

        public SettingsEditWindow() {
            InitializeComponent();
        }

        private void init(object sender, EventArgs e) {
            loadSettings();
            populateControls();
        }

        private void populateControls() {
            trackBarConfidenceThreshold.Value = (int)(settings["confidenceThreshold"].Value<double>() * 100);
            confidenceThresholdScroll(null, null);
            trackBarFailAlertThreshold.Value = (int)(settings["failAlertThreshold"].Value<double>() * 100);
            failAlertThresholdScroll(null, null);
            checkBoxLanguageCultureNotification.Checked = !settings["disableLanguageCultureNotification"].Value<bool>();
        }

        private void loadSettings() {
            string settingsFileString = File.ReadAllText(Path.Combine(Config.configPath, ConfigFiles.SETTINGS));
            settings = JsonConvert.DeserializeObject<JObject>(settingsFileString);
        }

        private void confidenceThresholdScroll(object sender, EventArgs e) {
            labelConfidenceThresholdPercent.Text = trackBarConfidenceThreshold.Value.ToString() + "%";
            settings["confidenceThreshold"] = trackBarConfidenceThreshold.Value / 100D;
        }

        private void failAlertThresholdScroll(object sender, EventArgs e) {
            labelFailAlertThresholdPercent.Text = trackBarFailAlertThreshold.Value.ToString() + "%";
            settings["failAlertThreshold"] = trackBarFailAlertThreshold.Value / 100D;
        }

        private void languageCultureNotificationCheckboxClick(object sender, EventArgs e) {
            settings["disableLanguageCultureNotification"] = !checkBoxLanguageCultureNotification.Checked;
        }

        private void formClosing(object sender, FormClosingEventArgs e) {
            this.Enabled = false;
            string serialized = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(Path.Combine(Config.configPath, ConfigFiles.SETTINGS), serialized);
            GameVoice.loadConfiguration();
        }
    }
}
