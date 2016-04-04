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
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.start_Button = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.partyBox1 = new System.Windows.Forms.GroupBox();
            this.partyBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(6, 19);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 25);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Location = new System.Drawing.Point(6, 50);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(136, 25);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // start_Button
            // 
            this.start_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start_Button.BackColor = System.Drawing.SystemColors.Control;
            this.start_Button.Location = new System.Drawing.Point(6, 81);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(136, 39);
            this.start_Button.TabIndex = 11;
            this.start_Button.Text = "Start";
            this.start_Button.UseVisualStyleBackColor = false;
            this.start_Button.Click += new System.EventHandler(this.startButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.start_Button);
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Location = new System.Drawing.Point(999, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // partyBox1
            // 
            this.partyBox1.Location = new System.Drawing.Point(999, 6);
            this.partyBox1.Name = "partyBox1";
            this.partyBox1.Size = new System.Drawing.Size(148, 250);
            this.partyBox1.TabIndex = 14;
            this.partyBox1.TabStop = false;
            this.partyBox1.Text = "groupBox2";
            // 
            // partyBox2
            // 
            this.partyBox2.Location = new System.Drawing.Point(999, 262);
            this.partyBox2.Name = "partyBox2";
            this.partyBox2.Size = new System.Drawing.Size(148, 250);
            this.partyBox2.TabIndex = 15;
            this.partyBox2.TabStop = false;
            this.partyBox2.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 999);
            this.Controls.Add(this.partyBox2);
            this.Controls.Add(this.partyBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 1038);
            this.MinimumSize = new System.Drawing.Size(1200, 1038);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Selection";
            this.Load += new System.EventHandler(this.Form1Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox partyBox1;
        private System.Windows.Forms.GroupBox partyBox2;
    }
}

