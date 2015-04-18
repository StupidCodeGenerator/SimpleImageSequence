using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISE
{
    public partial class FormCreateAction : Form
    {
        public FormCreateAction()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormMain.instance.addNewAction(textBoxName.Text.ToString());
            this.Close();
        }
    }
}
