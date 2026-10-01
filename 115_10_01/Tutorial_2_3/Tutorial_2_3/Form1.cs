using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buongiorno";
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buenos días";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Guten Morgen";
        }
    }
}
