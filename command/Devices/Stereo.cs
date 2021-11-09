using System;

namespace command.Devices
{
    public enum StereoMode
    {
        CD,
        DVD,
        RADIO
    }
    public class Stereo
    {
        public StereoMode Mode { get; set; } = StereoMode.RADIO;
        public int Volume { get; set; }
        
        public void On()
        {
            Console.WriteLine("Turning stereo On");
        }

        public void Off()
        {
            Console.WriteLine("Turning stereo Off");
        }

        public void SetCD()
        {
            Mode = StereoMode.CD;
            Console.WriteLine("Setting stereo to CD");
        }

        public void SetDVD()
        {
            Mode = StereoMode.DVD;
            Console.WriteLine("Setting stereo to DVD");
        }

        public void SetRadio()
        {
            Mode = StereoMode.RADIO;
            Console.WriteLine("Setting stereo to Radio");
        }

        public void SetVolume(int volume)
        {
            Volume = volume;
            Console.WriteLine($"Setting stereo volume to {volume}");
        }
    }
}