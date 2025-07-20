using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive;

internal class Locomotive
{
    private Person driver;

    public string Driver
    {
        get { return driver; }
        set { driver = value; }
    }
    private Engine engine;

    private Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }
    public Locomotive()
    {
        // Výchozí konstruktor
    }
    public Locomotive(Person driver, Engine engine)
    {
        this.driver = driver;
        this.engine = engine;
    }

    public override string ToString()
    {
        return "něco";
    }


    public static void Run()
    {
        Console.WriteLine("Spouštím program Locomotive...");
        // Zde by mohl být kód pro spuštění programu Locomotive
        // Například inicializace, načtení dat, atd.
        Console.WriteLine("Program Locomotive byl úspěšně spuštěn.");
    }
}
