using System;


namespace Abilities
{
    public class Slam : IDamager, IAbility
    {
        private Slam() { }
        static Slam() { }
        private static Slam _instance = new Slam();
        public static Slam instance { get { return _instance; } }
              
        public int power { get; set; }
        public int cost { get; set; }

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
                return roll * power;
            }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class Slash : IDamager, IAbility
    {
        private Slash() { }
        static Slash() { }
        private static Slash _instance = new Slash();
        public static Slash instance { get { return _instance; } }
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
                return roll * power;
            }
        }
        public int cost
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public int power
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
