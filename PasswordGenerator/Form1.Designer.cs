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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.lowercase = new System.Windows.Forms.CheckBox();
            this.uppercase = new System.Windows.Forms.CheckBox();
            this.numbers = new System.Windows.Forms.CheckBox();
            this.symbols = new System.Windows.Forms.CheckBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.numOfChars = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Roboto Lt", 8.6F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(44, 319);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(414, 22);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowercase
            // 
            this.lowercase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lowercase.BackColor = System.Drawing.Color.Transparent;
            this.lowercase.Checked = true;
            this.lowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercase.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.lowercase.ForeColor = System.Drawing.Color.White;
            this.lowercase.Location = new System.Drawing.Point(219, 142);
            this.lowercase.Name = "lowercase";
            this.lowercase.Size = new System.Drawing.Size(80, 17);
            this.lowercase.TabIndex = 3;
            this.lowercase.Text = "Lowercase";
            this.lowercase.UseVisualStyleBackColor = false;
            // 
            // uppercase
            // 
            this.uppercase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uppercase.BackColor = System.Drawing.Color.Transparent;
            this.uppercase.Checked = true;
            this.uppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercase.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.uppercase.ForeColor = System.Drawing.Color.White;
            this.uppercase.Location = new System.Drawing.Point(219, 165);
            this.uppercase.Name = "uppercase";
            this.uppercase.Size = new System.Drawing.Size(79, 17);
            this.uppercase.TabIndex = 4;
            this.uppercase.Text = "Uppercase";
            this.uppercase.UseVisualStyleBackColor = false;
            // 
            // numbers
            // 
            this.numbers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numbers.BackColor = System.Drawing.Color.Transparent;
            this.numbers.Checked = true;
            this.numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbers.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.numbers.ForeColor = System.Drawing.Color.White;
            this.numbers.Location = new System.Drawing.Point(219, 188);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(72, 17);
            this.numbers.TabIndex = 5;
            this.numbers.Text = "Numbers";
            this.numbers.UseVisualStyleBackColor = false;
            // 
            // symbols
            // 
            this.symbols.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.symbols.BackColor = System.Drawing.Color.Transparent;
            this.symbols.Checked = true;
            this.symbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.symbols.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.symbols.ForeColor = System.Drawing.Color.White;
            this.symbols.Location = new System.Drawing.Point(219, 211);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(70, 17);
            this.symbols.TabIndex = 6;
            this.symbols.Text = "Symbols";
            this.symbols.UseVisualStyleBackColor = false;
            // 
            // trackBar
            // 
            this.trackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar.AutoSize = false;
            this.trackBar.BackColor = System.Drawing.Color.White;
            this.trackBar.Location = new System.Drawing.Point(135, 82);
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
            this.numOfChars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numOfChars.BackColor = System.Drawing.Color.Transparent;
            this.numOfChars.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfChars.ForeColor = System.Drawing.Color.White;
            this.numOfChars.Location = new System.Drawing.Point(163, 56);
            this.numOfChars.Name = "numOfChars";
            this.numOfChars.Size = new System.Drawing.Size(177, 13);
            this.numOfChars.TabIndex = 8;
            this.numOfChars.Text = "Number of characters: 1";
            this.numOfChars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numOfChars.Click += new System.EventHandler(this.numOfChars_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(182, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PasswordGenerator.Properties.Resources.patrick_fore_359608;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numOfChars);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.symbols);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.uppercase);
            this.Controls.Add(this.lowercase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.CheckBox lowercase;
        private System.Windows.Forms.CheckBox uppercase;
        private System.Windows.Forms.CheckBox numbers;
        private System.Windows.Forms.CheckBox symbols;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label numOfChars;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

