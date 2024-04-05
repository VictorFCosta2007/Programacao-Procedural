using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int [TAMANHO_MATRIZ,TAMANHO_MATRIZ];
    
        PreencherMatriz(matriz);
        ImprimirTabuleiro(matriz);

        VerificarBalistaExistente(matriz);
    }

    static void PreencherMatriz(int[,] matriz)
    {
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                matriz[i,j] = Convert.ToInt32(Console.ReadLine()); 
            }
        }
    }

    static void ImprimirTabuleiro(int[,] matriz)
    {
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                System.Console.Write($"|{matriz[i,j]}|");
            }
            System.Console.WriteLine();
        }
    }
    
    
    static void VerificarBalistaExistente(int[,] matriz)
    {
        bool temBalista = false;
        
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if(matriz[i,j] == 0)
                {
                    temBalista = true;
                } 
            }
        }
        if(temBalista)
        {
            System.Console.WriteLine("Fique atento! existem balistas no tabuleiro");
        } 
        else
        {
            System.Console.WriteLine("nao ha balistas no tabuleiro");
        }
    }
}