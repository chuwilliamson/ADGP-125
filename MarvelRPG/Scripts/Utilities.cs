using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedRPG.Scripts
{
    public static class Utilities
    {
        public static void Test()
        {

            ///setup parties
            List<Unit> goodGuys = new List<Unit>();
            List<Unit> badGuys = new List<Unit>();

            ///setup units
            Warrior Dylan = new Warrior();
            Ninja Zak = new Ninja();
            goodGuys.Add(Dylan);
            goodGuys.Add(Zak);

            Warrior Rory = new Warrior();
            Ninja Donte = new Ninja();
            badGuys.Add(Rory);
            badGuys.Add(Donte);




        }
    }
}
