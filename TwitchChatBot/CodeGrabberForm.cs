using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TwitchChatBot
{
    public partial class CodeGrabberForm : MetroFramework.Forms.MetroForm
    {
        public MainForm MainForm_;
        public bool PanelHidden = true;
        bool AutoCopy = false;
        string CurrentCodeFormat = "xxx-xxx-xxx";
        bool PlaySound = false;
        public CodeGrabberForm()
        {
            InitializeComponent();
            HidePanel();
        }

        public void HidePanel()
        {
            PanelHidden = true;
            CodeGrabberPanel.Hide();
        }

        public bool IsPanelHidden()
        {
            if (PanelHidden)
                return true;
            else
                return false;
        }
        public void ScanMessage(string msg)
        {
            if (msg.Count(x => x == '-') < 2)
                return;
            int CodeFormatLength = CurrentCodeFormat.Length;           
            int[] DashIndexes = Enumerable.Range(0, CurrentCodeFormat.Length).Where(x => CurrentCodeFormat[x] == '-').ToArray();
            string[] Data = msg.Split(' '); 
            List<string> PotentialCodes = new List<string>();
            foreach (string item in Data)
            {
                if (item.Length != CodeFormatLength)
                    continue;
                else
                    PotentialCodes.Add(item);
            }

            foreach (string _code in PotentialCodes)
            {
                string code = _code.ToLower().Trim();
                int[] CodeDashIndexes = Enumerable.Range(0, code.Length).Where(x => code[x] == '-').ToArray();
                if (DashIndexes.SequenceEqual(CodeDashIndexes))
                {
                    if (WordFilter(code))
                    {
                        LatestCodeBox.Text = _code;
                        CodeTextBox.AppendText(_code + Environment.NewLine);
                        if (AutoCopy && !PanelHidden)
                            Clipboard.SetText(_code);
                        if (PlaySound && !PanelHidden)
                            System.Media.SystemSounds.Beep.Play();
                    }
                }
            }
        }

        public void ShowPanel()
        {
            PanelHidden = false;
            CodeGrabberPanel.Show();
        }

        private void AutoCopyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoCopyCheckBox.Checked)
                AutoCopy = true;
            else
                AutoCopy = false;

            SettingsLabel.Focus();
        }

        private void AutoCopyCheckBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }

        private void CodeComboBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }

        private void CodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCodeFormat = CodeComboBox.SelectedItem.ToString().Trim();

            FormatLabel.Focus();
        }

        private void CodeGrabberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        private void CodeTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }

        private void EnableGrabberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableGrabberCheckBox.Checked)
            {
                ShowPanel();
            }
            else
            {
                HidePanel();
            }
        }
        private void EnableGrabberCheckBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }

        private void LatestCodeBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }

        private void PlaySoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PlaySoundCheckBox.Checked)
                PlaySound = true;
            else
                PlaySound = false;

            SettingsLabel.Focus();
        }

        private void PlaySoundCheckBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }

        private bool WordFilter(string code)
        {
            List<string> Words = new List<string>()
            {
                "troll",
                "tr0ll",
                "tro11",
                "tr011",
                "meme",
                "m3m3",
                "c0de",
                "c0d3",
                "code",
                "kappa",
                "k4ppa",
                "k499a",
                "k4pp4",
                "r34l",
                "real",
                "r341",
                "r3al",
                "f4ke",
                "fake",
                "f4k3",
                "pepe",
                "loser",
                "l0s3r",
                "l0ser",
                "los3r",
                "n1ce",
                "n1c3",
                "nice",
                "faked",
                "c0des",
                "tarkov",
                "money",
                "m0n3y",
                "m0ney",
                "mon3y",
                "gay",
                "n3rd",
                "nerd",
                "nic3"
            };

            bool value = false;

            foreach (string word in Words) // Loop through each filter word
                if (code.IndexOf(word) > 0) // Check for filter words in the code
                    continue;
                else
                    value = true;

            return value;

        }
    }
}
