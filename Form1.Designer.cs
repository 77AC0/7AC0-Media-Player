namespace _7AC0Player2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.songList = new System.Windows.Forms.ListBox();
            this.playingState = new System.Windows.Forms.Label();
            this.currentAudioDevice = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.songTime = new System.Windows.Forms.Label();
            this.drkTheme = new System.Windows.Forms.CheckBox();
            this.currentDir = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.volumeKnob = new NAudio.Gui.Pot();
            this.loopChkBx = new System.Windows.Forms.CheckBox();
            this.shuffleBx = new System.Windows.Forms.CheckBox();
            this.discordRPClbl = new System.Windows.Forms.Label();
            this.discordTBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.AcceptsReturn = true;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBox.Location = new System.Drawing.Point(0, 430);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(800, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // songList
            // 
            this.songList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songList.FormattingEnabled = true;
            this.songList.Location = new System.Drawing.Point(6, 38);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(782, 340);
            this.songList.TabIndex = 1;
            // 
            // playingState
            // 
            this.playingState.AutoSize = true;
            this.playingState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingState.Location = new System.Drawing.Point(3, 3);
            this.playingState.Name = "playingState";
            this.playingState.Size = new System.Drawing.Size(83, 16);
            this.playingState.TabIndex = 2;
            this.playingState.Text = "playingState";
            this.playingState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentAudioDevice
            // 
            this.currentAudioDevice.AutoSize = true;
            this.currentAudioDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAudioDevice.Location = new System.Drawing.Point(3, 19);
            this.currentAudioDevice.Name = "currentAudioDevice";
            this.currentAudioDevice.Size = new System.Drawing.Size(95, 16);
            this.currentAudioDevice.TabIndex = 3;
            this.currentAudioDevice.Text = "Output Device:";
            this.currentAudioDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playBtn
            // 
            this.playBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playBtn.Image = ((System.Drawing.Image)(resources.GetObject("playBtn.Image")));
            this.playBtn.Location = new System.Drawing.Point(394, 393);
            this.playBtn.MaximumSize = new System.Drawing.Size(32, 32);
            this.playBtn.MinimumSize = new System.Drawing.Size(32, 32);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(32, 32);
            this.playBtn.TabIndex = 4;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.Location = new System.Drawing.Point(356, 393);
            this.stopBtn.MaximumSize = new System.Drawing.Size(32, 32);
            this.stopBtn.MinimumSize = new System.Drawing.Size(32, 32);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(32, 32);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // songTime
            // 
            this.songTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.songTime.AutoSize = true;
            this.songTime.Location = new System.Drawing.Point(432, 403);
            this.songTime.Name = "songTime";
            this.songTime.Size = new System.Drawing.Size(100, 13);
            this.songTime.TabIndex = 6;
            this.songTime.Text = "00:00:00 - 00:00:00";
            // 
            // drkTheme
            // 
            this.drkTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drkTheme.AutoSize = true;
            this.drkTheme.Location = new System.Drawing.Point(703, 407);
            this.drkTheme.Name = "drkTheme";
            this.drkTheme.Size = new System.Drawing.Size(85, 17);
            this.drkTheme.TabIndex = 7;
            this.drkTheme.Text = "Dark Theme";
            this.drkTheme.UseVisualStyleBackColor = true;
            this.drkTheme.CheckedChanged += new System.EventHandler(this.drkTheme_CheckedChanged);
            // 
            // currentDir
            // 
            this.currentDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentDir.AutoEllipsis = true;
            this.currentDir.Location = new System.Drawing.Point(3, 386);
            this.currentDir.Name = "currentDir";
            this.currentDir.Size = new System.Drawing.Size(309, 16);
            this.currentDir.TabIndex = 8;
            this.currentDir.Text = "Current Directory:";
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.Location = new System.Drawing.Point(703, 381);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(80, 23);
            this.browseBtn.TabIndex = 9;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pauseBtn.Image = ((System.Drawing.Image)(resources.GetObject("pauseBtn.Image")));
            this.pauseBtn.Location = new System.Drawing.Point(394, 393);
            this.pauseBtn.MaximumSize = new System.Drawing.Size(32, 32);
            this.pauseBtn.MinimumSize = new System.Drawing.Size(32, 32);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(32, 32);
            this.pauseBtn.TabIndex = 10;
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Visible = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // volumeKnob
            // 
            this.volumeKnob.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumeKnob.Location = new System.Drawing.Point(318, 393);
            this.volumeKnob.Maximum = 1D;
            this.volumeKnob.Minimum = 0D;
            this.volumeKnob.Name = "volumeKnob";
            this.volumeKnob.Size = new System.Drawing.Size(32, 32);
            this.volumeKnob.TabIndex = 11;
            this.volumeKnob.Value = 0.5D;
            // 
            // loopChkBx
            // 
            this.loopChkBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loopChkBx.AutoSize = true;
            this.loopChkBx.Location = new System.Drawing.Point(638, 407);
            this.loopChkBx.Name = "loopChkBx";
            this.loopChkBx.Size = new System.Drawing.Size(50, 17);
            this.loopChkBx.TabIndex = 12;
            this.loopChkBx.Text = "Loop";
            this.loopChkBx.UseVisualStyleBackColor = true;
            this.loopChkBx.CheckedChanged += new System.EventHandler(this.loopChkBx_CheckedChanged);
            // 
            // shuffleBx
            // 
            this.shuffleBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shuffleBx.AutoSize = true;
            this.shuffleBx.Location = new System.Drawing.Point(573, 407);
            this.shuffleBx.Name = "shuffleBx";
            this.shuffleBx.Size = new System.Drawing.Size(59, 17);
            this.shuffleBx.TabIndex = 13;
            this.shuffleBx.Text = "Shuffle";
            this.shuffleBx.UseVisualStyleBackColor = true;
            this.shuffleBx.CheckedChanged += new System.EventHandler(this.shuffleBx_CheckedChanged);
            // 
            // discordRPClbl
            // 
            this.discordRPClbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.discordRPClbl.AutoSize = true;
            this.discordRPClbl.Location = new System.Drawing.Point(3, 408);
            this.discordRPClbl.Name = "discordRPClbl";
            this.discordRPClbl.Size = new System.Drawing.Size(73, 13);
            this.discordRPClbl.TabIndex = 14;
            this.discordRPClbl.Text = "Discord Motd:";
            this.discordRPClbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discordTBx
            // 
            this.discordTBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.discordTBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discordTBx.Location = new System.Drawing.Point(82, 405);
            this.discordTBx.Name = "discordTBx";
            this.discordTBx.Size = new System.Drawing.Size(230, 20);
            this.discordTBx.TabIndex = 15;
            this.discordTBx.TextChanged += new System.EventHandler(this.discordTBx_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.discordTBx);
            this.Controls.Add(this.discordRPClbl);
            this.Controls.Add(this.shuffleBx);
            this.Controls.Add(this.loopChkBx);
            this.Controls.Add(this.volumeKnob);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.currentDir);
            this.Controls.Add(this.drkTheme);
            this.Controls.Add(this.songTime);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.currentAudioDevice);
            this.Controls.Add(this.playingState);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.searchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "Form1";
            this.Text = "7AC0 Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Label playingState;
        private System.Windows.Forms.Label currentAudioDevice;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label songTime;
        private System.Windows.Forms.CheckBox drkTheme;
        private System.Windows.Forms.Label currentDir;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button pauseBtn;
        private NAudio.Gui.Pot volumeKnob;
        private System.Windows.Forms.CheckBox loopChkBx;
        private System.Windows.Forms.CheckBox shuffleBx;
        private System.Windows.Forms.Label discordRPClbl;
        private System.Windows.Forms.TextBox discordTBx;
    }
}

