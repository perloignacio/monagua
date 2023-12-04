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
            client.Connect("dtc022.ferozo.com", 465, SecureSocketOptions.Auto);
            client.Authenticate("monagua@monagua.com.ar", "M0n4Gu@159");
            client.Send(message);

        }
        private static bool TrustingCallBack(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // The logic for acceptance of your certificates here
            return true;
        }
    }
}