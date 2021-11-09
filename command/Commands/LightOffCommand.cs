using command.Devices;

namespace command.Commands
{
    public class LightOffCommand : ICommand
    {
        public Light Light { get; set; }

        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }

        public void Undo()
        {
            Light.On();
        }
    }
}