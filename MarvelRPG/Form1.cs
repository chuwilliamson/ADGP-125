
using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

using HtmlAgilityPack;

namespace MarvelRPG
{

    public partial class Form1 : Form
    {

        private Party party = new Party();
        private List<string> validClasses = new List<string>();
        private Dictionary<string, Unit> CharacterLibrary = new Dictionary<string, Unit>();
        private Dictionary<string, Abilities> AbilityLibrary = new Dictionary<string, Abilities>();
        private Abilities abilities = new Abilities();
        private string currentSelection = "";

        public readonly static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\MarvelRPG\";


        private void Form1Load(object sender, EventArgs e)
        {

            var values = Enum.GetValues(typeof(Characters));
            int offset = 25;
            foreach (Enum v in values)
            {
                validClasses.Add(v.ToString());
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

            GenerateClasses();
            GenerateAbilities();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateAbilities()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\My Games\" + System.Windows.Forms.Application.ProductName + @"\Abilities\";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            abilities = Utilities.DeserializeXML<Abilities>(path + "Abilities");

            if (abilities != null)
            {
                foreach (Ability ability in abilities.Members)
                {
                    if (AbilityLibrary.ContainsKey(ability.Character))
                        AbilityLibrary[ability.Character].Add(ability);
                    else
                        AbilityLibrary.Add(ability.Character, new Abilities(ability));
                }

                return;
            }

            int MAXPOWERS = 1330;
            for (int i = 1; i <= MAXPOWERS; ++i)
            {
                //not sure if this works because i'm in the car with no internet
                //check this later b/c it looks alot cleaner to put the web request in the constructor
                Ability ability = new Ability(i.ToString());
                if (ability != null)
                {
                    abilities.Members.Add(ability);

                    if (AbilityLibrary.ContainsKey(ability.Character))
                        AbilityLibrary[ability.Character].Add(ability);
                    else
                        AbilityLibrary.Add(ability.Character, new Abilities(ability));
                }
            }

            Utilities.SerializeXML("Abilities", abilities, path);
        }

        private void GenerateClasses()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\My Games\" + System.Windows.Forms.Application.ProductName + @"\Units\";
            //generate the classes based on information on application startup
            //1330is number of abilities
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            foreach (String s in validClasses)
            {
                string unitFile = path + s + ".xml";
                Unit u = (File.Exists(unitFile)) ? Utilities.DeserializeXML<Unit>(s) : FetchUnit(s);

                CharacterLibrary.Add(s, u);
                Utilities.SerializeXML(s, u, path);
            }
        }



        private Unit FetchUnit(string name)
        {
            string marvelData = "http://marvelheroes.wikia.com/wiki/";
            var webGet = new HtmlWeb();

            var document = webGet.Load(marvelData + name);
            var docTable = document.DocumentNode.SelectNodes("//table");
            string charInfo = "";
            Regex regex = new Regex("Durability|Strength|Fighting Skills|Speed|Energy Projection|Intelligence");
            if (docTable == null)
                return new Unit(1, 1, 1, 1, 1, 1);

            foreach (HtmlNode table in docTable)
            {
                if (table.SelectNodes("tr") != null)
                    foreach (HtmlNode row in table.SelectNodes("tr"))
                    {
                        if (row.SelectNodes("td") != null)
                            foreach (HtmlNode cell in row.SelectNodes("td"))
                            {
                                if (regex.IsMatch(cell.InnerText))
                                    charInfo += cell.InnerText;

                                //format for their wiki is all jacked up
                                //Durability: \n &#160; 5 is the format...
                                if (cell.InnerText.Contains("&#160; "))
                                {
                                    string strip = cell.InnerText.Replace("&#160; ", "").Replace("\n", "");
                                    charInfo += strip + Environment.NewLine;
                                }
                            }
                    }
            }



            string test = new String(charInfo.Where(x => Char.IsDigit(x)).ToArray());
            int[] nums = new int[test.Count()];
            for (int i = 0; i < test.Count(); i++)
            {
                nums[i] = int.Parse(test[i].ToString());
            }

            ///create a temporary character
            return new Unit(nums[0], nums[1], nums[2], nums[3], nums[4], nums[5], name);

        }

        private void UpdateDescription(string info)
        {
            webTextBox1.Text = "";
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = null;

            switch (currentSelection)
            {
                case "Hulk":
                    pictureBox1.Image = MarvelRPG.Properties.Resources.Hulk_small;
                    break;
                case "Psylocke":
                    pictureBox1.Image = MarvelRPG.Properties.Resources.Psylocke_small;
                    break;
                case "Rogue":
                    pictureBox1.Image = MarvelRPG.Properties.Resources.Rogue_small;
                    break;
                case "Thor":
                    pictureBox1.Image = MarvelRPG.Properties.Resources.Thor_small;
                    break;
                case "Wolverine":
                    pictureBox1.Image = MarvelRPG.Properties.Resources.Wolverine_small;
                    break;
                default:
                    break;
            }


            ///create a temporary character
            string path = savePath + @"\Units\";
            Unit tmpChar = CharacterLibrary[currentSelection];
            Abilities tmpAbl = AbilityLibrary[currentSelection];
            string s0 = currentSelection + Environment.NewLine + Environment.NewLine;
            string s1 = "Durability: " + tmpChar.Durability.ToString() + Environment.NewLine;
            string s2 = "Fighting: " + tmpChar.Fighting.ToString() + Environment.NewLine;
            string s3 = "Energy: " + tmpChar.Energy.ToString() + Environment.NewLine;
            string s4 = "Speed: " + tmpChar.Speed.ToString() + Environment.NewLine;
            string s5 = "Intelligence " + tmpChar.Intelligence.ToString() + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            string s6 = "ABILITIES:" + Environment.NewLine;

            foreach (Ability a in tmpAbl.Members)
                s6 += a.Name + Environment.NewLine;

            webTextBox1.Text = s0 + s1 + s2 + s3 + s4 + s5 + s6;

        }

        #region events

        private void radioButton_Check(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            currentSelection = rb.Text;
            UpdateDescription(currentSelection);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string path = savePath + @"Parties\";
            if (Directory.Exists(path))
                saveFileDialog.InitialDirectory = path;
            saveFileDialog.Filter = "XML Files | *.xml";
            saveFileDialog.DefaultExt = "xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(saveFileDialog.FileName);
                fileName = fileName.Replace(".xml", "");
                Utilities.SerializeXML(fileName, party, path);
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            party.units.Clear();
            string fileName;
            OpenFileDialog selectFileDialog = new OpenFileDialog();
            string path = savePath + @"Parties\";

            selectFileDialog.InitialDirectory = path;
            selectFileDialog.Filter = "XML Files | *.xml";
            selectFileDialog.DefaultExt = "xml";

            if (selectFileDialog.ShowDialog() != DialogResult.OK)
                return;

            fileName = selectFileDialog.FileName;
            fileName = fileName.Replace(".xml", "");

            party = Utilities.DeserializeXML<Party>(fileName);

            Utilities.updateTextBox(ref webTextBox1, ref party);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Unit toRemove = party.units.Find(u => u.Name == currentSelection);
            if (toRemove != null)
                party.units.Remove(toRemove);

            Utilities.updateTextBox(ref partyBox, ref party);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string path = savePath + @"/Units/";
            Unit u = Utilities.DeserializeXML<Unit>(path + currentSelection);

            Unit tmp = party.units.Find(x => x.Name == u.Name);
            if (tmp == null)
                party.units.Add(u);

            Utilities.updateTextBox(ref partyBox, ref party);
        }

        #endregion events




    }
}
