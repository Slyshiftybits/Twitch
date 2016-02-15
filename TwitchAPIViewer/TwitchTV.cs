namespace TwitchAPIViewer
{
    internal class TwitchTV
    {
        public Stream stream { get; set; }

        public class Stream
        {
            public int viewers { get; set; }

            public Channel channel { get; set; }

            public class Channel
            {
                public int followers { get; set; }
                public int views { get; set; }
            }
        }
    }
}