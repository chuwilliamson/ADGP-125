namespace MarvelRPG
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.partyBox1 = new System.Windows.Forms.TextBox();
            this.partyBox2 = new System.Windows.Forms.TextBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.combatLog = new System.Windows.Forms.TextBox();
            this.leftCardBack = new System.Windows.Forms.TextBox();
            this.rightCardBack = new System.Windows.Forms.TextBox();
            this.leftFlipButton = new System.Windows.Forms.Button();
            this.rightFlipButton = new System.Windows.Forms.Button();
            this.turnBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // partyBox1
            // 
            this.partyBox1.Location = new System.Drawing.Point(12, 487);
            this.partyBox1.Margin = new System.Windows.Forms.Padding(1);
            this.partyBox1.Multiline = true;
            this.partyBox1.Name = "partyBox1";
            this.partyBox1.Size = new System.Drawing.Size(270, 233);
            this.partyBox1.TabIndex = 1;
            // 
            // partyBox2
            // 
            this.partyBox2.Location = new System.Drawing.Point(560, 487);
            this.partyBox2.Margin = new System.Windows.Forms.Padding(1);
            this.partyBox2.Multiline = true;
            this.partyBox2.Name = "partyBox2";
            this.partyBox2.Size = new System.Drawing.Size(270, 233);
            this.partyBox2.TabIndex = 2;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(1057, 725);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(115, 33);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Attack";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = global::MarvelRPG.Properties.Resources.Hulk_small;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.InitialImage = global::MarvelRPG.Properties.Resources.Hulk_small;
            this.pictureBox2.Location = new System.Drawing.Point(560, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 420);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // combatLog
            // 
            this.combatLog.Location = new System.Drawing.Point(286, 10);
            this.combatLog.Margin = new System.Windows.Forms.Padding(1);
            this.combatLog.Multiline = true;
            this.combatLog.Name = "combatLog";
            this.combatLog.Size = new System.Drawing.Size(270, 420);
            this.combatLog.TabIndex = 9;
            this.combatLog.Text = "combat log";
            // 
            // leftCardBack
            // 
            this.leftCardBack.Location = new System.Drawing.Point(12, 10);
            this.leftCardBack.Margin = new System.Windows.Forms.Padding(1);
            this.leftCardBack.Multiline = true;
            this.leftCardBack.Name = "leftCardBack";
            this.leftCardBack.Size = new System.Drawing.Size(270, 420);
            this.leftCardBack.TabIndex = 10;
            // 
            // rightCardBack
            // 
            this.rightCardBack.Location = new System.Drawing.Point(560, 10);
            this.rightCardBack.Margin = new System.Windows.Forms.Padding(1);
            this.rightCardBack.Multiline = true;
            this.rightCardBack.Name = "rightCardBack";
            this.rightCardBack.Size = new System.Drawing.Size(270, 420);
            this.rightCardBack.TabIndex = 11;
            // 
            // leftFlipButton
            // 
            this.leftFlipButton.Location = new System.Drawing.Point(167, 434);
            this.leftFlipButton.Name = "leftFlipButton";
            this.leftFlipButton.Size = new System.Drawing.Size(115, 33);
            this.leftFlipButton.TabIndex = 12;
            this.leftFlipButton.Text = "Flip";
            this.leftFlipButton.UseVisualStyleBackColor = true;
            this.leftFlipButton.Click += new System.EventHandler(this.leftFlipButton_Click);
            // 
            // rightFlipButton
            // 
            this.rightFlipButton.Location = new System.Drawing.Point(715, 436);
            this.rightFlipButton.Name = "rightFlipButton";
            this.rightFlipButton.Size = new System.Drawing.Size(115, 33);
            this.rightFlipButton.TabIndex = 13;
            this.rightFlipButton.Text = "Flip";
            this.rightFlipButton.UseVisualStyleBackColor = true;
            this.rightFlipButton.Click += new System.EventHandler(this.rightFlipButton_Click);
            // 
            // turnBox
            // 
            this.turnBox.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnBox.Location = new System.Drawing.Point(328, 548);
            this.turnBox.Margin = new System.Windows.Forms.Padding(1);
            this.turnBox.Multiline = true;
            this.turnBox.Name = "turnBox";
            this.turnBox.Size = new System.Drawing.Size(175, 101);
            this.turnBox.TabIndex = 14;
            this.turnBox.Text = "1";
            this.turnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 862);
            this.Controls.Add(this.turnBox);
            this.Controls.Add(this.rightFlipButton);
            this.Controls.Add(this.leftFlipButton);
            this.Controls.Add(this.combatLog);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.partyBox2);
            this.Controls.Add(this.partyBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rightCardBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.leftCardBack);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox partyBox1;
        private System.Windows.Forms.TextBox partyBox2;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox combatLog;
        private System.Windows.Forms.TextBox leftCardBack;
        private System.Windows.Forms.TextBox rightCardBack;
        private System.Windows.Forms.Button leftFlipButton;
        private System.Windows.Forms.Button rightFlipButton;
        private System.Windows.Forms.TextBox turnBox;
    }
}