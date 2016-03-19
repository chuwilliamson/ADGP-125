using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MarvelRPG
{


    [Serializable]    
    public class Unit : IAttributes
    {
        private Unit() { }
        public Unit(int d, int s, int f, int spd, int e, int i)
        {
            name = "default";
            durability = d;
            strength = s;
            fighting = f;
            speed = spd;
            energy = e;
            intelligence = i;
        }
        private string name;
        private int durability;
        private int strength;
        private int fighting;
        private int speed;
        private int energy;
        private int intelligence;
        public string Name { get { return name; } set { name = value; } }
        public int Durability { get { return durability; } set { durability = value; } }
        public int Energy { get { return energy; } set { energy = value; } }
        public int Fighting { get { return fighting; } set { fighting = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int Strength { get { return strength; } set { strength = value; } }
    }
}