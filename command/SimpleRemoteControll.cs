using command.Commands;

namespace command
{
    public class SimpleRemoteControll
    {
        public ICommand Command { get; set; }
        
        public SimpleRemoteControll()
        {
            
        }

        public void ButtonWasPressed()
        {
            Command.Execute();
        }
    }
}