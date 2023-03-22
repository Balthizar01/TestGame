namespace TestGame
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
            this.characterButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // characterButton
            // 
            this.characterButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.characterButton.Location = new System.Drawing.Point(12, 528);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(113, 56);
            this.characterButton.TabIndex = 0;
            this.characterButton.Text = "Character";
            this.characterButton.UseVisualStyleBackColor = false;
            this.characterButton.Click += new System.EventHandler(this.characterButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.attackButton.Location = new System.Drawing.Point(131, 528);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(119, 56);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Attack Self";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 596);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.characterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button characterButton;
        private System.Windows.Forms.Button attackButton;
    }
}

