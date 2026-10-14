using System;
namespace ThisTimeIGaveItANormalName
{
    /// <summary>
    /// Represents a Desktop device that can be charged.
    /// </summary>
    public class Desktop : Device
    {
        /// <summary>Capacity.</summary>
        public string Towersize { get; set; }

        /// <summary>longlasting.</summary>
        public bool IsGaming { get { return Power >= 100; } }


        /// <summary>
        /// desktop but actually kinda cool maybe chill may-okay
        /// </summary>
        public Desktop(string serial, string model, double power, string towersize) : base(serial, model, power)
        {
            Towersize = towersize;
        }

        /// <summary>
        /// desktop,,,,even!? L_L
        /// </summary>
        public Desktop(string model, string towerSize) : this("N/A", model, 0, towerSize)
        {
        }

        /// <overriding interface/>
        public override void TurnOn()
        {
            Console.WriteLine($"{Model} turns on.");
        }

        /// <overriding interface/>
        public void Charge()
        {
            Console.WriteLine($"{Model} charging...");
        }
        /// <inheritdoc/>
        public override string ToString()
        {
            return $"[Desktop] {Model}, {Power}W, source: {Source}";
        }
    }
}