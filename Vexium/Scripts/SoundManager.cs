using System.IO;
using NAudio.Wave;

namespace Vexium.Scripts
{
    class SoundManager
    {
        public static void PlaySound(string audioFilePath)
        {
            if (!File.Exists(audioFilePath))
            {
                return;
            }

            using (var audioFile = new AudioFileReader(audioFilePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(1);
                }
            }
        }
    }
}
