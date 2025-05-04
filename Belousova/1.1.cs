/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        for (int i=2; i<=n; i++)
        {
            bool isPrime=true;
            for (int j=2; j*j<=i; j++)
            {
                if (i%j ==0)
                {
                    isPrime=false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine(i);
        }
    }
}