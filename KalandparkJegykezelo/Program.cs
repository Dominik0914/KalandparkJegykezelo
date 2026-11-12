using KalandparkJegykezelo;
List<Jegyvasarlas> jelenlegi = new List<Jegyvasarlas>();
foreach(var sor in File.ReadAllLines("jegyek.txt"))
{
    jelenlegi.Add(new Jegyvasarlas(sor));
}