using Microsoft.Owin.Hosting;
using System;

namespace firstMicroService
{
    class Program
    {
        static void Main(string[] args)
        {
            string domainAddress = "http://localhost:44336";

            using (WebApp.Start(url: domainAddress))
            {
                Console.WriteLine(domainAddress);
                System.Threading.Thread.Sleep(-1);
            }
        }
    }
}