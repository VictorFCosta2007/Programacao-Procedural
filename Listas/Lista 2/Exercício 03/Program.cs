using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Gostaria de visualizar a rotina de Filomena ou Joselito?");
        string nomeDaCrianca = Console.ReadLine();

        if(nomeDaCrianca == "Filomena")
        {
            System.Console.WriteLine("1. Escola das 07h as 12h \n2. Almoço das 12h as 13h");
            System.Console.WriteLine("3. Futebol das 14h as 16h \n4. Dever de casa das 16h as 18h");
        }
        else if (nomeDaCrianca == "Joselito")
        {
            System.Console.WriteLine("1. Escola das 07h as 12h \n2. Almoço das 13h as 14h");
            System.Console.WriteLine("3. Natação das 14h as 16h \n4. Reforço escolar das 16h as 19h");
        }
        else
        {
            System.Console.WriteLine("Nome invalido ou incorreto...");
        }
    
    
    }
}