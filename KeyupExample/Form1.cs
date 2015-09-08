using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyupExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //Display a pop-up help topic to assist the user.
                Help.ShowPopup(TxtBox, "Enter your first name", new Point(this.TxtBox.Right, this.TxtBox.Bottom));
            }
        }
    }
}
