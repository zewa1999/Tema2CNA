using Generated;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace Server
{
    internal class ZodiacSignService: Generated.ZodiacSignService.ZodiacSignServiceBase
    {
        public override Task<Zodie> GetZodiacSign(Date request, ServerCallContext context)
        {
            Console.WriteLine("Client date: {0}", request.Date_);
            ZodiacList zodiacList = new ZodiacList();
            string zodiacSignOfClient = zodiacList.ReturnSign(request.Date_);
            Console.WriteLine("The sign is: {0}", zodiacSignOfClient);

            if(zodiacSignOfClient != string.Empty)
            {
                return Task.FromResult(new Zodie { Zodie_ = zodiacSignOfClient});

            }

            return Task.FromResult(new Zodie { Zodie_ = string.Empty });

        }
    }
}
