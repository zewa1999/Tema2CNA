using Grpc.Core;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text.RegularExpressions;

namespace Client
{
    class Program
    {
        static bool DateVerification(string date)
        {
            string dateRegex = @"((0?[1-9]|1[0-2])\/(0?[1-9]|[12][0-9]|3[01])\/([1-9][0-9]{0,3}))";
            if (date != string.Empty)
            {
                Match match = Regex.Match(date, dateRegex);
                if (match.Value == date)
                {
                    string[] splitDate = date.Split('/');
                    int month = int.Parse(splitDate[0]);
                    int day = int.Parse(splitDate[1]);
                    int year = int.Parse(splitDate[2]);


                    //luna februarie
                    if (month == 2 && year % 4 == 0 && year % 100 != 0 && year % 400 == 0 && day > 28)
                    {
                        return false;

                    }

                    else
                    { // luni cu 30 de zile
                        if ((month == 4 || month == 6) || month == 9 || month == 11 && day > 30)
                        {
                            return false;
                        }
                    }
                    return true;

                }

            }
            return false;
        }
        static void Main(string[] args)
        {
            const string Host = "localhost";
            const int Port = 17524;

            var channel = new Channel($"{Host}:{Port}", ChannelCredentials.Insecure);

            Console.WriteLine("When is your birthday? -format (MM/DD/YYYY)");

            var birthDate = Console.ReadLine();

            if (DateVerification(birthDate))
            {

                var client = new Generated.ZodiacSignService.ZodiacSignServiceClient(channel);
                var output = client.GetZodiacSign(new Generated.Date
                {
                    Date_ = birthDate
                });
                Console.WriteLine("Your Zodiac sign is: {0} ", output.Zodie_);

            }
            else
            {
                Console.WriteLine("Date format invalid - MM/DD/YYYY");
            }

            // Shutdown
            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any button to finish...");
            Console.ReadKey();
        }
    }
}
