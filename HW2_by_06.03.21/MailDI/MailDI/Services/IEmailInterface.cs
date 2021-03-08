using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailDI
{
    public interface IEmailInterface
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
