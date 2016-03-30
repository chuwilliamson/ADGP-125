using System;
using System.IO;

using System.Collections.Generic;


namespace MarvelRPG
{
    [Serializable]
    public class GameState
    {
        private GameState()
        {
            _party = new Party();
            _characterLibrary = new Dictionary<string, Unit>();
            _abilityLibrary = new Dictionary<string, Abilities>();
            _abilities = new Abilities();
            GenerateAbilities(apath + "Abilities");
            GenerateClasses();
        }


        /// <summary>
        /// generate the abilities for the characters
        /// either from web or from file
        /// </summary>
        /// <returns></returns>
        private bool GenerateAbilities(string file)
        { 
 
            if (!Directory.Exists(apath))
                Directory.CreateDirectory(apath);

           _abilities = Utilities.DeserializeXML<Abilities>(file);

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
                u.Abilities = AbilityLibrary[name];
                Utilities.SerializeXML(name, u, upath);
                _characterLibrary.Add(name, u);
                
            }

            return true;
        }

        #region private
        private Party _party;
        private Dictionary<string, Unit> _characterLibrary;
        private Dictionary<string, Abilities> _abilityLibrary;
        private Abilities _abilities;

        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string apath = path + @"\My Games\" + System.Windows.Forms.Application.ProductName + @"\Abilities\";
        private static string upath = path + @"\My Games\" + System.Windows.Forms.Application.ProductName + @"\Units\";
        #endregion

        #region public
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

        /// <summary>
        /// the combat party
        /// </summary>
        public Party Party
        {
            get { return _party; }

        }
        /// <summary>
        /// library of characters 
        /// </summary>
        public Dictionary<string, Unit> CharacterLibrary
        {
            get { return _characterLibrary; }

        }
        /// <summary>
        /// library of abilities
        /// </summary>
        public Dictionary<string, Abilities> AbilityLibrary
        {
            get { return _abilityLibrary; }

        }
        /// <summary>
        /// list of all abilities
        /// </summary>
        public Abilities Abilities
        {
            get { return _abilities; }
        }

        #endregion 
    }
}
