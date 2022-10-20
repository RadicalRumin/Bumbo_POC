// See https://aka.ms/new-console-template for more information

using BumboDB;
using BumboDB.EntityModels;
using Microsoft.EntityFrameworkCore;

var context = new BumboContext();

Console.Out.WriteLine("Hoeveel klanten worden er verwacht?");
int klanten = int.Parse(Console.ReadLine());

Console.Out.WriteLine("Hoeveel coli worden er verwacht?");
int coli = int.Parse(Console.ReadLine());

// Do prognose calculate
var pInputColi = new PrognoseInput()
{
    Datum = DateTime.Now,
    EenheidType = "Coli",
    Waarde = coli
};

var pInputKlanten = new PrognoseInput()
{
    Datum = DateTime.Now,
    EenheidType = "Klanten",
    Waarde = klanten
};