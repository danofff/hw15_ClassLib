using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace hw15_ClassLib
{
    [Serializable]
    public class PC
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public double Price { get; set; }

        private bool isOn=false;    

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
            if (isOn)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("COMPUTER {0} IS WORKING", Name);
                Console.ResetColor();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wait until computer {0} is loading", Name);
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 50; i++)
            {
                Console.Write(".");
                Thread.Sleep(rnd.Next(10, 201));
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nComputer {0} is ready to work!",Name);
            Console.ResetColor();
            isOn = true;
        }

        public void turnOff()
        {
            if (!isOn)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("COMPUTER {0} IS NOT WORKING", Name);
                Console.ResetColor();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wait until computer {0} is preparing to turn off", Name);
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 50; i++)
            {
                Console.Write(".");
                Thread.Sleep(rnd.Next(10, 201));
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nComputer {0} is turned off!", Name);
            Console.ResetColor();
            isOn = false;
        }

        public void reset()
        {
            if (!isOn)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("COMPUTER {0} IS NOT WORKING", Name);
                Console.ResetColor();
                return;
            }
            turnOff();
            turnOn();
        }

    }
}
