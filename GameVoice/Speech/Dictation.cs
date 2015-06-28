using GameVoice.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace GameVoice.Speech {
    class Dictation {

        private SpeechRecognitionEngine speechEngine;
        private bool enabled = false;

        public Dictation() {
            createRecognitionEngine();
        }

        private void createRecognitionEngine() {
            DictationGrammar defaultDictationGrammar = new DictationGrammar();
            defaultDictationGrammar.Name = "default dictation";
            defaultDictationGrammar.Enabled = true;
            SpeechRecognitionEngine speechEngine = new SpeechRecognitionEngine();
            speechEngine.LoadGrammar(defaultDictationGrammar);
            speechEngine.SetInputToDefaultAudioDevice();
            speechEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRecognized);
            speechEngine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(audioLevelUpdated);
            this.speechEngine = speechEngine;
        }

        private void audioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e) {
            AudioLevelUpdated.Invoke(sender, e);
        }

        private void speechRecognized(object sender, SpeechRecognizedEventArgs e) {
            if (e.Result.Confidence > .5)
                new Input().SendInputString(e.Result.Text);
        }

        internal bool toggle() {
            if (enabled) {
                speechEngine.RecognizeAsyncStop();
            } else {
                speechEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            enabled = !enabled;
            return enabled;
        }

        public EventHandler<AudioLevelUpdatedEventArgs> AudioLevelUpdated { get; set; }
    }
}
