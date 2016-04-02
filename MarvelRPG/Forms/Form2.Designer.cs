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
            this.partyBox1 = new System.Windows.Forms.TextBox();
            this.partyBox2 = new System.Windows.Forms.TextBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.combatLog = new System.Windows.Forms.TextBox();
            this.leftCardBack = new System.Windows.Forms.TextBox();
            this.rightCardBack = new System.Windows.Forms.TextBox();
            this.turnBox = new System.Windows.Forms.TextBox();
            this.abilityBox1 = new System.Windows.Forms.TextBox();
            this.abilityBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unitBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.defendButton1 = new System.Windows.Forms.Button();
            this.leftFlipButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unitBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // partyBox1
            // 
            this.partyBox1.Enabled = false;
            this.partyBox1.Location = new System.Drawing.Point(13, 581);
            this.partyBox1.Margin = new System.Windows.Forms.Padding(1);
            this.partyBox1.Multiline = true;
            this.partyBox1.Name = "partyBox1";
            this.partyBox1.ReadOnly = true;
            this.partyBox1.Size = new System.Drawing.Size(270, 80);
            this.partyBox1.TabIndex = 1;
            this.partyBox1.Text = "Party Info";
            // 
            // partyBox2
            // 
            this.partyBox2.Enabled = false;
            this.partyBox2.Location = new System.Drawing.Point(4, 581);
            this.partyBox2.Margin = new System.Windows.Forms.Padding(1);
            this.partyBox2.Multiline = true;
            this.partyBox2.Name = "partyBox2";
            this.partyBox2.ReadOnly = true;
            this.partyBox2.Size = new System.Drawing.Size(270, 80);
            this.partyBox2.TabIndex = 2;
            this.partyBox2.Text = "Party Info";
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(307, 775);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(266, 65);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = global::MarvelRPG.Properties.Resources.Hulk_small;
            this.pictureBox1.Location = new System.Drawing.Point(11, 61);
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
            this.pictureBox2.Location = new System.Drawing.Point(6, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 420);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // combatLog
            // 
            this.combatLog.Enabled = false;
            this.combatLog.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatLog.Location = new System.Drawing.Point(305, 124);
            this.combatLog.Margin = new System.Windows.Forms.Padding(1);
            this.combatLog.Multiline = true;
            this.combatLog.Name = "combatLog";
            this.combatLog.ReadOnly = true;
            this.combatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.combatLog.Size = new System.Drawing.Size(270, 606);
            this.combatLog.TabIndex = 9;
            this.combatLog.Text = "Combat Log";
            // 
            // leftCardBack
            // 
            this.leftCardBack.Location = new System.Drawing.Point(9, 63);
            this.leftCardBack.Margin = new System.Windows.Forms.Padding(1);
            this.leftCardBack.Multiline = true;
            this.leftCardBack.Name = "leftCardBack";
            this.leftCardBack.Size = new System.Drawing.Size(270, 420);
            this.leftCardBack.TabIndex = 10;
            // 
            // rightCardBack
            // 
            this.rightCardBack.Location = new System.Drawing.Point(6, 66);
            this.rightCardBack.Margin = new System.Windows.Forms.Padding(1);
            this.rightCardBack.Multiline = true;
            this.rightCardBack.Name = "rightCardBack";
            this.rightCardBack.Size = new System.Drawing.Size(270, 420);
            this.rightCardBack.TabIndex = 11;
            // 
            // turnBox
            // 
            this.turnBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.turnBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnBox.Enabled = false;
            this.turnBox.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnBox.Location = new System.Drawing.Point(305, 8);
            this.turnBox.Margin = new System.Windows.Forms.Padding(1);
            this.turnBox.Multiline = true;
            this.turnBox.Name = "turnBox";
            this.turnBox.ReadOnly = true;
            this.turnBox.Size = new System.Drawing.Size(270, 104);
            this.turnBox.TabIndex = 14;
            this.turnBox.Text = "2";
            this.turnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // abilityBox1
            // 
            this.abilityBox1.Enabled = false;
            this.abilityBox1.Location = new System.Drawing.Point(13, 673);
            this.abilityBox1.Margin = new System.Windows.Forms.Padding(1);
            this.abilityBox1.Multiline = true;
            this.abilityBox1.Name = "abilityBox1";
            this.abilityBox1.ReadOnly = true;
            this.abilityBox1.Size = new System.Drawing.Size(270, 123);
            this.abilityBox1.TabIndex = 15;
            this.abilityBox1.Text = "Current State: textBox1";
            // 
            // abilityBox2
            // 
            this.abilityBox2.Enabled = false;
            this.abilityBox2.Location = new System.Drawing.Point(4, 673);
            this.abilityBox2.Margin = new System.Windows.Forms.Padding(1);
            this.abilityBox2.Multiline = true;
            this.abilityBox2.Name = "abilityBox2";
            this.abilityBox2.ReadOnly = true;
            this.abilityBox2.Size = new System.Drawing.Size(270, 123);
            this.abilityBox2.TabIndex = 16;
            this.abilityBox2.Text = "abilityBox2";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(305, 732);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(270, 39);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "Active Party: textBox3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unitBox1);
            this.groupBox1.Controls.Add(this.abilityBox1);
            this.groupBox1.Controls.Add(this.partyBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.leftCardBack);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(1, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 800);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // unitBox1
            // 
            this.unitBox1.Enabled = false;
            this.unitBox1.Location = new System.Drawing.Point(13, 17);
            this.unitBox1.Margin = new System.Windows.Forms.Padding(1);
            this.unitBox1.Multiline = true;
            this.unitBox1.Name = "unitBox1";
            this.unitBox1.ReadOnly = true;
            this.unitBox1.Size = new System.Drawing.Size(270, 39);
            this.unitBox1.TabIndex = 21;
            this.unitBox1.Text = "Unit Info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.defendButton1);
            this.panel1.Controls.Add(this.leftFlipButton);
            this.panel1.Location = new System.Drawing.Point(13, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 81);
            this.panel1.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(139, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 33);
            this.button4.TabIndex = 17;
            this.button4.Text = "End Turn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // defendButton1
            // 
            this.defendButton1.Location = new System.Drawing.Point(3, 45);
            this.defendButton1.Name = "defendButton1";
            this.defendButton1.Size = new System.Drawing.Size(130, 33);
            this.defendButton1.TabIndex = 16;
            this.defendButton1.Text = "Skill";
            this.defendButton1.UseVisualStyleBackColor = true;
            // 
            // leftFlipButton
            // 
            this.leftFlipButton.Location = new System.Drawing.Point(139, 6);
            this.leftFlipButton.Name = "leftFlipButton";
            this.leftFlipButton.Size = new System.Drawing.Size(126, 33);
            this.leftFlipButton.TabIndex = 12;
            this.leftFlipButton.Text = "Flip";
            this.leftFlipButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.unitBox2);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.abilityBox2);
            this.groupBox2.Controls.Add(this.partyBox2);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.rightCardBack);
            this.groupBox2.Location = new System.Drawing.Point(579, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 800);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // unitBox2
            // 
            this.unitBox2.Enabled = false;
            this.unitBox2.Location = new System.Drawing.Point(6, 17);
            this.unitBox2.Margin = new System.Windows.Forms.Padding(1);
            this.unitBox2.Multiline = true;
            this.unitBox2.Name = "unitBox2";
            this.unitBox2.ReadOnly = true;
            this.unitBox2.Size = new System.Drawing.Size(270, 39);
            this.unitBox2.TabIndex = 22;
            this.unitBox2.Text = "Unit Info";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(6, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 81);
            this.panel2.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "End Turn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "Attack";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 33);
            this.button5.TabIndex = 16;
            this.button5.Text = "Skill";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(139, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 33);
            this.button6.TabIndex = 12;
            this.button6.Text = "Flip";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 862);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.turnBox);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combatLog);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox partyBox1;
        private System.Windows.Forms.TextBox partyBox2;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox combatLog;
        private System.Windows.Forms.TextBox leftCardBack;
        private System.Windows.Forms.TextBox rightCardBack;
        private System.Windows.Forms.TextBox turnBox;
        private System.Windows.Forms.TextBox abilityBox1;
        private System.Windows.Forms.TextBox abilityBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button leftFlipButton;
        private System.Windows.Forms.Button defendButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox unitBox1;
        private System.Windows.Forms.TextBox unitBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}