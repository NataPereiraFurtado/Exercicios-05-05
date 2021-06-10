using System;

namespace C_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nota;

            do
            {
                Console.WriteLine("Por favor insira sua nota (0/10)");
                Nota = int.Parse(Console.ReadLine());

                if (Nota >= 0 && Nota <= 10)
                {

                    Console.WriteLine("Sua nota é " + Nota);

                }
                else
                {
                    Console.WriteLine("Sua nota " + Nota + " é invalida.");
                }
            } while (Nota >= 10);




        }
    }
}