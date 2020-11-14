using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace CamadaModel.Servicos
{
    public class ServicoEmail
    {
        public string EmailRecuperacaoLogin(string email,string codigo)
        {


            string to = email;
            string from = "suporte.lumia@gmail.com";

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Suporte Lumia Recuperação de Senha";
            StringBuilder body = new StringBuilder();
            body.AppendLine("Recentemente, você solicitou a recuperação da senha da conta associada a este e-mail.");
            body.AppendLine($"Segue sua senha: {codigo}");
            body.AppendLine("Aconselhamos redefi-la.");
            message.Body = body.ToString();

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("suporte.lumia@gmail.com", "lumia12345678");

            try
            {
                smtp.Send(message);

                return "verifique sua caixa de e-mail";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
