using System;

namespace C_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
           string senhaUsuario;
           string nomeUsuario;
            do
            {
                Console.WriteLine("Escolha um nome de Usuário");
                nomeUsuario = Console.ReadLine();

                Console.WriteLine("Crie uma senha"); 
                senhaUsuario = Console.ReadLine();


                if (nomeUsuario == senhaUsuario)
                {

                    Console.WriteLine("Sua senha não pode ser igual ao Usuário, por favor escola outra senha.");
            
                }
                else
                {
                    Console.WriteLine("Usuário e senha registrados com sucesso.");
                
                }
            }  while (nomeUsuario == senhaUsuario);
        }
    }
}
