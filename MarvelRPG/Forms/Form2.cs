using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using MarvelRPG.Singletons;
using System.Xml.Serialization;
using System.IO;

namespace MarvelRPG
{
    public class Combat
    {
        public Combat() { }
        private static Combat m_instance;
        public static Combat Instance
        {
            get
            {
                if(m_instance == null)
                {
                    m_instance = new Combat();
                }
                return m_instance;
            }
        }
        public Party EnemyParty { get; set; }
        public Party PlayerParty { get; set; }

    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Combat combat;

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Card> Cards = new List<Card>(); 
            this.Text = "Combat"; 
        }
        private void InitForm()
        {
            
            using(var u1 = GameState.Instance.PlayerParty.units.GetEnumerator())
            using(var u2 = GameState.Instance.PlayerParty.units.GetEnumerator())
            {
                while(u1.MoveNext() && u2.MoveNext())
                {
                    listView1.Controls.Add(UI.CardLibrary[u1.Current.Name]);
                    listView2.Controls.Add(UI.CardLibrary[u2.Current.Name]);
                    UI.CardLibrary[u1.Current.Name].Dock = DockStyle.Left;                    
                    UI.CardLibrary[u2.Current.Name].Dock = DockStyle.Left;
                }
            }
                
        }
        public static T Deserialize<T>(string fileName) where  T : new()
        {
            var serializer = new  XmlSerializer(typeof(T));
            var path = Environment.CurrentDirectory + "../Saves/" + fileName + ".xml";
            using(var reader = new StreamReader(path))
                return (T)serializer.Deserialize(reader);            
        }

        private static void onAttackClick(object o, EventArgs e)
        {
        }
        private static void onSkillClick(object o, EventArgs e)
        {
        }
        private void onEndTurnClick(object o, EventArgs e)
        {  
        }
        private static void onFlipClick(object o, EventArgs e)
        {
            Console.WriteLine("flip");
            current.Flipped = !current.Flipped;
        }

        /// <summary>
        /// when something is clicked they are funneled through this function
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void onClick(object o, EventArgs e)
        {

            Button b = (Button)o;
            if(b == null)
                return;

            string name = b.Text;
            Console.Write("Button.Text: " + name + "\n");


            //buttons that do not feed fsm
            if(name == "Flip")
            {
                return;
            }

            //buttons that feed the fsm
            if(name == "Attack")
            {
                Form4 target = new Form4();
                target.Controls.Add(MakeBox());
                target.ShowDialog();
            } 
        }
        private void pauseButton_Click(object sender, EventArgs e)
        {
            Form3 pause = new Form3();
            pause.ShowDialog();
        }

 
        /// <summary>
        /// make a button 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private Button MakeButton(string name, Point p)
        {

            Button b = new Button();
            b.Location = p;
            b.Name = name + "_Button";
            b.Size = new Size(125, 35);
            b.TabIndex = 12;
            b.Text = name;
            b.UseVisualStyleBackColor = true;
            b.Anchor = AnchorStyles.Top;

            return b;


        }
        /// <summary>
        /// make a group box with labels
        /// </summary>
        /// <returns></returns>
        private GroupBox MakeBox()
        {
            GroupBox gb = new GroupBox();
            gb.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gb.Location = new Point(5, 5);
            gb.Name = "classGroupBox1";
            gb.Size = new Size(250, 200);
            gb.TabIndex = 1;
            gb.TabStop = false;
            gb.Text = "Enemies";
            int offset = 0;
            if(combat != null)
            {
                foreach(Unit u in combat.EnemyParty.units)
                {
                    //validClasses.Add(v.ToString());
                    string name = u.Name.ToString();
                    RadioButton rb = new RadioButton();
                    rb.AutoSize = true;
                    rb.Location = new Point(6, offset + 25);
                    rb.Name = "radioButton_" + name;
                    rb.Size = new Size(68, 21);
                    rb.TabIndex = 2;
                    rb.TabStop = true;
                    rb.Text = name;
                    rb.UseVisualStyleBackColor = true;
                    gb.Controls.Add(rb);
                    offset += 25;
                }

                Button ok = MakeButton("ok", new Point(gb.Size.Width - 125, gb.Size.Height - 35));
                Button cancel = MakeButton("cancel", new Point(0, gb.Size.Height - 35));
                ok.Click += targetSelected;
                cancel.Click += targetSelected;

                gb.Controls.Add(ok);
                gb.Controls.Add(cancel);

                ok.BringToFront();
                cancel.BringToFront();
            }

            Console.WriteLine(gb.Name);
            Console.WriteLine(gb.Location);



            return gb;
        }

        private void targetSelected(object o, EventArgs e)
        {
            Console.WriteLine("target selected");
            Button b = o as Button;
            Form f = b.FindForm();
            f.Close();
        }

        //private TestCombat combat;
        //private Card left, right;
        private static Card current;
        //private ActionGroup playerActions;
        //private ActionGroup enemyActions;




    }
}
