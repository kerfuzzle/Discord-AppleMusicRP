namespace Discord_AppleMusicRP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.clientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.detailsFormat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stateFormat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonLabelFormat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.largeImageKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.smallImageTextFormat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.playingLabel = new System.Windows.Forms.Label();
            this.playingImageKey = new System.Windows.Forms.TextBox();
            this.useStatusSymbols = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pausedLabel = new System.Windows.Forms.Label();
            this.pausedImageKey = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.normalLabel = new System.Windows.Forms.Label();
            this.smallImageKey = new System.Windows.Forms.TextBox();
            this.useTrackTimestamps = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.largeImageTextFormat = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discord Apple Music\r\nRich Presence";
            // 
            // clientId
            // 
            this.clientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.clientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientId.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientId.ForeColor = System.Drawing.Color.White;
            this.clientId.Location = new System.Drawing.Point(86, 107);
            this.clientId.MaxLength = 20;
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(190, 28);
            this.clientId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Discord_AppleMusicRP.Properties.Resources.DiscordAppleMusicIntegrationLogo50px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Leave this as default unless you know what you\'re doing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "String Fomatting Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 60);
            this.label5.TabIndex = 6;
            this.label5.Text = "{title} - Track title\r\n{artist} - Track artist\r\n{status} - Playback Status (Playi" +
    "ng/Paused)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Details";
            // 
            // detailsFormat
            // 
            this.detailsFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.detailsFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsFormat.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detailsFormat.ForeColor = System.Drawing.Color.White;
            this.detailsFormat.Location = new System.Drawing.Point(86, 278);
            this.detailsFormat.MaxLength = 4096;
            this.detailsFormat.Name = "detailsFormat";
            this.detailsFormat.Size = new System.Drawing.Size(285, 28);
            this.detailsFormat.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "State";
            // 
            // stateFormat
            // 
            this.stateFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.stateFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateFormat.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateFormat.ForeColor = System.Drawing.Color.White;
            this.stateFormat.Location = new System.Drawing.Point(86, 312);
            this.stateFormat.MaxLength = 4096;
            this.stateFormat.Name = "stateFormat";
            this.stateFormat.Size = new System.Drawing.Size(285, 28);
            this.stateFormat.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 818);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Label";
            // 
            // buttonLabelFormat
            // 
            this.buttonLabelFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.buttonLabelFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonLabelFormat.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLabelFormat.ForeColor = System.Drawing.Color.White;
            this.buttonLabelFormat.Location = new System.Drawing.Point(63, 814);
            this.buttonLabelFormat.MaxLength = 4096;
            this.buttonLabelFormat.Name = "buttonLabelFormat";
            this.buttonLabelFormat.Size = new System.Drawing.Size(308, 28);
            this.buttonLabelFormat.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(14, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Large Image";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Key";
            // 
            // largeImageKey
            // 
            this.largeImageKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.largeImageKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeImageKey.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.largeImageKey.ForeColor = System.Drawing.Color.White;
            this.largeImageKey.Location = new System.Drawing.Point(65, 437);
            this.largeImageKey.MaxLength = 4096;
            this.largeImageKey.Name = "largeImageKey";
            this.largeImageKey.Size = new System.Drawing.Size(308, 28);
            this.largeImageKey.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(14, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Text Content";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(16, 498);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Text";
            // 
            // smallImageTextFormat
            // 
            this.smallImageTextFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.smallImageTextFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallImageTextFormat.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smallImageTextFormat.ForeColor = System.Drawing.Color.White;
            this.smallImageTextFormat.Location = new System.Drawing.Point(65, 494);
            this.smallImageTextFormat.MaxLength = 4096;
            this.smallImageTextFormat.Name = "smallImageTextFormat";
            this.smallImageTextFormat.Size = new System.Drawing.Size(308, 28);
            this.smallImageTextFormat.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(12, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "Small Image";
            // 
            // playingLabel
            // 
            this.playingLabel.AutoSize = true;
            this.playingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.playingLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playingLabel.Location = new System.Drawing.Point(28, 565);
            this.playingLabel.Name = "playingLabel";
            this.playingLabel.Size = new System.Drawing.Size(85, 20);
            this.playingLabel.TabIndex = 18;
            this.playingLabel.Text = "Playing Key";
            // 
            // playingImageKey
            // 
            this.playingImageKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.playingImageKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playingImageKey.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playingImageKey.ForeColor = System.Drawing.Color.White;
            this.playingImageKey.Location = new System.Drawing.Point(28, 588);
            this.playingImageKey.MaxLength = 4096;
            this.playingImageKey.Name = "playingImageKey";
            this.playingImageKey.Size = new System.Drawing.Size(332, 28);
            this.playingImageKey.TabIndex = 17;
            // 
            // useStatusSymbols
            // 
            this.useStatusSymbols.AutoSize = true;
            this.useStatusSymbols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.useStatusSymbols.Checked = true;
            this.useStatusSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useStatusSymbols.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.useStatusSymbols.Location = new System.Drawing.Point(28, 538);
            this.useStatusSymbols.Name = "useStatusSymbols";
            this.useStatusSymbols.Size = new System.Drawing.Size(284, 24);
            this.useStatusSymbols.TabIndex = 22;
            this.useStatusSymbols.Text = "Use playback status to determine icon";
            this.useStatusSymbols.UseVisualStyleBackColor = false;
            this.useStatusSymbols.CheckedChanged += new System.EventHandler(this.IconPreferenceUpdate);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.pictureBox2.Location = new System.Drawing.Point(18, 528);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 237);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pausedLabel
            // 
            this.pausedLabel.AutoSize = true;
            this.pausedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.pausedLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pausedLabel.Location = new System.Drawing.Point(28, 623);
            this.pausedLabel.Name = "pausedLabel";
            this.pausedLabel.Size = new System.Drawing.Size(86, 20);
            this.pausedLabel.TabIndex = 25;
            this.pausedLabel.Text = "Paused Key";
            // 
            // pausedImageKey
            // 
            this.pausedImageKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.pausedImageKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pausedImageKey.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pausedImageKey.ForeColor = System.Drawing.Color.White;
            this.pausedImageKey.Location = new System.Drawing.Point(28, 646);
            this.pausedImageKey.MaxLength = 4096;
            this.pausedImageKey.Name = "pausedImageKey";
            this.pausedImageKey.Size = new System.Drawing.Size(332, 28);
            this.pausedImageKey.TabIndex = 24;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(28, 689);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(332, 5);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.normalLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.normalLabel.Location = new System.Drawing.Point(28, 704);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(87, 20);
            this.normalLabel.TabIndex = 28;
            this.normalLabel.Text = "Normal Key";
            // 
            // smallImageKey
            // 
            this.smallImageKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.smallImageKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallImageKey.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smallImageKey.ForeColor = System.Drawing.Color.White;
            this.smallImageKey.Location = new System.Drawing.Point(28, 727);
            this.smallImageKey.MaxLength = 4096;
            this.smallImageKey.Name = "smallImageKey";
            this.smallImageKey.Size = new System.Drawing.Size(332, 28);
            this.smallImageKey.TabIndex = 27;
            // 
            // useTrackTimestamps
            // 
            this.useTrackTimestamps.AutoSize = true;
            this.useTrackTimestamps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.useTrackTimestamps.Checked = true;
            this.useTrackTimestamps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useTrackTimestamps.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.useTrackTimestamps.Location = new System.Drawing.Point(18, 346);
            this.useTrackTimestamps.Name = "useTrackTimestamps";
            this.useTrackTimestamps.Size = new System.Drawing.Size(322, 24);
            this.useTrackTimestamps.TabIndex = 29;
            this.useTrackTimestamps.Text = "Use per-track timestamp (Instead of overall)";
            this.useTrackTimestamps.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(14, 768);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 23);
            this.label17.TabIndex = 30;
            this.label17.Text = "Button";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Open Sans Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(16, 791);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(169, 20);
            this.label18.TabIndex = 31;
            this.label18.Text = "Leave blank for no button";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(16, 407);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 20);
            this.label19.TabIndex = 33;
            this.label19.Text = "Text";
            // 
            // largeImageTextFormat
            // 
            this.largeImageTextFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.largeImageTextFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeImageTextFormat.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.largeImageTextFormat.ForeColor = System.Drawing.Color.White;
            this.largeImageTextFormat.Location = new System.Drawing.Point(65, 403);
            this.largeImageTextFormat.MaxLength = 4096;
            this.largeImageTextFormat.Name = "largeImageTextFormat";
            this.largeImageTextFormat.Size = new System.Drawing.Size(308, 28);
            this.largeImageTextFormat.TabIndex = 32;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(15, 848);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(358, 42);
            this.saveButton.TabIndex = 34;
            this.saveButton.Text = "Update Config";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveConfig);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(393, 896);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.largeImageTextFormat);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.useTrackTimestamps);
            this.Controls.Add(this.normalLabel);
            this.Controls.Add(this.smallImageKey);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pausedLabel);
            this.Controls.Add(this.pausedImageKey);
            this.Controls.Add(this.useStatusSymbols);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.smallImageTextFormat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.playingLabel);
            this.Controls.Add(this.playingImageKey);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.largeImageKey);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonLabelFormat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stateFormat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.detailsFormat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Discord Apple Music RP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox clientId;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox detailsFormat;
        private Label label7;
        private TextBox stateFormat;
        private Label label8;
        private TextBox buttonLabelFormat;
        private Label label9;
        private Label label10;
        private TextBox largeImageKey;
        private Label label11;
        private Label label12;
        private TextBox smallImageTextFormat;
        private Label label13;
        private Label playingLabel;
        private TextBox playingImageKey;
        private CheckBox useStatusSymbols;
        private PictureBox pictureBox2;
        private Label pausedLabel;
        private TextBox pausedImageKey;
        private PictureBox pictureBox3;
        private Label normalLabel;
        private TextBox smallImageKey;
        private CheckBox useTrackTimestamps;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox largeImageTextFormat;
        private Button saveButton;
    }
}