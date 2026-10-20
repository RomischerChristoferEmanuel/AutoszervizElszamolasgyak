using AutoszervizElszamolasgyak;
string[] c = File.ReadAllLines("reklamacio.txt");
Console.ForegroundColor=ConsoleColor.Green;
List<szerelo> dddd = new List<szerelo>();
int hj = 0;
int u;
double nhj = 0;
double i = 0;
foreach (string s in c)
{
    int x = 0;
    szerelo kkl =new szerelo();
    string[] jj= s.Split(';');
    kkl.Nev = jj[0];
    kkl.Javautok = int.Parse(jj[1]);
    kkl.Munkaora = int.Parse(jj[2]);
    kkl.GaranJav = int.Parse(jj[3]);
    dddd.Add(kkl);
    x=kkl.Munkaora*4000+kkl.Javautok*5000;
    if(kkl.Javautok>=6 && kkl.GaranJav <= 1)
    {
        x += 15000;
    }
    else if (kkl.GaranJav<=2)
    {
        x -= 10000;
    }
    kkl.Keresj = x;

    nhj += kkl.Munkaora;
    i += c.Count();
    hj += x;

    if (u<x)
    {

    }
}

    Console.WriteLine("Szereplők elszámolása:");
foreach (szerelo zov in dddd)
{
    Console.WriteLine($"{zov.Nev}: {zov.Javautok} autó, {zov.Munkaora} óra (Garanciális: {zov.GaranJav}) - Munkabér: {zov.Keresj} Ft");

}



Console.ForegroundColor = ConsoleColor.Black;