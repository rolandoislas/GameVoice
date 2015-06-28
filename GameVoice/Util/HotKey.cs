using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameVoice.Util {
    class HotKey {

        private int modifier;
        private int key;
        private IntPtr hWnd;
        private int id;

        public HotKey(int modifier, Keys key, Form form) {
            this.modifier = modifier;
            this.key = (int)key;
            this.hWnd = form.Handle;
            id = this.GetHashCode();
        }

        public override int GetHashCode() {
            return modifier ^ key ^ hWnd.ToInt32();
        }

        public bool register() {
            return RegisterHotKey(hWnd, id, (uint)modifier, (uint)key);
        }

        public bool unregister() {
            return UnregisterHotKey(hWnd, id);
        }

        #region hotkey user 32
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        internal enum Modifiers : uint {
            NOMOD = 0x0000,
            ALT = 0x0001,
            CTRL = 0x0002,
            SHIFT = 0x0003,
            WIN = 0x0008
        }
        #endregion
        public static class Constants {
            public const int NOMOD = 0x0000;
            public const int ALT = 0x0001;
            public const int CTRL = 0x0002;
            public const int SHIFT = 0x0004;
            public const int WIN = 0x0008;

            public const int WM_HOTKEY_MSG_ID = 0x0312;
        }
    }
}
