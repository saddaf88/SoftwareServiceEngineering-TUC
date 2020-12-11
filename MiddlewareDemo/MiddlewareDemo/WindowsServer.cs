using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MiddlewareDemo
{
    class WindowsServer : IServer
    {
        private Middleware middleware;
        public string Address { get; set; }
        public WindowsServer(string address, Middleware middleware)
        {
            this.Address = address;
            this.middleware = middleware;
        }
        public void Connect(string toAddress)
        {
            middleware.Connect(toAddress);
        }

        public void Send(string message)
        {
            middleware.Send(message);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"[Windows Server] Received : \n {Regex.Escape(message)}");
        }
    }
}
