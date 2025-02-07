using Capitalov;
using System.Numerics;
using System.Runtime.InteropServices;
using static Vexium.Scripts.Offsets;
using static Vexium.Scripts.States;

namespace Vexium.Scripts.Features
{
    internal class Functions
    {
        #region Import
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys ArrowKeys);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private const byte KEYEVENTF_KEYUP = 0x0002;
        private const byte VK_1 = 0x31;
        private const byte VK_2 = 0x32;
        private const byte VK_3 = 0x33;
        private const byte VK_4 = 0x34;
        private const byte VK_5 = 0x35;
        private const byte VK_6 = 0x36;
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

        private nint _client, _engine, _server, _materialsystem, _steam, _vgui;

        private int _isPause;

        public string targetLevel = string.Empty;

        public bool mousePressed = false;

        public float aimSmoothness = 5;

        public void Inject()
        {
            _offsets = GetOffsets("current");
            _memory.Inject("hl2");
            _client = _memory.GetModuleBase("client.dll");
            _engine = _memory.GetModuleBase("engine.dll");
            _server = _memory.GetModuleBase("server.dll");
            _steam = _memory.GetModuleBase("steamclient.dll");
            _materialsystem = _memory.GetModuleBase("materialsystem.dll");
            _vgui = _memory.GetModuleBase("vgui2.dll");

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
                _localPlayer.LifeState = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.m_lifeState);
                _localPlayer.Money = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.m_iAccount);
                _isPause = _memory.Read<int>(_vgui + _offsets!.Vgui!.isPause);

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
                AimLock();
                ShowPos();
                Wireframe();

                Thread.Sleep(1);
            }
        }

        private void Wireframe()
        {
            _memory.Write(_engine + _offsets!.Engine!.mat_WireFrame, wireframeEnabled ? 1 : 0);
        }

        private void ShowPos()
        {
            _memory.Write(_client + _offsets!.Client!.cl_showPos, showPosEnabled ? 1 : 0);
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
            if (bunnyhopEnabled && _isPause == 0)
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
            _memory.Write(_server + _offsets!.Server!.sv_showimpact, showimpactEnabled ? 1 : 0);
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

                if (entity > 0 && entity != _localPlayer.Address)
                {
                    int health = _memory.Read<int>(entity + _offsets!.Player!.m_iHealth);
                    int team = _memory.Read<int>(entity + _offsets!.Player!.m_iTeamNum);
                    int lifeState = _memory.Read<int>(entity + _offsets!.Player!.m_lifeState);

                    if (lifeState != 257 && team != _localPlayer.Team)
                    {
                        Entity ent = new Entity();

                        ent.Address = entity;
                        ent.Health = health;
                        ent.Team = team;
                        ent.Position = _memory.ReadVector(ent.Address + _offsets!.Player!.m_vecPosition);
                        ent.Distance = Vector3.Distance(_localPlayer.Position, ent.Position);
                        ent.Money = _memory.Read<int>(ent.Address + _offsets!.Player!.m_iAccount);
                        ent.LifeState = lifeState;

                        _entities.Add(ent);
                    }
                }
            }

            if (_localPlayer.LifeState != 258)
            {
                if (aimbotEnabled)
                {
                    Aimbot(_entities);
                }

                if (knifebotEnabled)
                {
                    Knifebot(_entities);
                }
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
                    case "Neck": entities[0].Position += new Vector3(0, 0, -3); break;
                    case "Body": entities[0].Position += new Vector3(0, 0, -15); break;
                    case "Legs": entities[0].Position += new Vector3(0, 0, -30); break;
                }

                int crosshair = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.crosshairID);

                if (!(crosshair != 0 && crosshair <= 32))
                {
                    entities[0].Position += new Vector3(0, 0, -13);
                }

                Vector2 targetAngles = CalculateAngles(_localPlayer.Position, entities[0].Position);
                Vector3 newAngles = new Vector3(targetAngles.Y, targetAngles.X, 0);

                Vector3 currentAngles = _memory.ReadVector(_engine + _offsets!.Engine!.viewangles_y);

                float smoothFactor = aimSmoothness / 100.0f;

                Vector3 smoothedAngles = Lerp(currentAngles, newAngles, smoothFactor);

                if (mousePressed)
                {
                    if ((GetAsyncKeyState(Keys.LButton) & 0x8000) != 0)
                    {
                        _memory.WriteVector(_engine + _offsets!.Engine!.viewangles_y, smoothedAngles);
                    }
                }
                else
                {
                    _memory.WriteVector(_engine + _offsets!.Engine!.viewangles_y, smoothedAngles);
                }
            }
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            return new Vector3(
                a.X + (b.X - a.X) * t,
                a.Y + (b.Y - a.Y) * t,
                a.Z + (b.Z - a.Z) * t
            );
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
                            _memory.Write<int>(_client + _offsets!.Player!.dwForceAttack, 5);

                            Thread.Sleep(1);

                            _memory.Write<int>(_client + _offsets!.Player!.dwForceAttack, 4);
                        }
                    }
                }
            }
        }

        private void AimLock()
        {
            if (aimlockEnabled)
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
                                case "Neck": enemy.Position += new Vector3(0, 0, -3); break;
                                case "Body": enemy.Position += new Vector3(0, 0, -15); break;
                                case "Legs": enemy.Position += new Vector3(0, 0, -30); break;
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
        }

        private void MatFullBright()
        {
            if (fullbrightEnabled)
            {
                _memory.Write(_materialsystem + _offsets!.Material!.mat_fullbright, 1);
            }
            else if (!whiteTextureEnabled)
            {
                _memory.Write(_materialsystem + _offsets!.Material!.mat_fullbright, 0);
            }
        }

        private void WhiteTexture()
        {
            if (whiteTextureEnabled)
            {
                _memory.Write(_materialsystem + _offsets!.Material!.mat_fullbright, 2);
            }
            else if (!fullbrightEnabled)
            {
                _memory.Write(_materialsystem + _offsets!.Material!.mat_fullbright, 0);
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
            _memory.Write(_materialsystem + _offsets!.Material!.mat_showlowresimage, lowresolutionEnabled ? 1 : 0);
        }

        public string GetInformation()
        {
            if (getInformationEnabled)
            {
                int armor = _memory.Read<int>(_localPlayer.Address + _offsets!.Player!.m_iArmor);

                string weapon = _memory.ReadString(_client + _offsets!.Client!.weaponName, 15);

                string team = Teams.TryGetValue(_localPlayer.Team, out var teamName) ? teamName : "Unknown Team";
                string flag = Flags.TryGetValue(_localPlayer.Flags, out var flagName) ? flagName : "Unknown State";

                return $"Team: {team}\nStatus: {flag}\nHealth {_localPlayer.Health}\nArmor: {armor}\nMoney: {_localPlayer.Money}\nWeapon: {weapon}";
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
                _memory.Nop(_client + _offsets!.Client!.thirdpersonVoidAddress, _offsets!.Client!.thirdpersonAddressBytes.Length);
                _memory.Write(_client + _offsets!.Client!.thirdperson, 256);

                _memory.Write(_localPlayer.Address + _offsets!.Player!.m_iObserverMode, 1);

                byte[] virtualKeys = { VK_1, VK_2, VK_3, VK_4, VK_5, VK_6 };

                for (int i = 0; i < virtualKeys.Length; i++)
                {
                    if ((GetAsyncKeyState((Keys)(Keys.D1 + i)) & 0x8000) != 0)
                    {
                        _memory.Write(_localPlayer.Address + _offsets!.Player!.m_iObserverMode, 0);

                        Thread.Sleep(1);

                        keybd_event(virtualKeys[i], 0, 0, UIntPtr.Zero);
                        Thread.Sleep(10);
                        keybd_event(virtualKeys[i], 0, KEYEVENTF_KEYUP, UIntPtr.Zero);

                        _memory.Write(_localPlayer.Address + _offsets!.Player!.m_iObserverMode, 1);
                        break;
                    }
                }
            }
            else
            {
                _memory.Write(_client + _offsets!.Client!.thirdperson, 0);
                _memory.WriteBytes(_client + _offsets!.Client!.thirdpersonVoidAddress, _offsets!.Client!.thirdpersonAddressBytes);
                _memory.Write(_localPlayer.Address + _offsets!.Player!.m_iObserverMode, 0);
            }
        }

    }
}