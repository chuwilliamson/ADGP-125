using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace MarvelRPG
{
    public class TestCombat
    {        
        public TestCombat()
        {
            m_player = new Party();
            m_enemy = new Party();
            this.Init();
        }

        /// <summary>
        /// create a combat with predefined parties
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public TestCombat(Party p1, Party p2)
        {
            m_current = m_player;
            m_player = p1;
            m_enemy = p2;
            m_turn = 0;
            this.Init(true);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="withParty"></param>
        private void Init(bool withParty = false)
        {
            //no party given make our own
            if (!withParty)
            {
                Unit psylocke = gameState.CharacterLibrary["Psylocke"];
                Unit hulk = gameState.CharacterLibrary["Hulk"];
                m_player.Add(psylocke);
                m_enemy.Add(hulk);
                return;
            }

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
        public void Next()
        {
            //
            m_turn++;
        }
        /// <summary>
        /// 
        /// </summary>
        private void Exit()
        {

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

        #region variables
        #region public
        public Party PlayerParty { get { return m_player; } }
        public Party EnemyParty { get { return m_enemy; } }
        public string PartyName
        {
            get { return "no party name"; }
        }
        public string ResolutionText
        {
            get { return "no resolution"; }
        }
        public string Turn { get { return m_turn.ToString(); } }
        public string CurrentParty
        {
            get
            {
                if ((m_turn % 2) == 0)
                    return "Player";
                return "Enemy";

            }
        }
        #endregion public

        #region private
        GameState gameState = GameState.instance;
        private Thread combatThread;
        private Party m_player;
        private Party m_enemy;
        private Party m_current;
        private int m_turn;
        #endregion private
        #endregion variables

    }
}
