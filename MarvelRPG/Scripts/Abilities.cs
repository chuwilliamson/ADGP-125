using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MarvelRPG
{

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
            if (_members == null)
                _members = new List<Ability>();
            _members.Add(a);
        }

        public Ability this[int key]
        {
            get { return _members[key]; }
        }


    }



    [Serializable]
    public class Ability
    {

        private Ability getAbilities(string id)
        {
            //*[@id="content"]/div[2]/div/h3/span/a[1]
            //title : //*[@id="content"]/div[2]/div/h3
            //name : //*[@id="tooltip"]/span[1]
            //info : //*[@id="tooltip"]/span[3]
            string character, name, description, xpath;
            HtmlNodeCollection info;
            string marvelData = "http://marvelheroes.info/power/";

            var webGet = new HtmlWeb();


            var document = webGet.Load(marvelData + id);
            if (document != null)
            {

                //name of character            
                xpath = "//*[@id=\"content\"]/div[2]/div/h3/span/a[2]";
                info = document.DocumentNode.SelectNodes(xpath);
                if (info != null)
                {
                    character = info[0].InnerText;

                    //name of ability
                    xpath = "//*[@id=\"tooltip\"]/span[1]";
                    info = document.DocumentNode.SelectNodes(xpath);
                    name = info[0].InnerText;

                    //description            
                    xpath = "//*[@id=\"tooltip\"]/span[4]";
                    info = document.DocumentNode.SelectNodes(xpath);
                    description = info[0].InnerText;


                    Ability ability = new Ability(character, name, description);


                    return ability;
                }

            }
            return null;

        }
        private Ability() { }
        public Ability(string id)
        {
            Ability a = new Ability();
            a = getAbilities(id);
            this.name = a.Name;
            this.character = a.Character;
            this.description = a.Description;

        }

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
