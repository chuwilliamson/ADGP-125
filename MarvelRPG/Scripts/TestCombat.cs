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

            m_enemyParty = new Party();
            m_playerParty = new Party();

            //if the gamestate has a party use that one

            if (gameState.Party.Count > 0)
            {
                Init(gameState.Party);
            }
            else
            {
                Init();
            }


        }

        private void Init(Party p)
        {

            Unit hulk = gameState.CharacterLibrary["Hulk"];
            Unit wolverine = gameState.CharacterLibrary["Thor"];
            m_enemyParty.Add(hulk);
            m_enemyParty.Add(wolverine);

            m_playerParty = p;
            m_currentParty = m_playerParty;
            m_partyIndex = 0;
            m_resolutionText = "\r\nno resolution";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="withoutParty"></param>
        private void Init()
        {
            Unit psylocke = gameState.CharacterLibrary["Psylocke"];
            Unit hulk = gameState.CharacterLibrary["Hulk"];
            Unit wolverine = gameState.CharacterLibrary["Thor"];
            Unit rogue = gameState.CharacterLibrary["Rogue"];
            m_playerParty.Add(psylocke);
            m_playerParty.Add(rogue);
            m_enemyParty.Add(hulk);
            m_enemyParty.Add(wolverine);
            m_currentParty = m_playerParty;
            m_partyIndex = 0;
            m_resolutionText = "\r\nno resolution";
        }

        /// <summary>
        /// 
        /// </summary>
        private void Exit()
        {

        }

        private bool Next()
        {

            m_partyIndex++;
            //if we have 1 member...
            //just flip the party on a new turn
            //i want a custom iterator that just lets this happen
            //m_currentParty.moveNext();

            if (m_partyIndex >= m_currentParty.Count || m_currentParty.Count == 1)
            {
                m_partyIndex = 0;
                m_Turn++;
                m_currentParty = (isPlayerParty) ? m_enemyParty : m_playerParty;
            }


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
                    m_resolutionText = "Attacking..";
                    AttackHandler();
                    break;
                case "End Turn":
                    m_resolutionText = "Ending Turn..";
                    EndTurnHandler();
                    break;

                case "Skill":
                    m_resolutionText = "Skill..";
                    SkillHandler();
                    break;

            }

            //move to the next state
            return Next();

        }

        #region StateHandlers
        public bool AttackHandler()
        {
            string s1 = CurrentUnit.Name;
            string s2 = "attacked for ";
            string s3 = CurrentUnit.Strength.ToString();
            m_resolutionText += s1 + s2 + s3 + nl;

            return true;
        }

        public bool SkillHandler()
        {
            string s1 = CurrentUnit.Name;
            string s2 = "do skill ";
            string s3 = CurrentUnit.Abilities.Members[0].Name;
            m_resolutionText += s1 + s2 + s3 + nl;

            return true;
        }
        string nl = Environment.NewLine;
        public bool EndTurnHandler()
        {

            string s1 = CurrentUnit.Name;
            string s2 = "ended turn ";
            string s3 = "";

            m_resolutionText += s1 + s2 + s3 + nl;
            return true;

        }
        #endregion





        public Unit CurrentUnit { get { return m_currentParty[m_partyIndex]; } }
        public Party PlayerParty { get { return m_playerParty; } }
        public Party EnemyParty { get { return m_enemyParty; } }

        public string ResolutionText
        {
            get { return m_resolutionText; }
            set { m_resolutionText = value; }
        }
        public string Turn { get { return m_Turn.ToString(); } }
        public bool isPlayerParty
        {
            get
            {
                //since we only have 2 parties then we can flip flop
                if (m_currentParty == m_playerParty)
                    return true;
                return false;
            }
        }


        public string CurrentParty
        {
            get
            {
                if ((m_Turn % m_currentParty.Count) == 0)
                    return "Player";
                return "Enemy";
            }
        }


        private GameState gameState = GameState.instance;
        private Thread combatThread;
        private Party m_playerParty;
        private Party m_enemyParty;
        private Party m_currentParty;
        private string m_resolutionText;
        private int m_partyIndex;
        private int m_Turn;



    }
}
