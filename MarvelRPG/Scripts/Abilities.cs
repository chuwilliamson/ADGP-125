using System;


namespace Abilities
{
    public class Slam : Singleton<Slam>, IDamager
    {
        public Slam() { }

        private int _power = 5;
        private int _cost = 3;

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

    public class Slash : Singleton<Slash>, IDamager
    {
        public Slash() { }

        private int _power = 5;
        private int _cost = 3;

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
}
