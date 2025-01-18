namespace Quasar
{
    class States
    {
        public static bool bunnyhopEnabled;
        public static bool wallhackEnabled;
        public static bool wireframeEnabled;
        public static bool showimpactEnabled;
        public static bool antiflashEnabled;
        public static bool triggerbotEnabled;
        public static bool fullbrightEnabled;
        public static bool whiteTextureEnabled;
        public static void DisableAll()
        {
            bunnyhopEnabled = false;
            wallhackEnabled = false;
            wireframeEnabled = false;
            showimpactEnabled = false;
            antiflashEnabled = false;
            triggerbotEnabled = false;
            fullbrightEnabled = false;
            whiteTextureEnabled = false;
        }
    }
}
