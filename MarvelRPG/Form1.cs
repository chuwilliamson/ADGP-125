using System.Windows.Forms;
using System;
using HtmlAgilityPack;
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

        private void PopulateDescription(object s, EventArgs events)
        {


        }


        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            var webGet = new HtmlWeb();
            var document = webGet.Load(web_url.Text);
            string classValue = "title";
            var tags = document.DocumentNode.SelectNodes("//span[@class='" + classValue + "']");
            int count = 1;
            if (tags != null)
            {
                foreach (HtmlNode node in tags)
                {
                    web_info.Text += node.InnerHtml + ":" + node.InnerText + Environment.NewLine;
                    count++;
                }
            }
            else
                web_info.Text = "Could not get the web info";


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 