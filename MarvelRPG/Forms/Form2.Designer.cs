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
            this.pauseButton = new System.Windows.Forms.Button();
            this.combatLog = new System.Windows.Forms.TextBox();
            this.turnBox = new System.Windows.Forms.TextBox();
            this.abilityBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.unitBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.defendButton1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.abilityBox2 = new System.Windows.Forms.TextBox();
            this.partyBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.unitBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // partyBox1
            // 
            this.partyBox1.Enabled = false;
            this.partyBox1.Location = new System.Drawing.Point(6, 630);
            this.partyBox1.Margin = new System.Windows.Forms.Padding(1);
            this.partyBox1.Multiline = true;
            this.partyBox1.Name = "partyBox1";
            this.partyBox1.ReadOnly = true;
            this.partyBox1.Size = new System.Drawing.Size(270, 80);
            this.partyBox1.TabIndex = 1;
            this.partyBox1.Text = "Party Info";
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(1179, 812);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(270, 65);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // combatLog
            // 
            this.combatLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.combatLog.Enabled = false;
            this.combatLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatLog.Location = new System.Drawing.Point(0, 881);
            this.combatLog.Margin = new System.Windows.Forms.Padding(1);
            this.combatLog.Multiline = true;
            this.combatLog.Name = "combatLog";
            this.combatLog.ReadOnly = true;
            this.combatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.combatLog.Size = new System.Drawing.Size(1471, 118);
            this.combatLog.TabIndex = 9;
            this.combatLog.Text = "Combat Log";
            // 
            // turnBox
            // 
            this.turnBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.turnBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnBox.Enabled = false;
            this.turnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnBox.Location = new System.Drawing.Point(1179, 690);
            this.turnBox.Margin = new System.Windows.Forms.Padding(1);
            this.turnBox.Multiline = true;
            this.turnBox.Name = "turnBox";
            this.turnBox.ReadOnly = true;
            this.turnBox.Size = new System.Drawing.Size(270, 118);
            this.turnBox.TabIndex = 14;
            this.turnBox.Text = "2";
            this.turnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // abilityBox1
            // 
            this.abilityBox1.Enabled = false;
            this.abilityBox1.Location = new System.Drawing.Point(6, 794);
            this.abilityBox1.Margin = new System.Windows.Forms.Padding(1);
            this.abilityBox1.Multiline = true;
            this.abilityBox1.Name = "abilityBox1";
            this.abilityBox1.ReadOnly = true;
            this.abilityBox1.Size = new System.Drawing.Size(270, 72);
            this.abilityBox1.TabIndex = 15;
            this.abilityBox1.Text = "Current State: textBox1";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(289, 886);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(270, 27);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "Active Party: textBox3";
            // 
            // unitBox1
            // 
            this.unitBox1.Enabled = false;
            this.unitBox1.Location = new System.Drawing.Point(6, 712);
            this.unitBox1.Margin = new System.Windows.Forms.Padding(1);
            this.unitBox1.Multiline = true;
            this.unitBox1.Name = "unitBox1";
            this.unitBox1.ReadOnly = true;
            this.unitBox1.Size = new System.Drawing.Size(270, 80);
            this.unitBox1.TabIndex = 21;
            this.unitBox1.Text = "Unit Info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.defendButton1);
            this.panel1.Location = new System.Drawing.Point(6, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 120);
            this.panel1.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 33);
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
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.unitBox1);
            this.groupBox1.Controls.Add(this.abilityBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.partyBox1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 873);
            this.groupBox1.TabIndex = 22;
            // 
            // abilityBox2
            // 
            this.abilityBox2.Enabled = false;
            this.abilityBox2.Location = new System.Drawing.Point(389, 798);
            this.abilityBox2.Margin = new System.Windows.Forms.Padding(1);
            this.abilityBox2.Multiline = true;
            this.abilityBox2.Name = "abilityBox2";
            this.abilityBox2.ReadOnly = true;
            this.abilityBox2.Size = new System.Drawing.Size(270, 72);
            this.abilityBox2.TabIndex = 16;
            this.abilityBox2.Text = "Current State: textBox2";
            // 
            // partyBox2
            // 
            this.partyBox2.Enabled = false;
            this.partyBox2.Location = new System.Drawing.Point(389, 634);
            this.partyBox2.Margin = new System.Windows.Forms.Padding(1);
            this.partyBox2.Multiline = true;
            this.partyBox2.Name = "partyBox2";
            this.partyBox2.ReadOnly = true;
            this.partyBox2.Size = new System.Drawing.Size(270, 80);
            this.partyBox2.TabIndex = 2;
            this.partyBox2.Text = "Party Info";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(389, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 123);
            this.panel2.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 33);
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
            // unitBox2
            // 
            this.unitBox2.Enabled = false;
            this.unitBox2.Location = new System.Drawing.Point(389, 716);
            this.unitBox2.Margin = new System.Windows.Forms.Padding(1);
            this.unitBox2.Multiline = true;
            this.unitBox2.Name = "unitBox2";
            this.unitBox2.ReadOnly = true;
            this.unitBox2.Size = new System.Drawing.Size(270, 80);
            this.unitBox2.TabIndex = 22;
            this.unitBox2.Text = "Unit Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(376, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 873);
            this.groupBox3.TabIndex = 23;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 999);
            this.Controls.Add(this.abilityBox2);
            this.Controls.Add(this.unitBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.partyBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.turnBox);
            this.Controls.Add(this.combatLog);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox partyBox1;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TextBox combatLog;
        private System.Windows.Forms.TextBox turnBox;
        private System.Windows.Forms.TextBox abilityBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button defendButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox unitBox1;
        private System.Windows.Forms.Panel groupBox1;
        private System.Windows.Forms.Panel groupBox3;
        private System.Windows.Forms.TextBox unitBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox partyBox2;
        private System.Windows.Forms.TextBox abilityBox2;
    }
}