
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MarvelRPG
{
    enum Characters
    {
        Psylocke, Hulk, Rogue, Thor, Wolverine
    }

    [Serializable]
    [XmlRoot("Party")]
    public class Party
    {

        public Party() { _units = new List<Unit>(); }

        private List<Unit> _units;

        [XmlArray("Team"), XmlArrayItem(typeof(Unit), ElementName = "Unit")]
        public List<Unit> units
        {
            get { return _units; }
            set { _units = value; }
        }
    }

    [Serializable]
    [XmlRoot("Abilities")]
    public class Abilities
    {
        public Abilities() { _members = new List<Ability>(); }
        public Abilities(Ability a)
        {
            _members = new List<Ability>();
            this.Add(a);
        }
        List<Ability> _members;

        [XmlArray("Powers"), XmlArrayItem(typeof(Ability), ElementName = "Ability")]
        public List<Ability> Members
        {
            get { return _members; }
            set { _members = value; }
        }

        public void Add(Ability a)
        {
            _members.Add(a);
        }


    }

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

        public Unit(int d, int s, int f, int spd, int e, int i, string n)
        {
            durability = d;
            strength = s;
            fighting = f;
            speed = spd;
            energy = e;
            intelligence = i;
            name = n;

        }

        public Unit(int d, int s, int f, int spd, int e, int i, string n, string b)
        {

            durability = d;
            strength = s;
            fighting = f;
            speed = spd;
            energy = e;
            intelligence = i;
            name = n;
            bio = b;
        }

        private string bio;
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


    [Serializable]
    public class Ability
    {
        private Ability() { }

        public Ability(string character, string name, string description)
        {
            Character = character;
            Name = name;
            Description = description;
        }
        string character, name, description;
        public string Character
        {
            get { return character; }
            set { character = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
