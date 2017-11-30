using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIMS
{
    public class ClientMessage
    {        
        public string Ip { get; set; }
        public string Alias { get; set; }
        public string Answer { get; set; }
        public bool StayConnected { get; set; }
    }
}
