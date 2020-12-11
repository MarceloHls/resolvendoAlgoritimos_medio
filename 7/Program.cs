using System;

namespace _7
{
    class Desafio_7
    {
        static void Main(string[] args)
        {


            int quantPlacas = Int32.Parse(Console.ReadLine());

            string[] resultado = new string[quantPlacas];



            for (int indice = 0; indice < quantPlacas; indice++)
            {
                /// Inicia Como falha
                resultado[indice] = "FALHA";
                string input = Console.ReadLine();

                if (input.Length == 8 && input[3].ToString().Contains("-"))
                {

                    // Tranformar chars em strings para ter outros metodos
                    string[] placa = new string[8];
                    for (int i = 0; i <= 7; i++)
                    {
                        placa[i] = $"{input[i]}";
                    }

                    // Comparar as letras da placa

                    string[] letras = { "a", "b", "c", "d","f", "g","h", "i","j", "k","l", "m","n",
             "o","p", "q","r","s","t","u", "v","w", "x","y", "z"};
                    bool[] letrasPlaca = { false, false, false };

                    for (int i = 0; i <= 2; i++)
                    {
                        for (int i2 = 0; i2 < letras.Length && !letrasPlaca[i]; i2++)
                        {
                            if (placa[i].Contains(letras[i2].ToUpper()))
                            {
                                letrasPlaca[i] = true;
                            }
                        }
                    }


                    /// Compara os numeros da placa

                    string[] numeros = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                    bool[] numerosPlaca = { false, false, false, false };

                    for (int i = 4; i <= 7; i++)
                    {
                        for (int i2 = 0; i2 < numeros.Length && !numerosPlaca[i - 4]; i2++)
                        {
                            if (placa[i].Contains(numeros[i2].ToUpper()))
                            {
                                numerosPlaca[i - 4] = true;
                            }
                        }
                    }

                    /// Verifica qual o ultimo numero da placa
                    string semama = "";
                    switch (placa[7])
                    {
                        case "1":
                        case "2":
                            {
                                semama = "SEGUNDA";
                                break;
                            }
                        case "3":
                        case "4":
                            {
                                semama = "TERCA";
                                break;
                            }
                        case "5":
                        case "6":
                            {
                                semama = "QUARTA";
                                break;
                            }
                        case "7":
                        case "8":
                            {
                                semama = "QUINTA";
                                break;
                            }
                        case "9":
                        case "0":
                            {
                                semama = "SEXTA";
                                break;
                            }
                    }

                    /// Verifica se todos parametros estão corretos e reornar o dia da semana

                    bool dadosCorretos = true;
                    foreach (bool letra in letrasPlaca)
                    {
                        if (!letra)
                        {
                            dadosCorretos = false;
                        }
                    }

                    foreach (bool numero in numerosPlaca)
                    {
                        if (!numero)
                        {
                            dadosCorretos = false;
                        }
                    }

                    if (dadosCorretos)
                    {
                        resultado[indice] = semama;
                    }


                }


            }


            foreach (string placa in resultado)
            {
                Console.WriteLine(placa);
            }


        }
    }
}



