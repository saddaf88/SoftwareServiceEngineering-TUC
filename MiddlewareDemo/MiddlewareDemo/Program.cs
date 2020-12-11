using System;

namespace MiddlewareDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is a demo project for understanding the middleware");
            Console.WriteLine("***************************************************************");

            Network.servers.Add(new WindowsServer("190.162.108.1:90000", new Middleware()));
            Network.servers.Add(new LinuxServer("190.162.108.3:800", new Middleware()));
            Network.servers.Add(new WindowsServer("190.162.106.1:5000", new Middleware()));

            var ind = new Random().Next(Network.servers.Count);
            IServer server = Network.servers[ind];

            server.Connect("190.162.108.1:90000");
            server.Send("Ola\nThe server is connected");
            server.Connect("190.162.108.3:800");
            server.Send("Ola\nThe server is connected");


        }
    }
}
