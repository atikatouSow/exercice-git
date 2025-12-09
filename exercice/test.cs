using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bonjour, ceci est mon premier test avec GitHub !");
        
        // Appel d'une petite fonction
        DireBonjour("Atikatou");
    }

    static void DireBonjour(string nom)
    {
        Console.WriteLine("Bonjour " + nom + " !");
    }

    static void DireAuRevoir()
{
    Console.WriteLine("Au revoir, modification depuis branche1 !");
}
}
