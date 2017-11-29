using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Message
    {
        public string Alias { get; set; }
        public string IP { get; set; }
        public string Answer { get; set; }
        public bool StayConnected { get; set; }
    }
}
