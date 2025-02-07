using Vexium.UserControls;
using static Vexium.Scripts.SoundManager;
using System.Runtime.InteropServices;
using Vexium.Scripts;
using Vexium.Scripts.Features;

namespace Vexium
{
    public partial class CheatMenu : Form
    {
        #region Import dll
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        public const string WindowName = "Counter-Strike: Source";
        public static IntPtr handle = FindWindow(null, WindowName);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
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
        public Visual_UC _visualUC = new Visual_UC();
        public Other_UC _otherUC = new Other_UC();
        public Combat_UC _combatUC;
        public Misc_UC _miscUC;

        private System.Windows.Forms.Timer _colorTimer;

        public static bool colorTransition;

        private bool _showed = true;

        private float _hue;

        public CheatMenu(bool windowed)
        {
            InitializeComponent();
            _functions.Inject();
            AddUserControl(_visualUC);

            _miscUC = new Misc_UC(_functions);
            _combatUC = new Combat_UC(_functions);
            States.combatUC = _combatUC;
            States.miscUC = _miscUC;
            States.visualUC = _visualUC;

            if (windowed)
            {
                ResolutionSettings();
            }

            StartColorTransition();
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

            Thread thread = new Thread(Update) { IsBackground = true };
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

        private void StartColorTransition()
        {
            _colorTimer = new System.Windows.Forms.Timer();
            _colorTimer.Interval = 30;
            _colorTimer.Tick += (s, e) =>
            {
                if (colorTransition)
                {
                    _hue += 1f;
                    if (_hue >= 360) _hue = 0;

                    ui2_panel.BackColor = ColorFromHSV(_hue, 1, 1);
                }
                else
                {
                    ui2_panel.BackColor = Color.FromArgb(255, 20, 55);
                }
            };

            _colorTimer.Start();
        }

        private Color ColorFromHSV(float hue, float saturation, float value)
        {
            int hi = (int)(hue / 60) % 6;
            float f = hue / 60 - (int)(hue / 60);
            value = value * 255;
            int v = (int)value;
            int p = (int)(value * (1 - saturation));
            int q = (int)(value * (1 - f * saturation));
            int t = (int)(value * (1 - (1 - f) * saturation));

            switch (hi)
            {
                case 0: return Color.FromArgb(255, v, t);
                case 1: return Color.FromArgb(255, q, v);
                case 2: return Color.FromArgb(255, p, v);
                case 3: return Color.FromArgb(255, p, q);
                case 4: return Color.FromArgb(255, t, p);
                case 5: return Color.FromArgb(255, v, p);
                default: return Color.Black;
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
            States.DisableAll(true);
        }

        private void misc_button_Click(object sender, EventArgs e)
        {
            AddUserControl(_miscUC);
        }

        private void unhook_button_Click(object sender, EventArgs e)
        {
            States.DisableAll(true);
        }

        private void other_button_Click(object sender, EventArgs e)
        {
            AddUserControl(_otherUC);
        }

        private void aimbot_button_Click(object sender, EventArgs e)
        {
            AddUserControl(_combatUC);
        }
    }
}
