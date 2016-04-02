using System;
using System.Threading;
namespace MarvelRPG
{
    public class TestCombat
    {

        /// <summary>
        /// create a test instance of combat with hulk and psylocke
        /// </summary>
        public TestCombat()
        {

            m_enemy = new Party();
            m_player = new Party();
            Unit hulk = gameState.CharacterLibrary["Hulk"];
            Unit wolverine = gameState.CharacterLibrary["Thor"]; 
            m_enemy.Add(hulk);
            m_enemy.Add(wolverine);
           

            Func<Party> noParty = () => {
                Party p = new Party();
                Unit psylocke = gameState.CharacterLibrary["Psylocke"];
                Unit rogue = gameState.CharacterLibrary["Rogue"];
                p.Add(psylocke);
                p.Add(rogue);
                return p;
            };
            //if the gamestate has a party use that one
            Func<Party> hasParty = () =>
            {
                return gameState.Party;
            };

            m_player = (gameState.Party.Count > 0 ? hasParty : noParty)();
            m_partyTurn = 0;
            m_resolutionText = "\r\nno resolution";



        }
         
        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {

            combatThread = new Thread(new ThreadStart(Logger));
            Console.WriteLine("Starting combat thread...");
            combatThread.Start();
        }
        /// <summary>
        /// 
        /// </summary>
        private void Exit()
        {

        }

        private bool Next()
        {

            m_partyTurn++;

            if (m_partyTurn >= m_currentParty.Count)
            {
                m_partyTurn = 0;
                m_combatTurn++;

            }
            m_currentParty = (isPlayerParty) ? m_player : m_enemy;
            
            return isPlayerParty;
        }

        /// <summary>
        /// update the fsm with an input
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool Update(string token)
        {
            switch (token)
            {
                case "Attack":
                    m_resolutionText = 
                        CurrentUnit.Name + " attacked for " + CurrentUnit.Strength;
                    attackHandler();
                    break;
                case "End Turn":
                    m_resolutionText = CurrentUnit.Name + " Ended Turn ";
                    break;

                case "Skill":
                    m_resolutionText =
               CurrentUnit.Name + " performed skill " + CurrentUnit.Abilities[0].Name;
                    skillHandler();
                    break;

            }

            //move to the next state
            return Next();

        }



        public bool attackHandler()
        {
            if (CurrentUnit == null)
                return false;
       
            return true;
        }

        public bool skillHandler()
        {
            if (CurrentUnit == null)
                return false;
           
            return true; 
        }
        /// <summary>
        /// 
        /// </summary>
        public void Restart()
        {
            combatThread.Abort();
            Start();
        }
        /// <summary>
        /// 
        /// </summary>
        private void Logger()
        {
            int time = 0;
            while (true)
            {
                time += 1;
                Console.Write("\rRunning combat thread... {0}ms: ", time.ToString());
            }

        }



        public Unit CurrentUnit { get { return m_currentParty[m_partyTurn]; } }
        #region fields
        #region public
        public Party PlayerParty { get { return m_player; } }
        public Party EnemyParty { get { return m_enemy; } }
        public string PartyName
        {
            get { return "no party name"; }
        }
        public string ResolutionText
        {
            get { return m_resolutionText; }
            set { m_resolutionText = value; }
        }
        public string CombatTurn { get { return m_combatTurn.ToString(); } }



        public string CurrentParty
        {
            get
            {
                if ((m_combatTurn % m_currentParty.Count) == 0)
                    return "Player";
                return "Enemy";
            }
        }
        #endregion public

        #region private
        private GameState gameState = GameState.instance;
        private Thread combatThread;
        private Party m_player;
        private Party m_enemy;
        private Party m_currentParty;
        private string m_resolutionText;
        private int m_partyTurn;
        private int m_combatTurn;
        public bool isPlayerParty
        {
            get
            {
                if ((m_combatTurn % m_currentParty.Count) == 0 )
                    return true;
                return false;
            }
        }
        #endregion private
        #endregion fields

    }
}
