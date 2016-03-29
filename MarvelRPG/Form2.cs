using System;
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
            this.Text = "Combat";

            //string n1 = "female";
            //string n2 = "male";
            //string path = Utilities.savePath + @"/Parties/";

            //p1 = Utilities.DeserializeXML<Party>(path + n1);
            //Utilities.updateTextBox(ref textBox1, ref p1);

            //p2 = Utilities.DeserializeXML<Party>(path + n2);
            //Utilities.updateTextBox(ref textBox2, ref p2);
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form2_KeyPress);
            //string text = (textBox1.HasChildren) ? "has children" : "no children";
            Console.WriteLine("starting form2");
            left = new Card("Psylocke", pictureBox1, leftCardBack);
            right = new Card("Hulk", pictureBox2, rightCardBack);
            partyBox1.ReadOnly = true;
            partyBox1.Enabled = false;
            partyBox2.ReadOnly = true;
            partyBox2.Enabled = false;
            combatLog.ReadOnly = true;
            combatLog.Enabled = false;

            Party p1 = new Party();
            Party p2 = new Party();
            tc = new TestCombat();
            p1 = tc.PlayerParty;
            p2 = tc.EnemyParty;
            Utilities.updateBox(ref partyBox1, ref p1);
            Utilities.updateBox(ref partyBox2, ref p2);
            turnBox.Text = tc.Turn.ToString();


        }
        TestCombat tc;
        Card left, right;

        private void pauseButton_Click(object sender, EventArgs e)
        {
            Form3 pause = new Form3();
            pause.ShowDialog();

        }
 

        private void updateCombatLog()
        {

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

        private void leftFlipButton_Click(object sender, EventArgs e)
        {
            left.Flipped = (left.Flipped ? false : true);
        }

        private void rightFlipButton_Click(object sender, EventArgs e)
        {
            right.Flipped = (right.Flipped ? false : true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            turnBox.Text = tc.Turn.ToString();
            tc.Next();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turnBox.Text = tc.Turn.ToString();
            tc.Next();
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            left.Flipped = (right.Flipped ? false : true);
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.
            if (e.KeyChar == (char)Keys.Return)
            {
                Console.WriteLine("Restart combat thread");
                tc.Restart();
                e.Handled = true;
            }
        }

    }
}
