namespace Discord_AppleMusicRP
{
    public partial class MainForm : Form
    {
        readonly PresenceManager presenceManager;
        public MainForm(PresenceManager presenceManager)
        {
            this.presenceManager = presenceManager;
            InitializeComponent();
            this.clientId.Text = Properties.UserConfig.Default.clientId;
            this.detailsFormat.Text = Properties.UserConfig.Default.detailsFormat;
            this.stateFormat.Text = Properties.UserConfig.Default.stateFormat;
            this.largeImageTextFormat.Text = Properties.UserConfig.Default.largeImageTextFormat;
            this.largeImageKey.Text = Properties.UserConfig.Default.largeImageKey;
            this.smallImageTextFormat.Text = Properties.UserConfig.Default.smallImageTextFormat;
            this.smallImageKey.Text = Properties.UserConfig.Default.smallImageKey;
            this.playingImageKey.Text = Properties.UserConfig.Default.playingImageKey;
            this.pausedImageKey.Text = Properties.UserConfig.Default.pausedImageKey;
            this.buttonLabelFormat.Text = Properties.UserConfig.Default.buttonLabelFormat;
            this.useTrackTimestamps.Checked = Properties.UserConfig.Default.useTrackTimestamps;
            this.useStatusSymbols.Checked = Properties.UserConfig.Default.useStatusSymbols;
            UpdateEnabledObjects();
        }

        private void UpdateEnabledObjects()
        {
            if (this.useStatusSymbols.Checked)
            {
                this.normalLabel.Enabled = this.smallImageKey.Enabled = false;
                this.playingImageKey.Enabled = this.playingLabel.Enabled = this.pausedImageKey.Enabled = this.pausedLabel.Enabled = true;
            }
            else
            {
                this.normalLabel.Enabled = this.smallImageKey.Enabled = true;
                this.playingImageKey.Enabled = this.playingLabel.Enabled = this.pausedImageKey.Enabled = this.pausedLabel.Enabled = false;
            }
        }

        private void SaveConfig(object sender, EventArgs e)
        {
            Properties.UserConfig.Default.clientId = this.clientId.Text;
            Properties.UserConfig.Default.detailsFormat = this.detailsFormat.Text;
            Properties.UserConfig.Default.stateFormat = this.stateFormat.Text;
            Properties.UserConfig.Default.largeImageTextFormat = this.largeImageTextFormat.Text;
            Properties.UserConfig.Default.largeImageKey = this.largeImageKey.Text;
            Properties.UserConfig.Default.smallImageTextFormat = this.smallImageTextFormat.Text;
            Properties.UserConfig.Default.smallImageKey = this.smallImageKey.Text;
            Properties.UserConfig.Default.playingImageKey = this.playingImageKey.Text;
            Properties.UserConfig.Default.pausedImageKey = this.pausedImageKey.Text;
            Properties.UserConfig.Default.buttonLabelFormat = this.buttonLabelFormat.Text;
            Properties.UserConfig.Default.useTrackTimestamps = this.useTrackTimestamps.Checked;
            Properties.UserConfig.Default.useStatusSymbols = this.useStatusSymbols.Checked;

            Properties.UserConfig.Default.Save();
            presenceManager.LoadConfig();
            presenceManager.UpdateStatus(presenceManager.currentStatusTrack);
        }

        private void IconPreferenceUpdate(object sender, EventArgs e)
        {
            UpdateEnabledObjects();

        }
    }
}