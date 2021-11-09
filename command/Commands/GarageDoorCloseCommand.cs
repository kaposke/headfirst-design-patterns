using command.Devices;

namespace command.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        public GarageDoor Door { get; set; }

        public GarageDoorCloseCommand(GarageDoor door)
        {
            Door = door;
        }

        public void Execute()
        {
            Door.Down();
        }

        public void Undo()
        {
            Door.Up();
        }
    }
}