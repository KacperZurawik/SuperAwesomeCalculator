using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "login";
            //login stuff
            MainMenu.WriteLogo();
            Console.WriteLine("Welcome back! ...Or just maybe first time");
            Console.ReadKey(true);
            MainMenu.Menu();
        
        
        }
    }
}
