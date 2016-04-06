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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.start_Button = new System.Windows.Forms.Button();
            this.buttonBox = new System.Windows.Forms.GroupBox();
            this.partyBox1 = new System.Windows.Forms.GroupBox();
            this.partyBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBox.SuspendLayout();
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
            // buttonBox
            // 
            this.buttonBox.Controls.Add(this.saveButton);
            this.buttonBox.Controls.Add(this.start_Button);
            this.buttonBox.Controls.Add(this.loadButton);
            this.buttonBox.Location = new System.Drawing.Point(1024, 811);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(148, 177);
            this.buttonBox.TabIndex = 12;
            this.buttonBox.TabStop = false;
            this.buttonBox.Text = "groupBox1";
            // 
            // partyBox1
            // 
            this.partyBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partyBox1.Location = new System.Drawing.Point(1024, 12);
            this.partyBox1.Name = "partyBox1";
            this.partyBox1.Size = new System.Drawing.Size(148, 382);
            this.partyBox1.TabIndex = 14;
            this.partyBox1.TabStop = false;
            this.partyBox1.Text = "groupBox2";
            // 
            // partyBox2
            // 
            this.partyBox2.Location = new System.Drawing.Point(1024, 400);
            this.partyBox2.Name = "partyBox2";
            this.partyBox2.Size = new System.Drawing.Size(148, 405);
            this.partyBox2.TabIndex = 15;
            this.partyBox2.TabStop = false;
            this.partyBox2.Text = "groupBox3";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1006, 976);
            this.panel1.TabIndex = 16;
            this.panel1.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.panel1_GiveFeedback);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 1000);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.partyBox2);
            this.Controls.Add(this.partyBox1);
            this.Controls.Add(this.buttonBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 1038);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Selection";
            this.Load += new System.EventHandler(this.Form1Load);
            this.buttonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.GroupBox buttonBox;
        private System.Windows.Forms.GroupBox partyBox1;
        private System.Windows.Forms.GroupBox partyBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

