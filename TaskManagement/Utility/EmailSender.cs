using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TaskManagement.Utility
{
    public class EmailSender : IEmailSender
    {
            public async Task SendEmailAsync(string email, string subject, string htmlMessage)
            {
                var Key1 = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Credintials")["Key1"];
                var Key2 = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Credintials")["Key2"];

                MailjetClient client = new MailjetClient(Key1, Key2)
                {

                };

                MailjetRequest request = new MailjetRequest
                {
                    Resource = Send.Resource,
                }
                .Property(Send.FromEmail, "anoop.kulkarni2021@gmail.com")
                .Property(Send.FromName, "Task Manager")
                .Property(Send.Subject, subject)
                .Property(Send.HtmlPart, htmlMessage)
                .Property(Send.Recipients, new JArray {
                new JObject {
                 {"Email", email}
                 }
                    });
                MailjetResponse response = await client.PostAsync(request);
            }
        
    }
}
