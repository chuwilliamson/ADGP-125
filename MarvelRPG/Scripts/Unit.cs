using System;
using System.Collections.Generic;

namespace MarvelRPG
{
    [Serializable()]
    class Unit : IAttributes
    {        
        private int 
            _durability,
            _strength, 
            _fighting, 
            _speed, 
            _energy, 
            _intelligence;

        public int Durability
        {
            get
            {
                return _durability;
            }

            set
            {
                _durability = value;
            }
        }

        public int Energy
        {
            get
            {
                return _energy;
            }

            set
            {
                _energy = value;
            }
        }

        public int Fighting
        {
            get
            {
                return _fighting;
            }

            set
            {
                _fighting = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return _intelligence;
            }

            set
            {
                _intelligence = value;
            }
        }

        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }

        public int Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                _strength = value;
            }
        }
    }
}