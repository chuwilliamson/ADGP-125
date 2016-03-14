using System;
 


public class Ability : IDamager
{
    /// <summary>
    /// Create an ability with power and cost
    /// </summary>
    /// <param name="p">power</param>
    /// <param name="c">cost</param>
    public Ability(int power, int cost) { _power = power; _cost = cost; }
    private int _power;
    private int _cost;

    public float Damage
    {
        get
        {
            //do a random roll
            //explain why just using a random roll is bad
            //introduce statistical distribution and how it can be used
            //to keep the graph in a general area
            Random random = new Random();
            int roll = random.Next(1, 21);
            return roll * _power;
        }
    }
}
