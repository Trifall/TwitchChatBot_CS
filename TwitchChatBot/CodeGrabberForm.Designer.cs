namespace TwitchChatBot
{
    partial class CodeGrabberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CodeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FormatLabel = new MetroFramework.Controls.MetroLabel();
            this.LatestCodeBox = new MetroFramework.Controls.MetroTextBox();
            this.CodeListLabel = new MetroFramework.Controls.MetroLabel();
            this.CodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SettingsLabel = new MetroFramework.Controls.MetroLabel();
            this.AutoCopyCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.PlaySoundCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.EnableGrabberCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.CodeGrabberPanel = new MetroFramework.Controls.MetroPanel();
            this.ChatBoxLabel = new MetroFramework.Controls.MetroLabel();
            this.CodeGrabberPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeComboBox
            // 
            this.CodeComboBox.FormattingEnabled = true;
            this.CodeComboBox.ItemHeight = 23;
            this.CodeComboBox.Items.AddRange(new object[] {
            "xxx-xxx-xxx",
            "xxxxx-xxx-xxxxx",
            "xxxxx-xxxxx-xxxxx",
            "xxxxx-xxxxx-xxxxx-xxxxx"});
            this.CodeComboBox.Location = new System.Drawing.Point(192, 13);
            this.CodeComboBox.Name = "CodeComboBox";
            this.CodeComboBox.Size = new System.Drawing.Size(242, 29);
            this.CodeComboBox.Sorted = true;
            this.CodeComboBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.CodeComboBox.TabIndex = 0;
            this.CodeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CodeComboBox.UseCustomForeColor = true;
            this.CodeComboBox.UseSelectable = true;
            this.CodeComboBox.UseStyleColors = true;
            this.CodeComboBox.SelectedIndexChanged += new System.EventHandler(this.CodeComboBox_SelectedIndexChanged);
            this.CodeComboBox.MouseEnter += new System.EventHandler(this.CodeComboBox_MouseEnter);
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FormatLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FormatLabel.Location = new System.Drawing.Point(117, 14);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(69, 25);
            this.FormatLabel.Style = MetroFramework.MetroColorStyle.Pink;
            this.FormatLabel.TabIndex = 1;
            this.FormatLabel.Text = "Format";
            this.FormatLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormatLabel.UseStyleColors = true;
            // 
            // LatestCodeBox
            // 
            // 
            // 
            // 
            this.LatestCodeBox.CustomButton.Image = null;
            this.LatestCodeBox.CustomButton.Location = new System.Drawing.Point(373, 1);
            this.LatestCodeBox.CustomButton.Name = "";
            this.LatestCodeBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.LatestCodeBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LatestCodeBox.CustomButton.TabIndex = 1;
            this.LatestCodeBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LatestCodeBox.CustomButton.UseSelectable = true;
            this.LatestCodeBox.CustomButton.Visible = false;
            this.LatestCodeBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.LatestCodeBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.LatestCodeBox.Lines = new string[] {
        "No Code Yet"};
            this.LatestCodeBox.Location = new System.Drawing.Point(192, 90);
            this.LatestCodeBox.MaxLength = 32767;
            this.LatestCodeBox.Multiline = true;
            this.LatestCodeBox.Name = "LatestCodeBox";
            this.LatestCodeBox.PasswordChar = '\0';
            this.LatestCodeBox.ReadOnly = true;
            this.LatestCodeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LatestCodeBox.SelectedText = "";
            this.LatestCodeBox.SelectionLength = 0;
            this.LatestCodeBox.SelectionStart = 0;
            this.LatestCodeBox.ShortcutsEnabled = true;
            this.LatestCodeBox.Size = new System.Drawing.Size(405, 33);
            this.LatestCodeBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.LatestCodeBox.TabIndex = 3;
            this.LatestCodeBox.Text = "No Code Yet";
            this.LatestCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LatestCodeBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LatestCodeBox.UseCustomBackColor = true;
            this.LatestCodeBox.UseSelectable = true;
            this.LatestCodeBox.UseStyleColors = true;
            this.LatestCodeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LatestCodeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LatestCodeBox.MouseEnter += new System.EventHandler(this.LatestCodeBox_MouseEnter);
            // 
            // CodeListLabel
            // 
            this.CodeListLabel.AutoSize = true;
            this.CodeListLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CodeListLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CodeListLabel.Location = new System.Drawing.Point(352, 149);
            this.CodeListLabel.Name = "CodeListLabel";
            this.CodeListLabel.Size = new System.Drawing.Size(85, 25);
            this.CodeListLabel.Style = MetroFramework.MetroColorStyle.Pink;
            this.CodeListLabel.TabIndex = 5;
            this.CodeListLabel.Text = "Code List";
            this.CodeListLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CodeListLabel.UseStyleColors = true;
            // 
            // CodeTextBox
            // 
            // 
            // 
            // 
            this.CodeTextBox.CustomButton.Image = null;
            this.CodeTextBox.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.CodeTextBox.CustomButton.Name = "";
            this.CodeTextBox.CustomButton.Size = new System.Drawing.Size(185, 185);
            this.CodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CodeTextBox.CustomButton.TabIndex = 1;
            this.CodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CodeTextBox.CustomButton.UseSelectable = true;
            this.CodeTextBox.CustomButton.Visible = false;
            this.CodeTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.CodeTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.CodeTextBox.Lines = new string[0];
            this.CodeTextBox.Location = new System.Drawing.Point(188, 181);
            this.CodeTextBox.MaxLength = 32767;
            this.CodeTextBox.Multiline = true;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.PasswordChar = '\0';
            this.CodeTextBox.ReadOnly = true;
            this.CodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodeTextBox.SelectedText = "";
            this.CodeTextBox.SelectionLength = 0;
            this.CodeTextBox.SelectionStart = 0;
            this.CodeTextBox.ShortcutsEnabled = true;
            this.CodeTextBox.Size = new System.Drawing.Size(430, 190);
            this.CodeTextBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.CodeTextBox.TabIndex = 6;
            this.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodeTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CodeTextBox.UseCustomBackColor = true;
            this.CodeTextBox.UseSelectable = true;
            this.CodeTextBox.UseStyleColors = true;
            this.CodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CodeTextBox.MouseEnter += new System.EventHandler(this.CodeTextBox_MouseEnter);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SettingsLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SettingsLabel.Location = new System.Drawing.Point(10, 181);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(76, 25);
            this.SettingsLabel.Style = MetroFramework.MetroColorStyle.Pink;
            this.SettingsLabel.TabIndex = 7;
            this.SettingsLabel.Text = "Settings";
            this.SettingsLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SettingsLabel.UseStyleColors = true;
            // 
            // AutoCopyCheckBox
            // 
            this.AutoCopyCheckBox.AutoSize = true;
            this.AutoCopyCheckBox.Location = new System.Drawing.Point(27, 218);
            this.AutoCopyCheckBox.Name = "AutoCopyCheckBox";
            this.AutoCopyCheckBox.Size = new System.Drawing.Size(151, 15);
            this.AutoCopyCheckBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.AutoCopyCheckBox.TabIndex = 8;
            this.AutoCopyCheckBox.Text = "Auto-Copy to Clipboard";
            this.AutoCopyCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutoCopyCheckBox.UseSelectable = true;
            this.AutoCopyCheckBox.UseStyleColors = true;
            this.AutoCopyCheckBox.CheckedChanged += new System.EventHandler(this.AutoCopyCheckBox_CheckedChanged);
            this.AutoCopyCheckBox.MouseEnter += new System.EventHandler(this.AutoCopyCheckBox_MouseEnter);
            // 
            // PlaySoundCheckBox
            // 
            this.PlaySoundCheckBox.AutoSize = true;
            this.PlaySoundCheckBox.Location = new System.Drawing.Point(27, 239);
            this.PlaySoundCheckBox.Name = "PlaySoundCheckBox";
            this.PlaySoundCheckBox.Size = new System.Drawing.Size(82, 15);
            this.PlaySoundCheckBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.PlaySoundCheckBox.TabIndex = 9;
            this.PlaySoundCheckBox.Text = "Play Sound";
            this.PlaySoundCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlaySoundCheckBox.UseSelectable = true;
            this.PlaySoundCheckBox.UseStyleColors = true;
            this.PlaySoundCheckBox.CheckedChanged += new System.EventHandler(this.PlaySoundCheckBox_CheckedChanged);
            this.PlaySoundCheckBox.MouseEnter += new System.EventHandler(this.PlaySoundCheckBox_MouseEnter);
            // 
            // EnableGrabberCheckBox
            // 
            this.EnableGrabberCheckBox.AutoSize = true;
            this.EnableGrabberCheckBox.Location = new System.Drawing.Point(510, 31);
            this.EnableGrabberCheckBox.Name = "EnableGrabberCheckBox";
            this.EnableGrabberCheckBox.Size = new System.Drawing.Size(134, 15);
            this.EnableGrabberCheckBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.EnableGrabberCheckBox.TabIndex = 10;
            this.EnableGrabberCheckBox.Text = "Enable Code Grabber";
            this.EnableGrabberCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EnableGrabberCheckBox.UseSelectable = true;
            this.EnableGrabberCheckBox.UseStyleColors = true;
            this.EnableGrabberCheckBox.CheckedChanged += new System.EventHandler(this.EnableGrabberCheckBox_CheckedChanged);
            this.EnableGrabberCheckBox.MouseEnter += new System.EventHandler(this.EnableGrabberCheckBox_MouseEnter);
            // 
            // CodeGrabberPanel
            // 
            this.CodeGrabberPanel.Controls.Add(this.PlaySoundCheckBox);
            this.CodeGrabberPanel.Controls.Add(this.CodeComboBox);
            this.CodeGrabberPanel.Controls.Add(this.AutoCopyCheckBox);
            this.CodeGrabberPanel.Controls.Add(this.FormatLabel);
            this.CodeGrabberPanel.Controls.Add(this.SettingsLabel);
            this.CodeGrabberPanel.Controls.Add(this.LatestCodeBox);
            this.CodeGrabberPanel.Controls.Add(this.CodeTextBox);
            this.CodeGrabberPanel.Controls.Add(this.CodeListLabel);
            this.CodeGrabberPanel.HorizontalScrollbarBarColor = true;
            this.CodeGrabberPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.CodeGrabberPanel.HorizontalScrollbarSize = 10;
            this.CodeGrabberPanel.Location = new System.Drawing.Point(0, 66);
            this.CodeGrabberPanel.Name = "CodeGrabberPanel";
            this.CodeGrabberPanel.Size = new System.Drawing.Size(700, 383);
            this.CodeGrabberPanel.Style = MetroFramework.MetroColorStyle.Pink;
            this.CodeGrabberPanel.TabIndex = 11;
            this.CodeGrabberPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CodeGrabberPanel.UseStyleColors = true;
            this.CodeGrabberPanel.VerticalScrollbarBarColor = true;
            this.CodeGrabberPanel.VerticalScrollbarHighlightOnWheel = false;
            this.CodeGrabberPanel.VerticalScrollbarSize = 10;
            // 
            // ChatBoxLabel
            // 
            this.ChatBoxLabel.AutoSize = true;
            this.ChatBoxLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ChatBoxLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ChatBoxLabel.ForeColor = System.Drawing.Color.HotPink;
            this.ChatBoxLabel.Location = new System.Drawing.Point(221, 225);
            this.ChatBoxLabel.Name = "ChatBoxLabel";
            this.ChatBoxLabel.Size = new System.Drawing.Size(258, 25);
            this.ChatBoxLabel.Style = MetroFramework.MetroColorStyle.Pink;
            this.ChatBoxLabel.TabIndex = 12;
            this.ChatBoxLabel.Text = "Code Grabber Is Not Enabled";
            this.ChatBoxLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChatBoxLabel.UseCustomBackColor = true;
            this.ChatBoxLabel.UseCustomForeColor = true;
            // 
            // CodeGrabberForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.CodeGrabberPanel);
            this.Controls.Add(this.EnableGrabberCheckBox);
            this.Controls.Add(this.ChatBoxLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CodeGrabberForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Code Grabber";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeGrabberForm_FormClosing);
            this.CodeGrabberPanel.ResumeLayout(false);
            this.CodeGrabberPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CodeComboBox;
        private MetroFramework.Controls.MetroLabel FormatLabel;
        private MetroFramework.Controls.MetroTextBox LatestCodeBox;
        private MetroFramework.Controls.MetroLabel CodeListLabel;
        private MetroFramework.Controls.MetroTextBox CodeTextBox;
        private MetroFramework.Controls.MetroLabel SettingsLabel;
        private MetroFramework.Controls.MetroCheckBox AutoCopyCheckBox;
        private MetroFramework.Controls.MetroCheckBox PlaySoundCheckBox;
        private MetroFramework.Controls.MetroCheckBox EnableGrabberCheckBox;
        private MetroFramework.Controls.MetroPanel CodeGrabberPanel;
        private MetroFramework.Controls.MetroLabel ChatBoxLabel;
    }
}