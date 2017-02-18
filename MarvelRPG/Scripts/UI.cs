using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelRPG.Singletons
{
    public class UI
    {
        private UI()
        {
            CardLibrary = new Dictionary<string, Card>();
        }
        private static UI m_instance;
        public static UI Instance
        {
            get
            {
                if(m_instance == null)
                    m_instance = new UI();
                return m_instance;
            }
        }


        public static Dictionary<string, Card> CardLibrary { get; private set; }
        public void AddCard(Card c)
        {
            CardLibrary.Add(c.Name, c);
        }

    }
}
