using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Call
    {
        //Fields and Properties - Start.
        private DateTime callDate;
        
        public string CallDate
        {
            get { return callDate.ToString("dddd, dd MMMM yyyy"); }
        }

        public string Time
        {
            get { return callDate.ToString("hh:mm tt"); }
        }

        private string dialedPhone;
        public string DialedPhone { get; private set; }

        public long Duration { get; set; }
        //Fields and Properties - End.

        //Constructors
        public Call(DateTime callDate, string dialedPhone)
        {
            this.callDate = callDate;
            this.dialedPhone = dialedPhone;
        }

        public override string ToString()
        {
            return string.Format("\nCall Date: {0}\nCall Time: {1}\nDialed Phone: {2}\nDuration: {3}s", 
                CallDate, Time, dialedPhone, Duration);
        }
    }
}
