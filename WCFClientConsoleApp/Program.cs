using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClientConsoleApp
{
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            ListAllCatsFromService();

            Console.ReadLine();
        }

        private static void ListAllCatsFromService()
        {
            // get all cats from service
            // enumerate through all of them
            // write their data on the screen
            // and open their images in browser
            // hint: it can be done with a cmd command 
            // Process.Start("cmd.exe", "/C start \"\" \"http://google.com\"");
        }
    }
}
