using System;
using System.Collections.Generic;


public interface IDamager
{
    /// <summary>
    /// OUTGOING DAMAGE
    /// </summary>
    /// <returns>return how much damage was SENT</returns>
    float Damage { get; }
}
public interface IDamageable //do damage and take damage
{
    /// <summary>
    /// INCOMING DAMAGE
    /// </summary>
    /// Perform damage on an object, it is the implementing class's responsibility to perform the
    /// damage mitigation
    void TakeDamage(int amount);
}

public interface IAttribute
{
    int Durability { get; set; }
    int Strength { get; set; }
    int Fighting_Skills { get; set; }
    int Speed { get; set; }
    int EnergyProjection { get; set; }
    int Intelligence { get; set; }
}

public interface IAbility
{
    int cost { get; set; }
    int power { get; set; }
    void Execute();
}
//when to make decisions?
//
