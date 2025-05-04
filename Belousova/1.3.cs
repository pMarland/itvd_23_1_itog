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
        Console.Write("Введите a: ");
        double a=double.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        double b=double.Parse(Console.ReadLine());
        Console.Write("Введите c: ");
        double c = double.Parse(Console.ReadLine());
        if (a==0 && b==0)
        {
            Console.WriteLine(c==0? "Бесконечно много решений" : "Нет решений");
        }
        else if (a==0)
        {
            double x=-c/b;
            Console.WriteLine("Одно решение: x="+x);
        }
        else
        {
            double d=b*b-4*a*c;
            if (d<0)
                Console.WriteLine("Нет решений");
            else if (d==0)
                Console.WriteLine("Одно решение: x = " + (-b/(2*a)));
            else
            {
                double x1=(-b+Math.Sqrt(d))/(2*a);
                double x2=(-b-Math.Sqrt(d))/(2*a);
                Console.WriteLine("Два решения: x1 = "+x1+",x2= "+x2);
            }
        }
    }
}