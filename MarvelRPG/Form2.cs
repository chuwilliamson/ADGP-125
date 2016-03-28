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

            string text = (textBox1.HasChildren) ? "has children" : "no children";

            MessageBox.Show(text);

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            Form3 pause = new Form3();
            pause.ShowDialog();

        }
    }
}
