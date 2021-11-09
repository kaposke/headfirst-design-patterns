using command.Devices;

namespace command.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        public GarageDoor Door { get; set; }

        public GarageDoorOpenCommand(GarageDoor door)
        {
            Door = door;
        }

        public void Execute()
        {
            Door.Up();
        }

        public void Undo()
        {
            Door.Down();
        }
    }
}