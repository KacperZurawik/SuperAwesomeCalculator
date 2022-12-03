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
                Console.WriteLine("I am sorry, but you can put only 2 numbers. Wait for updates.");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Put your first number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Put your second number: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int result = a + b;
                    Console.WriteLine("your result is = " + result);
                    Console.ReadKey();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Put your first number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Put your second number: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int result = a - b;
                    Console.WriteLine("your result is = " + result);
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Put your first number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Put your second number: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int result = a * b;
                    Console.WriteLine("your result is = " + result);
                    Console.ReadKey();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Put your first number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Put your second number: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int result = a / b;
                    Console.WriteLine("your result is = " + result);
                    Console.ReadKey();
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


█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ ▀█▀ █▀█ █▀█
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ ░█░ █▄█ █▀▄
";

            Console.WriteLine(logo, Color.LawnGreen);
        }
    }
}

