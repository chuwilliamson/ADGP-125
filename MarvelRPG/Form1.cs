using System.Windows.Forms;
using System;
using System.Linq;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace MarvelRPG
{

    public partial class Form1 : Form
    {
        CharInfo tmpChar;
        private string currentSelection = "";
        public Form1()
        {
            InitializeComponent(); 
            //initialize your game
            //have the gamestate run

        }
 

        private void RadioButtonChecked(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            currentSelection = rb.Text;
            UpdateDescription(currentSelection);
        }


        private void Confirm_Click(object sender, EventArgs e)
        {             
            Utilities.SerializeXML(currentSelection, (object)tmpChar);
            UpdateDescription(currentSelection);
        }
        [Serializable()]
        internal class CharInfo
        {
            public CharInfo(int d, int s, int f, int spd, int e, int i) 
            {
                Durability = d;
                Strength = s;
                Fighting = f;
                Speed = spd;
                Energy = e;
                Intelligence = i;
            }
            int Durability;
            int Strength;
            int Fighting;
            int Speed;
            int Energy;
            int Intelligence;
        }
        private void UpdateDescription(string info)
        {
            web_info.Text = "";
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

            if (docTable != null)
            {
                foreach (HtmlNode table in docTable)
                {
                    if (table.SelectNodes("tr") != null)
                        foreach (HtmlNode row in table.SelectNodes("tr"))
                        {
                            if (row.SelectNodes("td") != null)
                                foreach (HtmlNode cell in row.SelectNodes("td"))
                                {
                                    Regex regex = new Regex
                                        ("Durability|Strength|Fighting Skills|Speed|Energy Projection|Intelligence");
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
                web_info.Text = "Could not get the web info";
            }
            string test = new String(charInfo.Where(x => Char.IsDigit(x)).ToArray());
            int[] nums = new int[test.Count()];
            for(int i = 0; i < test.Count(); i++)
            {                
                nums[i] = int.Parse(test[i].ToString());
            }
            
            ///create a temporary character
            tmpChar = new CharInfo(nums[0], nums[1], nums[2], nums[3], nums[4], nums[5]); 
            
            ///formattings
            charInfo = charInfo.Replace("Fighting Skills", "Fighting");
            charInfo = charInfo.Replace("Energy Projection", "Energy");
            charInfo = charInfo.Replace("Bio:", Environment.NewLine + "Bio:" + Environment.NewLine + "    " );
            web_info.Text = charInfo;

        }
        
   
    }
}
