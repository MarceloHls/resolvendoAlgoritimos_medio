using System;

namespace _4
{
    class Desafio_4
    {
        static void Main(string[] args)
        {
            int segundos = Int32.Parse(Console.ReadLine());
            int minutos = 0, horas = 0;

            if (segundos >= 60)
            {
                int temp1 = segundos % 60;
                minutos = (segundos - temp1) / 60;
                segundos = temp1;

                if (minutos >= 60)
                {
                    int temp = minutos % 60;
                    horas = (minutos - temp) / 60;
                    minutos = temp;
                }
            }

            Console.WriteLine($"{horas}:{minutos}:{segundos}");

        }
    }
}
