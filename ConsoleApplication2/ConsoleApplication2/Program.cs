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

            doors[doors.Length - 1] = 1;
            int wins = 0;
            int los = 0;

            for (int i = 0; i < it; i++)
            {
                int choice = rnd.Next(0, doorsQuantity);
                    
                if (stayOfChange && choice == doors[doors.Length])
                {
                    wins++;
                }
                else if(!stayOfChange && choice == doors[doors.Length])
                {
                    los++;
                }
                else if (stayOfChange && choice != doors[doors.Length])
                {
                    los++;
                }
                else if (!stayOfChange && choice != doors[doors.Length])
                {
                    wins++;
                }
            }
            Console.WriteLine($"wins : {wins}, loses : {los}");
        }
    }
}