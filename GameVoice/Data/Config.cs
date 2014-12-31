﻿
using System;
using System.IO;
namespace GameVoice {
    public class Config {

        // Configuration Files
        public static readonly string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GameVoice");
        public static readonly string[] configFileNames = {
                                                              "settings.json",
                                                              "commands.json"
                                                          };

        // User settings
        public float confidenceThreshold { get; set; }
        public bool disableLanguageCultureNotification { get; set; }

    }
}
