using System;

namespace command.Devices
{
    public class Light
    {
        public bool IsOn { get; set; }
        public string Name { get; set; }

        public Light(string name)
        {
            Name = name;
        }

        public void On()
        {
            Console.WriteLine($"Turning {Name} light on");
            IsOn = true;
        }

        public void Off()
        {
            Console.WriteLine($"Turning {Name} light off");
            IsOn = false;
        }
    }
}