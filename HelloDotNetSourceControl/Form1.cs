using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloDotNetSourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayGreeting();
        }

        /// <summary>
        /// Displays a greeting to the user
        /// </summary>
        static void DisplayGreeting()
        {
            MessageBox.Show("hello world!");
        }
    }
}
