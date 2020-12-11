using System;

class MinhaClasse
{
    public static void Main(string[] args)
    {
        var idadeEmDias = int.Parse(Console.ReadLine());
        var anos = (idadeEmDias - (idadeEmDias % 365)) / 365; // Implemente aqui o calculo dos anos
        var meses = ((idadeEmDias - anos * 365) - ((idadeEmDias - anos * 365) % 30)) / 30; // Implemente aqui o calculo dos meses 
        var dias = idadeEmDias - (anos * 365 + meses * 30); // Implemente aqui o calculo dos dias

        Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
        
    }
}
