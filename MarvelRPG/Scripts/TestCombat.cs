using System;
using System.Collections.Generic;
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
            combatMachine = new Thread(() => CombatFSM("*"));
            playerMachine = new Thread(() => PlayerFSM("*"));
            enemyMachine = new Thread(() => EnemyFSM("*"));
            combatMachine.Start();

            m_combatTurn = 1;


            m_enemyParty = new Party();
            m_playerParty = new Party();
            m_currentParty = new Party();

            m_units = new List<Unit>();


            Unit hulk = gameState.CharacterLibrary["Hulk"];
            Unit wolverine = gameState.CharacterLibrary["Thor"];
            m_enemyParty.Add(hulk);
            m_enemyParty.Add(wolverine);

            //if we do not have a party to start with make one
            Func<Party> noParty = () =>
            {
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

            m_playerParty = (gameState.Party.Count > 0 ? hasParty : noParty)();
            //starting party is the player party
            m_currentParty = m_playerParty;

            m_resolutionText = "";

            m_combatState = CombatState.PLAYER;
            
            
        }


        private string PlayerFSM(string input)
        {
            switch (input)
            {
                case "*":
                    Console.Write("\r Player init");
                    break;
                case "ok":
                    break;
                case "cancel":
                    break;
                case "skill":
                    break;
                case "endturn":
                    break;
                case "attack":
                    break;
            }

            return input;
        }

        private void EnemyFSM(string input)
        {
            switch (input)
            {
                case "*":
                    break;
                case "ok":
                    break;
                case "cancel":
                    break;
                case "skill":
                    break;
                case "endturn":
                    break;
                case "attack":
                    break;
            }
        }

        private static void CombatFSM(string input)
        {
            int time = 0;
            CombatState currentState = m_combatState;
            while (true)
            {
                time += 1; 
                Console.Write("\rCombat State: {0} {1}", m_combatState.ToString(), time);

                if (input == "*")
                    m_combatState = CombatState.INIT;
                else if (input == "done")
                    m_combatState = (currentState == CombatState.PLAYER) ? CombatState.ENEMY : CombatState.PLAYER;


                switch (currentState)
                {
                    case CombatState.PLAYER:
                        if (enemyMachine.ThreadState == ThreadState.Running)
                        {
                            Console.WriteLine("die enemy state");
                            enemyMachine.Abort();
                        }
                        if(playerMachine.ThreadState == ThreadState.Unstarted)
                            playerMachine.Start();
                        
                        //PlayerFSM(input);
                        break;
                    case CombatState.ENEMY:
                        if (playerMachine.ThreadState == ThreadState.Running)
                        {
                            Console.WriteLine("die player state");
                            playerMachine.Abort();
                        }
                        enemyMachine.Start();
                        //EnemyFSM(input);
                        break;
                }
            } 
        }


 
        /// <summary>
        /// update the fsm with an input
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>

        public void Update(string token)
        {
            switch (token)
            {
                case "Attack":
                    CombatFSM("Attack");
                    break;
                case "End Turn":
                    CombatFSM("done");
                    break;
                case "Skill":
                    CombatFSM("Skill");
                    break;
            }

            //move to the next state


        }

        private Unit NextUnit()
        {
            m_unitTurn++;
            return m_currentParty[m_unitTurn - 1];
        }

        private void Next()
        {
            Unit u = NextUnit();
            if (u == null)
                m_currentParty = NextParty();
        }

        private Party NextParty()
        {
            Party p = new Party();
            if (m_unitTurn > m_currentParty.Count)
            {
                m_unitTurn = 1;
                m_combatTurn++;
                p = (m_currentParty.GetHashCode() == m_currentParty.GetHashCode()) ? m_enemyParty : m_playerParty;
            }
            return p;
        }



        public string attackHandler(Unit attacker, Unit Defender)
        {
            string resolution = attacker.Name + " attacked for " + attacker.Strength;


            return resolution;
        }

        public bool skillHandler()
        {
            if (CurrentUnit == null)
                return false;

            return true;
        }



        public string ResolutionText
        {
            get { return m_resolutionText; }
            set { m_resolutionText = value; }
        }

        public string CurrentPartyName
        {
            get
            {
                if ((m_combatTurn % m_currentParty.Count) == 0)
                    return "Player";
                return "Enemy";
            }
        }

        private GameState gameState = GameState.instance;
        private List<Unit> m_units;
        private Party m_playerParty;
        private Party m_enemyParty;
        private Party m_currentParty;
        private string m_resolutionText;
        private Unit m_currentUnit;
        private int m_unitTurn;
        private int m_combatTurn;
        private int m_Turn;

        public Party PlayerParty
        {
            get { return m_playerParty; }
        }

        public Party EnemyParty
        {
            get { return m_enemyParty; }
        }
        public Unit CurrentUnit
        {
            get { return m_currentUnit; }
        }
        public int Turn
        {
            get { return m_Turn; }
        }
        enum CombatState
        {
            INIT = 0,
            PLAYER = 1,
            ENEMY = 2,
        }
        enum UnitState
        {
            INIT = 0,
            TARGETING = 1,
            END = 2,
        }

        private static CombatState m_combatState = CombatState.INIT;
        private static Thread combatMachine;
        private static Thread playerMachine;
        private static Thread enemyMachine;

    }
}
