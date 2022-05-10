using System;
using System.Threading.Tasks;

namespace ShoppingCartStore.Services.DataServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string input, string subject, string body);
    }

    
}
