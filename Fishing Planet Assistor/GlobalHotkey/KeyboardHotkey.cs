using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GlobalHotkey
{
    public class KeyboardHotkey
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr windowProcess, int processID, int keyModifier, int keyShortcut);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr windowProcess, int processID);
    }
}
