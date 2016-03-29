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
        public TestCombat() { this.Init(); }
        GameState gameState = GameState.instance;
        private void Init()
        {
            Unit psylocke = gameState.CharacterLibrary["Psylocke"];
            Abilities psylocke_abilities = gameState.AbilityLibrary["Psylocke"];
            Unit hulk = gameState.CharacterLibrary["Hulk"];
            Abilities hulk_abilities = gameState.AbilityLibrary["Hulk"];
            this.Start();
        }



        Thread combatThread;
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


    }
}
