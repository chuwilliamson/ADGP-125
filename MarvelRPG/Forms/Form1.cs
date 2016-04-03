
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace MarvelRPG
{

    public partial class Form1 : Form
    {

        private string currentSelection = "";
        GameState gs = GameState.instance;
        /// <summary>
        /// Default form initialization
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        List<Card> Cards = new List<Card>();
        private void Form1Load(object sender, EventArgs e)
        {
           
            var values = Enum.GetValues(typeof(Characters));
            
            int xoffset = 5;
            int yoffset = 0;
            int num = 0;
            foreach (Enum v in values)
            {
                num++; 
                string name = v.ToString(); 
                int scale = 4;
                int width = 540/scale;
                int height = 960/scale;
               
                
                int reheight = height;
                Card c = new Card(name, new Size(width, height), new Point(xoffset, yoffset));
                Cards.Add(c);
                xoffset += width + 50;
                if (num % 4 == 0)
                {
                    xoffset = 0;
                    yoffset += height;
                }
                Controls.AddRange(c.Controls);

            }

            partyBox1.AllowDrop = true;
            partyBox2.AllowDrop = true;



        }




        #region events
 
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


            Utilities.updateBox(ref partyBox1, ref p);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Party p = gs.Party;
            Unit toRemove = p.units.Find(u => u.Name == currentSelection);
            if (toRemove != null)
                p.units.Remove(toRemove);


            Utilities.updateBox(ref partyBox1, ref p);

        }

        private void addButton_Click(object sender, EventArgs e)
        { 
            Unit u = Utilities.DeserializeXML<Unit>(Utilities.upath + currentSelection);

            Unit tmp = gs.Party.units.Find(x => x.Name == u.Name);

            if (tmp == null)
                gs.Party.units.Add(u);

            Party p = gs.Party;
            Utilities.updateBox(ref partyBox1, ref p);
        }

        private void clearPartyButton_Click(object sender, EventArgs e)
        {
            gs.Party.units.Clear();
            Party p = gs.Party;
            Utilities.updateBox(ref partyBox1, ref p, true);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //create a combat context
            TestCombat tc = new TestCombat();
            //give it to form2 to process
            Form2 combat = new Form2(ref tc);

            if (partyBox1.Controls.Count <= 0)
                MessageBox.Show("No party selected... loading default parties.");


            string partyText = Environment.NewLine;
            foreach (Unit u in tc.PlayerParty.units)
                partyText += u.Name + Environment.NewLine;


            MessageBox.Show("Combat Party " + partyText);
            combat.ShowDialog();
            this.Close();
        }
        #endregion events

        private void partyBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private void partyBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        int offset = 25;
        private void partyBox1_DragDrop(object sender, DragEventArgs e)
        {
            int numControls = partyBox1.Controls.Count;

            Label l = new Label();
            l.Size = new Size(1, 1);
            l.Location = new Point(5, offset * numControls + offset);
            l.AutoSize = true;
            l.Text = e.Data.GetData(DataFormats.Text).ToString();
            l.Text = l.Text.Replace("_", " ");
            

            Unit u = Utilities.DeserializeXML<Unit>(Utilities.upath + l.Text);
            Unit tmp = gs.Party.units.Find(x => x.Name == u.Name);

            if (tmp == null)
            {
                gs.Party.units.Add(u);
                partyBox1.Controls.Add(l);
            }
        }

        private void partyBox2_DragDrop(object sender, DragEventArgs e)
        {
            int numControls = partyBox2.Controls.Count;
            
                
            Label l = new Label();
            l.Size = new Size(1, 1);
            l.Location = new Point(5, offset * numControls + offset);
            l.AutoSize = true;
            l.Text = e.Data.GetData(DataFormats.Text).ToString();
            l.Text = l.Text.Replace("_", " ");
           
             
             
            
            Unit u = Utilities.DeserializeXML<Unit>(Utilities.upath + l.Text);
            
            Unit tmp = gs.Party.units.Find(x => x.Name == u.Name);

            if (tmp == null)
            {
                gs.Party.units.Add(u);
                partyBox2.Controls.Add(l);

            }
        }
    }
}
