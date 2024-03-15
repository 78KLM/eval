using eval;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------fiche automobile------------");
        Automobile a1 = new Automobile(12, "twingo2", "Renault",1,5,12600);
        Console.WriteLine(a1.AutoInfo());
        Console.WriteLine("--------------------------------------------");
        Automobile a2 = new Automobile();
        a2.Numero = 2;
        a2.Modele = "classe A";
        a2.Marque = "mercedes";
        a2.Categorie = 3;
        a2.PuissanceFiscle = 10;
        a2.KmParcouru = 15000;
        Console.WriteLine(a2.AutoInfo());
        Console.ReadLine();
    }
}