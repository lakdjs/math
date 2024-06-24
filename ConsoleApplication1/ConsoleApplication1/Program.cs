using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Random random = new Random();
      Console.WriteLine("сколько дурачков стоит?");
      int n = int.Parse(Console.ReadLine());

      int[] monetki = new int[n];

      for (int i = 0; i < monetki.Length; i++)
      {
        monetki[i] =  random.Next(0, 30);
      }
      
      for (int i = 0; i < monetki.Length; i++)
      {
        Console.Write(monetki[i] + " ");
      }
    }
  }
}