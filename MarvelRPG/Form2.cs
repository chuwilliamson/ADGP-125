using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MarvelRPG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Party p1 = new Party();
            Party p2 = new Party();
            tc = new TestCombat();
            p1 = tc.PlayerParty;
            p2 = tc.EnemyParty;

            this.Text = "Combat";
            this.left = new Card("Psylocke", pictureBox1, leftCardBack);
            this.right = new Card("Hulk", pictureBox2, rightCardBack);
            this.playerActions = new ActionGroup(ref panel1);
            this.enemyActions = new ActionGroup(ref panel2);
            //add the onclick events for the actions
            foreach (Button b in playerActions.Buttons)
                b.Click += onClick;
            foreach (Button b in enemyActions.Buttons)
                b.Click += onClick;

            //update the cards... will need to do this after every turn is finished
            Utilities.updateBox(ref partyBox1, ref p1);
            Utilities.updateBox(ref partyBox2, ref p2);
            //set players turn to first always for now
            
            UpdateForm(true);

        }

        private void onClick(object o, EventArgs e)
        {
            Button b = (Button)o;
            string name = b.Text;

            Console.Write("text of button: " + name + "\n");
            if (name == "End Turn")
                UpdateForm(tc.Next());



        }
        private void pauseButton_Click(object sender, EventArgs e)
        {
            Form3 pause = new Form3();
            pause.ShowDialog();

        }

        private void UpdateForm(bool state)
        {
            turnBox.Text = tc.CombatTurn.ToString();
            textBox3.Text = tc.CurrentParty;
            combatLog.Text = tc.ResolutionText;
            playerActions.SetActive(state);
            enemyActions.SetActive(!state);

        }

        internal class ActionGroup
        {
            
            public ActionGroup(ref Panel p)
            {
                _buttons = new Dictionary<string, Button>();
                foreach (Control c in p.Controls)
                {
                    string key = c.Text.Replace(" ", "").ToLower();
                    _buttons.Add(c.Text, (Button)c);
                }
            }
            private Dictionary<string, Button> _buttons;
            public List<Button> Buttons
            {
                get { return _buttons.Values.ToList<Button>(); }
            }
            public string[] ButtonNames { get { return _buttons.Keys.ToArray<string>(); } }

            public void SetActive(bool state)
            {
                foreach (KeyValuePair<string, Button> b in _buttons)
                    b.Value.Enabled = state;
            }
            
        }

        internal class Card
        {
            public Card(string name, PictureBox f, TextBox b)
            {
                front = f;
                back = b;
                Utilities.UpdateDescription(name, ref back, ref front);
            }
            public Card(PictureBox f, TextBox b)
            {
                front = f;
                back = b;
            }
            private PictureBox front;
            private TextBox back;
            private bool flipped = false;
            public bool Flipped
            {
                get { return flipped; }
                set
                {
                    flipped = value;
                    (flipped == true ? (Action)back.BringToFront : front.BringToFront)();
                }
            }
        }
        private TestCombat tc;
        private Card left, right;
        private ActionGroup playerActions;
        private ActionGroup enemyActions;




    }
}
