using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppThree_M
{
    public partial class FrmTest : Form
    {
        // The sentence to display to the user
        public String Sentence = "This is a test sentence that I want to display.";

        // The current letter position
        public int CurrentPos = 0;

        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check if we still need to write out the sentence
            if (CurrentPos < Sentence.Length)
            {
                // Add the next letter to the TextBox's text
                textBox1.Text += Sentence[CurrentPos];

                // Move to the next letter
                CurrentPos += 1;
            }
            else // We have finished writing out the sentence
            {
                // Disable the timer
                timer1.Enabled = false;
            }
        }
    }
}
