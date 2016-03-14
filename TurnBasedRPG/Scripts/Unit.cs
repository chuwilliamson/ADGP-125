
using System;
using System.Collections.Generic;

public interface IDamager
{
    /// <summary>
    /// OUTGOING DAMAGE
    /// </summary>
    /// <returns>return how much damage was SENT</returns>
    float Damage();
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

public abstract class Unit //can not use new on an abstract class, we only use it to better define it's subclasses
{
    protected int health;
    protected int defense;
    protected int attack;
    protected int level;
    protected int experience;
    //ratings for hp ap and att
    public Unit(){}
    
} 

class Ninja : Unit, IDamageable
{
    public Ninja(int h,int d,int a, int e) 
    {
        this.health = h;
        this.defense = d;
        this.attack = a;
        this.experience = 0;
    }
    private List<Ability> _abilities;
    private void AddAbility(Ability a)
    {
        _abilities.Add(a);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }
}

class Ability : IDamager
{
    public Ability(int p, int c) { power = p; cost = c; }
    int power;
    int cost;

    public float Damage()
    {
        //do a random roll
        //explain why just using a random roll is bad
        //introduce statistical distribution and how it can be used
        //to keep the graph in a general area
        Random random = new Random();
        int roll = random.Next(0, 21);
        return roll * power;
    }
}


class Utilities
{
    void Test()
    {

    }
}
