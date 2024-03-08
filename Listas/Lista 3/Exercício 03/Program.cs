using System;

class Program
{
    static void Main(string[] args)
    {
        const string USUARIO_CORRETO = "admin";
        const string SENHA_CORRETA = "123senha";
        const int NUMERO_TENTATIVAS = 3;
        int contador = 0;

        do
        {
            System.Console.WriteLine("Digite o nome de usuario:");
            string usuarioInserido = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:");
            string senhaInserida = Console.ReadLine();

            if(usuarioInserido == USUARIO_CORRETO && senhaInserida == SENHA_CORRETA)
            {
                System.Console.WriteLine("Login realizado com sucesso!!");
                break;
            }
            else
            {
                System.Console.WriteLine("Nome de usuario ou senha incorretos. Tente novamente");

                contador++;
                if(contador >= NUMERO_TENTATIVAS)
                {
                    System.Console.WriteLine("Sua conta foi bloqueada");
                    break;
                }
            }
        
        }
        while(contador <= NUMERO_TENTATIVAS);        
    }
}