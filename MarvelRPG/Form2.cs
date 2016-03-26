using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string path = Form1.savePath + @"/Parties/";
            p1 = Utilities.DeserializeXML<Party>( path + n1);
            updateParty(ref textBox1, ref p1);
            p2 = Utilities.DeserializeXML<Party>(path + n2);
            updateParty(ref textBox2, ref p2);

            if (textBox1.HasChildren)
                MessageBox.Show("has children");
            else MessageBox.Show("no children");
            int height = textBox1.Height;
            int width = textBox1.Width;
            for(int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    Point p = new Point(i, j);
                }
            }
        }

        private void updateParty(ref TextBox box, ref Party p, bool clear = false)
        {
            box.Controls.Clear();
            if (!clear)
            {
                int offset = 25;
                foreach (Unit u in p.units)
                {
                    Label l = new Label();
                    l.Location = new System.Drawing.Point(6, offset);
                    l.Size = new System.Drawing.Size(68, 21);
                    l.AutoSize = true;
                    l.Text = u.Name;
                    offset += 25;
                    box.Controls.Add(l);
                }
            }
        }
    }
}
