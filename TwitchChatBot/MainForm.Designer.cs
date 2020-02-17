namespace TwitchChatBot
{
    partial class MainForm
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
            this.ChatBoxLabel = new MetroFramework.Controls.MetroLabel();
            this.ChannelTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DisconnectButton = new MetroFramework.Controls.MetroButton();
            this.ConnectButton = new MetroFramework.Controls.MetroButton();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.CodeGrabberButton = new MetroFramework.Controls.MetroButton();
            this.ConsoleTabPage = new System.Windows.Forms.TabPage();
            this.ConsoleBox = new MetroFramework.Controls.MetroTextBox();
            this.TabController = new MetroFramework.Controls.MetroTabControl();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.SettingsTabPage.SuspendLayout();
            this.ConsoleTabPage.SuspendLayout();
            this.TabController.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatBoxLabel
            // 
            this.ChatBoxLabel.AutoSize = true;
            this.ChatBoxLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ChatBoxLabel.ForeColor = System.Drawing.Color.White;
            this.ChatBoxLabel.Location = new System.Drawing.Point(118, 68);
            this.ChatBoxLabel.Name = "ChatBoxLabel";
            this.ChatBoxLabel.Size = new System.Drawing.Size(80, 25);
            this.ChatBoxLabel.Style = MetroFramework.MetroColorStyle.Pink;
            this.ChatBoxLabel.TabIndex = 5;
            this.ChatBoxLabel.Text = "Chat Box";
            this.ChatBoxLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChatBoxLabel.UseCustomBackColor = true;
            this.ChatBoxLabel.UseCustomForeColor = true;
            // 
            // ChannelTextBox
            // 
            // 
            // 
            // 
            this.ChannelTextBox.CustomButton.Image = null;
            this.ChannelTextBox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.ChannelTextBox.CustomButton.Name = "";
            this.ChannelTextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ChannelTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChannelTextBox.CustomButton.TabIndex = 1;
            this.ChannelTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChannelTextBox.CustomButton.UseSelectable = true;
            this.ChannelTextBox.CustomButton.Visible = false;
            this.ChannelTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ChannelTextBox.ForeColor = System.Drawing.Color.Pink;
            this.ChannelTextBox.Lines = new string[0];
            this.ChannelTextBox.Location = new System.Drawing.Point(827, 594);
            this.ChannelTextBox.MaxLength = 32767;
            this.ChannelTextBox.Multiline = true;
            this.ChannelTextBox.Name = "ChannelTextBox";
            this.ChannelTextBox.PasswordChar = '\0';
            //this.ChannelTextBox.PromptText = "No Channel";
            this.ChannelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChannelTextBox.SelectedText = "";
            this.ChannelTextBox.SelectionLength = 0;
            this.ChannelTextBox.SelectionStart = 0;
            this.ChannelTextBox.ShortcutsEnabled = true;
            this.ChannelTextBox.Size = new System.Drawing.Size(205, 33);
            this.ChannelTextBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.ChannelTextBox.TabIndex = 6;
            this.ChannelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChannelTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChannelTextBox.UseCustomBackColor = true;
            this.ChannelTextBox.UseCustomForeColor = true;
            this.ChannelTextBox.UseSelectable = true;
            this.ChannelTextBox.WaterMark = "No Channel";
            this.ChannelTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChannelTextBox.WaterMarkFont = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChannelTextBox_KeyDown);
            this.ChannelTextBox.MouseEnter += new System.EventHandler(this.ChannelTextBox_MouseEnter);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(1129, 594);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(85, 33);
            this.DisconnectButton.Style = MetroFramework.MetroColorStyle.Pink;
            this.DisconnectButton.TabIndex = 7;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DisconnectButton.UseCustomBackColor = true;
            this.DisconnectButton.UseSelectable = true;
            this.DisconnectButton.UseStyleColors = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            this.DisconnectButton.MouseEnter += new System.EventHandler(this.DisconnectButton_MouseEnter);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(1038, 594);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(85, 33);
            this.ConnectButton.Style = MetroFramework.MetroColorStyle.Pink;
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConnectButton.UseCustomBackColor = true;
            this.ConnectButton.UseSelectable = true;
            this.ConnectButton.UseStyleColors = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            this.ConnectButton.MouseEnter += new System.EventHandler(this.ConnectButton_MouseEnter);
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsTabPage.Controls.Add(this.CodeGrabberButton);
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 38);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Size = new System.Drawing.Size(869, 515);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Text = " Settings";
            // 
            // CodeGrabberButton
            // 
            this.CodeGrabberButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CodeGrabberButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CodeGrabberButton.Location = new System.Drawing.Point(10, 10);
            this.CodeGrabberButton.Name = "CodeGrabberButton";
            this.CodeGrabberButton.Size = new System.Drawing.Size(175, 45);
            this.CodeGrabberButton.Style = MetroFramework.MetroColorStyle.Pink;
            this.CodeGrabberButton.TabIndex = 0;
            this.CodeGrabberButton.Text = "Open Code Grabber";
            this.CodeGrabberButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CodeGrabberButton.UseCustomBackColor = true;
            this.CodeGrabberButton.UseSelectable = true;
            this.CodeGrabberButton.UseStyleColors = true;
            this.CodeGrabberButton.Click += new System.EventHandler(this.CodeGrabberButton_Click);
            this.CodeGrabberButton.MouseEnter += new System.EventHandler(this.CodeGrabberButton_MouseEnter);
            // 
            // ConsoleTabPage
            // 
            this.ConsoleTabPage.BackColor = System.Drawing.Color.Transparent;
            this.ConsoleTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleTabPage.Controls.Add(this.ConsoleBox);
            this.ConsoleTabPage.Location = new System.Drawing.Point(4, 38);
            this.ConsoleTabPage.Name = "ConsoleTabPage";
            this.ConsoleTabPage.Size = new System.Drawing.Size(869, 515);
            this.ConsoleTabPage.TabIndex = 0;
            this.ConsoleTabPage.Text = "Console";
            // 
            // ConsoleBox
            // 
            // 
            // 
            // 
            this.ConsoleBox.CustomButton.Image = null;
            this.ConsoleBox.CustomButton.Location = new System.Drawing.Point(356, 1);
            this.ConsoleBox.CustomButton.Name = "";
            this.ConsoleBox.CustomButton.Size = new System.Drawing.Size(505, 505);
            this.ConsoleBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConsoleBox.CustomButton.TabIndex = 1;
            this.ConsoleBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConsoleBox.CustomButton.UseSelectable = true;
            this.ConsoleBox.CustomButton.Visible = false;
            this.ConsoleBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleBox.Lines = new string[0];
            this.ConsoleBox.Location = new System.Drawing.Point(3, 3);
            this.ConsoleBox.MaxLength = 32767;
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.PasswordChar = '\0';
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleBox.SelectedText = "";
            this.ConsoleBox.SelectionLength = 0;
            this.ConsoleBox.SelectionStart = 0;
            this.ConsoleBox.ShortcutsEnabled = true;
            this.ConsoleBox.Size = new System.Drawing.Size(862, 507);
            this.ConsoleBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.ConsoleBox.TabIndex = 1;
            this.ConsoleBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConsoleBox.UseCustomForeColor = true;
            this.ConsoleBox.UseSelectable = true;
            this.ConsoleBox.UseStyleColors = true;
            this.ConsoleBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConsoleBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.ConsoleTabPage);
            this.TabController.Controls.Add(this.SettingsTabPage);
            this.TabController.Location = new System.Drawing.Point(341, 26);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(877, 557);
            this.TabController.Style = MetroFramework.MetroColorStyle.Pink;
            this.TabController.TabIndex = 4;
            this.TabController.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabController.UseSelectable = true;
            this.TabController.MouseEnter += new System.EventHandler(this.TabController_MouseEnter);
            // 
            // ChatBox
            // 
            this.ChatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ChatBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChatBox.Location = new System.Drawing.Point(10, 100);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ReadOnly = true;
            this.ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ChatBox.Size = new System.Drawing.Size(325, 479);
            this.ChatBox.TabIndex = 9;
            this.ChatBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1230, 639);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ChannelTextBox);
            this.Controls.Add(this.ChatBoxLabel);
            this.Controls.Add(this.TabController);
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Twitch Chat Bot";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.SettingsTabPage.ResumeLayout(false);
            this.ConsoleTabPage.ResumeLayout(false);
            this.TabController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel ChatBoxLabel;
        private MetroFramework.Controls.MetroTextBox ChannelTextBox;
        private MetroFramework.Controls.MetroButton DisconnectButton;
        private MetroFramework.Controls.MetroButton ConnectButton;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private MetroFramework.Controls.MetroButton CodeGrabberButton;
        private System.Windows.Forms.TabPage ConsoleTabPage;
        private MetroFramework.Controls.MetroTextBox ConsoleBox;
        private MetroFramework.Controls.MetroTabControl TabController;
        private System.Windows.Forms.RichTextBox ChatBox;
    }
}

