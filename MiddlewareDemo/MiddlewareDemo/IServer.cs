using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareDemo
{
    interface IServer
    {
        public string Address { get; set; }
        void Connect(string Address);
        void Send(string message);
        void Receive(string message);

    }
}
