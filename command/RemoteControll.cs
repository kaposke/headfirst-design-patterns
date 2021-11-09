using System.Text;
using command.Commands;

namespace command
{
    public class RemoteControll
    {
        ICommand[] onCommands;
        ICommand[] offCommands;

        ICommand undoCommand;

        public RemoteControll()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            if (slot < 0 || slot >= onCommands.Length) return;
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            if (slot < 0 || slot >= onCommands.Length) return;
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            if (slot < 0 || slot >= onCommands.Length) return;
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder builder = new();
            builder.Append("\n--- Remote Controll ---\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                builder.Append($"[slot {i}] {onCommands[i].GetType().Name}      {offCommands[i].GetType().Name}\n");
            }
            builder.Append($"[Undo] {undoCommand.GetType().Name}\n");
            return builder.ToString();
        }
    }
}