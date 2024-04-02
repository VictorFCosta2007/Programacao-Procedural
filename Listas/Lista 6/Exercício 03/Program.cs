using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
    
        int[,] matriz = new int [TAMANHO_MATRIZ,TAMANHO_MATRIZ];

        int somatorioDiagonal = 0;
        
        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                int valores = int.Parse(Console.ReadLine());

                if(linha == coluna)
                {
                    somatorioDiagonal = somatorioDiagonal + valores;
                }
            }
        }
        System.Console.WriteLine(somatorioDiagonal);
    }
}