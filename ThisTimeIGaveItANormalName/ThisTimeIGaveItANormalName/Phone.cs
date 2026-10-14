using System;

/// <summary>
/// Represents a phone device that can be charged.
/// </summary>
public class Phone : Device, IChargeable
{
	/// <summary>Capacity.</summary>
	public int ScreenSize { get; set; }

	/// <summary>longlasting.</summary>
	public bool IsPhablet { get { return ScreenSize >= 100; } }

	/// <summary>
	/// phone but actually kinda cool maybe chill may-okay
	/// </summary>
	public Phone(string serial, string model, double power, int screenSize)
		: base(serial, model, power)
	{
		ScreenSize = screenSize;
	}

	/// <summary>
	/// phone,,,,even!? L_L
	/// </summary>
	public Phone(string model, int screenSize)
		: this("N/A", model, 0, screenSize)
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
		return $"[Phone] {Model}, {Power}W, source: {Source}";
	}

}