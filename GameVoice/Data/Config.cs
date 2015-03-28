
using System;
using System.ComponentModel;
using System.IO;
namespace GameVoice {
    public class Config {

        // Configuration Files
        public static readonly string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GameVoice");

        // User settings
        public float confidenceThreshold { get; set; }
        public bool disableLanguageCultureNotification { get; set; }
        public string activeGame { get; set; }
        public float failAlertThreshold { get; set; }

    }

    public static class ConfigFiles {
        public static readonly string SETTINGS = "settings.json";
        public static readonly string COMMANDS_SMITE = "commands-smite.json";
        public static readonly string COMMANDS_TF2 = "commands-tf2.json";
        public static readonly string COMMANDS_LOL = "commands-lol.json";
        public static readonly string SETTINGS_SMITE = "settings-smite.json";
        public static readonly string SETTINGS_TF2 = "settings-tf2.json";
        public static readonly string SETTINGS_LOL = "settings-lol.json";
    }
}
