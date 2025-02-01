namespace Quasar.Scripts
{
    class States
    {
        public static bool bunnyhopEnabled;
        public static bool wallhackEnabled;
        public static bool showimpactEnabled;
        public static bool antiflashEnabled;
        public static bool triggerbotEnabled;
        public static bool fullbrightEnabled;
        public static bool whiteTextureEnabled;
        public static bool nosmokeEnabled;
        public static bool hitboxesEnabled;
        public static bool tracersEnabled;
        public static bool shadowFrameEnabled;
        public static bool lowresolutionEnabled;
        public static bool getInformationEnabled;
        public static bool aimbotEnabled;

        public static void DisableAll()
        {
            bunnyhopEnabled = false;
            wallhackEnabled = false;
            showimpactEnabled = false;
            antiflashEnabled = false;
            triggerbotEnabled = false;
            fullbrightEnabled = false;
            whiteTextureEnabled = false;
            nosmokeEnabled = false;
            hitboxesEnabled = false;
            tracersEnabled = false;
            shadowFrameEnabled = false;
            lowresolutionEnabled = false;
            getInformationEnabled = false;
            aimbotEnabled = false;
        }
    }
}
