using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Quarta nota: ");
        double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine($"A média do Aluno é: {media} ");

    }
}