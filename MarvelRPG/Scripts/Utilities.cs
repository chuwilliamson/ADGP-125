using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace MarvelRPG
{
    public static class Utilities
    {
        public static void updateTextBox(ref GroupBox box, ref Party p, bool clear = false)
        {
            box.Controls.Clear();
            if (!clear)
            {
                int offset = 25;
                foreach (Unit u in p.units)
                {
                    System.Windows.Forms.Label l = new System.Windows.Forms.Label();
                    l.Location = new System.Drawing.Point(0, offset);
                    l.Size = new System.Drawing.Size(70, 20);
                    l.AutoSize = true;
                    l.Text = u.Name;
                    offset += 25;
                    box.Controls.Add(l);
                }
            }
        }

        public static void addLabels<T>(List<T> list, ref object to)
        {

            int offset = 25;
            foreach (T u in list)
            {
                System.Windows.Forms.Label l = new System.Windows.Forms.Label();
                l.Location = new System.Drawing.Point(0, offset);
                l.Size = new System.Drawing.Size(70, 20);
                l.AutoSize = true;
                Label v = u as Label;
                l.Text = v.Name;
                offset += 25;
                TextBox tb = to as TextBox;
                GroupBox gb = to as GroupBox;
                tb.Controls.Add(l);
                gb.Controls.Add(l);
            }

        }
        public static void updateBox(ref object box, ref Party p, bool clear = false)
        {
            TextBox tb = box as TextBox;
            GroupBox gb = box as GroupBox;            
            
            if(gb != null)
                addLabels<Unit>(p.units, ref box);
            

          

        }
        public static void updateTextBox(ref TextBox box, ref Party p, bool clear = false)
        {
            box.Controls.Clear();
            if (!clear)
            {
                int offset = 25;
                foreach (Unit u in p.units)
                {
                    System.Windows.Forms.Label l = new System.Windows.Forms.Label();
                    l.Location = new System.Drawing.Point(0, offset);
                    l.Size = new System.Drawing.Size(70, 20);
                    l.AutoSize = true;
                    l.Text = u.Name;
                    offset += 25;
                    box.Controls.Add(l);
                }
            }
        }
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
