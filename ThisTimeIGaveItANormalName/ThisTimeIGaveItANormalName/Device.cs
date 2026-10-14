using System;
using System.Collections.Generic;
using System.Text;

namespace ThisTimeIGaveItANormalName
{
    /// <summary>
    /// Base.
    /// </summary>
    public abstract class Device
    {
        /// <summary>
        /// hwat
        /// </summary>
        private readonly string _serial;

        /// <summary>name.</summary>
        public string Model { get; set; }

        /// <summary>consume. grow grow grow! ROT ROT ROT.</summary>
        public double Power { get; set; }

        /// <summary>powersource.</summary>
        public PowerSource Source { get; set; } = PowerSource.Mains;

        /// <summary>consumption now in watts.</summary>
        public double PowerInWatts => Power * 1000;

        /// <summary>
        /// behold! A device! Created! Oh god, how could it be? Now i need my five ducking month vacation for god's sake pls take me out of here i am making a game and i am procrastinating constantly how to solve my problems with work's ethics i need more sleep goddamit okay but did you know that uhhhhhhhhhh fun facts about ducks, ducks don't deserve fun facts they are terrible creatures, especially male ones.
        /// </summary>
        public Device(string serial, string model, double power)
        {
            _serial = serial;
            Model = model;
            Power = power;
        }

        /// <summary>
        /// defaultism
        /// </summary>
        public Device(string model) : this("N/A", model, 0)
        {
        }

        /// <summary>
        /// Bz-bz
        /// </summary>
        public abstract void TurnOn();
    }
}
