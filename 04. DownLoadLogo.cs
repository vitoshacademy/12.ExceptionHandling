// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
// Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Linq;
using System.Net;
using System.Threading;

class LogoDownLoad
{
    static void Main()
    {
        using (WebClient picture = new WebClient())
        {
            try
            {
                Console.WriteLine("This program downloads a logo on your desktop.");
                string path = Environment.ExpandEnvironmentVariables(@"%UserProfile%\Desktop\logo-basd.jpg");
                picture.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", path);
                Console.WriteLine();
                Console.WriteLine("D O W N L A D I N G");
                Thread.Sleep(800); 
                Console.WriteLine();
                Console.WriteLine("Logo is downloaded!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You entered an empty address.");
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
        }

    }
}
