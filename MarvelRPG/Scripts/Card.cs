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

        public Card(string name, Size s, Point loc)
        {
       
            originalLoc = loc;
            current = new object();
            m_size = s;
            front = new PictureBox();
            back = new RichTextBox();
            front.Anchor = AnchorStyles.Left;
            back.Anchor = AnchorStyles.Left;
            front.BorderStyle = BorderStyle.FixedSingle;
            back.BorderStyle = BorderStyle.Fixed3D;
            front.Location = loc;
            front.Name = name;
            front.Size = s;
            front.SizeMode = PictureBoxSizeMode.StretchImage;
            front.TabIndex = 7;
            front.TabStop = false;

            back.Location = new Point(6, 19);
            back.Margin = new Padding(1);
            back.Multiline = true;
            back.Name = name + "_Back";
            back.TabIndex = 11;
            back.ReadOnly = true;
            back.Enabled = false;
            back.Text = "no text";
            back.Size = s;
            back.Location = loc;

             
            front.MouseMove += onMouseMove;
            front.MouseDown += onMouseDown;
            front.MouseUp += onMouseUp;
            //front.DragDrop += onMouseUp;
            front.QueryContinueDrag += onQueryContinueDrag;

            back.MouseMove += onMouseMove;
            back.MouseDown += onMouseDown;
            back.MouseUp += onMouseUp; 

            front.Cursor = Cursors.Hand;
            back.Cursor = Cursors.Hand;
            Flipped = false;

            Utilities.UpdateDescription(name, ref front, ref back);

        }
        public void onQueryContinueDrag(object o, QueryContinueDragEventArgs e)
        {
            switch(e.Action)
            {
                case DragAction.Cancel:
                    break;
                case DragAction.Drop:
                    Console.WriteLine("juhrop");
                    break;
                case DragAction.Continue:
                    break;
            } 
        }

        int xPos;
        int yPos;
        bool drag = false;
        public void onMouseDown(object o, MouseEventArgs e)
        {
            front.BringToFront();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    front.DoDragDrop(front.Name, DragDropEffects.Copy | DragDropEffects.Move);
                    break;
                case MouseButtons.Right:
                    Flipped = !Flipped;
                    break;
                default:
                    //    drag = true;

                    //    xPos = e.X;
                    //    yPos = e.Y;       
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
                    drag = false;
                    front.Location = originalLoc;
                    back.Location = front.Location;
                }
     

        }
        public void onMouseMove(object o, MouseEventArgs e)
        {
            Console.Write("\r{0},{1}", e.X, e.Y);
            //if (drag && o != null)
            //{
        
                  
            //}
            
        }
        private void onEnter(object o, EventArgs e)
        {
            current = o;
            PictureBox p = current as PictureBox;
            Console.WriteLine("Current: " + p.Name);
            front.BorderStyle = BorderStyle.Fixed3D;
            back.BorderStyle = BorderStyle.Fixed3D;
        }
        private void onLeave(object o, EventArgs e)
        {             
 
            front.BorderStyle = BorderStyle.FixedSingle;            
            back.BorderStyle = BorderStyle.FixedSingle;
            Console.WriteLine("leave" + Size.ToString());


        }
    


        public Control[] Controls
        {
            get
            {
                Control[] controls;
                controls = new Control[2];
                controls[0] = front;
                controls[1] = back;
                return controls;
            }

        }

        private Point originalLoc;
        private PictureBox front;
        private RichTextBox back;
        private bool flipped = false;
        public bool Flipped
        {
            get { return flipped; }
            set
            {
                flipped = value;
                (flipped == true ? (Action)back.BringToFront : front.BringToFront)();
            }
        }



        object current;
        private Size m_size;
        public Size Size
        {
            get { return m_size; }
        }

    }
}
