using Capitalov;
using System.Numerics;
using System.Runtime.InteropServices;
using static Quasar.Scripts.Offsets;
using static Quasar.Scripts.States;

namespace Quasar.Features
{
    internal class Functions
    {
        #region Import
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys ArrowKeys);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        #endregion

        private static readonly Dictionary<int, string> Teams = new Dictionary<int, string>
        {
            { 1, "Spectator" },
            { 2, "Terrorist" },
            { 3, "Counter-Terrorist" }
        };

        private static readonly Dictionary<int, string> Flags = new Dictionary<int, string>
        {
            { 257, "Standing" },
            { 256, "In air" },
            { 261, "Not full crouching" },
            { 263, "Crouching" }
        };

        private MemoryRaider _memory = new MemoryRaider();

        private List<Entity> _entities = new List<Entity>();

        private nint _client, _engine, _server, _materialsystem, _steam;

        private IntPtr _localPlayer;

        public static string targetLevel = string.Empty;
        public static bool mousePressed = false;

        public void Inject()
        {
            _memory.Inject("hl2");
            _client = _memory.GetModuleBase("client.dll");
            _engine = _memory.GetModuleBase("engine.dll");
            _server = _memory.GetModuleBase("server.dll");
            _steam = _memory.GetModuleBase("steamclient.dll");
            _materialsystem = _memory.GetModuleBase("materialsystem.dll");

            Task.Run(() =>
            {
                Update();
                EnableSvCheats();
            });
        }

        private void Update()
        {
            while (true)
            {
                _localPlayer = _memory.ReadPointer(_client, dwLocalPlayer);

                Bunnyhop();
                Wallhack();
                ShowImpact();
                Antiflash();
                Triggerbot();
                MatFullBright();
                WhiteTexture();
                NoSmoke();
                DrawHitboxes();
                DrawTracers();
                DrawShadowFrame();
                DrawLowResolution();
                Aimbot();

                Thread.Sleep(1);
            }
        }

        private void Wallhack()
        {
            _memory.Write<int>(_client + r_drawothermodels, wallhackEnabled ? 2 : 1);
        }

        private void EnableSvCheats()
        {
            while (true)
            {
                _memory.Write<int>(_engine + sv_cheats, 1);

                Thread.Sleep(500);
            }
        }

        private void Bunnyhop()
        {
            if (bunnyhopEnabled)
            {
                int flags = _memory.Read<int>(_localPlayer + m_fFlags);

                if (GetAsyncKeyState(Keys.Space) < 0 && (flags == 257 || flags == 263))
                {
                    _memory.Write<int>(_client + dwForceJump, 5);
                    Thread.Sleep(1);
                    _memory.Write<int>(_client + dwForceJump, 4);
                }
            }
        }

        private void ShowImpact()
        {
            _memory.Write<int>(_server + sv_showimpact, showimpactEnabled ? 1 : 0);
        }

        private void Antiflash()
        {
            if (antiflashEnabled)
            {
                _memory.Write<int>(_localPlayer + fMaxFlashAlpha, 0);
            }
        }

        private void Aimbot()
        {
            if (aimbotEnabled)
            {
                Vector3 player_pos = _memory.ReadVector(_localPlayer + m_vecPosition);
                int player_team = _memory.Read<int>(_localPlayer + m_iTeamNum);

                for (int i = 0; i < 32; i++)
                {
                    IntPtr entity = _memory.Read<int>(_client + (dwEntityList + (i - 1) * 0x10));

                    if (entity > 0)
                    {
                        int health = _memory.Read<int>(entity + m_iHealth);
                        int team = _memory.Read<int>(entity + m_iTeamNum);

                        if (health > 1 && team != player_team)
                        {
                            Entity ent = new Entity();

                            ent.Address = entity;
                            ent.Health = health;
                            ent.Team = team;
                            ent.Position = _memory.ReadVector(ent.Address + m_vecPosition);
                            ent.Distance = Vector3.Distance(player_pos, ent.Position);

                            switch (targetLevel)
                            {
                                case "Neck":
                                    ent.Position += new Vector3(0, 0, -3);
                                    break;
                                case "Body":
                                    ent.Position += new Vector3(0, 0, -15);
                                    break;
                                case "Legs":
                                    ent.Position += new Vector3(0, 0, -30);
                                    break;
                            }

                            _entities.Add(ent);
                        }
                    }
                }

                _entities = _entities.OrderBy(e => e.Distance).ToList();

                if (_entities.Count > 0)
                {
                    Vector2 angles = CalculateAngles(player_pos, _entities[0].Position);
                    Vector3 newAngles = new Vector3(angles.Y, angles.X, 0);

                    if (mousePressed)
                    {
                        if ((GetAsyncKeyState(Keys.LButton) & 0x8000) != 0)
                        {
                            _memory.WriteVector(_engine + viewangles_y, newAngles);
                        }
                    }
                    else
                    {
                        _memory.WriteVector(_engine + viewangles_y, newAngles);
                    }
                }

                _entities.Clear();
            }
        }

        private Vector2 CalculateAngles(Vector3 from, Vector3 to)
        {
            float yaw, pitch;

            float x = to.X - from.X;
            float y = to.Y - from.Y;
            float z = to.Z - from.Z;

            yaw = (float)(Math.Atan2(y, x) * 180 / Math.PI);

            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            pitch = -(float)(Math.Atan2(z, distance) * 180 / Math.PI);

            return new Vector2(yaw, pitch);
        }

        private void Triggerbot()
        {
            if (triggerbotEnabled)
            {
                int crosshair = _memory.Read<int>(_localPlayer + crosshairID);

                if (crosshair != 0 && crosshair <= 32)
                {
                    int entity = _memory.Read<int>(_client + (dwEntityList + (crosshair - 1) * 0x10));

                    if (entity != 0)
                    {
                        int enemy_team = _memory.Read<int>(entity + m_iTeamNum);
                        int player_team = _memory.Read<int>(_localPlayer + m_iTeamNum);

                        if (player_team != enemy_team)
                        {
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);

                            Thread.Sleep(1);

                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        }
                    }
                }
            }
        }

        private void MatFullBright()
        {
            if (fullbrightEnabled)
            {
                _memory.Write<int>(_materialsystem + mat_fullbright, 1);
            }
            else if (!whiteTextureEnabled)
            {
                _memory.Write<int>(_materialsystem + mat_fullbright, 0);
            }
        }

        private void WhiteTexture()
        {
            if (whiteTextureEnabled)
            {
                _memory.Write<int>(_materialsystem + mat_fullbright, 2);
            }
            else if (!fullbrightEnabled)
            {
                _memory.Write<int>(_materialsystem + mat_fullbright, 0);
            }
        }

        private void NoSmoke()
        {
            _memory.Write<int>(_client + r_drawparticles, nosmokeEnabled ? 0 : 1);
        }

        private void DrawHitboxes()
        {
            _memory.Write<int>(_client + r_drawrenderhitboxes, hitboxesEnabled ? 1 : 0);
        }

        private void DrawTracers()
        {
            _memory.Write<int>(_engine + r_visualizetracers, tracersEnabled ? 1 : 0);
        }

        private void DrawShadowFrame()
        {
            _memory.Write<int>(_engine + r_shadowwireframe, shadowFrameEnabled ? 1 : 0);
        }

        private void DrawLowResolution()
        {
            _memory.Write<int>(_materialsystem + mat_showlowresimage, lowresolutionEnabled ? 1 : 0);
        }

        public string GetInformation()
        {
            if (getInformationEnabled)
            {
                int flagsID = _memory.Read<int>(_localPlayer + m_fFlags);
                int teamID = _memory.Read<int>(_localPlayer + m_iTeamNum);
                int health = _memory.Read<int>(_localPlayer + m_iHealth);
                int armor = _memory.Read<int>(_localPlayer + m_iArmor);

                string weapon = _memory.ReadString(_client + weaponName, 15);

                string team = Teams.TryGetValue(teamID, out var teamName) ? teamName : "Unknown Team";
                string flag = Flags.TryGetValue(flagsID, out var flagName) ? flagName : "Unknown State";

                return $"Team: {team}\nStatus: {flag}\nHealth {health}\nArmor: {armor}\nWeapon: {weapon}";
            }

            return "Error";
        }

        public void ChangeNickname(string newNickname)
        {
            _memory.WriteString(_steam + nickname, "                                                        ");
            _memory.WriteString(_steam + nickname, newNickname);
        }

        public void ChangeClantag(string newClantag)
        {
            _memory.WriteString(_steam + clantag, "                                                        ");
            _memory.WriteString(_steam + clantag, newClantag);
        }
    }
}