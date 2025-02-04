using System.Collections.Generic;

namespace Quasar.Scripts
{
    class Offsets
    {
        //client.dll
        public static int sv_cheats = 0x616A70;
        public static int sv_showimpact = 0x588598;
        public static int weaponName = 0x4D4E63;
        public static int thirdperson = 0x5065AC;

        public static int r_drawothermodels = 0x4C4BA0;
        public static int r_drawparticles = 0x4F7A40;
        public static int r_drawrenderhitboxes = 0x4C5FA0;
        public static int r_visualizetracers = 0x5AA410;
        public static int r_shadowwireframe = 0x5D1768;

        public static int cl_bob = 0x50C868;

        //engine.dll
        public static int mat_WireFrame = 0x5ADD60;
        public static int mat_fullbright = 0x121EF8;
        public static int mat_showlowresimage = 0x121EB0;

        public class ClientOffsets
        {
            public int sv_showimpact;
            public int weaponName;
            public int thirdperson;
            public int thirdpersonAddress;
            public byte[] thirdpersonAddressBytes;
            public int r_drawothermodels;
            public int r_drawparticles;
            public int r_drawrenderhitboxes;
            public int cl_bob;
            public int dwEntityList;
        }

        public class EngineOffsets
        {
            public int sv_cheats;
            public int mat_WireFrame;
            public int mat_fullbright;
            public int mat_showlowresimage;
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
        }

        public class SteamOffsets
        {
            public int nickname;
            public int clantag;
        }
    }
}

