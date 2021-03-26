using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebHook_Deleter
{
    static class Program
    {
        //reqbin.com
        static void Main()
        {

            Console.Write("WebHook : ");
            var url = Console.ReadLine();
            Console.Clear();
            delete(url);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Main();
            

        }
        static void delete(string url)
        {
  
            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "DELETE";

            httpRequest.Accept = "*/*";
           
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                Console.WriteLine("Success, WebHook Deleted");
            }
            catch { wrongwebhook(); }
        }
        static void wrongwebhook()
        {
            Console.WriteLine("Unknown Webhook\ncode : 10015");
        }
    }
}
