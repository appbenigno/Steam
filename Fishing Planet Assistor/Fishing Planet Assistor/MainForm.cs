using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowHook;
using GlobalHotkey;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.XmlConfiguration;
using System.Xml.XPath;
using System.Xml.Linq;
using System.IO;
using Assistor;

namespace Fishing_Planet_Assistor
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Main Form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            globals.windowProcess = this.Handle;
            globals.windowID = this.GetType().GetHashCode();

            globals.registerHotkeys();
        }

        /// <summary>
        /// Instances
        /// </summary>
        FishingMode casting = new FishingMode();
        FishingMode spinning = new FishingMode();
        FishingMode floating = new FishingMode();
        Flags AutoCatch = new Flags();
        Flags Twitch = new Flags();
        Flags SlowStraight = new Flags();
        Flags Straight = new Flags();
        Flags StopGo = new Flags();
        Flags LiftDrop = new Flags();
        Flags Tease = new Flags();
        
        /// <summary>
        /// Public Controls
        /// </summary>
        public bool FloatingSelected
        {
            get { return radFloating.Checked; }
            set { radFloating.Checked = value; }
        }
        public bool CastingSelected
        {
            get { return radCasting.Checked; }
            set { radCasting.Checked = value; }
        }
        public bool SpinningSelected
        {
            get { return radSpinning.Checked; }
            set { radSpinning.Checked = value; }
        }

        /// <summary>
        /// Enumeration List
        /// </summary>
        /// 
        enum Keyboard
        {
            None = Keys.None,
            F9 = 7864320,
            PauseBreak = 1245184,
            NumpadDecimal = 7208960,
            Numpad0 = 6291456,
            Numpad1 = 6356992,
            Numpad2 = 6422528,
            Numpad3 = 6488064,
            Numpad4 = 6553600,
            Numpad5 = 6619136,
            Numpad6 = 6684672,
            Numpad7 = 6750208,
            Numpad8 = 6815744,
            Numpad9 = 6881280
        }

        /// <summary>
        /// Process Window
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const uint WM_HOTKEY = 0x0312;
            int keyID = m.LParam.GetHashCode();

            if (m.Msg == WM_HOTKEY)
            {
                if (keyID == Keyboard.F9.GetHashCode()) //F9
                {
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        fishing.focusProgram();
                        this.WindowState = FormWindowState.Normal;
                        this.Activate();
                    }
                    else if (this.WindowState == FormWindowState.Normal)
                    {
                        fishing.focusParent();
                        this.WindowState = FormWindowState.Minimized;
                    }
                }
                else if (keyID == Keyboard.PauseBreak.GetHashCode()) //Pause or Break
                {
                    Flags.destroy("AutoCatch");
                    Flags.destroy("SlowStraight");
                    Flags.destroy("Straight");
                    Flags.destroy("Twitch");
                    Flags.destroy("StopGo");
                    Flags.destroy("LiftDrop");
                    Flags.destroy("Tease");
                    tReelState(false);
                    tJerkState(false);
                    timerReeling.Enabled = false;
                    timerJerking.Enabled = false;
                    notifyTray("Pause / Break", "All keys pressed reset.");
                }
                else if (keyID == Keyboard.NumpadDecimal.GetHashCode() && globals.isLoaded()) //Numpad Decimal
                {
                    fishing.resetReelingSpeed();
                    notifyTray("Reset Reeling Speed", "Speed = 1");
                }
                else if (keyID == Keyboard.Numpad0.GetHashCode() && globals.isLoaded()) //Numpad 0
                {
                    if (Flags.isRaised("AutoCatch"))
                    {
                        Flags.destroy("AutoCatch");
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        fishing.resetReelingSpeed();
                        notifyTray("Auto-catching", "OFF");
                    }
                    else if (!Flags.isRaised("AutoCatch"))
                    {
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        Flags.destroy("AutoCatch");
                        Flags.destroy("SlowStraight");
                        Flags.destroy("Straight");
                        Flags.destroy("Twitch");
                        Flags.destroy("StopGo");
                        Flags.destroy("LiftDrop");
                        Flags.destroy("Tease");

                        Flags.raise("AutoCatch");
                        retrievePlain.Select();
                        fishing.focusProgram();
                        fishing.setReelingSpeed(Convert.ToInt32(numSpeed.Value));

                        if (radFloating.Checked)
                        {
                            tJerkTemp.Enabled = true;
                        }
                        timerJerking.Enabled = true;
                        timerReeling.Enabled = true;
                        notifyTray("Auto-catching", "ON");
                    }
                }
                else if (keyID == Keyboard.Numpad1.GetHashCode() && globals.isLoaded()) //Numpad 1
                {
                    if (Flags.isRaised("SlowStraight"))
                    {
                        Flags.destroy("SlowStraight");
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        fishing.resetReelingSpeed();
                        notifyTray("Slow-Straight", "OFF");
                    }
                    else if (!Flags.isRaised("SlowStraight"))
                    {
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        Flags.destroy("AutoCatch");
                        Flags.destroy("SlowStraight");
                        Flags.destroy("Straight");
                        Flags.destroy("Twitch");
                        Flags.destroy("StopGo");
                        Flags.destroy("LiftDrop");
                        Flags.destroy("Tease");

                        Flags.raise("SlowStraight");
                        retrieveSlowStraight.Select();
                        fishing.focusProgram();
                        fishing.setReelingSpeed(Convert.ToInt32(numSpeed.Value));
                        timerReeling.Enabled = true;
                        timerJerking.Enabled = true;
                        notifyTray("Slow-Straight", "ON");
                    }
                }
                else if (keyID == Keyboard.Numpad2.GetHashCode() && globals.isLoaded()) //Numpad 2
                {
                    if (Flags.isRaised("Straight"))
                    {
                        Flags.destroy("Straight");
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        fishing.resetReelingSpeed();
                        notifyTray("Straight", "OFF");
                    }
                    else if (!Flags.isRaised("Straight"))
                    {
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        Flags.destroy("AutoCatch");
                        Flags.destroy("SlowStraight");
                        Flags.destroy("Straight");
                        Flags.destroy("Twitch");
                        Flags.destroy("StopGo");
                        Flags.destroy("LiftDrop");
                        Flags.destroy("Tease");

                        Flags.raise("Straight");
                        retrieveStraight.Select();
                        fishing.focusProgram();
                        fishing.setReelingSpeed(Convert.ToInt32(numSpeed.Value));
                        timerReeling.Enabled = true;
                        timerJerking.Enabled = true;
                        notifyTray("Straight", "ON");
                    }
                }
                else if (keyID == Keyboard.Numpad3.GetHashCode() && globals.isLoaded()) //Numpad 3
                {
                    if (Flags.isRaised("Twitch"))
                    {
                        Flags.destroy("Twitch");
                        tReelState(false);
                        tJerkState(false);
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        fishing.resetReelingSpeed();
                        notifyTray("Twitch", "OFF");
                    }
                    else if (!Flags.isRaised("Twitch"))
                    {
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        Flags.destroy("AutoCatch");
                        Flags.destroy("SlowStraight");
                        Flags.destroy("Straight");
                        Flags.destroy("Twitch");
                        Flags.destroy("StopGo");
                        Flags.destroy("LiftDrop");
                        Flags.destroy("Tease");

                        Flags.raise("Twitch");
                        retrieveTwitch.Select();
                        fishing.focusProgram();
                        fishing.setReelingSpeed(Convert.ToInt32(numSpeed.Value));
                        timerReeling.Enabled = true;
                        timerJerking.Enabled = true;
                        notifyTray("Twitch", "ON");
                    }
                }
                else if (keyID == Keyboard.Numpad4.GetHashCode() && globals.isLoaded()) //Numpad 4
                {
                    if (Flags.isRaised("StopGo"))
                    {
                        Flags.destroy("StopGo");
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        fishing.resetReelingSpeed();
                        notifyTray("Stop & Go", "OFF");
                    }
                    else if (!Flags.isRaised("StopGo"))
                    {
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        Flags.destroy("AutoCatch");
                        Flags.destroy("SlowStraight");
                        Flags.destroy("Straight");
                        Flags.destroy("Twitch");
                        Flags.destroy("StopGo");
                        Flags.destroy("LiftDrop");
                        Flags.destroy("Tease");

                        Flags.raise("StopGo");
                        retrieveStopGo.Select();
                        fishing.focusProgram();
                        fishing.setReelingSpeed(Convert.ToInt32(numSpeed.Value));
                        timerReeling.Enabled = true;
                        timerJerking.Enabled = true;
                        notifyTray("Stop & Go", "ON");
                    }
                }
                else if (keyID == Keyboard.Numpad5.GetHashCode() && globals.isLoaded()) //Numpad 5
                {
                    if (Flags.isRaised("LiftDrop"))
                    {
                        Flags.destroy("LiftDrop");
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        fishing.resetReelingSpeed();
                        notifyTray("Lift & Drop", "OFF");
                    }
                    else if (!Flags.isRaised("LiftDrop"))
                    {
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        Flags.destroy("AutoCatch");
                        Flags.destroy("SlowStraight");
                        Flags.destroy("Straight");
                        Flags.destroy("Twitch");
                        Flags.destroy("StopGo");
                        Flags.destroy("LiftDrop");
                        Flags.destroy("Tease");

                        Flags.raise("LiftDrop");
                        retrieveLiftDrop.Select();
                        fishing.focusProgram();
                        fishing.setReelingSpeed(Convert.ToInt32(numSpeed.Value));
                        timerReeling.Enabled = true;
                        timerJerking.Enabled = true;
                        notifyTray("Lift & Drop", "ON");
                    }
                }
                else if (keyID == Keyboard.Numpad6.GetHashCode() && globals.isLoaded()) //Numpad 6
                {
                    if (Flags.isRaised("Tease"))
                    {
                        Flags.destroy("Tease");
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        fishing.resetReelingSpeed();
                        notifyTray("Teasing", "OFF");
                    }
                    else if (!Flags.isRaised("Tease"))
                    {
                        tReelState(false);
                        tJerkState(false);
                        timerReeling.Enabled = false;
                        timerJerking.Enabled = false;
                        Flags.destroy("AutoCatch");
                        Flags.destroy("SlowStraight");
                        Flags.destroy("Straight");
                        Flags.destroy("Twitch");
                        Flags.destroy("StopGo");
                        Flags.destroy("LiftDrop");
                        Flags.destroy("Tease");

                        Flags.raise("Tease");
                        retrieveTease.Select();
                        fishing.focusProgram();
                        fishing.setReelingSpeed(Convert.ToInt32(numSpeed.Value));
                        timerReeling.Enabled = true;
                        timerJerking.Enabled = true;
                        notifyTray("Teasing", "ON");
                    }
                }
                else if (keyID == Keyboard.Numpad7.GetHashCode()) //Numpad 7
                {
                    radFloating.Select();
                    retrievePlain.Select();
                    notifyTray("Float Fishing","Selected");
                }
                else if (keyID == Keyboard.Numpad8.GetHashCode()) //Numpad 8
                {
                    radSpinning.Select();
                    notifyTray("Spin Fishing", "Selected");
                }
                else if (keyID == Keyboard.Numpad9.GetHashCode()) //Numpad 9
                {
                    radCasting.Select();
                    notifyTray("Cast Fishing", "Selected");
                }

                //statusKeys.Text = keyID.ToString();
                updateStatusBar();
            }
            base.WndProc(ref m);
        }

        //
        // Update Status Bar
        //
        public void updateStatusBar()
        {
            statusKeys.Text = string.Concat("~~ Assistor v", AboutBox.AssemblyVersion);
            if (fishing.isLoaded())
            {
                statusLabel.Text = string.Concat("Fishing Planet", " (LOADED!)");
            }
            else
            {
                statusLabel.Text = string.Concat("Fishing Planet", " (NOT FOUND!)");
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            globals.programHandle = WinHook.FindWindow(globals.programClass, globals.programName);
            globals.parentHandle = WinHook.FindWindow(null, "Fishing Planet Assistor");
            updateStatusBar();
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
            updateStatusBar();
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            updateStatusBar();
        }

        //
        // Update Settings
        //
        private void getSettings(RetrievalMethod rm)
        {
            numReeling.Value = rm.ReelInterval;
            numJerking.Value = rm.JerkInterval;
            numSpeed.Value = rm.Speed;
            numReelPulse.Value = rm.ReelPulse;
            numJerkPulse.Value = rm.JerkPulse;
        }
        
        public void updateSettings()
        {
            // Float Fishing
            if (radFloating.Checked && retrievePlain.Checked)
            {
                getSettings(floating.Retrieve);
            }

            // Cast Fishing
            if (radCasting.Checked && retrievePlain.Checked)
            {
                getSettings(casting.Retrieve);
            }
            else if (radCasting.Checked && retrieveSlowStraight.Checked)
            {
                getSettings(casting.SlowStraight);
            }
            else if (radCasting.Checked && retrieveStraight.Checked)
            {
                getSettings(casting.Straight);
            }
            else if (radCasting.Checked && retrieveStopGo.Checked)
            {
                getSettings(casting.StopGo);
            }
            else if (radCasting.Checked && retrieveTwitch.Checked)
            {
                getSettings(casting.Twitch);
            }
            else if (radCasting.Checked && retrieveLiftDrop.Checked)
            {
                getSettings(casting.LiftDrop);
            }

            // Spin Fishing
            if (radSpinning.Checked && retrievePlain.Checked)
            {
                getSettings(spinning.Retrieve);
            }
            else if (radSpinning.Checked && retrieveSlowStraight.Checked)
            {
                getSettings(spinning.SlowStraight);
            }
            else if (radSpinning.Checked && retrieveStraight.Checked)
            {
                getSettings(spinning.Straight);
            }
            else if (radSpinning.Checked && retrieveStopGo.Checked)
            {
                getSettings(spinning.StopGo);
            }
            else if (radSpinning.Checked && retrieveTwitch.Checked)
            {
                getSettings(spinning.Twitch);
            }
            else if (radSpinning.Checked && retrieveLiftDrop.Checked)
            {
                getSettings(spinning.LiftDrop);
            }

            //Tease
            if (retrieveTease.Checked)
            {
                numReeling.Value = 3000;
                numJerking.Value = 3000;
                numSpeed.Value = 1;
                numReelPulse.Value = 5;
                numJerkPulse.Value = 10;
            }
        }

        //
        // Modify Settings
        //
        public void modifySettings()
        {
            // Float Fishing
            if (radFloating.Checked && retrievePlain.Checked)
            {
                floating.setValue(floating.Retrieve, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }

            // Cast Fishing
            if (radCasting.Checked && retrievePlain.Checked)
            {
                casting.setValue(casting.Retrieve, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radCasting.Checked && retrieveSlowStraight.Checked)
            {
                casting.setValue(casting.SlowStraight, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radCasting.Checked && retrieveStraight.Checked)
            {
                casting.setValue(casting.Straight, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radCasting.Checked && retrieveStopGo.Checked)
            {
                casting.setValue(casting.StopGo, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radCasting.Checked && retrieveTwitch.Checked)
            {
                casting.setValue(casting.Twitch, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radCasting.Checked && retrieveLiftDrop.Checked)
            {
                casting.setValue(casting.LiftDrop, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }

            // Spin Fishing
            if (radSpinning.Checked && retrievePlain.Checked)
            {
                spinning.setValue(spinning.Retrieve, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radSpinning.Checked && retrieveSlowStraight.Checked)
            {
                spinning.setValue(spinning.SlowStraight, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radSpinning.Checked && retrieveStraight.Checked)
            {
                spinning.setValue(spinning.Straight, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radSpinning.Checked && retrieveStopGo.Checked)
            {
                spinning.setValue(spinning.StopGo, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radSpinning.Checked && retrieveTwitch.Checked)
            {
                spinning.setValue(spinning.Twitch, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
            else if (radSpinning.Checked && retrieveLiftDrop.Checked)
            {
                spinning.setValue(spinning.LiftDrop, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse);
            }
        }

        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //
            // Settings Directory
            //
            bool settingsDirectoryExist = Directory.Exists(Path.GetFullPath(".\\") + fileStructure.settingsPath);
            if (!settingsDirectoryExist)
            {
                Directory.CreateDirectory(Path.GetFullPath(".\\") + fileStructure.settingsPath);
            }

            //
            // Casting
            //

            casting.setValue(casting.Retrieve, 30, 750, 4, 1000, 15);
            casting.setValue(casting.SlowStraight, 30, 3600000, 2, 1000, 5);
            casting.setValue(casting.Straight, 30, 3600000, 3, 1000, 5);
            casting.setValue(casting.Twitch, 30, 2500, 3, 1000, 20);
            casting.setValue(casting.StopGo, 1700, 3600000, 3, 30, 5);
            casting.setValue(casting.LiftDrop, 2750, 2750, 3, 50, 50);

            //
            // Spinning
            //

            spinning.setValue(spinning.Retrieve, 30, 750, 4, 1000, 15);
            spinning.setValue(spinning.SlowStraight, 30, 3600000, 2, 1000, 5);
            spinning.setValue(spinning.Straight, 30, 3600000, 3, 1000, 5);
            spinning.setValue(spinning.Twitch, 30, 2500, 3, 1000, 20);
            spinning.setValue(spinning.StopGo, 1750, 3600000, 3, 50, 5);
            spinning.setValue(spinning.LiftDrop, 3000, 3000, 3, 50, 50);

            //
            // Floating
            //

            floating.setValue(floating.Retrieve, 30, 750, 4, 1000, 30);

            radFloating.Select();
            updateStatusBar();
            updateSettings();
        }

        private void radFloating_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
            retrieveLiftDrop.Enabled = false;
            retrieveSlowStraight.Enabled = false;
            retrieveStopGo.Enabled = false;
            retrieveStraight.Enabled = false;
            retrieveTwitch.Enabled = false;
            tabSettings.SelectTab(tabFloat);
        }

        private void retrievePlain_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }

        private void radSpinning_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
            retrieveLiftDrop.Enabled = true;
            retrieveSlowStraight.Enabled = true;
            retrieveStopGo.Enabled = true;
            retrieveStraight.Enabled = true;
            retrieveTwitch.Enabled = true;
            tabSettings.SelectTab(tabSpin);
        }

        private void radCasting_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
            retrieveLiftDrop.Enabled = true;
            retrieveSlowStraight.Enabled = true;
            retrieveStopGo.Enabled = true;
            retrieveStraight.Enabled = true;
            retrieveTwitch.Enabled = true;
            tabSettings.SelectTab(tabCast);
        }

        private void retrieveSlowStraight_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }

        private void retrieveStraight_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }

        private void retrieveStopGo_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }

        private void retrieveTwitch_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }

        private void retrieveLiftDrop_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }

        private void numReeling_Click(object sender, EventArgs e)
        {
            numReeling.Select(0, numReeling.ToString().Length);
        }

        private void numJerking_Click(object sender, EventArgs e)
        {
            numJerking.Select(0, numJerking.ToString().Length);
        }

        private void numSpeed_Click(object sender, EventArgs e)
        {
            numSpeed.Select(0, numSpeed.ToString().Length);
        }

        private void timerReeling_Tick(object sender, EventArgs e)
        {
            /*
            fishing.lineReel(Convert.ToInt32(numReelPulse.Value));
            */
            tReelState(true);
        }

        private void timerJerking_Tick(object sender, EventArgs e)
        {
            /*
            fishing.lineJerk(Convert.ToInt32(numJerkPulse.Value));
            */
            tJerkState(true);
        }

        private void numReeling_ValueChanged(object sender, EventArgs e)
        {
            timerReeling.Interval = Convert.ToInt32(numReeling.Value);
        }

        private void numJerking_ValueChanged(object sender, EventArgs e)
        {
            timerJerking.Interval = Convert.ToInt32(numJerking.Value);
        }

        private void numJerking_Validating(object sender, CancelEventArgs e)
        {
            modifySettings();
        }

        private void numReeling_Validating(object sender, CancelEventArgs e)
        {
            modifySettings();
        }

        private void numSpeed_Validating(object sender, CancelEventArgs e)
        {
            modifySettings();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numReelPulse_Click(object sender, EventArgs e)
        {
            numReelPulse.Select(0, numReelPulse.ToString().Length);
        }

        private void numJerkPulse_Click(object sender, EventArgs e)
        {
            numJerkPulse.Select(0, numJerkPulse.ToString().Length);
        }

        private void numReelPulse_Validating(object sender, CancelEventArgs e)
        {
            modifySettings();
        }

        private void numJerkPulse_Validating(object sender, CancelEventArgs e)
        {
            modifySettings();
        }

        /// <summary>
        /// Load Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileLoad_Click(object sender, EventArgs e)
        {
            try
            {
                settingsOpenDialog.InitialDirectory = Path.GetFullPath(".\\") + fileStructure.settingsPath;
                settingsOpenDialog.ShowDialog();
                settingsLoad();
            }
            catch { }
        }
        private void readSettings(ListView targetListView, string elementParent, string elementChild)
        {
            XmlReader xRead = XmlReader.Create(settingsOpenDialog.FileName);
            xRead.ReadStartElement("FishingPlanet");
            targetListView.Items.Clear();
            while (xRead.Read())
            {
                if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementParent)
                {
                    while (xRead.Read())
                    {
                        if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementChild)
                        {
                            if (xRead.HasAttributes)
                            {
                                ListViewItem lviItems = new ListViewItem(xRead.GetAttribute("ReelInterval").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("JerkInterval").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("Speed").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("ReelPulse").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("JerkPulse").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("Description").ToString());
                                targetListView.Items.Add(lviItems);
                            }
                        }
                    }
                }
            }
            xRead.Close();
        }
        public void settingsLoad()
        {
            try
            {
                readSettings(lvFloat, "Floating", "FloatSettings");
                readSettings(lvSpin, "Spinning", "SpinSettings");
                readSettings(lvCast, "Casting", "CastSettings");
                updateSettings();
                notifyTray("Settings Loaded", "Settings have been loaded properly.");
            }
            catch { }
        }

        /// <summary>
        /// Save Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                settingsSaveDialog.InitialDirectory = Path.GetFullPath(".\\") + fileStructure.settingsPath;
                settingsSaveDialog.ShowDialog();
                settingsSave();
            }
            catch { }
        }
        public void settingsSave()
        {
            try
            {
                XmlWriterSettings mysettings = new XmlWriterSettings();
                mysettings.Indent = true;
                XmlWriter xWrite = XmlWriter.Create(settingsSaveDialog.FileName, mysettings);

                xWrite.WriteStartDocument();
                xWrite.WriteStartElement("FishingPlanet");

                xWrite.WriteStartElement("Floating");
                for (int x1 = 0; x1 < lvFloat.Items.Count; x1++)
                {
                    xWrite.WriteStartElement("FloatSettings");
                    xWrite.WriteAttributeString("ReelInterval", lvFloat.Items[x1].SubItems[0].Text);
                    xWrite.WriteAttributeString("JerkInterval", lvFloat.Items[x1].SubItems[1].Text);
                    xWrite.WriteAttributeString("Speed", lvFloat.Items[x1].SubItems[2].Text);
                    xWrite.WriteAttributeString("ReelPulse", lvFloat.Items[x1].SubItems[3].Text);
                    xWrite.WriteAttributeString("JerkPulse", lvFloat.Items[x1].SubItems[4].Text);
                    xWrite.WriteAttributeString("Description", lvFloat.Items[x1].SubItems[5].Text);
                    xWrite.WriteEndElement();
                }
                xWrite.WriteEndElement();

                xWrite.WriteStartElement("Spinning");
                for (int x2 = 0; x2 < lvSpin.Items.Count; x2++)
                {
                    xWrite.WriteStartElement("SpinSettings");
                    xWrite.WriteAttributeString("ReelInterval", lvSpin.Items[x2].SubItems[0].Text);
                    xWrite.WriteAttributeString("JerkInterval", lvSpin.Items[x2].SubItems[1].Text);
                    xWrite.WriteAttributeString("Speed", lvSpin.Items[x2].SubItems[2].Text);
                    xWrite.WriteAttributeString("ReelPulse", lvSpin.Items[x2].SubItems[3].Text);
                    xWrite.WriteAttributeString("JerkPulse", lvSpin.Items[x2].SubItems[4].Text);
                    xWrite.WriteAttributeString("Description", lvSpin.Items[x2].SubItems[5].Text);
                    xWrite.WriteEndElement();
                }
                xWrite.WriteEndElement();

                xWrite.WriteStartElement("Casting");
                for (int x3 = 0; x3 < lvCast.Items.Count; x3++)
                {
                    xWrite.WriteStartElement("CastSettings");
                    xWrite.WriteAttributeString("ReelInterval", lvCast.Items[x3].SubItems[0].Text);
                    xWrite.WriteAttributeString("JerkInterval", lvCast.Items[x3].SubItems[1].Text);
                    xWrite.WriteAttributeString("Speed", lvCast.Items[x3].SubItems[2].Text);
                    xWrite.WriteAttributeString("ReelPulse", lvCast.Items[x3].SubItems[3].Text);
                    xWrite.WriteAttributeString("JerkPulse", lvCast.Items[x3].SubItems[4].Text);
                    xWrite.WriteAttributeString("Description", lvCast.Items[x3].SubItems[5].Text);
                    xWrite.WriteEndElement();
                }
                xWrite.WriteEndElement();

                xWrite.WriteEndElement();
                xWrite.WriteEndDocument();
                xWrite.Close();

                notifyTray("Settings Saved", "Settings saved successfully!");
            }
            catch { }
        }

        public void notifyTray(string notifyTitle, string notifyMessage,int notifyTime=250)
        {
            notifyIcon.Visible = true;
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.BalloonTipTitle = notifyTitle;
            notifyIcon.BalloonTipText = notifyMessage;
            notifyIcon.BalloonTipIcon = ToolTipIcon.None;
            notifyIcon.ShowBalloonTip(notifyTime);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            MyForms.MainForm.Hide();
            MyForms.ProcessList.Show();
            updateStatusBar();
            updateSettings();
        }

        private void retrieveTease_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyForms.AboutBox.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MyForms.AboutBox.Show();
        }

        /// <summary>
        /// Timers
        /// </summary>
        /// <param name="enabled"></param>
        public void tReelState(bool enabled = false)
        {
            if (enabled)
            {
                tReel.Enabled = true;
            }
            else
            {
                tReel.Enabled = false;
                fishing.reelTick = 0;
            }
        }

        public void tJerkState(bool enabled = false)
        {
            if (enabled)
            {
                tJerk.Enabled = true;
            }
            else
            {
                tJerk.Enabled = false;
                fishing.jerkTick = 0;
            }
        }
        private void tReel_Tick(object sender, EventArgs e)
        {
            if (fishing.reelTick != (Convert.ToInt32(numReelPulse.Value) * 1))
            {
                fishing.reelTick += 1;
                fishing.lineReel(1);
            }
            else if (fishing.reelTick == (Convert.ToInt32(numReelPulse.Value) * 1))
            {
                tReel.Enabled = false;
                fishing.reelTick = 0;
            }
        }

        private void tJerk_Tick(object sender, EventArgs e)
        {
            if (fishing.jerkTick != (Convert.ToInt32(numJerkPulse.Value) * 1))
            {
                fishing.jerkTick += 1;
                fishing.lineJerk(1);
            }
            else if (fishing.jerkTick == (Convert.ToInt32(numJerkPulse.Value) * 1))
            {
                tJerk.Enabled = false;
                fishing.jerkTick = 0;
            }
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://fishing-planet-assistor.sourceforge.net");
            }
            catch (Exception errUpdate)
            {
                MessageBox.Show(errUpdate.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCentimeters_Click(object sender, EventArgs e)
        {
            txtCentimeters.Select(0, txtCentimeters.TextLength);
        }

        private void txtMeters_Click(object sender, EventArgs e)
        {
            txtMeters.Select(0, txtMeters.TextLength);
        }

        private void txtInches_Click(object sender, EventArgs e)
        {
            txtInches.Select(0, txtInches.TextLength);
        }

        private void txtFeet_Click(object sender, EventArgs e)
        {
            txtFeet.Select(0, txtFeet.TextLength);
        }

        private void btnCentimeters_Click(object sender, EventArgs e)
        {
            try
            {
                txtMeters.Text = conversion.cm_to_m(double.Parse(txtCentimeters.Text)).ToString();
                txtInches.Text = conversion.cm_to_in(double.Parse(txtCentimeters.Text)).ToString();
                txtFeet.Text = conversion.in_to_ft(conversion.cm_to_in(double.Parse(txtCentimeters.Text))).ToString();
            }
            catch { }
        }

        private void btnMeters_Click(object sender, EventArgs e)
        {
            try
            {
                txtCentimeters.Text = conversion.m_to_cm(double.Parse(txtMeters.Text)).ToString();
                txtInches.Text = conversion.cm_to_in(conversion.m_to_cm(double.Parse(txtMeters.Text))).ToString();
                txtFeet.Text = conversion.in_to_ft(conversion.cm_to_in(conversion.m_to_cm(double.Parse(txtMeters.Text)))).ToString();
            }
            catch { }
        }

        private void btnInches_Click(object sender, EventArgs e)
        {
            try
            {
                txtCentimeters.Text = conversion.in_to_cm(double.Parse(txtInches.Text)).ToString();
                txtMeters.Text = conversion.cm_to_m(conversion.in_to_cm(double.Parse(txtInches.Text))).ToString();
                txtFeet.Text = conversion.in_to_ft(double.Parse(txtInches.Text)).ToString();
            }
            catch { }
        }

        private void btnFeet_Click(object sender, EventArgs e)
        {
            try
            {
                txtCentimeters.Text = conversion.in_to_cm(conversion.ft_to_in(double.Parse(txtFeet.Text))).ToString();
                txtMeters.Text = conversion.cm_to_m(conversion.in_to_cm(conversion.ft_to_in(double.Parse(txtFeet.Text)))).ToString();
                txtInches.Text = conversion.ft_to_in(double.Parse(txtFeet.Text)).ToString();
            }
            catch { }
        }

        private void txtGrams_Click(object sender, EventArgs e)
        {
            txtGrams.Select(0, txtGrams.TextLength);
        }

        private void txtKilograms_Click(object sender, EventArgs e)
        {
            txtKilograms.Select(0, txtKilograms.TextLength);
        }

        private void txtOunce_Click(object sender, EventArgs e)
        {
            txtOunce.Select(0, txtOunce.TextLength);
        }

        private void txtPounds_Click(object sender, EventArgs e)
        {
            txtPounds.Select(0, txtPounds.TextLength);
        }

        private void btnGrams_Click(object sender, EventArgs e)
        {
            try
            {
                txtKilograms.Text = conversion.g_to_kg(double.Parse(txtGrams.Text)).ToString();
                txtOunce.Text = conversion.g_to_oz(double.Parse(txtGrams.Text)).ToString();
                txtPounds.Text = conversion.oz_to_lbs(conversion.g_to_oz(double.Parse(txtGrams.Text))).ToString();
            }
            catch { }
        }

        private void btnKilograms_Click(object sender, EventArgs e)
        {
            try
            {
                txtGrams.Text = conversion.kg_to_g(double.Parse(txtKilograms.Text)).ToString();
                txtOunce.Text = conversion.g_to_oz(conversion.kg_to_g(double.Parse(txtKilograms.Text))).ToString();
                txtPounds.Text = conversion.oz_to_lbs(conversion.g_to_oz(conversion.kg_to_g(double.Parse(txtKilograms.Text)))).ToString();
            }
            catch { }
        }

        private void btnOunce_Click(object sender, EventArgs e)
        {
            try
            {
                txtGrams.Text = conversion.oz_to_g(double.Parse(txtOunce.Text)).ToString();
                txtKilograms.Text = conversion.g_to_kg(conversion.oz_to_g(double.Parse(txtOunce.Text))).ToString();
                txtPounds.Text = conversion.oz_to_lbs(double.Parse(txtOunce.Text)).ToString();
            }
            catch { }
        }

        private void btnPounds_Click(object sender, EventArgs e)
        {
            try
            {
                txtGrams.Text = conversion.oz_to_g(conversion.lbs_to_oz(double.Parse(txtPounds.Text))).ToString();
                txtKilograms.Text = conversion.g_to_kg(conversion.oz_to_g(conversion.lbs_to_oz(double.Parse(txtPounds.Text)))).ToString();
                txtOunce.Text = conversion.lbs_to_oz(double.Parse(txtPounds.Text)).ToString();
            }
            catch { }
        }

        private void tJerkTemp_Tick(object sender, EventArgs e)
        {
            if (fishing.jerkTickTemp != (60))
            {
                fishing.jerkTickTemp += 1;
                fishing.lineJerk(1);
            }
            else if (fishing.jerkTickTemp == (60))
            {
                tJerkTemp.Enabled = false;
                fishing.jerkTickTemp = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radFloating.Checked)
            {
                Assistant.addSettings(lvFloat, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse, txtDescription.Text);
            }
            else if (radSpinning.Checked)
            {
                Assistant.addSettings(lvSpin, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse, txtDescription.Text);
            }
            else if (radCasting.Checked)
            {
                Assistant.addSettings(lvCast, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse, txtDescription.Text);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (radFloating.Checked)
                {
                    Assistant.removeSettings(lvFloat);
                }
                else if (radSpinning.Checked)
                {
                    Assistant.removeSettings(lvSpin);
                }
                else if (radCasting.Checked)
                {
                    Assistant.removeSettings(lvCast);
                }
            }
            catch (Exception errDelete)
            {
                MessageBox.Show(string.Concat("Select an item to remove.", "\n\n", errDelete.Message), "Error Deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (radFloating.Checked)
                {
                    Assistant.editSettings(lvFloat, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse, txtDescription.Text);
                }
                else if (radSpinning.Checked)
                {
                    Assistant.editSettings(lvSpin, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse, txtDescription.Text);
                }
                else if (radCasting.Checked)
                {
                    Assistant.editSettings(lvCast, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse, txtDescription.Text);
                }
            }
            catch (Exception errEdit)
            {
                MessageBox.Show(string.Concat("Select an item to edit.", "\n\n", errEdit.Message), "Error Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lvFloat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (radFloating.Checked)
                {
                    Assistant.getSettings(lvFloat, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse, txtDescription);
                    modifySettings();
                }
            }
            catch { }
        }

        private void lvSpin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (radSpinning.Checked)
                {
                    Assistant.getSettings(lvSpin, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse, txtDescription);
                    modifySettings();
                }
            }
            catch { }
        }

        private void lvCast_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (radCasting.Checked)
                {
                    Assistant.getSettings(lvCast, numReeling, numJerking, numSpeed, numReelPulse, numJerkPulse, txtDescription);
                    modifySettings();
                }
            }
            catch { }
        }
    }
}