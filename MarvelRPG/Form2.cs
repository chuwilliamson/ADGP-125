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
            Utilities.updateTextBox(ref textBox1, ref p1);
            p2 = Utilities.DeserializeXML<Party>(path + n2);
            Utilities.updateTextBox(ref textBox2, ref p2);

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
                    if(textBox1.GetChildAtPoint(p) != null)
                    {
                        break;
                    }

                }
            }
        }


    }
}
