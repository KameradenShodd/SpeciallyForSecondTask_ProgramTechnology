using System;
using System.Collections.Generic;

namespace ThisTimeIGaveItANormalName
{
    class Program
    {

        static void Main()
        {

            List<Device> devices = new List<Device>
        {
            new Laptop("SUPER-SERIOUS-SERIE-007", "ThinkPad", 55, 60000),
            new Desktop("SUPER-SERIOUS-SERIE-009", "Gaming PC", 500, "SO TOWER YOU COULD PLAY TOWER DEFENSE WITH IT"),
            new Phone("SUPER-SERIOUS-SERIE-010", "iPhone", 555, 3000000),
        };

            foreach (Device device_device in devices)
            {
                Console.WriteLine(device_device);
                Console.WriteLine($"  watts: {device_device.PowerInWatts}");
                device_device.TurnOn();

                if (device_device is IChargeable chargeable) //im very stupid for not realizing realization for some realization time
                {
                    chargeable.Charge();
                }

                else
                {
                    Console.WriteLine($"{device_device.Model} cannot be charged.");
                }

                Console.WriteLine("------"); //i grew tired of this
            }
        }
    }

}