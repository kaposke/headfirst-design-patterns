using command.Devices;

namespace command.Commands
{
    public class LightOnCommand : ICommand
    {
        public Light Light { get; set; }

        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}