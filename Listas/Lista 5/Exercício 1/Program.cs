using System;

class Program
{
    static void Main(string[] args)
    {
        const int MAXIMO = 100;
        
        const int MINIMO = 0;

        int i = 0;

        int j = 204;

        while(i <= MAXIMO && j >= MINIMO)
        {
            j -= 4;
            
            System.Console.WriteLine($"{i} - {j}");

            i += 2;
        }
    }
}