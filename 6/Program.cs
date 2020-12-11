using System;

namespace _6
{
    class Desafio_6
    {
        static void Main(string[] args)
        {
            int minutosRestantes = Int32.Parse(Console.ReadLine());
            string[] presentes = Console.ReadLine().Split(" ");
            int minutosNecessarios = 0;

            foreach (string minutos in presentes)
            {
                minutosNecessarios += Int32.Parse(minutos);
            }

            if (minutosNecessarios <= minutosRestantes)
            {
                Console.WriteLine("Farei hoje!");
            }
            else
            {
                Console.WriteLine("Deixa para amanha!");
            }

        }
    }
}
