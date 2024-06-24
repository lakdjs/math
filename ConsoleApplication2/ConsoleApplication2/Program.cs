using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Doors(1000,3,true);
            Doors(1000,3,false);
            Console.ReadLine();
        }
        public static void Doors(int it, int doorsQuantity, bool stayOfChange)
        {
            Random rnd = new Random();
            int[] doors = new int[doorsQuantity];
            for (int i = 0; i < doors.Length; i++)
            {
                doors[i] = 0;
            }

            
            int wins = 0;
            int los = 0;

            for (int i = 0; i < it; i++)
            {
                int rightIndex = rnd.Next(0, doors.Length);
                doors[rightIndex] = 1;
                int choice = rnd.Next(0, doorsQuantity);
                    
                if (stayOfChange && choice == doors[rightIndex])
                {
                    wins++;
                }
                else if(!stayOfChange && choice == doors[rightIndex])
                {
                    los++;
                }
                else if (stayOfChange && choice != doors[rightIndex])
                {
                    los++;
                }
                else if (!stayOfChange && choice != doors[rightIndex])
                {
                    wins++;
                }
            }
            Console.WriteLine($"wins : {wins}, loses : {los}");
        }
    }
}