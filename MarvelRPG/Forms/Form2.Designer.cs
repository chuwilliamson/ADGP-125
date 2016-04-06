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
            this.pauseButton = new System.Windows.Forms.Button();
            this.combatLog = new System.Windows.Forms.TextBox();
            this.turnBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cardBox2 = new System.Windows.Forms.Panel();
            this.cardBox1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.turnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnBox.Location = new System.Drawing.Point(687, 834);
            this.turnBox.Margin = new System.Windows.Forms.Padding(1);
            this.turnBox.Multiline = true;
            this.turnBox.Name = "turnBox";
            this.turnBox.ReadOnly = true;
            this.turnBox.Size = new System.Drawing.Size(26, 45);
            this.turnBox.TabIndex = 14;
            this.turnBox.Text = "2";
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
            // cardBox2
            // 
            this.cardBox2.AutoSize = true;
            this.cardBox2.Location = new System.Drawing.Point(4, 385);
            this.cardBox2.Name = "cardBox2";
            this.cardBox2.Size = new System.Drawing.Size(1445, 272);
            this.cardBox2.TabIndex = 22;
            // 
            // cardBox1
            // 
            this.cardBox1.Location = new System.Drawing.Point(12, 4);
            this.cardBox1.Name = "cardBox1";
            this.cardBox1.Size = new System.Drawing.Size(1437, 311);
            this.cardBox1.TabIndex = 23;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 999);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.turnBox);
            this.Controls.Add(this.combatLog);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.cardBox2);
            this.Controls.Add(this.cardBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TextBox combatLog;
        private System.Windows.Forms.TextBox turnBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel cardBox2;
        private System.Windows.Forms.Panel cardBox1;
    }
}