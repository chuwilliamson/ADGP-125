using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

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
            this.current = left;
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
            GroupBox enemies = MakeBox();
            enemies.BringToFront();
            enemies.CausesValidation = true;

            string name = b.Text;
            Console.Write("Button.Text: " + name + "\n");
            

            //buttons that do not feed fsm
            if (name == "Flip")
            {
                current.Flipped = !current.Flipped;
                return;
            }

            if (name == "Attack")
            {
                Form4 target = new Form4();
                target.Controls.Add(MakeBox());
                target.ShowDialog();
                
                
 
            }
            
            UpdateForm(tc.Update(name));
        }
        private void pauseButton_Click(object sender, EventArgs e)
        {
            Form3 pause = new Form3();
            pause.ShowDialog();

        }

        private Button MakeButton(string name, Point p)
        {

            Button b = new Button();
            b.Location = p;
            b.Name = name + "_Button";
            b.Size = new Size(125, 35);
            b.TabIndex = 12;
            b.Text = name;
            b.UseVisualStyleBackColor = true;
            b.Anchor = AnchorStyles.Top;
            
            return b;


        }
        private GroupBox MakeBox()
        {
            GroupBox gb = new GroupBox();
            gb.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gb.Location = new Point(5, 5);
            gb.Name = "classGroupBox1";
            gb.Size = new Size(250, 200);
            gb.TabIndex = 1;
            gb.TabStop = false;
            gb.Text = "Enemies";
            int offset = 0;
            if (tc != null)
            {
                foreach (Unit u in tc.EnemyParty.units)
                {
                    //validClasses.Add(v.ToString());
                    string name = u.Name.ToString();
                    RadioButton rb = new RadioButton();
                    rb.AutoSize = true;
                    rb.Location = new Point(6, offset + 25);
                    rb.Name = "radioButton_" + name;
                    rb.Size = new Size(68, 21);
                    rb.TabIndex = 2;
                    rb.TabStop = true;
                    rb.Text = name;
                    rb.UseVisualStyleBackColor = true;
                    rb.CheckedChanged += new System.EventHandler(radioButton_Check);
                    gb.Controls.Add(rb);              
                    offset += 25;
                }

                Button ok = MakeButton("ok", new Point(gb.Size.Width - 125, gb.Size.Height - 35));
                Button cancel = MakeButton("cancel", new Point(0, gb.Size.Height - 35));
                ok.Click += targetSelected;
                cancel.Click += targetSelected;

                gb.Controls.Add(ok);
                gb.Controls.Add(cancel);

                ok.BringToFront();
                cancel.BringToFront();
            }

            Console.WriteLine(gb.Name);
            Console.WriteLine(gb.Location);



            return gb;
        }

        private void targetSelected(object o, EventArgs e)
        {
            Console.WriteLine("target selected");
            Button b = o as Button;
            Form f = b.FindForm();
            f.Close();
        }
        private void radioButton_Check(object o, EventArgs e)
        {

        }

        /// <summary>
        /// state is either a player or an enemy
        /// </summary>
        /// <param name="state"></param>
        private void UpdateForm(bool state)
        {
            if (current.Flipped) current.Flipped = false;
            if (state)
            {
                current = left;
                
                groupBox1.Text = tc.CurrentUnit.Name;
                left = new Card(tc.CurrentUnit.Name, pictureBox1, leftCardBack);
                textBox1.Text = tc.CurrentUnit.Abilities[0].Description;
            }
            if (!state)
            {
                current = right;
                groupBox2.Text = tc.CurrentUnit.Name;
                right = new Card(tc.CurrentUnit.Name, pictureBox2, rightCardBack);
                textBox2.Text = tc.CurrentUnit.Abilities[0].Description;
            }
            turnBox.Text = tc.CombatTurn.ToString();            
            textBox3.Text = 
                "Current Party: " + tc.CurrentParty + 
                Environment.NewLine + "Current Unit: " + tc.CurrentUnit.Name;
            combatLog.Text += tc.ResolutionText + Environment.NewLine ;
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
                back.ReadOnly = true;
                Utilities.UpdateDescription(name, ref back, ref front);
            }
            public Card(PictureBox f, TextBox b)
            {
                front = f;
                back = b;
                back.ReadOnly = true;
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
        private Card left, right, current;
        private ActionGroup playerActions;
        private ActionGroup enemyActions;




    }
}
