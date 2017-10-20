namespace PasswordGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.lowercase = new System.Windows.Forms.CheckBox();
            this.uppercase = new System.Windows.Forms.CheckBox();
            this.numbers = new System.Windows.Forms.CheckBox();
            this.symbols = new System.Windows.Forms.CheckBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.numOfChars = new System.Windows.Forms.Label();
            this.clipboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(210, 290);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(0, 13);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(171, 242);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lowercase
            // 
            this.lowercase.AutoSize = true;
            this.lowercase.Checked = true;
            this.lowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercase.Location = new System.Drawing.Point(171, 129);
            this.lowercase.Name = "lowercase";
            this.lowercase.Size = new System.Drawing.Size(78, 17);
            this.lowercase.TabIndex = 3;
            this.lowercase.Text = "Lowercase";
            this.lowercase.UseVisualStyleBackColor = true;
            // 
            // uppercase
            // 
            this.uppercase.AutoSize = true;
            this.uppercase.Checked = true;
            this.uppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercase.Location = new System.Drawing.Point(171, 152);
            this.uppercase.Name = "uppercase";
            this.uppercase.Size = new System.Drawing.Size(78, 17);
            this.uppercase.TabIndex = 4;
            this.uppercase.Text = "Uppercase";
            this.uppercase.UseVisualStyleBackColor = true;
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Checked = true;
            this.numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbers.Location = new System.Drawing.Point(171, 175);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(68, 17);
            this.numbers.TabIndex = 5;
            this.numbers.Text = "Numbers";
            this.numbers.UseVisualStyleBackColor = true;
            // 
            // symbols
            // 
            this.symbols.AutoSize = true;
            this.symbols.Checked = true;
            this.symbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.symbols.Location = new System.Drawing.Point(171, 198);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(65, 17);
            this.symbols.TabIndex = 6;
            this.symbols.Text = "Symbols";
            this.symbols.UseVisualStyleBackColor = true;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(96, 81);
            this.trackBar.Maximum = 50;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(233, 45);
            this.trackBar.TabIndex = 7;
            this.trackBar.Value = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // numOfChars
            // 
            this.numOfChars.AutoSize = true;
            this.numOfChars.Location = new System.Drawing.Point(151, 56);
            this.numOfChars.Name = "numOfChars";
            this.numOfChars.Size = new System.Drawing.Size(121, 13);
            this.numOfChars.TabIndex = 8;
            this.numOfChars.Text = "Number of characters: 1";
            // 
            // clipboard
            // 
            this.clipboard.Location = new System.Drawing.Point(148, 324);
            this.clipboard.Name = "clipboard";
            this.clipboard.Size = new System.Drawing.Size(115, 23);
            this.clipboard.TabIndex = 9;
            this.clipboard.Text = "Copy to clipboard!";
            this.clipboard.UseVisualStyleBackColor = true;
            this.clipboard.Click += new System.EventHandler(this.clipboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 375);
            this.Controls.Add(this.clipboard);
            this.Controls.Add(this.numOfChars);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.symbols);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.uppercase);
            this.Controls.Add(this.lowercase);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox lowercase;
        private System.Windows.Forms.CheckBox uppercase;
        private System.Windows.Forms.CheckBox numbers;
        private System.Windows.Forms.CheckBox symbols;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label numOfChars;
        private System.Windows.Forms.Button clipboard;
    }
}

