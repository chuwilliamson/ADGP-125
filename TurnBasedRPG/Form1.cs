using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TurnBasedRPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            damage_chart.ChartAreas[0].AxisY.Maximum = 20;
            damage_chart.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void attack_button_Click(object sender, EventArgs e)
        {
          
            Random rand = new Random(); //reuse this if you are generating many
            double u1 = rand.NextDouble(); //these are uniform(0,1) random doubles
            double u2 = rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            
            int total = damage_chart.Series["Series1"].Points.Count;
            double sum = damage_chart.Series["Series1"].Points[0].YValues[0];
            
            //double randNormal = mean + stdev * randStdNormal; //random normal(mean,stdDev^2)

            damage_chart.Series["Damage Roll"].Points.AddY(randNormal);
            
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            damage_chart.Series["Damage Roll"].Points.Clear();
        }

    

    }
}
