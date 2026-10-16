using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(new Light("Garage"));
            Stereo stereo = new Stereo();
            // Define and instantiate an Off and On command for each Vendor class

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */

            Command livingRoomLightOn = new LightOnCommand(livingRoomLight);
            Command livingRoomLightOff = new LightOffCommand(livingRoomLight);
            Command kitchenLightOn = new LightOnCommand(kitchenLight);
            Command kitchenLightOff = new LightOffCommand(kitchenLight);
            Command ceilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);
            Command ceilingFanLow = new CeilingFanLowCommand(livingRoomCeilingFan);
            Command ceilingFanMedium = new CeilingFanMediumCommand(livingRoomCeilingFan);
            Command ceilingFanHigh = new CeilingFanHighCommand(livingRoomCeilingFan);
            Command garageDoorOpen = new GarageDoorUpCommand(garageDoor);
            Command garageDoorClose = new GarageDoorDownCommand(garageDoor);
            Command stereoOnWithDvdCommand = new StereoOnWithDvdCommand(stereo);
            Command StereoOff = new StereoOffCommand(stereo);


            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, garageDoorOpen, garageDoorClose);
            remoteControl.SetCommand(4, stereoOnWithDvdCommand, StereoOff);

            Console.WriteLine(remoteControl);
            // Test the pressing of Buttons here. Don't forget to test the Undo button

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanLow, ceilingFanOff);
            remoteControl.SetCommand(3, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(4, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(5, garageDoorOpen, garageDoorClose);
            remoteControl.SetCommand(6, stereoOnWithDvdCommand, StereoOff);

            // \n word gebruikt om een nieuwe regel te beginnen in de terminal (^_^) :) :D ^^ :> (;-;) :P O_O 
            Console.WriteLine("\n--- Volgende acties ---");
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);

            Console.WriteLine("\n--- Volgende actie is een undo ---");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n--- Volgende acties ---");
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

            Console.WriteLine("\n--- Volgende actie is een undo ---");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n--- Volgende acties ---");
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);

            Console.WriteLine("\n--- Volgende acties zijn undo's ---");
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n--- Volgende acties ---");
            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);

            Console.WriteLine("\n--- Volgende actie is een undo ---");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n--- Volgende acties ---");
            remoteControl.OnButtonWasPushed(6);
            remoteControl.OffButtonWasPushed(6);

            Console.WriteLine("\n--- Volgende actie is een undo ---");
            remoteControl.UndoButtonWasPushed();



        }
    }
}