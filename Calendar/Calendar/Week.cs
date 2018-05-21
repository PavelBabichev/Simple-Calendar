using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
   public class Week
    {
       public Week(string Mon, string Tues, string Wen, string Thu, string Fr, string Sat, string Sn)
       {
           Monday = Mon;
           Tuesday = Tues;
           Wednesday = Wen;
           Thursday = Thu;
           Friday = Fr;
           Saturday = Sat;
           Sunday = Sn;
       }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }

    }
}
