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
        private bool waitForDictationHotKeyInput;

        public SettingsEditWindow() {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += keyDown;
        }

        private void keyDown(object sender, KeyEventArgs e) {
            Console.Out.WriteLine(e.KeyCode);
            Console.Out.WriteLine(e.KeyData);
            Console.Out.WriteLine(e.KeyValue);
            if (waitForDictationHotKeyInput) {
                buttonDictationHotKey.Text = e.KeyCode.ToString();
                settings["dictationHotKey"] = e.KeyValue;
                waitForDictationHotKeyInput = false;
                buttonDictationHotKey.Enabled = true;
            }
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
            buttonDictationHotKey.Text = ((Keys)(int)settings["dictationHotKey"]).ToString();
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

        private void dictationHotKeyButtonClicked(object sender, EventArgs e) {
            if (waitForDictationHotKeyInput)
                return;
            buttonDictationHotKey.Text = "Press a key";
            buttonDictationHotKey.Enabled = false;
            waitForDictationHotKeyInput = true;
        }
    }
}
