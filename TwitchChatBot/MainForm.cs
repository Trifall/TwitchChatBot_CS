using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib;
using TwitchLib.Client;
using TwitchLib.Api.Models.v5.Users;
using TwitchLib.Client.Models;
using TwitchLib.Client.Events;

namespace TwitchChatBot
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        TwitchClient client;
        CodeGrabberForm CodeGrabberForm_ = new CodeGrabberForm();
        readonly ConnectionCredentials credentials = new ConnectionCredentials(TwitchInfo.BotUsername, TwitchInfo.BotToken);
        bool isConnected = false;

        public MainForm()
        {
            InitializeComponent();
            //Connect();
            //Disconnect();
        }

        delegate void SetTextCallback(string text);

        delegate void SetTextCallback2(string text);

        internal void Connect(string Channel)
        {
            ConsoleBox.AppendText(Environment.NewLine + "Connecting");
            client = new TwitchClient();
            client.Initialize(credentials, Channel);
            client.OnLog += Client_OnLog;
            client.OnConnectionError += Client_OnConnectionError;
            client.OnConnected += Client_OnConnected;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnJoinedChannel += Client_OnJoinedChannel;

            client.Connect();

        }

        internal void Disconnect()
        {
            client.Disconnect();
            AppendTextConsole("[Console] - Disconnecting");
        }

        private void AppendTextChat(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.ChatBox.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(AppendTextChat);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.ChatBox.AppendText(Environment.NewLine + text);
            }
        }


        private void AppendTextConsole(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.ConsoleBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AppendTextConsole);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.ConsoleBox.AppendText(Environment.NewLine + text);
            }
        }

        private void ChannelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConnectButton_Click(this, new EventArgs());
                ChatBoxLabel.Focus();
            }
        }

        private void ChannelTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            AppendTextConsole("[Console] - Connected");
        }

        private void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            AppendTextConsole("[Console] - Error: " + e.Error);
        }

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {

            AppendTextConsole("[Console] - Joined Channel: " + e.Channel);
        }

        private void Client_OnLog(object sender, OnLogArgs e)
        {
            AppendTextConsole(e.Data);
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.IsModerator)
            {
                AppendTextChat("[Mod] " + e.ChatMessage.Username + ": " + e.ChatMessage.Message);
            }
            else if (e.ChatMessage.IsBroadcaster)
            {
                AppendTextChat("[Broadcaster] " + e.ChatMessage.Username + ": " + e.ChatMessage.Message);
            }
            else if (e.ChatMessage.IsSubscriber)
            {
                AppendTextChat("[Sub] " + e.ChatMessage.Username + ": " + e.ChatMessage.Message);
            }
            else
            {
                AppendTextChat(e.ChatMessage.Username + ": " + e.ChatMessage.Message);
            }
            if (!CodeGrabberForm_.IsPanelHidden())
                CodeGrabberForm_.Invoke(new Action(() => CodeGrabberForm_.ScanMessage(e.ChatMessage.Message)));
        }

        private void CodeGrabberButton_Click(object sender, EventArgs e)
        {
            ChatBoxLabel.Focus();
            CodeGrabberForm_.Hide();
            CodeGrabberForm_.Show();
        }

        private void CodeGrabberButton_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                Connect(ChannelTextBox.Text.Trim());
                isConnected = !isConnected;
            }
            ChatBoxLabel.Focus();
        }

        private void ConnectButton_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Disconnect();
                isConnected = !isConnected;
            }
            else
                AppendTextConsole("[Console] - Error: Not connected to a channel.");

            ChatBoxLabel.Focus();
        }

        private void DisconnectButton_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }
        private void SendMessage(string text, string channel)
        {
            client.SendMessage(channel, text);
            AppendTextChat("[Bot] " + TwitchInfo.BotUsername + ": " + text);
        }
        private void TabController_MouseEnter(object sender, EventArgs e)
        {
            if (this.CanFocus && !this.Focused)
                this.Focus();

            base.OnMouseEnter(e);
        }
    }
}

/*
//++ Notes
    Send Message from Bot -> SendMessage("hi", client.JoinedChannels.First().Channel);
*/