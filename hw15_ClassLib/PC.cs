using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace hw15_ClassLib
{
    public class PC
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public double Price { get; set; }

        public PC():this("noname")
        {
        }
        public PC(string name):this(name,"000000")
        {
            Name = name;
        }
        public PC(string name,string serial):this(name, serial, 0.0)
        {
            Name = name;
            SerialNumber = serial;
        }
        public PC(string name,string serial, double price)
        {
            Name = name;
            SerialNumber = serial;
            Price = price;
        }

        public void turnOn()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wait until computer {0} is loading", Name);
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 50; i++)
            {
                Console.Write(".");
                Thread.Sleep(rnd.Next(10, 101));
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nComputer {0} is ready to work!",Name);
            Console.ResetColor();
        }

        public void turnOff()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wait until computer {0} is preparing to turn off", Name);
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 50; i++)
            {
                Console.Write(".");
                Thread.Sleep(rnd.Next(10, 101));
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nComputer {0} is turned off!", Name);
            Console.ResetColor();
        }

        public void reset()
        {
            turnOff();
            turnOn();
        }

    }
}
