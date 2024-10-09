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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ავტორიზაციის ფორმის გასუფთავების მეთოდი
        public void emptyForm()
        {
            radioBtnForeigner.Checked = false;
            radioBtnGeorgian.Checked = false;

            input_ID.Text = "";
            input_password.Text = "";
        }


       



        // Our events
        private void event_logInOnClick(object sender, MouseEventArgs e)
        {
            /*
             * ვალიდაცია შემდეგნაირად:
             *      თუ ყველაფერი ცარიელია       -> შესაბამისი ერორ მესიჯი
             *      თუ ზოგიერთი ცარიელია       -> შესაბამისი ერორ მესიჯი
             *      
             *   შემდეგ:
             *      რამდენად სწორი აიდი და პაროლია, ამის ვალიდაცია
            */

            
            // თუ მთლიანად ცარიელია ფორმა
            if(!(radioBtnForeigner.Checked || radioBtnGeorgian.Checked) && input_ID.Text.Trim() == "" && input_password.Text.Trim() == "")
            {
                label_errorMessage.Text = ErrorMessagePack.errorOf(Error.noNothing).message;
                return;
            }
            // თუ ნაწილობრივ ცარიელი
            else
            {
                string errorTextList = "";

                if (!(radioBtnForeigner.Checked || radioBtnGeorgian.Checked))
                {
                    errorTextList += $"{ErrorMessagePack.errorOf(Error.noRadio).message}\n";
                }

                if (input_ID.Text.Trim() == "")
                {
                    errorTextList += $"{ErrorMessagePack.errorOf(Error.noLogIn).message}\n";
                }

                if (input_password.Text.Trim() == "")
                {
                    errorTextList += $"{ErrorMessagePack.errorOf(Error.noPassword).message}\n";
                }

                label_errorMessage.Text = errorTextList;
                if (errorTextList != "") return;
            }

            // თუ ყველაფერი შევსებულია, მათი სისწორე

            // პირველად მოწმდება პირადი ნომერი ბაზაში, თუ არ არსებობს, შესაბამისი ერორ მესიჯი
            // აქ იფ-ში ჩაისმევა ბექის შექმნილი ვალიდაციის ფუნქცია, რომელიც უზრუნველყოფს სწორია თუ არა აიდი

            // თუ ჭეშმარიტი აიდია, იფ-ში საერთოდ უნდა იყოს ამ ფუნქციის უარყოფითი მნიშვნელობა ( input_ID )
            if (!true)
            {
                label_errorMessage.Text = ErrorMessagePack.errorOf(Error.noSuchId).message;
                return;
            }

            // აქაც იგივე, უკვე პაროლზე ( input_password )
            if (!true)
            {
                label_errorMessage.Text = ErrorMessagePack.errorOf(Error.wrongPassword).message;
                return;
            }


            // თუ ყველაფერი სწორი აღმოჩნდა შესრულდეს შესვლის ოპერაცია, რასაც სხვა მოდული უზრუნველყოფს

            // შესვლის ოოერაცია:
            // func();
        }

        private void event_forgotOnClick(object sender, MouseEventArgs e)
        {
            // შედეგად გაიხსნება პაროლის აღდგენის ფორმა, ხოლო მთავარი ფორმა დროებით დაიმალება
            Form_forgotPassword form = new Form_forgotPassword();
            this.Hide();
            form.mainForm = this;
            form.Show();
        }

        private void event_langSelected(object sender, EventArgs e)
        {
            // შესაბამისი ფუნქციონალი ენის შეცვლისა (სხვა მოდულიდან)
        }

        private void languageSelector_KeyPress(object sender, KeyPressEventArgs e)
        {
            // კლავიატურით რომ არ შევცვალოთ კომბობოქსის შიგთავსი
            e.Handled = true;
        }

        private void event_formInputId(object sender, KeyPressEventArgs e)
        {
            // პირადი ნომრის შეყვანა, არ აიკრიფება გარდა რიცხვებისა
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
