// See https://aka.ms/new-console-template for more information

using BumboDB;
using Microsoft.EntityFrameworkCore;

var context = new BumboContext();

var norms = await context.Normeringen
    .Include(n => n.Activiteit)
    .Include(n => n.Eenheid)
    .Include(n => n.Filiaal)
    .ToListAsync();
    
Console.Out.WriteLine("Hoeveel klanten worden er verwacht?");
int klanten = int.Parse(Console.ReadLine());

Console.Out.WriteLine("Hoeveel coli worden er verwacht?");
int coli = int.Parse(Console.ReadLine());


foreach (var norm in norms)
{
    if (norm.Eenheid.EenheidType == "Coli")
    {
        Console.Out.WriteLine($"{norm?.Activiteit.Beschrijving} zal {coli / norm?.AantalPerUur} uur duren");
    }
    else if (norm.Eenheid.EenheidType == "Klanten")
    {
        Console.Out.WriteLine($"{norm?.Activiteit.Beschrijving} zal {klanten / norm?.AantalPerUur} uur duren");

    }
    else if (norm.Eenheid.EenheidType == "Meter")
    {
        Console.Out.WriteLine($"Spiegelen zal {norm?.Filiaal.MeterSchappen / norm?.AantalPerUur} uur duren");
    }
   
}