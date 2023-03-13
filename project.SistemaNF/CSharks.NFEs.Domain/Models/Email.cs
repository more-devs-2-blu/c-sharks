using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models
{
    public class Email
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public string Clients { get; set; }

        public string Host { get; set; }
        public string Display { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }    
        public int Port { get; set; }   
    }


}
