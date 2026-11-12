using KalandparkJegykezelo;
using System.Security.Cryptography;
List<Jegyvasarlas> jelenlegi = new List<Jegyvasarlas>();
foreach(var sor in File.ReadAllLines("jegyek.txt"))
{
    jelenlegi.Add(new Jegyvasarlas(sor));
}
Console.WriteLine("Napi jegyvásárlások:");
foreach (var jegy in jelenlegi)
{
    Console.WriteLine(jegy);
}
Console.WriteLine("\nStatisztika:");
int oss =jelenlegi.Sum(a=>a.FizetendoOsszeg()) ;
var leg = jelenlegi.MaxBy(a => a.FizetendoOsszeg());
Console.WriteLine($"Kalandpark teljes napi bevétele: {oss} Ft");
Console.WriteLine($"Legtöbbet fizető látogató: {leg.LatogatoNeve} ({leg.FizetendoOsszeg()} Ft)");