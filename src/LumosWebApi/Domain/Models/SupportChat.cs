using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumos.Domain.Models
{
    public class SupportChat
    {
        public int SupportChatId { get; set; }
        public int ManagerId { get; set; }
        public int CustomerId { get; set; }
    }
}
