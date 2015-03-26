using GameVoice.Gui;
using GameVoice.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace GameVoice {
    public partial class MainWindow : Form {

        private SpeechRecognitionEngine speechRecognitionEngine = null;
        List<Command> commands = new List<Command>();
        private string mainCommand =  "";

        public MainWindow() {
            InitializeComponent();
            initializeRecognizer();
        }

        private void initializeRecognizer() {
            initializeRecognizer(true);
        }

        private void initializeRecognizer(bool firstRun) {
            try {
                // Create speech engine
                speechRecognitionEngine = createSpeechEngine("en-US", firstRun);

                // Create events
                speechRecognitionEngine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(engine_AudioLevelUpdated);
                speechRecognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);

                // Load dictionary
                loadGrammar();

                // Use default microphone
                speechRecognitionEngine.SetInputToDefaultAudioDevice();

                // Start listening
                speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);

                writeResult("Speech recognition started.", true);
                writeResult("Now listening for " + GameVoice.configuration.activeGame + " commands.");
            } catch (Exception e) {
                MessageBox.Show(e.Message + e.StackTrace, "Could not start voice recognition.");
                Application.Exit();
            }
        }

        private void loadGrammar() {
            try {
                Choices grammarChoices = new Choices();
                string commandsJson = File.ReadAllText(Path.Combine(Config.configPath, getCommandsFileName()));

                Dictionary<string, object> commandConfig = JsonConvert.DeserializeObject<Dictionary<string, object>>(commandsJson);
                mainCommand = (String) commandConfig["mainCommand"];
                foreach (object command in (JArray)commandConfig["commands"]) {
                    Command singleCommand = JsonConvert.DeserializeObject<Command>(command.ToString());
                    this.commands.Add(singleCommand);
                    grammarChoices.Add(getMainCommand() + singleCommand.text);
                }

                Grammar grammarList = new Grammar(new GrammarBuilder(grammarChoices));
                speechRecognitionEngine.LoadGrammar(grammarList);
            } catch (Exception e) {
                throw e;
            }
        }

        private string getCommandsFileName() {
            string currentGame = "commands-" + GameVoice.configuration.activeGame + ".json";
            foreach(var configFile in typeof(ConfigFiles).GetFields()) {
                if(currentGame.Equals(configFile.GetValue(configFile))) {
                    return (string)configFile.GetValue(configFile);
                }
            }
            throw new Exception("Command file " + currentGame + " not found.");
        }

        private string getMainCommand() {
            return mainCommand.Equals("") ? "" : mainCommand + " ";
        }

        private void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            outputResult(e.Result);
            if(aboveConfidenceThreshold(e.Result.Confidence)) {
                string command = getCommandFromVoiceResult(e.Result.Text);
                if (command != null) {
                    User32 sendInput = new User32();
                    sendInput.SendInputString(command);
                }
            } else if(e.Result.Confidence > GameVoice.configuration.failAlertThreshold) {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private string getCommandFromVoiceResult(string voiceResult) {
            try {
                var command = commands.Where(c => (getMainCommand() + c.text).Equals(voiceResult)).First();
                return command.command;
            } catch (Exception) {
                return null;
            }
        }

        private bool aboveConfidenceThreshold(float confidence) {
            return confidence > GameVoice.configuration.confidenceThreshold;
        }

        private void outputResult(RecognitionResult result) {
            writeResult("Command: " + result.Text, true);
            writeResult("Confidence: " + result.Confidence.ToString());
            writeResult("Above Confidence Threshold: " + aboveConfidenceThreshold(result.Confidence));
        }

        private void engine_AudioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e) {
            micLevelBar.Value = e.AudioLevel;
        }

        private SpeechRecognitionEngine createSpeechEngine(string culture, bool firstRun) {
            foreach(RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers()) {
                if (config.Culture.ToString().Equals(culture)) {
                    speechRecognitionEngine = new SpeechRecognitionEngine(config);
                    break;
                }
            }

            if(speechRecognitionEngine == null) {
                if(firstRun && !GameVoice.configuration.disableLanguageCultureNotification) {
                    MessageBox.Show("Language " + culture + " not found. Using " + SpeechRecognitionEngine.InstalledRecognizers()[0].Culture.ToString() + ".", "Language " + culture + " not found.");
                }
                speechRecognitionEngine = new SpeechRecognitionEngine(SpeechRecognitionEngine.InstalledRecognizers()[0]);
            }

            return speechRecognitionEngine;
        }

        private void writeResult(string text) {
            writeResult(text, false);
        }

        private void writeResult(string text, bool clear) {
            if(clear) {
                textBox.Clear();
            }
            textBox.AppendText(text + Environment.NewLine);
        }

        private void openConfigurationFile(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(@Path.Combine(Config.configPath, ConfigFiles.SETTINGS));
        }

        private void openCommandsFile(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(@Path.Combine(Config.configPath, getCommandsFileName()));
        }

        private void openGameSwitchWindow(object sender, EventArgs e) {
            GameSwitchWindow window = new GameSwitchWindow();
            window.ButtonClicked += new EventHandler(reloadRecognizer);
            window.ShowDialog();
        }

        private void reloadRecognizer(object sender, EventArgs e) {
            speechRecognitionEngine.RecognizeAsyncStop();
            speechRecognitionEngine = null;
            commands = new List<Command>();
            initializeRecognizer(false);
        }

    }
}
