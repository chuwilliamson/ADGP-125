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
            Party p1 = new Party();
            Party p2 = new Party();
            string n1 = "female";
            string n2 = "male";
            string path = Utilities.savePath + @"/Parties/";

            p1 = Utilities.DeserializeXML<Party>(path + n1);
            Utilities.updateTextBox(ref textBox1, ref p1);

            p2 = Utilities.DeserializeXML<Party>(path + n2);
            Utilities.updateTextBox(ref textBox2, ref p2);
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(form2_KeyPress);
            //string text = (textBox1.HasChildren) ? "has children" : "no children";
            Console.WriteLine("starting form2");
        

 

        }
        TestCombat tc = new TestCombat();
        private void form2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            Form3 pause = new Form3();
            pause.ShowDialog();

        }

        private void attackButton_Click(object sender, EventArgs e)
        {

        }

        private void updateCombatLog()
        {

        }

        private void form2_KeyPress(object sender, KeyPressEventArgs e)
        {
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
