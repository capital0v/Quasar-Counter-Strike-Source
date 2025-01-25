using Capitalov;
using System.Diagnostics;
using static Quasar.Offsets;

namespace Quasar
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string securityStatus = File.ReadAllText("security.txt").Trim();

            if (securityStatus == "enabled")
            {
                string[] settingsLines = File.ReadAllLines("box_settings.txt");
                string messageBoxTitle = settingsLines.Length > 0 ? settingsLines[0] : "Quasar";
                string messageBoxText = settingsLines.Length > 1 ? settingsLines[1] : "There's been an unforeseen error.";

                Process[] processes = Process.GetProcessesByName("hl2");

                if (processes.Length > 0)
                {
                    MemoryRaider memory = new MemoryRaider();
                    memory.Inject("hl2");

                    bool valueIsCorrect = false;

                    while (!valueIsCorrect)
                    {
                        nint client = memory.GetModuleBase("client.dll");
                        IntPtr localPlayer = memory.ReadPointer(client + dwLocalPlayer);
                        float y = memory.Read<float>(localPlayer + viewangles_y);
                        MessageBox.Show(y.ToString());
                        if (y == 89)
                        {
                            valueIsCorrect = true;
                            Application.Run(new Login());
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show(messageBoxText, messageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.No)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show(messageBoxText, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}
