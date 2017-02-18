using System; 
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;
using HtmlAgilityPack;  

namespace MarvelRPG
{
    public static class Utilities
    {
        public readonly static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\MarvelRPG\";        
        public readonly static string apath = path + @"\Abilities\";
        public readonly static string upath = path + @"\Units\";



        public static Unit FetchUnit(string name)
        {
            string marvelData = "http://marvelheroes.wikia.com/wiki/";
            var webGet = new HtmlWeb();

            var document = webGet.Load(marvelData + name);
            var docTable = document.DocumentNode.SelectNodes("//table");
            string charInfo = "";
            Regex regex = new Regex("Durability|Strength|Fighting Skills|Speed|Energy Projection|Intelligence");
            if (docTable == null)
                return new Unit(n: "null", d: 1, s: 1, f: 1, spd: 1, e: 1, i: 1);

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
            if (test == "")//if the website died and doesn't have the character b/c they are the worst... srs
                return new Unit(name, 1, 1, 1, 1, 1, 1);
            int[] nums = new int[test.Count()];
            
            for (int i = 0; i < test.Count(); i++)
            {
                nums[i] = int.Parse(test[i].ToString());
            }

            ///create a temporary character
            return new Unit(name, nums[0], nums[1], nums[2], nums[3], nums[4], nums[5]);

        }


        public static Tuple<string,string> UpdateDescription<T>(string name, ref PictureBox pb, ref T tb)
        {
            //pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(name);
            //if (pb.Image == null)
            //    pb.Image = MarvelRPG.Properties.Resources.noimage;
          
           

            name = name.Replace("_", " ");
            ///create a temporary character
            string path = Utilities.path + @"\Units\";
            Unit tmpChar = new Unit();
          
            //GameState.Instance.CharacterLibrary[name];

            string s0 = name + Environment.NewLine + Environment.NewLine;
            string s1 = "Durability: " + tmpChar.Durability.ToString() + Environment.NewLine;
            string s2 = "Fighting: " + tmpChar.Fighting.ToString() + Environment.NewLine;
            string s3 = "Energy: " + tmpChar.Energy.ToString() + Environment.NewLine;
            string s4 = "Speed: " + tmpChar.Speed.ToString() + Environment.NewLine;
            string s5 = "Intelligence " + tmpChar.Intelligence.ToString() + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            string s6 = "HP: " + tmpChar.Health.ToString() + Environment.NewLine;
            string s7 = "ABILITIES:" + Environment.NewLine;
            

            foreach (Ability a in tmpChar.Abilities)
                s7 += a.Name + Environment.NewLine;
             
            return  new Tuple<string,string>(s0 + s6 + s1 + s2 + s3 + s4 + s5, s7);
      
        }

 
        public static void updateBox<T>(ref T box, ref Party p, bool clear = false)
        {
            Type type = typeof(T);

            var o = new Control();
            //hashtag begin janky
            if (type == typeof(TextBox)) o = box as TextBox;
            if (type == typeof(GroupBox)) o = box as GroupBox;
            
            o.Controls.Clear();
           
            //add the labels
            if (o != null )
            {
                int offset = 25;
                foreach (Unit u in p.units)
                {
                    Label l = new Label();
                    l.Location = new System.Drawing.Point(0, offset);
                    l.Size = new System.Drawing.Size(70, 20);
                    l.AutoSize = true;
                    l.Text = u.Name;
                    offset += 25;
                    o.Controls.Add(l);
                }
            } 
        }


        

        /// <summary>
        /// save stream to xml
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="path"></param>
        public static void SerializeXML<T>(string s, T t, string path)
        {
            if (Directory.Exists(path))
            {
                using (FileStream fs = File.Create(path + s + ".xml"))
                {
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        serializer.Serialize(fs, t);
                        fs.Close();
                    }
                    catch (XmlException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Exception object Line, pos: (" + e.LineNumber + "," + e.LinePosition + ")");
                        throw e;

                    }
                }
            }
            else
            {
                string appName = System.Windows.Forms.Application.ProductName;
                Directory.CreateDirectory(path + appName);
            }

        }

        /// <summary>
        /// deserialize from a path
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="s"></param>
        /// <returns></returns>
        public static T DeserializeXML<T>(string s)
        {

            T t; //We will use the as the return value      
            if (!s.Contains(".xml"))
                s += ".xml";
            using (FileStream fs = File.OpenRead(s))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                t = (T)deserializer.Deserialize(fs);
                fs.Close();
            }

            return t;
        }

    }
}
