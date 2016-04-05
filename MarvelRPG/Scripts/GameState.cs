using System;
using System.IO;

using System.Collections.Generic;


namespace MarvelRPG
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
            m_enemyParty = new Party();
            m_playerParty = new Party();
            m_combatParty = new Party();
            m_characterLibrary = new Dictionary<string, Unit>();
            m_abilityLibrary = new Dictionary<string, Abilities>();
            m_abilities = new Abilities();
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

            if (!Directory.Exists(Utilities.apath))
                Directory.CreateDirectory(Utilities.apath);

            m_abilities = Utilities.DeserializeXML<Abilities>(file);

            if (m_abilities != null)
            {
                foreach (Ability ability in m_abilities.Members)
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

            Utilities.SerializeXML("Abilities", m_abilities, Utilities.apath);

            return true;
        }

        private bool GenerateClasses()
        {

            var v = Enum.GetValues(typeof(Characters));
            //generate the classes based on information on application startup
            //1330is number of abilities
            if (!Directory.Exists(Utilities.upath))
                Directory.CreateDirectory(Utilities.upath);

            foreach (var s in v)
            {
                string name = s.ToString();
                string unitFile = Utilities.upath + name + ".xml"; 
                Unit u = (File.Exists(unitFile)) ? Utilities.DeserializeXML<Unit>(unitFile) : Utilities.FetchUnit(name); 
                //if not go get it from the wiki
                name = name.Replace("_", " ");
                 
                Abilities a = new Abilities(AbilityLibrary[name][0]);
                //attach abilities to it 
                u.Abilities = a; 
                //save it 
                //put it in library
                m_characterLibrary.Add(name, u);
                Utilities.SerializeXML(name, u, Utilities.upath);

            }

            return true;
        }

        #region private
        private Party m_playerParty;
        private Party m_enemyParty;
        private Party m_combatParty;
        private Dictionary<string, Unit> m_characterLibrary;
        private Dictionary<string, Abilities> m_abilityLibrary;
        private Abilities m_abilities;
        


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



        public int PartySize
        {
            get { return m_combatParty.Count; }
        }
        public Party EnemyParty
        {
            get { return m_enemyParty; }
        }
        public Party PlayerParty
        {
            get { return m_playerParty; }
        }
        /// <summary>
        /// the combat party
        /// </summary>
        public Party CombatParty
        {
            get { return m_combatParty; }

        }
        /// <summary>
        /// library of characters 
        /// </summary>
        public Dictionary<string, Unit> CharacterLibrary
        {
            get { return m_characterLibrary; }

        }
        /// <summary>
        /// library of abilities
        /// </summary>
        public Dictionary<string, Abilities> AbilityLibrary
        {
            get { return m_abilityLibrary; }

        }
        /// <summary>
        /// list of all abilities
        /// </summary>
        public Abilities Abilities
        {
            get { return m_abilities; }
        }

        #endregion 
    }
}
