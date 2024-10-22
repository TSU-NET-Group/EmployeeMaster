using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject_v001
{
    public partial class NewPasswordForm : Form
    {
        public NewPasswordForm()
        {
            InitializeComponent();
        }


        private void newPasswordButton_Click(object sender, EventArgs e)
        {

        }

        private void NewPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void NewPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
