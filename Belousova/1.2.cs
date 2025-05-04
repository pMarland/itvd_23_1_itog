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
        Console.Write("Введите делимое(a): ");
        int a=int.Parse(Console.ReadLine());

        Console.Write("Введите делитель (b): ");
        int b=int.Parse(Console.ReadLine());

        if (b<=0)
        {
            Console.WriteLine("Ошибка:делитель должен быть положительным.");
            return;
        }

        int quotient=0;
        int sum=b;

        if (a>=0)
        {
            while (sum<=a)
            {
                quotient++;
                sum += b;
            }
        }
        else
        {
            while (sum<=-a)
            {
                quotient++;
                sum+=b;
            }
            quotient=-quotient;
        }

        Console.WriteLine("Неполное частное: "+quotient);
    }
}
