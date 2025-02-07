using Vexium.UserControls;

namespace Vexium.Scripts
{
    class States
    {
        public static Combat_UC? combatUC;
        public static Misc_UC? miscUC;
        public static Visual_UC? visualUC;

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
        public static bool knifebotEnabled;
        public static bool thirdpersonEnabled;
        public static bool aimlockEnabled;
        public static bool showPosEnabled;
        public static bool wireframeEnabled;

        public async static void DisableAll(bool exit)
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
            knifebotEnabled = false;
            thirdpersonEnabled = false;
            aimlockEnabled = false;
            showPosEnabled = false;
            wireframeEnabled = false;

            combatUC.DisableAll();
            miscUC.DisableAll();
            visualUC.DisableAll();

            if (exit)
            {
                await Task.Delay(10);
                Environment.Exit(0);
            }
        }

    }
}
