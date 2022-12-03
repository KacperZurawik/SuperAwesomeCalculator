using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading;
namespace test
{
    class MainMenu
    {
        public static void Menu()
        {
            for (; ; )
            {
                Console.Clear();
                WriteLogo();
                Say("1", "Add");
                Say("2", "Substract");
                Say("3", "Multiply");
                Say("4", "Divide");
                string option = Console.ReadLine();
                if (option == "1")
                {
                     

                }
                else if (option == "2")
                {

                }
                else if (option == "3")
                {

                }
                else if (option == "4")
                {
                    
                }
                else
                {
                    Console.WriteLine("Error! Please choose a valid option!");
                    Thread.Sleep(1500);
                }
            }
        }

        public static void Say(string prefix, string message)
        {
       
            Console.Write("[");
            Console.Write(prefix, Color.LawnGreen);
            Console.WriteLine("] " + message);
        }

        public static void WriteLogo()
        {
            string logo = @"

▄▀█ █▀█ █▀█ █░░ █ █▀▀ ▄▀█ ▀█▀ █ █▀█ █▄░█
█▀█ █▀▀ █▀▀ █▄▄ █ █▄▄ █▀█ ░█░ █ █▄█ █░▀█
";

            Console.WriteLine(logo, Color.LawnGreen);
        }
    }
}

