using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppSwitcher
{
    public partial class Main : Form
    {
        private List<(Icon Icon, string Name)> icons;
        private Timer iconChangeTimer;

        public Main()
        {
            InitializeComponent();
            LoadIcons();
            InitializeTimer();
        }

        private void LoadIcons()
        {
            icons = new List<(Icon, string)>
            {
                (Properties.Resources.BlueStacks, "BlueStacks"),
                (Properties.Resources.DuckGo, "DuckDuckGo"),
                (Properties.Resources.EA, "EA"),
                (Properties.Resources.EpicGames, "EpicGames"),
                (Properties.Resources.FireFox, "FireFox"),
                (Properties.Resources.LogiTech, "LogiTech"),
                (Properties.Resources.Obs, "Obs"),
                (Properties.Resources.Steam, "Steam"),
                (Properties.Resources.Telegram, "Telegram"),
                (Properties.Resources.Tor, "Tor")
            };
        }

        private void InitializeTimer()
        {
            iconChangeTimer = new Timer();
            iconChangeTimer.Interval = 1000; // 1 seconds
            iconChangeTimer.Tick += (sender, e) => SetRandomIcon();
            iconChangeTimer.Start();
            SetRandomIcon();
        }

        private void SetRandomIcon()
        {
            Random random = new Random();
            int index = random.Next(icons.Count);
            var selectedIcon = icons[index];
            this.Icon = selectedIcon.Icon;
            this.Text = selectedIcon.Name;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}