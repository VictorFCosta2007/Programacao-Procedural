using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Base do Triângulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Altura do Triângulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double area = (baseTriangulo * alturaTriangulo) / 2;
        Console.WriteLine($"o valor da área é de: {area}");
        
        bool resultado = area > 20;

        Console.WriteLine($"A area do triângulo é maior que 20? {resultado}");

    }
}