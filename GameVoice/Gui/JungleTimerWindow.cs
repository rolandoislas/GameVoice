using GameVoice.Gui.Control;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GameVoice.Gui {
    public partial class JungleTimerWindow : Form {

        private Dictionary<string, int[]> timers = new Dictionary<string, int[]>();
        private int[] controlMargin = { 5, 3, 5, 5 };
        private int[] controlSize = { (int)(Screen.PrimaryScreen.Bounds.Width * 0.025), (int)(Screen.PrimaryScreen.Bounds.Height * (2D / 45D)) };
        private int leftMargin = (int)(Screen.PrimaryScreen.Bounds.Width * 0.03);
        private System.Timers.Timer loopTimer;

        private enum stateCode {
            RESET = 0, // Timer not countign down
            DOWN = 1 // Timer counting down
        }

        public JungleTimerWindow() {
            InitializeComponent();
            if (GameVoice.configurationGame.jungleTimer["userEnabled"].Value<bool>()) {
                initializeIndicators();
                initializeTimers();
                addSystemTimer();
            }
        }

        private void addSystemTimer() {
            loopTimer = new System.Timers.Timer();
            loopTimer.Elapsed += new ElapsedEventHandler(timerLoop);
            loopTimer.Interval = 1000;
            loopTimer.Start();
        }

        private void initializeTimers() {
            foreach (JProperty time in GameVoice.configurationGame.jungleTimer["time"]) {
                // Populate timers dictionary [name] -> [0] Status code, [1] time in seconds
                timers.Add(time.Name, new int[]{(int)stateCode.RESET, 0});
                resetTimer(time.Name);
            }
        }

        private void resetTimer(string name) {
            ((Label)this.flowLayoutPanel.Controls.Find("timeLabel" + name, false)[0]).ForeColor = Color.White;
            timers[name][1] = GameVoice.configurationGame.jungleTimer["time"][name].Value<int>();
            setTime(name, secondsToTimeString(timers[name][1]));
        }

        private string secondsToTimeString(int time) {
            string minutes = Math.Floor(time / 60D).ToString();
            string seconds = (time % 60).ToString().PadLeft(2, '0');
            string timeString = minutes + ":" + seconds;
            return timeString;
        }

        delegate void setTimeCallback(string labelName, string timestring);

        private void setTime(string labelName, string timeString) {
            Label label = (Label)this.flowLayoutPanel.Controls.Find("timeLabel" + labelName, false)[0];
            if (label.InvokeRequired) {
                setTimeCallback t = new setTimeCallback(setTime);
                this.Invoke(t, new Object[] { labelName, timeString });
            } else {
                label.Text = timeString;
            }
        }

        delegate void toggleLabelColorCallback(string name);

        private void toggleLabelColor(string name) {
            Label label = (Label)this.flowLayoutPanel.Controls.Find("timeLabel" + name, false)[0];
            if (label.InvokeRequired) {
                toggleLabelColorCallback t = new toggleLabelColorCallback(toggleLabelColor);
                this.Invoke(t, new Object[] { name });
            } else {
                label.ForeColor = (label.ForeColor == Color.White) ? Color.OrangeRed : Color.White;
            }
        }

        private void initializeIndicators() {
            // Add monster Images
            foreach (JProperty time in GameVoice.configurationGame.jungleTimer["time"]) {
                Image image = Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GameVoice.Resources.Image." + "jungle-" + GameVoice.configuration.activeGame + "-" + time.Name + ".png"));

                PictureBox monsterImage = new PictureBox();
                monsterImage.Image = image;
                monsterImage.Margin = new Padding(controlMargin[0], controlMargin[1], controlMargin[2], controlMargin[3]);
                monsterImage.Size = new Size(controlSize[0], controlSize[1]);
                monsterImage.Name = "monsterImage" + time.Name;
                monsterImage.Click += new System.EventHandler(timerClicked);
                monsterImage.SizeMode = PictureBoxSizeMode.StretchImage;

                this.toolTip.SetToolTip(monsterImage, time.Name.Substring(0, 1).ToUpper() + time.Name.Substring(1));
                this.flowLayoutPanel.Controls.Add(monsterImage);
            }
            // Add timer labels
            foreach (JProperty time in GameVoice.configurationGame.jungleTimer["time"]) {
                Label label = new Label();
                label.AutoSize = false;
                label.Margin = new Padding(0);
                label.Size = new Size(controlSize[0], controlSize[1]);
                label.Text = "";
                label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                label.ForeColor = Color.White;
                label.Name = "timeLabel" + time.Name;
                label.Width = controlSize[0] + controlMargin[0] + controlMargin[2];
                label.Height = controlSize[1] + controlMargin[1] + controlMargin[3];
                label.BackColor = Color.Transparent;

                this.flowLayoutPanel.Controls.Add(label);
            }
            // Set window to screen size
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            // Set flow panel size
            this.flowLayoutPanel.Size = new Size(GameVoice.configurationGame.jungleTimer["time"].ToArray().Length * (controlSize[0] + controlMargin[0] + controlMargin[2]), Screen.PrimaryScreen.Bounds.Height);
            // Add left margin to panel
            this.flowLayoutPanel.Location = new Point(leftMargin, 0);
            // Add backgroud to panel
            Image backgroundMonsterImage = Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GameVoice.Resources.Image." + "jungle-" + GameVoice.configuration.activeGame + "-monster-background.png"));
            Image backgroundTimerImage = Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GameVoice.Resources.Image." + "jungle-" + GameVoice.configuration.activeGame + "-monster-timer-background.png"));
            int test = backgroundTimerImage.Width;
            this.flowLayoutPanel.setImage(new Image[]{backgroundMonsterImage, backgroundTimerImage}, GameVoice.configurationGame.jungleTimer["time"].ToArray().Length);
            this.flowLayoutPanel.BackgroundImageLayout = ImageLayout.None;
            // Break flow of last image
            string lastTimerName = ((JProperty)GameVoice.configurationGame.jungleTimer["time"].Last).Name;
            this.flowLayoutPanel.SetFlowBreak(flowLayoutPanel.Controls.Find("monsterImage" + lastTimerName, false)[0], true);
        }

        private void timerClicked(object sender, EventArgs e) {
            int index = 0;
            if (sender.GetType() == typeof(PictureBox)) {
                index = "monsterImage".Length; // Who needs to count?
            } else {
                index = "timeLabel".Length; // Not me.
            }
            string name = ((System.Windows.Forms.Control)sender).Name.Substring(index);
            switch (timers[name][0]) {
                case (int)stateCode.RESET:
                    timers[name][0] = (int)stateCode.DOWN;
                    break;
                case (int)stateCode.DOWN:
                    resetTimer(name);
                    timers[name][0] = (int)stateCode.RESET;
                    break;
            }
        }

        private void timerLoop(object sender, EventArgs e) {
            foreach (JProperty time in GameVoice.configurationGame.jungleTimer["time"]) {
                if (timers[time.Name][0] == (int)stateCode.DOWN) {
                    if (timers[time.Name][1] > 0) {
                        timers[time.Name][1]--;
                        setTime(time.Name, secondsToTimeString(timers[time.Name][1]));
                    } else {
                        toggleLabelColor(time.Name);
                    }
                }
            }
        }

        internal void stopTimer() {
            loopTimer.Stop();
        }
    }
}
