using System;

namespace _3
{
    class Desafio_3
    {
        static void Main(string[] args)
        {
            string startInput = Console.ReadLine();
            string[] inputArray = startInput.Split(" ");

            if (Int32.TryParse(inputArray[0], out int quantPessoas) && Int32.TryParse(inputArray[1], out int quantDatas))
            {
                string dataPossivel = "Pizza antes de FdA";
                
                for (int i = 1; i <= quantDatas; i++)
                {
                    string[] dataEpessoas = Console.ReadLine().Split(" ");
                    string dataAtual = dataEpessoas[0];
                    int pessoas = 0;
                    for (int i2 = 1; i2 < dataEpessoas.Length; i2++)
                    {
                        pessoas += Int32.Parse(dataEpessoas[i2]);
                    }

                    if (pessoas == quantDatas && dataPossivel == "Pizza antes de FdA")
                    {
                        dataPossivel = dataAtual;
                    }
                }

                Console.WriteLine(dataPossivel);
            }
        }
    }
}
