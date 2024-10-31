using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registration;
namespace GroupProject_v001
{
    public partial class NewPasswordForm : Form
    {

        /*
             paroli unda iyos aseTi:
                                    a-z, A-Z, 0-9, !, ?, *, (no spaces),

                                    savaldebulo : min 1 spec symbol,
                                                  min 4 latin symbol,
                                                  min 3 nums,
                                                  fixed 8 characters
        */
        public NewPasswordForm()
        {
            InitializeComponent();
        }


        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            string password1 = passwordOnce.Text;
            string password2 = passwordTwice.Text;

            if(password1.Trim() == "" || password2.Trim() == "")
            {
                label_errorMessage.Text = "Fill both";
            }
            else
            {
                if (password1 == password2)
                {
                    if(PasswordVerifier.verifyPassword(password1, out string error)){
                        label_errorMessage.Text = "";
                        // აქ მოხდება ბექის მოდულის ფუნქცია ახალი პაროლით
                    }
                    else
                    {
                        label_errorMessage.Text = error;
                    }
                }
                else
                {
                    label_errorMessage.Text = "Both passwords should be same!";
                    //roca pirveli ar emtxveva meores magis case 
                }
            }

            /*
             1. ორივე ტოლია
             2. 8 სიმბოლოა
             3. 
             */
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
