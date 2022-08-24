using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morris_Course_Project_Part_2
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void hireDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void hireDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

       

