using email_api_sendgrid;

var result = await Services.SendMessageSendGrid();

Console.WriteLine(result.IsSuccessStatusCode ? "E-mail enviado com sucesso!" : "Falha ao enviar o e-mail!");
