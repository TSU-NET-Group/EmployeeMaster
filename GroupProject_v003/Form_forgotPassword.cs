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

namespace GroupProject_v001
{
    public partial class Form_forgotPassword : Form
    {
        public LoginForm mainForm;
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

        // ახალი პაროლის გენერაცია
        public string generatePassword()
        {
            StringBuilder sb = new StringBuilder();

            List<char> validChars = new List<char>();
            char toAdd = 'a';
            for(int i = 0; i < 26; i++)
            {
                validChars.Add(toAdd);
                validChars.Add(toAdd.ToString().ToUpper()[0]);
                toAdd = (char)((int)toAdd + 1);
            }

            toAdd = '0';

            for(int i = 0; i < 10; i++)
            {
                validChars.Add(toAdd);
                toAdd = (char)((int)toAdd + 1);
            }


            Random random = new Random();
            for(int i = 0; i < 8; i++)
            {
                sb.Append(validChars[(int)Math.Floor((double)(random.Next(0, validChars.Count)))]);
            }

            // აქ ფუნქციით, რომელსაც უკვე ექნება წვდომა სხვა თანამშრომელთა პაროლებზე
            // შევამოწმებთ ასეთი პაროლი უკვე არსებობს თუ არა,
            // და თუ არსებობს ფუნქციას ახლიდან გამოვიძახებთ რეკურსიულად
            /*
            if(passwordExists(sb.ToString()))
            {
                return generatePassword(); // რეკურსია
            {
            */


            return sb.ToString();
        }


        private void event_formClosingClick(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        // გაგზავნის ღილაკის დაკლიკება
        private void event_sendIDBtn(object sender, EventArgs e)
        {
            // თუ ველი ცარიელია
            if(input_Id.Text == "")
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
                string recipientMail = "sabasidamonidze2004@gmail.com"; // აქ ბაზებიდან მეილის წვდომის შესაბამისი ფუნქცია,
                                                                        // რომელიც მეილს დააბრუნებს ID-დან გამომდინარე
                                                                        // ეს მეილი დემონსტრაციისთვის

                // ახალი პაროლი
                string newPassword = generatePassword();

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
            if(!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
