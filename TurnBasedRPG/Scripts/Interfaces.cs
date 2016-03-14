using System.Collections.Generic;

public interface IAbility
{
    string name { get; set; }
}
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