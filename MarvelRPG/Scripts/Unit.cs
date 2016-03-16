
public abstract class Unit 
{
    protected int health;
    protected int defense;
    protected int attack;
    protected int level;

    protected int experience;
    //ratings for hp ap and att
    public Unit() { }

}

class Warrior : Unit, IDamageable
{
    public Warrior() { }
    public void TakeDamage(int amount)
    {
        health -= amount;
    }
}


class Ninja : Unit, IDamageable 
{
    public Ninja(){}        
    
    public void TakeDamage(int amount)
    {
        health -= amount;
    }
}
