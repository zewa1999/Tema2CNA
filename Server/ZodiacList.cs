using Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ZodiacList
    {
        private List<ZodiacSign> zodiacList = new List<ZodiacSign>();

        public ZodiacList()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("intervaleZodii.txt");


            while ((line = file.ReadLine()) != null)
            {
                string[] sign = line.Split(' ');

                ZodiacSign zodie = new ZodiacSign(sign[0], sign[1], sign[2]);
                zodiacList.Add(zodie);
            }
        }

        public string ReturnSign(string date) 
        {
            Console.WriteLine(date);
            string[] dateSplit = date.Split('/');
            int month = int.Parse(dateSplit[0]); 
            int day = int.Parse(dateSplit[1]); 

            foreach(ZodiacSign zodie in zodiacList)
            {
                string[] startingDate = zodie.startingDate.Split('/');
                string[] endingDate = zodie.endDate.Split('/');

                if ((month == int.Parse(startingDate[0]) && day >= int.Parse(startingDate[1])) || (month == int.Parse(endingDate[0]) && day <= int.Parse(endingDate[1])))
                {
                    return zodie.zodiacSign;
                }


            }
            return string.Empty;
        }

    }
}
