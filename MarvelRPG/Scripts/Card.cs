using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarvelRPG
{
    class Card
    {
        /// <summary>
        /// card object to represent a card in the game
        /// </summary>
        protected PictureBox Front
        {
            get
            {
                if (m_front == null)
                {
                    m_front = new PictureBox();
                    //m_front.Anchor = AnchorStyles.Left;
                    m_front.BorderStyle = BorderStyle.FixedSingle;
                    m_front.Location = m_location;
                    m_front.Name = m_name;
                    m_front.Size = m_size;
                    m_front.SizeMode = PictureBoxSizeMode.StretchImage;
                    m_front.MaximumSize = new Size(540, 960);
                    m_front.MinimumSize = new Size(540 / 4, 960 / 4);
                    //m_front.SizeChanged += onSizeChange;
                    m_front.MouseLeave += onMouseExit;
                    m_front.MouseEnter += onMouseEnter;
                    m_front.MouseMove += onMouseMove;
                    m_front.MouseDown += onMouseDown;
                    m_front.MouseUp += onMouseUp;
                    m_front.QueryContinueDrag += onQueryContinueDrag;
                    m_front.Cursor = Cursors.Hand;
                    if (m_back != null)
                        m_back.Size = m_front.Size;
                }

                return m_front;
            }

        }

        protected RichTextBox Back
        {
            get
            {
                if (m_back == null)
                {
                    m_back = new RichTextBox(); 
                    m_back.BorderStyle = BorderStyle.Fixed3D;
                    m_back.Location = m_front.Location;
                    m_back.Margin = new Padding(1);
                    m_back.Multiline = true;
                    m_back.Name = m_name + "_Back";
                    m_back.ReadOnly = true;
                    m_back.Enabled = false;
                    m_back.Text = "no text";
                    m_back.Size = m_front.Size;
                    m_back.Location = m_location;                    
                    m_back.Cursor = Cursors.Hand;

                }
                return m_back;
            }
        }
        public Card(string name, Size s, Point loc)
        {
            m_name = name;
            m_size = s;
            m_location = loc;

            PictureBox p = Front;
            RichTextBox rt = Back;
            this.Controls[0] = p;
            this.Controls[1] = rt;

            Flipped = false;

            Utilities.UpdateDescription(name, ref m_front, ref m_back);

        }
        public void onQueryContinueDrag(object o, QueryContinueDragEventArgs e)
        {
            switch (e.Action)
            {
                case DragAction.Cancel:
                    break;
                case DragAction.Drop:
                    m_front.Enabled = false;
                    Console.WriteLine("juhrop");
                    break;
                case DragAction.Continue:
                    PictureBox p = o as PictureBox;
                    p.Location = new Point(xPos, yPos);
                    break;
            }
        }

        public void onSizeChange(object o, EventArgs e)
        {
            m_back.Size = m_front.Size;
            m_back.Location = m_front.Location;
        }

        //int xPos;
        //int yPos;
        //bool drag = false;
        public void onMouseDown(object o, MouseEventArgs e)
        {
            //m_front.BringToFront();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    m_front.DoDragDrop(m_front.Name, DragDropEffects.Copy | DragDropEffects.Move);
                    m_front.Enabled = false;
                    break;
                case MouseButtons.Right:
                    Flipped = !Flipped;
                    break;
                default:
                    //    drag = true;

                  
                    break;
            }
        }

        public void onMouseUp(object o, MouseEventArgs e)
        {
            Console.WriteLine("mouse up");
            if (e.Button == MouseButtons.Right)
                Flipped = !Flipped;

            if (e.Button == MouseButtons.Left)
            {
                //drag = false;
                m_front.Location = m_location;

            }


        }

        protected void SetActive(bool state)
        {
            if (state)
            {
                Front.BringToFront();
            }
        }
        int xPos, yPos;
        public void onMouseMove(object o, MouseEventArgs e)
        {
            current = o as PictureBox;
            
            focus = true;
            xPos = e.X;
            yPos = e.Y;
            Point pos = new Point(xPos, yPos);
            Console.Write("\rPos: {0}, {1}",pos,current.Name);
            
                  
        }
        private int scale = 1;
        private bool focus = false;
        private PictureBox m_display;

        private PictureBox current;
        private void onMouseEnter(object o, EventArgs e)
        {        Console.WriteLine("Enter: " + this.Name);
                current = o as PictureBox;
            
          
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
            
            
            Form.ActiveForm.Controls.Remove(m_display);
            m_front.BorderStyle = BorderStyle.FixedSingle;
            m_front.BringToFront();
            Console.WriteLine(Form.ActiveForm.Controls.Count);
            Console.WriteLine("Exit: " + this.Name);
           
 

        }



        public Control[] Controls
        {
            get
            {
                Control[] controls;
                controls = new Control[2];
                controls[0] = m_front;
                controls[1] = m_back;
                return controls;
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
        protected string Name
        {
            get { return m_name; }
        }
        private Size m_size;
        public Size Size
        {
            get { return m_size; }
        }

    }
}
