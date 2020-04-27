using System;
using System.Collections.Generic;
using System.Numerics;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {

            using (Server server = new Server(Configuration.HOST, Configuration.PORT))
            {
                server.CloseServerAction = () => Console.ReadLine();
                server.Start();
            }
           
        }

    }
}
