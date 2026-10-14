using System;

/// <summary>
/// Represents a Desktop device that can be charged.
/// </summary>
public class Desktop : Device, IChargeable
{
    /// <summary>Capacity.</summary>
    public int Towersize { get; set; }

    /// <summary>longlasting.</summary>
    public bool IsGaming { get { return Towersize >= 100; } }


    /// <summary>
    /// desktop but actually kinda cool maybe chill may-okay
    /// </summary>
    public Desktop(string serial, string model, double power, int towersize): base(serial, model, power)
    {
        Towersize = towersize;
    }

    /// <summary>
    /// desktop,,,,even!? L_L
    /// </summary>
    public Desktop(string model, int towersize): this("N/A", model, 0, towersize)
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