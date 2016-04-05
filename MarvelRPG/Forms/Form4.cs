using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarvelRPG
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        public void Form4_Load()
        {
            
            var values = Enum.GetValues(typeof(Characters));

            int num = 0;
            int scale = 1;
            ///236 x 459
            int width = 240 / scale;
            int height = 460 / scale;

            int xPadding = 5;
            int yPadding = 5;
            int xoffset = 0;
            int yoffset = 0;
 
            foreach (Enum v in values)
            {

                num++;
                string name = v.ToString();
                Point pos = new Point(xoffset + xPadding, yoffset + yPadding);
                Card c = new Card(name, new Size(width, height), pos);

                UI.CardLibrary.Add(name, c);

                if (num % 4 == 0)
                {
                    xoffset = 0;
                    yoffset += height + yPadding;
                }
                else
                    xoffset += width + xPadding; 

            }
           
          
 
            

        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            string ext = ".jpg";
            var values = Enum.GetValues(typeof(Characters));
            foreach(var v in values)
            {
                
                string name = v.ToString() + ext;
                listView1.Items.Add(null, name);
            }
            ColumnHeader header = new ColumnHeader();
            listView1.Scrollable = true;
            
            listView1.Alignment = ListViewAlignment.Left;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.RemoveAt(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
