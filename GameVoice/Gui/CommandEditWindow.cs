using GameVoice.Util;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameVoice.Gui {
    public partial class CommandEditWindow : Form {

        private JObject commands;
        private string activeItem;

        public CommandEditWindow() {
            InitializeComponent();
        }

        private void init(object sender, EventArgs e) {
            loadCommands();
            initializeDropdown();
        }

        private void initializeDropdown() {
            initializeDropdown(0, null);
        }

        private void initializeDropdown(string itemName) {
            initializeDropdown(0, itemName);
        }

        private void initializeDropdown(int index) {
            initializeDropdown(index, null);
        }

        private void initializeDropdown(int index, string itemName) {
            SortedDictionary<string, string> items = new SortedDictionary<string, string>();
            items.Add("[Main command]", commands["mainCommand"].Value<string>());
            foreach (JObject command in commands["commands"]) {
                if (!items.ContainsKey(command["text"].Value<string>()))
                    items.Add(command["text"].Value<string>(), command["command"].Value<string>());
            }
            comboBoxMain.DataSource = new BindingSource(items, null);
            comboBoxMain.DisplayMember = "Key";
            comboBoxMain.ValueMember = "Value";
            if (itemName != null) {
                index = 0;
                foreach (KeyValuePair<string, string> item in items) {
                    if (item.Key.Equals(itemName)) {
                        break;
                    }
                    index++;
                }
            }
            comboBoxMain.SelectedIndex = index;
            itemSelected(null, null);
        }

        private void loadCommands() {
            string commandsFileString = File.ReadAllText(Path.Combine(Config.configPath, "commands-" + GameVoice.configuration.activeGame + ".json"));
            commands = JsonConvert.DeserializeObject<JObject>(commandsFileString);
        }

        private void itemSelected(object sender, EventArgs e) {
            if (comboBoxMain.SelectedIndex > 0) {
                textBoxVoiceCommand.Text = ((KeyValuePair<string, string>)comboBoxMain.SelectedItem).Key;
                textBoxMacro.Text = ((KeyValuePair<string, string>)comboBoxMain.SelectedItem).Value;
                textBoxMacro.Enabled = true;
                buttonDelete.Enabled = true;
            } else {
                textBoxVoiceCommand.Text = ((KeyValuePair<string, string>)comboBoxMain.SelectedItem).Value;
                textBoxMacro.Clear();
                textBoxMacro.Enabled = false;
                buttonDelete.Enabled = false;
            }
            activeItem = textBoxVoiceCommand.Text;
        }

        private void voiceCommandChanged(object sender, EventArgs e) {
            string text = textBoxVoiceCommand.Text;
            if (!voiceCommandValid(text))
                return;
            if (comboBoxMain.SelectedIndex > 0 && text.Length >= 1) {
                JObject command = commands.findCommandObject(activeItem);
                command["text"] = text;
                initializeDropdown(text);
            } else {
                commands["mainCommand"] = text;
                initializeDropdown();
            }
        }

        private bool voiceCommandValid(string command) {
            Regex regex = new Regex("^[a-zA-Z ]*$");
            if (regex.IsMatch(command))
                return true;
            return false;
        }

        private void macroChanged(object sender, EventArgs e) {
            if (comboBoxMain.SelectedIndex == 0)
                return;
            string text = textBoxMacro.Text;
            JObject command = commands.findCommandObject(((KeyValuePair<string, string>)comboBoxMain.SelectedItem).Key);
            command["command"] = text;
        }

        private void writeCommands(object sender, EventArgs e) {
            this.Enabled = false;
            string commandsSerialized = JsonConvert.SerializeObject(commands, Formatting.Indented);
            File.WriteAllText(Path.Combine(Config.configPath, "commands-" + GameVoice.configuration.activeGame + ".json"), commandsSerialized);
            GameVoice.loadConfiguration();
            this.Close();
        }

        private void deleteCommand(object sender, EventArgs e) {
            JObject command = commands.findCommandObject(((KeyValuePair<string, string>)comboBoxMain.SelectedItem).Key);
            command.Remove();
            initializeDropdown(0);
        }

        private void addCommand(object sender, EventArgs e) {
            try {
                JObject command = commands.findCommandObject("[New Command]");
                initializeDropdown(1);
                return;
            } catch { }
            JObject newCommand = new JObject();
            newCommand.Add("text", "[New Command]");
            newCommand.Add("command", "");
            ((JArray)commands["commands"]).Add(newCommand);
            initializeDropdown(1);
        }

        private void saveCommand(object sender, EventArgs e) {
            macroChanged(sender, e);
            voiceCommandChanged(sender, e);
        }
    }
}
