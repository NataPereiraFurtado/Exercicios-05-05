using System;

namespace C_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Idade; 
            string Nome;
           
                Console.WriteLine("Qual o seu nome?");
                Nome = Console.ReadLine().ToLower();           
           
            do
            {

                Console.WriteLine("Qual a sua idade?");
                Idade = int.Parse(Console.ReadLine());


                if (Idade >= 0 && Idade <=150) 
                {
                
                }
                else
                {
                    Console.WriteLine("Sua idade não é valida.");
                }
            
            } while (Idade > 150);
            
             int Salaraio;

            do
            {
                Console.WriteLine("Qual o seu salário?");
                Salaraio = int.Parse(Console.ReadLine());

                if (Salaraio >0)
                {

                }
                else
                {
                    Console.WriteLine("Seu salário é invalido");
                }
            } while (Salaraio <=0);


                Console.WriteLine("Qual o seu estado civil?");
                Console.WriteLine("Solteiro(a)");
                Console.WriteLine("Casado(a)");
                Console.WriteLine("Viuvo(a)");
                Console.WriteLine("Divorciado(a)");
                string resposta = Console.ReadLine();

                

                 Console.WriteLine("Olá " + Nome + "!!!");
                 Console.WriteLine("Você tem " + Idade + " anos de idade");
                 Console.WriteLine("Seu salário é de " + Salaraio + " reais.");
                 Console.WriteLine("E seu estado civil é " + resposta);
              
        }
    }
}
