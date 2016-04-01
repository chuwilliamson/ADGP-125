
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace MarvelRPG
{

    public partial class Form1 : Form
    {

        private string currentSelection = "";
        GameState gs = GameState.instance;

        private void Form1Load(object sender, EventArgs e)
        {

            var values = Enum.GetValues(typeof(Characters));
            int offset = 25;
            foreach (Enum v in values)
            {
                //validClasses.Add(v.ToString());
                string name = v.ToString();
                RadioButton rb = new RadioButton();
                rb.AutoSize = true;
                rb.Location = new System.Drawing.Point(6, offset);
                rb.Name = "radioButton_" + v.ToString();
                rb.Size = new System.Drawing.Size(68, 21);
                rb.TabIndex = 2;
                rb.TabStop = true;
                rb.Text = name;
                rb.UseVisualStyleBackColor = true;
                rb.CheckedChanged += new System.EventHandler(radioButton_Check);
                classGroupBox1.Controls.Add(rb);
                offset += 25;
            }


        }

        /// <summary>
        /// Default form initialization
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        #region events

        private void radioButton_Check(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            currentSelection = rb.Text;
            Utilities.UpdateDescription(currentSelection, ref webTextBox1, ref pictureBox1);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Party p = gs.Party;
            if (p.units.Count <= 0)
            {
                MessageBox.Show("Party is Empty.. Please add members.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string path = Utilities.path + @"Parties\";
            if (Directory.Exists(path))
                saveFileDialog.InitialDirectory = path;

            saveFileDialog.Filter = "XML Files | *.xml";
            saveFileDialog.DefaultExt = "xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(saveFileDialog.FileName);
                fileName = fileName.Replace(".xml", "");
                Utilities.SerializeXML(fileName, p, path);
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            gs.Party.units.Clear();
            string fileName;
            OpenFileDialog selectFileDialog = new OpenFileDialog();
            string path = Utilities.path + @"Parties\";

            selectFileDialog.InitialDirectory = path;
            selectFileDialog.Filter = "XML Files | *.xml";
            selectFileDialog.DefaultExt = "xml";

            if (selectFileDialog.ShowDialog() != DialogResult.OK)
                return;

            fileName = selectFileDialog.FileName;
            fileName = fileName.Replace(".xml", "");
            Party p = Utilities.DeserializeXML<Party>(fileName);


            Utilities.updateBox(ref partyBox, ref p);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Party p = gs.Party;
            Unit toRemove = p.units.Find(u => u.Name == currentSelection);
            if (toRemove != null)
                p.units.Remove(toRemove);


            Utilities.updateBox(ref partyBox, ref p);

        }

        private void addButton_Click(object sender, EventArgs e)
        {


            Unit u = Utilities.DeserializeXML<Unit>(Utilities.upath + currentSelection);

            Unit tmp = gs.Party.units.Find(x => x.Name == u.Name);

            if (tmp == null)
                gs.Party.units.Add(u);

            Party p = gs.Party;
            Utilities.updateBox(ref partyBox, ref p);
        }

        private void clearPartyButton_Click(object sender, EventArgs e)
        {
            gs.Party.units.Clear();
            Party p = gs.Party;
            Utilities.updateBox(ref partyBox, ref p, true);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //create a combat context
            TestCombat tc = new TestCombat();
            //give it to form2 to process
            Form2 combat = new Form2(ref tc);

            if (partyBox.Controls.Count <= 0)
                MessageBox.Show("No party selected... loading default parties.");


            string partyText = Environment.NewLine;
            foreach (Unit u in tc.PlayerParty.units)
                partyText += u.Name + Environment.NewLine;


            MessageBox.Show("Combat Party " + partyText);
            combat.ShowDialog();
            this.Close();
        }
        #endregion events

    }
}
