using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SET
{
    public partial class GeneralOptions : Form
    {
        public GeneralOptions()
        {
            InitializeComponent();
        }

        private void closeOptionsLabel_Click(object sender, EventArgs e)
        {
            // close options wihtout saving
            this.Close();
        }

        private void saveOptionsLabel_Click(object sender, EventArgs e)
        {
            // save settings
            MessageBox.Show("Your settings were saved!");
            // close otions form
            this.Close();
        }

        private void keyBindingLable_Click(object sender, EventArgs e)
        {
            // allow user to switch key bind to whatever key they press
            MessageBox.Show("Allow user to switch keybinds!");
        }
    }
}
