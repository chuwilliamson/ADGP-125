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
            Party p1 = new Party();
            Party p2 = new Party();
            tc = new TestCombat();
            p1 = tc.PlayerParty;
            p2 = tc.EnemyParty;
            
            this.Text = "Combat";
            left = new Card("Psylocke", pictureBox1, leftCardBack);
            right = new Card("Hulk", pictureBox2, rightCardBack);
 

            Utilities.updateBox(ref partyBox1, ref p1);
            Utilities.updateBox(ref partyBox2, ref p2);
            turnBox.Text = tc.Turn.ToString(); 
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            Form3 pause = new Form3();
            pause.ShowDialog();

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
            //unit has attacked
            //resolve and move to the next unit
            turnBox.Text = tc.Turn.ToString();
            tc.Next();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turnBox.Text = tc.Turn.ToString();
            tc.Next();
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

        private void turnBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
