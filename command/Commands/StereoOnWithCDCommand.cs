using command.Devices;

namespace command.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        public Stereo Stereo { get; set; }

        private StereoMode _previousMode;
        private int _previousVolume;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            _previousMode = Stereo.Mode;
            _previousVolume = Stereo.Volume;

            Stereo.On();
            Stereo.SetCD();
            Stereo.SetVolume(11);
        }

        public void Undo()
        {
            Stereo.Off();
            if (_previousMode == StereoMode.CD)
                Stereo.SetCD();
            else if (_previousMode == StereoMode.DVD)
                Stereo.SetDVD();
            else if (_previousMode == StereoMode.RADIO)
                Stereo.SetRadio();
            Stereo.SetVolume(_previousVolume);
        }
    }
}