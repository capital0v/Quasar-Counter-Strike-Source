using System.Diagnostics;
using Vexium.Scripts;
using static Vexium.Scripts.SoundManager;

namespace Vexium.UserControls
{
    public partial class Other_UC : UserControl
    {
        private readonly string _menuSound = "Sounds/click3.wav";
        private readonly string _offsets = "    class Offsets\r\n    {\r\n        private static readonly Dictionary<string, OffsetsData> _offsets = new Dictionary<string, OffsetsData>\r\n        {\r\n            { \"current\", new OffsetsData\r\n                {\r\n                    Client = new ClientOffsets\r\n                    {\r\n                        weaponName = 0x4D4E63,\r\n                        thirdperson = 0x5065AC,\r\n                        thirdpersonVoidAddress = 0x145220,\r\n                        thirdpersonAddressBytes = new byte[] { 0xC6, 0x81, 0x8D, 0x00, 0x00, 0x00, 0x00 },\r\n                        r_drawothermodels = 0x4C4BA0,\r\n                        r_drawparticles = 0x4F7A40,\r\n                        r_drawrenderhitboxes = 0x4C5FA0,\r\n                        cl_bob = 0x50C868,\r\n                        dwEntityList = 0x4D5AE4,\r\n                        cl_showPos = 0x4FBD18\r\n                    },\r\n                    Engine = new EngineOffsets\r\n                    {\r\n                        sv_cheats = 0x616A70,\r\n                        mat_WireFrame = 0x5ADD60,\r\n                        viewangles_x = 0x47C340,\r\n                        viewangles_y = 0x47C33C,\r\n                        r_shadowwireframe = 0x5D1768,\r\n                        r_visualizetracers = 0x5AA410\r\n                    },\r\n                    Player = new PlayerOffsets\r\n                    {\r\n                        dwLocalPlayer = 0x4C88E8,\r\n                        dwForceJump = 0x4F5D24,\r\n                        crosshairID = 0x14F0,\r\n                        m_fFlags = 0x350,\r\n                        m_iTeamNum = 0x9C,\r\n                        m_iHealth = 0x94,\r\n                        m_iArmor = 0x1498,\r\n                        m_vecPosition = 0x260,\r\n                        fMaxFlashAlpha = 0x1450,\r\n                        m_iObserverMode = 0x103C,\r\n                        m_iAccount = 0x148C,\r\n                        dwForceAttack = 0x4F5D30,\r\n                        m_lifeState = 0x93\r\n                    },\r\n                    Steam = new SteamOffsets\r\n                    {\r\n                        nickname = 0x6D09E8,\r\n                        clantag = 0x6D0AB0,\r\n                    },\r\n                    Vgui = new VguiOffsets\r\n                    {\r\n                        isPause = 0x56DD8\r\n                    },\r\n                    Server = new ServerOffsets\r\n                    {\r\n                        sv_showimpact = 0x588598\r\n                    },\r\n                    Material = new MaterialSystemOffsets\r\n                    {\r\n                        mat_fullbright = 0x121EF8,\r\n                        mat_showlowresimage = 0x121EB0\r\n                    }\r\n                }\r\n            },\r\n        };\r\n\r\n        public static OffsetsData GetOffsets(string version)\r\n        {\r\n            return _offsets!.TryGetValue(version, out var offsets) ? offsets : null;\r\n        }\r\n\r\n        public class OffsetsData\r\n        {\r\n            public ClientOffsets? Client { get; set; }\r\n            public EngineOffsets? Engine { get; set; }\r\n            public PlayerOffsets? Player { get; set; }\r\n            public SteamOffsets? Steam { get; set; }\r\n            public VguiOffsets? Vgui { get; set; }\r\n            public ServerOffsets? Server { get; set; }\r\n            public MaterialSystemOffsets? Material { get; set; }\r\n        }\r\n\r\n        public class ClientOffsets\r\n        {\r\n            public int weaponName;\r\n            public int thirdperson;\r\n            public int thirdpersonVoidAddress;\r\n            public byte[] thirdpersonAddressBytes;\r\n            public int r_drawothermodels;\r\n            public int r_drawparticles;\r\n            public int r_drawrenderhitboxes;\r\n            public int cl_bob;\r\n            public int dwEntityList;\r\n            public int cl_showPos;\r\n        }\r\n\r\n        public class EngineOffsets\r\n        {\r\n            public int sv_cheats;\r\n            public int mat_WireFrame;\r\n            public int viewangles_x;\r\n            public int viewangles_y;\r\n            public int r_shadowwireframe;\r\n            public int r_visualizetracers;\r\n        }\r\n\r\n        public class PlayerOffsets\r\n        {\r\n            public int dwLocalPlayer;\r\n            public int dwForceJump;\r\n            public int crosshairID;\r\n            public int m_fFlags;\r\n            public int m_iTeamNum;\r\n            public int m_iHealth;\r\n            public int m_iArmor;\r\n            public int m_vecPosition;\r\n            public int fMaxFlashAlpha;\r\n            public int m_iObserverMode;\r\n            public int m_iAccount;\r\n            public int dwForceAttack;\r\n            public int m_lifeState;\r\n        }\r\n\r\n        public class SteamOffsets\r\n        {\r\n            public int nickname;\r\n            public int clantag;\r\n        }\r\n\r\n        public class VguiOffsets\r\n        {\r\n            public int isPause;\r\n        }\r\n\r\n        public class ServerOffsets\r\n        {\r\n            public int sv_showimpact;\r\n        }\r\n\r\n        public class MaterialSystemOffsets\r\n        {\r\n            public int mat_fullbright;\r\n            public int mat_showlowresimage;\r\n        }\r\n    }";
        public Other_UC()
        {
            InitializeComponent();
        }

        private void github_picture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/capital0v") { UseShellExecute = true });
            PlaySound(_menuSound);
        }

        private void telegram_picture_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://t.me/capital0v") { UseShellExecute = true });
            PlaySound(_menuSound);
        }

        private void colortransition_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheatMenu.colorTransition = colortransition_checkbox.Checked;
            PlaySound(_menuSound);
        }

        private void saveoffsets_button_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "offsets.cs");
            System.IO.File.WriteAllText(filePath, _offsets);
            MessageBox.Show("File 'offsets.cs' has been created on your desktop.", "File Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PlaySound(_menuSound);
        }

        private void turnoffall_button_Click(object sender, EventArgs e)
        {
            States.DisableAll(false);
            PlaySound(_menuSound);
        }
    }
}
