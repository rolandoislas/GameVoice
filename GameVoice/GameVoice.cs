﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameVoice {
    static class GameVoice {

        public static Config configuration;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            createConfigs();
            loadConfiguration();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        private static void createConfigs() {
            try {
                Directory.CreateDirectory(Config.configPath);

                foreach(var fileName in typeof(ConfigFiles).GetFields()) {
                    string filePath = Path.Combine(Config.configPath, (string)fileName.GetValue(fileName));
                    if (!File.Exists(filePath)) {
                        Stream fileInput = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GameVoice.Resources.Config." + fileName.GetValue(fileName));
                        FileStream fileOutput = new FileStream(filePath, FileMode.Create);
                        fileInput.CopyTo(fileOutput);
                        fileOutput.Close();
                        fileInput.Close();
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Error Creating Configuration");
                Environment.Exit(1);
            }
        }

        private static void loadConfiguration() {
            string configFileString = File.ReadAllText(Path.Combine(Config.configPath, ConfigFiles.SETTINGS));
            configuration = JsonConvert.DeserializeObject<Config>(configFileString);
        }
    }
}
