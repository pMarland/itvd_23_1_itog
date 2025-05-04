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
        Console.Write("Введите первое число: ");
        int a=int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b=int.Parse(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int c=int.Parse(Console.ReadLine());
        int result=0;
        for (int i=0; i<32; i++)
        {
            int bitA=(a>>i)&1;
            int bitB=(b>>i)&1;
            int bitC=(c>>i)&1;

            int sum=bitA+bitB+bitC;
            if (sum>=2)
                result |=(1<<i);
        }
        Console.WriteLine("Результат:"+result);
    }
}