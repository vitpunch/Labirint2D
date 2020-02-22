using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Labirint2D
{
    public static class Sound
    {
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.sound_fail);
        static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.sound_key);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.sound_start);
        static SoundPlayer sound_yuowin = new SoundPlayer(Properties.Resources.sound_youwin);
        static bool sound_enabled = true;

        public static void soundOn()
        {
            sound_enabled = true;
        }
        public static void soundOff()
        {
            sound_enabled = false;
        }
        public static void playFail()
        {
            if(sound_enabled)
                sound_fail.Play();
        }
        public static void playKey()
        {
            if (sound_enabled)
                sound_key.Play();
        }
        public static void playStart()
        {
            if (sound_enabled)
                sound_start.Play();
        }
        public static void playYouwin()
        {
            if (sound_enabled)
                sound_yuowin.Play();
        }
    }

    
}
