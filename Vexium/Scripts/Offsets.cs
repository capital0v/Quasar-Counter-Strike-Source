namespace Vexium.Scripts
{
    class Offsets
    {
        private static readonly Dictionary<string, OffsetsData> _offsets = new Dictionary<string, OffsetsData>
        {
            { "current", new OffsetsData
                {
                    Client = new ClientOffsets
                    {
                        weaponName = 0x4D4E63,
                        thirdperson = 0x5065AC,
                        thirdpersonVoidAddress = 0x145220,
                        thirdpersonAddressBytes = new byte[] { 0xC6, 0x81, 0x8D, 0x00, 0x00, 0x00, 0x00 },
                        r_drawothermodels = 0x4C4BA0,
                        r_drawparticles = 0x4F7A40,
                        r_drawrenderhitboxes = 0x4C5FA0,
                        cl_bob = 0x50C868,
                        dwEntityList = 0x4D5AE4,
                        cl_showPos = 0x4FBD18
                    },
                    Engine = new EngineOffsets
                    {
                        sv_cheats = 0x616A70,
                        mat_WireFrame = 0x5ADD60,
                        viewangles_x = 0x47C340,
                        viewangles_y = 0x47C33C,
                        r_shadowwireframe = 0x5D1768,
                        r_visualizetracers = 0x5AA410
                    },
                    Player = new PlayerOffsets
                    {
                        dwLocalPlayer = 0x4C88E8,
                        dwForceJump = 0x4F5D24,
                        crosshairID = 0x14F0,
                        m_fFlags = 0x350,
                        m_iTeamNum = 0x9C,
                        m_iHealth = 0x94,
                        m_iArmor = 0x1498,
                        m_vecPosition = 0x260,
                        fMaxFlashAlpha = 0x1450,
                        m_iObserverMode = 0x103C,
                        m_iAccount = 0x148C,
                        dwForceAttack = 0x4F5D30,
                        m_lifeState = 0x93
                    },
                    Steam = new SteamOffsets
                    {
                        nickname = 0x6D09E8,
                        clantag = 0x6D0AB0,
                    },
                    Vgui = new VguiOffsets
                    {
                        isPause = 0x56DD8
                    },
                    Server = new ServerOffsets
                    {
                        sv_showimpact = 0x588598
                    },
                    Material = new MaterialSystemOffsets
                    {
                        mat_fullbright = 0x121EF8,
                        mat_showlowresimage = 0x121EB0
                    }
                }
            },
        };

        public static OffsetsData GetOffsets(string version)
        {
            return _offsets!.TryGetValue(version, out var offsets) ? offsets : null;
        }

        public class OffsetsData
        {
            public ClientOffsets? Client { get; set; }
            public EngineOffsets? Engine { get; set; }
            public PlayerOffsets? Player { get; set; }
            public SteamOffsets? Steam { get; set; }
            public VguiOffsets? Vgui { get; set; }
            public ServerOffsets? Server { get; set; }
            public MaterialSystemOffsets? Material { get; set; }
        }

        public class ClientOffsets
        {
            public int weaponName;
            public int thirdperson;
            public int thirdpersonVoidAddress;
            public byte[] thirdpersonAddressBytes;
            public int r_drawothermodels;
            public int r_drawparticles;
            public int r_drawrenderhitboxes;
            public int cl_bob;
            public int dwEntityList;
            public int cl_showPos;
        }

        public class EngineOffsets
        {
            public int sv_cheats;
            public int mat_WireFrame;
            public int viewangles_x;
            public int viewangles_y;
            public int r_shadowwireframe;
            public int r_visualizetracers;
        }

        public class PlayerOffsets
        {
            public int dwLocalPlayer;
            public int dwForceJump;
            public int crosshairID;
            public int m_fFlags;
            public int m_iTeamNum;
            public int m_iHealth;
            public int m_iArmor;
            public int m_vecPosition;
            public int fMaxFlashAlpha;
            public int m_iObserverMode;
            public int m_iAccount;
            public int dwForceAttack;
            public int m_lifeState;
        }

        public class SteamOffsets
        {
            public int nickname;
            public int clantag;
        }

        public class VguiOffsets
        {
            public int isPause;
        }

        public class ServerOffsets
        {
            public int sv_showimpact;
        }

        public class MaterialSystemOffsets
        {
            public int mat_fullbright;
            public int mat_showlowresimage;
        }
    }
}

