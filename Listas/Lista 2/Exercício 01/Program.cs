using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Nome de Usuario: ");
        string nomeDoUsuario = Console.ReadLine();

        System.Console.WriteLine("Senha do Usuario: ");
        string SenhaDoUsuario = Console.ReadLine();

        if (nomeDoUsuario == "admin" && SenhaDoUsuario == "123senha")
        {
            System.Console.WriteLine("Login realizado com sucesso!");

        }
        else
        {
            System.Console.WriteLine("Credencias invalidas...");
        }
   
   
   
   
    }   


}