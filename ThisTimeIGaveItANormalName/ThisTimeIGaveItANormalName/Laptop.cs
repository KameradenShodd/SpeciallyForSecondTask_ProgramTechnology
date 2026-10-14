using System;
namespace ThisTimeIGaveItANormalName
{
	/// <summary>
	/// Represents a laptop device that can be charged.
	/// </summary>
	public class Laptop : Device, IChargeable
	{
		/// <summary>Capacity.</summary>
		public int BatteryCapacity { get; set; }

		/// <summary>longlasting.</summary>
		public bool IsLongLasting { get { return BatteryCapacity >= 5000; } }

		/// <summary>
		/// laptop but actually kinda cool maybe chill may-okay
		/// </summary>
		public Laptop(string serial, string model, double power, int batteryCapacity) : base(serial, model, power)
		{
			BatteryCapacity = batteryCapacity;
		}

		/// <summary>
		/// laptop,,,,even!? L_L
		/// </summary>
		public Laptop(string model, int batteryCapacity) : this("N/A", model, 0, batteryCapacity)
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
			return $"[Laptop] {Model}, {Power}W, source: {Source}";
		}
	}
}