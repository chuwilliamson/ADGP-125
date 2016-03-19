
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using HtmlAgilityPack;

namespace MarvelRPG
{
    enum Characters
    {
        Psylocke, Hulk, Rogue, Thor, Juggernaut
    }

    public partial class Form1 : Form
    {
        private Party party = new Party();
        private List<string> validClasses = new List<string>();       
        private Unit tmpChar;        
        private string currentSelection = "";

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
                rb.Name = "radioButton_"+v.ToString();
                rb.Size = new System.Drawing.Size(68, 21);
                rb.TabIndex = 2;
                rb.TabStop = true;
                rb.Text = name;
                rb.UseVisualStyleBackColor = true;
                rb.CheckedChanged += new System.EventHandler(RadioButtonChecked);
                classGroupBox1.Controls.Add(rb);
                offset += 25;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButtonChecked(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            currentSelection = rb.Text;
            UpdateDescription(currentSelection);
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

                default:
                    break;
            }

            //clear description

            string marvelData = "http://marvelheroes.wikia.com/wiki/";
            var webGet = new HtmlWeb();
            var document = webGet.Load(marvelData + currentSelection);
            var docTable = document.DocumentNode.SelectNodes("//table");
            string charInfo = "";
            Regex regex = new Regex("Durability|Strength|Fighting Skills|Speed|Energy Projection|Intelligence");
            if (docTable != null)
            {
                foreach (HtmlNode table in docTable)
                {
                    foreach (HtmlNode row in table.SelectNodes("tr"))
                    {
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

            }
            else
            {
                webTextBox1.Text = "Could not get the web info";
            }
            string test = new String(charInfo.Where(x => Char.IsDigit(x)).ToArray());
            int[] nums = new int[test.Count()];
            for (int i = 0; i < test.Count(); i++)
            {
                nums[i] = int.Parse(test[i].ToString());
            }

            ///create a temporary character
            tmpChar = new Unit(nums[0], nums[1], nums[2], nums[3], nums[4], nums[5]);
            tmpChar.Name = currentSelection;

            ///formattings
            charInfo = charInfo.Replace("Fighting Skills", "Fighting");
            charInfo = charInfo.Replace("Energy Projection", "Energy");
            charInfo = charInfo.Replace("Bio:", Environment.NewLine + "Bio:" + Environment.NewLine);
            webTextBox1.Text = charInfo;

        }
 
        private void saveButton_Click(object sender, EventArgs e)
        {
            Utilities.SerializeXML("Party", party);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
           party =  Utilities.DeserializeXML<Party>("Party");
            UpdateParty();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;            
            Unit toRemove = party.units.Find(u => u.Name == rb.Text);
            party.units.Remove(toRemove);

        }

        private void UpdateParty()
        {
            int offset = 25;
            foreach(Unit u in party.units)
            {
                Label l = new Label();
                
                l.Location = new System.Drawing.Point(6, offset);
                l.Size = new System.Drawing.Size(68, 21);
                l.AutoSize = true;
                l.Text = u.Name;
                offset += 25;
                partyBox.Controls.Add(l);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (party.units == null)
                party.units.Add(tmpChar);
            if(!party.units.Contains(tmpChar) )
                party.units.Add(tmpChar);
            UpdateParty();
        }
    }
}
