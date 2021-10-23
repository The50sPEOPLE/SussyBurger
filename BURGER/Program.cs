using System;
using System.Threading;

namespace BURGER
{
    class Program
    {
        static void Main(string[] args)
        {
            int order;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WELCOME TO 50sKING \nHeres Our Menu");
            Console.WriteLine("POOP = 1 \nSHEET = 2 \nPOPO = 3 \nwhat will u like to order?");
            order = Convert.ToInt32(Console.ReadLine());

            if(order == 1)
            {
                Console.WriteLine("POOP is it...");
            }
            else if(order == 2)
            {
                Console.WriteLine("SHEET IS ON UR WAY....");
            }
            else if(order == 3)
            {
                Console.WriteLine("POPO IS THE ORDER!!");
            }
                OrderNUMB();
            
            void OrderNUMB()
            {
                Random Number = new Random();
                int order = Number.Next(1, 60);

                Console.WriteLine("OK SIR, your order will be in " + order);

            }
            Console.ReadKey();

            for (int i = 0; order < 60; i++)
            {
                if(i % 1 == 0)
                Thread.Sleep(1000);
                Console.WriteLine(i); 
               
            }

            






            Console.ReadKey();
        }
    }
}
