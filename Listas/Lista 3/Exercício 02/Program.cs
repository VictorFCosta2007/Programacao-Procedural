using System;

class Program
{
    static void Main(string [] args)
    {
        System.Console.WriteLine("Quantidade de itens no carrinho");        
        int qtdeItensComprados = int.Parse(Console.ReadLine());       
        
        double precoTotal = 0;

        int contador = 1;
        
        const double FRETE_GRATIS = 150;
        
        while(contador <= qtdeItensComprados)
        {
            System.Console.WriteLine($"Preco do {contador}º produto");
            double preco = double.Parse(Console.ReadLine());

            precoTotal = precoTotal + preco;
            contador++;
        }   
        if(precoTotal >= FRETE_GRATIS)
            {
                System.Console.WriteLine($"Parabens! Voce ganhou frete gratis em sua compra de valor {precoTotal}");
            }
            else
            {
                System.Console.WriteLine($"O valor da sua compra ficou de: {precoTotal}");
            }
    
    
    }
}