
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using HtmlAgilityPack;

namespace MarvelRPG
{


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
    public class Unit : IAttributes, IBaseStats
    {
        private Unit() {  }

        
        public Unit(string n, int d, int s, int f, int spd, int e, int i)
        {
            durability = d;
            strength = s;
            fighting = f;
            speed = spd;
            energy = e;
            intelligence = i;
            name = n;
            b_health = 650;
            b_resource = 1000;
        }

        public Unit(string n, int d, int s, int f, int spd, int e, int i, int h, int r)
        {
            durability = d;
            strength = s;
            fighting = f;
            speed = spd;
            energy = e;
            intelligence = i;
            name = n;
            b_health = h;
            b_resource = r;
        }




        #region private
        private string bio;
        private string name;
        private int durability;
        private int strength;
        private int fighting;
        private int speed;
        private int energy;
        private int intelligence;
        private Abilities abilities;
        private int b_health;
        private int b_resource;



        #endregion private

        #region public
        public Abilities Abilities { get { return abilities; } set { abilities = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Durability { get { return durability; } set { durability = value; } }
        public int Energy { get { return energy; } set { energy = value; } }
        public int Fighting { get { return fighting; } set { fighting = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int Strength { get { return strength; } set { strength = value; } }
        #region Base Stats
        public int Health { get { return b_health; } set { b_health = value; } }
        public int Resource { get { return b_resource; } set { b_resource = value; } }
        #endregion Base Stats
        #endregion public
    }

}
