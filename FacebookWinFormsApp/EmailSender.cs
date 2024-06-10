using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;

namespace BasicFacebookFeatures
{
    public static class EmailSender
    {
        private const int GmailSMTPPort = 587;
        private const string GmailHost = "smtp.gmail.com";

        public static bool SendEmails(string i_GroupName, string i_GroupLink, List<string> i_EmailsList)
        {
            bool isEmailsSendingSucceed = true;
            string senderEmail = "fapp20140@gmail.com";
            string senderAppPassword = "jmqi dcpi wvqq vnzb";
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress(senderEmail);
            message.Subject = $"{FormMain.LoggedInUser.Name} created new group -  Please Join";
            message.Body = $"Hey! {FormMain.LoggedInUser.Name} created a group and wants you to join. Here is the link to the new group called '{i_GroupName}': {i_GroupLink}";
            smtp.Port = GmailSMTPPort;
            smtp.Host = GmailHost;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(senderEmail, senderAppPassword);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            foreach (string email in i_EmailsList)
            {
                message.To.Add(new MailAddress(email));
            }

            try
            {
                smtp.Send(message);
            }
            catch (Exception)
            {
                isEmailsSendingSucceed = false;
            }

            return isEmailsSendingSucceed;
        }
    }
}