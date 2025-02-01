using Quasar.Features;
using Quasar.UserControls;
using NAudio.Wave;
using System.Runtime.InteropServices;
using Quasar.Scripts;

namespace Quasar
{
    public partial class CheatMenu : Form
    {
        #region Window Settings
        private bool _showed = true;
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public const string WindowName = "Counter-Strike: Source";

        public static IntPtr handle = FindWindow(null, WindowName);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]

        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);
        public static RECT rect;
        public struct RECT
        {
            public int left, top, right, bottom;
        }
        #endregion

        private Functions _functions = new Functions();

        private Visual_UC _visualUC = new Visual_UC();
        private Contacts_UC _contactsUC = new Contacts_UC();
        private Aimbot_UC _aimbotUC;
        private Misc_UC _miscUC;
        public CheatMenu(bool windowed)
        {
            InitializeComponent();

            _functions.Inject();
            AddUserControl(_visualUC);
            _miscUC = new Misc_UC(_functions);
            _aimbotUC = new Aimbot_UC(_functions);

            if (windowed)
            {
                ResolutionSettings();
            }
        }

        private void ResolutionSettings()
        {
            CheckForIllegalCrossThreadCalls = true;

            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            GetWindowRect(handle, out rect);

            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);

            this.Left = rect.left;
            this.Top = rect.top;

            Thread thread = new Thread(Update)
            {
                IsBackground = true
            };
            thread.Start();
        }

        public async void Update()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.Home) < 0)
                {
                    _showed = !_showed;

                    this.Invoke(new Action(() => this.Visible = _showed));
                    await Task.Delay(100);
                }

                Thread.Sleep(1);
            }
        }

        private void PlaySound(string audioFilePath)
        {
            using (var audioFile = new AudioFileReader(audioFilePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(1);
                }
            }
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            container_panel.Controls.Clear();
            container_panel.Controls.Add(userControl);
            userControl.BringToFront();
            PlaySound("Sounds/click.wav");
        }

        private void visual_button_Click(object sender, EventArgs e)
        {
            AddUserControl(_visualUC);
        }

        private void CheatMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            States.DisableAll();
            Environment.Exit(0);
        }

        private void misc_button_Click(object sender, EventArgs e)
        {
            AddUserControl(_miscUC);
        }

        private void unhook_button_Click(object sender, EventArgs e)
        {
            States.DisableAll();
            Environment.Exit(0);
        }

        private void contact_button_Click(object sender, EventArgs e)
        {
            AddUserControl(_contactsUC);
        }

        private void aimbot_button_Click(object sender, EventArgs e)
        {
            AddUserControl(_aimbotUC);
        }
    }
}
