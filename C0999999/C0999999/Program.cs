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
    
    static void Download()
    {

            Task.Run(() =>
           {
               Thread.Sleep(3000);
               Console.WriteLine("Download Complete..");
           });
         

            Thread.Sleep(3000);
            Console.WriteLine("Download complete...");
            Thread.Sleep(7000);
        }

        

    }
}
