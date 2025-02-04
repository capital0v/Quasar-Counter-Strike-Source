using Capitalov;
using System.Numerics;
using System.Runtime.InteropServices;
using static Quasar.Scripts.Offsets;
using static Quasar.Scripts.States;

namespace Quasar.Scripts.Features
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
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
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

        private static OffsetsData? _offsets;

        private List<Entity> _entities = new List<Entity>();

        private Entity _localPlayer = new Entity();

        private nint _client, _engine, _server, _materialsystem, _steam;

        public static string targetLevel = string.Empty;
        public static bool mousePressed = false;

        public void Inject()
        {
            _offsets = GetOffsets("34");
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
                _localPlayer.Address = _memory.ReadPointer(_client, _offsets!.Player!.dwLocalPlayer);
                _localPlayer.Position = _memory.ReadVector(_localPlayer.Address + _offsets!.Player!.m_vecPosition);
                _localPlayer.Health = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.m_iHealth);
                _localPlayer.Team = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.m_iTeamNum);
                _localPlayer.Flags = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.m_fFlags);

                GetEntityList();
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
                Thirdperson();
                Test();

                Thread.Sleep(1);
            }
        }

        private void Wallhack()
        {
            _memory.Write(_client + _offsets!.Client!.r_drawothermodels, wallhackEnabled ? 2 : 1);
        }

        private void EnableSvCheats()
        {
            while (true)
            {
                _memory.Write(_engine + _offsets!.Engine!.sv_cheats, 1);

                Thread.Sleep(500);
            }
        }

        private void Bunnyhop()
        {
            if (bunnyhopEnabled)
            {
                if (GetAsyncKeyState(Keys.Space) < 0 && (_localPlayer.Flags == 257 || _localPlayer.Flags == 263))
                {
                    _memory.Write(_client + _offsets!.Player!.dwForceJump, 5);
                    Thread.Sleep(1);
                    _memory.Write(_client + _offsets.Player.dwForceJump, 4);
                }
            }
        }

        private void ShowImpact()
        {
            _memory.Write(_server + _offsets!.Client!.sv_showimpact, showimpactEnabled ? 1 : 0);
        }

        private void Antiflash()
        {
            if (antiflashEnabled)
            {
                _memory.Write(_localPlayer.Address + _offsets!.Player!.fMaxFlashAlpha, 0);
            }
        }

        private void Knifebot(List<Entity> entities)
        {
            string weapon = _memory.ReadString(_client + _offsets!.Client!.weaponName, 5);

            if (weapon == "knife")
            {
                entities = _entities;

                if (entities.Count > 0)
                {
                    entities = _entities.OrderBy(e => e.Distance).ToList();

                    float distance = entities[0].Distance;

                    if (distance <= 63)
                    {
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);

                        Thread.Sleep(1);

                        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                    }
                }
            }
        }

        private void GetEntityList()
        {
            for (int i = 0; i < 32; i++)
            {
                nint entity = _memory.Read<int>(_client + (_offsets!.Client!.dwEntityList + i * 0x10));

                if (entity > 0)
                {
                    int health = _memory.Read<int>(entity + _offsets!.Player!.m_iHealth);
                    int team = _memory.Read<int>(entity + _offsets.Player.m_iTeamNum);

                    if (health > 1 && team != _localPlayer.Team)
                    {
                        Entity ent = new Entity();

                        ent.Address = entity;
                        ent.Health = health;
                        ent.Team = team;
                        ent.Position = _memory.ReadVector(ent.Address + _offsets.Player.m_vecPosition);
                        ent.Distance = Vector3.Distance(_localPlayer.Position, ent.Position);

                        _entities.Add(ent);
                    }
                }
            }

            if (aimbotEnabled)
            {
                Aimbot(_entities);
            }

            if (knifebotEnabled)
            {
                Knifebot(_entities);
            }

            _entities.Clear();
        }

        private void Aimbot(List<Entity> entities)
        {
            entities = _entities;

            if (entities.Count > 0)
            {
                entities = _entities.OrderBy(e => e.Distance).ToList();

                switch (targetLevel)
                {
                    case "Neck":
                        entities[0].Position += new Vector3(0, 0, -3);
                        break;
                    case "Body":
                        entities[0].Position += new Vector3(0, 0, -15);
                        break;
                    case "Legs":
                        entities[0].Position += new Vector3(0, 0, -30);
                        break;
                }

                Vector2 angles = CalculateAngles(_localPlayer.Position, entities[0].Position);
                Vector3 newAngles = new Vector3(angles.Y, angles.X, 0);

                if (mousePressed)
                {
                    if ((GetAsyncKeyState(Keys.LButton) & 0x8000) != 0)
                    {
                        _memory.WriteVector(_engine + _offsets!.Engine!.viewangles_y, newAngles);
                    }
                }
                else
                {
                    _memory.WriteVector(_engine + _offsets!.Engine!.viewangles_y, newAngles);
                }
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
                int crosshair = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.crosshairID);

                if (crosshair != 0 && crosshair <= 32)
                {
                    int entity = _memory.Read<int>(_client + (_offsets!.Client!.dwEntityList + (crosshair - 1) * 0x10));

                    if (entity != 0)
                    {
                        int enemy_team = _memory.Read<int>(entity + _offsets!.Player!.m_iTeamNum);

                        if (_localPlayer.Team != enemy_team)
                        {
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);

                            Thread.Sleep(1);

                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        }
                    }
                }
            }
        }

        private void Test()
        {
            int crosshair = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.crosshairID);

            if (crosshair != 0 && crosshair <= 32)
            {
                int entity = _memory.Read<int>(_client + (_offsets!.Client!.dwEntityList + (crosshair - 1) * 0x10));

                if (entity != 0)
                {
                    int entity_team = _memory.Read<int>(entity + _offsets!.Player!.m_iTeamNum);

                    if (_localPlayer.Team != entity_team)
                    {
                        Entity enemy = new Entity();
                        enemy.Address = entity;
                        enemy.Position = _memory.ReadVector(enemy.Address + _offsets.Player.m_vecPosition);
                        enemy.Distance = Vector3.Distance(_localPlayer.Position, enemy.Position);

                        switch (targetLevel)
                        {
                            case "Neck":
                                enemy.Position += new Vector3(0, 0, -3);
                                break;
                            case "Body":
                                enemy.Position += new Vector3(0, 0, -15);
                                break;
                            case "Legs":
                                enemy.Position += new Vector3(0, 0, -30);
                                break;
                        }

                        Vector2 angles = CalculateAngles(_localPlayer.Position, enemy.Position);
                        Vector3 newAngles = new Vector3(angles.Y, angles.X, 0);

                        if (mousePressed)
                        {
                            if ((GetAsyncKeyState(Keys.LButton) & 0x8000) != 0)
                            {
                                _memory.WriteVector(_engine + _offsets!.Engine!.viewangles_y, newAngles);
                            }
                        }
                        else
                        {
                            _memory.WriteVector(_engine + _offsets!.Engine!.viewangles_y, newAngles);
                        }
                    }
                }
            }
        }

        private void MatFullBright()
        {
            if (fullbrightEnabled)
            {
                _memory.Write(_materialsystem + _offsets!.Engine!.mat_fullbright, 1);
            }
            else if (!whiteTextureEnabled)
            {
                _memory.Write(_materialsystem + _offsets!.Engine!.mat_fullbright, 0);
            }
        }

        private void WhiteTexture()
        {
            if (whiteTextureEnabled)
            {
                _memory.Write(_materialsystem + _offsets!.Engine!.mat_fullbright, 2);
            }
            else if (!fullbrightEnabled)
            {
                _memory.Write(_materialsystem + _offsets!.Engine!.mat_fullbright, 0);
            }
        }

        private void NoSmoke()
        {
            _memory.Write(_client + _offsets!.Client!.r_drawparticles, nosmokeEnabled ? 0 : 1);
        }

        private void DrawHitboxes()
        {
            _memory.Write(_client + _offsets!.Client!.r_drawrenderhitboxes, hitboxesEnabled ? 1 : 0);
        }

        private void DrawTracers()
        {
            _memory.Write(_engine + _offsets!.Engine!.r_visualizetracers, tracersEnabled ? 1 : 0);
        }

        private void DrawShadowFrame()
        {
            _memory.Write(_engine + _offsets!.Engine!.r_shadowwireframe, shadowFrameEnabled ? 1 : 0);
        }

        private void DrawLowResolution()
        {
            _memory.Write(_materialsystem + _offsets!.Engine!.mat_showlowresimage, lowresolutionEnabled ? 1 : 0);
        }

        public string GetInformation()
        {
            if (getInformationEnabled)
            {
                int armor = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.m_iArmor);

                string weapon = _memory.ReadString(_client + _offsets!.Client!.weaponName, 15);

                string team = Teams.TryGetValue(_localPlayer.Team, out var teamName) ? teamName : "Unknown Team";
                string flag = Flags.TryGetValue(_localPlayer.Flags, out var flagName) ? flagName : "Unknown State";

                return $"Team: {team}\nStatus: {flag}\nHealth {_localPlayer.Health}\nArmor: {armor}\nWeapon: {weapon}";
            }

            return "Error";
        }

        public void ChangeNickname(string newNickname)
        {
            _memory.WriteString(_steam + _offsets!.Steam!.nickname, "                                                        ");
            _memory.WriteString(_steam + _offsets!.Steam!.nickname, newNickname);
        }

        public void ChangeClantag(string newClantag)
        {
            _memory.WriteString(_steam + _offsets!.Steam!.clantag, "                                                        ");
            _memory.WriteString(_steam + _offsets!.Steam!.clantag, newClantag);
        }

        public void Thirdperson()
        {
            if (thirdpersonEnabled)
            {
                _memory.Nop(_client + _offsets!.Client!.thirdpersonAddress, _offsets!.Client!.thirdpersonAddressBytes.Length);
                _memory.Write(_client + _offsets!.Client!.thirdperson, 256);
            }
            else
            {
                _memory.Write(_client + _offsets!.Client!.thirdperson, 0);
                _memory.WriteBytes(_client + _offsets!.Client!.thirdpersonAddress, _offsets!.Client!.thirdpersonAddressBytes);
            }
        }

    }
}