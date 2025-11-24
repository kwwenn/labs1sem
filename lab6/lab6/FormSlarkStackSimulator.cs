using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace _3lab
{
    public partial class FormSlarkStackSimulator : Form
    {
        private int stacksCount = 0;
        private List<DateTime> stackTimers = new List<DateTime>();
        private Timer cleanupTimer;
        private Random random = new Random();
        private List<string> soundFiles = new List<string>();

        public FormSlarkStackSimulator()
        {
            InitializeComponent();
            LoadSoundFiles();
            LoadSlarkImage();
            InitializeTimers();
            UpdateStacksDisplay();
        }

        private void LoadSoundFiles()
        {
            
            string soundsPath = Path.Combine(Application.StartupPath, "Sounds");

            if (Directory.Exists(soundsPath))
            {
                string[] files = Directory.GetFiles(soundsPath, "*.wav");
                soundFiles.AddRange(files);
            }
        }

        private void LoadSlarkImage()
        {
            try
            {
                string[] imageExtensions = { ".png", ".jpg", ".jpeg", ".bmp", ".gif" };
                string imagePath = null;

                foreach (string ext in imageExtensions)
                {
                    string testPath = Path.Combine(Application.StartupPath, "slark" + ext);
                    if (File.Exists(testPath))
                    {
                        imagePath = testPath;
                        break;
                    }
                }

                if (imagePath != null)
                {
                    picSlark.Image = Image.FromFile(imagePath);
                }
                else
                {
                    
                    picSlark.BackColor = Color.DarkBlue;
                    picSlark.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
        }

        private void InitializeTimers()
        {
            cleanupTimer = new Timer();
            cleanupTimer.Interval = 1000;
            cleanupTimer.Tick += CleanupTimer_Tick;
            cleanupTimer.Start();
        }

        private void CleanupTimer_Tick(object sender, EventArgs e)
        {
            CheckExpiredStacks();
        }

        private void CheckExpiredStacks()
        {
            DateTime now = DateTime.Now;
            int expiredCount = 0;

            for (int i = stackTimers.Count - 1; i >= 0; i--)
            {
                if (now >= stackTimers[i])
                {
                    stackTimers.RemoveAt(i);
                    expiredCount++;
                }
            }


            if (expiredCount > 0)
            {
                stacksCount = Math.Max(0, stacksCount - expiredCount);
                UpdateStacksDisplay();
            }
        }

        private void btnAddStack_Click(object sender, EventArgs e)
        {

            stacksCount++;
            stackTimers.Add(DateTime.Now.AddSeconds(35));


            if (random.Next(100) < 20)
            {
                PlayRandomSlarkSound();
            }

            UpdateStacksDisplay();
        }

        private void PlayRandomSlarkSound()
        {
            if (soundFiles.Count > 0)
            {

                string randomSound = soundFiles[random.Next(soundFiles.Count)];
                PlaySoundFile(randomSound);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void PlaySoundFile(string filePath)
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(filePath))
                {
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка воспроизведения звука: {ex.Message}");
            }
        }

        private void UpdateStacksDisplay()
        {
            lblStacksCount.Text = $"Стаков: {stacksCount}";
            lblAgility.Text = $"Ловкость: +{stacksCount * 4}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            cleanupTimer.Stop();
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            cleanupTimer?.Stop();
            cleanupTimer?.Dispose();
            base.OnFormClosed(e);
        }
    }
}