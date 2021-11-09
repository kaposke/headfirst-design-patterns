using command.Devices;

namespace command.Commands
{
    public class StereoOffCommand : ICommand
    {
        public Stereo Stereo { get; set; }

        public StereoOffCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.Off();
        }

        public void Undo()
        {
            Stereo.On();
        }
    }
}