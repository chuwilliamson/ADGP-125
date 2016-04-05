using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarvelRPG
{
    public class Card : UserControl
    {
        int xPos;
        int yPos;
        //private int scale = 1;
        //private bool focus = false;
        //private PictureBox m_display;

        private PictureBox current;
        public ControlCollection CardControls
        {
            get
            {
           
                return Controls;
            }

        }

        private Point m_location;
        private PictureBox m_front;
        private RichTextBox m_back;
        private bool m_flipped = false;
        public bool Flipped
        {
            get { return m_flipped; }
            set
            {
                m_flipped = value;
                (m_flipped == true ? (Action)m_back.BringToFront : m_front.BringToFront)();
            }
        }

        private string m_name;

        protected string CardName
        {
            get { return m_name; }
        }
        private Size m_size;
        public Size CardSize
        {
            get { return m_size; }
        }


        /// <summary>
        /// card object to represent a card in the game
        /// </summary>
        public PictureBox Front
        {
            get
            {
                if (m_front == null)
                {
                    m_front = new PictureBox();
                    //m_front.Anchor = AnchorStyles.Left;
                    m_front.BorderStyle = BorderStyle.None;
                   // m_front.Location = m_location;
                    m_front.Name = m_name;
                    m_front.Size = m_size;
                    m_front.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                    //m_front.SizeChanged += onSizeChange;
                    m_front.MouseLeave += onMouseExit;
                    m_front.MouseEnter += onMouseEnter;
                    m_front.MouseMove += onMouseMove;
                    m_front.MouseDown += onMouseDown;
                    m_front.MouseUp += onMouseUp;
                    m_front.QueryContinueDrag += onQueryContinueDrag;
                    m_front.Cursor = Cursors.Hand;
                    m_front.Padding = new Padding(10);
                    m_front.BackgroundImage = global::MarvelRPG.Properties.Resources.Card_Background;
                    m_front.BackgroundImageLayout = ImageLayout.Stretch;
                    if (m_back != null)
                        m_back.Size = m_front.Size;
                }

                return m_front;
            }

        }

        public RichTextBox Back
        {
            get
            {
                if (m_back == null)
                {
                    m_back = new RichTextBox();
                    m_back.BorderStyle = BorderStyle.Fixed3D;
                   // m_back.Location = m_front.Location;
                    m_back.Margin = new Padding(1);
                    m_back.Multiline = true;
                    m_back.Name = m_name + "_Back";
                    m_back.ReadOnly = true;
                    m_back.Enabled = false;
                    m_back.Text = "no text";
                    m_back.Size = m_front.Size; 
                    m_back.Cursor = Cursors.Hand;

                }
                return m_back;
            }
        }

        public Card(string name, Size s, Point loc)
        {
            InitializeComponent();
            m_name = name;
            m_size = s;
            m_location = loc;
            Name = name;
            Size = s;
            Bounds = new Rectangle(loc, s);
            Location = loc;
            Left = loc.X;
            Top = loc.Y;
            Width = s.Width;
            Height = s.Height;
            
   
            xPos = loc.X;
            yPos = loc.Y;

            PictureBox p = Front;
            RichTextBox rt = Back;
            Controls.Add(p);
            Controls.Add(rt);

            Flipped = false;

            Utilities.UpdateDescription(name, ref p, ref rt);

        }
         
        #region Drag Events
        public void onQueryContinueDrag(object o, QueryContinueDragEventArgs e)
        {
            PictureBox p = o as PictureBox;
            switch (e.Action)
            {
                case DragAction.Cancel:
                    break;
                case DragAction.Drop:
                    m_front.Enabled = false;
                    Console.WriteLine("juhrop");
                    break;
                case DragAction.Continue:
                    
                   // p.Location = new Point(xPos, yPos);
                    break;
            }
        }
        #endregion Drag Events

        #region Mouse Events
        public void onMouseDown(object o, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    m_front.DoDragDrop(m_front.Name, DragDropEffects.Copy | DragDropEffects.Move);
                   
                    break;
                case MouseButtons.Right:
                    Flipped = !Flipped;
                    break;
                default:
                    break;
            }
        }
        public void onMouseUp(object o, MouseEventArgs e)
        {
            Console.WriteLine("mouse up");
            if (e.Button == MouseButtons.Right)
                Flipped = !Flipped;

            if (e.Button == MouseButtons.Left)
            {   //drag = false;
                //m_front.Location = m_location;

            }
        }
        public void onMouseMove(object o, MouseEventArgs e)
        {
            //current = o as PictureBox;

            ////focus = true;
            //xPos = e.X;
            //yPos = e.Y;
            //Point pos = new Point(xPos, yPos);
            //Console.Write("\rPos: {0}, {1}", pos, current.Name);


        }
        private void onMouseEnter(object o, EventArgs e)
        {
            //Console.WriteLine("Enter: " + this.CardName);
            //current = o as PictureBox;


            //scale = 3;
            //Form f = Form.ActiveForm;
            //Size s = new Size(Size.Width * scale, Size.Height * scale);
            //Point center = new Point((f.Width / 2), (f.Height / 2));


            //m_display = new PictureBox();
            //m_display.Image = Front.Image;
            //m_display.Name = "display";
            //m_display.Size = f.Size;

            ////int left = center.X - (m_display.Size.Width / 2);
            ////int top = center.Y - (m_display.Size.Height / 2);

            ////m_display.Left = left;
            ////m_display.Top = top;
            //m_display.SizeMode = PictureBoxSizeMode.AutoSize;
            m_front.BorderStyle = BorderStyle.Fixed3D;
            //m_display.BorderStyle = BorderStyle.Fixed3D;
            //Form.ActiveForm.Controls.Add(m_display);

            //m_front.SendToBack();
            //m_back.SendToBack();


        }
        private void onMouseExit(object o, EventArgs e)
        {
            //Form.ActiveForm.Controls.Remove(m_display);
            //m_front.BorderStyle = BorderStyle.FixedSingle;
            m_front.BorderStyle = BorderStyle.None;
            //Console.WriteLine(Form.ActiveForm.Controls.Count);
            //Console.WriteLine("Exit: " + this.CardName);
        }
        #endregion Mouse Events


        protected void SetActive(bool state)
        {
            if (state)
            {
                Front.BringToFront();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Card
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MarvelRPG.Properties.Resources.Card_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(240, 460);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(236, 459);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.ResumeLayout(false);

        }
    }
}
