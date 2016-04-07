using System;
using System.Threading;
namespace MarvelRPG
{
    public class TestCombat
    {
        public TestCombat(Party player, Party enemy)
        {
            m_playerParty = player;
            m_enemyParty = enemy;
            m_currentParty = m_playerParty;
            
            Init(m_playerParty, m_enemyParty);
        }
        private void Init(Party p, Party e)
        {
            Unit u = GameState.instance.CharacterLibrary["Scarlet Witch"];
            if (e.Count <= 0)
                e.Add(u);
            m_currentParty = m_playerParty;
            m_partyIndex = 0;
            m_playerIndex = 0;
            m_enemyIndex = 0;
            m_resolutionText = "\r\nno resolution";
        }

        /// <summary>
        /// create a test instance of combat with hulk and psylocke
        /// </summary>
         
 
       

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
            //Func < bool, int > f = (player) => 
            //{
            //    int index = (player) ? m_playerIndex : m_enemyIndex;
            //    return index;
            //};
            if (isPlayerParty) m_playerIndex = m_partyIndex;
            else if (!isPlayerParty) m_enemyIndex = m_partyIndex;

            Console.WriteLine(m_playerIndex);
            Console.WriteLine(m_enemyIndex);

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



        public Unit CurrentEnemy { get { return m_enemyParty[m_enemyIndex]; } }
        public Unit CurrentPlayer { get { return m_playerParty[m_playerIndex]; } }
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
        private int m_enemyIndex;
        private int m_playerIndex;



    }
}
