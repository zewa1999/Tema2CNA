using Grpc.Core;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Host = "localhost";
            const int Port = 17524;

            var channel = new Channel($"{Host}:{Port}", ChannelCredentials.Insecure);

            Console.WriteLine("Numele tau: ");

            do
            {
                var key = Console.ReadLine();

                var client = new Generated.NameRequestService.NameRequestServiceClient(channel);

                client.OutputName(new Generated.Name
                {
                    Name_ = key
                });
            } while (true);

            // Shutdown
            channel.ShutdownAsync().Wait();
            Console.WriteLine("Apasa orice tasta pentru a iesi...");
            Console.ReadKey();
        }
    }
}
