
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MarvelRPG
{
    [Serializable]
    [XmlRoot("Party")]
    public class Party
    {
        public Party() { _units = new List<Unit>();       }

        private List<Unit> _units;

        [XmlArray("Team"), XmlArrayItem(typeof(Unit), ElementName = "Unit")]
        public List<Unit> units
        {
            get
            {
                return _units;
            }
            set
            {
                _units = value;
            }
        }
    }
}
