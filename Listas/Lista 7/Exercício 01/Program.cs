using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    static void Main(String[] args)
    {
        int numero = Convert.ToInt32(Console.ReadLine()); 

        System.Console.WriteLine(VerificacaoNumero(numero)); 
    }
    static bool VerificacaoNumero(int numero)
    {
        return numero % 2 == 0;
    }
}