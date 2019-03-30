using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C0999999
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading a file");
            Download();
            Console.ReadLine();
        }
    
        static async void Download()
        {   await Network.Download();
            Console.WriteLine("Download complete");  }
    }

    class Network
    {
        static public Task Download()
        {
            return Task.Run(
                    () => Thread.Sleep(3000));
        }
    }

}
