using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Hosting.Self;

namespace dodgeball
{
    /// <summary>
    /// This class is the main entry point for the dodgeball server
    /// </summary>
    class DodgeballMain
    {
        static void Main(string[] args)
        {
            using(NancyHost host = new NancyHost(new Uri[] {new Uri("http://127.0.0.1:3000")}))
            {
                host.Start();
                Console.ReadLine();
            }
        }
    }
}
