using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareDemo
{
    static class Network
    {
        static readonly public List<IServer> servers = new List<IServer>();
    }
}
