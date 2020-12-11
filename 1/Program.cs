using System;

namespace _1
{
    class Desafio_1
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(" ");

            // Verifica se é possivel tranformar em int e retornar voltas e placas
            if (Int32.TryParse(inputArray[0], out int voltas) && Int32.TryParse(inputArray[1], out int placas))
            {
                int totalDePlcas = voltas * placas;
                string listaDeValores = "";
                for (int i = 1; i < 10; i++)
                {
                    // Tranformar em decimal para fazer o calculo de porcentagem
                    var percentual = Convert.ToDecimal(i) / 10;
                    var resultado = Math.Ceiling(percentual * totalDePlcas);

                    listaDeValores += $"{resultado} ";

                }

                Console.WriteLine(listaDeValores);
            }
        }
    }
}
