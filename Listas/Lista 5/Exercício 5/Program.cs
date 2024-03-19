using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        const int AREA_MAXIMA = 8;
        
        for(int linha = 0; linha < AREA_MAXIMA; linha ++ )
        {
            if(linha % 2 == 0)
            {
                for(int coluna = 0; coluna < AREA_MAXIMA; coluna ++)
                {
                    Tabuleiro.Adicionar(linha, coluna, "C");
                }
            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}