// using SendGrid's C# Library
// https://github.com/sendgrid/sendgrid-csharp
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SendGridStudy
{
    internal class Example
    {
        private static void Main()
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            var apiKey = "api key";
            var client = new SendGridClient(apiKey);
            var to = new EmailAddress("test@test.com", "test test");
            var from = new EmailAddress("test@test.com", "test test");
            var templateId = "Unique template Id";

            var data = new { Name = "test" };

            var message = MailHelper.CreateSingleTemplateEmail(from, to, templateId, data);

            await client.SendEmailAsync(message);
        }
    }
}


