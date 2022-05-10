using System;
using System.Threading.Tasks;

namespace ShoppingCartStore.Services.DataServices.Implementations
{
    class EmailSender:IEmailSender
    {
        public EmailSender()
        {
        }

        public Task SendEmailAsync(string input, string subject, string body) { return Task.CompletedTask; }
    }
}
