using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMaster
{
    public partial class Form_forgotPassword : Form
    {
        public LoginForm mainForm;

        public static string oneTimePassword = "";
        public Form_forgotPassword()
        {
            InitializeComponent();


        }

        // მეთოდი რომელიც კომპანიის მეილით (employeemaster007@gmail.com) გააგზავნის ინფორმაციას თანამშრომლის მეილზე
        public void sendMailTo(string recipientsMail, string subject, string content)
        {
            // მესიჯის, გამგზავნის და მიმღების ინიციალიზება
            MailMessage Msg = new MailMessage();
            Msg.From = new MailAddress("employeemaster007@gmail.com");
            Msg.To.Add(recipientsMail);
            Msg.Subject = subject;
            Msg.Body = content;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            // გამგზავნი მეილის ინფო
            smtp.Credentials = new System.Net.NetworkCredential("employeemaster007@gmail.com", "qlwu qvle flui wqhq");

            smtp.EnableSsl = true;

            // გაგზავნა
            smtp.Send(Msg);
        }



        private static Random random = new Random();

        // ახალი პაროლის გენერაცია
        public static string GenerateCode()
        {
            // Define character sets
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string symbols = "!@#$%^&*()-_=+[]{}|;:,.<>?";

            // Ensure at least one of each character type
            char[] code = new char[4];
            code[0] = GetRandomCharacter(lowercase);
            code[1] = GetRandomCharacter(uppercase);
            code[2] = GetRandomCharacter(numbers);
            code[3] = GetRandomCharacter(symbols);

            // Shuffle the characters to make the code random
            ShuffleArray(code);

            return new string(code);
        }

        private static char GetRandomCharacter(string characterSet)
        {
            int index = random.Next(characterSet.Length);
            return characterSet[index];
        }

        private static void ShuffleArray(char[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = random.Next(n--);
                char temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        private void event_formClosingClick(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        // გაგზავნის ღილაკის დაკლიკება
        private void event_sendIDBtn(object sender, EventArgs e)
        {
            // თუ ველი ცარიელია
            if (input_Id.Text == "")
            {
                label_errorMessageForId.Text = ErrorMessagePack.errorOf(Error.noLogIn).message;
                return;
            }

            // აქ, თრუ/ფოლსის ნაცვლად აიდის ნამდვილად შემოწმების ფუნქცია
            if (!true)
            {
                // თუ ასეთი აიდი ბაზაში არ არის, ფორმაში გამოვა შესაბამისი შეტყობინება
                label_errorMessageForId.Text = ErrorMessagePack.errorOf(Error.noSuchId).message;
            }
            else
            {
                // აქ ვართ, თუ აიდი ნამდვილია, მაშინ შესაბამისად მეილიც გვაქვს
                string recipientMail = "sabawiqarishvili1204@gmail.com"; // აქ ბაზებიდან მეილის წვდომის შესაბამისი ფუნქცია,
                                                                         // რომელიც მეილს დააბრუნებს ID-დან გამომდინარე
                                                                         // ეს მეილი დემონსტრაციისთვის

                // ახალი პაროლი
                string newPassword = GenerateCode();
                oneTimePassword = newPassword;
                // გასაგზავნი კონტენტი ასეთია:
                string message = $"Your new password is: \"{newPassword}\"";


                // აქ იქნება რეალური ფუნქცია, რომელიც დაგენერირებულ ახალ პაროლს ბაზებში მიანიჭებს
                //
                // renewPasswordOfId(input_Id.Text); // example name of method
                //

                // გაგზავნის ფუნქცია, რითაც თანამშრომელს მეილზე მიუდის ახალი პაროლი
                sendMailTo(recipientMail, "Restored employee password", message);


                event_formClosingClick(this, null); // ამან აღდგენი ფორმის დახურვა არ გამოიწვია,
                                                    // მხოლოდ ის რაც ამ ივენთზე მოხდა, ჩვენს მიერ განსაზღვრული, ესეც საჭიროა
                Close(); // აღდგენის ფორმის დახურვა
                mainForm.emptyForm();

                // ავტორიზაციის ფორმაში ვატყობინებთ რომ მას მეილზე ახალი პაროლი მიუვიდა
                mainForm.label_message.Text = "შეამოწმე მეილი, ახალი პაროლის სანახავად!";

                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (s, ev) =>
                {
                    mainForm.label_message.Text = "";
                    timer.Stop();
                };
                timer.Start();
            }
        }


        private void event_forgotPass_IdInput(object sender, KeyPressEventArgs e)
        {
            // პირადი ნომრის შეყვანა, არ აიკრიფება გარდა რიცხვებისა
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void groupBox_ForgotPassword_Enter(object sender, EventArgs e)
        {

        }

        private void Form_forgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
