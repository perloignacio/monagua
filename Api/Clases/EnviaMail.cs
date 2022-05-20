using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MailKit.Net.Smtp;
using MailKit.Security;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using MimeKit;

namespace API.Clases
{
    public static class EnviaMail
    {
        public static void Envia(MimeMessage message)
        {
            SmtpClient client = new SmtpClient();
            client.ServerCertificateValidationCallback += TrustingCallBack;
            client.Connect("dtc027.ferozo.com", 465, SecureSocketOptions.Auto);
            client.Authenticate("hola@minilent.com", "H0laM1nil3nt*");
            client.Send(message);

        }
        private static bool TrustingCallBack(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // The logic for acceptance of your certificates here
            return true;
        }
    }
}