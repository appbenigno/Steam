using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowHook;
using System.Windows.Forms;
using GlobalHotkey;

namespace Fishing_Planet_Assistor
{
    class globals
    {
        public static IntPtr windowProcess;
        public static int windowID;

        public static string programClass = "UnityWndClass";
        public static string processName = "-";
        public static string programName = "FishingPlanet";
        //public static string programClass = "Notepad";
        //public static string programName = "Untitled - Notepad";

        // Get a handle to the Program application. The window class
        // and window name were obtained using the Spy++ tool.
        public static IntPtr programHandle; 
        public static IntPtr parentHandle; 

        /// <summary>
        /// Verify that the program is a running process
        /// </summary>
        /// <returns></returns>
        public static bool isLoaded()
        {
            programHandle = WinHook.FindWindow(globals.programClass, globals.programName);
            parentHandle = WinHook.FindWindow(null, "Fishing Planet Assistor");
            if (programHandle == IntPtr.Zero)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Register the hotkeys
        /// </summary>
        public static void registerHotkeys()
        {
            Boolean successF9 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.F9.GetHashCode());//Set hotkey as 'F9'
            if (!successF9) { MessageBox.Show("'F9' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successPause = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.Pause.GetHashCode());//Set hotkey as 'Pause/Break'
            if (!successPause) { MessageBox.Show("'PAUSE/BREAK' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpadPeriod = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.Decimal.GetHashCode());//Set hotkey as 'Numpad.'
            if (!successNumpadPeriod) { MessageBox.Show("'NUMPAD (.)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad0 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad0.GetHashCode());//Set hotkey as 'Numpad0'
            if (!successNumpad0) { MessageBox.Show("'NUMPAD (0)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad1 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad1.GetHashCode());//Set hotkey as 'Numpad1'
            if (!successNumpad1) { MessageBox.Show("'NUMPAD (1)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad2 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad2.GetHashCode());//Set hotkey as 'Numpad2'
            if (!successNumpad2) { MessageBox.Show("'NUMPAD (2)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad3 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad3.GetHashCode());//Set hotkey as 'Numpad3'
            if (!successNumpad3) { MessageBox.Show("'NUMPAD (3)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad4 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad4.GetHashCode());//Set hotkey as 'Numpad4'
            if (!successNumpad4) { MessageBox.Show("'NUMPAD (4)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad5 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad5.GetHashCode());//Set hotkey as 'Numpad5'
            if (!successNumpad5) { MessageBox.Show("'NUMPAD (5)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad6 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad6.GetHashCode());//Set hotkey as 'Numpad6'
            if (!successNumpad6) { MessageBox.Show("'NUMPAD (6)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad7 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad7.GetHashCode());//Set hotkey as 'Numpad7'
            if (!successNumpad6) { MessageBox.Show("'NUMPAD (7)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad8 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad8.GetHashCode());//Set hotkey as 'Numpad8'
            if (!successNumpad6) { MessageBox.Show("'NUMPAD (8)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Boolean successNumpad9 = KeyboardHotkey.RegisterHotKey(globals.windowProcess, globals.windowID, Keys.None.GetHashCode(), Keys.NumPad9.GetHashCode());//Set hotkey as 'Numpad9'
            if (!successNumpad6) { MessageBox.Show("'NUMPAD (9)' could not be registered. It is in use by another program.", "Hotkey Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }

    /// <summary>
    /// Single instance windows forms
    /// </summary>
    class MyForms
    {
        private static Form MF;
        public static Form MainForm
        {
            get
            {
                if (MF == null)
                {
                    MF = new MainForm();
                }
                return MF;
            }
        }

        private static Form ABox;
        public static Form AboutBox
        {
            get
            {
                if (ABox == null)
                {
                    ABox = new AboutBox();
                }
                return ABox;
            }
            
        }

        private static Form PList;
        public static Form ProcessList
        {
            get
            {
                if (PList == null)
                {
                    PList = new frmProcessList();
                }
                return PList;
            }
        }
    }
    class fileStructure
    {
        public static string settingsPath = "settings";
    }
}
