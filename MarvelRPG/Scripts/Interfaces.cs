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
    int Strength { get; set; }
    int Agility { get; set; }
    int Intelligence { get; set; }
}

//when to make decisions?
//
