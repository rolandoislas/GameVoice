using Newtonsoft.Json;
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
            string commandFilePath = Path.Combine(Config.configPath, "commands.json");
            string settingsFilePath = Path.Combine(Config.configPath, "settings.json");

            try {
                Directory.CreateDirectory(Config.configPath);
                if(!File.Exists(commandFilePath)) {
                    Stream commandInput = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GameVoice.Resources.Config.commands.json");
                    FileStream commandOutput = new FileStream(commandFilePath, FileMode.Create);
                    commandInput.CopyTo(commandOutput);
                    commandOutput.Close();
                }
                if(!File.Exists(settingsFilePath)) {
                    Stream settingsInput = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GameVoice.Resources.Config.settings.json");
                    FileStream settingsOutput = new FileStream(settingsFilePath, FileMode.Create);
                    settingsInput.CopyTo(settingsOutput);
                    settingsOutput.Close();
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Error Creating Configuration");
                Environment.Exit(1);
            }
        }

        private static void loadConfiguration() {
            string configFileString = File.ReadAllText(Path.Combine(Config.configPath, "settings.json"));
            configuration = JsonConvert.DeserializeObject<Config>(configFileString);
        }
    }
}
