using System;

class Program
{
    static void Main(string[] args)
    {
        const int LIMITE = 9;
        
        System.Console.WriteLine("insira um número");
        int altura = int.Parse(Console.ReadLine());

        if(altura <= LIMITE)
        {
            System.Console.WriteLine();
            for(int i = 1; i <= altura; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                System.Console.Write(j);
            }
            System.Console.WriteLine();
        }
        }
        else
        {
            System.Console.WriteLine("Altura invalida, insira uma altura entre 1 e 9");
        }
    }
}