using System;
using Xunit;

namespace URLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a demo project for URL parser");
            Console.WriteLine("**************************************");
            var fullURL = "http://www.tu-chemnitz.de:8080/ein%20test?my-name=my-value&a=1#id";
            URL Url = new URL(fullURL);
            Console.WriteLine("The full URL is : "+ fullURL);
            Console.WriteLine("Scheme: " + Url.Scheme);
            Console.WriteLine("Host: " + Url.Host);
            Console.WriteLine("Port : " + Url.Port);
            Console.WriteLine("Path: " + Url.Path);
            Console.WriteLine("Query: " + Url.Query);
            Console.WriteLine("FragmentId: " + Url.FragmentId);


        }
    }
}
