using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        const int MINIMO = 1;
        
        const int MAXIMO = 10;
        
        for(int i = 10; i >= MINIMO; i--)
        {
            for(int j = 0; j <= 10; j++)
            {
                System.Console.WriteLine($"{i} x {j} = {i * j}");
            } 
            System.Console.WriteLine();
        }
    }
}