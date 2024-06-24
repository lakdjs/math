using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());

            int[] mass = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(1, 10);
            }
            

            int temp = mass[0];

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i+1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];

                        mass[i] = mass[j];

                        mass[j] = temp;
                    }
                }
            }
            Console.Write("отсортированный массив : ");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            
            Console.WriteLine("HIndex = ");
            int h = HIndex(mass);
            Console.Write(h);

        }

        public static int HIndex(int[] arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dictionary.ContainsKey(arr[i]))
                {
                    dictionary.Add(arr[i],1);
                }
                else
                {
                    dictionary[arr[i]] += 1;
                }
            }
            int returning = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if(arr[i] <= dictionary[arr[i]])
                {
                    returning = arr[i];
                }
            }
            return returning;
        }
    }
}