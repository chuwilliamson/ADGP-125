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
        GameState gameState = GameState.instance;
        public TestCombat()
        {
            m_player = new Party();
            m_enemy = new Party();
            this.Init();
        }

        /// <summary>
        /// create a combat with some predefined parties
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public TestCombat(Party p1, Party p2)
        {
            m_current = m_player;
            m_player = p1;
            m_enemy = p2;
            this.Init(true);
        }


        int m_turn = 0;
        public int Turn { get { return m_turn; } }

        private Party m_player;
        private Party m_enemy;
        private Party m_current;

        public Party PlayerParty { get { return m_player; } }
        public Party EnemyParty { get { return m_enemy; } }
        public Party CurrentParty
        {
            get
            {
                if ((m_turn % 2) == 0)
                    return m_player;
                return m_enemy;

            }
        }





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

        void OnAttack(Unit attacker, Unit defender)
        {

        }


        public void Next()
        {
            //
            m_turn++;
        }


        private void Start()
        {

            combatThread = new Thread(new ThreadStart(Logger));
            Console.WriteLine("Starting combat thread...");

            combatThread.Start();
        }

        private void Update()
        {

        }



        private void Exit()
        {

        }

        public void Restart()
        {
            combatThread.Abort();
            Start();
        }
        //1ms = .001 seconds
        private void Logger()
        {
            int time = 0;
            while (true)
            {
                time += 1;
                Console.Write("\rRunning combat thread... {0}ms: ", time.ToString());
            }

        }
        Thread combatThread;

    }
}
