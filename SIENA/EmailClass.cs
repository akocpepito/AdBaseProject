using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SIENA
{
    class EmailClass
    {
        readonly MailMessage mail = new MailMessage();

        public void SendConfirmationEmail(User user)
        {
            User emailUser = user;

            mail.From = new MailAddress("siena.admn@gmail.com");
            mail.To.Add(emailUser.Email_address);
            mail.Subject = "Your account has been created!";
            mail.Body = "Congratulations "+emailUser.First_Name+"! <br/>Your account has been registered with SIENA.<br/>Please wait for an email from our Administrator regarding the activation of your account.<br/>" +
                "Please use the following credentials to access your account.<br/>" +
                "Username: "+emailUser.Username+"<br/>" +
                "Password: "+emailUser.Password+"<br/>" +
                "<br/><br/>Thank you,<br/>SIENA Administrator";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.Credentials = new System.Net.NetworkCredential("siena.admn@gmail.com", "P@ssword12345");
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }

        public void SendProfileUpdatedEmail(User user)
        {
            User emailUser = user;

            mail.From = new MailAddress("siena.admn@gmail.com");
            mail.To.Add(emailUser.Email_address);
            mail.Subject = "Your account has been created!";
            mail.Body = "Congratulations " + emailUser.First_Name + "! <br/>Your account has been registered with SIENA.<br/>Please wait for an email from our Administrator regarding the activation of your account.<br/>" +
                "Please use the following credentials to access your account.<br/>" +
                "Username: " + emailUser.Username + "<br/>" +
                "Password: " + emailUser.Password + "<br/>" +
                "<br/><br/>Thank you,<br/>SIENA Administrator";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.Credentials = new System.Net.NetworkCredential("siena.admn@gmail.com", "P@ssword12345");
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }

        public void SendPasswordResetEmail(User user)
        {
            User emailUser = user;

            mail.From = new MailAddress("siena.admn@gmail.com");
            mail.To.Add(emailUser.Email_address);
            mail.Subject = "Your password has been reset!";
            mail.Body = "The password on your account has been reset.<br/><br/>" +
                "Please use the following credentials to access your account.<br/>" +
                "Username: " + emailUser.Username + "<br/>" +
                "Password: " + emailUser.Password + "<br/><br/>" +
                "If you did not make this request, please contact our administrators.<br/><br/>" +
                "<br/><br/>Thank you,<br/>SIENA Administrator";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.Credentials = new System.Net.NetworkCredential("siena.admn@gmail.com", "P@ssword12345");
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }

        public void SendAccountCreatedEmail(User user)
        {
            User emailUser = user;

            mail.From = new MailAddress("siena.admn@gmail.com");
            mail.To.Add(emailUser.Email_address);
            mail.Subject = "Your account has been created!";
            mail.Body = "Congratulations " + emailUser.First_Name + "! <br/>Your account has been registered with SIENA.<br/>Please wait for an email from our Administrator regarding the activation of your account.<br/>" +
                "Please use the following credentials to access your account.<br/>" +
                "Username: " + emailUser.Username + "<br/>" +
                "Password: " + emailUser.Password + "<br/>" +
                "<br/><br/>Thank you,<br/>SIENA Administrator";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.Credentials = new System.Net.NetworkCredential("siena.admn@gmail.com", "P@ssword12345");
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }
    }
}
