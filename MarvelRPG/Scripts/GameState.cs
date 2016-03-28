using System;
using System.IO;

using System.Collections.Generic;


namespace MarvelRPG
{
    [Serializable]
    public class GameState
    {
        static private GameState _instance;
        static public GameState instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameState();
                return _instance;
            }
        }

        private Party _party;
        private Dictionary<string, Unit> _characterLibrary;
        private Dictionary<string, Abilities> _abilityLibrary;
        private Abilities _abilities;

        public Party Party
        {
            get { return _party; }
             
        }
        public Dictionary<string, Unit> CharacterLibrary
        {
            get { return _characterLibrary; }
             
        }
        public Dictionary<string, Abilities> AbilityLibrary
        {
            get { return _abilityLibrary; }
            
        }
        public Abilities Abilities
        {
            get { return _abilities; }
            

        }

        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string apath = path + @"\My Games\" + System.Windows.Forms.Application.ProductName + @"\Abilities\";
        private static string upath = path + @"\My Games\" + System.Windows.Forms.Application.ProductName + @"\Units\";

        GameState()
        {
            _party = new Party();
            _characterLibrary = new Dictionary<string, Unit>();
            _abilityLibrary = new Dictionary<string, Abilities>();
            _abilities = new Abilities();
            GenerateClasses();
            GenerateAbilities();
             
        }

        private bool GenerateAbilities()
        { 
 
            if (!Directory.Exists(apath))
                Directory.CreateDirectory(apath);

           _abilities = Utilities.DeserializeXML<Abilities>(apath + "Abilities");

            if (_abilities != null)
            {
                foreach (Ability ability in _abilities.Members)
                {
                    if (AbilityLibrary.ContainsKey(ability.Character))
                        AbilityLibrary[ability.Character].Add(ability);
                    else
                        AbilityLibrary.Add(ability.Character, new Abilities(ability));
                }

                return true;
            }

            int MAXPOWERS = 1330;
            for (int i = 1; i <= MAXPOWERS; ++i)
            {
                //not sure if this works because i'm in the car with no internet
                //check this later b/c it looks alot cleaner to put the web request in the constructor
                Ability ability = new Ability(i.ToString());
                if (ability != null)
                {
                    Abilities.Members.Add(ability);

                    //Func<int> f = delegate () { AbilityLibrary[ability.Character].Add(ability); };


                    //bool present = (AbilityLibrary.ContainsKey(ability.Character) ? () => { AbilityLibrary[ability.Character].Add(ability); } : 
                    if (AbilityLibrary.ContainsKey(ability.Character))
                    {
                        AbilityLibrary[ability.Character].Add(ability);
                    }
                    else
                    {
                        AbilityLibrary.Add(ability.Character, new Abilities(ability));
                    }
                }
            }

            Utilities.SerializeXML("Abilities", _abilities, apath);

            return true;
        }

        private bool GenerateClasses()
        {

            var v = Enum.GetValues(typeof(Characters));
            //generate the classes based on information on application startup
            //1330is number of abilities
            if (!Directory.Exists(upath))
                Directory.CreateDirectory(upath);

            foreach (var s in v)
            {
                string name = s.ToString();
                string unitFile = path + name + ".xml";

                Unit u = (File.Exists(unitFile)) ? Utilities.DeserializeXML<Unit>(unitFile) : Utilities.FetchUnit(name);
                Utilities.SerializeXML(name, u, upath);
                _characterLibrary.Add(name, u);
                
            }

            return true;
        }

    }
}
