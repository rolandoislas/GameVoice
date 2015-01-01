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
    public partial class GameSwitchWindow : Form {

        public event EventHandler ButtonClicked;

        public GameSwitchWindow() {
            InitializeComponent();
        }

        private void doChangeGame(object sender, EventArgs e) {
            string game = ((Button)sender).Text.ToLower();
            updateSettingsJson(game);
            GameVoice.configuration.activeGame = game;
            ButtonClicked(this, e);
            this.Close();
        }

        private void updateSettingsJson(string game) {
            string settingsFilePath = Path.Combine(Config.configPath, Config.configFileNames[0]);
            
            JObject config = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(settingsFilePath));
            config.Property("activeGame").Value = game;
            string configSerialized = JsonConvert.SerializeObject(config, Formatting.Indented);

            File.WriteAllText(settingsFilePath, configSerialized);
        }

        private void formActivated(object sender, EventArgs e) {
            this.CenterToParent();
        }
    }
}
