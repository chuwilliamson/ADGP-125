
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using HtmlAgilityPack;

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
        public Party()
        {
            _units = new List<Unit>();
        }

        [XmlArray("Team"), XmlArrayItem(typeof(Unit), ElementName = "Unit")]
        public List<Unit> units
        {
            get { return _units; }
            set { _units = value; }
        }

        public bool Add(Unit u)
        {
            if (u != null)
            {
                _units.Add(u);
                return true;
            }
            return false;
        }

        public int Count { get { return _units.Count; } }
        private List<Unit> _units;

        public Unit this[int key]
        {
            get { return _units[key]; }
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
        private Abilities abilities;
        public Abilities Abilities { get { return abilities; } set { abilities = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Durability { get { return durability; } set { durability = value; } }
        public int Energy { get { return energy; } set { energy = value; } }
        public int Fighting { get { return fighting; } set { fighting = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int Strength { get { return strength; } set { strength = value; } }

    

    }

}
