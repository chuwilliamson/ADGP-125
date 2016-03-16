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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     

        private void RadioButtonChecked(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Name)
            {
                case "radioButton1":
                    pictureBox1.Image = MarvelRPG.Properties.Resources.Hulk_small;
                    break;
                case "radioButton2":
                    pictureBox1.Image = MarvelRPG.Properties.Resources.Psylocke_small;
                    break;
                default:
                    break;
            }
        }
        
        private void PopulateStuff(object s, EventArgs events)
        {
            Abilities.Slam sa = Abilities.Slam.instance;
            label1.Text = "SLAM DAMAGE" + sa.Damage.ToString();                        
            chart1_trashcan.Series["student_heights"].Points.AddY(sa.Damage);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_trashcan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
