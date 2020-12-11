using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MiddlewareDemo
{
    class Middleware
    {
        IServer server;

        public void Connect(string address)
        {
            foreach(var server in Network.servers)
            {
                if (server.Address.Equals(address))
                {
                    this.server = server;
                    break;
                }
            }
            if(server == null)
            {
                Console.WriteLine("Requested host is not available");
            }
            
        }
        public void Send(string message)
        {
            if(server == null)
            {
                Console.WriteLine("Not connected with a server");
            }
            else
            {
                if(server.GetType() == typeof(LinuxServer))
                {
                    message = Regex.Replace(message, "(?<!\r)\n", "\r\n");
                }
                server.Receive(message);
            }
        }
    }
}
