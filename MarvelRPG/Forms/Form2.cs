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
        public Form2(ref TestCombat tc)
        {
            InitializeComponent();
            combat = tc;
            
        }
        List<Card> Cards;
        private void Form2_Load(object sender, EventArgs e)
        {
            Party p1 = new Party();
            Party p2 = new Party();
            Cards = new List<Card>();
            p1 = combat.PlayerParty;
            p2 = combat.EnemyParty;
            
            this.Text = "Combat";
            int xoffset = 0;
       
            //this.left = new Card(p1[0].Name, pictureBox1, leftCardBack);
            //this.right = new Card(p2[0].Name, pictureBox2, rightCardBack);
           // this.current = left;
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
            InitForm();
            UpdateForm(true);


        }
        private void InitForm()
        {
            //left
            groupBox1.Text = combat.CurrentUnit.Name;
            abilityBox1.Text = combat.CurrentUnit.Abilities[0].Description;
            unitBox1.Text = "Health: " + combat.CurrentUnit.Health.ToString();
            //right
            groupBox2.Text = combat.CurrentUnit.Name;
            abilityBox2.Text = combat.CurrentUnit.Abilities[0].Description;
            unitBox2.Text = "Health: " + combat.CurrentUnit.Health.ToString();
        }

        /// <summary>
        /// when something is clicked they are funneled through this function
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void onClick(object o, EventArgs e)
        {
            Button b = (Button)o;
            if (b == null)
                return;

            string name = b.Text;
            Console.Write("Button.Text: " + name + "\n");


            //buttons that do not feed fsm
            if (name == "Flip")
            {
                current.Flipped = !current.Flipped;
                return;
            }

            //buttons that feed the fsm
            if (name == "Attack")
            {
                Form4 target = new Form4();
                target.Controls.Add(MakeBox());
                target.ShowDialog();
            }

            //send the button name to fsm
            //if it's a valid input it will be handled their
            //tc.Update(name) will return the party who is active            
            UpdateForm(combat.Update(name));
            //relevant information for the UI is
            //combat info string
            //party info Party
            //unit info Unit
        }
        private void pauseButton_Click(object sender, EventArgs e)
        {
            Form3 pause = new Form3();
            pause.ShowDialog();

        }

        /// <summary>
        /// state is either a player or an enemy
        /// </summary>
        /// <param name="player">the party state. True for player. False for other</param>
        private void UpdateForm(bool player)
        {
            //if the card is flipped over then turn it back to the picture
            if(current != null)
                current.Flipped = (current.Flipped) ? false : false;

          

            turnBox.Text = combat.Turn.ToString();
            textBox3.Text = "Current Party: " + combat.CurrentParty + Environment.NewLine
                          + "Current Unit: " + combat.CurrentUnit.Name;
            combatLog.Text += combat.ResolutionText + Environment.NewLine;
            //set the playerbuttons active state
            playerActions.SetActive(player);
            //set the enemybuttons active state
            enemyActions.SetActive(!player);
        }

        /// <summary>
        /// abilities button group
        /// should support future created buttons
        /// </summary>
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

       


        /// <summary>
        /// make a button 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="p"></param>
        /// <returns></returns>
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
        /// <summary>
        /// make a group box with labels
        /// </summary>
        /// <returns></returns>
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
            if (combat != null)
            {
                foreach (Unit u in combat.EnemyParty.units)
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

        private TestCombat combat;
        private Card left, right, current;
        private ActionGroup playerActions;
        private ActionGroup enemyActions;




    }
}
