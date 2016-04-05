using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelRPG
{

    public class UI
    {
        private UI()
        {
            _cardLibrary = new Dictionary<string, Card>();
        }
        private static UI m_instance;
        public static UI Instance
        {
            get
            {
                if (m_instance == null)
                    m_instance = new UI();
                return m_instance;

            }
        }

        private static Dictionary<string, Card> _cardLibrary;
        public static Dictionary<string, Card> CardLibrary { get { return _cardLibrary; } }
       public void AddCard(Card c)
        {
            _cardLibrary.Add(c.Name, c);
        }
        
    }
}
