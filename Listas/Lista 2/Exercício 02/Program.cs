using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Nota do primeiro Bimestre:");
        double primeiraNota = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Nota do Segundo Bimestre");
        double segundaNota = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Nota do Terceiro Bimestre");
        double terceiraNota = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Nota do Quarto Bimestre");
        double quartaNota = double.Parse(Console.ReadLine());

        double notaMedia = (primeiraNota + segundaNota + terceiraNota + quartaNota) / 4;

        if (notaMedia >=5)
        {
            System.Console.WriteLine("Aluno aprovado");
        }
        else if (notaMedia < 5 && notaMedia >= 3)
        {
            System.Console.WriteLine("Aluno em recuperacao");
        }
        else 
        {
            System.Console.WriteLine("Aluno reprovado");
        }      
    }
}
