using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace CamadaControler.Servicos
{
    public class ServicoEmail
    {
        public string EmailRecuperacaoLogin()
        {
            string to = "lucas.developerdebug@gmail.com";
            string from = "lucas.amocristo@gmail.com";

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Lumia Recuperação de Senha Teste";
            StringBuilder body = new StringBuilder();
            body.AppendLine("Recentemente, você solicitou a recuperação da senha da conta associada a este e-mail.");
            body.AppendLine("Segue sua senha: 536152211.");
            body.AppendLine("Aconselhamos redefi-la.");
            message.Body = body.ToString();

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("lucas.amocristo@gmail.com", "luki@42083866");

            try
            {
                smtp.Send(message);

                return "verifique sua caixa de e-mail";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
