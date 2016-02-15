using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TwitchAPIViewer
{
    public partial class TwitchForm : Form
    {
        delegate void ShowTwitchTV(TwitchTV twitchTV);
        event ShowTwitchTV OnShowTwitchTV;

        WebClient m_WebClient;
        bool m_Running = false;

        public TwitchForm()
        {
            InitializeComponent();
            m_WebClient = new WebClient();
            OnShowTwitchTV += TwitchForm_OnShowTwitchTV;
        }

        private void TwitchForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(LoadKraken));
            thread.Start();
        }

        void TwitchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_Running = false;
        }

        private void TwitchForm_OnShowTwitchTV(TwitchTV twitchTV)
        {
            lblViewers.Text = string.Format("Viewers: {0:000}", twitchTV.stream.viewers);
            lblFollowers.Text = string.Format("Followers: {0:000}", twitchTV.stream.channel.followers);
            lblViews.Text = string.Format("Views: {0:000}", twitchTV.stream.channel.views);
            userName.Text = string.Format("User: {0}", twitchTV.stream.channel.name);
        }

        private void LoadKraken()
        {
            m_Running = true;
            while (m_Running)
            {
                var url = "https://api.twitch.tv/kraken/streams/moonducktv";
                string json = m_WebClient.DownloadString(url);

                TwitchTV twitchTV = JsonConvert.DeserializeObject<TwitchTV>(json);

                this.BeginInvoke(OnShowTwitchTV, twitchTV);

                Thread.Sleep(3000);
            }
        }
    }
}
