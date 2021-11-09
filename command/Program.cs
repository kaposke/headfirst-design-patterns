using System;
using command.Commands;
using command.Devices;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControll remote = new();
            Light livingRoomLight = new("Living Room");
            Light kitchenLight = new("Kitchen");
            GarageDoor garageDoor = new();
            Stereo stereo = new();

            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);
            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            var garageDoorClose = new GarageDoorCloseCommand(garageDoor);
            var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            var partyOn = new ICommand[] { livingRoomLightOn, kitchenLightOn, stereoOnWithCD };
            var partyOff = new ICommand[] { livingRoomLightOff, kitchenLightOff, stereoOff };
            
            var partyOnMacro = new MacroCommand(partyOn);
            var partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, garageDoorOpen, garageDoorClose);
            remote.SetCommand(3, stereoOnWithCD, stereoOff);
            remote.SetCommand(4, partyOnMacro, partyOffMacro);

            Console.WriteLine(remote);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            remote.OnButtonWasPushed(3);
            remote.OnButtonWasPushed(4);

            Console.WriteLine(remote);

            remote.UndoButtonWasPushed();
            

            // SimpleRemoteControll remote = new();
            // Light light = new();
            // LightOnCommand lightOn = new(light);

            // GarageDoor garageDoor = new();
            // GarageDoorOpenCommand garageUp = new(garageDoor);

            // remote.Command = lightOn;
            // remote.ButtonWasPressed();

            // remote.Command = garageUp;
            // remote.ButtonWasPressed();
        }
    }
}
