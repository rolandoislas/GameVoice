
using System;
using System.IO;
namespace GameVoice {
    public class Config {

        // Configuration Files
        public static readonly string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GameVoice");
        public static readonly string[] configFileNames = {
                                                              "settings.json",
                                                              "commands-smite.json",
                                                              "commands-tf2.json"
                                                          };

        // User settings
        public float confidenceThreshold { get; set; }
        public bool disableLanguageCultureNotification { get; set; }
        public string activeGame { get; set; }
        public float failAlertThreshold { get; set; }

    }
}
