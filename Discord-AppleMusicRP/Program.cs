using DiscordRPC;
using Newtonsoft.Json;
using Windows.Media.Control;
using Button = DiscordRPC.Button;

namespace Discord_AppleMusicRP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(new PresenceManager()));
        }
    }
    public class Track
    {
        public string title = "Title";
        public string artist = "Artist";
        public GlobalSystemMediaTransportControlsSessionPlaybackStatus playbackStatus;

        public string ApplyFormatting(string format) => format.Replace("{title}", this.title).Replace("{artist}", this.artist).Replace("{status}", this.playbackStatus.ToString());
    }

    class Config
    {
        //Default Config
        public string clientId = "1084164353579827260";
        public string detailsFormat = "{title}";
        public string stateFormat = "by {artist}";
        public string largeImageTextFormat = "Discord AppleMusicRP (by Kerfuzzle#2472)";
        public string largeImageKey = "apple_music_icon";
        public string smallImageTextFormat = "{status}";
        public string smallImageKey = "apple_music_icon";
        public string playingImageKey = "playing_icon";
        public string pausedImageKey = "paused_icon";
        public string buttonLabelFormat = "Search on Apple Music";
        public bool useTrackTimestamps = true;
        public bool useStatusSymbols = true;
    }
    public class PresenceManager
    {
        DiscordRpcClient client;
        readonly Config userConfig = new();
        public Track currentStatusTrack = new();
        readonly Timestamps applicationStartTime = Timestamps.Now;
        public PresenceManager()
        {
            LoadConfig();
            InitClient();
        }
        async void InitClient()
        {
            client = new DiscordRpcClient(userConfig.clientId);
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine($"Received Ready from user {e.User.Username}#{e.User.Discriminator}");
            };
            client.Initialize();

            // Update status when the app starts
            GlobalSystemMediaTransportControlsSessionManager sessionManager = await GlobalSystemMediaTransportControlsSessionManager.RequestAsync();
            IReadOnlyList<GlobalSystemMediaTransportControlsSession> globalSessions = sessionManager.GetSessions();
            GlobalSystemMediaTransportControlsSession currentSession = globalSessions.First(session =>
            {
                return session.SourceAppUserModelId == "MicrosoftCorporationII.WindowsSubsystemForAndroid_8wekyb3d8bbwe!App";
            });
            OnPlayerUpdate(currentSession, 0);
            // Register wrt API events
            currentSession.PlaybackInfoChanged += OnPlayerUpdate;
            currentSession.MediaPropertiesChanged += OnPlayerUpdate;
        }

        static async Task<Track> GetCurrentTrack(GlobalSystemMediaTransportControlsSession session)
        {
            GlobalSystemMediaTransportControlsSessionPlaybackInfo playbackInfo = session.GetPlaybackInfo();
            GlobalSystemMediaTransportControlsSessionMediaProperties mediaProperties = await session.TryGetMediaPropertiesAsync();

            GlobalSystemMediaTransportControlsSessionPlaybackStatus playbackStatus = playbackInfo.PlaybackStatus;
            String title = mediaProperties.Title;
            String artist = mediaProperties.Artist;
            return new Track()
            {
                title = title,
                artist = artist,
                playbackStatus = playbackStatus,
            };
        }

        async void OnPlayerUpdate(GlobalSystemMediaTransportControlsSession newSession, object _)
        {
            Track newTrack = await GetCurrentTrack(newSession);
            if (JsonConvert.SerializeObject(newTrack) != JsonConvert.SerializeObject(currentStatusTrack) && (int)newTrack.playbackStatus > 3)
            {
                Console.WriteLine($"{newTrack.title} {newTrack.artist} {newTrack.playbackStatus}");
                UpdateStatus(newTrack);
                currentStatusTrack = newTrack;
            }
            GC.Collect();
        }

        public void LoadConfig()
        {
            this.userConfig.clientId = Properties.UserConfig.Default.clientId;
            this.userConfig.detailsFormat = Properties.UserConfig.Default.detailsFormat;
            this.userConfig.stateFormat = Properties.UserConfig.Default.stateFormat;
            this.userConfig.largeImageTextFormat = Properties.UserConfig.Default.largeImageTextFormat;
            this.userConfig.largeImageKey = Properties.UserConfig.Default.largeImageKey;
            this.userConfig.smallImageTextFormat = Properties.UserConfig.Default.smallImageTextFormat;
            this.userConfig.smallImageKey = Properties.UserConfig.Default.smallImageKey;
            this.userConfig.playingImageKey = Properties.UserConfig.Default.playingImageKey;
            this.userConfig.pausedImageKey = Properties.UserConfig.Default.pausedImageKey;
            this.userConfig.buttonLabelFormat = Properties.UserConfig.Default.buttonLabelFormat;
            this.userConfig.useTrackTimestamps = Properties.UserConfig.Default.useTrackTimestamps;
            this.userConfig.useStatusSymbols = Properties.UserConfig.Default.useStatusSymbols;
        }

        public void UpdateStatus(Track track)
        {
            bool isPlaying = (int)track.playbackStatus == 4;
            client.SetPresence(new RichPresence()
            {
                Details = track.ApplyFormatting(userConfig.detailsFormat),
                State = track.ApplyFormatting(userConfig.stateFormat),
                Assets = new Assets()
                {
                    LargeImageKey = userConfig.largeImageKey,
                    LargeImageText = track.ApplyFormatting(userConfig.largeImageTextFormat),
                    SmallImageKey = userConfig.useStatusSymbols ? (isPlaying ? userConfig.playingImageKey : userConfig.pausedImageKey) : userConfig.smallImageKey,
                    SmallImageText = track.ApplyFormatting(userConfig.smallImageTextFormat),
                },
                Buttons = userConfig.buttonLabelFormat.Length > 0 ? new Button[]
                {
                    new Button()
                    {
                        Label = track.ApplyFormatting(userConfig.buttonLabelFormat),
                        Url = $"https://music.apple.com/search?term={(track.title + " " + track.artist).Replace(" ", "%20")}"
                    }
                } : null,
                Timestamps = userConfig.useTrackTimestamps ? (isPlaying ? Timestamps.Now : null) : applicationStartTime
            });
        }
    }
}