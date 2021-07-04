using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int[] evens = new int[10];
    int[] odds = new int[10];
    int n,i=0,j=0,k=0;

    while (i < 10) {
      Console.WriteLine("Enter a number:");
      n = Convert.ToInt32(Console.ReadLine());

      if (n % 2 == 0) {
        evens[j] = n;
        j++;
      } else {
        odds[k] = n;
        k++;
      }
      i++;
    }
    Console.WriteLine("\n");

    Array.Sort(evens);
    Array.Sort(odds);
    Array.Reverse(odds);
    foreach (int num in odds) {
      if (num != 0) {
        Console.WriteLine(num);
      }
    }
    Console.WriteLine("\n");
    foreach (int num in evens) {
      if (num != 0) {
        Console.WriteLine(num);
      }
    }

    Console.WriteLine("\nOdds Sum: " + odds.Sum());
    Console.WriteLine("Evens Sum: " + evens.Sum());
  }
}