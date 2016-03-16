namespace TurnBasedRPG
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
            this.WarriorRadioButton = new System.Windows.Forms.RadioButton();
            this.ClassBox = new System.Windows.Forms.GroupBox();
            this.NinjaRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClassBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WarriorRadioButton
            // 
            this.WarriorRadioButton.AutoSize = true;
            this.WarriorRadioButton.Location = new System.Drawing.Point(6, 19);
            this.WarriorRadioButton.Name = "WarriorRadioButton";
            this.WarriorRadioButton.Size = new System.Drawing.Size(59, 17);
            this.WarriorRadioButton.TabIndex = 0;
            this.WarriorRadioButton.TabStop = true;
            this.WarriorRadioButton.Text = "Warrior";
            this.WarriorRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClassBox
            // 
            this.ClassBox.BackColor = System.Drawing.SystemColors.Control;
            this.ClassBox.Controls.Add(this.NinjaRadioButton);
            this.ClassBox.Controls.Add(this.WarriorRadioButton);
            this.ClassBox.Location = new System.Drawing.Point(18, 457);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(258, 110);
            this.ClassBox.TabIndex = 1;
            this.ClassBox.TabStop = false;
            this.ClassBox.Text = "Class";
            // 
            // NinjaRadioButton
            // 
            this.NinjaRadioButton.AutoSize = true;
            this.NinjaRadioButton.Location = new System.Drawing.Point(6, 42);
            this.NinjaRadioButton.Name = "NinjaRadioButton";
            this.NinjaRadioButton.Size = new System.Drawing.Size(49, 17);
            this.NinjaRadioButton.TabIndex = 1;
            this.NinjaRadioButton.TabStop = true;
            this.NinjaRadioButton.Text = "Ninja";
            this.NinjaRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 439);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 774);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClassBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClassBox.ResumeLayout(false);
            this.ClassBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton WarriorRadioButton;
        private System.Windows.Forms.GroupBox ClassBox;
        private System.Windows.Forms.RadioButton NinjaRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

