using System.IO;

namespace OOPReeks1ConsoleOef2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel standaard = new Cirkel();
           //variabelen declareren
            string kleur;
            double straal;
            
            //gerbruiker cirkel
           
            Console.WriteLine("wat is de kler van uw cirkel: ");
            kleur = Console.ReadLine();
            Console.WriteLine("wat is de straal van uw crikel: ");
            straal = double.Parse(Console.ReadLine());
            
            Cirkel mijnCirkel = new Cirkel(kleur, straal);

            //resultaten gebruiker cirkel
            Console.WriteLine($"De resultaten van mijn cirkel gekozen cirkel: ");
            Console.WriteLine($"De omtrek: {mijnCirkel.Omtrek()}");
            Console.WriteLine($"De oppervlakte: {mijnCirkel.Oppervlakte()}");

            //resultaten standaard cirkel
            Console.WriteLine($"De resultaten van de standaard cirkel: ");
            Console.WriteLine($"De omtrek: {standaard.Omtrek()}");
            Console.WriteLine($"De oppervlakte: {standaard.Oppervlakte()}");

            Console.ReadKey();  


        }
    }
}
