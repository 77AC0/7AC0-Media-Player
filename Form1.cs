using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.CoreAudioApi;
using NAudio.Wave;

using DiscordRPC;

namespace _7AC0Player2
{
    public partial class Form1 : Form, IDisposable {
        //Save Variables
        string saveData;
        string settingRead;

        public string songDirectory;

        //Music Function
        string song;
        string songName;
        bool IsPlaying = false;
        bool IsPaused = false;

        //DiscordRPC
        DiscordRpcClient client;

        public Form1() {
            InitializeComponent();
        }

        void InitDiscordRPC() {
            client = new DiscordRpcClient("596880881831116830");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                State = "Not Playing",
                Assets = new Assets()
                {
                    LargeImageKey = "7ac0mediaplayericon",
                    LargeImageText = discordTBx.Text
                }
            });
        }

        public void Form1_Load(object sender, EventArgs e) {
            try {
                FlushMemory();
                saveData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                if (!Directory.Exists(saveData)) {
                    Directory.CreateDirectory(saveData);
                }
                if (!File.Exists($@"{saveData}\7AC0PlayerSaveData.txt")) {
                    File.WriteAllText($@"{saveData}\7AC0PlayerSaveData.txt", $"Please Choose a Directory{Environment.NewLine}0{Environment.NewLine}1{Environment.NewLine}0{Environment.NewLine}0{Environment.NewLine}Welcome to 7AC0 Media Player");
                }
                saveData = saveData + @"\7AC0PlayerSaveData.txt";
                playingState.Text = "Not Playing";
                Setting_Load();
                InitDiscordRPC();
                OutputDevice();
                //Timer();
            }
            catch (Exception err) {
                MessageBox.Show($"Error1: {err.Message}");
            }
        }

        void Setting_Load() {
            //Grabbing song directory
            Read(1);
            songDirectory = settingRead;
            currentDir.Text = "Current Directory: " + songDirectory;

            if (songDirectory != "" && Directory.Exists(songDirectory)) {
                RefreshDir();
            }

            //Grabbing theme state
            Read(2);
            if (settingRead == "0") {
                drkTheme.CheckState = CheckState.Unchecked;
            } else if (settingRead == "1") {
                drkTheme.CheckState = CheckState.Checked;
            } else {
                drkTheme.CheckState = CheckState.Unchecked;
            }

            //Grabbing Volume
            Read(3);
            volumeKnob.Value = Convert.ToDouble(settingRead);

            //Grabbing Shuffle and Loop
            Read(4);
            if (settingRead == "1") {
                loopChkBx.CheckState = CheckState.Checked;
            } else {
                loopChkBx.CheckState = CheckState.Unchecked;
            }

            Read(5);
            if (settingRead == "1") {
                shuffleBx.CheckState = CheckState.Checked;
            } else {
                shuffleBx.CheckState = CheckState.Unchecked;
            }

            //Grabbing Discord Motd
            Read(6);
            discordTBx.Text = settingRead;
        }

        async void Play() {
            try {
                await Task.Delay(1000);

                song = songList.SelectedItem.ToString();

                songName = song.Replace($@"{songDirectory}\", "");
                songName = songName.Replace(".mp3", "");
                songName = songName.Replace(".wav", "");
                songName = songName.Replace("_", " ");

                var mf = new MediaFoundationReader(song);
                var wo = new WaveOutEvent();

                wo.Init(mf);
                wo.Play();

                IsPaused = false;
                IsPlaying = true;

                while (IsPlaying == true) {
                    playingState.Text = $"Now Playing: {songName}";

                    OutputDevice();

                    string tempTime = mf.CurrentTime.ToString();
                    string tempTotal = mf.TotalTime.ToString();
                    int index = tempTime.IndexOf(".");
                    int index2 = tempTotal.IndexOf(".");
                    if (index2 > 0) {
                        tempTotal = tempTotal.Substring(0, index2);
                    }
                    if (index > 0) {
                        songTime.Text = tempTime.Substring(0, index) + " - " + tempTotal;
                    }

                    client.SetPresence(new RichPresence() {
                        State = $"{songTime.Text}",
                        Details = $"Now Playing: {songName}",
                        Assets = new Assets() {
                            LargeImageKey = "7ac0mediaplayericon",
                            LargeImageText = discordTBx.Text
                        }
                    });

                    wo.Volume = (float)volumeKnob.Value;
                    wo.Play();

                    while (IsPaused == true) {
                        playingState.Text = "Paused";
                        wo.Pause();
                        client.SetPresence(new RichPresence() {
                            State = "Paused",
                            Assets = new Assets() {
                                LargeImageKey = "7ac0mediaplayericon",
                                LargeImageText = discordTBx.Text
                            }
                        });
                        await Task.Delay(100);
                    }

                    if (mf.CurrentTime.TotalSeconds > (mf.TotalTime.TotalSeconds - 1)) {
                        IsPlaying = false;
                    }

                    await Task.Delay(100);
                }

                if (loopChkBx.CheckState == CheckState.Checked) {
                    Loop();
                    wo.Stop();
                    wo.Dispose();
                    return;
                }

                if (shuffleBx.CheckState ==  CheckState.Checked) {
                    Shuffle();
                    wo.Stop();
                    wo.Dispose();
                    return;
                }

                client.SetPresence(new RichPresence() {
                    State = "Not Playing",
                    Assets = new Assets() {
                        LargeImageKey = "7ac0mediaplayericon",
                        LargeImageText = discordTBx.Text
                    }
                });

                IsPlaying = false;
                playBtn.Visible = true;
                pauseBtn.Visible = false;

                wo.Stop();
                wo.Dispose();
                FlushMemory();
            }
            catch (Exception err) {
                MessageBox.Show($"Error2: {err.Message}");
            }
        }

        void Shuffle() {
            FlushMemory();
            Random rnd = new Random();
            songList.SelectedIndex = rnd.Next(0, songList.Items.Count);
            Play();
        }

        void Loop() {
            FlushMemory();
            var currentSongInt = songList.SelectedIndex;
            currentSongInt++;
            if (currentSongInt >= songList.Items.Count) {
                currentSongInt = 0;
            }
            songList.SelectedIndex = currentSongInt;
            Play();
        }

        private void browseBtn_Click(object sender, EventArgs e) {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                songDirectory = folderBrowserDialog1.SelectedPath;
                currentDir.Text = "Current Directory: " + songDirectory;
                Save(1, songDirectory);
                RefreshDir();
            }
        }

        void RefreshDir() {
            songList.Items.Clear();
            var ext = new List<string> { ".mp3", ".wav" };
            IEnumerable<string> files = Directory.EnumerateFiles(songDirectory, "*.*", SearchOption.AllDirectories).Where(s => ext.Contains(Path.GetExtension(s)));
            foreach (string f in files) {
                FileInfo fi = new FileInfo(f);
                string ss = fi.FullName;
                songList.Items.Add(ss);
            }
        }

        void Save(int lineToEdit, string data) {
            try {
                string[] arrLine = File.ReadAllLines(saveData);
                arrLine[lineToEdit - 1] = data;
                File.WriteAllLines(saveData, arrLine);
            }
            catch (Exception err) {
                MessageBox.Show($"Error: Failed to save data to file. {err.Message}");
            }
        }

        void Read(int lineToRead) {
            try {
                string[] arrLine = File.ReadAllLines(saveData);
                settingRead = arrLine[lineToRead - 1];
            }
            catch (Exception err) {
                MessageBox.Show($"Error: Failed to read data from file. {err.Message}");
            }
        }

        void drkTheme_CheckedChanged(object sender, EventArgs e) {
            if (drkTheme.CheckState == CheckState.Checked) {
                this.BackColor = Color.Gray;
                songList.BackColor = Color.DarkGray;
                searchBox.BackColor = Color.DarkGray;
                discordTBx.BackColor = Color.DarkGray;
                Save(2, "1");
            } else if (drkTheme.CheckState == CheckState.Unchecked) {
                this.BackColor = Color.White;
                songList.BackColor = Color.LightGray;
                searchBox.BackColor = Color.LightGray;
                discordTBx.BackColor = Color.LightGray;
                Save(2, "0");
            }
        }

        void FlushMemory() {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void playBtn_Click(object sender, EventArgs e) {
            if (IsPlaying == false) {
                Play();
                IsPaused = false;
                pauseBtn.Visible = true;
                playBtn.Visible = false;
            } else {
                IsPaused = false;
                pauseBtn.Visible = true;
                playBtn.Visible = false;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e) {
            Stop();
        }

        void Stop() {
            FlushMemory();
            IsPlaying = false;
            IsPaused = false;
        }

        private void pauseBtn_Click(object sender, EventArgs e) {
            IsPaused = true;
            playBtn.Visible = true;
            pauseBtn.Visible = false;
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {
            if (searchBox.Text == "") {
                songList.Items.Clear();
                var ext = new List<string> { ".mp3", ".wav" };
                IEnumerable<string> files = Directory.EnumerateFiles(songDirectory, "*.*", SearchOption.AllDirectories).Where(s => ext.Contains(Path.GetExtension(s)));
                foreach (string f in files) {
                    FileInfo fi = new FileInfo(f);
                    string ss = fi.FullName;
                    songList.Items.Add(ss);
                }
            } else {
                songList.Items.Clear();
                IEnumerable<string> files = Directory.EnumerateFiles(songDirectory, "*.*", SearchOption.AllDirectories).Where(x => x.Contains(searchBox.Text));
                foreach (string f in files) {
                    FileInfo fi = new FileInfo(f);
                    string ss = fi.FullName;
                    songList.Items.Add(ss);
                }
            }
        }

        private void loopChkBx_CheckedChanged(object sender, EventArgs e) {
            if (shuffleBx.CheckState == CheckState.Unchecked && loopChkBx.CheckState == CheckState.Unchecked) {
                Save(4, "0");
                Save(5, "0");
                return;
            }

            if (loopChkBx.CheckState == CheckState.Checked) {
                shuffleBx.CheckState = CheckState.Unchecked;
                Save(4, "1");
                Save(5, "0");
            }
        }

        private void shuffleBx_CheckedChanged(object sender, EventArgs e) {
            if (shuffleBx.CheckState == CheckState.Unchecked && loopChkBx.CheckState == CheckState.Unchecked) {
                Save(4, "0");
                Save(5, "0");
                return;
            }

            if (shuffleBx.CheckState == CheckState.Checked) {
                loopChkBx.CheckState = CheckState.Unchecked;
                Save(4, "0");
                Save(5, "1");
            }
        }

        private void discordTBx_TextChanged(object sender, EventArgs e)
        {
            Save(6, discordTBx.Text);
        }

        void OutputDevice() {
            var enumerator = new MMDeviceEnumerator();
            var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            currentAudioDevice.Text = $"Output Device: {device.ToString()}";
        }

        bool playToggle = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.MediaPlayPause)
            {
                if (playToggle == false)
                {
                    playBtn.PerformClick();
                    playToggle = true;
                }
                else if (playToggle == true)
                {
                    pauseBtn.PerformClick();
                    playToggle = false;
                }
            }

            if (e.KeyCode == Keys.MediaStop)
            {
                stopBtn.PerformClick();
            }
        }

        //async void Timer() {
        //    while (true)
        //    {
        //        await Task.Delay(10);
        //    }
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Save(3, $"{volumeKnob.Value}");
        }
    }
}