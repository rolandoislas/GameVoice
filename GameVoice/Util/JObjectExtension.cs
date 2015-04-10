using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVoice.Util {
    public static class JObjectExtension {

        public static JObject findCommandObject(this JObject commands, string name) {
            foreach (JObject command in commands["commands"]) {
                if (command["text"].ToString().Equals(name)) {
                    return command;
                }
            }
            throw new Exception("Key not found.");
        }
    }
}
