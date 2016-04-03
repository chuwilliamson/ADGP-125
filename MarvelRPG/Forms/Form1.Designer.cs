namespace MarvelRPG
{
    partial class Form1
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.partyBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.clearParty_button = new System.Windows.Forms.Button();
            this.start_Button = new System.Windows.Forms.Button();
            this.partyBox2 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // partyBox1
            // 
            this.partyBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partyBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyBox1.Location = new System.Drawing.Point(782, 12);
            this.partyBox1.Name = "partyBox1";
            this.partyBox1.Size = new System.Drawing.Size(115, 250);
            this.partyBox1.TabIndex = 7;
            this.partyBox1.TabStop = false;
            this.partyBox1.Text = "Players";
            this.partyBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.partyBox1_DragDrop);
            this.partyBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.partyBox1_DragEnter);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(782, 691);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 25);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(782, 722);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(115, 25);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // clearParty_button
            // 
            this.clearParty_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearParty_button.Location = new System.Drawing.Point(782, 753);
            this.clearParty_button.Name = "clearParty_button";
            this.clearParty_button.Size = new System.Drawing.Size(115, 25);
            this.clearParty_button.TabIndex = 10;
            this.clearParty_button.Text = "Clear Party";
            this.clearParty_button.UseVisualStyleBackColor = true;
            this.clearParty_button.Click += new System.EventHandler(this.clearPartyButton_Click);
            // 
            // start_Button
            // 
            this.start_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start_Button.BackColor = System.Drawing.SystemColors.Control;
            this.start_Button.Location = new System.Drawing.Point(782, 784);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(115, 70);
            this.start_Button.TabIndex = 11;
            this.start_Button.Text = "Start";
            this.start_Button.UseVisualStyleBackColor = false;
            this.start_Button.Click += new System.EventHandler(this.startButton_Click);
            // 
            // partyBox2
            // 
            this.partyBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partyBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyBox2.Location = new System.Drawing.Point(782, 307);
            this.partyBox2.Name = "partyBox2";
            this.partyBox2.Size = new System.Drawing.Size(115, 250);
            this.partyBox2.TabIndex = 12;
            this.partyBox2.TabStop = false;
            this.partyBox2.Text = "Enemies";
            this.partyBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.partyBox2_DragDrop);
            this.partyBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.partyBox2_DragEnter);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Black_Cat.jpg");
            this.imageList1.Images.SetKeyName(1, "Black_Panther.jpg");
            this.imageList1.Images.SetKeyName(2, "Cable.jpg");
            this.imageList1.Images.SetKeyName(3, "Captain_Marvel.jpg");
            this.imageList1.Images.SetKeyName(4, "Card_Background.png");
            this.imageList1.Images.SetKeyName(5, "Deadpool.jpeg");
            this.imageList1.Images.SetKeyName(6, "Emma_Frost.jpg");
            this.imageList1.Images.SetKeyName(7, "Emma_Frost.png");
            this.imageList1.Images.SetKeyName(8, "Gambit.jpg");
            this.imageList1.Images.SetKeyName(9, "Hulk.jpg");
            this.imageList1.Images.SetKeyName(10, "Magneto.jpg");
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(34, 307);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 499);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(916, 862);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.partyBox2);
            this.Controls.Add(this.start_Button);
            this.Controls.Add(this.clearParty_button);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.partyBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Selection";
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.GroupBox partyBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button clearParty_button;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.GroupBox partyBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
    }
}

