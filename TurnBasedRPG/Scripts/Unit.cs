using System;
using System.Collections.Generic;


public abstract class Unit //can not use new on an abstract class, we only use it to better define it's subclasses
{

    protected int health;
    protected int defense;
    protected int attack;
    protected int level;
    protected int experience;
    //ratings for hp ap and att
    public Unit() { }

}
class Warrior : Unit, IDamageable, IAbilities
{
    public List<Ability> abilities
    {
        get { throw new NotImplementedException(); }
        set { throw new NotImplementedException(); }
    }

    public void TakeDamage(int amount) { }

    public void AddAbility(Ability a)
    {
        throw new NotImplementedException();
    }

    public Warrior() { }
}


class Ninja : Unit, IDamageable, IAbilities
{

    public Ninja()
    {
        health = 0;
        defense = 0;
        attack = 0;
        experience = 0;

    }

    public List<Ability> abilities
    {
        get { throw new NotImplementedException(); }
        set { throw new NotImplementedException(); }
    }

    public void AddAbility(Ability a)
    {
        throw new NotImplementedException();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }
}




class Utilities
{
    enum CombatStates
    {
        INIT, START, TURN, TARGET, RESOLVE, END,
    }
    void Test()
    {
       
        ///setup abilities
        Ability slash = new Ability(5, 3);
        Ability slam = new Ability(3, 3);               
        
        ///setup parties
        List<Unit> goodGuys = new List<Unit>();
        List<Unit> badGuys = new List<Unit>();
        
        ///setup units
        Unit Dylan = new Warrior();
        Unit Zak = new Ninja();
        Unit Rory = new Warrior();
        Unit Donte = new Ninja();

        
        ///setup parties
        goodGuys.Add(Dylan);
        goodGuys.Add(Zak);
        badGuys.Add(Rory);
        badGuys.Add(Donte);
    }
}
