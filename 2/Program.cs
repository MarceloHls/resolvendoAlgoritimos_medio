using System;

namespace _2
{
    class Desafio_2
    {
        static void Main(string[] args)
        {
            string refeicoes = Console.ReadLine();
            string[] refeicoesArray = refeicoes.Split(" ");
            string passageiros = Console.ReadLine();
            string[] passageirosArray = passageiros.Split(" ");

            bool calPossivel = true;

            int[] refeicoesInt = new int[3];
            int[] passageirosInt = new int[3];

            for (int i = 0; i <= 2 && calPossivel; i++)
            {
                if (Int32.TryParse(refeicoesArray[i], out int refeicao) && Int32.TryParse(passageirosArray[i], out int passageiro))
                {
                    refeicoesInt[i] = refeicao;
                    passageirosInt[i] = passageiro;

                }
                else
                {
                    calPossivel = false;
                }
            }

            if (calPossivel)
            {
                int ref1 = (passageirosInt[0] - refeicoesInt[0]) < 0 ? 0 : passageirosInt[0] - refeicoesInt[0];
                int ref2 = (passageirosInt[1] - refeicoesInt[1]) < 0 ? 0 : passageirosInt[1] - refeicoesInt[1];
                int ref3 = (passageirosInt[2] - refeicoesInt[2]) < 0 ? 0 : passageirosInt[2] - refeicoesInt[2];

                int resultado = ref1 + ref2 + ref3;
                Console.WriteLine(resultado);

            }
        }
    }
}
