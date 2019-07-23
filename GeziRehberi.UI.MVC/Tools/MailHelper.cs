using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace GeziRehberi.UI.MVC.Tools
{
    public class MailHelper
    {
        public static bool SendConfirmationMail(string username, string password, string email, int id)
        {
            bool result = false;
            MailMessage msg = new MailMessage();
            msg.To.Add(email);
            msg.Subject = "Hoşgeldiniz ...";
            msg.IsBodyHtml = true;
            msg.Body = "Sitemize hoşgeldiniz..";
            msg.From = new MailAddress("kurumsalolmayan.ba@gmail.com");
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            NetworkCredential credential = new NetworkCredential("kurumsalolmayan.ba@gmail.com", "13022019");
            smtpClient.Credentials = credential;
            try
            {
                smtpClient.Send(msg);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}