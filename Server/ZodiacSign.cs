using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ZodiacSign
    {
        public string zodiacSign { get; set; }
        public string startingDate { get; set; }
        public string endDate { get; set; }

        public ZodiacSign( string zodie, string startingDate, string endDate )
        {
            this.endDate = endDate;
            this.startingDate = startingDate;
            this.zodiacSign = zodie;
        }

    }


}
