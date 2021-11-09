using System;

namespace command.Devices
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Opening garage door");
        }

        public void Down()
        {
            Console.WriteLine("Closing garage door");
        }

        public void LightOn()
        {
            Console.WriteLine("Turning on garage door light");
        }

        public void LightOff()
        {
            Console.WriteLine("Turning off garage door light");
        }
    }
}