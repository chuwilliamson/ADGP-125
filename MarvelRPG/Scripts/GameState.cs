using System;
using System.IO; 
using System.Collections.Generic;


namespace MarvelRPG.Singletons
{
    enum Characters
    {
        Psylocke,
        Storm,
        Rogue,
        Captain_Marvel,
        Scarlet_Witch,
        Iron_Man,
        Kitty_Pryde,
        Hulk,
        Thor,
        Emma_Frost,
        Black_Cat,
        Black_Panther,

    }
    [Serializable]
    public class GameState
    {
        private GameState()
        {
            EnemyParty = new Party();
            PlayerParty = new Party();
            CombatParty = new Party();
            CharacterLibrary = new Dictionary<string, Unit>();
            AbilityLibrary = new Dictionary<string, Abilities>();
            Abilities = new Abilities();
            GenerateAbilities(Utilities.apath + "Abilities");
            GenerateClasses();
        }
        /// <summary>
        /// generate the abilities for the characters
        /// either from web or from file
        /// </summary>
        /// <returns></returns>
        private bool GenerateAbilities(string file)
        {

            if(!Directory.Exists(Utilities.apath))
                Directory.CreateDirectory(Utilities.apath);
            Abilities = Utilities.DeserializeXML<Abilities>(file);

            if(Abilities != null)
            {
                foreach(Ability ability in Abilities.Members)
                {
                    if(AbilityLibrary.ContainsKey(ability.Character))
                        AbilityLibrary[ability.Character].Add(ability);
                    else
                        AbilityLibrary.Add(ability.Character, new Abilities(ability));
                }

                return true;
            }

            int MAXPOWERS = 1330;
            for(int i = 1; i <= MAXPOWERS; ++i)
            {
                //not sure if this works because i'm in the car with no internet
                //check this later b/c it looks alot cleaner to put the web request in the constructor
                Ability ability = new Ability(i.ToString());
                if(ability != null)
                {
                    Abilities.Members.Add(ability);

                    if(AbilityLibrary.ContainsKey(ability.Character))
                    {
                        AbilityLibrary[ability.Character].Add(ability);
                    }
                    else
                    {
                        AbilityLibrary.Add(ability.Character, new Abilities(ability));
                    }
                }
            }

            Utilities.SerializeXML("Abilities", Abilities, Utilities.apath);

            return true;
        }

        private bool GenerateClasses()
        {

            var v = Enum.GetValues(typeof(Characters));
            //generate the classes based on information on application startup
            //1330is number of abilities
            if(!Directory.Exists(Utilities.upath))
                Directory.CreateDirectory(Utilities.upath);

            foreach(var s in v)
            {
                string name = s.ToString();
                string unitFile = Utilities.upath + name + ".xml";
                Unit u = (File.Exists(unitFile)) ? Utilities.DeserializeXML<Unit>(unitFile) : Utilities.FetchUnit(name);
                //if not go get it from the wiki
                name = name.Replace("_", " ");

                Abilities a = new Abilities(AbilityLibrary[name][0]);
                //attach abilities to it 
                u.Abilities = a;
                CharacterLibrary.Add(name, u);
                Utilities.SerializeXML(name, u, Utilities.upath);

            }

            return true;
        }

 

        #region public
        static private GameState _instance;
        static public GameState Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new GameState();
                return _instance;
            }
        }



        public int PartySize
        {
            get;
            private set;
        }
        public Party EnemyParty
        {
            get;
            private set;
        }
        public Party PlayerParty
        {
            get;
            private set;
        }

        public Party CombatParty
        {
            get;
            private set;

        }
        /// <summary>
        /// library of characters 
        /// </summary>
        public Dictionary<string, Unit> CharacterLibrary
        {
            get;
            private set;

        }
        /// <summary>
        /// library of abilities
        /// </summary>
        public Dictionary<string, Abilities> AbilityLibrary
        {
            get;
            private set;

        }
        /// <summary>
        /// list of all abilities
        /// </summary>
        public Abilities Abilities
        {
            get;
            private set;
        }

        #endregion 
    }
}
