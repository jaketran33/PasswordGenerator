using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
Set default form size on startup
Took out "ERROR:" from error message
Added history list, appends history label when Generate is clicked
Added time stamp
 */ 

/* TODO:
 * Change history and time stamps to most recent order instead of first to last
 * Serialize data upon exit and reload it upon startup
 */ 

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {

        bool lowercaseB, uppercaseB, numbersB, symbolsB;


		// Constructor
		public Form1()
        {
            InitializeComponent();

			this.Size = new Size(700, 750);
			history.Text = "";
			timeStamp.Text = "";


		}

        // Checks if checkboxes are checked, sets the respective bools.
        private void setBools()
        {
            if (lowercase.Checked)
                lowercaseB = true;
            else
                lowercaseB = false;
            if (uppercase.Checked)
                uppercaseB = true;
            else
                uppercaseB = false;
            if (numbers.Checked)
                numbersB = true;
            else
                numbersB = false;
            if (symbols.Checked)
                symbolsB = true;
            else
                symbolsB = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numOfChars.Text = "Number of characters: " + trackBar.Value;
        }

        private void clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password.Text);
        }

        private void numOfChars_Click(object sender, EventArgs e)
        {

        }

        // Generate button clicked
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setBools();
            if (isBlank())
                password.Text = "Please check at least one box.";
            else
            {
                RandomPasswordGen passGen = new RandomPasswordGen(trackBar.Value, lowercaseB, uppercaseB, numbersB, symbolsB);
				string pw = passGen.getPassword();
				password.Text = pw;

				history.Text += pw + "\n";

				DateTime dateTime = DateTime.UtcNow.Date;
				timeStamp.Text = DateTime.Now.ToString("hh:mm:ss") + " " + DateTime.Today.ToString("MM/dd/yyyy") + "\n";
            }
        }

        // Copy to Clipboard button clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password.Text);
        }

        // Checks if all checkboxes are blank, if yes, return true.
        private bool isBlank()
        {
            if (lowercase.Checked == false && uppercase.Checked == false && numbers.Checked == false && symbols.Checked == false)
            {
                return true;
            }
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
