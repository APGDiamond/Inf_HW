using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailDI
{
    public class EmailConfig
    {
        public string From { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; }
    }
}
