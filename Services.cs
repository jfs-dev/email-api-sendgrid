using SendGrid;
using SendGrid.Helpers.Mail;

namespace email_api_sendgrid;

public static class Services
{
    public static async Task<Response> SendMessageSendGrid()
    {
        var client = new SendGridClient(Configuration.ApiKeySendGrid);
        var from = new EmailAddress("remetente@dominio.com.br", "Nome do Remetente");
        var subject = "Meu primeiro e-mail com SendGrid";
        var to = new EmailAddress("destinatario@dominio.com.br", "Nome do Destinatário");
        var plainTextContent = "Meu primeiro e-mail com SendGrid";
        var htmlContent = "<p>Olá!<br><br>Realmente é muito fácil enviar um e-mail usando a opção e-mail API da SendGrid.<br><br> <strong>Concordam?</strong></p>";
        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

        return await client.SendEmailAsync(msg);
    }
}
