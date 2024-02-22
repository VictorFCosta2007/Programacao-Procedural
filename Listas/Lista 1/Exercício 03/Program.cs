using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantidade de centavos: ");
        int cents1 = int.Parse(Console.ReadLine());

        int real = cents1 / 100 ;
        int cents2 = cents1 % 100;

        Console.WriteLine($"O total de dinheiro é: {real} real(is) e {cents2} centavos(s)");
    }
}